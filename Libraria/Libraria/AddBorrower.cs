namespace Libraria
{
    public partial class AddBorrower : Form
    {
        public AddBorrower()
        {
            InitializeComponent();
        }

        private void Submit(object sender, EventArgs e)
        {
            string email = this.email != null ? this.email.Text.Trim() : "";
            string givenName = this.givenName != null ? this.givenName.Text.Trim() : "";
            string familyName = this.familyName != null ? this.familyName.Text.Trim() : "";

            var borrower = Database.borrowers.Find((b) => b.email == email);
            if (borrower != null)
            {
                MessageBox.Show(
                    "The borrower is already existing in the Database!", "Prompt",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (givenName == "" || familyName == "")
            {
                MessageBox.Show(
                    "Please ensure that all credentials are filled.", "Prompt",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Database.borrowers.Add(new Borrower(email, givenName, familyName));
            MessageBox.Show(
                $"Successfully added!", "Prompt",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Session.dashboard.RefreshBorrowers();
            Reset();
            return;
        }

        public virtual void Reset()
        {
            email.Clear();
            givenName.Clear();
            familyName.Clear();
        }
    }
}
