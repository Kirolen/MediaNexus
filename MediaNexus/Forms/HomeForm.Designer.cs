using System.Data.SqlTypes;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace MediaNexus
{
    partial class HomeForm
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
            this.navTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.navMenuPanel.AutoSize = true;
            this.navMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.navMenuPanel.Controls.Add(this.navTableLayout);
            this.navMenuPanel.Location = new System.Drawing.Point(239, 0);
            this.navMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.navMenuPanel.Name = "navMenuPanel";
            this.navMenuPanel.Size = new System.Drawing.Size(179, 160);
            this.navMenuPanel.TabIndex = 0;
            this.navMenuPanel.Visible = false;
            // 
            // navTableLayout
            // 
            this.navTableLayout.AutoSize = true;
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
            this.navButton_media.Size = new System.Drawing.Size(179, 43);
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
            this.navButton_comics.Size = new System.Drawing.Size(179, 43);
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
            this.navButton_book.Size = new System.Drawing.Size(179, 43);
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

        #region nav Menu Panel

        private void createNavMenuPanel(string currentPage)
        {
            this.navButton.Text = currentPage;
            this.mainPanel.Controls.Add(this.navMenuPanel);
        }

        #endregion

        #region mediaPanel
        private void createMainMediaPanel()
        {
            createNavMenuPanel("⌂ Home");

            int widthNewMedia = (int)(mainPanel.Width * 0.75);
            int heightNewMedia = (int)(mainPanel.Height * 0.85);

            int xPosition = (mainPanel.Width - widthNewMedia) / 2;
            int yPosition = (mainPanel.Height - heightNewMedia) / 2;

            MediaPanel = new Panel
            {
                Size = new Size(widthNewMedia, heightNewMedia),
                Location = new Point(xPosition, yPosition),
            };

            createGoToNewMediaButton();
            CreateRecentMediaPanel();
            createMediaHistoryAndNavPanel();
            mainPanel.Controls.Add(MediaPanel);
        }

        private void createGoToNewMediaButton()
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

            MediaPanel.Controls.Add(goToNewMediaButton);
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

            mediaBlocksTableLayoutPanel = AddRecentMediaBlocks(5, 1);

            mediaBlocksPanel.Controls.Add(mediaBlocksTableLayoutPanel);
            MediaPanel.Controls.Add(mediaBlocksPanel);
        }

        private TableLayoutPanel AddRecentMediaBlocks(int columnCount, int rowCount)
        {
            TableLayoutPanel mediaBlocksTableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = columnCount,
                RowCount = rowCount,
                Dock = DockStyle.Fill,
                Margin = new System.Windows.Forms.Padding(0),
            };

            for (int i = 0; i < rowCount; i++)
            {
                mediaBlocksTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / rowCount));
                for (int j = 0; j < columnCount; j++)
                {
                    mediaBlocksTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columnCount));

                    Panel mediaBlock = CreateRecentMediaBlock(j.ToString());
                    if (j == 0) mediaBlock.Margin = new Padding(0, 5, 5, 5);
                    else if (j == columnCount - 1) mediaBlock.Margin = new Padding(5, 5, 0, 5);

                    mediaBlocksTableLayoutPanel.Controls.Add(mediaBlock, j, i);
                }
            }
            

            return mediaBlocksTableLayoutPanel;
        }

        private Panel CreateRecentMediaBlock(string name)
        {
            Panel mediaBlock = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Name = $"MediaBlock_{name}",
                Margin = new System.Windows.Forms.Padding(5)
                        
            };

            TableLayoutPanel mediaBlockTableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 3,
                ColumnCount = 1,
                Margin = new System.Windows.Forms.Padding(0),
                Cursor = Cursors.Hand
            };

            mediaBlockTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            mediaBlockTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            mediaBlockTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));

            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = "https://ih1.redbubble.net/image.1066412296.0216/fposter,small,wall_texture,product,750x1000.u4.jpg",
            };

            mediaBlockTableLayoutPanel.Controls.Add(pictureBox, 0, 0);

            Label titleLabel = new Label
            {
                Dock = DockStyle.Fill,
                Text = "Media Title",
                TextAlign = ContentAlignment.MiddleLeft,
                MaximumSize = new Size(mediaBlock.Width, 0),
            };
            titleLabel.MouseEnter += (s, e) => changeButtonForeColor(titleLabel, Color.Orange);
            titleLabel.MouseLeave += (s, e) => changeButtonForeColor(titleLabel, Color.Black);
            titleLabel.Click += new System.EventHandler(this.goToNewMedia_button_Click);

            Label studioLabel = new Label
            {
                Dock = DockStyle.Fill,
                Text = "Studio/Publisher",
                MaximumSize = new Size(mediaBlock.Width, 0),
                TextAlign = ContentAlignment.MiddleLeft,
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
            // Create the outer panel that will act as a button
            Panel buttonPanel = new Panel
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                BackColor = bgColor,
                Margin = new Padding(0),
                Cursor = Cursors.Hand,
            };


            // Create a TableLayoutPanel to hold the text and the ">" symbol
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel()
            {
                AutoSize = true,
                ColumnCount = 3,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            // Set column widths: text takes 90%, ">" symbol takes 10%
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

            // Create and add a Label for the ">" symbol
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

            // Add the TableLayoutPanel to the outer panel
            buttonPanel.Controls.Add(tableLayoutPanel);

            return buttonPanel;
        }

        #endregion

        #region media list
        
        private void createMediaListPanel(string typeMedia)
        {
            createNavMenuPanel(typeMedia);

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

            TableLayoutPanel MediaListTableLayout = new TableLayoutPanel
            {
                ColumnCount = 2,
                Dock = DockStyle.Fill,
            };

            MediaListTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80f));
            MediaListTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));

            MediaPanel.Controls.Add(MediaListTableLayout);

            Panel list = new Panel
            {
                BackColor = Color.AliceBlue,
                Dock = DockStyle.Fill
            };

            int minBlockWidth = 150;
            int minBlockHeight = 200;

            int countCols = widthMediaListPanel / minBlockWidth;
            int countRows = heightMediaListPanel / minBlockHeight;


            list.Controls.Add(AddRecentMediaBlocks(countCols, countRows));

            MediaListTableLayout.Controls.Add(list, 0, 0);

            mainPanel.Controls.Add(MediaPanel);
        }





        #endregion



        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel navTableLayoutPanel;
        private TableLayoutPanel navTableLayout;

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

        
        private TextBox searchTextBox;

        private TableLayoutPanel mediaBlocksTableLayoutPanel;


    }
}

