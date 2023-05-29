namespace Libraria
{
    partial class Form2
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
            this.Client = new System.Windows.Forms.Button();
            this.Server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Client
            // 
            this.Client.Location = new System.Drawing.Point(197, 62);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(135, 63);
            this.Client.TabIndex = 3;
            this.Client.Text = "Client";
            this.Client.UseVisualStyleBackColor = true;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(58, 62);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(133, 63);
            this.Server.TabIndex = 2;
            this.Server.Text = "Server";
            this.Server.UseVisualStyleBackColor = true;
            this.Server.Click += new System.EventHandler(this.Server_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 186);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Server);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Client;
        private Button Server;
    }
}