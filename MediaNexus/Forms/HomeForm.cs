using MediaNexus.Class;
using MediaNexus.Database;
using MediaNexus.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MediaNexus
{
    public partial class HomeForm : Form
    {
        private User currentUser;

        public HomeForm()
        {
            InitializeComponent();
            this.Resize += new EventHandler(HomeForm_Resize);
            this.MinimumSize = new Size(800, 600);
            
            createMainMediaPanel();
            Properties.Settings.Default.login = "";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.Save();
            checkFastVerification();

        }


        #region resizing
        // Event handler for form resizing
        private void HomeForm_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void ResizeControls()
        {
            mainTableLayoutPanel.Size = this.ClientSize;
            navTableLayoutPanel.Width = this.ClientSize.Width;

            navMenuResize();
            newMediaPanelResize();
        }

        private void navMenuResize()
        {
            navMenuPanel.Size = new Size(navButton.Width, 130);
            navMenuPanel.Location = new Point(navButton.Location.X, navButton.Location.Y);
        }

        private void newMediaPanelResize()
        {
            if (MediaPanel != null)
            {
                int widthNewMedia = (int)(mainPanel.Width * 0.75);
                int heightNewMedia = (int)(mainPanel.Height * 0.85);

                int xPosition = (mainPanel.Width - widthNewMedia) / 2;
                int yPosition = (mainPanel.Height - heightNewMedia) / 2;

                MediaPanel.Size = new Size(widthNewMedia, heightNewMedia);
                MediaPanel.Location = new Point(xPosition, yPosition);

                gtnmButtonResize();
                mediaPanelResize();
            }
        }
        private void mediaPanelResize()
        {
            if (MediaPanel != null && mediaBlocksPanel != null && mediaHistoryAndNavPanel != null)
            {
                int widthPanel = MediaPanel.Width;
                int heightBlocksPanel = (int)(MediaPanel.Height * 0.6);
                int heightHAVPanel = (int)(MediaPanel.Height * 0.2);

                mediaBlocksPanel.Size = new Size(widthPanel, heightBlocksPanel);
                mediaHistoryAndNavPanel.Size = new Size(widthPanel, heightHAVPanel);

                mediaBlocksPanel.Location = new Point(
                    (MediaPanel.Width - widthPanel) / 2,
                    60 
                );

                mediaHistoryAndNavPanel.Location = new Point(
                    (MediaPanel.Width - widthPanel) / 2,
                    mediaBlocksPanel.Bottom + 10 
                );
            }
        }
        private void gtnmButtonResize()
        {
            if (MediaPanel != null)
            {
                int widthButton = MediaPanel.Width;
                int heightButton = 25;

                if (goToNewMediaButton != null)
                {
                    goToNewMediaButton.Size = new Size(widthButton, heightButton);
                    goToNewMediaButton.Location = new Point(
                        (MediaPanel.Width - widthButton) / 2,
                        25
                    );
                }
            }
        }

        #endregion

        #region Event: button click
        private void navButton_Click(object sender, EventArgs e)
        {
            navMenuPanel.Visible = !navMenuPanel.Visible;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                currentUser = loginForm.LoggedInUser;
                MessageBox.Show($"Welcome, {currentUser.Username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                navTableLayoutPanel.Controls.RemoveAt(4);
            }

        }
        private void navButton_type_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            string mediaType = "";

            Button clickedButton = sender as Button;

            if (clickedButton == navButton_media) mediaType = "Media";
            else if (clickedButton == navButton_comics) mediaType = "Comics";
            else if (clickedButton == navButton_book) mediaType = "Books";

            createMediaListPanel(mediaType);
        }

        private void goToNewMedia_button_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            createMediaListPanel("New");
        }

        private void navNameLabel_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            createMainMediaPanel();
        }

        #endregion

        #region Enter/Leave events
        private void changeButtonForeColor(Label button, Color newColor)
        {
            if (button != null) button.ForeColor = newColor;
        }

        private void navButton_MouseEnter(object sender, EventArgs e)
        {
            Button navButton = sender as Button;

            if (navButton != null)
            {
                navButton.BackColor = Color.White;
                navButton.ForeColor = Color.Black;
            }
        }
        private void navButton_MouseLeave(object sender, EventArgs e)
        {
            Button navButton = sender as Button;

            if (navButton != null)
            {
                navButton.BackColor = Color.FromArgb(58, 58, 58);
                navButton.ForeColor = Color.White;
            }
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Search")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black; 
            }
        }
        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBox.Text = "Search";
                searchTextBox.ForeColor = Color.Gray; 
            }
        }
        #endregion

        public void checkFastVerification()
        {
            string ul = Properties.Settings.Default.login;
            string up = Properties.Settings.Default.password;
            bool verificationSuccessful = false;
            if (ul != null)
            {
               verificationSuccessful = DB.checkLogin(ul, up);
            }
            if (!verificationSuccessful)
            {
                navTableLayoutPanel.Controls.Add(loginButton, 4, 0);
            }
            else {
                Panel userPanel = new Panel
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.White,
                };
                navTableLayoutPanel.Controls.Add(userPanel, 4, 0);
            }
        }

      
    }
}
