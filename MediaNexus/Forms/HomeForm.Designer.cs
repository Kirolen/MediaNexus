using MediaNexus.Forms;
using MediaNexus_Backend;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
namespace MediaNexus
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
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
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.navTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.mainPanel, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1195, 495);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // navTableLayoutPanel
            // 
            this.navTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.navTableLayoutPanel.ColumnCount = 5;
            this.navTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.navTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.navTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.navTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.navTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navTableLayoutPanel.Controls.Add(this.navNameLabel, 0, 0);
            this.navTableLayoutPanel.Controls.Add(this.navButton, 1, 0);
            this.navTableLayoutPanel.Controls.Add(this.searchTextBox, 2, 0);
            this.navTableLayoutPanel.Controls.Add(this.searchButton, 3, 0);
            this.navTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.navTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navTableLayoutPanel.Name = "navTableLayoutPanel";
            this.navTableLayoutPanel.RowCount = 1;
            this.navTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navTableLayoutPanel.Size = new System.Drawing.Size(1195, 43);
            this.navTableLayoutPanel.TabIndex = 0;
            // 
            // loginButton
            // 

            // 
            // navNameLabel
            // 
            this.navNameLabel.AutoSize = true;
            this.navNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.navNameLabel.Location = new System.Drawing.Point(0, 0);
            this.navNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.navNameLabel.Name = "navNameLabel";
            this.navNameLabel.Size = new System.Drawing.Size(239, 43);
            this.navNameLabel.TabIndex = 0;
            this.navNameLabel.Text = "MediaNexus";
            this.navNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.navNameLabel.Click += new System.EventHandler(this.NavNameLabel_Click);
            // 
            // navButton
            // 
            this.navButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.navButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navButton.ForeColor = System.Drawing.Color.White;
            this.navButton.Location = new System.Drawing.Point(239, 0);
            this.navButton.Margin = new System.Windows.Forms.Padding(0);
            this.navButton.Name = "navButton";
            this.navButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.navButton.Size = new System.Drawing.Size(179, 43);
            this.navButton.TabIndex = 1;
            this.navButton.Text = "⌂ Home";
            this.navButton.UseVisualStyleBackColor = false;
            this.navButton.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.ForeColor = System.Drawing.Color.Gray;
            this.searchTextBox.Location = new System.Drawing.Point(428, 10);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(408, 22);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.Text = "Search";
            this.searchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(836, 0);
            this.searchButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(59, 40);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "🔍";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 43);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1195, 452);
            this.mainPanel.TabIndex = 1;

            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1195, 495);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeForm";
            this.Text = "MediaNexus";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.navTableLayoutPanel.ResumeLayout(false);
            this.navTableLayoutPanel.PerformLayout();
            this.navTableLayout.ResumeLayout(false);
            this.navTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion


        public class DarkTheme
        {
            static public Color buttonBackColor { get; } = Color.FromArgb(58, 58, 58);
            static public Color ForeButtonColor { get; } = Color.White;
            static public Color longButtonBackColor { get; } = Color.FromArgb(100, 100, 100);
            static public Color historyPanelBackColor { get; } = Color.FromArgb(233, 247, 251);
        }
        SortMedia conditions; 
        #region Media Navigation Panel
        private void createNavMenuPanel()
        {
            this.navButton.Text = currentNavPage;
            Panel mediaNav = new Panel
            {
                BackColor = DarkTheme.buttonBackColor,
                Name = "navMenuPanel",
                Location = new Point(navButton.Location.X, navButton.Location.Y),
                Margin = new System.Windows.Forms.Padding(4),
                TabIndex = 0,
                Height = 200,
                Width = navButton.Width,
                Visible = false
            };

            TableLayoutPanel mediaNavLayout = Components.CreateTableLayoutPanel(5, 1);

            mediaNavLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mediaNavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            mediaNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            mediaNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            mediaNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            mediaNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));

            mediaNav.Controls.Add(mediaNavLayout);
            mediaNavLayout.Controls.Add(createNavLabel("navLabel_base", "Database:"), 0, 0);
            mediaNavLayout.Controls.Add(createNavButton("navButton_media", "Media"), 0, 1);
            mediaNavLayout.Controls.Add(createNavButton("navButton_book", "Books"), 0, 2);
            mediaNavLayout.Controls.Add(createNavButton("navButton_comics", "Comics"), 0, 3);
            mediaNavLayout.Controls.Add(createNavButton("navButton_games", "Games"), 0, 4);

            navMenuPanel = mediaNav;
            this.mainPanel.Controls.Add(this.navMenuPanel);
            navMenuPanel.BringToFront();
        }
        private Button createNavButton(string buttonName, string buttonText)
        {
            Button button = new Button
            {
                BackColor = DarkTheme.buttonBackColor,
                Cursor = Cursors.Hand,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204),
                ForeColor = DarkTheme.ForeButtonColor,
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
        private void createMainMediaPanel()
        {
            MediaPanel = createMediaPanel(width: (int)(mainPanel.Width * 0.75), height: (int)(mainPanel.Height * 0.85), backColor: Color.FromArgb(30, 30, 30));

            MediaPanel.Controls.Add(createGoToNewMediaButton());
            CreateRecentMediaPanel();
            createMediaHistoryAndNavPanel();

            mainPanel.Controls.Add(MediaPanel);
        }

        private Panel createGoToNewMediaButton()
        {
            int widthButton = (int)(MediaPanel.Width * 0.95);
            int heightButton = 25;

            int xPosition = (MediaPanel.Width - widthButton) / 2;
            int yPosition = 25;

            goToNewMediaButton = new Panel()
            {
                Size = new Size(widthButton, heightButton),
                Location = new Point(xPosition, yPosition),
                BackColor = DarkTheme.longButtonBackColor,
            };

            TableLayoutPanel goButtonLayout = Components.CreateTableLayoutPanel(1, 2,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 100)}, 
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 85F), new ColumnStyle(SizeType.Percent, 15F)},
                Cursors.Hand);

            Label buttonLabel = new Label()
            {
                AutoSize = true,
                Text = "Go to new media",
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                Anchor = AnchorStyles.Left,
                ForeColor = DarkTheme.ForeButtonColor,
                Cursor = Cursors.Hand
            };

            Label arrowLabel = new Label()
            {
                AutoSize = true,
                Text = ">",
                TextAlign = ContentAlignment.MiddleRight,
                Dock = DockStyle.Fill,
                Anchor = AnchorStyles.Right,
                ForeColor = DarkTheme.ForeButtonColor,
                Cursor = Cursors.Hand
            };

            Label[] labels = { buttonLabel, arrowLabel };
            foreach (Label label in labels)
            {
                label.MouseEnter += (s, e) =>
                {
                    ChangeButtonForeColor(buttonLabel, Color.Orange);
                    ChangeButtonForeColor(arrowLabel, Color.Orange);
                };
                label.Click += this.GoToNewMedia_button_Click;
                label.MouseLeave += (s, e) =>
                {
                    ChangeButtonForeColor(buttonLabel, DarkTheme.ForeButtonColor);
                    ChangeButtonForeColor(arrowLabel, DarkTheme.ForeButtonColor);
                };
            }

            goButtonLayout.Controls.Add(buttonLabel, 0, 0);
            goButtonLayout.Controls.Add(arrowLabel, 1, 0);
            goToNewMediaButton.Controls.Add(goButtonLayout);

            goButtonLayout.MouseEnter += (s, e) =>
            {
                ChangeButtonForeColor(buttonLabel, Color.Orange);
                ChangeButtonForeColor(arrowLabel, Color.Orange);
            };

            goButtonLayout.Click += this.GoToNewMedia_button_Click;
            goButtonLayout.MouseLeave += (s, e) =>
            {
                ChangeButtonForeColor(buttonLabel, DarkTheme.ForeButtonColor);
                ChangeButtonForeColor(arrowLabel, DarkTheme.ForeButtonColor);
            };

            return goToNewMediaButton;
        }
        private void CreateRecentMediaPanel()
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
            mediaBlocksTableLayoutPanel = AddMediaBlocks(5, 1, 1);

            mediaBlocksPanel.Controls.Add(mediaBlocksTableLayoutPanel);
            MediaPanel.Controls.Add(mediaBlocksPanel);
        }
        private TableLayoutPanel AddMediaBlocks(int columnCount, int rowCount, int numPage)
        {
            TableLayoutPanel mediaBlocksTableLayoutPanel = Components.CreateTableLayoutPanel(rowCount, columnCount);

            MainMedia[] RecentMedia = MediaService.GetFilteredMedia(conditions, columnCount * rowCount, numPage);

            for (int i = 0; i < rowCount; i++)
            {
                mediaBlocksTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / rowCount));
                for (int j = 0; j < columnCount; j++)
                {
                    mediaBlocksTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columnCount));

                    int currentIndex = (i * columnCount) + j;
                    if (currentIndex >= RecentMedia.Length) continue;

                    Panel mediaBlock = CreateRecentMediaBlock(RecentMedia[currentIndex].Id.ToString(), RecentMedia[currentIndex]);

                    mediaBlocksTableLayoutPanel.Controls.Add(mediaBlock, j, i);
                }
            }

            return mediaBlocksTableLayoutPanel;
        }
        private Panel CreateRecentMediaBlock(string name, MainMedia currentMedia)
        {
            Panel mediaBlock = new Panel()
            {
                Dock = DockStyle.Fill,
                Name = $"MediaBlock_{name}",
                Margin = new System.Windows.Forms.Padding(5),
                Tag = currentMedia,
            };

            TableLayoutPanel mediaBlockTableLayoutPanel = Components.CreateTableLayoutPanel(3, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 85), new RowStyle(SizeType.Percent, 7.5F), new RowStyle(SizeType.Percent, 7.5F) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F)},
                Cursors.Hand);


            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = currentMedia.ImageURL,
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
            };
            titleLabel.MouseEnter += (s, e) => ChangeButtonForeColor(titleLabel, Color.Orange);
            titleLabel.MouseLeave += (s, e) => ChangeButtonForeColor(titleLabel, Color.Black);
            titleLabel.Click += (s, e) => addMediInfoPanel(currentMedia);

            Label studioLabel = new Label
            {
                Dock = DockStyle.Fill,
                Text = "currentMedia.Studio",
                MaximumSize = new Size(mediaBlock.Width, 0),
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0),
            };
            studioLabel.MouseEnter += (s, e) => ChangeButtonForeColor(titleLabel, Color.Orange);
            studioLabel.MouseLeave += (s, e) => ChangeButtonForeColor(titleLabel, Color.Black);
            studioLabel.Click += (s, e) => addMediInfoPanel(currentMedia);

            pictureBox.MouseEnter += (s, e) => ChangeButtonForeColor(titleLabel, Color.Orange);
            pictureBox.MouseLeave += (s, e) => ChangeButtonForeColor(titleLabel, Color.Black);
            pictureBox.Click += (s, e) => addMediInfoPanel(currentMedia);

            mediaBlockTableLayoutPanel.Controls.Add(titleLabel, 0, 1);
            mediaBlockTableLayoutPanel.Controls.Add(studioLabel, 0, 2);

            mediaBlock.Controls.Add(mediaBlockTableLayoutPanel);

            return mediaBlock;
        }
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

            TableLayoutPanel outerTableLayoutPanel = new TableLayoutPanel
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

                TableLayoutPanel tagsTableLayoutPanel = new TableLayoutPanel
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
        private Panel createHistoryPanel()
        {
            Panel panel = new Panel
            {
                AutoSize = true,
                BackColor = DarkTheme.historyPanelBackColor,
                Margin = new Padding(0),
                Dock = DockStyle.Fill,

            };

            return panel;
        }
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
        private void createMediaListPanel(int page = 1)
        {
            MediaPanel = createMediaPanel(width: (int)(mainPanel.Width * 0.75), height: (int)(mainPanel.Height * 0.85), backColor: Color.FromArgb(30, 30, 30));

            TableLayoutPanel MediaListControlTableLayout = Components.CreateTableLayoutPanel(1, 2);

            MediaListControlTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80f));
            MediaListControlTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));

            MediaPanel.Controls.Add(MediaListControlTableLayout);

            MediaListTableLayout = new TableLayoutPanel
            {
                RowCount = 2,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            MediaListTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            MediaListTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30f));
            MediaListControlTableLayout.Controls.Add(MediaListTableLayout, 0, 0);


            MediaListControlTableLayout.Controls.Add(SortPanel(), 1, 0);
            AddMediaList(page);
            createPages();

            mainPanel.Controls.Add(MediaPanel);
        }

        private TableLayoutPanel SortPanel()
        {
            var main = Components.CreateTableLayoutPanel(4, 1,
                rowStyles: new List<RowStyle>
                {
            new RowStyle(SizeType.Percent, 20),
            new RowStyle(SizeType.Percent, 30),
            new RowStyle(SizeType.Percent, 20),
            new RowStyle(SizeType.Percent, 20),
            new RowStyle(SizeType.Percent, 10)
                },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });

            var mediaSort = CreateMediaSortPanel();
            var genresSort = CreateGenresSortPanel();
            var userListSort = CreateUserListSortPanel();
            var mediaStatusSort = CreateMediaStatusSortPanel();

            main.Controls.Add(mediaSort);
            main.Controls.Add(genresSort);
            main.Controls.Add(userListSort);
            main.Controls.Add(mediaStatusSort);

            Button findButton = new Button
            {
                Text = "Search",
                Dock = DockStyle.Fill
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

        private TableLayoutPanel CreateMediaSortPanel()
        {
            var mediaSort = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 30), new RowStyle(SizeType.Percent, 100) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });

            mediaSort.Controls.Add(createNavLabel("mediaLabel", "Media:"));
            var mediaTypes = new[] { "Media", "Book", "Comics", "Game" };
            mediaSort.Controls.Add(CreateMediaCheckBoxes(mediaTypes));

            return mediaSort;
        }

        private TableLayoutPanel CreateGenresSortPanel()
        {
            Genres[] genres = MediaService.GetGenres(); 

            var genresSort = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 30), new RowStyle(SizeType.Percent, 100) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });

            genresSort.Controls.Add(createNavLabel("genresLabel", "Genres:"));
            genresSort.Controls.Add(CreateGenresCheckBoxes(genres));

            return genresSort;
        }

        private TableLayoutPanel CreateUserListSortPanel()
        {
            var userListSort = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 30), new RowStyle(SizeType.Percent, 100) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });

            userListSort.Controls.Add(createNavLabel("userListLabel", "List:"));
            var mediaTypes = new[] { "InProcess", "Completed", "Planned", "Dropped" };
            
            userListSort.Controls.Add(CreateMediaCheckBoxes(mediaTypes));

            return userListSort;
        }

        private TableLayoutPanel CreateMediaStatusSortPanel()
        {
            var mediaStatusSort = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 30), new RowStyle(SizeType.Percent, 100) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });

            mediaStatusSort.Controls.Add(createNavLabel("mediaStatusLabel", "Status:"));
            var mediaStatus = new[] { "Released", "Ongoing", "Announced", "Canceled", "Delayed" };
            mediaStatusSort.Controls.Add(CreateMediaCheckBoxes(mediaStatus));

            return mediaStatusSort;
        }

        private FlowLayoutPanel CreateMediaCheckBoxes(string[] types)
        {
            var flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };

            foreach (var type in types)
            {
                var checkBox = Components.CreateCheckBox(type, Color.AliceBlue);
                flowLayoutPanel.Controls.Add(checkBox);
            }

            return flowLayoutPanel;
        }

        private FlowLayoutPanel CreateGenresCheckBoxes(Genres[] genres)
        {
            var flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };

            foreach (var genre in genres)
            {
                var checkBox = Components.CreateCheckBox(genre.GenreName, Color.AliceBlue);
                checkBox.Tag = genre.GenreID; // Optionally store GenreID in Tag for later use
                flowLayoutPanel.Controls.Add(checkBox);
            }

            return flowLayoutPanel;
        }

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

            Button leftArrowButton = new Button
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
                    Button pageButton = CreatePageButton(i + 1, i == currentPage - 1);
                    pagesTableLayout.Controls.Add(pageButton, i + 1, 0);
                }
            }
            else
            {
                Button firstPageButton = CreatePageButton(1, currentPage == 1);
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
                    Button pageButton = CreatePageButton(i, i == currentPage);
                    pagesTableLayout.Controls.Add(pageButton, i - startPage + 2, 0);
                }

                Button lastPageButton = CreatePageButton(numPages, currentPage == numPages);
                pagesTableLayout.Controls.Add(lastPageButton, maxButtons, 0);
            }

            Button rightArrowButton = new Button
            {
                Text = ">",
                Dock = DockStyle.Fill,
                BackColor = Color.LightBlue,
                Enabled = currentPage < numPages
            };
            pagesTableLayout.Controls.Add(rightArrowButton, columnCount - 1, 0);

            MediaListTableLayout.Controls.Add(pagesTableLayout, 0, 1);
        }
        private Button CreatePageButton(int pageNumber, bool isCurrent)
        {
            Button pageButton = new Button
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

            mainMediaList.Controls.Add(AddMediaBlocks(currentMediaCols, currentMediaRows, pageNumber));

            MediaListTableLayout.Controls.Add(mainMediaList, 0, 0);
    }

    #endregion

    #region Navigation Label
    private Label createNavLabel(string labelName, string labelText)
        {
            Label navLabel = new Label
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = DarkTheme.ForeButtonColor,
                Margin = new Padding(0),
                Name = labelName,
                TabIndex = 6,
                Text = labelText,
                TextAlign = ContentAlignment.BottomLeft
            };

            return navLabel;
        }

        #endregion

        #region Login Button
        private void createLoginButton()
        {
            Button loginBut = new Button
            {
                Anchor = AnchorStyles.Right,
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = DarkTheme.ForeButtonColor,
                Margin = new Padding(0),
                Name = "loginButton",
                Size = new Size(151, 40),
                TabIndex = 6,
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
        private void addUserPanel(MediaNexus_Backend.User user)
        {
            userPanel = new Panel
            {
                Size = new Size(140, 40),
                Margin = new Padding(0),
                Anchor = AnchorStyles.Right,

            };

            TableLayoutPanel userLayout = Components.CreateTableLayoutPanel(1, 3);

            userLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            userLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
            userLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
            userLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));

            PictureBox userIco = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = string.IsNullOrEmpty(user.UserImageURL) ?
                "https://ih1.redbubble.net/image.1066412296.0216/fposter,small,wall_texture,product,750x1000.u4.jpg" : user.UserImageURL,
                Margin = new Padding(0),
                Cursor = Cursors.Hand,
            };
            userIco.MouseClick += UserPanel_Click;
            userLayout.Controls.Add(userIco, 0, 0);

            Label userName = new Label
            {
                Text = user.Nickname,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0),
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            };
            userName.MouseClick += UserPanel_Click;
            userLayout.Controls.Add(userName, 1, 0);

            Label arrowLabel = new Label
            {
                Text = "▼",
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0),
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                Cursor = Cursors.Hand,
            };
            arrowLabel.MouseClick += UserPanel_Click;
            userLayout.Controls.Add(arrowLabel, 2, 0);

            userPanel.Controls.Add(userLayout);

            navTableLayoutPanel.Controls.Add(userPanel, 4, 0);
            createUserNav(user.Role.ToString());
        }

        private void createUserNav(string role)
        {
            bool isAdmin;
            if (role == "admin" || role == "moderator") isAdmin = true;
            else isAdmin = false;

            userNav = new Panel
            {
                Size = new Size(140, isAdmin ? 330 : 290),
                Location = new Point(userPanel.Location.X, userPanel.Location.Y),
                BackColor = Color.FromArgb(20, 20, 20),
                Visible = false,
                Margin = new Padding(0)
            };

            TableLayoutPanel userNavLayout = Components.CreateTableLayoutPanel(isAdmin ? 8 : 7, 1);


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


            Label accountLabel = new Label
            {
                Text = "Account",
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            userNavLayout.Controls.Add(accountLabel, 0, 0);

            userNavLayout.Controls.Add(createUserNavButton("Profile", ProfileButton_Click), 0, 1);
            userNavLayout.Controls.Add(createUserNavButton("My Media List", MyMediaList_Click), 0, 2); 
            userNavLayout.Controls.Add(createUserNavButton("Settings", ProfileSettingsButton_Click), 0, 3);
            userNavLayout.Controls.Add(createUserNavButton("Exit", ExitButton_Click), 0, 4);

            Label controlLabel = new Label
            {
                Text = "Control",
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            userNavLayout.Controls.Add(controlLabel, 0, 5);
            userNavLayout.Controls.Add(createUserNavButton("media", (s, e) => AddButton_Click("media"), isAddingButton: true), 0, 6);
            userNavLayout.Controls.Add(createUserNavButton("book", (s, e) => AddButton_Click("book"), isAddingButton: true), 0, 7);
            if (isAdmin) userNavLayout.Controls.Add(createUserNavButton("Media control", ExitButton_Click), 0, 8);

            userNav.Controls.Add(userNavLayout);
            this.mainPanel.Controls.Add(userNav);
            userNav.BringToFront();
        }

        private Panel createUserNavButton(string buttonText, EventHandler onClick, bool isAddingButton = false)
        {
            Color CircleColor = Color.White;

            Panel button = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                BackColor = Color.Transparent
            };

            TableLayoutPanel buttonLayout = Components.CreateTableLayoutPanel(1, 2);

            buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            Label symbol = new Label
            {
                Text = buttonText[0].ToString(),
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Size = new Size(30, 30),
                ForeColor = Color.White,
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
            Label buttonName = new Label
            {
                Text = isAddingButton ? $"Add {buttonText}" : buttonText,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                ForeColor = Color.White,
                BackColor = Color.Transparent
            };

            buttonLayout.Controls.Add(symbol, 0, 0);
            buttonLayout.Controls.Add(buttonName, 1, 0);

            button.Controls.Add(buttonLayout);


            Label[] labels = new Label[] { buttonName, symbol };
            foreach (Label label in labels)
            {
                label.Click += (s, e) => onClick(s, e);

                label.MouseEnter += (s, e) =>
                {
                    button.BackColor = Color.White;
                    buttonName.ForeColor = Color.Black;
                    symbol.ForeColor = Color.Black;
                    CircleColor = Color.Black;
                    symbol.Invalidate();
                };

                label.MouseLeave += (s, e) =>
                {
                    button.BackColor = Color.FromArgb(20, 20, 20);
                    buttonName.ForeColor = Color.White;
                    symbol.ForeColor = Color.White;
                    CircleColor = Color.White;
                    symbol.Invalidate();
                };
            }

            return button;
        }
        #endregion

        #region User Settings Panel
        private void createSettingsPanel(MediaNexus_Backend.User user)
        {
            ProfileSettingsPanel = createMediaPanel(width: (int)(mainPanel.Width * 0.75), height: 480, backColor: Color.FromArgb(30, 30, 30));

            TableLayoutPanel ProfileSettingsLayout = CreateProfileSettingLayout();
            ProfileSettingsPanel.Controls.Add(ProfileSettingsLayout);

            ProfileSettingsLayout.Controls.Add(createUsernameLine(user.Nickname), 0, 0);

            TableLayoutPanel SettingsFormLayout = CreateSettingsForm();
            ProfileSettingsLayout.Controls.Add(SettingsFormLayout, 0, 1);

            mainPanel.Controls.Add(ProfileSettingsPanel);
        }

        private TableLayoutPanel CreateProfileSettingLayout()
        {
            TableLayoutPanel profileSettingLayout = Components.CreateTableLayoutPanel(2, 1);

            profileSettingLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            profileSettingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            profileSettingLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            return profileSettingLayout;
        }
        private Panel createUsernameLine(string username)
        {
            Panel userNamePanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Gray,
                Margin = new Padding(1)
            };

            Label UserNameLabel = new Label
            {
                Text = username,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            userNamePanel.Controls.Add(UserNameLabel);
            return userNamePanel;
        }
        private TableLayoutPanel CreateSettingsForm()
        {
            TableLayoutPanel settingsFormLayout = Components.CreateTableLayoutPanel(1, 2);
            settingsFormLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            settingsFormLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));

            settingsFormLayout.Controls.Add(createInfoPanel(), 0, 0);

            settingsFormLayout.Controls.Add(AddingForm.addMeddiaImageBox(imageUrl = AddingForm.addTextBox("Image url", needMargin: true, fixedWidth: 200), new Size(200, 200)), 1, 0);

            return settingsFormLayout;
        }
        private TableLayoutPanel createInfoPanel()
        {
            TableLayoutPanel firstColumnLayout = Components.CreateTableLayoutPanel(7, 1);

            for (int i = 0; i < 4; ++i) firstColumnLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            firstColumnLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 120));
            firstColumnLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));

            firstColumnLayout.Controls.Add(SettingNickname = AddingForm.addTextBox("Nickname", needMargin: true, multiLine: false));
            firstColumnLayout.Controls.Add(SettingEmail = AddingForm.addTextBox("Email", needMargin: true, multiLine: false));
            firstColumnLayout.Controls.Add(SettingNewPassword = AddingForm.addTextBox("New password", needMargin: true, multiLine: false, isPassword: true));
            firstColumnLayout.Controls.Add(SettingCurrentPassword = AddingForm.addTextBox("Current password", needMargin: true, multiLine: false, isPassword: true));

            Description = AddingForm.addTextBox("Description", needMargin: true, multiLine: true);
            Description.Height = 100;
            firstColumnLayout.Controls.Add(Description);


            firstColumnLayout.Controls.Add(AddingForm.createLabel("Birthday"));
            firstColumnLayout.Controls.Add(birthdayPicker = new DatePickerPanel());
            firstColumnLayout.Controls.Add(CreateSaveButton());

            return firstColumnLayout;
        }
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

            //themeButton.Click += ChangeTheme_Click;
            return themeButton;
        }

        #endregion

        #region Media Info Panels
        Panel MediaInfoControlPanel;
        MainMedia currentMediaUse;
        private void addMediInfoPanel(MainMedia media)
        {   
            currentMediaUse = media;
            UserMediaStatus inUserList = MediaService.GetUserMediaStatus(currentUser.Id, media.Id);
            mainPanel.Controls.Clear();
            ChangeNavLabelText(media.MainType.ToString());
            MediaInfoControlPanel = createMediaInfoPanel(media);
            mainPanel.Controls.Add(MediaInfoControlPanel);
        }

        private Panel createMediaInfoPanel(MainMedia media)
        {
            MediaInfoControlPanel = createMediaPanel(width: (int)(mainPanel.Width * 0.75), height: (int)(mainPanel.Height * 0.95), backColor: Color.FromArgb(30, 30, 30));

            TableLayoutPanel rowsTableLayout = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 380), new RowStyle(SizeType.Percent, 100)},
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F)});

            MediaInfoControlPanel.Controls.Add(rowsTableLayout);

           
            rowsTableLayout.Controls.Add(mediaInfo(media), 0, 0);
            showResponseButton(isResponse: false, rowsTableLayout, media);

            return MediaInfoControlPanel;
        }

        private TableLayoutPanel mediaInfo(MainMedia media)
        {
            TableLayoutPanel infoTableLayout = Components.CreateTableLayoutPanel(1, 2,
               rowStyles: new List<RowStyle> { new RowStyle(SizeType.Percent, 100) },
               colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Absolute, 180), new ColumnStyle(SizeType.Percent, 100) });

            
            infoTableLayout.Controls.Add(ControlEpisodePanel(media.ImageURL, media.Id), 0, 0);
            infoTableLayout.Controls.Add(addMediaInformation(media.MainType, media.Id), 1, 0);

            return infoTableLayout;
        }

        Button goToResponse;
        Button goToMediaInfo;
        private void showResponseButton(bool isResponse, TableLayoutPanel rowsTableLayout, MainMedia media)
        {
            goToResponse = new Button
            {
                Text = "->",
                ForeColor = Color.White,
                Height = 40,
                Width = 50,
                Anchor = AnchorStyles.Right | AnchorStyles.Bottom,
            };

            goToMediaInfo = new Button
            {
                Text = "<-",

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
                rowsTableLayout.Controls.Add(createResponsePanel(media), 0, 0);
                rowsTableLayout.Controls.Add(goToMediaInfo, 0, 1);
            };

            if (isResponse)
                rowsTableLayout.Controls.Add(goToMediaInfo, 0, 1);
            else
                rowsTableLayout.Controls.Add(goToResponse, 0, 1);
        }

        private TableLayoutPanel createResponsePanel(MainMedia media, bool isOnly = true)
        {
            TableLayoutPanel main = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 30), new RowStyle(SizeType.Absolute, isOnly ? 220 : 180), new RowStyle(SizeType.Absolute, 100), new RowStyle(SizeType.Absolute, 30) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Percent, 100F) });

            Label responseLabel = new Label
            {
                Text = "Response:",
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            TextBox userResponse = AddingForm.addTextBox("Write your response...", needMargin: false, multiLine: true);
            userResponse.Height = 100;
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.Yellow,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false 
            };
       
            Button sendUserResponse = new Button
            {
                Dock = DockStyle.Fill,
                Text = "Send Response",
                ForeColor = Color.White,
                BackColor = Color.FromArgb(28, 28, 28),
                Margin = new Padding(0)
            };

            for(int i = 0; i < 5; i++)
            {
                Panel blue = new Panel
                {             
                    BackColor = Color.Blue,
                    Height = 500,
                    Width = flowLayoutPanel.Width,
                    Margin = new Padding(5, 5, 5, 0)
                };

                Label reviewLabel = new Label
                {
                    Text = $"Panel {i + 1}", // Текст для кожної панелі
                    ForeColor = Color.White,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                blue.Controls.Add(reviewLabel);
                flowLayoutPanel.Controls.Add(blue); // Додаємо панель до flowLayoutPanel
            }

            sendUserResponse.Click += (s, e) =>
            {
                // Створення нової панелі рецензії
                Panel blue = new Panel
                {
                    Dock = DockStyle.Top, // Використовуйте DockStyle.Top для правильного додавання
                    BackColor = Color.Blue,
                    Height = 80,
                    Width = 100,
                    Margin = new Padding(0, 5, 0, 0) // Додайте верхній відступ для відділення рецензій
                };

                // Можна додати текст або інші елементи до blue панелі, наприклад:
                Label reviewLabel = new Label
                {
                    Text = userResponse.Text,
                    ForeColor = Color.White,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                blue.Controls.Add(reviewLabel); // Додаємо текст до панелі рецензії
                flowLayoutPanel.Controls.Add(blue); // Додаємо панель рецензії до flowLayoutPanel
                userResponse.Clear(); // Очищення текстового поля після надсилання
            };

            main.Controls.Add(responseLabel);
            main.Controls.Add(flowLayoutPanel);
            main.Controls.Add(userResponse);
            main.Controls.Add(sendUserResponse);

            return main;
        }

        private PictureBox CreatePictureBox(string pictureURL)
        {
            PictureBox mediaPictureBox = new PictureBox
            {
                Dock = DockStyle.Top,
                Height = 260,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                ImageLocation = pictureURL,
            };

            return mediaPictureBox;
        }

        private Panel createMediaPanel(int width, int height, Color backColor)
        {

            int xPosition = (mainPanel.Width - width) / 2;
            int yPosition = (mainPanel.Height - height) / 2;

            Panel MediaPanel = new Panel
            {
                Size = new Size(width, height),
                Location = new Point(xPosition, yPosition),
                BackColor = backColor,
                Margin = new Padding(0), 
            };

            return MediaPanel;
        }

        private Panel addMediaInformation(MainMediaType type, int mediaID)
        {
            Media media = MediaService.GetMedia(mediaID);
            

            Panel panel = new Panel {Dock  = DockStyle.Fill};
            panel.Margin = new Padding(10);
            TableLayoutPanel infoTableLayout = Components.CreateTableLayoutPanel(11, 1);
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
                ForeColor = Color.White,
                Dock = DockStyle.Top, 
                Font = new Font("Arial", 10, FontStyle.Regular),
                BorderStyle = BorderStyle.None,
                Multiline = true,
                ReadOnly = true,
                BackColor = Color.FromArgb(30, 30, 30),
                ScrollBars = ScrollBars.Vertical, 
                Height = 80
            };
            infoTableLayout.Controls.Add(textBox);


            return panel;
        }

        Label createInfoLabel(string name, string val, Font font)
        {
            Label label = new Label
            {
                Text = name + val,
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                Font = font,
                AutoSize = true,
                Margin = new Padding(5)
            };

            return label;
        }


        TableLayoutPanel titleControlTable;
        private Panel ControlEpisodePanel(string url, int mediaId)
        {
            TableLayoutPanel control = Components.CreateTableLayoutPanel(2, 1,
                rowStyles: new List<RowStyle> { new RowStyle(SizeType.Absolute, 280), new RowStyle(SizeType.Percent, 100F) },
                colStyles: new List<ColumnStyle> { new ColumnStyle(SizeType.Absolute, 180) });

            Panel controlPanel = new Panel
            {
                Dock = DockStyle.Fill,
            };

            control.Controls.Add(CreatePictureBox(url), 0, 0);


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
        Label titleStatus;
        private Panel MediaControl(UserMediaStatus inUserList)
        {
            Panel ControlPanel_CloseMode = new Panel
            {
                Height = 20,
                ForeColor = Color.White,
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
                    UserMediaStatusForm control = new UserMediaStatusForm(inUserList, currentMediaUse);
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
                ForeColor = Color.White
            };
            minusButton.FlatAppearance.BorderSize = 0;


            int full = MediaService.GetMediaCountByType(currentMediaUse.MainType, currentMediaUse.Id);
            int ended = inUserList.EndedPageOrEpisode;
            Label episodeCountLabel = new Label
            {
                Text = ended.ToString() + "/" + (full != 0 ? full.ToString() : "?"),
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(0),
                ForeColor = Color.White
            };

            Button plusButton = new Button
            {
                Text = "+",
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
                Margin = new Padding(0),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White
            };
            plusButton.FlatAppearance.BorderSize = 0;
            plusButton.Click += (sender, e) => UpdateEpisodeCount(inUserList, episodeCountLabel, 1);
            minusButton.Click += (sender, e) => UpdateEpisodeCount(inUserList, episodeCountLabel, -1);

            episode.Controls.Add(minusButton, 0, 0); 
            episode.Controls.Add(episodeCountLabel, 1, 0); 
            episode.Controls.Add(plusButton, 2, 0);

            return episode;
        }
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

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel navTableLayoutPanel;
        private TableLayoutPanel navTableLayout;
        private TableLayoutPanel MediaListTableLayout;
        private TableLayoutPanel pagesTableLayout;

        private Label navNameLabel;

        private Button navButton;
        private Button searchButton;
        private Button loginButton;

        private Panel mainPanel;
        private Panel navMenuPanel;
        private Panel MediaPanel;
        private Panel mediaBlocksPanel;
        private Panel mediaHistoryAndNavPanel;
        private Panel goToNewMediaButton;
        private Panel userPanel;
        private Panel userNav;
        //private Panel ProfilePanel;
        private Panel ProfileSettingsPanel;
        private Panel mainMediaList;

        private TextBox searchTextBox;

        private TableLayoutPanel mediaBlocksTableLayoutPanel;

        #region Setting Components
        TextBox SettingNickname;
        TextBox SettingEmail;
        TextBox SettingCurrentPassword;
        TextBox SettingNewPassword;
        TextBox Description;
        TextBox imageUrl;
        DatePickerPanel birthdayPicker;
        #endregion
        #region Media Info Components
        Panel mediaInfoPanel;

        #endregion
    }
}