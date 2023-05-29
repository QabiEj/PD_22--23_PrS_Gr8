using System;
using System.Diagnostics;
using System.ComponentModel;

namespace Libraria
{
    public partial class Dashboard : Form
    {
        public virtual DataGridView[] tables => new DataGridView[] {
            books, borrowers, circulations
        };
        public virtual DataGridView activeTable => tables[tabControl.SelectedIndex];
        public virtual IEnumerable<DataGridViewRow> selectedRows
        {
            get
            {
                var rows = new List<DataGridViewRow>();
                if (activeTable != null)
                {
                    foreach (DataGridViewRow row in activeTable.Rows)
                    {
                        if (row.Cells[0].Value == "1") rows.Add(row);
                    }
                }
                return rows;
            }
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void SignOut(object sender, EventArgs e)
        {
            Session.user = null;
            Hide();
            ResetText();
            Session.signIn.Reset();
            Session.signIn.Show();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Refresh();
        }

        public virtual void RefreshBooks()
        {
            RefreshBooks(Database.books.ToArray());
        }

        public virtual void RefreshBooks(params Book[] books)
        {
            this.books.Rows.Clear();
            foreach (var book in Database.books)
            {
                int index = this.books.Rows.Add(
                    "0",
                    book.isbn,
                    book.title,
                    string.Join("; ", book.authors),
                    Database.circulations.Count > 0
                    ? (Database.circulations.Count((c) => c.book == book) == 0
                        ? "1" : "0")
                    : "1"
                );
            }
        }

        public virtual void RefreshBorrowers()
        {
            RefreshBorrowers(Database.borrowers.ToArray());
        }

        public virtual void RefreshBorrowers(params Borrower[] borrowers)
        {
            this.borrowers.Rows.Clear();
            foreach (var borrower in borrowers)
            {
                int borrowedCount = Database.circulations.Count > 0
                    ? Database.circulations.Count((c) => c.borrower == borrower)
                    : 0;
                string borrowedBooks = Database.circulations.Count > 0
                    ? string.Join("; ",
                        Database.circulations.Where((c) => c.borrower == borrower)
                        .Select((c) => c.book.title).Reverse())
                    : "";
                if (borrowedBooks.Length > 25)
                    borrowedBooks = borrowedBooks.Substring(0, 22) + "...";
                int index = this.borrowers.Rows.Add(
                    "0",
                    borrower.email,
                    $"{borrower.givenName} {borrower.familyName}",
                    $"({borrowedCount}) {borrowedBooks}"
                );
            }
        }

        public virtual void RefreshCirculations(params Circulation[] circulations)
        {
            this.circulations.Rows.Clear();
            foreach (var circulation in circulations)
            {
                int index = this.circulations.Rows.Add(
                    "0",
                    circulation.id,
                    $"{circulation.book.isbn} {circulation.book.title}",
                    $"{circulation.borrower.email} - {circulation.borrower.givenName} {circulation.borrower.familyName}",
                    circulation.dateBorrowed,
                    !circulation.dateReturned.Equals(default(DateOnly))
                    ? circulation.dateReturned.ToShortDateString()
                    : "<Not Yet Returned>"
                );
            }
        }

        public virtual void RefreshCirculations() => RefreshCirculations(Database.circulations.ToArray());

        public virtual void Refresh()
        {
            RefreshBooks();
            RefreshBorrowers();
            RefreshCirculations();
        }

        private void Refresh(object sender, EventArgs e)
        {
            Refresh();
        }

        private void SelectAll(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in activeTable.Rows)
                {
                    row.Cells[0].Value = "1";
                }
            }
            catch { }
        }

        private void InvertSelection(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in activeTable.Rows)
                {
                    string value = row.Cells[0].Value == "0" ? "1" : "0";
                    row.Cells[0].Value = value;
                }
            }
            catch { }
        }

        private void ClearSelection(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in activeTable.Rows)
                {
                    row.Cells[0].Value = "0";
                }
            }
            catch { }
        }

        private void AddBook(object sender, EventArgs e)
        {
            Session.addBook.Reset();
            Session.addBook.ShowDialog();
        }

        private void Filter(object sender, EventArgs e) => Filter();

        protected virtual void Filter()
        {
            string[] keywords = keyword.Text != null ? keyword.Text.Trim().ToLower().Split(' ') : new string[] { };
            if (keywords.Length == 0 || keywords.All((k) => k.Length == 0))
            {
                Refresh();
                return;
            }

            foreach (DataGridViewRow row in activeTable.Rows)
            {
                var cells = new List<DataGridViewCell>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Visible) cells.Add(cell);
                }
                row.Visible = false;

                foreach (var cell in cells)
                {
                    cell.Selected = false;

                    if (cell.Value != null)
                    {
                        var cellKeywords = cell.Value.ToString().Trim().ToLower().Split(' ');
                        if (cellKeywords.Length == 0) continue;
                        foreach (string keyword in keywords)
                        {
                            if (cellKeywords.Contains(keyword))
                            {
                                cell.Selected = true;
                                row.Visible = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void ArchiveBook(object sender, EventArgs e)
        {
            var books = selectedRows.Select((r) =>
                Database.books.Find((b) => b.isbn == r.Cells[1].Value.ToString()))
                .Where((b) => b != null
                    && (
                        Database.circulations.Count > 0 ? Database.circulations.Count((c) => c.book == b) : 0
                    ) == 0);
            if (books.Count() == 0) return;
            int count = books.Count();
            foreach (var book in books)
            {
                Database.books.Remove(book);
                Database.archivedBooks.Add(book);
            }

            MessageBox.Show(
                $"Successfully archived {count} book(s)!", "Prompt",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            RefreshBooks();
        }

        private void UpdateBook(object sender, EventArgs e)
        {
            var books = selectedRows.Select((r) =>
                Database.books.Find((b) => b.isbn == r.Cells[1].Value.ToString()))
                .Where((b) => b != null);
            if (books.Count() == 0) return;
            foreach (var book in books)
            {
                Session.updateBook.ShowDialog(book.isbn);
            }
        }

        private void AddBorrower(object sender, EventArgs e)
        {
            Session.addBorrower.Reset();
            Session.addBorrower.ShowDialog();
        }

        private void UpdateBorrower(object sender, EventArgs e)
        {
            var borrowers = selectedRows.Select((r) =>
                Database.borrowers.Find((b) => b.email == r.Cells[1].Value.ToString()))
                .Where((b) => b != null);
            if (borrowers.Count() == 0) return;
            foreach (var borrower in borrowers)
            {
                Session.updateBorrower.ShowDialog(borrower.email);
            }
        }

        private void ArchiveBorrower(object sender, EventArgs e)
        {
            var borrowers = selectedRows.Select((r) =>
                Database.borrowers.Find((b) => b.email == r.Cells[1].Value.ToString()))
                .Where((b) => b != null
                    && (
                        Database.circulations.Count > 0 ? Database.circulations.Count((c) => c.borrower == b) : 0
                    ) == 0);
            if (borrowers.Count() == 0) return;
            int count = borrowers.Count();
            foreach (var borrower in borrowers)
            {
                Database.borrowers.Remove(borrower);
                Database.archivedBorrowers.Add(borrower);
            }

            MessageBox.Show(
                $"Successfully archived {count} borrowers(s)!", "Prompt",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            RefreshBorrowers();
        }

        private void Borrow(object sender, EventArgs e)
        {
            var books = selectedRows.Where((r) => r.Cells[4].Value != null
                ? r.Cells[4].Value.ToString() == "1"
                : true).Select((r) =>
                Database.books.Find((b) => b.isbn == r.Cells[1].Value.ToString()))
                .Where((b) => b != null);
            if (books.Count() == 0) return;
            foreach (var book in books)
            {
                Session.borrow.ShowDialog(book.isbn, null);
            }
        }

        private void ReturnCirculation(object sender, EventArgs e)
        {
            var circulations = selectedRows.Select((r) =>
                Database.circulations.Find((c) => c.id == r.Cells[1].Value.ToString()))
                .Where((b) => b != null);
            if (circulations.Count() == 0) return;
            int count = circulations.Count();
            var now = DateTime.Now;
            var dateOnly = new DateOnly(now.Year, now.Month, now.Day);
            foreach (var circulation in circulations)
            {
                circulation.dateReturned = dateOnly;
            }

            MessageBox.Show(
                $"Successfully marked {count} lendings(s) as returned!", "Prompt",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ViewCirculation(object sender, EventArgs e)
        {
            var circulations = selectedRows.Select((r) =>
                Database.circulations.Find((c) => c.id == r.Cells[1].Value.ToString()))
                .Where((b) => b != null);
            if (circulations.Count() == 0) return;
            foreach (var circulation in circulations)
            {
                Session.lending.ShowDialog(circulation.id);
            }
        }

        private void About(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"
Title:
    Simple Library Management System (SLMS)
Author:
    enaielei <gr8@gmail.com>
Date Created:
    Saturday, May 20, 2023
                ", "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ExitApplication(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void borrowers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vchat_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
