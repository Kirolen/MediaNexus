using MediaNexus_Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MediaNexus.Forms
{
    public partial class AddingForm : Form
    {
        public AddingForm(string type)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            if (type == "media") createAddMediaPanel();
        }

        private void AddMediaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Media newMedia = new Media
                {
                    OriginalName = string.IsNullOrWhiteSpace(originalNameTextBox.Text) ? null : originalNameTextBox.Text,
                    EnglishName = string.IsNullOrWhiteSpace(englishNameTextBox.Text) ? null : englishNameTextBox.Text,
                    ImageTitle = string.IsNullOrWhiteSpace(imageUrlTextBox.Text) ? null : imageUrlTextBox.Text,
                    MediaType = (mediaTypeComboBox.SelectedIndex > 0) ? (MediaTypeEnum)(mediaTypeComboBox.SelectedIndex) : (MediaTypeEnum)(0),
                    ReleaseDate = releaseDatePicker.Value,
                    Studio = string.IsNullOrWhiteSpace(studioTextBox.Text) ? null : studioTextBox.Text,
                    Description = string.IsNullOrWhiteSpace(descriptionTextBox.Text) ? null : descriptionTextBox.Text,
                    Rating = (ratingComboBox.SelectedIndex > 0) ? (RatingEnum)(ratingComboBox.SelectedIndex) : (RatingEnum)(0),
                    Status = (statusComboBox.SelectedIndex > 0) ? (StatusEnum)(statusComboBox.SelectedIndex) : (StatusEnum)(0),
                    EpisodeDuration = TimeSpan.TryParse(episodeDurationTextBox.Text, out TimeSpan episodeDuration) ? episodeDuration : TimeSpan.Zero,
                    TotalEpisodes = int.TryParse(totalEpisodesTextBox.Text, out int totalEpisodes) ? totalEpisodes : 0,
                    ReleasedEpisodes = int.TryParse(releasedEpisodesTextBox.Text, out int releasedEpisodes) ? releasedEpisodes : 0,
                    NextEpisode = nextEpisodeDatePicker.Value > DateTime.Now ? nextEpisodeDatePicker.Value : (DateTime?)null,
                    TimeUntilNextEpisode = ConvertToSeconds(timeUntilNextEpisodeTextBox.Text)
                };

                List<Genres> selectedGenres = new List<Genres>();
                foreach (Control control in genresPanel.Controls)
                {
                    if (control is ComboBox genreComboBox && genreComboBox.SelectedIndex > 0) 
                    {
                        Genres selectedGenre = genreComboBox.SelectedItem as Genres;
                        if (selectedGenre != null)
                        {
                            selectedGenres.Add(selectedGenre);
                        }
                    }
                }

                Genres[] genresArray = selectedGenres.ToArray();


                MNBackend.addMedia(genresArray, newMedia);
                MessageBox.Show("Media successfully added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding media: {ex.Message}");
            }
        }
        public int ConvertToSeconds(string time)
        {
            // Спочатку розділяємо рядок по символу ":"
            string[] timeParts = time.Split(':');

            if (timeParts.Length != 3)
            {
                throw new FormatException("Неправильний формат часу. Очікується формат HH:mm:ss.");
            }

            // Парсимо години, хвилини і секунди
            int hours = int.Parse(timeParts[0]);
            int minutes = int.Parse(timeParts[1]);
            int seconds = int.Parse(timeParts[2]);

            // Створюємо об'єкт TimeSpan
            TimeSpan timeSpan = new TimeSpan(hours, minutes, seconds);

            // Повертаємо загальну кількість секунд
            return (int)timeSpan.TotalSeconds;
        }
    }
}
