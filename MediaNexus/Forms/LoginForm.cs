using MediaNexus_Backend;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaNexus
{
    public partial class LoginForm : Form
    {
        public User LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void TextBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.White;
            }
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.White;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = textBoxUsername.Text;
            string passUser = textBoxPassword.Text;

            LoggedInUser = MediaService.CheckLogin(loginUser, passUser);

            if (LoggedInUser.Role != UserRole.Guest)
            {
                if (checkBoxRememberMe.Checked)
                {
                    Properties.Settings.Default.savedLogin = loginUser;
                    Properties.Settings.Default.savedPassword = passUser;
                    Properties.Settings.Default.Save();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}
