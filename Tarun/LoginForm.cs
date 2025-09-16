using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CustomerSupportSystem.Tarun
{
    public partial class LoginForm : Form
    {
        private string validEmail = "admin@gmail.com";
        private string validPassword = "Admin@123";

        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click; 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show(" Please enter your email address.",
                                "Missing Email",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }


            // Validate Email Format
            if (!email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Email must be a valid Gmail address (e.g., user@gmail.com).",
                                "Invalid Email",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

           
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show(" Please enter your password.",
                                "Missing Password",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
           
            if (email.Equals(validEmail, StringComparison.OrdinalIgnoreCase) &&
                password == validPassword)
            {
                MessageBox.Show(" Login Successful! Welcome Admin.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.Hide();
                Form1 dashboard = new Form1();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show(" Incorrect email or password. Please try again.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        


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
