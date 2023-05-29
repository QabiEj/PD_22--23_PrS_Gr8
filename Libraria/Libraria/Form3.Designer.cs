namespace Libraria
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Server = new Button();
            Client = new Button();
            SuspendLayout();
            // 
            // Server
            // 
            Server.Location = new Point(51, 54);
            Server.Margin = new Padding(2);
            Server.Name = "Server";
            Server.Size = new Size(106, 50);
            Server.TabIndex = 3;
            Server.Text = "Server";
            Server.UseVisualStyleBackColor = true;
            Server.Click += Server_Click;
            // 
            // Client
            // 
            Client.Location = new Point(161, 54);
            Client.Margin = new Padding(2);
            Client.Name = "Client";
            Client.Size = new Size(108, 50);
            Client.TabIndex = 4;
            Client.Text = "Client";
            Client.UseVisualStyleBackColor = true;
            Client.Click += Client_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 156);
            Controls.Add(Client);
            Controls.Add(Server);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button Server;
        private Button Client;
    }
}