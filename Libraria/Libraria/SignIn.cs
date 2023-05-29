namespace Libraria
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Submit(object sender, EventArgs e)
        {
            string username = this.username != null ? this.username.Text.Trim() : "";
            string password = this.password != null ? this.password.Text.Trim() : "";

            var user = Database.users.Find((u) => u.name == username);
            if (user != null)
            {
                if (user.password == password)
                {
                    Session.user = user;

                    MessageBox.Show(
                        $"Successfully signed in!\nWelcome {user.name}.", "Prompt",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    var dashboard = new Dashboard();
                    dashboard.Show();
                    Hide();
                    return;
                }
            }

            MessageBox.Show(
                "The credentials are incorrect!", "Prompt",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public virtual void Reset()
        {
            username.Clear();
            password.Clear();
        }
    }
}
