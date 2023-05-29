namespace Libraria
{
    partial class Form1
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
            this.Server = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(31, 44);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(133, 63);
            this.Server.TabIndex = 0;
            this.Server.Text = "Server";
            this.Server.UseVisualStyleBackColor = true;
            this.Server.Click += new System.EventHandler(this.Server_Click);
            // 
            // Client
            // 
            this.Client.Location = new System.Drawing.Point(170, 44);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(135, 63);
            this.Client.TabIndex = 1;
            this.Client.Text = "Client";
            this.Client.UseVisualStyleBackColor = true;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 150);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Server);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Server;
        private Button Client;
    }
}