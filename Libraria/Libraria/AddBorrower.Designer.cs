namespace Libraria
{
    partial class AddBorrower
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.familyName = new System.Windows.Forms.TextBox();
            this.givenName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.familyName);
            this.groupBox1.Controls.Add(this.givenName);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // familyName
            // 
            this.familyName.Location = new System.Drawing.Point(6, 80);
            this.familyName.Name = "familyName";
            this.familyName.PlaceholderText = "Family Name";
            this.familyName.Size = new System.Drawing.Size(248, 23);
            this.familyName.TabIndex = 2;
            // 
            // givenName
            // 
            this.givenName.Location = new System.Drawing.Point(6, 51);
            this.givenName.Name = "givenName";
            this.givenName.PlaceholderText = "Given Name";
            this.givenName.Size = new System.Drawing.Size(248, 23);
            this.givenName.TabIndex = 1;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(6, 22);
            this.email.Name = "email";
            this.email.PlaceholderText = "Email";
            this.email.Size = new System.Drawing.Size(248, 23);
            this.email.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(12, 129);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(260, 40);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit);
            // 
            // AddBorrower
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddBorrower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Borrower";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox givenName;
        private TextBox email;
        private Button submit;
        private TextBox familyName;
    }
}