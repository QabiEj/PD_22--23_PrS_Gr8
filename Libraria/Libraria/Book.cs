namespace Libraria
{
    public class Book
    {
        protected string _isbn = "";
        public virtual string isbn
        {
            get => _isbn;
            set
            {
                _isbn = ToIsbn(value);
            }
        }
        public string title = "";
        public List<string> authors = new();

        public Book() { }

        public Book(string isbn, string title, params string[] authors)
        {
            this.isbn = isbn;
            this.title = title;
            this.authors.AddRange(authors);
        }

        public static string ToIsbn(string str)
        {
            str = string.Concat(
                str.Where((c) => char.IsDigit(c))
            );
            if (str.Length != 10) return null;
            return str;
        }
    }
}
