using MediaNexus_Backend;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MediaNexus
{
    public partial class HomeForm : Form
    {
        User currentUser;
        public HomeForm()
        {
            InitializeComponent();
            this.Resize += new EventHandler(HomeForm_Resize);
            this.MinimumSize = new Size(800, 600);

            createMainMediaPanel();
            Verification();
        }


        #region Resizing
        private void HomeForm_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void ResizeControls()
        {
            mainTableLayoutPanel.Size = this.ClientSize;
            navTableLayoutPanel.Width = this.ClientSize.Width;

            NavMenuResize();
            RecentMediaPanelResize();
            UserPanelLocation();
            ProfileSettingsPanelResize();
            RecentMediaInfoPanelResize();
        }
        private void NavMenuResize()
        {
            if (navMenuPanel != null)
            {
                navMenuPanel.Size = new Size(navButton.Width, 200);
                navMenuPanel.Location = new Point(navButton.Location.X, navButton.Location.Y);
            }
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

                GoToNewMediaButtonResize();
                RecentMediaPanelElementsResize();
            }
        }
        private void RecentMediaPanelElementsResize()
        {
            if (MediaPanel != null && mediaBlocksPanel != null && mediaHistoryAndNavPanel != null)
            {
                int widthPanel = (int)(MediaPanel.Width * 0.95);
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
        private void GoToNewMediaButtonResize()
        {
            if (MediaPanel != null)
            {
                int widthButton = (int)(MediaPanel.Width * 0.95);
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

        private void RecentMediaInfoPanelResize()
        {
            if (MediaInfoControlPanel != null)
            {
                int widthNewMedia = (int)(mainPanel.Width * 0.75);
                int heightNewMedia = (int)(mainPanel.Height * 0.95);

                int xPosition = (mainPanel.Width - widthNewMedia) / 2;
                int yPosition = (mainPanel.Height - heightNewMedia) / 2;

                MediaInfoControlPanel.Size = new Size(widthNewMedia, heightNewMedia);
                MediaInfoControlPanel.Location = new Point(xPosition, yPosition);
                TableLayoutPanel panel = MediaInfoControlPanel.Controls[0] as TableLayoutPanel;
                if (heightNewMedia > 700)
                {
                    if (panel != null)
                    {
                        {
                            panel.Controls.Clear();
                            panel.Controls.Add(mediaInfo(currentMediaUse), 0, 0);
                            panel.Controls.Add(createResponsePanel(currentMediaUse, isOnly: false), 0, 1);
                        }
                    }
                }
                else
                {
                    if (panel != null)
                    {
                        {
                            panel.Controls.Clear();
                            panel.Controls.Add(mediaInfo(currentMediaUse), 0, 0);
                            showResponseButton(isResponse: false, panel, currentMediaUse);
                        }
                    }

                }
            }
        }
        #endregion



        #region resizing

        //private void ProfilePanelResize()
        //{
        //    if (ProfilePanel != null)
        //    {
        //        int widthNewMedia = (int)(mainPanel.Width * 0.75);
        //        int heightNewMedia = ProfilePanel.Height;

        //        if (widthNewMedia > 800) widthNewMedia = 880;

        //        int xPosition = (mainPanel.Width - widthNewMedia) / 2;
        //        int yPosition = (mainPanel.Height - heightNewMedia) / 2;

        //        ProfilePanel.Size = new Size(widthNewMedia, heightNewMedia);
        //        ProfilePanel.Location = new Point(xPosition, yPosition);
        //    }
        //}





        //private void ListPanel_Resize()
        //{
        //    if (mainMediaList != null && MediaListTableLayout != null)
        //    {
        //        int minBlockWidth = 110;
        //        int minBlockHeight = 190;

        //        int countCols = MediaListTableLayout.Width / minBlockWidth;
        //        int countRows = MediaListTableLayout.Height / minBlockHeight;

        //        if (currentMediaRows != countRows || currentMediaCols != countCols)
        //        {
        //            currentMediaRows = countRows;
        //            currentMediaCols = countCols;
        //            mainMediaList.Controls.Clear();
        //            mainMediaList.Controls.Add(AddRecentMediaBlocks(countCols, countRows, 1));
        //        }
        //    }
        //}

        #endregion


        #region Click
        private void NavButton_Click(object sender, EventArgs e)
        {
            if (navMenuPanel == null) createNavMenuPanel();
            if (!mainPanel.Controls.Contains(navMenuPanel))
            {
                mainPanel.Controls.Add(navMenuPanel);
                navMenuPanel.Visible = false;
                navMenuPanel.BringToFront();
            }

            navMenuPanel.Visible = !navMenuPanel.Visible;
        }

        private void NavButton_type_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();


            Button clickedButton = sender as Button;

            if (clickedButton.Name == "navButton_media")
            {
                ChangeNavLabelText("Media");
                conditions = new SortMediacs(new[] { "Media" }, Array.Empty<Genres>(), Array.Empty<string>());
            }
            else if (clickedButton.Name == "navButton_comics")
            {
                ChangeNavLabelText("Comics");
                conditions = new SortMediacs(new[] { "Comics" }, Array.Empty<Genres>(), Array.Empty<string>());
            }
            else if (clickedButton.Name == "navButton_book")
            {
                ChangeNavLabelText("Books");
                conditions = new SortMediacs(new[] { "Book" }, Array.Empty<Genres>(), Array.Empty<string>());
            }
            else if (clickedButton.Name == "navButton_games")
            {
                ChangeNavLabelText("Games");
                conditions = new SortMediacs(new[] { "Game" }, Array.Empty<Genres>(), Array.Empty<string>());
            }

            createMediaListPanel();
        }

        private void NavNameLabel_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ChangeNavLabelText("⌂ Home");
            createMainMediaPanel();
        }

        private void GoToNewMedia_button_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            conditions = new SortMediacs();
            ChangeNavLabelText("New");
            createMediaListPanel();    
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                currentUser = loginForm.LoggedInUser;
                MessageBox.Show($"Welcome, {currentUser.Nickname}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                navTableLayoutPanel.Controls.RemoveAt(4);
                addUserPanel(currentUser);
            }
        }

        private void UserPanel_Click(object sender, EventArgs e)
        {
            if (userNav == null) createUserNav(currentUser.Role.ToString()); 
            if (!mainPanel.Controls.Contains(userNav))
            {
                mainPanel.Controls.Add(userNav);
                userNav.Visible = false;
                userNav.BringToFront();
            }

            
            userNav.Visible = !userNav.Visible;
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            //mainPanel.Controls.Clear();
            //createProfile(currentUser);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            navTableLayoutPanel.Controls.RemoveAt(4);
            currentUser = new User();
            Properties.Settings.Default.savedLogin = "";
            Properties.Settings.Default.savedPassword = "";
            Properties.Settings.Default.Save();
            if (loginButton == null) createLoginButton();
            navTableLayoutPanel.Controls.Add(loginButton, 4, 0);
            createMainMediaPanel();
        }

        private void ProfileSettingsButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ChangeNavLabelText("New");
            createSettingsPanel(currentUser);
        }

        private void AddButton_Click(string type)
        {
            MainMediaType mediaType = MainMediaType.Media;
            if (type == "book") mediaType = MainMediaType.Book;

            AddingForm adding = new AddingForm(type, mediaType, currentUser.Id);
            adding.ShowDialog();
        }

        private void SaveUserSettingsButton_Click()
        {
            User newInfoCuurrentUser = new User(currentUser);

            if (!string.IsNullOrEmpty(SettingNickname.Text)) newInfoCuurrentUser.Nickname = SettingNickname.Text;
            if (!string.IsNullOrEmpty(SettingEmail.Text)) newInfoCuurrentUser.Email = SettingEmail.Text;
            if (!string.IsNullOrEmpty(Description.Text)) newInfoCuurrentUser.UserDescription = Description.Text;
            if (!string.IsNullOrEmpty(imageUrl.Text)) newInfoCuurrentUser.UserImageURL = imageUrl.Text;
            if (birthdayPicker.GetSelectedDate() != null) newInfoCuurrentUser.BirthdayDate = birthdayPicker.GetSelectedDate();

            string currentPasswword = SettingCurrentPassword.Text;
            string newPasswword = SettingNewPassword.Text;

            MediaService.ChangeUserInfo(newInfoCuurrentUser, currentPasswword, newPasswword);
        }
        #endregion


        #region Enter/Leave events
        [DebuggerStepThrough]
        private void ChangeButtonForeColor(Label button, Color newColor)
        {
            if (button != null) button.ForeColor = newColor;
        }

        [DebuggerStepThrough]
        private void NavButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button navButton)
            {
                navButton.BackColor = Color.White;
                navButton.ForeColor = Color.Black;
            }
        }
        [DebuggerStepThrough]
        private void NavButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button navButton)
            {
                navButton.BackColor = Color.FromArgb(58, 58, 58);
                navButton.ForeColor = Color.White;
            }
        }

        [DebuggerStepThrough]
        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Search")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black;
            }
        }
        [DebuggerStepThrough]
        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBox.Text = "Search";
                searchTextBox.ForeColor = Color.Gray;
            }
        }
        #endregion
        #region logic
        private void Verification(string ul = "Kirito", string up = "1234")
        {
            currentUser = MediaService.CheckLogin(ul, up);
            if (currentUser.Role != UserRole.Guest)
            {
                addUserPanel(currentUser);
                Console.WriteLine("Login Succesfull");
            }
            else
            {
                if (loginButton == null) createLoginButton();
                navTableLayoutPanel.Controls.Add(loginButton, 4, 0);
                Console.WriteLine("Login isn`t Succesfull");
            }
        }

        private void ChangeNavLabelText(string newNavPageName)
        {
            currentNavPage = newNavPageName;
            navButton.Text = currentNavPage;
        }

        #endregion
    }
}
