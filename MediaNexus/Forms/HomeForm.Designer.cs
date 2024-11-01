using MediaNexus.Forms;
using MediaNexus_Backend;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MediaNexus.Class;
using System.Runtime.Serialization;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Net.WebRequestMethods;


namespace MediaNexus
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        SortMedia conditions;
        Theme userTheme;
        MainMedia currentMediaUse;

        private IContainer components = null;
        string currentNavPage = "⌂ Home";
        private int currentPage = 0;
        private int currentMediaCols = 0;
        private int currentMediaRows = 0;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.navTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.navNameLabel = new System.Windows.Forms.Label();
            this.navButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.navTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mainTableLayoutPanel.SuspendLayout();
            this.navTableLayoutPanel.SuspendLayout();
            this.navTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            this.mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.navTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.mainPanel, 0, 1);
            this.mainTableLayoutPanel.Dock = DockStyle.Fill;
            this.mainTableLayoutPanel.Margin = new Padding(0);
            // 
            // navTableLayoutPanel
            // 
            this.navTableLayoutPanel.BackColor = userTheme.getNavPanelColor();
            this.navTableLayoutPanel.RowCount = 1;
            this.navTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.navTableLayoutPanel.ColumnCount = 5;
            this.navTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            this.navTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            this.navTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            this.navTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            this.navTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.navTableLayoutPanel.Controls.Add(this.navNameLabel, 0, 0);
            this.navTableLayoutPanel.Controls.Add(this.navButton, 1, 0);
            this.navTableLayoutPanel.Controls.Add(this.searchTextBox, 2, 0);
            this.navTableLayoutPanel.Controls.Add(this.searchButton, 3, 0);
            this.navTableLayoutPanel.Dock = DockStyle.Fill;
            this.navTableLayoutPanel.Location = new Point(0, 0);
            this.navTableLayoutPanel.Margin = new Padding(0);
            // 
            // navNameLabel
            // 
            this.navNameLabel.AutoSize = true;
            this.navNameLabel.Cursor = Cursors.Hand;
            this.navNameLabel.Dock = DockStyle.Fill;
            this.navNameLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.navNameLabel.ForeColor = userTheme.getLabelTextColor();
            this.navNameLabel.Margin = new Padding(0);
            this.navNameLabel.Text = "MediaNexus";
            this.navNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.navNameLabel.Click += new System.EventHandler(this.NavNameLabel_Click);
            // 
            // navButton
            // 
            this.navButton.BackColor = userTheme.getDefaultButtonColor();
            this.navButton.Cursor = Cursors.Hand;
            this.navButton.Dock = DockStyle.Fill;
            this.navButton.FlatStyle = FlatStyle.Flat;
            this.navButton.FlatAppearance.BorderSize = 0;   
            this.navButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204); 
            this.navButton.ForeColor = userTheme.getLabelTextColor();
            this.navButton.Margin = new Padding(0);
            this.navButton.Name = "navButton";
            this.navButton.Text = "⌂ Home";
            this.navButton.UseVisualStyleBackColor = false;
            this.navButton.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor =AnchorStyles.Left | AnchorStyles.Right;
            this.searchTextBox.ForeColor = Color.Gray;
            this.searchTextBox.Margin = new Padding(10, 0, 0, 0);
            this.searchTextBox.Size = new Size(408, 22);
            this.searchTextBox.Text = "Search";
            this.searchTextBox.Enter += new EventHandler(this.SearchTextBox_Enter);
            this.searchTextBox.Leave += new EventHandler(this.SearchTextBox_Leave);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = Color.Transparent;
            this.searchButton.Cursor = Cursors.Hand;
            this.searchButton.Dock = DockStyle.Top;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.searchButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.searchButton.FlatStyle = FlatStyle.Flat;
            this.searchButton.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = userTheme.getLabelTextColor();
            this.searchButton.Margin = new Padding(0);
            this.searchButton.Size = new Size(59, 40);
            this.searchButton.Text = "🔍";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = DockStyle.Fill;
            this.mainPanel.Margin = new Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.BackColor = userTheme.getMainPanelColor();
            this.mainPanel.TabIndex = 1;

            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Text = "MediaNexus";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.navTableLayoutPanel.ResumeLayout(false);
            this.navTableLayoutPanel.PerformLayout();
            this.navTableLayout.ResumeLayout(false);
            this.navTableLayout.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        #region Media Navigation Panel
        /// <summary>
        /// Creates and configures a navigation menu panel containing buttons for different media types.
        /// </summary>
        private void createNavMediaMenuPanel()
        {
            this.navButton.Text = currentNavPage;
            Panel mediaNav = Components.createPanel(navButton.Width, 200, userTheme.getDefaultButtonColor(), mainPanel);
            mediaNav.Visible = false;
            mediaNav.Location = new Point(navButton.Location.X, navButton.Location.Y);
            mediaNav.Margin = new System.Windows.Forms.Padding(4);

            TableLayoutPanel mediaNavLayout = Components.CreateTableLayoutPanel(5, 1,
            rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 25F), new RowStyle(SizeType.Absolute, 43F), new RowStyle(SizeType.Absolute, 43F), new RowStyle(SizeType.Absolute, 43F), new RowStyle(SizeType.Absolute, 43F) },
            colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });

            mediaNav.Controls.Add(mediaNavLayout);
            mediaNavLayout.Controls.Add(Components.createLabel("navLabel_base", "Database:", userTheme.getLabelTextColor()), 0, 0);
            mediaNavLayout.Controls.Add(createNavMediaButton("navButton_media", "Media"), 0, 1);
            mediaNavLayout.Controls.Add(createNavMediaButton("navButton_book", "Books"), 0, 2);
            mediaNavLayout.Controls.Add(createNavMediaButton("navButton_comics", "Comics"), 0, 3);
            mediaNavLayout.Controls.Add(createNavMediaButton("navButton_games", "Games"), 0, 4);

            this.mainPanel.Controls.Add(this.navMenuPanel = mediaNav);
            navMenuPanel.BringToFront();
        }
        /// <summary>
        /// Creates a styled navigation button for the media navigation panel with specified name and text.
        /// </summary>
        /// <param name="buttonName">The name to assign to the button, used as its identifier.</param>
        /// <param name="buttonText">The text to display on the button.</param>
        /// <returns>A configured <see cref="Button"/> with event handlers.</returns>
        private Button createNavMediaButton(string buttonName, string buttonText)
        {
            var button = new Button
            {
                BackColor = userTheme.getDefaultButtonColor(),
                Cursor = Cursors.Hand,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204),
                ForeColor = userTheme.getDefaultButtonTextColor(),
                Margin = new Padding(0),
                Name = buttonName,
                TabIndex = 3,
                Text = buttonText,
                TextAlign = ContentAlignment.MiddleLeft,
            };

            button.Click += NavButton_type_Click;
            button.MouseEnter += NavButton_MouseEnter;
            button.MouseLeave += NavButton_MouseLeave;

            button.FlatAppearance.BorderSize = 0;

            return button;
        }
        #endregion

        #region Reccent Media Panel
        /// <summary>
        /// Initializes and configures the main media panel within the application, setting its dimensions,
        /// background color, and adding necessary child controls such as a "All Media" button, a recent media panel,
        /// and a media history/navigation panel.
        /// </summary>
        private void createMainMediaPanel()
        {
            MediaPanel = Components.createPanel(width: (int)(mainPanel.Width * 0.75), height: (int)(mainPanel.Height * 0.85), backColor: userTheme.getPanelColor(), mainPanel);

            MediaPanel.Controls.Add(createGoToAllMediaButton());
            AddRecentMediaPanel();
            createMediaHistoryAndNavPanel();

            mainPanel.Controls.Add(MediaPanel);
        }

        /// <summary>
        /// Creates and configures a button panel that navigates to the "All Media" section.
        /// Event handlers are attached to handle mouse interactions and navigation.
        /// </summary>
        /// <returns>A configured <see cref="Panel"/> that acts as a button to navigate to the "All Media" section.</returns>
        private Panel createGoToAllMediaButton()
        {
            int widthButton = (int)(MediaPanel.Width * 0.95);
            int heightButton = 25;

            int xPosition = (MediaPanel.Width - widthButton) / 2;
            int yPosition = 25;

            goToNewMediaButton = new Panel()
            {
                Size = new Size(widthButton, heightButton),
                Location = new Point(xPosition, yPosition),
                BackColor = userTheme.getDefaultButtonColor(),
            };

            var goButtonLayout = Components.CreateTableLayoutPanel(1, 2,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 100)}, 
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 85F), new ColumnStyle(SizeType.Percent, 15F)},
                Cursors.Hand);

            Label buttonLabel = new Label()
            {
                AutoSize = true,
                Text = "Go to all media",
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                Anchor = AnchorStyles.Left,
                ForeColor = userTheme.getDefaultButtonTextColor(),
                Cursor = Cursors.Hand
            };

            Label arrowLabel = new Label()
            {
                AutoSize = true,
                Text = ">",
                TextAlign = ContentAlignment.MiddleRight,
                Dock = DockStyle.Fill,
                Anchor = AnchorStyles.Right,
                ForeColor = userTheme.getDefaultButtonTextColor(),
                Cursor = Cursors.Hand
            };

            Label[] labels = { buttonLabel, arrowLabel };
            foreach (Label label in labels)
            {
                label.MouseEnter += (s, e) =>
                {
                    ChangeButtonForeColor(buttonLabel, userTheme.getMouseEnterButtonTextColor());
                    ChangeButtonForeColor(arrowLabel, userTheme.getMouseEnterButtonTextColor());
                };
                label.Click += this.GoToNewMedia_button_Click;
                label.MouseLeave += (s, e) =>
                {
                    ChangeButtonForeColor(buttonLabel, userTheme.getDefaultButtonTextColor());
                    ChangeButtonForeColor(arrowLabel, userTheme.getDefaultButtonTextColor());
                };
            }

            goButtonLayout.Controls.Add(buttonLabel, 0, 0);
            goButtonLayout.Controls.Add(arrowLabel, 1, 0);
            goToNewMediaButton.Controls.Add(goButtonLayout);

            goButtonLayout.MouseEnter += (s, e) =>
            {
                ChangeButtonForeColor(buttonLabel, userTheme.getMouseEnterButtonTextColor());
                ChangeButtonForeColor(arrowLabel, userTheme.getMouseEnterButtonTextColor());
            };
            goButtonLayout.Click += this.GoToNewMedia_button_Click;
            goButtonLayout.MouseLeave += (s, e) =>
            {
                ChangeButtonForeColor(buttonLabel, userTheme.getDefaultButtonTextColor());
                ChangeButtonForeColor(arrowLabel, userTheme.getDefaultButtonTextColor());
            };

            return goToNewMediaButton;
        }

        /// <summary>
        /// Add and configures the recent media panel within the main media panel, setting its size, position, 
        /// and adding a layout for displaying last 5 media blocks with default sorting conditions.
        /// </summary>
        private void AddRecentMediaPanel()
        {
            int panelWidth = (int)(MediaPanel.Width * 0.95);
            int panelHeight = (int)(MediaPanel.Height * 0.6);

            int xPosition = (MediaPanel.Width - panelWidth) / 2;
            int yPosition = 60;

            mediaBlocksPanel = new Panel()
            {
                Size = new Size(panelWidth, panelHeight),
                Location = new Point(xPosition, yPosition)
            };

            conditions = new SortMedia();
            mediaBlocksTableLayoutPanel = CreateMediaBlocks(5, 1, 1);

            mediaBlocksPanel.Controls.Add(mediaBlocksTableLayoutPanel);
            MediaPanel.Controls.Add(mediaBlocksPanel);
        }

        /// <summary>
        /// Creates a <see cref="TableLayoutPanel"/> containing media blocks arranged in a specified number of columns and rows.
        /// Media blocks are populated with media items filtered by the current sorting conditions and displayed according to the specified page.
        /// </summary>
        /// <param name="columnCount">The number of columns in the layout.</param>
        /// <param name="rowCount">The number of rows in the layout.</param>
        /// <param name="numPage">The page number to fetch a specific set of media items.</param>
        /// <returns>A configured <see cref="TableLayoutPanel"/> populated with media blocks for the specified page.</returns>
        private TableLayoutPanel CreateMediaBlocks(int columnCount, int rowCount, int numPage)
        {
            var mediaBlocksTableLayoutPanel = Components.CreateTableLayoutPanel(rowCount, columnCount);

            var RecentMedia = MediaService.GetFilteredMedia(conditions, columnCount * rowCount, numPage);

            for (int i = 0; i < rowCount; i++)
            {
                mediaBlocksTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / rowCount));
                for (int j = 0; j < columnCount; j++)
                {
                    mediaBlocksTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columnCount));

                    int currentIndex = (i * columnCount) + j;
                    if (currentIndex >= RecentMedia.Length) continue;

                    var mediaBlock = CreateRecentMediaBlock(RecentMedia[currentIndex].Id.ToString(), RecentMedia[currentIndex]);

                    mediaBlocksTableLayoutPanel.Controls.Add(mediaBlock, j, i);
                }
            }

            return mediaBlocksTableLayoutPanel;
        }

        /// <summary>
        /// Creates a media block panel for displaying a media item, including its image, title, and studio label. 
        /// The media block is interactive, with event handlers for mouse interactions and navigation to a detailed view of the media item.
        /// </summary>
        /// <param name="name">The unique name identifier for the media block panel.</param>
        /// <param name="currentMedia">The media item of type <see cref="MainMedia"/> to display within the block.</param>
        /// <returns>A configured <see cref="Panel"/> representing the media block.</returns>
        private Panel CreateRecentMediaBlock(string name, MainMedia currentMedia)
        {
            var mediaBlock = new Panel()
            {
                Dock = DockStyle.Fill,
                Name = $"MediaBlock_{name}",
                Margin = new System.Windows.Forms.Padding(5),
                Tag = currentMedia,
            };

            var mediaBlockTableLayoutPanel = Components.CreateTableLayoutPanel(3, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 85), new RowStyle(SizeType.Percent, 7.5F), new RowStyle(SizeType.Percent, 7.5F) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F)},
                Cursors.Hand);


            var pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = string.IsNullOrEmpty(currentMedia.ImageURL) ? Properties.Settings.Default.DefaultImageURL : currentMedia.ImageURL,
                Margin = new Padding(0),
                Cursor = Cursors.Hand,
            };

            mediaBlockTableLayoutPanel.Controls.Add(pictureBox, 0, 0);

            Label titleLabel = new Label
            {
                Dock = DockStyle.Fill,
                Text = currentMedia.OriginalName,
                TextAlign = ContentAlignment.MiddleLeft,
                MaximumSize = new Size(mediaBlock.Width, 0),
                Margin = new Padding(0),
                ForeColor = userTheme.getDefaultButtonTextColor(),
            };
            titleLabel.MouseEnter += (s, e) => ChangeButtonForeColor(titleLabel, userTheme.getMouseEnterButtonTextColor());
            titleLabel.MouseLeave += (s, e) => ChangeButtonForeColor(titleLabel, userTheme.getDefaultButtonTextColor());
            titleLabel.Click += (s, e) => addMediInfoPanel(currentMedia);

            Label studioLabel = new Label
            {
                Dock = DockStyle.Fill,
                Text = "currentMedia.Studio",
                MaximumSize = new Size(mediaBlock.Width, 0),
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0),
                ForeColor = userTheme.getDefaultButtonTextColor()
            };
            studioLabel.MouseEnter += (s, e) => ChangeButtonForeColor(titleLabel, userTheme.getMouseEnterButtonTextColor());
            studioLabel.MouseLeave += (s, e) => ChangeButtonForeColor(titleLabel, userTheme.getDefaultButtonTextColor());
            studioLabel.Click += (s, e) => addMediInfoPanel(currentMedia);

            pictureBox.MouseEnter += (s, e) => ChangeButtonForeColor(titleLabel, userTheme.getMouseEnterButtonTextColor());
            pictureBox.MouseLeave += (s, e) => ChangeButtonForeColor(titleLabel, userTheme.getDefaultButtonTextColor());
            pictureBox.Click += (s, e) => addMediInfoPanel(currentMedia);

            mediaBlockTableLayoutPanel.Controls.Add(titleLabel, 0, 1);
            mediaBlockTableLayoutPanel.Controls.Add(studioLabel, 0, 2);

            mediaBlock.Controls.Add(mediaBlockTableLayoutPanel);

            return mediaBlock;
        }

        /// <summary>
        /// Initializes and sets up the media history and navigation panel within the main media panel. 
        /// This panel includes buttons for navigating to different media categories such as Media, Books, and Comics, 
        /// as well as a section displaying media history. The layout is organized using a table layout with 
        /// specified column styles for responsiveness.
        /// </summary>
        private void createMediaHistoryAndNavPanel()
        {
            int widthPanel = (int)(MediaPanel.Width * 0.95);
            int heightPanel = (int)(MediaPanel.Height * 0.2);

            int xPosition = (MediaPanel.Width - widthPanel) / 2;
            int yPosition = mediaBlocksPanel.Bottom + 10;

            mediaHistoryAndNavPanel = new Panel()
            {
                Size = new Size(widthPanel, heightPanel),
                Location = new Point(xPosition, yPosition),
                Margin = new Padding(0)
            };

            var outerTableLayoutPanel = new TableLayoutPanel
            {
                AutoSize = true,
                ColumnCount = 7,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            outerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            for (int i = 1; i < 7; i++)
            {
                if (i % 2 == 0) outerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
                else outerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5f));
            }

            for (int i = 2; i < 7; i += 2)
            {
                string buttonName = (i == 2) ? "Media" :
                                    (i == 4) ? "Books" :
                                    "Comics";

                Color bgColor = (i == 2) ? Color.FromArgb(254, 221, 223) :
                                    (i == 4) ? Color.FromArgb(218, 241, 255) :
                                    Color.FromArgb(231, 246, 218);

                Color textColor = (i == 2) ? Color.FromArgb(252, 87, 94) :
                                    (i == 4) ? Color.FromArgb(68, 187, 255) :
                                    Color.FromArgb(116, 214, 31);

                Color bpColor = (i == 2) ? Color.FromArgb(254, 194, 197) :
                                    (i == 4) ? Color.FromArgb(188, 230, 255) :
                                    Color.FromArgb(215, 239, 195);

                var tagsTableLayoutPanel = new TableLayoutPanel
                {
                    AutoSize = true,
                    RowCount = 2,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(0),
                };

                tagsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30f));
                tagsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70f));

                Panel a = createMediaButton(buttonName, bgColor, textColor, bpColor);

                tagsTableLayoutPanel.Controls.Add(a, 0, 0);
                outerTableLayoutPanel.Controls.Add(tagsTableLayoutPanel, i, 0);
            }

            outerTableLayoutPanel.Controls.Add(createHistoryPanel(), 0, 0);
            mediaHistoryAndNavPanel.Controls.Add(outerTableLayoutPanel);
            MediaPanel.Controls.Add(mediaHistoryAndNavPanel);
        }

        /// <summary>
        /// Creates and configures a panel for displaying media history.
        /// The panel is styled with the user's theme color for history panels, 
        /// automatically sizes itself to its content, and fills the available space.
        /// </summary>
        /// <returns>A <see cref="Panel"/> configured for media history display.</returns>
        private Panel createHistoryPanel()
        {
            Panel panel = new Panel
            {
                AutoSize = true,
                BackColor = userTheme.getHistoryPanelColor(),
                Margin = new Padding(0),
                Dock = DockStyle.Fill,

            };

            return panel;
        }

        /// <summary>
        /// Creates a media button panel with specified text and color settings.
        /// The button consists of a background panel, a text label, and an arrow label,
        /// arranged using a TableLayoutPanel for proper alignment and responsiveness.
        /// </summary>
        /// <param name="buttonText">The text to be displayed on the button.</param>
        /// <param name="bgColor">The background color of the button.</param>
        /// <param name="textColor">The color of the text on the button.</param>
        /// <param name="bpColor">The color of the background panel behind the button.</param>
        /// <returns>A <see cref="Panel"/> representing the media button.</returns>
        private Panel createMediaButton(string buttonText, Color bgColor, Color textColor, Color bpColor)
        {
            Panel buttonPanel = new Panel
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                BackColor = bgColor,
                Margin = new Padding(0),
                Cursor = Cursors.Hand,
            };

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel()
            {
                AutoSize = true,
                ColumnCount = 3,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5f));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));

            Panel backPanel = new Panel
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                BackColor = bpColor,
            };
            tableLayoutPanel.Controls.Add(backPanel, 0, 0);

            Label textLabel = new Label
            {
                AutoSize = true,
                Text = buttonText,
                Dock = DockStyle.Fill,
                BackColor = bgColor,
                ForeColor = textColor,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0),
            };
            tableLayoutPanel.Controls.Add(textLabel, 1, 0);

            Label arrowLabel = new Label
            {
                AutoSize = true,
                Text = ">",
                Dock = DockStyle.Fill,
                BackColor = bgColor,
                ForeColor = textColor,
                TextAlign = ContentAlignment.MiddleRight,
                Margin = new Padding(0),
            };
            tableLayoutPanel.Controls.Add(arrowLabel, 2, 0);

            buttonPanel.Controls.Add(tableLayoutPanel);

            return buttonPanel;
        }
        #endregion

        #region Media Panel
        /// <summary>
        /// Creates and configures the media list panel with sorting options.
        /// This panel is displayed on the main application window and includes
        /// controls for filtering and sorting media items based on user selection.
        /// </summary>
        /// <param name="page">The current page number for pagination. Default is 1.</param>
        private void createMediaListPanel(int page = 1)
        {
            MediaPanel = Components.createPanel(width: (int)(mainPanel.Width * 0.75), height: (int)(mainPanel.Height * 0.85), backColor: userTheme.getPanelColor(), mainPanel);

            var MediaListControlTableLayout = Components.CreateTableLayoutPanel(1, 2,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 100)},
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 80f), new ColumnStyle(SizeType.Percent, 20f) });

            MediaPanel.Controls.Add(MediaListControlTableLayout);

            MediaListTableLayout = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 100), new RowStyle(SizeType.Absolute, 30f) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100f)});

            MediaListControlTableLayout.Controls.Add(MediaListTableLayout, 0, 0);

            MediaListControlTableLayout.Controls.Add(SortPanel(), 1, 0);
            AddMediaList(page);
            createPages();

            mainPanel.Controls.Add(MediaPanel);
        }

        /// <summary>
        /// Creates a sorting panel that contains various sorting options for media items.
        /// This panel includes sorting options for media type, genres, user lists, and media status.
        /// A search button is provided to trigger filtering based on the selected options.
        /// </summary>
        /// <returns>A <see cref="TableLayoutPanel"/> containing the sorting controls.</returns>
        private TableLayoutPanel SortPanel()
        {
            var main = Components.CreateTableLayoutPanel(4, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 20), new RowStyle(SizeType.Percent, 30), new RowStyle(SizeType.Percent, 20), new RowStyle(SizeType.Percent, 20),  new RowStyle(SizeType.Percent, 10)},
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });

            var mediaSort = CreateMediaSortPanel();
            var genresSort = CreateGenresSortPanel();
            var userListSort = CreateUserListSortPanel();
            var mediaStatusSort = CreateMediaStatusSortPanel();

            main.Controls.Add(mediaSort);
            main.Controls.Add(genresSort);
            main.Controls.Add(userListSort);
            main.Controls.Add(mediaStatusSort);

            var findButton = new Button
            {
                Text = "Search",
                Dock = DockStyle.Fill,
                ForeColor = userTheme.getLabelTextColor()
            };

            findButton.Click += (s, e) =>
            {   
                conditions.selectedTypes = GetSelectedOptions(mediaSort.Controls[1] as FlowLayoutPanel);
                conditions.selectedGenres = GetSelectedGenres(genresSort.Controls[1] as FlowLayoutPanel);
                conditions.selectedStatus = GetSelectedOptions(userListSort.Controls[1] as FlowLayoutPanel);
                conditions.selectedMediaStatus = GetSelectedOptions(mediaStatusSort.Controls[1] as FlowLayoutPanel);
                conditions.userID = currentUser.Id;
                AddMediaList(1);
                createPages();
            };
            main.Controls.Add(findButton);

            return main;
        }

        /// <summary>
        /// Retrieves the selected options from a flow layout panel containing checkboxes.
        /// Only the checked options are collected and returned as an array of strings.
        /// </summary>
        /// <param name="flowLayoutPanel">The <see cref="FlowLayoutPanel"/> containing checkboxes for options.</param>
        /// <returns>An array of strings representing the selected options.</returns>
        private string[] GetSelectedOptions(FlowLayoutPanel flowLayoutPanel)
        {
            var selectedOptions = new List<string>();

            foreach (var control in flowLayoutPanel.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    selectedOptions.Add(checkBox.Text);
                }
            }

            return selectedOptions.ToArray();
        }

        /// <summary>
        /// Retrieves the selected genres from a flow layout panel containing checkboxes.
        /// Each checked checkbox is converted into a <see cref="Genres"/> object and returned as an array.
        /// </summary>
        /// <param name="flowLayoutPanel">The <see cref="FlowLayoutPanel"/> containing checkboxes for genres.</param>
        /// <returns>An array of <see cref="Genres"/> objects representing the selected genres.</returns>
        private Genres[] GetSelectedGenres(FlowLayoutPanel flowLayoutPanel)
        {
            var selectedOptions = new List<Genres>();

            foreach (var control in flowLayoutPanel.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    var genreId = checkBox.Tag is int id ? id : Convert.ToInt32(checkBox.Tag);
                    selectedOptions.Add(new Genres(genreId, checkBox.Text));
                }
            }

            return selectedOptions.ToArray();
        }

        /// <summary>
        /// Creates a sorting panel specifically for media types.
        /// The panel includes a label and checkboxes for different media types such as Media, Book, Comics, and Game.
        /// </summary>
        /// <returns>A <see cref="TableLayoutPanel"/> containing the media type sorting controls.</returns>
        private TableLayoutPanel CreateMediaSortPanel()
        {
            var mediaSort = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 30), new RowStyle(SizeType.Percent, 100) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });

            mediaSort.Controls.Add(Components.createLabel("mediaLabel", "Media:", userTheme.getLabelTextColor()));
            var mediaTypes = new[] { "Media", "Book", "Comics", "Game" };
            mediaSort.Controls.Add(CreateMediaCheckBoxes(mediaTypes));

            return mediaSort;
        }

        /// <summary>
        /// Creates a sorting panel for genres.
        /// The panel includes a label and checkboxes for available genres retrieved from the media service.
        /// </summary>
        /// <returns>A <see cref="TableLayoutPanel"/> containing the genre sorting controls.</returns>
        private TableLayoutPanel CreateGenresSortPanel()
        {
            Genres[] genres = MediaService.GetGenres(); 

            var genresSort = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 30), new RowStyle(SizeType.Percent, 100) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });

            genresSort.Controls.Add(Components.createLabel("genresLabel", "Genres:", userTheme.getLabelTextColor()));
            genresSort.Controls.Add(CreateGenresCheckBoxes(genres));

            return genresSort;
        }

        /// <summary>
        /// Creates a sorting panel for user lists.
        /// The panel includes a label and checkboxes representing the status of media items (e.g., InProcess, Completed, Planned, Dropped).
        /// </summary>
        /// <returns>A <see cref="TableLayoutPanel"/> containing the user list sorting controls.</returns>
        private TableLayoutPanel CreateUserListSortPanel()
        {
            var userListSort = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 30), new RowStyle(SizeType.Percent, 100) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });

            userListSort.Controls.Add(Components.createLabel("userListLabel", "List:", userTheme.getLabelTextColor()));
            var mediaTypes = new[] { "InProcess", "Completed", "Planned", "Dropped" };
            
            userListSort.Controls.Add(CreateMediaCheckBoxes(mediaTypes));

            return userListSort;
        }

        /// <summary>
        /// Creates a sorting panel for media status.
        /// The panel includes a label and checkboxes for various media statuses such as Released, Ongoing, Announced, Canceled, and Delayed.
        /// </summary>
        /// <returns>A <see cref="TableLayoutPanel"/> containing the media status sorting controls.</returns>
        private TableLayoutPanel CreateMediaStatusSortPanel()
        {
            var mediaStatusSort = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 30), new RowStyle(SizeType.Percent, 100) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });

            mediaStatusSort.Controls.Add(Components.createLabel("mediaStatusLabel", "Status:", userTheme.getLabelTextColor()));
            var mediaStatus = new[] { "Released", "Ongoing", "Announced", "Canceled", "Delayed" };
            mediaStatusSort.Controls.Add(CreateMediaCheckBoxes(mediaStatus));

            return mediaStatusSort;
        }

        /// <summary>
        /// Creates a flow layout panel containing checkboxes for the specified media types.
        /// Each checkbox is labeled with the corresponding media type and styled with a specified background color.
        /// </summary>
        /// <param name="types">An array of strings representing media types (e.g., "Media", "Book", "Comics", "Game").</param>
        /// <returns>A <see cref="FlowLayoutPanel"/> containing checkboxes for the media types.</returns>
        private FlowLayoutPanel CreateMediaCheckBoxes(string[] types)
        {
            var flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = userTheme.getSortPanelColor()
            };

            foreach (var type in types)
            {
                var checkBox = Components.CreateCheckBox(type, Color.AliceBlue);
                flowLayoutPanel.Controls.Add(checkBox);
            }

            return flowLayoutPanel;
        }

        /// <summary>
        /// Creates a flow layout panel containing checkboxes for the specified genres.
        /// Each checkbox is labeled with the genre name and styled with a specified background color.
        /// The GenreID is stored in the checkbox's Tag property for later use.
        /// </summary>
        /// <param name="genres">An array of <see cref="Genres"/> objects representing available genres.</param>
        /// <returns>A <see cref="FlowLayoutPanel"/> containing checkboxes for the genres.</returns>
        private FlowLayoutPanel CreateGenresCheckBoxes(Genres[] genres)
        {
            var flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = userTheme.getSortPanelColor()
            };

            foreach (var genre in genres)
            {
                var checkBox = Components.CreateCheckBox(genre.GenreName, Color.AliceBlue);
                checkBox.Tag = genre.GenreID; // Optionally store GenreID in Tag for later use
                flowLayoutPanel.Controls.Add(checkBox);
            }

            return flowLayoutPanel;
        }

        /// <summary>
        /// Creates a pagination control for the media list, allowing navigation through pages of media items.
        /// If the pagination control already exists, it removes it before creating a new one.
        /// </summary>
        private void createPages()
        {
            if (MediaListTableLayout.Controls.Contains(pagesTableLayout))
            {
                MediaListTableLayout.Controls.Remove(pagesTableLayout);
                pagesTableLayout.Dispose();
            }

            int numMedia = MediaService.CountFilteredMedia(conditions);
            int numPages = (int)Math.Ceiling((double)numMedia / (currentMediaCols * currentMediaRows));

            int maxButtons = 15;
            int columnCount = 17;

            pagesTableLayout = Components.CreateTableLayoutPanel(1, columnCount);

            float columnPercentage = 100f / columnCount;
            for (int i = 0; i < columnCount; ++i)
                pagesTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columnPercentage));

            var leftArrowButton = new Button
            {
                Text = "<",
                BackColor = Color.LightBlue,
                Dock = DockStyle.Fill,
                Enabled = currentPage > 1
            };
            pagesTableLayout.Controls.Add(leftArrowButton, 0, 0);

            if (numPages <= maxButtons)
            {
                for (int i = 0; i < numPages; i++)
                {
                    var pageButton = CreatePageButton(i + 1, i == currentPage - 1);
                    pagesTableLayout.Controls.Add(pageButton, i + 1, 0);
                }
            }
            else
            {
                var firstPageButton = CreatePageButton(1, currentPage == 1);
                pagesTableLayout.Controls.Add(firstPageButton, 1, 0);

                int startPage = Math.Max(2, currentPage - 6);
                int endPage = Math.Min(numPages - 1, currentPage + 6);

                if (currentPage <= 7)
                {
                    startPage = 2;
                    endPage = 13;
                }
                else if (currentPage >= numPages - 7)
                {
                    startPage = numPages - 12;
                    endPage = numPages - 1;
                }

                for (int i = startPage; i <= endPage; i++)
                {
                    var pageButton = CreatePageButton(i, i == currentPage);
                    pagesTableLayout.Controls.Add(pageButton, i - startPage + 2, 0);
                }

                var lastPageButton = CreatePageButton(numPages, currentPage == numPages);
                pagesTableLayout.Controls.Add(lastPageButton, maxButtons, 0);
            }

            var rightArrowButton = new Button
            {
                Text = ">",
                Dock = DockStyle.Fill,
                BackColor = Color.LightBlue,
                Enabled = currentPage < numPages
            };
            pagesTableLayout.Controls.Add(rightArrowButton, columnCount - 1, 0);

            MediaListTableLayout.Controls.Add(pagesTableLayout, 0, 1);
        }

        /// <summary>
        /// Creates a button representing a specific page number for pagination.
        /// The button's appearance changes based on whether it is the current page or not.
        /// </summary>
        /// <param name="pageNumber">The number of the page the button represents.</param>
        /// <param name="isCurrent">A boolean indicating if this button is for the current page.</param>
        /// <returns>A <see cref="Button"/> representing the specified page.</returns>
        private Button CreatePageButton(int pageNumber, bool isCurrent)
        {
            var pageButton = new Button
            {
                Text = pageNumber.ToString(),
                Dock = DockStyle.Fill,
                BackColor = isCurrent ? Color.LightBlue : Color.White
            };

            pageButton.Click += (sender, e) =>
            {
                AddMediaList(pageNumber);
            };

            return pageButton;
        }

        /// <summary>
        /// Adds a list of media items to the display, based on the specified page number.
        /// If a media list already exists, it removes it before creating a new one.
        /// The media items are organized into blocks based on the current available space.
        /// </summary>
        /// <param name="pageNumber">The number of the page of media items to display.</param>
        private void AddMediaList(int pageNumber)
        {
            if (MediaListTableLayout.Controls.Contains(mainMediaList))
            {
                MediaListTableLayout.Controls.Remove(mainMediaList);
                mainMediaList.Dispose();
            }

            mainMediaList = new Panel
            {
                BackColor = Color.AliceBlue,
                Dock = DockStyle.Fill
            };

            int minBlockWidth = 110;
            int minBlockHeight = 190;

            currentMediaCols = MediaListTableLayout.Width / minBlockWidth;
            currentMediaRows = MediaListTableLayout.Height / minBlockHeight;

            mainMediaList.Controls.Add(CreateMediaBlocks(currentMediaCols, currentMediaRows, pageNumber));

            MediaListTableLayout.Controls.Add(mainMediaList, 0, 0);
    }
        #endregion

        #region Login Button
        /// <summary>
        /// Creates a customizable "Login" button with specific design and behavior.
        /// </summary>
        private void createLoginButton()
        {
            var loginBut = new Button
            {
                Anchor = AnchorStyles.Right,
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = userTheme.getLabelTextColor(),
                Margin = new Padding(0),
                Size = new Size(151, 40),
                Text = "Login",
            };
            loginBut.FlatAppearance.BorderSize = 0;
            loginBut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            loginBut.FlatAppearance.MouseOverBackColor = Color.Transparent;

            loginBut.Click += new System.EventHandler(this.LoginButton_Click);
            loginButton = loginBut;
        }
        #endregion

        #region User Navigation Panel
        /// <summary>
        /// Creates and adds a user panel to the navigation layout with the user's profile picture, nickname,
        /// and a dropdown arrow for additional navigation options.
        /// </summary>
        /// <param name="user">The user object containing details such as nickname and profile picture URL.</param>
        private void addUserPanel(User user)
        {
            userPanel = new Panel
            {
                Size = new Size(140, 40),
                Margin = new Padding(0),
                Anchor = AnchorStyles.Right,
                BackColor = userTheme.getUserPanelColor(),
            };

            var userLayout = Components.CreateTableLayoutPanel(1, 3,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 100) }, 
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Absolute, 40), new ColumnStyle(SizeType.Absolute, 80), new ColumnStyle(SizeType.Absolute, 20) });

            var userIco = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = string.IsNullOrEmpty(user.UserImageURL) ? Properties.Settings.Default.DefaultImageURL : user.UserImageURL,
                Margin = new Padding(0),
                Cursor = Cursors.Hand,
            };
            userIco.MouseClick += UserPanel_Click;
            userLayout.Controls.Add(userIco, 0, 0);

            Label userName = Components.createLabel("userName", user.Nickname, userTheme.getDefaultButtonTextColor(), ContentAlignment.MiddleLeft);
            userName.MouseClick += UserPanel_Click;
            userLayout.Controls.Add(userName, 1, 0);

            Label arrowLabel = Components.createLabel("arrowLabel", "▼", userTheme.getDefaultButtonTextColor(), ContentAlignment.MiddleLeft);
            arrowLabel.MouseClick += UserPanel_Click;
            userLayout.Controls.Add(arrowLabel, 2, 0);

            userPanel.Controls.Add(userLayout);

            navTableLayoutPanel.Controls.Add(userPanel, 4, 0);
            createUserNav(user.Role.ToString());
        }

        /// <summary>
        /// Creates a user navigation panel with options like Profile, My Media List, Settings, and Exit.
        /// If the user has an admin or moderator role, additional control options are added.
        /// </summary>
        /// <param name="role">The user's role, which determines whether admin options are displayed.</param>
        private void createUserNav(string role)
        {
            bool isAdmin;
            if (role == "admin" || role == "moderator") isAdmin = true;
            else isAdmin = false;

            userNav = Components.createPanel(140, isAdmin ? 330 : 290, userTheme.getNavPanelColor(), mainPanel);
            userNav.Visible = false;
            userNav.Location = new Point(userPanel.Location.X, userPanel.Location.Y);

            var userNavLayout = Components.CreateTableLayoutPanel(isAdmin ? 8 : 7, 1);

            userNavLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            if (isAdmin)
                userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));

            Label accountLabel = Components.createLabel("accountLabel", "Account", userTheme.getLabelTextColor(), ContentAlignment.MiddleLeft);

            userNavLayout.Controls.Add(accountLabel, 0, 0);

            userNavLayout.Controls.Add(createUserNavButton("Profile", ProfileButton_Click), 0, 1);
            userNavLayout.Controls.Add(createUserNavButton("My Media List", MyMediaList_Click), 0, 2); 
            userNavLayout.Controls.Add(createUserNavButton("Settings", ProfileSettingsButton_Click), 0, 3);
            userNavLayout.Controls.Add(createUserNavButton("Exit", ExitButton_Click), 0, 4);

            Label controlLabel = Components.createLabel("Control", "Control", userTheme.getLabelTextColor(), ContentAlignment.MiddleLeft);

            userNavLayout.Controls.Add(controlLabel, 0, 5);
            userNavLayout.Controls.Add(createUserNavButton("media", (s, e) => AddButton_Click("media"), isAddingButton: true), 0, 6);
            userNavLayout.Controls.Add(createUserNavButton("book", (s, e) => AddButton_Click("book"), isAddingButton: true), 0, 7);
            if (isAdmin) userNavLayout.Controls.Add(createUserNavButton("Media control", ExitButton_Click), 0, 8);

            userNav.Controls.Add(userNavLayout);
            this.mainPanel.Controls.Add(userNav);
            userNav.BringToFront();
        }

        /// <summary>
        /// Creates a navigation button with specified text, click handler, and an optional "Add" prefix.
        /// </summary>
        /// <param name="buttonText">Text to display on the button.</param>
        /// <param name="onClick">Event handler for the button click action.</param>
        /// <param name="isAddingButton">Indicates whether to prefix button text with "Add".</param>
        /// <returns>A <see cref="Panel"/> containing the stylized button.</returns>
        private Panel createUserNavButton(string buttonText, EventHandler onClick, bool isAddingButton = false)
        {
            Color CircleColor = userTheme.getLabelTextColor();

            var button = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                BackColor = Color.Transparent
            };

            var buttonLayout = Components.CreateTableLayoutPanel(1, 2,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 100) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Absolute, 30), new ColumnStyle(SizeType.Percent, 100) });

            Label symbol = new Label
            {
                Text = buttonText[0].ToString(),
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Size = new Size(30, 30),
                ForeColor = userTheme.getDefaultButtonTextColor(),
                BackColor = Color.Transparent
            };
            symbol.Paint += (s, e) =>
            {
                Control control = (Control)s;
                int diameter = Math.Min(control.Width, control.Height) - 5;
                using (Pen pen = new Pen(CircleColor, 2))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawEllipse(pen, new Rectangle((control.Width - diameter) / 2 - 1, (control.Height - diameter) / 2, diameter, diameter));
                }
            };
            Label buttonName = Components.createLabel("buttonName", isAddingButton ? $"Add {buttonText}" : buttonText, userTheme.getDefaultButtonTextColor(), ContentAlignment.MiddleLeft);

            buttonLayout.Controls.Add(symbol, 0, 0);
            buttonLayout.Controls.Add(buttonName, 1, 0);

            button.Controls.Add(buttonLayout);


            Label[] labels = new Label[] { buttonName, symbol };
            foreach (Label label in labels)
            {
                label.Click += (s, e) => onClick(s, e);

                label.MouseEnter += (s, e) =>
                {
                    buttonName.ForeColor = symbol.ForeColor = CircleColor = userTheme.getMouseEnterButtonTextColor();
                    symbol.Invalidate();
                };

                label.MouseLeave += (s, e) =>
                {
                    buttonName.ForeColor = symbol.ForeColor = CircleColor = userTheme.getDefaultButtonTextColor();
                    symbol.Invalidate();
                };
            }

            return button;
        }
        #endregion

        #region User Settings Panel
        /// <summary>
        /// Creates and displays the settings panel for a user, including username display,
        /// and a form for updating user settings.
        /// </summary>
        /// <param name="user">The user object containing the user's nickname and other information.</param>
        private void createSettingsPanel(User user)
        {
            ProfileSettingsPanel = Components.createPanel(width: (int)(mainPanel.Width * 0.75), height: (int)(mainPanel.Height * 0.85), backColor: userTheme.getPanelColor(), mainPanel);

            var ProfileSettingsLayout = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 40F), new RowStyle(SizeType.Percent, 100F) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });
            ProfileSettingsPanel.Controls.Add(ProfileSettingsLayout);

            ProfileSettingsLayout.Controls.Add(createUsernameLine(user.Nickname), 0, 0);

            var SettingsFormLayout = CreateSettingsForm();
            ProfileSettingsLayout.Controls.Add(SettingsFormLayout, 0, 1);

            mainPanel.Controls.Add(ProfileSettingsPanel);
        }

        /// <summary>
        /// Creates a panel displaying the user's name.
        /// </summary>
        /// <param name="username">The username to be displayed.</param>
        /// <returns>A <see cref="Panel"/> containing the username label.</returns>
        private Panel createUsernameLine(string username)
        {
            Panel userNamePanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Gray,
                Margin = new Padding(1)
            };

            Label UserNameLabel = Components.createLabel("UserNameLabel", username, userTheme.getLabelTextColor(), ContentAlignment.MiddleLeft);

            userNamePanel.Controls.Add(UserNameLabel);
            return userNamePanel;
        }

        /// <summary>
        /// Creates the settings form layout, including various fields for user settings,
        /// such as nickname, email, and password fields.
        /// </summary>
        /// <returns>A <see cref="TableLayoutPanel"/> containing the settings form fields.</returns>
        private TableLayoutPanel CreateSettingsForm()
        {
            var settingsFormLayout = Components.CreateTableLayoutPanel(1, 2,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 100F) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 60F), new ColumnStyle(SizeType.Percent, 40F) });
     
            settingsFormLayout.Controls.Add(createInfoPanel(), 0, 0);

            settingsFormLayout.Controls.Add(AddingForm.addMeddiaImageBox(imageUrl = Components.addTextBox("Image url", needMargin: true, fixedWidth: 200), new Size(200, 200)), 1, 0);

            return settingsFormLayout;
        }

        /// <summary>
        /// Creates a panel containing fields for user information settings,
        /// including nickname, email, passwords, description, and birthday.
        /// </summary>
        /// <returns>A <see cref="TableLayoutPanel"/> containing user info fields.</returns>
        private TableLayoutPanel createInfoPanel()
        {
            var firstColumnLayout = Components.CreateTableLayoutPanel(8, 1);
            for (int i = 0; i < 4; ++i) firstColumnLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            firstColumnLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 120));
            firstColumnLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            firstColumnLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));

            firstColumnLayout.Controls.Add(SettingNickname = Components.addTextBox("Nickname", needMargin: true, multiLine: false));
            firstColumnLayout.Controls.Add(SettingEmail = Components.addTextBox("Email", needMargin: true, multiLine: false));
            firstColumnLayout.Controls.Add(SettingNewPassword = Components.addTextBox("New password", needMargin: true, multiLine: false, isPassword: true));
            firstColumnLayout.Controls.Add(SettingCurrentPassword = Components.addTextBox("Current password", needMargin: true, multiLine: false, isPassword: true));

            Description = Components.addTextBox("Description", needMargin: true, multiLine: true);
            Description.Height = 100;
            firstColumnLayout.Controls.Add(Description);


            firstColumnLayout.Controls.Add(Components.createLabel("BirthdayLabel", "Birthday", userTheme.getLabelTextColor()));
            firstColumnLayout.Controls.Add(birthdayPicker = new DatePickerPanel());
            firstColumnLayout.Controls.Add(CreateThemeButton());
            firstColumnLayout.Controls.Add(CreateSaveButton());

            return firstColumnLayout;
        }

        /// <summary>
        /// Creates a button for saving user settings.
        /// </summary>
        /// <returns>A <see cref="Button"/> configured for saving user settings.</returns>
        private Button CreateSaveButton()
        {
            Button saveButton = new Button
            {
                Text = "Save",
                Width = 100,
                Height = 30,
                BackColor = Color.LightGreen,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderColor = Color.DarkGreen, BorderSize = 2 },
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };

            saveButton.MouseEnter += (s, e) => saveButton.BackColor = Color.MediumSeaGreen;
            saveButton.MouseLeave += (s, e) => saveButton.BackColor = Color.LightGreen;
            saveButton.Click += (s, e) => SaveUserSettingsButton_Click();

            return saveButton;
        }

        /// <summary>
        /// Creates a button for changing the theme of the application.
        /// </summary>
        /// <returns>A <see cref="Button"/> configured for theme change.</returns>
        private Button CreateThemeButton()
        {
            Button themeButton = new Button
            {
                Text = "☼",
                Width = 30,
                Height = 30,
                TextAlign = ContentAlignment.TopCenter,
                Margin = new Padding(0),
                Padding = new Padding(0),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Orange
            };

            themeButton.MouseEnter += (s, e) =>
            {
                themeButton.BackColor = Color.DarkGray;
                themeButton.ForeColor = Color.Yellow;
            };

            themeButton.MouseLeave += (s, e) =>
            {
                themeButton.BackColor = Color.LightGray;
                themeButton.ForeColor = Color.Orange;
            };

            themeButton.Click += (s, e) =>
            {
                ThemeButton();
            };
            return themeButton;
        }

        #endregion

        #region Media Info Panels
        /// <summary>
        /// Adds the media information panel to the main panel, clearing existing controls and updating the navigation label.
        /// </summary>
        /// <param name="media">The <see cref="MainMedia"/> object containing media information to be displayed.</param>
        private void addMediInfoPanel(MainMedia media)
        {   
            currentMediaUse = media;
            mainPanel.Controls.Clear();
            ChangeNavLabelText(media.MainType.ToString());
            MediaInfoControlPanel = createMediaInfoPanel(media);
            mainPanel.Controls.Add(MediaInfoControlPanel);       
        }

        /// <summary>
        /// Creates a panel for displaying information about a specific media item.
        /// </summary>
        /// <param name="media">The <see cref="MainMedia"/> object containing media information.</param>
        /// <returns>A <see cref="Panel"/> containing the media information layout.</returns>
        private Panel createMediaInfoPanel(MainMedia media)
        {
            MediaInfoControlPanel = Components.createPanel(width: (int)(mainPanel.Width * 0.75), height: (int)(mainPanel.Height * 0.85), backColor: userTheme.getPanelColor(), mainPanel);

            var rowsTableLayout = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 380), new RowStyle(SizeType.Percent, 100)},
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F)});

            MediaInfoControlPanel.Controls.Add(rowsTableLayout);
   
            rowsTableLayout.Controls.Add(mediaInfo(media), 0, 0);
            showResponseButton(isResponse: false, rowsTableLayout, media);

            return MediaInfoControlPanel;
        }

        /// <summary>
        /// Creates a table layout panel containing detailed information about the media item,
        /// including an image and additional media details.
        /// </summary>
        /// <param name="media">The <see cref="MainMedia"/> object containing media information.</param>
        /// <returns>A <see cref="TableLayoutPanel"/> containing the media information layout.</returns>
        private TableLayoutPanel mediaInfo(MainMedia media)
        {
            var infoTableLayout = Components.CreateTableLayoutPanel(1, 2,
               rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 100) },
               colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Absolute, 180), new ColumnStyle(SizeType.Percent, 100) });

            infoTableLayout.Controls.Add(ControlEpisodePanel(media.ImageURL, media.Id), 0, 0);
            infoTableLayout.Controls.Add(addMediaInformation(media.MainType, media.Id), 1, 0);

            return infoTableLayout;
        }

        /// <summary>
        /// Displays a button that allows navigation between media information and user responses.
        /// </summary>
        /// <param name="isResponse">Indicates whether the current view is a response view.</param>
        /// <param name="rowsTableLayout">The <see cref="TableLayoutPanel"/> to which the buttons will be added.</param>
        /// <param name="media">The <see cref="MainMedia"/> object containing media information.</param>
        private void showResponseButton(bool isResponse, TableLayoutPanel rowsTableLayout, MainMedia media)
        {
            goToResponse = new Button
            {
                Text = "->",
                ForeColor = userTheme.getLabelTextColor(),
                Height = 40,
                Width = 50,
                Anchor = AnchorStyles.Right | AnchorStyles.Bottom,
            };

            goToMediaInfo = new Button
            {
                Text = "<-",
                ForeColor = userTheme.getLabelTextColor(),
                Height = 40,
                Width = 50,
                Anchor = AnchorStyles.Left | AnchorStyles.Bottom,
            };

            goToMediaInfo.Click += (s, e) =>
            {
                rowsTableLayout.Controls.Clear();
                rowsTableLayout.Controls.Add(mediaInfo(media), 0, 0);
                rowsTableLayout.Controls.Add(goToResponse, 0, 1);
            };

            goToResponse.Click += (s, e) =>
            {
                rowsTableLayout.Controls.Clear();
                rowsTableLayout.Controls.Add(createMainResponsePanel(media), 0, 0);
                rowsTableLayout.Controls.Add(goToMediaInfo, 0, 1);
                ResponsePanelResize();
            };

            if (isResponse)
                rowsTableLayout.Controls.Add(goToMediaInfo, 0, 1);
            else
                rowsTableLayout.Controls.Add(goToResponse, 0, 1);
        }

        /// <summary>
        /// Creates a panel for user responses related to the media item, including a text box for input
        /// and a button to submit the response.
        /// </summary>
        /// <param name="media">The <see cref="MainMedia"/> object containing media information.</param>
        /// <param name="isOnly">Indicates whether the response panel is standalone or part of a larger layout.</param>
        /// <returns>A <see cref="TableLayoutPanel"/> containing the user response layout.</returns>
        private TableLayoutPanel createMainResponsePanel(MainMedia media, bool isOnly = true)
        {
            var main = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 30), new RowStyle(SizeType.Absolute, isOnly ? 220 : 180), new RowStyle(SizeType.Absolute, 100), new RowStyle(SizeType.Absolute, 30) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });

            Label responseLabel = Components.createLabel("responseLabel", "Response", userTheme.getLabelTextColor(), ContentAlignment.MiddleLeft);
                
            TextBox userResponse = Components.addTextBox("Write your response...", needMargin: false, multiLine: true);
            userResponse.BackColor = userTheme.getDefaultButtonColor();
            userResponse.ForeColor = userTheme.getLabelTextColor();
            userResponse.Height = 100;

            responseFlowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false 
            };
       
            Button sendUserResponse = new Button
            {
                Dock = DockStyle.Fill,
                Text = "Send Response",
                BackColor = userTheme.getDefaultButtonColor(),
                ForeColor = userTheme.getLabelTextColor(),
                Margin = new Padding(0)
            };


            UserResponse[] responses = MediaService.GetResponsesByMediaId(currentMediaUse.Id);
            for (int i = 0; i < responses.Length; ++i)
            {
                responseFlowLayoutPanel.Controls.Add(createResponsePanel(responses[i]));
            }

            sendUserResponse.Click += (s, e) =>
            {
                if (userResponse.Text != "Write your response..." && currentUser.Role != UserRole.Guest)
                {
                    UserResponse response = new UserResponse(currentUser.Id, -1, currentMediaUse.Id, userResponse.Text, ResponseType.Neutral, currentUser.Nickname, currentUser.UserImageURL);
                    bool successful = MediaService.AddUserResponseToDatabase(response);
                    if (successful)
                    {
                        MessageBox.Show("Your response has been successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userResponse.Text = "Write your response...";
                    }
                    else
                    {
                        MessageBox.Show("Failed to add your response. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            main.Controls.Add(responseLabel);
            main.Controls.Add(responseFlowLayoutPanel);
            main.Controls.Add(userResponse);
            main.Controls.Add(sendUserResponse);

            return main;
        }

        private Panel createResponsePanel(UserResponse userResponse)
        {
            var panel = new Panel
            {
                BackColor = userTheme.getHistoryPanelColor(),
            };

            var tableLayout = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 40), new RowStyle(SizeType.Percent, 100)},
                colStyles: new List<ColumnStyle> {new ColumnStyle(SizeType.Percent, 100)});

            panel.Controls.Add(tableLayout);

            var userResponseInfo = Components.CreateTableLayoutPanel(1, 2,
               rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 100) },
               colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Absolute, 40), new ColumnStyle(SizeType.Percent, 100) });

            tableLayout.Controls.Add(userResponseInfo, 0, 0);
            var userIco = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = string.IsNullOrEmpty(userResponse.UserIMGURL) ? Properties.Settings.Default.DefaultImageURL : userResponse.UserIMGURL,
                Margin = new Padding(0),
                Cursor = Cursors.Hand,
            };

            Label UserNameLabel = Components.createLabel("UserNameLabel", userResponse.UserNickname, userTheme.getResponseTextColor(), ContentAlignment.MiddleLeft);

            userResponseInfo.Controls.Add(userIco, 0, 0);
            userResponseInfo.Controls.Add(UserNameLabel, 1, 0);

            TextBox textBox = new TextBox
            {
                Text = userResponse.ResponseText,
                ForeColor = userTheme.getLabelTextColor(),
                BackColor = userTheme.getPanelColor(),
                Dock = DockStyle.Top,
                Font = new Font("Arial", 10, FontStyle.Regular),
                BorderStyle = BorderStyle.None,
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Height = 200
            };

            tableLayout.Controls.Add(textBox, 1, 0);

            return panel;
        } 

        /// <summary>
        /// Adds a panel that displays detailed information about the specified media.
        /// </summary>
        /// <param name="type">The type of the media being displayed.</param>
        /// <param name="mediaID">The unique identifier of the media item.</param>
        /// <returns>A Panel containing the media's detailed information.</returns>
        private Panel addMediaInformation(MainMediaType type, int mediaID)
        {
            Media media = MediaService.GetMedia(mediaID);
            

            Panel panel = new Panel {Dock  = DockStyle.Fill, Margin  = new Padding(10)};
            var infoTableLayout = Components.CreateTableLayoutPanel(11, 1);
            Font labelFontStyle = new Font("Arial", 12, FontStyle.Regular);
            panel.Controls.Add(infoTableLayout);    
            infoTableLayout.Controls.Add(createInfoLabel("Original name: ", media.OriginalName, labelFontStyle));
            infoTableLayout.Controls.Add(createInfoLabel("English name: ", media.EnglishName, labelFontStyle));
            infoTableLayout.Controls.Add(createInfoLabel("Status: ", media.getStatusString(), labelFontStyle));
            if (media.Status != MediaStatus.Ongoing && media.StartDate.Value != null) 
                infoTableLayout.Controls.Add(createInfoLabel("Start date: ", media.StartDate.Value.ToString("yyyy-MM-dd"), labelFontStyle));
            infoTableLayout.Controls.Add(createInfoLabel("Type: ", media.SecondMediaType.ToString(), labelFontStyle));
            infoTableLayout.Controls.Add(createInfoLabel("Studio: ", media.Studio, labelFontStyle));
            infoTableLayout.Controls.Add(createInfoLabel("Rating: ", media.PG_Rating.ToString(), labelFontStyle));
            infoTableLayout.Controls.Add(createInfoLabel("Episode: ", media.getEpisodeString(), labelFontStyle));
            infoTableLayout.Controls.Add(createInfoLabel("Episode duration: ", media.getEpisodeduration(), labelFontStyle));
            if (media.Status == MediaStatus.Ongoing)
                infoTableLayout.Controls.Add(createInfoLabel("Next episode: ", media.getNextEpisodeDAte(), labelFontStyle));

            infoTableLayout.Controls.Add(createInfoLabel("Desctiption: ", "", labelFontStyle));
            TextBox textBox = new TextBox
            {
                Text = media.Description,
                ForeColor = userTheme.getLabelTextColor(),
                BackColor = userTheme.getPanelColor(),
                Dock = DockStyle.Top, 
                Font = new Font("Arial", 10, FontStyle.Regular),
                BorderStyle = BorderStyle.None,
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical, 
                Height = 80
            };
            infoTableLayout.Controls.Add(textBox);


            return panel;
        }

        /// <summary>
        /// Creates a label displaying a piece of media information.
        /// </summary>
        /// <param name="name">The label name (title).</param>
        /// <param name="val">The value associated with the label.</param>
        /// <param name="font">The font style for the label.</param>
        /// <returns>A Label containing the specified name and value.</returns>
        Label createInfoLabel(string name, string val, Font font)
        {
            Label label = new Label
            {
                Text = name + val,
                ForeColor = userTheme.getLabelTextColor(),
                Dock = DockStyle.Fill,
                Font = font,
                AutoSize = true,
                Margin = new Padding(5)
            };

            return label;
        }

        /// <summary>
        /// Creates a panel that displays the media's episode image and controls for user interactions.
        /// </summary>
        /// <param name="url">The URL of the media image.</param>
        /// <param name="mediaId">The unique identifier of the media item.</param>
        /// <returns>A Panel containing the episode controls and media image.</returns>
        private Panel ControlEpisodePanel(string url, int mediaId)
        {
            var control = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 280), new RowStyle(SizeType.Percent, 100F) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Absolute, 180) });

            Panel controlPanel = new Panel { Dock = DockStyle.Fill };

            var mediaPictureBox = new PictureBox
            {
                Dock = DockStyle.Top,
                Height = 260,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                ImageLocation = url,
            };

            control.Controls.Add(mediaPictureBox, 0, 0);

            if (currentUser.Role != UserRole.Guest)
            {
                titleControlTable = Components.CreateTableLayoutPanel(3, 1,
                 rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 30F), new RowStyle(SizeType.Absolute, 30F), new RowStyle(SizeType.Absolute, 30F) },
                 colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Absolute, 180f) });

                control.Controls.Add(titleControlTable);
                UserMediaStatus inUserList = MediaService.GetUserMediaStatus(currentUser.Id, mediaId);

                titleControlTable.Controls.Add(MediaControl(inUserList), 0, 0);
                if (inUserList != null) titleControlTable.Controls.Add(EpisodeConrol(inUserList), 1, 0);
            }
            controlPanel.Controls.Add(control);

            return controlPanel;
        }

        /// <summary>
        /// Creates a panel that allows users to manage their media status, such as adding to a list or updating progress.
        /// </summary>
        /// <param name="inUserList">The user's current status for the media, or null if not in the user's list.</param>
        /// <returns>A Panel containing the media control interface for the user.</returns>
        private Panel MediaControl(UserMediaStatus inUserList)
        {
            Panel ControlPanel_CloseMode = new Panel
            {
                Height = 20,
                ForeColor = userTheme.getLabelTextColor(),
                BackColor = Color.Blue,
                Margin = new Padding(10, 0, 10, 0)
            };

            titleStatus = new Label
            {
                Text = inUserList == null ? "Add to list"
                                    : inUserList.Status == MediaStatusInUserList.InProcess
                                    ? "In Procces" : inUserList.Status.ToString(),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
            };

            titleStatus.Click += (s, e) =>
            {
                if (titleStatus.Text == "Add to list")
                {
                    titleStatus.Text = "In Procces";
                    inUserList = new UserMediaStatus(currentMediaUse.Id, currentUser.Id, MediaStatusInUserList.InProcess, 0);
                    MediaService.AddOrUpdateUserMediaStatus(inUserList);
                    titleControlTable.Controls.Add(EpisodeConrol(inUserList), 1, 0);
                }
                else
                {
                    var control = new UserMediaStatusForm(inUserList, currentMediaUse);
                    control.ShowDialog();
                    titleStatus.Text = control.newInUserList.Status == MediaStatusInUserList.InProcess
                    ? "In Procces" : control.newInUserList.Status.ToString();
                    titleControlTable.Controls.RemoveAt(1);

                    titleControlTable.Controls.Add(EpisodeConrol(inUserList), 1, 0);
                }
            };

            ControlPanel_CloseMode.Controls.Add(titleStatus);

            return ControlPanel_CloseMode;
        }

        /// <summary>
        /// Creates a table layout panel for managing episode count with increment and decrement buttons.
        /// </summary>
        /// <param name="inUserList">The user's current status for the media.</param>
        /// <returns>A TableLayoutPanel containing controls for episode management.</returns>
        private TableLayoutPanel EpisodeConrol(UserMediaStatus inUserList)
        {
            TableLayoutPanel episode = Components.CreateTableLayoutPanel(1, 3,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 100F) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Absolute, 60f), new ColumnStyle(SizeType.Absolute, 60f), new ColumnStyle(SizeType.Absolute, 60f) });


            Button minusButton = new Button
            {
                Text = "-",
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                Margin = new Padding(0),
                FlatStyle = FlatStyle.Flat,
                ForeColor = userTheme.getLabelTextColor(),
            };
            minusButton.FlatAppearance.BorderSize = 0;


            int full = MediaService.GetMediaCountByType(currentMediaUse.MainType, currentMediaUse.Id);
            int ended = inUserList.EndedPageOrEpisode;
            Label episodeCountLabel = new Label
            {
                Text = ended.ToString() + "/" + (full != 0 ? full.ToString() : "?"),
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(0),
                ForeColor = userTheme.getLabelTextColor(),
            };

            Button plusButton = new Button
            {
                Text = "+",
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
                Margin = new Padding(0),
                FlatStyle = FlatStyle.Flat,
                ForeColor = userTheme.getLabelTextColor(),
            };
            plusButton.FlatAppearance.BorderSize = 0;
            plusButton.Click += (sender, e) => UpdateEpisodeCount(inUserList, episodeCountLabel, 1);
            minusButton.Click += (sender, e) => UpdateEpisodeCount(inUserList, episodeCountLabel, -1);

            episode.Controls.Add(minusButton, 0, 0);
            episode.Controls.Add(episodeCountLabel, 1, 0);
            episode.Controls.Add(plusButton, 2, 0);

            return episode;
        }

        /// <summary>
        /// Updates the episode count for the user's media status and refreshes the displayed count.
        /// </summary>
        /// <param name="inUserList">The user's current status for the media.</param>
        /// <param name="episodeCountLabel">The label displaying the current episode count.</param>
        /// <param name="change">The change in episode count (positive to increment, negative to decrement).</param>
        private void UpdateEpisodeCount(UserMediaStatus inUserList, Label episodeCountLabel, int change)
        {
            int full = MediaService.GetMediaCountByType(currentMediaUse.MainType, currentMediaUse.Id);
           
            if (change > 0 && inUserList.EndedPageOrEpisode < full)
            {
                inUserList.EndedPageOrEpisode++;
                if (inUserList.EndedPageOrEpisode == full && full != 0)
                {
                    inUserList.Status = MediaStatusInUserList.Completed;
                    titleStatus.Text = "Completed";
                }
            }
            else if (change < 0 && inUserList.EndedPageOrEpisode > 0)
            {
                inUserList.EndedPageOrEpisode--;
                if (inUserList.EndedPageOrEpisode < full && full != 0)
                {
                    inUserList.Status = MediaStatusInUserList.InProcess;
                    titleStatus.Text = "In Procces";
                }
            }

            episodeCountLabel.Text = inUserList.EndedPageOrEpisode.ToString() + "/" + (full != 0 ? full.ToString() : "?");

            MediaService.AddOrUpdateUserMediaStatus(inUserList);
        }
        #endregion

        #region Profile Panel
        void AddUserProfile()
        {
            ProfilePanel = Components.createPanel(width: (int)(mainPanel.Width * 0.75), height: 500, backColor: userTheme.getPanelColor(), mainPanel);
            ProfilePanel.BackColor = userTheme.getPanelColor(); 
            mainPanel.Controls.Add(ProfilePanel); 

            var rowsTableLayout = Components.CreateTableLayoutPanel(2, 1,
               rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 200), new RowStyle(SizeType.Percent, 100) },
               colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });

            rowsTableLayout.Controls.Add(createUserInfo(), 0, 0);
            rowsTableLayout.Controls.Add(userListInfo(), 0, 1);
                
            ProfilePanel.Controls.Add(rowsTableLayout);
        }

        private TableLayoutPanel createUserInfo()
        {
            var ProfilePanel = Components.CreateTableLayoutPanel(1, 2,
               rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 100) },
               colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Absolute, 160F), new ColumnStyle(SizeType.Percent, 100F) });

            PictureBox pictureBox = new PictureBox
            {
                ImageLocation = "https://img.freepik.com/free-photo/love-illustrated-anime-style_23-2151103293.jpg",
                Height = 140,
                Width = 140,
                Margin = new Padding(15, 15, 0, 0),
                SizeMode = PictureBoxSizeMode.StretchImage 
            };

            ProfilePanel.Controls.Add(pictureBox, 0, 0);

            var userInfo = Components.CreateTableLayoutPanel(5, 1);
            userInfo.Margin = new Padding(0, 15, 0, 0);

            Font labelFontStyle = new Font("Arial", 12, FontStyle.Regular);
            userInfo.Controls.Add(createInfoLabel("", currentUser.Nickname, new Font("Arial", 32, FontStyle.Bold)));
            if (currentUser.IsBanned) userInfo.Controls.Add(createInfoLabel("Banned to ", currentUser.DateEndBan.ToString(), new Font("Arial", 12, FontStyle.Regular)));
            userInfo.Controls.Add(createInfoLabel("", "Have list from: " + currentUser.RegisterDate.ToString(), new Font("Arial", 12, FontStyle.Regular)));
            userInfo.Controls.Add(createInfoLabel("", "Last login: " + currentUser.LastLoginDate?.ToString(), new Font("Arial", 12, FontStyle.Regular)));
            userInfo.Controls.Add(createInfoLabel("", "Birthday: " + currentUser.BirthdayDate?.ToString(), new Font("Arial", 12, FontStyle.Regular)));
            
            ProfilePanel.Controls.Add(userInfo, 1, 0);


            return ProfilePanel; 
        }

        private TableLayoutPanel userListInfo()
        {
            TableLayoutPanel tableLayoutPanel = Components.CreateTableLayoutPanel(5, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 70), new RowStyle(SizeType.Absolute, 70), new RowStyle(SizeType.Absolute, 70), new RowStyle(SizeType.Absolute, 70), new RowStyle(SizeType.Percent, 100) }
                );
            tableLayoutPanel.Margin = new Padding(25, 0, 25, 0);
            SortMedia sortMedia;

            string mediaType;
            for (int i = 0; i < 4; ++i)
            {

                if (i == 0) mediaType = "Media";
                else if (i == 1) mediaType = "Book";
                else if (i == 2) mediaType = "Game";
                else mediaType = "Comics";
                sortMedia = new SortMedia(new[] { mediaType }, Array.Empty<Genres>(), Array.Empty<string>(), Array.Empty<string>(), currentUser.Id);

                sortMedia.selectedStatus = new[] { "Completed" };
                int completed = MediaService.CountFilteredMedia(sortMedia);
                sortMedia.selectedStatus = new[] { "Planned" };
                int planned = MediaService.CountFilteredMedia(sortMedia);
                sortMedia.selectedStatus = new[] { "InProcess" };
                int inProcces = MediaService.CountFilteredMedia(sortMedia);
                sortMedia.selectedStatus = new[] { "Dropped" };
                int dropped = MediaService.CountFilteredMedia(sortMedia);

                tableLayoutPanel.Controls.Add(mediaInfoLine(completed, planned,inProcces, dropped, mediaType), 0, i);
            }

            return tableLayoutPanel;
        }

        private TableLayoutPanel mediaInfoLine(int completed, int planned, int inProcess, int dropped, string mediaType)
        {
            int total = completed + planned + inProcess + dropped;

            float basePercent = 15f;
            float remainingPercent = 40f;
            float completedPercent = total != 0 ? basePercent + ((float)completed / total * remainingPercent) : basePercent;
            float plannedPercent = total != 0 ? basePercent + ((float)planned / total * remainingPercent) : basePercent;
            float inProcessPercent = total != 0 ? basePercent + ((float)inProcess / total * remainingPercent) : basePercent;
            float droppedPercent = total != 0 ? basePercent + ((float)dropped / total * remainingPercent) : basePercent;

            TableLayoutPanel line = Components.CreateTableLayoutPanel(3, 4,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 30), new RowStyle(SizeType.Absolute, 30), new RowStyle(SizeType.Absolute, 10)},
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, completedPercent), new ColumnStyle(SizeType.Percent, plannedPercent), new ColumnStyle(SizeType.Percent, inProcessPercent), new ColumnStyle(SizeType.Percent, droppedPercent)});
            Font labelFontStyle = new Font("Arial", 8, FontStyle.Regular);

            line.Controls.Add(createInfoLabel("", mediaType, labelFontStyle), 0, 0);

            Label completedLabel = createInfoLabel("", "Completed", labelFontStyle);
            completedLabel.Click += (s, e) => { LoadMedia(mediaType, "Completed"); };
            completedLabel.Cursor = Cursors.Hand;
            line.Controls.Add(completedLabel, 0, 1);

            Label plannedLabel = createInfoLabel("", "Planned", labelFontStyle);
            plannedLabel.Click += (s, e) => { LoadMedia(mediaType, "Planned"); };
            plannedLabel.Cursor = Cursors.Hand;
            line.Controls.Add(plannedLabel, 1, 1);

            Label inProccesLabel = createInfoLabel("", "In Process", labelFontStyle);
            inProccesLabel.Click += (s, e) => { LoadMedia(mediaType, "InProcess"); };
            inProccesLabel.Cursor = Cursors.Hand;
            line.Controls.Add(inProccesLabel, 2, 1);

            Label droppedLabel = createInfoLabel("", "Dropped", labelFontStyle);
            droppedLabel.Click += (s, e) => { LoadMedia(mediaType, "Dropped"); };
            droppedLabel.Cursor = Cursors.Hand;
            line.Controls.Add(droppedLabel, 3, 1); 

            int[] counts = { completed, planned, inProcess, dropped };
            Random random = new Random();
            for (int i = 0; i < 4; ++i)
            {
                Panel panel = new Panel
                {
                    Dock = DockStyle.Fill,
                    Margin = new Padding(0),
                    BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)) 
                };

                Label countLabel = new Label
                {
                    Text = counts[i].ToString(),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };

                panel.Controls.Add(countLabel); 
                line.Controls.Add(panel, i, 2);
            }

            return line;
        }

        

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private TableLayoutPanel navTableLayoutPanel;
        private TableLayoutPanel navTableLayout;
        private TableLayoutPanel MediaListTableLayout;
        private TableLayoutPanel pagesTableLayout;
        private TableLayoutPanel titleControlTable;
        private TableLayoutPanel mediaBlocksTableLayoutPanel;

        private Label navNameLabel;
        private Label titleStatus;

        private Button navButton;
        private Button searchButton;
        private Button loginButton;
        private Button goToResponse;
        private Button goToMediaInfo;

        private Panel mainPanel;
        private Panel navMenuPanel;
        private Panel MediaPanel;
        private Panel mediaBlocksPanel;
        private Panel mediaHistoryAndNavPanel;
        private Panel goToNewMediaButton;
        private Panel userPanel;
        private Panel userNav;
        private Panel ProfilePanel;
        private Panel ProfileSettingsPanel;
        private Panel mainMediaList;
        private Panel MediaInfoControlPanel;

        private TextBox searchTextBox;

        private FlowLayoutPanel responseFlowLayoutPanel;

        #region Setting Components
        TextBox SettingNickname;
        TextBox SettingEmail;
        TextBox SettingCurrentPassword;
        TextBox SettingNewPassword;
        TextBox Description;
        TextBox imageUrl;
        DatePickerPanel birthdayPicker;
        #endregion
    }
}