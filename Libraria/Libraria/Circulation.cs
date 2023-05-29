namespace Libraria
{
    public class Circulation
    {
        public virtual string id => book.isbn + "@" + borrower.email;
        public Book book;
        public Borrower borrower;
        public DateOnly dateBorrowed;
        public DateOnly dateReturned;

        public Circulation() { }

        public Circulation(Book book, Borrower borrower, DateOnly dateBorrowed, DateOnly dateReturned = default)
        {
            this.book = book;
            this.borrower = borrower;
            this.dateBorrowed = dateBorrowed;
            this.dateReturned = dateReturned;
        }

        public Circulation(Book book, Borrower borrower, DateTime dateBorrowed, DateTime dateReturned = default) :
            this(
                book, borrower,
                new DateOnly(dateBorrowed.Year, dateBorrowed.Month, dateBorrowed.Day),
                !dateReturned.Equals(default(DateOnly))
                ? new DateOnly(dateReturned.Year, dateReturned.Month, dateReturned.Day)
                : default
            )
        { }
    }
}
