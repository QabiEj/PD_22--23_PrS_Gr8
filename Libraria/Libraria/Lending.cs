namespace Libraria
{
    public partial class Lending : Form
    {
        public Lending()
        {
            InitializeComponent();
        }

        public virtual void Reset()
        {
            book.Clear();
            borrower.Clear();
            dateBorrowed.Clear();
            dateReturned.Clear();
        }

        public virtual void ShowDialog(string id)
        {
            var circulation = Database.circulations.Find((c) => c.id == id);
            if (circulation != null)
            {
                book.Text = $"{circulation.book.isbn} {circulation.book.title}";
                borrower.Text = $"{circulation.borrower.email}";
                dateBorrowed.Text = circulation.dateBorrowed.ToShortDateString();
                dateReturned.Text = circulation.dateReturned.Equals(default(DateOnly))
                    ? "<Not Yet Returned>"
                    : circulation.dateReturned.ToShortDateString();
            }

            ShowDialog();
        }

        private void EditBook(object sender, EventArgs e)
        {
            if (book.Text != null)
            {
                Session.updateBook.ShowDialog(book.Text.ToString().Split()[0]);
            }
        }

        private void EditBorrower(object sender, EventArgs e)
        {
            if (borrower.Text != null)
            {
                Session.updateBorrower.ShowDialog(borrower.Text.ToString().Split()[0]);
            }
        }
    }
}
