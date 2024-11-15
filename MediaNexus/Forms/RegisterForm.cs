using MediaNexus_Backend;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaNexus
{
    /// <summary>
    /// Represents a registration form for creating a new user account.
    /// Allows users to input their username, password, and email, and handles 
    /// placeholder text for these fields. Provides feedback on the success or 
    /// failure of the registration process.
    /// </summary>
    public partial class RegisterForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterForm"/> class,
        /// setting up a fixed dialog form style with no maximize option.
        /// </summary>
        public RegisterForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        #region Event: button click
        /// <summary>
        /// Handles the register button click event. Attempts to register a new user 
        /// with the input username, password, and email. Provides feedback based on 
        /// the registration result, informing the user if registration is successful 
        /// or if there are issues with the provided credentials.
        /// </summary>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string userLogin = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string email = textBoxEmail.Text;

            RegisterResult isRegistered = MediaService.Register(userLogin, password, email);

            if (isRegistered == RegisterResult.Success)
            {
                MessageBox.Show("Registration successful!");
            }
            else if (isRegistered == RegisterResult.UserLoginTaken)
            {
                MessageBox.Show("User login is already taken.");
            }
            else if (isRegistered == RegisterResult.EmailTaken)
            {
                MessageBox.Show("Email is already taken.");
            }
            else
            {
                MessageBox.Show("Registration failed!");
            }
            this.Close();
        }
        #endregion

        #region Event: Enter/Leave
        /// <summary>
        /// Clears the placeholder text ("Username") in the username text box 
        /// when the box gains focus, and sets the text color to black.
        /// </summary>
        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Restores the placeholder text ("Username") in the username text box 
        /// if the box loses focus and is empty, setting the text color to gray.
        /// </summary>
        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        /// <summary>
        /// Clears the placeholder text ("Password") in the password text box 
        /// when the box gains focus, enables password masking, and sets the 
        /// text color to black.
        /// </summary>
        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Restores the placeholder text ("Password") in the password text box 
        /// if the box loses focus and is empty, disables password masking, and 
        /// sets the text color to gray.
        /// </summary>
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        /// <summary>
        /// Clears the placeholder text ("Email") in the email text box 
        /// when the box gains focus, and sets the text color to black.
        /// </summary>
        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Restores the placeholder text ("Email") in the email text box 
        /// if the box loses focus and is empty, setting the text color to gray.
        /// </summary>
        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }
        #endregion
    }
}
