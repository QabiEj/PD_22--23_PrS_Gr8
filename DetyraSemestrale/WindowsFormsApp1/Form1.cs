using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using NAudio.Wave;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoCaptureDevice;
        private TcpListener tcpListener;
        private TcpClient tcpClient;
        private NetworkStream networkStream;
        private Thread videoStreamingThread;
        private Thread audioStreamingThread;
        private Thread audioReceivingThread;
        private bool isStreaming;
        // Add these as member variables of the Form1 class
        private WaveInEvent waveSource = null;
        private WaveFileWriter waveFile = null;

        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
            isStreaming = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video devices found.");
                return;
            }

            comboBox1.Items.Clear(); // Clear existing items

            foreach (FilterInfo dev in videoDevices)
            {
                comboBox1.Items.Add(dev.Name);
            }

            comboBox1.SelectedIndex = 0; // Set the selected index after adding items

            videoCaptureDevice = new VideoCaptureDevice(videoDevices[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

            StartServer();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (isStreaming)
            {
                // Convert the video frame to byte array
                Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
                byte[] frameBytes = ImageToByteArray(frame);

                // Send the frame bytes to the client
                if (networkStream.CanWrite)
                {
                    networkStream.Write(frameBytes, 0, frameBytes.Length);
                    networkStream.Flush();
                }
            }

            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Clone the new frame
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

            if (isStreaming)
            {
                try
                {
                    // Convert the frame to a byte array
                    byte[] frameBytes = ImageToByteArray(frame);

                    // Send the frame dimensions and bytes to the client
                    if (networkStream != null && networkStream.CanWrite)
                    {
                        // Send frame dimensions (width and height)
                        byte[] widthBytes = BitConverter.GetBytes(frame.Width);
                        byte[] heightBytes = BitConverter.GetBytes(frame.Height);

                        networkStream.Write(widthBytes, 0, widthBytes.Length);
                        networkStream.Write(heightBytes, 0, heightBytes.Length);

                        // Send frame bytes
                        networkStream.Write(frameBytes, 0, frameBytes.Length);
                        networkStream.Flush();
                    }
                }
                catch (Exception ex)
                {
                    // Handle or log exception
                    Console.WriteLine($"Error while streaming video: {ex.Message}");
                }
            }

            // Dispose the frame object to free up system resources
            frame.Dispose();

            // Update the picture box on the UI thread
            if (pictureBox1.InvokeRequired)
            {
                pictureBox1.Invoke(new Action(() => pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone()));
            }
            else
            {
                pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopServer();

            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
                videoCaptureDevice = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StopServer();

            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
                videoCaptureDevice = null;
                pictureBox1.Image = null; // Clear the picture box
            }
        }

        private void StartServer()
        {
            tcpListener = new TcpListener(IPAddress.Any, 8080);
            tcpListener.Start();

            videoStreamingThread = new Thread(StreamVideo);
            videoStreamingThread.Start();

            audioStreamingThread = new Thread(StreamAudio);
            audioStreamingThread.Start();

            
        }


        private void StopServer()
        {
            isStreaming = false;

            if (tcpListener != null)
            {
                tcpListener.Stop();
                tcpListener = null;
            }

            if (tcpClient != null)
            {
                tcpClient.Close();
                tcpClient = null;
            }

            if (networkStream != null)
            {
                networkStream.Close();
                networkStream = null;
            }

            if (videoStreamingThread != null && videoStreamingThread.IsAlive)
            {
                videoStreamingThread.Join();
                videoStreamingThread = null;
            }

            if (audioStreamingThread != null && audioStreamingThread.IsAlive)
            {
                audioStreamingThread.Join();
                audioStreamingThread = null;
            }

            if (audioReceivingThread != null && audioReceivingThread.IsAlive)
            {
                audioReceivingThread.Join();
                audioReceivingThread = null;
            }
        }


        private void StreamVideo()
        {
            while (true)
            {
                tcpClient = tcpListener.AcceptTcpClient();
                networkStream = tcpClient.GetStream();
                isStreaming = true;

                while (isStreaming)
                {
                    // Keep streaming video frames to the client
                    Thread.Sleep(10);
                }
            }
        }
        private void StreamAudio()
        {
            string filePath = @"C:\temp\test.wav";

            byte[] audioBytes = File.ReadAllBytes(filePath);

            try
            {
                if (networkStream != null && networkStream.CanWrite)
                {
                    // Write the length of the audio data as a 4-byte header
                    int audioLength = audioBytes.Length;
                    byte[] lengthBytes = BitConverter.GetBytes(audioLength);
                    networkStream.Write(lengthBytes, 0, lengthBytes.Length);

                    // Write the audio data
                    networkStream.Write(audioBytes, 0, audioBytes.Length);
                    networkStream.Flush();
                }
                else
                {
                    // Handle the situation where the network stream is null or not writable
                    Console.WriteLine("Network stream is null or cannot write.");
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately (e.g., log, display error message)
                Console.WriteLine($"Error while streaming audio: {ex.Message}");
            }
        }




        private byte[] ImageToByteArray(Image image)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }
        private void StartRecordingAudio()
        {
            waveSource = new WaveInEvent();
            waveSource.WaveFormat = new WaveFormat(44100, 1);

            waveSource.DataAvailable += waveSource_DataAvailable;
            waveSource.RecordingStopped += waveSource_RecordingStopped;

            waveFile = new WaveFileWriter(@"C:\temp\test.wav", waveSource.WaveFormat);

            waveSource.StartRecording();
        }

        private void StopRecordingAudio()
        {
            if (waveSource != null)
            {
                waveSource.StopRecording();
                waveSource.Dispose();
                waveSource = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose();
                waveFile = null;
            }
        }

        private void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                waveFile.Flush();
            }
        }

        private void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (waveSource != null)
            {
                waveSource.Dispose();
                waveSource = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose();
                waveFile = null;
            }
        }

        // Create a new Button click event to start recording


        private void button3_Click(object sender, EventArgs e)
        {

            StartRecordingAudio();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StopRecordingAudio();
        }
        


    }
}