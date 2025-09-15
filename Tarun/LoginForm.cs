using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CustomerSupportSystem.Tarun
{
    public partial class LoginForm : Form
    {
        // Hardcoded credentials (for demo, no DB)
        private string validEmail = "admin@gmail.com";
        private string validPassword = "Admin@123";

        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click; // Attach event handler
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate Email Format
            if (!email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Email must be a valid Gmail address (e.g., user@gmail.com).",
                                "Invalid Email",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validate Password Format
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must contain at least:\n" +
                                "• One uppercase letter\n" +
                                "• One lowercase letter\n" +
                                "• One number\n" +
                                "• One special character",
                                "Invalid Password",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // ✅ Check Against Hardcoded Credentials
            if (email == validEmail && password == validPassword)
            {
                // Hide login and open MainForm
                this.Hide();
                Form1 Form1 = new Form1();
                Form1.Show();
            }
            else
            {
                MessageBox.Show("❌ Invalid credentials. Try again.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // Helper method to validate password
        private bool IsValidPassword(string password)
        {
            var regex = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{6,}$");
            return regex.IsMatch(password);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}
