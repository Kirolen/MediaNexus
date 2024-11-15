using MediaNexus_Backend;
using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Represents a login form that allows users to enter their credentials 
/// and log in to the application. Provides placeholder text handling for 
/// username and password fields, and stores the logged-in user's information 
/// upon successful login.
/// </summary>
namespace MediaNexus
{
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Gets the user who has successfully logged in.
        /// </summary>
        public User LoggedInUser { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class
        /// and sets up the components for the login interface.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the username text box gains focus. 
        /// Clears the placeholder text ("Username") and sets the text color to white.
        /// </summary>
        private void TextBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Event handler for when the username text box loses focus. 
        /// If the field is empty, it restores the placeholder text ("Username") 
        /// and changes the text color to gray.
        /// </summary>
        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        /// <summary>
        /// Event handler for when the password text box gains focus. 
        /// Clears the placeholder text ("Password"), enables password masking,
        /// and changes the text color to white.
        /// </summary>
        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Event handler for when the password text box loses focus. 
        /// If the field is empty, it restores the placeholder text ("Password"), 
        /// disables password masking, and changes the text color to gray.
        /// </summary>
        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        /// <summary>
        /// Handles the login button click event. Verifies the user's credentials
        /// by checking with the <see cref="MediaService.CheckLogin"/> method.
        /// If the login is successful, stores the credentials if "Remember Me" 
        /// is checked and closes the form. Otherwise, shows an error message.
        /// </summary>
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

        /// <summary>
        /// Handles the registration button click event. Closes the login form 
        /// and opens the registration form, allowing the user to create a new account.
        /// </summary>
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}
