namespace Libraria
{
    partial class UpdateBook
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
            this.author = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.author);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Controls.Add(this.isbn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(6, 80);
            this.author.Name = "author";
            this.author.PlaceholderText = "Author(s)";
            this.author.Size = new System.Drawing.Size(248, 23);
            this.author.TabIndex = 2;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(6, 51);
            this.title.Name = "title";
            this.title.PlaceholderText = "Title";
            this.title.Size = new System.Drawing.Size(248, 23);
            this.title.TabIndex = 1;
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(6, 22);
            this.isbn.MaxLength = 10;
            this.isbn.Name = "isbn";
            this.isbn.PlaceholderText = "International Standard Book Number 10";
            this.isbn.ReadOnly = true;
            this.isbn.Size = new System.Drawing.Size(248, 23);
            this.isbn.TabIndex = 0;
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
            // UpdateBook
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UpdateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox title;
        private TextBox isbn;
        private Button submit;
        private TextBox author;
    }
}