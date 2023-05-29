using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

// For audio capturing
using NAudio.Wave;
namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private VideoCaptureDevice videoSource;
        private WaveInEvent audioSource;
        private TcpClient tcpClient;
        private NetworkStream networkStream;
        private Thread streamingThread;
        private Thread audioStreamingThread;
        private Thread audioReceivingThread;
        private bool isStreaming;

        public Form1()
        {
            InitializeComponent();

            // Set up video capture device
            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                throw new Exception("No video devices found.");
            }
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);

            // Set up audio capture device
            audioSource = new WaveInEvent();
            audioSource.DataAvailable += new EventHandler<WaveInEventArgs>(audioSource_DataAvailable);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Connect to the server
                tcpClient = new TcpClient("127.0.0.1", 8080); // change to the server's IP address
                networkStream = tcpClient.GetStream();

                // Start the streaming threads
                isStreaming = true;
                streamingThread = new Thread(StreamVideo);
                streamingThread.Start();
                audioStreamingThread = new Thread(StreamAudio);
                audioStreamingThread.Start();

                audioReceivingThread = new Thread(ReceiveAudio);
                audioReceivingThread.Start();
            }
            catch (Exception ex)
            {
                // Show the error message
                MessageBox.Show($"Error while connecting to the server: {ex.Message}");
            }
        }

        private void StreamVideo()
        {
            try
            {
                while (isStreaming)
                {
                    // Read the frame dimensions
                    byte[] widthBytes = ReadBytes(4);
                    byte[] heightBytes = ReadBytes(4);

                    // Reverse the bytes if the system architecture is little-endian
                    if (BitConverter.IsLittleEndian)
                    {
                        Array.Reverse(widthBytes);
                        Array.Reverse(heightBytes);
                    }

                    int width = BitConverter.ToInt32(widthBytes, 0);
                    int height = BitConverter.ToInt32(heightBytes, 0);

                    checked
                    {
                        // Ensure the frame size is not excessively large
                        long frameSize = (long)width * height * 3; // 3 bytes per pixel for RGB
                        if (frameSize > int.MaxValue)
                        {
                            throw new Exception("Frame size exceeds maximum allowable size.");
                        }

                        // Read the frame bytes
                        byte[] frameBytes = ReadBytes((int)frameSize);

                        // Create a Bitmap object from the frame bytes
                        using (var ms = new MemoryStream(frameBytes))
                        {
                            Bitmap frame = new Bitmap(ms);
                            pictureBox1.Image = frame;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Show the error message
                MessageBox.Show($"Error while receiving video: {ex.Message}");
            }
        }



        private byte[] ReadBytes(int count)
        {
            byte[] bytes = new byte[count];
            int bytesRead = 0;

            while (bytesRead < count)
            {
                int read = networkStream.Read(bytes, bytesRead, count - bytesRead);
                if (read == 0)
                {
                    // No data available, the connection may be closed
                    break;
                }
                bytesRead += read;
            }

            return bytes;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the streaming threads and close the connection
            isStreaming = false;

            if (streamingThread != null && streamingThread.IsAlive)
            {
                streamingThread.Join();
                streamingThread = null;
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

            if (networkStream != null)
            {
                networkStream.Close();
                networkStream = null;
            }

            if (tcpClient != null)
            {
                tcpClient.Close();
                tcpClient = null;
            }

            // Cancel the form closing event
            e.Cancel = true;
        }

        private void ReceiveAudio()
        {
            try
            {
                // Read the length of the audio data from the client
                byte[] lengthBytes = ReadBytes(4);
                int audioLength = BitConverter.ToInt32(lengthBytes, 0);

                // Create a buffer to hold the received audio data
                byte[] audioBytes = new byte[audioLength];
                int totalBytesRead = 0;

                // Loop until all the audio data is received
                while (totalBytesRead < audioLength && isStreaming)
                {
                    int remainingBytes = audioLength - totalBytesRead;
                    int bytesRead = networkStream.Read(audioBytes, totalBytesRead, remainingBytes);
                    if (bytesRead > 0)
                    {
                        totalBytesRead += bytesRead;
                    }
                    else
                    {
                        // No data available, the connection may be closed
                        break;
                    }
                }

                // Save the received audio data to a file
                string filePath = @"C:\temp\received_client_audio.wav";
                File.WriteAllBytes(filePath, audioBytes);
            }
            catch (Exception ex)
            {
                // Show the error message
                MessageBox.Show($"Error while receiving audio: {ex.Message}");
            }
        }

        private void StreamAudio()
        {
            try
            {
                string filePath = @"C:\temp\client_audio.wav";

                byte[] audioBytes = File.ReadAllBytes(filePath);

                if (networkStream.CanWrite)
                {
                    // Write the length of the audio data as a 4-byte header
                    int audioLength = audioBytes.Length;
                    byte[] lengthBytes = BitConverter.GetBytes(audioLength);
                    networkStream.Write(lengthBytes, 0, lengthBytes.Length);

                    // Write the audio data
                    networkStream.Write(audioBytes, 0, audioBytes.Length);
                    networkStream.Flush();
                }
            }
            catch (Exception ex)
            {
                // Show the error message
                MessageBox.Show($"Error while streaming audio: {ex.Message}");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Stop the streaming threads and close the connection
            isStreaming = false;

            if (streamingThread != null && streamingThread.IsAlive)
            {
                streamingThread.Join();
                streamingThread = null;
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

            if (networkStream != null)
            {
                networkStream.Close();
                networkStream = null;
            }

            if (tcpClient != null)
            {
                tcpClient.Close();
                tcpClient = null;
            }
        }
        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // eventArgs.Frame contains the current video frame.
            // You can display it in a PictureBox, encode it, and send it to the server.
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void audioSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            // e.Buffer contains the current audio data.
            // You can encode it and send it to the server.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            videoSource.Start();
            audioSource.StartRecording();
        }

       

        private void button4_Click_1(object sender, EventArgs e)
        {

            videoSource.SignalToStop();
            audioSource.StopRecording();
        }
    }
}
