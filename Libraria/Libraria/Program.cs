namespace Libraria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.users.Add(new User("", ""));

            Database.books.Add(new Book("1234567890", "Book 1"));
            Database.books.Add(new Book("1334567890", "Book 2", "John", "Doe"));
            Database.books.Add(new Book("5334567890", "Book 3","Mark","Twain"));
            Database.books.Add(new Book("1339567890", "Book 4"));

            Database.borrowers.Add(new Borrower("shabanejupi5@email.com", "Shaban", "Ejupi"));
            Database.borrowers.Add(new Borrower("ariant.likaj@email.com", "Arianit", "Likaj"));
            Database.borrowers.Add(new Borrower("blendi.rexhepi@email.com", "Blendi", "Rexhepi"));
            
            ApplicationConfiguration.Initialize();
            Session.signIn = new SignIn();
            Session.dashboard = new Dashboard();
            Session.addBook = new AddBook();
            Session.updateBook = new UpdateBook();
            Session.addBorrower = new AddBorrower();
            Session.updateBorrower = new UpdateBorrower();
            Session.borrow = new Borrow();
            Session.lending = new Lending();

            Session.dashboard.Hide();
            Session.addBook.Hide();
            Session.updateBook.Hide();
            Session.addBorrower.Hide();
            Session.updateBorrower.Hide();
            Session.borrow.Hide();
            Session.lending.Hide();

            Application.Run(Session.signIn);
        }
    }
}