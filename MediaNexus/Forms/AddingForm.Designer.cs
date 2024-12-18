﻿using System.Drawing;
using System.Windows.Forms;
using System;
using System.Net;
using System.IO;
using MediaNexus_Backend;

namespace MediaNexus
{
    partial class AddingForm
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "AddingForm";
        }

        /// <summary>
        /// Sets the background color, text color, and client window size.
        /// </summary>
        /// <param name="size">The desired size for the window.</param>
        private void WindowProperties(Size size)
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;
            this.ClientSize = size;
        }

        #region Helpers component
        /// <summary>
        /// Creates and configures the main TableLayoutPanel with three rows and one column.
        /// </summary>
        /// <returns>A TableLayoutPanel configured as the main layout.</returns>
        private TableLayoutPanel CreateMainTableLayoutPanel()
        {
            TableLayoutPanel mainLayout = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                AutoSize = true
            };
            return mainLayout;
        }

        /// <summary>
        /// Creates and configures a TableLayoutPanel for the first row, with two columns.
        /// </summary>
        /// <returns>A TableLayoutPanel configured for the first row layout.</returns>
        private TableLayoutPanel CreateFirstRowTableLayoutPanel()
        {
            TableLayoutPanel firstRowLayout = new TableLayoutPanel
            {
                RowCount = 1,
                ColumnCount = 2,
                Dock = DockStyle.Fill
            };
            firstRowLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            firstRowLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            return firstRowLayout;
        }

        /// <summary>
        /// Creates a TableLayoutPanel containing a label, a DatePicker component, and optionally, an add/remove button.
        /// </summary>
        /// <param name="labelText">The label text for the DatePicker.</param>
        /// <param name="datePicker">The DatePicker component to be used.</param>
        /// <param name="hasTime">Indicates whether to include time selection.</param>
        /// <param name="needAddButton">Determines if the add button is necessary.</param>
        /// <returns>A TableLayoutPanel containing the configured DatePicker.</returns>
        static public TableLayoutPanel datePicker(string labelText, DatePickerPanel datePicker, bool hasTime = false, bool needAddButton = true)
        {
            TableLayoutPanel panel = new TableLayoutPanel
            {
                RowCount = 1,
                ColumnCount = 3,
                Dock = DockStyle.Top,
                AutoSize = true
            };

            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            int datePickerWidth = hasTime ? DateTimePickerPanel.GetStandrtWidth() : DatePickerPanel.GetStandrtWidth();
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, datePickerWidth));

            Label label = new Label
            {
                Text = labelText,
                Dock = DockStyle.Left,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
            };
            panel.Controls.Add(label, 0, 0);

            if (needAddButton)
            {
                Button addButton = new Button
                {
                    Text = "+",
                    Dock = DockStyle.Left,
                    Width = 30
                };
                panel.Controls.Add(addButton, 1, 0);

                addButton.Click += (sender, e) =>
                {
                    panel.Controls.Remove(addButton);

                    Button removeButton = new Button
                    {
                        Text = "-",
                        Dock = DockStyle.Left,
                        Width = 30
                    };

                    removeButton.Click += (s, ev) =>
                    {
                        panel.Controls.Remove(datePicker);
                        panel.Controls.Remove(removeButton);

                        panel.Controls.Add(addButton, 1, 0);
                    };

                    panel.Controls.Add(datePicker, 1, 0);
                    panel.Controls.Add(removeButton, 2, 0);
                };
            }
            else
                panel.Controls.Add(datePicker, 1, 0);

            return panel;
        }

        /// <summary>
        /// Creates a TableLayoutPanel with a PictureBox and a TextBox for a media image URL.
        /// </summary>
        /// <param name="UrlTextBox">A TextBox for the image URL input.</param>
        /// <param name="size">Optional fixed size for the PictureBox.</param>
        /// <returns>A TableLayoutPanel with a PictureBox for media images and a URL TextBox.</returns>
        static public TableLayoutPanel addMeddiaImageBox(TextBox UrlTextBox, Size? size = null)
        {
            bool hasFixedSize = (size == null) ? false : true;
            TableLayoutPanel imageLayout = new TableLayoutPanel
            {
                RowCount = 2,
                ColumnCount = 1,
                Dock = DockStyle.Top,
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 0)
            };

            imageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, hasFixedSize ? size.Value.Height : 240));
            imageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));

            PictureBox mediaPictureBox = new PictureBox
            {
                Dock = (size == null) ? DockStyle.Fill : DockStyle.None,
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(hasFixedSize ? 5 : 0,
                                     hasFixedSize ? 0 : 5,
                                     0, 0)
            };

            if (hasFixedSize)
                mediaPictureBox.Size = (Size)size;

            UrlTextBox.TextChanged += (s, e) =>
            {
                string url = UrlTextBox.Text.Trim();

                if (!string.IsNullOrEmpty(url))
                {
                    try
                    {
                        using (var webClient = new WebClient())
                        {
                            byte[] imageData = webClient.DownloadData(url);
                            using (var stream = new MemoryStream(imageData))
                            {
                                mediaPictureBox.Image = Image.FromStream(stream);
                            }
                        }
                    }
                    catch
                    {
                        mediaPictureBox.Image = null;
                    }
                }
                else
                {
                    mediaPictureBox.Image = null;
                }
            };

            imageLayout.Controls.Add(mediaPictureBox, 0, 0);
            imageLayout.Controls.Add(UrlTextBox, 0, 1);

            return imageLayout;
        }

        /// <summary>
        /// Creates a FlowLayoutPanel for selecting genres with an add genre button and up to nine ComboBox entries.
        /// </summary>
        /// <returns>A FlowLayoutPanel with an add genre button and ComboBox items for genres.</returns>
        private FlowLayoutPanel createGenresPanel()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight
            };

            Button addGenreButton = new Button
            {
                Text = "+",
                Dock = DockStyle.Top,
                Width = 30
            };
            int genreCount = 0;

            addGenreButton.Click += (s, e) =>
            {
                if (genreCount < 9)
                {
                    ComboBox genreComboBox = new ComboBox { Width = 100 };

                    Genres[] genres = MediaService.GetGenres();
                    genreComboBox.Items.Insert(0, "Select Genre");
                    genreComboBox.Items.AddRange(genres);
                    genreComboBox.SelectedIndex = 0;
                    genreComboBox.ForeColor = Color.Gray;
                    genresPanel.Controls.Add(genreComboBox);
                    genreCount++;
                }
            };

            panel.Controls.Add(addGenreButton);
            return panel;
        }

        /// <summary>
        /// Creates a Button with specified text and click event.
        /// </summary>
        /// <param name="buttonText">The text to display on the button.</param>
        /// <param name="click">The click event handler for the button.</param>
        /// <returns>A Button with the specified text and click event.</returns>
        private Button CreateAddButton(string buttonText, EventHandler click)
        {
            Button addButton = new Button
            {
                Text = buttonText,
                Dock = DockStyle.Bottom,
                Height = 30
            };
            addButton.Click += click;
            return addButton;
        }

        /// <summary>
        /// Adds a ComboBox configured with a placeholder and populated with enum values.
        /// </summary>
        /// <param name="palceHolder">Placeholder text to display in the ComboBox.</param>
        /// <param name="enumType">The enum type to populate the ComboBox items.</param>
        /// <returns>A ComboBox populated with enum values.</returns>
        private ComboBox AddComboBox(string palceHolder, Type enumType)
        {
            ComboBox comboBox = new ComboBox { Dock = DockStyle.Top, };
            AddPlaceholder(comboBox, palceHolder);
            comboBox.Items.AddRange(Enum.GetNames(enumType));
            return comboBox;
        }

        /// <summary>
        /// Creates a Label with specified text, white font color, and left alignment.
        /// </summary>
        /// <param name="labelText">The text for the label.</param>
        /// <returns>A Label with the specified text and styling.</returns>
        static public Label createLabel(string labelText)
        {
            Label label = new Label
            {
                Height = 15,
                Text = labelText,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.BottomLeft,
            };

            return label;
        }
        #endregion

        #region PlaceHolder
        /// <summary>
        /// Adds a placeholder item to a ComboBox with a specified text and color settings,
        /// which updates the ComboBox's text color based on selection.
        /// </summary>
        /// <param name="comboBox">The ComboBox to modify.</param>
        /// <param name="placeholderText">The placeholder text to display initially.</param>
        static public void AddPlaceholder(ComboBox comboBox, string placeholderText)
        {
            comboBox.Items.Add(placeholderText);
            comboBox.SelectedIndex = 0;
            comboBox.BackColor = Color.Black;
            comboBox.ForeColor = Color.LightGray;


            comboBox.SelectedIndexChanged += (s, e) =>
            {
                if (comboBox.SelectedIndex == 0)
                {
                    comboBox.ForeColor = Color.LightGray;
                }
                else
                {
                    comboBox.ForeColor = Color.White;
                }
            };
        }

        #endregion

        #region Info Panels
        /// <summary>
        /// Creates a TableLayoutPanel containing fields for media information including
        /// original name, English name, status, PG rating, media type, and date fields.
        /// Also includes a genres selection panel.
        /// </summary>
        /// <returns>A TableLayoutPanel populated with media information input fields.</returns>
        private TableLayoutPanel addMediaInfoTable()
        {
            TableLayoutPanel mediaInfoLayout = new TableLayoutPanel
            {
                RowCount = 15,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            originalName = Components.addTextBox("Original name", needMargin: true);
            englishName = Components.addTextBox("English name", needMargin: true);
            status = AddComboBox("Status", typeof(MediaStatus));
            pg_rating = AddComboBox("PG-Rating", typeof(PG_Rating));
            mediaType = AddComboBox("Media type", typeof(MediaType));
            studio = Components.addTextBox("Studio", needMargin: true);
            totalEpisode = Components.addTextBox("Total episode", needMargin: true);
            realesedEpisode = Components.addTextBox("Realesed episode", needMargin: true);
            episodeDuration = Components.addTextBox("Episode duration (in minute)", needMargin: true);
            timeUntilNewEpisodeInSeconds = Components.addTextBox("Time until new episode (hh:mm:ss)", needMargin: true);
            nextEpisodeDate = new DateTimePickerPanel();
            startDatePicker = new DatePickerPanel();
            endDatePicker = new DatePickerPanel();

            //MediaType
            mediaInfoLayout.Controls.Add(originalName);
            mediaInfoLayout.Controls.Add(englishName);
            mediaInfoLayout.Controls.Add(status);
            mediaInfoLayout.Controls.Add(pg_rating);
            mediaInfoLayout.Controls.Add(mediaType);
            mediaInfoLayout.Controls.Add(studio);
            mediaInfoLayout.Controls.Add(totalEpisode);
            mediaInfoLayout.Controls.Add(realesedEpisode);
            mediaInfoLayout.Controls.Add(episodeDuration);
            mediaInfoLayout.Controls.Add(timeUntilNewEpisodeInSeconds);
            mediaInfoLayout.Controls.Add(datePicker("Next episode date:", nextEpisodeDate, hasTime: true));
            mediaInfoLayout.Controls.Add(datePicker("Start date:", startDatePicker));
            mediaInfoLayout.Controls.Add(datePicker("Realese date:", endDatePicker));
            genresPanel = createGenresPanel();
            mediaInfoLayout.Controls.Add(createLabel("Genres:"));
            mediaInfoLayout.Controls.Add(genresPanel);


            return mediaInfoLayout;
        }

        /// <summary>
        /// Creates a TableLayoutPanel containing fields for book information including
        /// original name, English name, status, PG rating, author, pages, ISBN, and publisher date.
        /// Also includes a genres selection panel.
        /// </summary>
        /// <returns>A TableLayoutPanel populated with book information input fields.</returns>
        private TableLayoutPanel addBookInfoTable()
        {
            TableLayoutPanel bookInfoLayout = new TableLayoutPanel
            {
                RowCount = 8,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            originalName = Components.addTextBox("Original name", needMargin: true);
            englishName = Components.addTextBox("English name", needMargin: true);
            status = AddComboBox("Status", typeof(MediaStatus));
            pg_rating = AddComboBox("PG-Rating", typeof(PG_Rating));
            AuthorBox = Components.addTextBox("Author", needMargin: true);
            PagesBox = Components.addTextBox("Pages", needMargin: true); 
            ISBN_Box = Components.addTextBox("ISBN", needMargin: true);
            endDatePicker = new DatePickerPanel();

            //MediaType
            bookInfoLayout.Controls.Add(originalName);
            bookInfoLayout.Controls.Add(englishName);
            bookInfoLayout.Controls.Add(status);
            bookInfoLayout.Controls.Add(pg_rating);
            bookInfoLayout.Controls.Add(AuthorBox);
            bookInfoLayout.Controls.Add(PagesBox);
            bookInfoLayout.Controls.Add(ISBN_Box);
            bookInfoLayout.Controls.Add(datePicker("Publisher date:", endDatePicker));
            genresPanel = createGenresPanel();
            bookInfoLayout.Controls.Add(createLabel("Genres:"));
            bookInfoLayout.Controls.Add(genresPanel);


            return bookInfoLayout;
        }
        #endregion

        /// <summary>
        /// Initializes the panel for adding media, setting window properties and main layout,
        /// and adding fields for media information, an image URL, a description, and an "Add media" button.
        /// </summary>
        private void createAddMediaPanel()
        {
            WindowProperties(new Size(750, 630));

            TableLayoutPanel mainLayout = CreateMainTableLayoutPanel();

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 480));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));

            TableLayoutPanel firstRowLayout = CreateFirstRowTableLayoutPanel();

            firstRowLayout.Controls.Add(addMeddiaImageBox(imageUrlTextBox = Components.addTextBox("Enter Image URL", needMargin: false, fixedWidth: -1)), 0, 0);
            firstRowLayout.Controls.Add(addMediaInfoTable(), 1, 0);

            descriptionTextBox = Components.addTextBox("Enter media description", needMargin: true, multiLine: true);

            descriptionTextBox.Height = 100;
            Button addButton = CreateAddButton("Add media", AddMediaButton_Click);

            mainLayout.Controls.Add(firstRowLayout, 0, 0);
            mainLayout.Controls.Add(descriptionTextBox, 0, 1);
            mainLayout.Controls.Add(addButton, 0, 2);

            mainLayout.Controls.Add(firstRowLayout, 0, 0);

            this.Controls.Add(mainLayout);
        }

        /// <summary>
        /// Initializes the panel for adding books, setting window properties and main layout,
        /// and adding fields for book information, an image URL, a description, and an "Add book" button.
        /// </summary>
        private void createAddBookPanel()
        {
            WindowProperties(new Size(750, 480));

            TableLayoutPanel mainLayout = CreateMainTableLayoutPanel();

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 330));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));

            TableLayoutPanel firstRowLayout = CreateFirstRowTableLayoutPanel();

            firstRowLayout.Controls.Add(addMeddiaImageBox(imageUrlTextBox = Components.addTextBox("Enter Image URL", needMargin: false, fixedWidth: -1)), 0, 0);
            firstRowLayout.Controls.Add(addBookInfoTable(), 1, 0);

            descriptionTextBox = Components.addTextBox("Enter book description", needMargin: true, multiLine: true);
            descriptionTextBox.Height = 100;

            Button addButton = CreateAddButton("Add book", AddBookButton_Click);

            mainLayout.Controls.Add(firstRowLayout, 0, 0);
            mainLayout.Controls.Add(descriptionTextBox, 0, 1);
            mainLayout.Controls.Add(addButton, 0, 2);

            mainLayout.Controls.Add(firstRowLayout, 0, 0);

            this.Controls.Add(mainLayout);
        }

        #region Media Elements
        //For media Textbox:
        TextBox totalEpisode;
        TextBox realesedEpisode;
        TextBox episodeDuration;
        TextBox studio;
        TextBox timeUntilNewEpisodeInSeconds;
        
        //For media combox
        ComboBox mediaType;

        //For media DatePicker:
        DateTimePickerPanel nextEpisodeDate;
        DatePickerPanel startDatePicker;
        #endregion

        #region Book elements
        TextBox AuthorBox;
        TextBox PagesBox;
        TextBox ISBN_Box;
        #endregion

        #region All media Elements
        //All medias ComboBox:
        ComboBox status;
        ComboBox pg_rating;

        //All medias Textbox:
        TextBox originalName;
        TextBox englishName;
        TextBox descriptionTextBox;
        TextBox imageUrlTextBox;

        //All media DatePicker:
        DatePickerPanel endDatePicker; // PublicationDate 
        #endregion


        FlowLayoutPanel genresPanel;

        #endregion
    }
}