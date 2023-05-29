namespace Libraria
{
    public class Borrower
    {
        public string email = "";
        public string givenName = "";
        public string familyName = "";

        public Borrower() { }

        public Borrower(string email, string givenName, string familyName)
        {
            this.email = email;
            this.givenName = givenName;
            this.familyName = familyName;
        }
    }
}
