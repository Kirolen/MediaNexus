using MediaNexus.Class;
using MediaNexus_Backend;
using MediaNexus.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Globalization;

namespace MediaNexus
{
    public partial class HomeForm : Form
    {
        private delegate void ButtonClickHandler(object sender, EventArgs e);
        private User currentUser = new User();

        public HomeForm()
        {
            InitializeComponent();
            this.Resize += new EventHandler(HomeForm_Resize);
            this.MinimumSize = new Size(800, 600);
            
            createMainMediaPanel();
            //Properties.Settings.Default.login = "";
            //Properties.Settings.Default.password = "";
            //Properties.Settings.Default.Save();
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
            RecentMediaPanelResize();
            UserPanelLocation();
            ProfilePanelResize();
            ProfileSettingsPanelResize();
            ListPanel_Resize();
        }

        private void navMenuResize()
        {
            navMenuPanel.Size = new Size(navButton.Width, 160);
            navMenuPanel.Location = new Point(navButton.Location.X, navButton.Location.Y);
        }
        private void RecentMediaPanelResize()
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
                RecentMediaPanelElementsResize();
            }
        }
        private void RecentMediaPanelElementsResize()
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
        private void ProfilePanelResize()
        {
            if (ProfilePanel != null)
            {
                int widthNewMedia = (int)(mainPanel.Width * 0.75);
                int heightNewMedia = ProfilePanel.Height;

                if (widthNewMedia > 800) widthNewMedia = 880;

                int xPosition = (mainPanel.Width - widthNewMedia) / 2;
                int yPosition = (mainPanel.Height - heightNewMedia) / 2;
                
                ProfilePanel.Size = new Size(widthNewMedia, heightNewMedia);
                ProfilePanel.Location = new Point(xPosition, yPosition);
            }
        }

        private void ProfileSettingsPanelResize()
        {
            if (ProfileSettingsPanel != null)
            {
                int widthNewMedia = (int)(mainPanel.Width * 0.75);
                int heightNewMedia = ProfileSettingsPanel.Height;

                if (widthNewMedia > 800) widthNewMedia = 880;

                int xPosition = (mainPanel.Width - widthNewMedia) / 2;
                int yPosition = (mainPanel.Height - heightNewMedia) / 2;

                ProfileSettingsPanel.Size = new Size(widthNewMedia, heightNewMedia);
                ProfileSettingsPanel.Location = new Point(xPosition, yPosition);
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
        private void UserPanelLocation()
        {
            if (userNav != null && userPanel != null) userNav.Location = new Point(userPanel.Location.X, userPanel.Location.Y);
        }

        private void ListPanel_Resize()
        {
            if (mainMediaList != null && MediaListTableLayout != null)
            {
                int minBlockWidth = 110;
                int minBlockHeight = 190;

                int countCols = MediaListTableLayout.Width / minBlockWidth;
                int countRows = MediaListTableLayout.Height / minBlockHeight;

                if (currentMediaRows != countRows || currentMediaCols != countCols)
                {
                    currentMediaRows = countRows;
                    currentMediaCols = countCols;
                    mainMediaList.Controls.Clear();
                    mainMediaList.Controls.Add(AddRecentMediaBlocks(countCols, countRows, 1));
                }
            }
        }

        #endregion

        #region Event: button click
        private void navButton_Click(object sender, EventArgs e)
        {
            navMenuPanel.Visible = !navMenuPanel.Visible;
        }
        private void userPanel_Click(object sender, EventArgs e)
        {
            userNav.Visible = !userNav.Visible;
            
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                currentUser = loginForm.LoggedInUser;
                MessageBox.Show($"Welcome, {currentUser.Username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                navTableLayoutPanel.Controls.RemoveAt(4);
                addUserPanel(currentUser);
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

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            createProfile(currentUser);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            navTableLayoutPanel.Controls.RemoveAt(4);
            currentUser = new User();
            Properties.Settings.Default.login = "";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.Save();
            navTableLayoutPanel.Controls.Add(loginButton, 4, 0);
            createMainMediaPanel();
        }

        private void ProfileSettingsButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            createSettingsPanel(currentUser);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddingForm adding = new AddingForm("media");
            adding.ShowDialog();
        }


        private void ChangeTheme_Click(object sender, EventArgs e)
        {
        }

        private void ChooseImage_Click(object sender, EventArgs e)
        {
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
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

        #region logic
        public void checkFastVerification()
        {
            string ul = Properties.Settings.Default.login;
            string up = Properties.Settings.Default.password;
            if (ul != null && MNBackend.CheckLogin(ul, up))
            {
                currentUser = new User(ul, up, "user");
                addUserPanel(currentUser);
            }
            else
            {
                navTableLayoutPanel.Controls.Add(loginButton, 4, 0);
            }
        }
        #endregion



    }
}
