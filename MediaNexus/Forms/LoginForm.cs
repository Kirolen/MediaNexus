using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaNexus.Class;
using MediaNexus.Database;

namespace MediaNexus.Forms
{
    public partial class LoginForm : Form
    {
        public User LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();

        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.White;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;  
                textBoxPassword.ForeColor = Color.White;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.UseSystemPasswordChar = false; 
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = textBoxUsername.Text;
            string passUser = textBoxPassword.Text;

            bool verificationSuccessful = DB.checkLogin(loginUser, passUser);

            if (verificationSuccessful)
            {
                if (checkBoxRememberMe.Checked)
                {
                    Properties.Settings.Default.login = loginUser;
                    Properties.Settings.Default.password = passUser;
                    Properties.Settings.Default.Save(); 
                }

                LoggedInUser = new User { Username = loginUser, Password = passUser }; 
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}
