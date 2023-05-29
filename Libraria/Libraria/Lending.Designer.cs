namespace Libraria
{
    partial class Lending
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
            this.label1 = new System.Windows.Forms.Label();
            this.book = new System.Windows.Forms.TextBox();
            this.borrower = new System.Windows.Forms.TextBox();
            this.editBook = new System.Windows.Forms.Button();
            this.editBorrower = new System.Windows.Forms.Button();
            this.dateBorrowed = new System.Windows.Forms.TextBox();
            this.dateReturned = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateReturned);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateBorrowed);
            this.groupBox1.Controls.Add(this.borrower);
            this.groupBox1.Controls.Add(this.book);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.editBorrower);
            this.groupBox1.Controls.Add(this.editBook);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date Borrowed";
            // 
            // book
            // 
            this.book.Location = new System.Drawing.Point(6, 22);
            this.book.Name = "book";
            this.book.PlaceholderText = "Book";
            this.book.ReadOnly = true;
            this.book.Size = new System.Drawing.Size(217, 23);
            this.book.TabIndex = 6;
            // 
            // borrower
            // 
            this.borrower.Location = new System.Drawing.Point(6, 51);
            this.borrower.Name = "borrower";
            this.borrower.PlaceholderText = "Borrower";
            this.borrower.ReadOnly = true;
            this.borrower.Size = new System.Drawing.Size(217, 23);
            this.borrower.TabIndex = 7;
            // 
            // editBook
            // 
            this.editBook.Location = new System.Drawing.Point(229, 22);
            this.editBook.Name = "editBook";
            this.editBook.Size = new System.Drawing.Size(25, 23);
            this.editBook.TabIndex = 3;
            this.editBook.Text = "✎";
            this.editBook.UseVisualStyleBackColor = true;
            this.editBook.Click += new System.EventHandler(this.EditBook);
            // 
            // editBorrower
            // 
            this.editBorrower.Location = new System.Drawing.Point(229, 51);
            this.editBorrower.Name = "editBorrower";
            this.editBorrower.Size = new System.Drawing.Size(25, 23);
            this.editBorrower.TabIndex = 5;
            this.editBorrower.Text = "✎";
            this.editBorrower.UseVisualStyleBackColor = true;
            this.editBorrower.Click += new System.EventHandler(this.EditBorrower);
            // 
            // dateBorrowed
            // 
            this.dateBorrowed.Location = new System.Drawing.Point(93, 80);
            this.dateBorrowed.Name = "dateBorrowed";
            this.dateBorrowed.PlaceholderText = "Date Borrowed";
            this.dateBorrowed.ReadOnly = true;
            this.dateBorrowed.Size = new System.Drawing.Size(161, 23);
            this.dateBorrowed.TabIndex = 8;
            // 
            // dateReturned
            // 
            this.dateReturned.Location = new System.Drawing.Point(93, 109);
            this.dateReturned.Name = "dateReturned";
            this.dateReturned.PlaceholderText = "Date Returned";
            this.dateReturned.ReadOnly = true;
            this.dateReturned.Size = new System.Drawing.Size(161, 23);
            this.dateReturned.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date Returned";
            // 
            // Lending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Lending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lending";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox borrower;
        private TextBox book;
        private TextBox dateReturned;
        private Label label2;
        private TextBox dateBorrowed;
        private Button editBorrower;
        private Button editBook;
    }
}