using Microsoft.IdentityModel.Tokens;
using SnackDeliveryLibrary.Models;

namespace SnackDelivery
{
    public partial class LoginForm : Form
    {
        private SnackDeliveryContext context;
        public LoginForm()
        {
            InitializeComponent();
            context = new SnackDeliveryContext();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please enter your phonenumber.", "Phonenumber Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please enter your username.", "Username Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var account = context.Accounts.FirstOrDefault(a => a.PhoneNumber == txtUsername.Text);

            if (account == null)
            {
                MessageBox.Show("Account doesn't exist", "Check your phonenumber", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (account.Password != txtPassword.Text)
            {
                MessageBox.Show("Incorrect Password", "Check your password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((bool)account.IsAdmin)
            {
                AdminForm admin = new AdminForm();
                admin.Show();
            }
            else
            {
                Account_InfoForm acc = new Account_InfoForm(account.Id);
                acc.Show();
            }
            this.Hide();

        }
    }
}