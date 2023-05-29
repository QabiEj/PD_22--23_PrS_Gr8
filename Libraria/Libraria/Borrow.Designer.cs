namespace Libraria
{
    partial class Borrow
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.editBorrower = new System.Windows.Forms.Button();
            this.borrower = new System.Windows.Forms.ComboBox();
            this.editBook = new System.Windows.Forms.Button();
            this.book = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.editBorrower);
            this.groupBox1.Controls.Add(this.borrower);
            this.groupBox1.Controls.Add(this.editBook);
            this.groupBox1.Controls.Add(this.book);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(43, 80);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(211, 23);
            this.date.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date";
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
            // borrower
            // 
            this.borrower.FormattingEnabled = true;
            this.borrower.Location = new System.Drawing.Point(6, 51);
            this.borrower.Name = "borrower";
            this.borrower.Size = new System.Drawing.Size(217, 23);
            this.borrower.TabIndex = 4;
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
            // book
            // 
            this.book.FormattingEnabled = true;
            this.book.Location = new System.Drawing.Point(6, 22);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(217, 23);
            this.book.TabIndex = 2;
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
            // Borrow
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button submit;
        private Button editBook;
        private Label label1;
        private Button editBorrower;
        private DateTimePicker date;
        private ComboBox borrower;
        private ComboBox book;
    }
}