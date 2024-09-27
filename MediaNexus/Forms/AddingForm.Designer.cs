using MediaNexus_Backend;
using Microsoft.Win32.SafeHandles;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Policy;
using System.Threading;
using System.Windows.Forms;

namespace MediaNexus.Forms
{
    partial class AddingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public class DateTimePanelResult
        {
            public Panel Panel { get; set; }
            public DateTimePicker DatePicker { get; set; }
        }
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
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Text = "AddingForm";
        }

        private void createAddMediaPanel()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;

            TableLayoutPanel mainLayout = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                AutoSize = true
            };
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 450));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));

            TableLayoutPanel firstRowLayout = new TableLayoutPanel
            {
                RowCount = 1,
                ColumnCount = 2,
                Dock = DockStyle.Fill
            };
            firstRowLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            firstRowLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            TableLayoutPanel imageLayout = new TableLayoutPanel
            {
                BackColor = Color.White,
                RowCount = 2,
                ColumnCount = 1,
                Dock = DockStyle.Top,
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 0)
            };
            imageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 240));
            imageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));

            PictureBox mediaPictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 5, 0, 0)
            };

            imageUrlTextBox = addTextBox("Enter Image URL");
            imageUrlTextBox.TextChanged += (s, e) =>
            {
                string url = imageUrlTextBox.Text.Trim();

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
            imageLayout.Controls.Add(imageUrlTextBox, 0, 1);

            firstRowLayout.Controls.Add(imageLayout, 0, 0);

            TableLayoutPanel mediaInfoLayout = new TableLayoutPanel
            {
                RowCount = 13, 
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            originalNameTextBox = addTextBox("Original Name", needMargin: true);
            englishNameTextBox = addTextBox("English Name", needMargin: true);
            mediaTypeComboBox = AddComboBox("Select Media Type", typeof(MediaTypeEnum));

            Label releaseDateLabel = createLabel("Release Date:");
            DateTimePanelResult releaseDateResult = createDateTimePanel(format: "MM/dd/yyyy");
            Panel releaseDatePanel = releaseDateResult.Panel;
            releaseDatePicker = releaseDateResult.DatePicker;

            Label nextEpisodeLabel = createLabel("Next Episode Date:");
            DateTimePanelResult nextEpisodeResult = createDateTimePanel(format: "MM/dd/yyyy HH:mm", DateTime.Now);
            Panel addNextEpisodeDatePanel = nextEpisodeResult.Panel;
            nextEpisodeDatePicker = nextEpisodeResult.DatePicker;

            ratingComboBox = AddComboBox("Select Rating", typeof(RatingEnum));
            statusComboBox = AddComboBox("Select Status", typeof(StatusEnum));
            studioTextBox = addTextBox("Studi0", needMargin:true);
            episodeDurationTextBox = addTextBox("Episode Duration (HH:MM:SS)", needMargin: true);
            totalEpisodesTextBox = addTextBox("Total Episodes", needMargin: true);
            releasedEpisodesTextBox = addTextBox("Released Episodes", needMargin: true);
            timeUntilNextEpisodeTextBox = addTextBox("Time Until Next Episode (HH:MM:SS)", needMargin: true);

            mediaInfoLayout.Controls.Add(originalNameTextBox);
            mediaInfoLayout.Controls.Add(englishNameTextBox);
            mediaInfoLayout.Controls.Add(mediaTypeComboBox);
            mediaInfoLayout.Controls.Add(releaseDateLabel); 
            mediaInfoLayout.Controls.Add(releaseDatePanel); 
            mediaInfoLayout.Controls.Add(ratingComboBox);
            mediaInfoLayout.Controls.Add(statusComboBox);
            mediaInfoLayout.Controls.Add(studioTextBox);
            mediaInfoLayout.Controls.Add(episodeDurationTextBox);
            mediaInfoLayout.Controls.Add(totalEpisodesTextBox);
            mediaInfoLayout.Controls.Add(releasedEpisodesTextBox);
            mediaInfoLayout.Controls.Add(nextEpisodeLabel);
            mediaInfoLayout.Controls.Add(addNextEpisodeDatePanel);
            mediaInfoLayout.Controls.Add(timeUntilNextEpisodeTextBox);

            Label genresLabel = createLabel("Genres:");
            genresPanel = createGenresPanel();
            mediaInfoLayout.Controls.Add(genresLabel);
            mediaInfoLayout.Controls.Add(genresPanel);

            firstRowLayout.Controls.Add(mediaInfoLayout, 1, 0);

            descriptionTextBox = addTextBox("Enter media description", needMargin: true, multiLine:true, height: 100);

            Button addButton = new Button
            {
                Text = "Add Media",
                Dock = DockStyle.Bottom,
                Height = 30
            };
            addButton.Click += AddMediaButton_Click;

            mainLayout.Controls.Add(firstRowLayout, 0, 0);
            mainLayout.Controls.Add(descriptionTextBox, 0, 1);
            mainLayout.Controls.Add(addButton, 0, 2);

            this.Controls.Add(mainLayout);
        }


        private TextBox addTextBox(string palceHolder, bool needMargin = false, bool multiLine = false, int height = 20)
        {
            TextBox textBox = new TextBox
            {
                Dock = DockStyle.Top,
                Height = height,
                Multiline = multiLine,
                Margin = needMargin ? new Padding(5) : new Padding(0),
            };
            AddPlaceholder(textBox, palceHolder);

            return textBox;
        }
        private ComboBox AddComboBox(string palceHolder, Type enumType)
        {
            ComboBox comboBox = new ComboBox { Dock = DockStyle.Top, };
            AddPlaceholder(comboBox, palceHolder);
            comboBox.Items.AddRange(Enum.GetNames(enumType));
            return comboBox;
        }
        private DateTimePanelResult createDateTimePanel(string format, DateTime? dateTime = null)
        {
            Panel panel = new Panel
            {
                Height = 20,
                BackColor = Color.Transparent,
                Margin = new Padding(0)
            };

            DateTimePicker datePicker = new DateTimePicker
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = format,
                ShowUpDown = false,
                Visible = false,
            };
            if (dateTime != null) datePicker.MinDate = dateTime.Value;

            Button addDatePickerButton = new Button
            {
                Text = "Add Date",
                ForeColor = Color.White,
                BackColor = Color.Black,
            };

            addDatePickerButton.Click += (s, e) =>
            {
                addDatePickerButton.Visible = false;
                datePicker.Visible = true;
            };

            panel.Controls.Add(addDatePickerButton);
            panel.Controls.Add(datePicker);

            return new DateTimePanelResult
            {
                Panel = panel,
                DatePicker = datePicker
            };
        }
        private Label createLabel(string labelText)
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

                    MediaNexus_Backend.Genres[] genres = MNBackend.GetGenres();
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
        private void AddPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.LightGray;
            textBox.BackColor = Color.Black;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.White;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.LightGray;
                }
            };
        }
        private void AddPlaceholder(ComboBox comboBox, string placeholderText)
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

        TextBox imageUrlTextBox;
        TextBox originalNameTextBox;
        TextBox englishNameTextBox;
        TextBox studioTextBox;
        TextBox episodeDurationTextBox;
        TextBox totalEpisodesTextBox;
        TextBox releasedEpisodesTextBox;
        TextBox timeUntilNextEpisodeTextBox;
        TextBox descriptionTextBox;

        ComboBox mediaTypeComboBox;
        ComboBox ratingComboBox;
        ComboBox statusComboBox;

        FlowLayoutPanel genresPanel;

        DateTimePicker releaseDatePicker;
        DateTimePicker nextEpisodeDatePicker;
        #endregion
    }
}