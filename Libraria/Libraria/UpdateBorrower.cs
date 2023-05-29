namespace Libraria
{
    public partial class UpdateBorrower : Form
    {
        public UpdateBorrower()
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
                if (givenName == "" || familyName == "")
                {
                    MessageBox.Show(
                        "Please ensure that all credentials are filled.", "Prompt",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                borrower.givenName = givenName;
                borrower.familyName = familyName;
                MessageBox.Show(
                    $"Successfully updated!", "Prompt",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Session.dashboard.RefreshBorrowers();
                Hide();
            }
        }

        public virtual void Reset()
        {
            email.Clear();
            givenName.Clear();
            familyName.Clear();
        }

        public virtual void ShowDialog(string email)
        {
            this.email.Text = email;
            var borrower = Database.borrowers.Find((b) => b.email == email);
            givenName.Text = borrower.givenName;
            familyName.Text = borrower.familyName;
            ShowDialog();
        }
    }
}
