using System.Data;

namespace Libraria
{
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }

        private void Submit(object sender, EventArgs e)
        {
            string isbn = this.book.SelectedItem != null ? this.book.SelectedItem.ToString().Split()[0] : "";
            string email = this.borrower.SelectedItem != null ? this.borrower.SelectedItem.ToString().Split()[0] : "";

            isbn = Book.ToIsbn(isbn);

            var book = Database.books.Find((b) => b.isbn == isbn);
            var borrower = Database.borrowers.Find((b) => b.email == email);

            if (book == null || borrower == null)
            {
                MessageBox.Show(
                    "Please select a proper book and borrower first!", "Prompt",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Database.circulations.Add(new Circulation(book, borrower, date.Value));
            MessageBox.Show(
                $"Successfully added to circulations!", "Prompt",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Session.dashboard.Refresh();
            Reset();
            Hide();
        }

        public virtual void Reset()
        {
            date.Value = date.MaxDate;
            book.SelectedItem = null;
            borrower.SelectedItem = null;
        }

        public virtual void ShowDialog(string isbn, string email)
        {
            date.MinDate = DateTime.Now.AddYears(-1);
            date.MaxDate = DateTime.Now;
            date.Value = date.MaxDate;

            book.Items.Clear();
            book.Items.AddRange(Database.books.Count > 0
                ? Database.books.Select((b) => $"{b.isbn} {b.title}").ToArray()
                : new string[] { });

            borrower.Items.Clear();
            borrower.Items.AddRange(Database.borrowers.Count > 0
                ? Database.borrowers.Select((b) => b.email).ToArray()
                : new string[] { });

            if (book.Items.Count > 0)
            {
                var book = Database.books.Find((b) => b.isbn == isbn);
                if (book != null) this.book.SelectedItem = $"{book.isbn} {book.title}";
            }
            else book.SelectedItem = null;

            if (borrower.Items.Count > 0)
            {
                var borrower = Database.borrowers.Find((b) => b.email == email);
                if (borrower != null) this.borrower.SelectedItem = borrower.email;
            }
            else borrower.SelectedItem = null;

            ShowDialog();
        }

        private void EditBook(object sender, EventArgs e)
        {
            if (book.SelectedItem != null)
            {
                Session.updateBook.ShowDialog(book.SelectedItem.ToString().Split()[0]);
            }
            else
            {
                Session.addBook.Reset();
                Session.addBook.ShowDialog();
            }
        }

        private void EditBorrower(object sender, EventArgs e)
        {
            if (borrower.SelectedItem != null)
            {
                Session.updateBorrower.ShowDialog(borrower.SelectedItem.ToString().Split()[0]);
            }
            else
            {
                Session.addBorrower.Reset();
                Session.addBorrower.ShowDialog();
            }
        }
    }
}
