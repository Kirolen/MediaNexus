using MediaNexus.Class;
using MediaNexus_Backend;
using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace MediaNexus
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int currentMediaCols = 0;
        private int currentMediaRows = 0;

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
            this.loginButton = new System.Windows.Forms.Button();
            this.navNameLabel = new System.Windows.Forms.Label();
            this.navButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.navMenuPanel = new System.Windows.Forms.Panel();
            this.navTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.navButton_media = new System.Windows.Forms.Button();
            this.navButton_comics = new System.Windows.Forms.Button();
            this.navButton_book = new System.Windows.Forms.Button();
            this.navLabel_base = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.navTableLayoutPanel.SuspendLayout();
            this.navMenuPanel.SuspendLayout();
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
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(1044, 1);
            this.loginButton.Margin = new System.Windows.Forms.Padding(0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(151, 40);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
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
            this.navNameLabel.Click += new System.EventHandler(this.navNameLabel_Click);
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
            this.navButton.Click += new System.EventHandler(this.navButton_Click);
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
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
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
            // navMenuPanel
            // 
            this.navMenuPanel.BackColor = Color.FromArgb(59, 58, 58);
            this.navMenuPanel.Controls.Add(this.navTableLayout);
            this.navMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.navMenuPanel.Name = "navMenuPanel";
            this.navMenuPanel.TabIndex = 0;
            this.navMenuPanel.Visible = false;
            // 
            // navTableLayout
            // 
            this.navTableLayout.ColumnCount = 1;
            this.navTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navTableLayout.Controls.Add(this.navButton_media, 0, 1);
            this.navTableLayout.Controls.Add(this.navButton_comics, 0, 3);
            this.navTableLayout.Controls.Add(this.navButton_book, 0, 2);
            this.navTableLayout.Controls.Add(this.navLabel_base, 0, 0);
            this.navTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navTableLayout.Location = new System.Drawing.Point(0, 0);
            this.navTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.navTableLayout.Name = "navTableLayout";
            this.navTableLayout.RowCount = 5;
            this.navTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.navTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.navTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.navTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.navTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navTableLayout.Size = new System.Drawing.Size(179, 160);
            this.navTableLayout.TabIndex = 0;
            // 
            // navButton_media
            // 
            this.navButton_media.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.navButton_media.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navButton_media.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navButton_media.FlatAppearance.BorderSize = 0;
            this.navButton_media.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navButton_media.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navButton_media.ForeColor = System.Drawing.Color.White;
            this.navButton_media.Location = new System.Drawing.Point(0, 25);
            this.navButton_media.Margin = new System.Windows.Forms.Padding(0);
            this.navButton_media.Name = "navButton_media";
            this.navButton_media.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.navButton_media.Size = new System.Drawing.Size(179, 40);
            this.navButton_media.TabIndex = 3;
            this.navButton_media.Text = "Media";
            this.navButton_media.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navButton_media.UseVisualStyleBackColor = false;
            this.navButton_media.Click += new System.EventHandler(this.navButton_type_Click);
            this.navButton_media.MouseEnter += new System.EventHandler(this.navButton_MouseEnter);
            this.navButton_media.MouseLeave += new System.EventHandler(this.navButton_MouseLeave);
            // 
            // navButton_comics
            // 
            this.navButton_comics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.navButton_comics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navButton_comics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navButton_comics.FlatAppearance.BorderSize = 0;
            this.navButton_comics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navButton_comics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navButton_comics.ForeColor = System.Drawing.Color.White;
            this.navButton_comics.Location = new System.Drawing.Point(0, 111);
            this.navButton_comics.Margin = new System.Windows.Forms.Padding(0);
            this.navButton_comics.Name = "navButton_comics";
            this.navButton_comics.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.navButton_comics.Size = new System.Drawing.Size(179, 40);
            this.navButton_comics.TabIndex = 8;
            this.navButton_comics.Text = "Comics";
            this.navButton_comics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navButton_comics.UseVisualStyleBackColor = false;
            this.navButton_comics.Click += new System.EventHandler(this.navButton_type_Click);
            this.navButton_comics.MouseEnter += new System.EventHandler(this.navButton_MouseEnter);
            this.navButton_comics.MouseLeave += new System.EventHandler(this.navButton_MouseLeave);
            // 
            // navButton_book
            // 
            this.navButton_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.navButton_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navButton_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navButton_book.FlatAppearance.BorderSize = 0;
            this.navButton_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navButton_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navButton_book.ForeColor = System.Drawing.Color.White;
            this.navButton_book.Location = new System.Drawing.Point(0, 68);
            this.navButton_book.Margin = new System.Windows.Forms.Padding(0);
            this.navButton_book.Name = "navButton_book";
            this.navButton_book.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.navButton_book.Size = new System.Drawing.Size(179, 40);
            this.navButton_book.TabIndex = 7;
            this.navButton_book.Text = "Books";
            this.navButton_book.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navButton_book.UseVisualStyleBackColor = false;
            this.navButton_book.Click += new System.EventHandler(this.navButton_type_Click);
            this.navButton_book.MouseEnter += new System.EventHandler(this.navButton_MouseEnter);
            this.navButton_book.MouseLeave += new System.EventHandler(this.navButton_MouseLeave);
            // 
            // navLabel_base
            // 
            this.navLabel_base.AutoSize = true;
            this.navLabel_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navLabel_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navLabel_base.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.navLabel_base.Location = new System.Drawing.Point(0, 0);
            this.navLabel_base.Margin = new System.Windows.Forms.Padding(0);
            this.navLabel_base.Name = "navLabel_base";
            this.navLabel_base.Size = new System.Drawing.Size(179, 25);
            this.navLabel_base.TabIndex = 6;
            this.navLabel_base.Text = "Database:";
            this.navLabel_base.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.navMenuPanel.ResumeLayout(false);
            this.navMenuPanel.PerformLayout();
            this.navTableLayout.ResumeLayout(false);
            this.navTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Navigation Menu Panel
        /// <summary>
        /// Updates the navigation menu panel by setting the current page name and ensuring
        /// the navigation menu panel is added to the main panel and brought to the front.
        /// </summary>
        /// <param name="currentPage">A string representing the name of the current page. This will be set as the text of the navButton.</param>
        private void createNavMenuPanel(string currentPage)
        {
            this.navButton.Text = currentPage;
            this.mainPanel.Controls.Add(this.navMenuPanel);
            navMenuPanel.BringToFront();
        }

        #endregion

        #region mediaPanel
        private void createMainMediaPanel()
        {
            createNavMenuPanel("⌂ Home");
            if (currentUser.Username != string.Empty) createUserNav(currentUser.Status);

            int widthNewMedia = (int)(mainPanel.Width * 0.75);
            int heightNewMedia = (int)(mainPanel.Height * 0.85);

            int xPosition = (mainPanel.Width - widthNewMedia) / 2;
            int yPosition = (mainPanel.Height - heightNewMedia) / 2;

            MediaPanel = new Panel
            {
                Size = new Size(widthNewMedia, heightNewMedia),
                Location = new Point(xPosition, yPosition),
            };

            MediaPanel.Controls.Add(createGoToNewMediaButton()); 
            CreateRecentMediaPanel();
            createMediaHistoryAndNavPanel();

            mainPanel.Controls.Add(MediaPanel);
        }

        private Panel createGoToNewMediaButton()
        {
            int widthButton = MediaPanel.Width;
            int heightButton = 25;

            int xPosition = (MediaPanel.Width - widthButton) / 2;
            int yPosition = 25;

            goToNewMediaButton = new Panel()
            {
                Size = new Size(widthButton, heightButton),
                Location = new Point(xPosition, yPosition),
                BackColor = Color.FromArgb(100, 100, 100), // Initial background color
            };

            TableLayoutPanel goButtonLayout = new TableLayoutPanel
            {
                ColumnCount = 2,
                Dock = DockStyle.Fill,
                Cursor = Cursors.Hand
            };

            goButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            goButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));

            Label buttonLabel = new Label()
            {
                AutoSize = true,
                Text = "Go to new media",
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                Anchor = AnchorStyles.Left,
                ForeColor = Color.White,
                Cursor = Cursors.Hand
            };

            Label arrowLabel = new Label()
            {
                AutoSize = true,
                Text = ">",
                TextAlign = ContentAlignment.MiddleRight,
                Dock = DockStyle.Fill,
                Anchor = AnchorStyles.Right,
                ForeColor = Color.White,
                Cursor = Cursors.Hand
            };

            Label[] labels = { buttonLabel, arrowLabel };
            foreach (Label label in labels)
            {
                label.MouseEnter += (s, e) =>
                {
                    changeButtonForeColor(buttonLabel, Color.Orange);
                    changeButtonForeColor(arrowLabel, Color.Orange);
                };
                label.Click += this.goToNewMedia_button_Click;
                label.MouseLeave += (s, e) =>
                {
                    changeButtonForeColor(buttonLabel, Color.White);
                    changeButtonForeColor(arrowLabel, Color.White);
                };
            }

            goButtonLayout.Controls.Add(buttonLabel, 0, 0);
            goButtonLayout.Controls.Add(arrowLabel, 1, 0);
            goToNewMediaButton.Controls.Add(goButtonLayout);


            goButtonLayout.MouseEnter += (s, e) => 
            { 
                changeButtonForeColor(buttonLabel, Color.Orange);
                changeButtonForeColor(arrowLabel, Color.Orange);
            };
            goButtonLayout.Click += this.goToNewMedia_button_Click;
            goButtonLayout.MouseLeave += (s, e) => {
                changeButtonForeColor(buttonLabel, Color.White);
                changeButtonForeColor(arrowLabel, Color.White);
            };

            return goToNewMediaButton;
        }

        private void CreateRecentMediaPanel()
        {
            int panelWidth = MediaPanel.Width;
            int panelHeight = (int)(MediaPanel.Height * 0.6);

            int xPosition = (MediaPanel.Width - panelWidth) / 2;
            int yPosition = 60;

            mediaBlocksPanel = new Panel()
            {
                Size = new Size(panelWidth, panelHeight),
                Location = new Point(xPosition, yPosition)
            };

            mediaBlocksTableLayoutPanel = AddRecentMediaBlocks(5, 1, 1);

            mediaBlocksPanel.Controls.Add(mediaBlocksTableLayoutPanel);
            MediaPanel.Controls.Add(mediaBlocksPanel);
        }

        private TableLayoutPanel AddRecentMediaBlocks(int columnCount, int rowCount, int numPage)
        {
            TableLayoutPanel mediaBlocksTableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = columnCount,
                RowCount = rowCount,
                Dock = DockStyle.Fill,
                Margin = new System.Windows.Forms.Padding(0),
            };

            MediaNexus_Backend.Media[] RecentMedia = MNBackend.GetRecentMedia(columnCount * rowCount, numPage);

            for (int i = 0; i < rowCount; i++)
            {
                mediaBlocksTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / rowCount));
                for (int j = 0; j < columnCount; j++)
                {
                    mediaBlocksTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columnCount));

                    int currentIndex = (i * columnCount) + j;
                    if (currentIndex >= RecentMedia.Length) continue;

                    Panel mediaBlock = CreateRecentMediaBlock(RecentMedia[currentIndex].MediaId.ToString(), RecentMedia[currentIndex]);

                    mediaBlocksTableLayoutPanel.Controls.Add(mediaBlock, j, i);
                }
            }

            return mediaBlocksTableLayoutPanel;
        }

        private Panel CreateRecentMediaBlock(string name, Media currentMedia)
        {
            Panel mediaBlock = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Name = $"MediaBlock_{name}",
                Margin = new System.Windows.Forms.Padding(5),
                Tag = currentMedia,
            };

            TableLayoutPanel mediaBlockTableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 3,
                ColumnCount = 1,
                Margin = new System.Windows.Forms.Padding(0),
                Cursor = Cursors.Hand,
            };

            mediaBlockTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            mediaBlockTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            mediaBlockTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));

            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = currentMedia.ImageTitle,
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
            titleLabel.MouseEnter += (s, e) => changeButtonForeColor(titleLabel, Color.Orange);
            titleLabel.MouseLeave += (s, e) => changeButtonForeColor(titleLabel, Color.Black);
            titleLabel.Click += new System.EventHandler(this.goToNewMedia_button_Click);

            Label studioLabel = new Label
            {
                Dock = DockStyle.Fill,
                Text = currentMedia.Studio,
                MaximumSize = new Size(mediaBlock.Width, 0),
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0),
            };
            studioLabel.MouseEnter += (s, e) => changeButtonForeColor(titleLabel, Color.Orange);
            studioLabel.MouseLeave += (s, e) => changeButtonForeColor(titleLabel, Color.Black);


            pictureBox.MouseEnter += (s, e) => changeButtonForeColor(titleLabel, Color.Orange);
            pictureBox.MouseLeave += (s, e) => changeButtonForeColor(titleLabel, Color.Black);

            mediaBlockTableLayoutPanel.Controls.Add(titleLabel, 0, 1);
            mediaBlockTableLayoutPanel.Controls.Add(studioLabel, 0, 2);

            mediaBlock.Controls.Add(mediaBlockTableLayoutPanel);

            return mediaBlock;
        }

        private void createMediaHistoryAndNavPanel()
        {
            int widthPanel = MediaPanel.Width;
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
                BackColor = Color.FromArgb(233, 247, 251),
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

            // Create and add a Label for the text
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

        #region media list
        private void createMediaListPanel(string typeMedia, int page = 1)
        {
            createNavMenuPanel(typeMedia);
            if (currentUser.Username != string.Empty) createUserNav(currentUser.Status);


            int widthMediaListPanel = (int)(mainPanel.Width * 0.75);
            int heightMediaListPanel = (int)(mainPanel.Height * 0.85);

            int xPosition = (mainPanel.Width - widthMediaListPanel) / 2;
            int yPosition = (mainPanel.Height - heightMediaListPanel) / 2;

            MediaPanel = new Panel
            {
                Size = new Size(widthMediaListPanel, heightMediaListPanel),
                Location = new Point(xPosition, yPosition),
                BackColor = Color.Green,
                Margin = new Padding(0)
            };

            TableLayoutPanel MediaListControlTableLayout = new TableLayoutPanel
            {
                ColumnCount = 2,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

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
            MediaListControlTableLayout.Controls.Add(MediaListTableLayout);

            mainMediaList = new Panel
            {
                BackColor = Color.AliceBlue,
                Dock = DockStyle.Fill
            };

            int minBlockWidth = 110; 
            int minBlockHeight = 190;

            currentMediaCols = MediaListTableLayout.Width / minBlockWidth;
            currentMediaRows = MediaListTableLayout.Height / minBlockHeight;

            mainMediaList.Controls.Add(AddRecentMediaBlocks(currentMediaCols, currentMediaRows, page));
            
            MediaListTableLayout.Controls.Add(mainMediaList, 0, 0);
            createPages();

            mainPanel.Controls.Add(MediaPanel);
        }

        private int currentPage = 0;
        private void createPages()
        {
            int numMedia = MNBackend.GetMediaCount("media");
            int numPages = (int)Math.Ceiling((double)numMedia / (currentMediaCols * currentMediaRows));

            int maxButtons = 15; // Максимальна кількість кнопок, яку ми можемо показати (без фіксованих "1" і "останньої")
            int columnCount = 17;

            pagesTableLayout = new TableLayoutPanel
            {
                ColumnCount = columnCount,
                RowCount = 1,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            float columnPercentage = 100f / columnCount;
            for (int i = 0; i < columnCount; ++i)
                pagesTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columnPercentage));

            // Кнопка лівої стрілки
            Button leftArrowButton = new Button
            {
                Text = "<",
                BackColor = Color.LightBlue,
                Dock = DockStyle.Fill,
                Enabled = currentPage > 1
            };
            pagesTableLayout.Controls.Add(leftArrowButton, 0, 0);

            // Динамічна побудова кнопок сторінок
            if (numPages <= maxButtons) // Якщо сторінок мало, просто показуємо всі
            {
                for (int i = 0; i < numPages; i++)
                {
                    Button pageButton = CreatePageButton(i + 1, i == currentPage - 1);
                    pagesTableLayout.Controls.Add(pageButton, i + 1, 0);
                }
            }
            else // Якщо сторінок більше 15
            {
                // Додаємо кнопку "1"
                Button firstPageButton = CreatePageButton(1, currentPage == 1);
                pagesTableLayout.Controls.Add(firstPageButton, 1, 0);

                // Визначаємо, які кнопки показати залежно від поточної сторінки
                int startPage = Math.Max(2, currentPage - 6);
                int endPage = Math.Min(numPages - 1, currentPage + 6);

                // Якщо поточна сторінка ближче до початку
                if (currentPage <= 7)
                {
                    startPage = 2;
                    endPage = 13;
                }
                // Якщо поточна сторінка ближче до кінця
                else if (currentPage >= numPages - 7)
                {
                    startPage = numPages - 12;
                    endPage = numPages - 1;
                }

                // Додаємо кнопки від startPage до endPage
                for (int i = startPage; i <= endPage; i++)
                {
                    Button pageButton = CreatePageButton(i, i == currentPage);
                    pagesTableLayout.Controls.Add(pageButton, i - startPage + 2, 0);
                }

                // Додаємо кнопку останньої сторінки
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
                mainPanel.Controls.Clear(); 
                createMediaListPanel("New", pageNumber); 
            };

            return pageButton;
        }



        // Функція для оновлення сторінки
        //private void UpdatePage()
        //{
        //    // Логіка для оновлення контенту сторінки
        //    // Наприклад, виклик методу для відображення медіа для currentPage
        //    DisplayMediaForPage(currentPage);
        //}


        #endregion

        #region user nav
        private void addUserPanel(User user)
        {
            userPanel = new Panel
            {
                Size = new Size(140, 40),
                Margin = new Padding(0),
                Anchor = AnchorStyles.Right,
                
            };

            TableLayoutPanel userLayout = new TableLayoutPanel
            {
                ColumnCount = 3,
                RowCount = 1,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            userLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            userLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
            userLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
            userLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));

            PictureBox userIco = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = "https://ih1.redbubble.net/image.1066412296.0216/fposter,small,wall_texture,product,750x1000.u4.jpg",
                Margin = new Padding(0),
                Cursor = Cursors.Hand,
            };
            userIco.MouseClick += userPanel_Click;
            userLayout.Controls.Add(userIco, 0, 0);

            Label userName = new Label
            {
                Text = user.Username,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0),
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 12, FontStyle.Regular) 
            };
            userName.MouseClick += userPanel_Click;
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
            arrowLabel.MouseClick += userPanel_Click;
            userLayout.Controls.Add(arrowLabel, 2, 0);

            userPanel.Controls.Add(userLayout);

            navTableLayoutPanel.Controls.Add(userPanel, 4, 0);
            createUserNav(user.Status);
        }

        private void createUserNav(string role)
        {
            bool isAdmin;
            if (role == "admin" || role == "moderator") isAdmin = true;
            else isAdmin = false;

            userNav = new Panel
            {
                Size = new Size(140, isAdmin ? 290 : 250),
                Location = new Point(userPanel.Location.X, userPanel.Location.Y),
                BackColor = Color.FromArgb(20, 20, 20),
                Visible = false,
                Margin = new Padding(0)
            };

            TableLayoutPanel userNavLayout = new TableLayoutPanel
            {
                RowCount = isAdmin ? 8 : 7,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            userNavLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F)); 
            userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F)); 
            userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            userNavLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
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
            userNavLayout.Controls.Add(createUserNavButton("My Media List", ExitButton_Click), 0, 2); //need change
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
            userNavLayout.Controls.Add(createUserNavButton("Add media", addButton_Click), 0, 6);
            if (isAdmin) userNavLayout.Controls.Add(createUserNavButton("Media control", ExitButton_Click), 0, 7);

            userNav.Controls.Add(userNavLayout);
            this.mainPanel.Controls.Add(userNav);
            userNav.BringToFront();
        }

        private Panel createUserNavButton(string buttonText, EventHandler onClick)
        {
            Color CircleColor = Color.White;

            Panel button = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                BackColor = Color.Transparent 
            };

            TableLayoutPanel buttonLayout = new TableLayoutPanel
            {
                ColumnCount = 2,
                RowCount = 1,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

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
                Text = buttonText,
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


            Label[] labels = new Label[] {buttonName, symbol};
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

        #region Profile
        void createProfile(User user)
        {
            createNavMenuPanel("Profile");
            createUserNav(currentUser.Status);

            int widthNewMedia = (int)(mainPanel.Width * 0.75);
            int heightNewMedia = 400;
            int xPosition = (mainPanel.Width - widthNewMedia) / 2;
            int yPosition = (mainPanel.Height - heightNewMedia) / 2;

            ProfilePanel = new Panel
            {
                Size = new Size(widthNewMedia, heightNewMedia),
                Location = new Point(xPosition, yPosition),
            };

            TableLayoutPanel ProfileLayout = CreateProfileLayout();
            ProfilePanel.Controls.Add(ProfileLayout);

            // User Info Section
            TableLayoutPanel UserInfoLayout = CreateUserInfoLayout();
            ProfileLayout.Controls.Add(UserInfoLayout);
            UserInfoLayout.Controls.Add(createProfilePicture(), 0, 0);
            UserInfoLayout.Controls.Add(createUserInfo(user), 1, 0);

            // All Info Section (Media, Books, Comics)
            TableLayoutPanel ALLInfoLayout = CreateALLInfoLayout();
            ProfileLayout.Controls.Add(ALLInfoLayout, 0, 1);

            ALLInfoLayout.Controls.Add(CreateMediaInfoLayout(), 0, 0);
            ALLInfoLayout.Controls.Add(CreateBooksInfoLayout(), 0, 1);
            ALLInfoLayout.Controls.Add(CreateComicsInfoLayout(), 0, 2);

            mainPanel.Controls.Add(ProfilePanel);
        }
        TableLayoutPanel CreateProfileLayout()
        {
            TableLayoutPanel ProfileLayout = new TableLayoutPanel
            {
                RowCount = 2,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            ProfileLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            ProfileLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));

            return ProfileLayout;
        }
        TableLayoutPanel CreateUserInfoLayout()
        {
            TableLayoutPanel UserInfoLayout = new TableLayoutPanel
            {
                RowCount = 1,
                ColumnCount = 2,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            UserInfoLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F)); 
            UserInfoLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));   
            return UserInfoLayout;
        }
        TableLayoutPanel CreateALLInfoLayout()
        {
            TableLayoutPanel ALLInfoLayout = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                BackColor = Color.LightGray
            };

            ALLInfoLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
            ALLInfoLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
            ALLInfoLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33));

            return ALLInfoLayout;
        }
        TableLayoutPanel CreateMediaInfoLayout()
        {
            int watched = 70, watching = 10, drop = 8;
            Color[] colors = { Color.FromArgb(70, 130, 180), Color.FromArgb(121, 169, 207), Color.FromArgb(20, 20, 20) };
            string[] buttonsText = { "On hold", "Watched", "Watching", "Drop" };
            return CreateInfoLayout(watched, watching, drop, colors, "Media", buttonsText);
        }
        TableLayoutPanel CreateBooksInfoLayout()
        {
            int read = 50, reading = 20, abandoned = 5;
            Color[] colors = { Color.FromArgb(139, 199, 153), Color.FromArgb(185, 237, 172), Color.FromArgb(20, 20, 20) };
            string[] buttonsText = { "On hold", "Read", "Reading", "Drop" };
            return CreateInfoLayout(read, reading, abandoned, colors, "Books", buttonsText);
        }
        TableLayoutPanel CreateComicsInfoLayout()
        {
            int read = 30, reading = 15, abandoned = 10;
            Color[] colors = { Color.FromArgb(183, 139, 199), Color.FromArgb(237, 172, 217), Color.FromArgb(20, 20, 20) };
            string[] buttonsText = { "On hold", "Read", "Reading", "Drop" };
            return CreateInfoLayout(read, reading, abandoned, colors, "Comics", buttonsText);
        }
        TableLayoutPanel CreateInfoLayout(int primary, int secondary, int tertiary, Color[] colors, string name, string[] buttonText)
        {
            TableLayoutPanel InfoLayout = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
            };

            InfoLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            InfoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            InfoLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));

            Label lineName = new Label
            {
                Text = name,
                Size = new Size(80, 20),
                Anchor = AnchorStyles.Left | AnchorStyles.Bottom,
            };
            InfoLayout.Controls.Add(lineName, 0, 0);

            TableLayoutPanel InfoLineLayout = CreateInfoLineLayout(primary, secondary, tertiary, colors);
            InfoLayout.Controls.Add(InfoLineLayout, 0, 1);

            TableLayoutPanel ButtonLayout = CreateActionButtons(buttonText);
            InfoLayout.Controls.Add(ButtonLayout, 0, 2);


            return InfoLayout;
        }
        TableLayoutPanel CreateActionButtons(string[] buttonText)
        {
            TableLayoutPanel buttonLayout = new TableLayoutPanel
            {
                RowCount = 1,
                ColumnCount = 5,
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
            };
            for (int i = 0; i < 4; i++)
            {

                buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
                Button button = new Button
                {
                    Text = buttonText[i],
                    Size = new Size(100, 20),
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black,
                    FlatStyle = FlatStyle.Flat
                };
                button.FlatAppearance.BorderSize = 0;

                button.MouseEnter += (s, e) => button.ForeColor = Color.Orange;
                button.MouseLeave += (s, e) => button.ForeColor = Color.Black;

                buttonLayout.Controls.Add(button, i, 0);
            }

            return buttonLayout;
        }
        TableLayoutPanel CreateInfoLineLayout(int primary, int secondary, int tertiary, Color[] colors )
        {
            int total = primary + secondary + tertiary;

            TableLayoutPanel InfoLineLayout = new TableLayoutPanel
            {
                RowCount = 1,
                ColumnCount = 3,
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
            };

            InfoLineLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (primary / (float)total) * 100));
            InfoLineLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (secondary / (float)total) * 100));
            InfoLineLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (tertiary / (float)total) * 100));

            InfoLineLayout.Controls.Add(createLabel(primary, colors[0], leftMargin:true), 0, 0);
            InfoLineLayout.Controls.Add(createLabel(secondary, colors[1]), 1, 0);
            InfoLineLayout.Controls.Add(createLabel(tertiary, colors[2], rightMargin:true), 2, 0);

            return InfoLineLayout;
        }
        private Label createLabel(int num, Color BC, bool leftMargin = false, bool rightMargin = false)
        {
            return new Label
            {
                Text = num.ToString(),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = BC,
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                Margin = new Padding((leftMargin) ? 5 : 0,
                0,
                (rightMargin) ? 5 : 0,
                0)
            };
        }
        PictureBox createProfilePicture()
        {
            return new PictureBox
            {
                Size = new Size(200, 200),
                ImageLocation = "https://pbs.twimg.com/profile_images/1131624264405327873/1YpVVtxD_400x400.jpg",
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };
        }
        Panel createUserInfo(User user)
        {
            Panel userInfoPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10),
                BackColor = Color.Transparent
            };

            Label nameLabel = new Label
            {
                Text = "USER",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                Dock = DockStyle.Top,
                AutoSize = true,
                ForeColor = Color.White
            };

            Label lastVisitLabel = new Label
            {
                Text = $"Last visit: ",
                Font = new Font("Segoe UI", 15),
                Dock = DockStyle.Top,
                AutoSize = true,
                ForeColor = Color.White
            };

            Label registrationDateLabel = new Label
            {
                Text = $"In the application since: ",
                Font = new Font("Segoe UI", 15),
                Dock = DockStyle.Top,
                AutoSize = true,
                ForeColor = Color.White
            };

            userInfoPanel.Controls.Add(registrationDateLabel);
            userInfoPanel.Controls.Add(lastVisitLabel);
            userInfoPanel.Controls.Add(nameLabel);

            return userInfoPanel;
        }


        #endregion

        #region ProfileSettings

        private void createSettingsPanel(User user)
        {
            createNavMenuPanel("Settings");
            createUserNav(currentUser.Status); 

            int widthSettingsPanel = (int)(mainPanel.Width * 0.75);
            int heightSettingsPanel = 400;
            int xPosition = (mainPanel.Width - widthSettingsPanel) / 2;
            int yPosition = (mainPanel.Height - heightSettingsPanel) / 2;

            ProfileSettingsPanel = new Panel
            {
                Size = new Size(widthSettingsPanel, heightSettingsPanel),
                Location = new Point(xPosition, yPosition),
                BackColor = Color.White,
            };

            TableLayoutPanel ProfileSettingsLayout = CreateProfileSettingLayout();
            ProfileSettingsPanel.Controls.Add(ProfileSettingsLayout);

            Panel userNamePanel = createUsernameLine(user.Username);
            ProfileSettingsLayout.Controls.Add(userNamePanel, 0, 0);

            TableLayoutPanel SettingsFormLayout = CreateSettingsForm();
            ProfileSettingsLayout.Controls.Add(SettingsFormLayout, 0, 1);

            mainPanel.Controls.Add(ProfileSettingsPanel);
        }

        private TableLayoutPanel CreateSettingsForm()
        {
            TableLayoutPanel settingsFormLayout = new TableLayoutPanel
            {
                ColumnCount = 2,
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };

            settingsFormLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            settingsFormLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));

            TableLayoutPanel firstColumnLayout = new TableLayoutPanel
            {
                RowCount = 5,
                Dock = DockStyle.Fill
            };
            firstColumnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            firstColumnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            firstColumnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            firstColumnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            firstColumnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));

            firstColumnLayout.Controls.Add(CreateTextBox("Name", "Enter new name"), 0, 0);
            firstColumnLayout.Controls.Add(CreateTextBox("Email", "Enter new email"), 0, 1);
            firstColumnLayout.Controls.Add(CreateTextBox("New Password", "Enter new password", true), 0, 2);
            firstColumnLayout.Controls.Add(CreateTextBox("Current Password", "Enter current password", true), 0, 3);
            firstColumnLayout.Controls.Add(CreateThemeButton(), 0, 4);

            settingsFormLayout.Controls.Add(firstColumnLayout, 0, 0);

            TableLayoutPanel secondColumnLayout = new TableLayoutPanel
            {
                RowCount = 3,
                Dock = DockStyle.Fill
            };
            secondColumnLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200));
            secondColumnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            secondColumnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            PictureBox profilePictureBox = new PictureBox
            {
                Size = new Size(200, 200),
                ImageLocation = "https://ih1.redbubble.net/image.4939897710.6996/fposter,small,wall_texture,square_product,600x600.jpg",
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            secondColumnLayout.Controls.Add(profilePictureBox, 0, 0);

            secondColumnLayout.Controls.Add(CreateAddImageButton(), 0, 1);
            secondColumnLayout.Controls.Add(CreateSaveButton(), 0, 2);

            settingsFormLayout.Controls.Add(secondColumnLayout, 1, 0);

            return settingsFormLayout;
        }

        private TextBox CreateTextBox(string placeholder, string toolTipText, bool isPassword = false)
        {
            TextBox textBox = new TextBox
            {
                Dock = DockStyle.Fill,
                ForeColor = Color.Gray,
                Text = placeholder,
                MaximumSize = new Size(400, 30), 
                PasswordChar = isPassword ? '\0' : '\0' 
            };

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(textBox, toolTipText);

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                    if (isPassword)
                    {
                        textBox.PasswordChar = '*';
                    }
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                    textBox.PasswordChar = '\0'; 
                }
            };

            return textBox;
        }

        private Button CreateAddImageButton()
        {
            Button addImageButton = new Button
            {
                Text = "Choose image",  
                Width = 200,
                Height = 30,
                BackColor = Color.LightBlue, 
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(0, 5, 0, 0),
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            addImageButton.MouseEnter += (s, e) =>
            {
                addImageButton.BackColor = Color.DeepSkyBlue;
            };

            addImageButton.MouseLeave += (s, e) =>
            {
                addImageButton.BackColor = Color.LightBlue; 
            };

            return addImageButton;
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

            saveButton.MouseEnter += (s, e) =>
            {
                saveButton.BackColor = Color.MediumSeaGreen; 
            };

            saveButton.MouseLeave += (s, e) =>
            {
                saveButton.BackColor = Color.LightGreen; 
            };

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

            themeButton.Click += ChangeTheme_Click;  
            return themeButton;
        }

        private TableLayoutPanel CreateProfileSettingLayout()
        {
            TableLayoutPanel profileSettingLayout = new TableLayoutPanel
            {
                RowCount = 2,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

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
            };

            Label UserNameLabel = new Label
            {
                Text = username,
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            userNamePanel.Controls.Add(UserNameLabel);
            return userNamePanel;
        }




        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel navTableLayoutPanel;
        private TableLayoutPanel navTableLayout;
        private TableLayoutPanel MediaListTableLayout;
        private TableLayoutPanel pagesTableLayout;


        private Label navNameLabel;
        private Label navLabel_base;

        private Button navButton;
        private Button navButton_media;
        private Button navButton_comics;
        private Button navButton_book;
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
        private Panel ProfilePanel;
        private Panel ProfileSettingsPanel;
        private Panel mainMediaList;

        private TextBox searchTextBox;

        private TableLayoutPanel mediaBlocksTableLayoutPanel;


    }
}

