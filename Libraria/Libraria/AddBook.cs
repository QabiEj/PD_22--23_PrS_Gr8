using System.Data;

namespace Libraria
{
    public partial class AddBook : Form
    {
        public AddBook()
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
                MessageBox.Show(
                    "The book is already existing in the Database!", "Prompt",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Database.books.Add(new Book(isbn, title, authors.ToArray()));
            MessageBox.Show(
                $"Successfully added!", "Prompt",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Session.dashboard.RefreshBooks();
            Reset();
            return;
        }

        public virtual void Reset()
        {
            isbn.Clear();
            title.Clear();
            author.Clear();
        }
    }
}
