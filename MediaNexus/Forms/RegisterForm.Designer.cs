using System.Drawing;
using System;
using System.Windows.Forms;

namespace MediaNexus.Forms
{
    partial class RegisterForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsername = new TextBox();
            this.textBoxPassword = new TextBox();
            this.textBoxEmail = new TextBox();
            this.buttonRegister = new Button();
            //
            // Form settings
            //
            this.ClientSize = new Size(400, 350);
            this.Text = "Register";
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            //
            // Username TextBox
            //
            this.textBoxUsername.Size = new Size(300, 30);
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.Font = new Font("Segoe UI", 12);
            this.textBoxUsername.ForeColor = Color.Gray;
            this.textBoxUsername.BackColor = Color.FromArgb(50, 50, 50);
            this.textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxUsername.Location = new Point(50, 50);
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            //
            // Password TextBox
            //
            this.textBoxPassword.Size = new Size(300, 30);
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.ForeColor = Color.Gray;
            this.textBoxPassword.Font = new Font("Segoe UI", 12);
            this.textBoxPassword.BackColor = Color.FromArgb(50, 50, 50);
            this.textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxPassword.Location = new Point(50, 100);
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            //
            // Email TextBox
            //
            this.textBoxEmail.Size = new Size(300, 30);
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.Font = new Font("Segoe UI", 12);
            this.textBoxEmail.ForeColor = Color.Gray;
            this.textBoxEmail.BackColor = Color.FromArgb(50, 50, 50);
            this.textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxEmail.Location = new Point(50, 150);
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            //
            //Register Button
            //
            this.buttonRegister.Text = "Register";
            this.buttonRegister.ForeColor = Color.Black;
            this.buttonRegister.BackColor = Color.LightBlue;
            this.buttonRegister.FlatStyle = FlatStyle.Flat;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.Size = new Size(120, 40);
            this.buttonRegister.Location = new Point(140, 220);
            this.buttonRegister.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.buttonRegister.Cursor = Cursors.Hand;
            //this.buttonRegister.Click += new EventHandler(buttonRegister_Click);

            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonRegister);
        }

        #endregion


        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Button buttonRegister;
    }
}