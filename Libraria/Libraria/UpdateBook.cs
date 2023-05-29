using System.Data;

namespace Libraria
{
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void Submit(object sender, EventArgs e)
        {
            string isbn = this.isbn != null ? this.isbn.Text.Trim() : "";
            string title = this.title != null ? this.title.Text.Trim() : "";
            string author = this.author != null ? this.author.Text.Trim() : "";
            var authors = author.Split(';').Select((s) => s.Trim()).Where((s) => s != "");

            isbn = Book.ToIsbn(isbn);
            if (isbn == null) return;

            var book = Database.books.Find((b) => b.isbn == isbn);
            if (book != null)
            {
                book.title = title;
                book.authors.Clear();
                book.authors.AddRange(authors);

                MessageBox.Show(
                    $"Successfully updated the book with ISBN 10 of {book.isbn}!", "Prompt",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Session.dashboard.RefreshBooks();
                Hide();
                return;
            }
        }

        public virtual void Reset()
        {
            isbn.Clear();
            title.Clear();
            author.Clear();
        }

        public virtual void ShowDialog(string isbn)
        {
            this.isbn.Text = isbn;
            var book = Database.books.Find((b) => b.isbn == isbn);
            title.Text = book.title;
            author.Text = string.Join("; ", book.authors);
            ShowDialog();
        }
    }
}
