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
        private bool isAboveThreshold = false;

        // <summary>
        /// Initializes a new instance of the <see cref="HomeForm"/> class.
        /// Sets up the theme, minimum size, and event handlers for form resizing.
        /// </summary>
        public HomeForm()
        {
            userTheme = new Class.Theme(Properties.Settings.Default.isDarkTheme);

            InitializeComponent();
            this.Resize += new EventHandler(HomeForm_Resize);
            this.MinimumSize = new Size(800, 600);

            createMainMediaPanel();
            Verification(Properties.Settings.Default.savedLogin, Properties.Settings.Default.savedPassword);
        }
        #region Resizing

        /// <summary>
        /// Handles the Resize event, calling <see cref="ResizeControls"/> to adjust all child components' sizes and positions.
        /// </summary>
        private void HomeForm_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }
        /// <summary>
        /// Resizes and repositions the main layout and panels based on the current size of the form.
        /// </summary>
        private void ResizeControls()
        {
            mainTableLayoutPanel.Size = this.ClientSize;
            navTableLayoutPanel.Width = this.ClientSize.Width;

            NavMenuResize();
            RecentMediaPanelResize();
            UserPanelLocation();
            ProfileSettingsPanelResize();
            RecentMediaInfoPanelResize();
            ProfilePanelResize();
        }

        /// <summary>
        /// Adjusts the size and location of the navigation menu panel.
        /// </summary>
        private void NavMenuResize()
        {
            if (navMenuPanel != null)
            {
                navMenuPanel.Size = new Size(navButton.Width, 200);
                navMenuPanel.Location = new Point(navButton.Location.X, navButton.Location.Y);
            }
        }

        /// <summary>
        /// Resizes and repositions the recent media panel to fit proportionally within the main panel.
        /// Also adjusts the size and position of the button and sub-elements.
        /// </summary>
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

        /// <summary>
        /// Resizes sub-elements within the recent media panel, including the history and navigation panel.
        /// </summary>
        private void RecentMediaPanelElementsResize()
        {
            if (MediaPanel != null && mediaBlocksPanel != null && mediaHistoryAndNavPanel != null)
            {
                int widthPanel = (int)(MediaPanel.Width * 0.95);
                int heightBlocksPanel = (int)(MediaPanel.Height * 0.6);
                int heightHAVPanel = (int)(MediaPanel.Height * 0.2);

                mediaBlocksPanel.Size = new Size(widthPanel, heightBlocksPanel);
                mediaHistoryAndNavPanel.Size = new Size(widthPanel, heightHAVPanel);

                mediaBlocksPanel.Location = new Point((MediaPanel.Width - widthPanel) / 2, 60);
                mediaHistoryAndNavPanel.Location = new Point((MediaPanel.Width - widthPanel) / 2, mediaBlocksPanel.Bottom + 10);
            }
        }

        /// <summary>
        /// Adjusts the size and location of the "Go to New Media" button.
        /// </summary>
        private void GoToNewMediaButtonResize()
        {
            if (MediaPanel != null && goToNewMediaButton != null)
            {
                int widthButton = (int)(MediaPanel.Width * 0.95);
                int heightButton = 25;

                goToNewMediaButton.Size = new Size(widthButton, heightButton);
                goToNewMediaButton.Location = new Point((MediaPanel.Width - widthButton) / 2, 25);
            }
        }

        /// <summary>
        /// Adjusts the location of the user navigation panel based on the user panel's location.
        /// </summary>
        private void UserPanelLocation()
        {
            if (userNav != null && userPanel != null)
            {
                userNav.Location = new Point(userPanel.Location.X, userPanel.Location.Y);
            }
        }

        /// <summary>
        /// Resizes and repositions the profile settings panel, keeping it centered within the main panel.
        /// </summary>
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

        /// <summary>
        /// Resizes and repositions the recent media info panel. Adjusts content based on height thresholds.
        /// </summary>
        private void RecentMediaInfoPanelResize()
        {
            if (MediaInfoControlPanel != null && currentMediaUse != null)
            {
                int widthNewMedia = (int)(mainPanel.Width * 0.75);
                int heightNewMedia = (int)(mainPanel.Height * 0.95);

                int xPosition = (mainPanel.Width - widthNewMedia) / 2;
                int yPosition = (mainPanel.Height - heightNewMedia) / 2;

                MediaInfoControlPanel.Size = new Size(widthNewMedia, heightNewMedia);
                MediaInfoControlPanel.Location = new Point(xPosition, yPosition);

                TableLayoutPanel panel = MediaInfoControlPanel.Controls[0] as TableLayoutPanel;

                if (heightNewMedia > 700 && !isAboveThreshold)
                {
                    isAboveThreshold = true;
                    if (panel != null)
                    {
                        panel.Controls.Clear();
                        panel.Controls.Add(mediaInfo(currentMediaUse), 0, 0);
                        panel.Controls.Add(createMainResponsePanel(currentMediaUse, isOnly: false), 0, 1);
                    }
                }
                else if (heightNewMedia <= 700 && isAboveThreshold)
                {
                    isAboveThreshold = false;
                    if (panel != null)
                    {
                        panel.Controls.Clear();
                        panel.Controls.Add(mediaInfo(currentMediaUse), 0, 0);
                        showResponseButton(isResponse: false, panel, currentMediaUse);
                    }
                }
                ResponsePanelResize();
            }
        }

        /// <summary>
        /// Adjusts the size of individual response panels within the response flow layout panel.
        /// </summary>
        private void ResponsePanelResize()
        {
            if (responseFlowLayoutPanel != null)
            {
                foreach (Control p in responseFlowLayoutPanel.Controls)
                {
                    if (p is Panel)
                    {
                        p.Width = responseFlowLayoutPanel.Width;
                        p.Height = 200;
                    }
                }
            }
        }

        /// <summary>
        /// Resizes and repositions the profile panel, keeping it centered and maintaining a maximum size.
        /// </summary>
        private void ProfilePanelResize()
        {
            if (ProfilePanel != null)
            {
                int widthNewMedia = (int)(mainPanel.Width * 0.75);
                int heightNewMedia = 500;

                if (widthNewMedia > 800) widthNewMedia = 880;
                if (heightNewMedia > 500) heightNewMedia = 500;

                int xPosition = (mainPanel.Width - widthNewMedia) / 2;
                int yPosition = (mainPanel.Height - heightNewMedia) / 2;

                ProfilePanel.Size = new Size(widthNewMedia, heightNewMedia);
                ProfilePanel.Location = new Point(xPosition, yPosition);
            }
        }

        #endregion

        #region Click
        /// <summary>
        /// Toggles the visibility of the navigation menu panel. Initializes it if it doesn't already exist.
        /// </summary>
        /// <param name="sender">The object that triggered the event, expected to be a Button.</param>
        /// <param name="e">The event arguments.</param>
        private void NavButton_Click(object sender, EventArgs e)
        {
            if (navMenuPanel == null) createNavMediaMenuPanel();
            if (!mainPanel.Controls.Contains(navMenuPanel))
            {
                mainPanel.Controls.Add(navMenuPanel);
                navMenuPanel.Visible = false;
                navMenuPanel.BringToFront();
            }

            navMenuPanel.Visible = !navMenuPanel.Visible;
        }

        /// <summary>
        /// Handles click events on navigation buttons that filter media by type (e.g., "Media", "Comics").
        /// Sets the sorting conditions based on the selected type and updates the displayed media list.
        /// </summary>
        /// <param name="sender">The object that triggered the event, expected to be a Button.</param>
        /// <param name="e">The event arguments.</param>
        private void NavButton_type_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            Button clickedButton = sender as Button;

            if (clickedButton.Name == "navButton_media")
            {
                ChangeNavLabelText("Media");
                conditions = new SortConditions(new[] { "Media" }, Array.Empty<Genres>(), Array.Empty<string>(), Array.Empty<string>(), currentUser.Id);
            }
            else if (clickedButton.Name == "navButton_comics")
            {
                ChangeNavLabelText("Comics");
                conditions = new SortConditions(new[] { "Comics" }, Array.Empty<Genres>(), Array.Empty<string>(), Array.Empty<string>(), currentUser.Id);
            }
            else if (clickedButton.Name == "navButton_book")
            {
                ChangeNavLabelText("Books");
                conditions = new SortConditions(new[] { "Book" }, Array.Empty<Genres>(), Array.Empty<string>(), Array.Empty<string>(), currentUser.Id);
            }
            else if (clickedButton.Name == "navButton_games")
            {
                ChangeNavLabelText("Games");
                conditions = new SortConditions(new[] { "Game" }, Array.Empty<Genres>(), Array.Empty<string>(), Array.Empty<string>(), currentUser.Id);
            }

            createMediaListPanel();
        }

        /// <summary>
        /// Navigates back to the home view when the navigation label is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event, expected to be a Button.</param>
        /// <param name="e">The event arguments.</param>
        private void NavNameLabel_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ChangeNavLabelText("⌂ Home");
            createMainMediaPanel();
        }

        /// <summary>
        /// Clears the main panel and loads a list of new media. Updates the navigation label to "New".
        /// </summary>
        /// <param name="sender">The object that triggered the event, expected to be a Button.</param>
        /// <param name="e">The event arguments.</param>
        private void GoToNewMedia_button_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            conditions = new SortConditions();
            ChangeNavLabelText("New");
            createMediaListPanel();
        }

        /// <summary>
        /// Opens the login form. Upon successful login, updates the current user and displays a welcome message.
        /// </summary>
        /// <param name="sender">The object that triggered the event, expected to be a Button.</param>
        /// <param name="e">The event arguments.</param>
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

        /// <summary>
        /// Toggles the visibility of the user navigation panel. Initializes it if it doesn't already exist.
        /// </summary>
        /// <param name="sender">The object that triggered the event, expected to be a Button.</param>
        /// <param name="e">The event arguments.</param>
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

        /// <summary>
        /// Clears the main panel and displays the user's profile information.
        /// </summary>
        /// <param name="sender">The object that triggered the event, expected to be a Button.</param>
        /// <param name="e">The event arguments.</param>
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AddUserProfile();
        }

        /// <summary>
        /// Logs out the current user, clears saved login details, and displays the login button.
        /// </summary>
        /// <param name="sender">The object that triggered the event, expected to be a Button.</param>
        /// <param name="e">The event arguments.</param>
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

        /// <summary>
        /// Loads a list of completed media items when the "My Media List" button is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event, expected to be a Button.</param>
        /// <param name="e">The event arguments.</param>
        private void MyMediaList_Click(object sender, EventArgs e)
        {
            LoadMedia("Media", "Completed");
        }

        /// <summary>
        /// Clears the main panel and opens the profile settings panel for the current user.
        /// </summary>
        /// <param name="sender">The object that triggered the event, expected to be a Button.</param>
        /// <param name="e">The event arguments.</param>
        private void ProfileSettingsButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ChangeNavLabelText("New");
            createSettingsPanel(currentUser);
        }

        /// <summary>
        /// Opens the "Add Media" form with the specified media type, allowing the user to add new items.
        /// </summary>
        /// <param name="type">The type of media to add (e.g., "book").</param>
        private void AddButton_Click(string type)
        {
            MainMediaType mediaType = MainMediaType.Media;
            if (type == "book") mediaType = MainMediaType.Book;

            AddingForm adding = new AddingForm(type, mediaType, currentUser.Id);
            adding.ShowDialog();
        }

        /// <summary>
        /// Saves the current user's settings, including nickname, email, description, image URL, and birthday.
        /// Updates the user's password if provided.
        /// </summary>
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
        /// <summary>
        /// Changes the foreground color of a specified label.
        /// </summary>
        /// <param name="button">The label control whose foreground color will be changed.</param>
        /// <param name="newColor">The color to set for the label's foreground.</param>
        [DebuggerStepThrough]
        private void ChangeButtonForeColor(Label button, Color newColor)
        {
            if (button != null) button.ForeColor = newColor;
        }

        /// <summary>
        /// Handles the mouse enter event for navigation buttons, changing background
        /// and foreground colors to indicate focus.
        /// </summary>
        /// <param name="sender">The object that triggered the event, expected to be a Button.</param>
        /// <param name="e">The event arguments.</param>
        [DebuggerStepThrough]
        private void NavButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button navButton)
            {
                navButton.BackColor = userTheme.getMouseEnterButtonColor();
                navButton.ForeColor = userTheme.getMouseEnterButtonTextColor();
            }
        }

        /// <summary>
        /// Handles the mouse leave event for navigation buttons, restoring
        /// background and foreground colors to their default state.
        /// </summary>
        /// <param name="sender">The object that triggered the event, expected to be a Button.</param>
        /// <param name="e">The event arguments.</param>
        [DebuggerStepThrough]
        private void NavButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button navButton)
            {
                navButton.BackColor = userTheme.getDefaultButtonColor();
                navButton.ForeColor = userTheme.getLabelTextColor();
            }
        }

        /// <summary>
        /// Handles the focus enter event for the search text box. Clears placeholder
        /// text ("Search") and sets the text color to black.
        /// </summary>
        /// <param name="sender">The object that triggered the event, expected to be a text box.</param>
        /// <param name="e">The event arguments.</param>
        [DebuggerStepThrough]
        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Search")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Handles the focus leave event for the search text box. Restores placeholder
        /// text and sets the text color to gray if the box is empty.
        /// </summary>
        /// <param name="sender">The object that triggered the event, expected to be a text box.</param>
        /// <param name="e">The event arguments.</param>
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
        /// <summary>
        /// Verifies user credentials and displays the user panel if authenticated.
        /// Adds a login button if authentication fails.
        /// </summary>
        /// <param name="ul">The username or login.</param>
        /// <param name="up">The user password.</param>
        private void Verification(string ul, string up)
        {
            currentUser = MediaService.CheckLogin(ul, up);
            if (currentUser.Role != UserRole.Guest)
            {
                addUserPanel(currentUser);
            }
            else
            {
                if (loginButton == null) createLoginButton();
                navTableLayoutPanel.Controls.Add(loginButton, 4, 0);
            }
        }

        /// <summary>
        /// Updates the navigation button's text with the specified page name.
        /// </summary>
        /// <param name="newNavPageName">The name of the new navigation page to display.</param>
        private void ChangeNavLabelText(string newNavPageName)
        {
            currentNavPage = newNavPageName;
            navButton.Text = currentNavPage;
        }

        /// <summary>
        /// Toggles between light and dark themes, updating the appearance of the navigation
        /// and main panels and recreating user settings. Saves the theme setting for future sessions.
        /// </summary>
        private void ThemeButton()
        {
            userTheme.DarkTheme = Properties.Settings.Default.isDarkTheme = !userTheme.DarkTheme;
            Properties.Settings.Default.Save();
            this.navTableLayoutPanel.BackColor = userTheme.getNavPanelColor();
            this.navNameLabel.ForeColor = userTheme.getLabelTextColor();
            this.navButton.BackColor = userTheme.getDefaultButtonColor();
            this.navButton.ForeColor = userTheme.getLabelTextColor();
            this.searchButton.ForeColor = userTheme.getLabelTextColor();
            this.mainPanel.BackColor = userTheme.getMainPanelColor();
            mainPanel.Controls.Clear();
            userNav = null;
            navMenuPanel = null;
            navTableLayoutPanel.Controls.RemoveAt(4);
            addUserPanel(currentUser);
            createSettingsPanel(currentUser);
        }

        /// <summary>
        /// Clears the main panel and updates the navigation label based on the specified
        /// media type and status. Initializes media loading conditions and displays the media list panel.
        /// </summary>
        /// <param name="mediaType">The type of media to load (e.g., Book, Game).</param>
        /// <param name="Status">The status of the media (e.g., available, watched, read).</param>
        private void LoadMedia(string mediaType, string Status)
        {
            mainPanel.Controls.Clear();
            ChangeNavLabelText(mediaType);
            conditions = new SortConditions(Array.Empty<string>(), Array.Empty<Genres>(), new[] { Status }, Array.Empty<string>(), currentUser.Id);

            createMediaListPanel();
        }
        #endregion
    }
}
