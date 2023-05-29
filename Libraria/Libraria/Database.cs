namespace Libraria
{
    public static class Database
    {
        public static List<Book> books = new();
        public static List<Book> archivedBooks = new();
        public static List<User> users = new();
        public static List<Borrower> borrowers = new();
        public static List<Borrower> archivedBorrowers = new();
        public static List<Circulation> circulations = new();
    }
}
