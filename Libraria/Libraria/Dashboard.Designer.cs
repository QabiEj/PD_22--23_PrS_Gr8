namespace Libraria
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            account = new ToolStripMenuItem();
            signOut = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            selectionAll = new ToolStripMenuItem();
            selectionClear = new ToolStripMenuItem();
            selectionInvert = new ToolStripMenuItem();
            view = new ToolStripMenuItem();
            refresh = new ToolStripMenuItem();
            help = new ToolStripMenuItem();
            about = new ToolStripMenuItem();
            tabControl = new TabControl();
            inventory = new TabPage();
            button2 = new Button();
            vchat = new Button();
            books = new DataGridView();
            selectionBook = new DataGridViewCheckBoxColumn();
            isbn = new DataGridViewTextBoxColumn();
            title = new DataGridViewTextBoxColumn();
            author = new DataGridViewTextBoxColumn();
            available = new DataGridViewCheckBoxColumn();
            borrowBook = new Button();
            updateBook = new Button();
            archiveBook = new Button();
            addBook = new Button();
            borrowersTab = new TabPage();
            borrowers = new DataGridView();
            selectionBorrower = new DataGridViewCheckBoxColumn();
            email = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            borrowedBook = new DataGridViewTextBoxColumn();
            updateBorrower = new Button();
            archiveBorrower = new Button();
            addBorrower = new Button();
            circulation = new TabPage();
            viewCirculation = new Button();
            returnCirculation = new Button();
            circulations = new DataGridView();
            selectionCirculation = new DataGridViewCheckBoxColumn();
            id = new DataGridViewTextBoxColumn();
            book = new DataGridViewTextBoxColumn();
            borrower = new DataGridViewTextBoxColumn();
            dateBorrowed = new DataGridViewTextBoxColumn();
            dateReturned = new DataGridViewTextBoxColumn();
            filter = new Button();
            keyword = new TextBox();
            button1 = new Button();
            menu.SuspendLayout();
            tabControl.SuspendLayout();
            inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)books).BeginInit();
            borrowersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)borrowers).BeginInit();
            circulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circulations).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { account, toolStripMenuItem1, view, help });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(7, 2, 0, 2);
            menu.Size = new Size(914, 28);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // account
            // 
            account.DropDownItems.AddRange(new ToolStripItem[] { signOut });
            account.Name = "account";
            account.Size = new Size(77, 24);
            account.Text = "Account";
            // 
            // signOut
            // 
            signOut.Name = "signOut";
            signOut.Size = new Size(147, 26);
            signOut.Text = "Sign out";
            signOut.Click += SignOut;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(49, 24);
            toolStripMenuItem1.Text = "Edit";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { selectionAll, selectionClear, selectionInvert });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(153, 26);
            toolStripMenuItem2.Text = "Selection";
            // 
            // selectionAll
            // 
            selectionAll.Name = "selectionAll";
            selectionAll.ShortcutKeys = Keys.Control | Keys.A;
            selectionAll.Size = new Size(175, 26);
            selectionAll.Text = "All";
            selectionAll.Click += SelectAll;
            // 
            // selectionClear
            // 
            selectionClear.Name = "selectionClear";
            selectionClear.Size = new Size(175, 26);
            selectionClear.Text = "Clear";
            selectionClear.Click += ClearSelection;
            // 
            // selectionInvert
            // 
            selectionInvert.Name = "selectionInvert";
            selectionInvert.ShortcutKeys = Keys.Control | Keys.I;
            selectionInvert.Size = new Size(175, 26);
            selectionInvert.Text = "Invert";
            selectionInvert.Click += InvertSelection;
            // 
            // view
            // 
            view.DropDownItems.AddRange(new ToolStripItem[] { refresh });
            view.Name = "view";
            view.Size = new Size(55, 24);
            view.Text = "View";
            // 
            // refresh
            // 
            refresh.Name = "refresh";
            refresh.ShortcutKeys = Keys.F5;
            refresh.Size = new Size(165, 26);
            refresh.Text = "Refresh";
            refresh.Click += Refresh;
            // 
            // help
            // 
            help.DropDownItems.AddRange(new ToolStripItem[] { about });
            help.Name = "help";
            help.Size = new Size(55, 24);
            help.Text = "Help";
            // 
            // about
            // 
            about.Name = "about";
            about.Size = new Size(133, 26);
            about.Text = "About";
            about.Click += About;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(inventory);
            tabControl.Controls.Add(borrowersTab);
            tabControl.Controls.Add(circulation);
            tabControl.Location = new Point(14, 76);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(887, 508);
            tabControl.TabIndex = 1;
            // 
            // inventory
            // 
            inventory.Controls.Add(button1);
            inventory.Controls.Add(button2);
            inventory.Controls.Add(vchat);
            inventory.Controls.Add(books);
            inventory.Controls.Add(borrowBook);
            inventory.Controls.Add(updateBook);
            inventory.Controls.Add(archiveBook);
            inventory.Controls.Add(addBook);
            inventory.Location = new Point(4, 29);
            inventory.Margin = new Padding(3, 4, 3, 4);
            inventory.Name = "inventory";
            inventory.Padding = new Padding(3, 4, 3, 4);
            inventory.Size = new Size(879, 475);
            inventory.TabIndex = 0;
            inventory.Text = "Inventory";
            inventory.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(480, 409);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(124, 54);
            button2.TabIndex = 9;
            button2.Text = "Chat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // vchat
            // 
            vchat.Location = new Point(363, 409);
            vchat.Margin = new Padding(2, 2, 2, 2);
            vchat.Name = "vchat";
            vchat.Size = new Size(113, 54);
            vchat.TabIndex = 8;
            vchat.Text = "Vchat";
            vchat.UseVisualStyleBackColor = true;
            vchat.Click += vchat_Click;
            // 
            // books
            // 
            books.AllowUserToAddRows = false;
            books.AllowUserToDeleteRows = false;
            books.AllowUserToOrderColumns = true;
            books.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            books.BackgroundColor = SystemColors.ControlLight;
            books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            books.Columns.AddRange(new DataGridViewColumn[] { selectionBook, isbn, title, author, available });
            books.Location = new Point(7, 8);
            books.Margin = new Padding(3, 4, 3, 4);
            books.Name = "books";
            books.RowHeadersVisible = false;
            books.RowHeadersWidth = 62;
            books.RowTemplate.Height = 25;
            books.Size = new Size(864, 394);
            books.TabIndex = 7;
            books.CellContentClick += books_CellContentClick;
            // 
            // selectionBook
            // 
            selectionBook.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            selectionBook.FalseValue = "0";
            selectionBook.HeaderText = "Selection";
            selectionBook.IndeterminateValue = "2";
            selectionBook.MinimumWidth = 8;
            selectionBook.Name = "selectionBook";
            selectionBook.TrueValue = "1";
            selectionBook.Width = 76;
            // 
            // isbn
            // 
            isbn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            isbn.HeaderText = "ISBN";
            isbn.MinimumWidth = 8;
            isbn.Name = "isbn";
            isbn.ReadOnly = true;
            isbn.Width = 231;
            // 
            // title
            // 
            title.HeaderText = "Title";
            title.MinimumWidth = 8;
            title.Name = "title";
            title.ReadOnly = true;
            // 
            // author
            // 
            author.HeaderText = "Author(s)";
            author.MinimumWidth = 8;
            author.Name = "author";
            author.ReadOnly = true;
            // 
            // available
            // 
            available.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            available.FalseValue = "0";
            available.HeaderText = "Available";
            available.IndeterminateValue = "2";
            available.MinimumWidth = 8;
            available.Name = "available";
            available.ReadOnly = true;
            available.TrueValue = "1";
            available.Width = 77;
            // 
            // borrowBook
            // 
            borrowBook.Location = new Point(253, 410);
            borrowBook.Margin = new Padding(3, 4, 3, 4);
            borrowBook.Name = "borrowBook";
            borrowBook.Size = new Size(105, 54);
            borrowBook.TabIndex = 6;
            borrowBook.Text = "Borrow";
            borrowBook.UseVisualStyleBackColor = true;
            borrowBook.Click += Borrow;
            // 
            // updateBook
            // 
            updateBook.Location = new Point(140, 410);
            updateBook.Margin = new Padding(3, 4, 3, 4);
            updateBook.Name = "updateBook";
            updateBook.Size = new Size(107, 54);
            updateBook.TabIndex = 5;
            updateBook.Text = "Update";
            updateBook.UseVisualStyleBackColor = true;
            updateBook.Click += UpdateBook;
            // 
            // archiveBook
            // 
            archiveBook.Location = new Point(7, 410);
            archiveBook.Margin = new Padding(3, 4, 3, 4);
            archiveBook.Name = "archiveBook";
            archiveBook.Size = new Size(127, 54);
            archiveBook.TabIndex = 4;
            archiveBook.Text = "Archive";
            archiveBook.UseVisualStyleBackColor = true;
            archiveBook.Click += ArchiveBook;
            // 
            // addBook
            // 
            addBook.Location = new Point(736, 409);
            addBook.Margin = new Padding(3, 4, 3, 4);
            addBook.Name = "addBook";
            addBook.Size = new Size(135, 54);
            addBook.TabIndex = 3;
            addBook.Text = "Add";
            addBook.UseVisualStyleBackColor = true;
            addBook.Click += AddBook;
            // 
            // borrowersTab
            // 
            borrowersTab.Controls.Add(borrowers);
            borrowersTab.Controls.Add(updateBorrower);
            borrowersTab.Controls.Add(archiveBorrower);
            borrowersTab.Controls.Add(addBorrower);
            borrowersTab.Location = new Point(4, 29);
            borrowersTab.Margin = new Padding(3, 4, 3, 4);
            borrowersTab.Name = "borrowersTab";
            borrowersTab.Padding = new Padding(3, 4, 3, 4);
            borrowersTab.Size = new Size(879, 475);
            borrowersTab.TabIndex = 1;
            borrowersTab.Text = "Borrowers";
            borrowersTab.UseVisualStyleBackColor = true;
            // 
            // borrowers
            // 
            borrowers.AllowUserToAddRows = false;
            borrowers.AllowUserToDeleteRows = false;
            borrowers.AllowUserToOrderColumns = true;
            borrowers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            borrowers.BackgroundColor = SystemColors.ControlLight;
            borrowers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            borrowers.Columns.AddRange(new DataGridViewColumn[] { selectionBorrower, email, fullName, borrowedBook });
            borrowers.Location = new Point(7, 8);
            borrowers.Margin = new Padding(3, 4, 3, 4);
            borrowers.Name = "borrowers";
            borrowers.RowHeadersVisible = false;
            borrowers.RowHeadersWidth = 62;
            borrowers.RowTemplate.Height = 25;
            borrowers.Size = new Size(864, 394);
            borrowers.TabIndex = 8;
            borrowers.CellContentClick += borrowers_CellContentClick;
            // 
            // selectionBorrower
            // 
            selectionBorrower.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            selectionBorrower.FalseValue = "0";
            selectionBorrower.HeaderText = "Selection";
            selectionBorrower.IndeterminateValue = "2";
            selectionBorrower.MinimumWidth = 8;
            selectionBorrower.Name = "selectionBorrower";
            selectionBorrower.TrueValue = "1";
            selectionBorrower.Width = 76;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            email.HeaderText = "Email";
            email.MinimumWidth = 8;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 231;
            // 
            // fullName
            // 
            fullName.HeaderText = "Full Name";
            fullName.MinimumWidth = 8;
            fullName.Name = "fullName";
            fullName.ReadOnly = true;
            // 
            // borrowedBook
            // 
            borrowedBook.HeaderText = "Borrowed Book(s)";
            borrowedBook.MinimumWidth = 8;
            borrowedBook.Name = "borrowedBook";
            borrowedBook.ReadOnly = true;
            // 
            // updateBorrower
            // 
            updateBorrower.Location = new Point(139, 410);
            updateBorrower.Margin = new Padding(3, 4, 3, 4);
            updateBorrower.Name = "updateBorrower";
            updateBorrower.Size = new Size(126, 54);
            updateBorrower.TabIndex = 7;
            updateBorrower.Text = "Update";
            updateBorrower.UseVisualStyleBackColor = true;
            updateBorrower.Click += UpdateBorrower;
            // 
            // archiveBorrower
            // 
            archiveBorrower.Location = new Point(7, 410);
            archiveBorrower.Margin = new Padding(3, 4, 3, 4);
            archiveBorrower.Name = "archiveBorrower";
            archiveBorrower.Size = new Size(126, 54);
            archiveBorrower.TabIndex = 6;
            archiveBorrower.Text = "Archive";
            archiveBorrower.UseVisualStyleBackColor = true;
            archiveBorrower.Click += ArchiveBorrower;
            // 
            // addBorrower
            // 
            addBorrower.Location = new Point(271, 410);
            addBorrower.Margin = new Padding(3, 4, 3, 4);
            addBorrower.Name = "addBorrower";
            addBorrower.Size = new Size(600, 54);
            addBorrower.TabIndex = 4;
            addBorrower.Text = "Add";
            addBorrower.UseVisualStyleBackColor = true;
            addBorrower.Click += AddBorrower;
            // 
            // circulation
            // 
            circulation.Controls.Add(viewCirculation);
            circulation.Controls.Add(returnCirculation);
            circulation.Controls.Add(circulations);
            circulation.Location = new Point(4, 29);
            circulation.Margin = new Padding(3, 4, 3, 4);
            circulation.Name = "circulation";
            circulation.Padding = new Padding(3, 4, 3, 4);
            circulation.Size = new Size(879, 475);
            circulation.TabIndex = 2;
            circulation.Text = "Circulation";
            circulation.UseVisualStyleBackColor = true;
            // 
            // viewCirculation
            // 
            viewCirculation.Location = new Point(7, 410);
            viewCirculation.Margin = new Padding(3, 4, 3, 4);
            viewCirculation.Name = "viewCirculation";
            viewCirculation.Size = new Size(126, 54);
            viewCirculation.TabIndex = 10;
            viewCirculation.Text = "View";
            viewCirculation.UseVisualStyleBackColor = true;
            viewCirculation.Click += ViewCirculation;
            // 
            // returnCirculation
            // 
            returnCirculation.Location = new Point(139, 410);
            returnCirculation.Margin = new Padding(3, 4, 3, 4);
            returnCirculation.Name = "returnCirculation";
            returnCirculation.Size = new Size(731, 54);
            returnCirculation.TabIndex = 9;
            returnCirculation.Text = "Return";
            returnCirculation.UseVisualStyleBackColor = true;
            returnCirculation.Click += ReturnCirculation;
            // 
            // circulations
            // 
            circulations.AllowUserToAddRows = false;
            circulations.AllowUserToDeleteRows = false;
            circulations.AllowUserToOrderColumns = true;
            circulations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            circulations.BackgroundColor = SystemColors.ControlLight;
            circulations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            circulations.Columns.AddRange(new DataGridViewColumn[] { selectionCirculation, id, book, borrower, dateBorrowed, dateReturned });
            circulations.Location = new Point(7, 8);
            circulations.Margin = new Padding(3, 4, 3, 4);
            circulations.Name = "circulations";
            circulations.RowHeadersVisible = false;
            circulations.RowHeadersWidth = 62;
            circulations.RowTemplate.Height = 25;
            circulations.Size = new Size(864, 394);
            circulations.TabIndex = 8;
            // 
            // selectionCirculation
            // 
            selectionCirculation.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            selectionCirculation.FalseValue = "0";
            selectionCirculation.HeaderText = "Selection";
            selectionCirculation.IndeterminateValue = "2";
            selectionCirculation.MinimumWidth = 8;
            selectionCirculation.Name = "selectionCirculation";
            selectionCirculation.TrueValue = "1";
            selectionCirculation.Width = 76;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // book
            // 
            book.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            book.HeaderText = "Book";
            book.MinimumWidth = 8;
            book.Name = "book";
            book.ReadOnly = true;
            book.Width = 231;
            // 
            // borrower
            // 
            borrower.HeaderText = "Borrower";
            borrower.MinimumWidth = 8;
            borrower.Name = "borrower";
            borrower.ReadOnly = true;
            // 
            // dateBorrowed
            // 
            dateBorrowed.HeaderText = "Date Borrowed";
            dateBorrowed.MinimumWidth = 8;
            dateBorrowed.Name = "dateBorrowed";
            dateBorrowed.ReadOnly = true;
            // 
            // dateReturned
            // 
            dateReturned.HeaderText = "Data Returned";
            dateReturned.MinimumWidth = 8;
            dateReturned.Name = "dateReturned";
            dateReturned.ReadOnly = true;
            // 
            // filter
            // 
            filter.Location = new Point(815, 38);
            filter.Margin = new Padding(3, 4, 3, 4);
            filter.Name = "filter";
            filter.Size = new Size(81, 30);
            filter.TabIndex = 2;
            filter.Text = "Filter";
            filter.UseVisualStyleBackColor = true;
            filter.Click += Filter;
            // 
            // keyword
            // 
            keyword.Location = new Point(14, 38);
            keyword.Margin = new Padding(3, 4, 3, 4);
            keyword.Name = "keyword";
            keyword.PlaceholderText = "Keyword(s)";
            keyword.Size = new Size(794, 27);
            keyword.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(608, 409);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(123, 54);
            button1.TabIndex = 10;
            button1.Text = "Video";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl);
            Controls.Add(menu);
            Controls.Add(keyword);
            Controls.Add(filter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Library Management System";
            FormClosed += ExitApplication;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            tabControl.ResumeLayout(false);
            inventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)books).EndInit();
            borrowersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)borrowers).EndInit();
            circulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)circulations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem account;
        private ToolStripMenuItem signOut;
        private ToolStripMenuItem help;
        private ToolStripMenuItem about;
        private TabControl tabControl;
        private TabPage inventory;
        private TabPage borrowersTab;
        private ToolStripMenuItem view;
        private ToolStripMenuItem refresh;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem selectionAll;
        private ToolStripMenuItem selectionClear;
        private ToolStripMenuItem selectionInvert;
        private Button filter;
        private TextBox keyword;
        private Button addBook;
        private Button updateBook;
        private Button archiveBook;
        private Button borrowBook;
        private Button updateBorrower;
        private Button archiveBorrower;
        private Button addBorrower;
        private DataGridView books;
        private DataGridView borrowers;
        private TabPage circulation;
        private DataGridView circulations;
        private DataGridViewCheckBoxColumn selectionBook;
        private DataGridViewTextBoxColumn isbn;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn author;
        private DataGridViewCheckBoxColumn available;
        private DataGridViewCheckBoxColumn selectionBorrower;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn borrowedBook;
        private Button viewCirculation;
        private Button returnCirculation;
        private DataGridViewCheckBoxColumn selectionCirculation;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn book;
        private DataGridViewTextBoxColumn borrower;
        private DataGridViewTextBoxColumn dateBorrowed;
        private DataGridViewTextBoxColumn dateReturned;
        private Button vchat;
        private Button button2;
        private Button button1;
    }
}