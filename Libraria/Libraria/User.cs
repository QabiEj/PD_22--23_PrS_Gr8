namespace Libraria
{
    public class User
    {
        protected string _username = "";
        public virtual string name => _username;
        public string password = "";

        public User() { }

        public User(string username, string password)
        {
            _username = username;
            this.password = password;
        }
    }
}
