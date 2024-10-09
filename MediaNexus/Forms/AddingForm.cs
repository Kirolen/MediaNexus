using MediaNexus_Backend;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaNexus
{
    public partial class AddingForm : Form
    {
        readonly MainMediaType mainMediaType;
        readonly int userId;

        public AddingForm(string type, MainMediaType mediaType, int id = 0)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            userId = id;
            mainMediaType = mediaType;

            if (type == "media") createAddMediaPanel();
            else if (type == "book") createAddBookPanel();
        }

        private void AddMediaButton_Click(object sender, EventArgs e)
        {
            AddMedia();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AddBook();
        }

        private void AddMedia()
        {
            if (string.IsNullOrEmpty(originalName.Text) || string.IsNullOrEmpty(englishName.Text))
            {
                MessageBox.Show("Original and English names are required.");
                return;
            }

            Media newMedia = new Media
            {
                MainType = mainMediaType,
                OriginalName = originalName.Text,
                EnglishName = englishName.Text,
                ImageURL = imageUrlTextBox.Text,
                Status = (status.SelectedIndex > 0) ? (MediaStatus)(status.SelectedIndex) : (MediaStatus)(0),
                PG_Rating = (pg_rating.SelectedIndex > 0) ? (PG_Rating)(pg_rating.SelectedIndex) : (PG_Rating)(0),
                Description = descriptionTextBox.Text,
                IDUserWhoAdded = userId,
                TimeAdded = DateTime.Now,
                SecondMediaType = (mediaType.SelectedIndex > 0) ? (MediaType)(mediaType.SelectedIndex) : (MediaType)(0),
                Studio = studio.Text,
                TotalEpisodes = int.TryParse(totalEpisode.Text, out int totalEps) ? totalEps : 0,
                ReleasedEpisode = int.TryParse(realesedEpisode.Text, out int releasedEps) ? releasedEps : 0,
                EpisodeDuration = int.TryParse(episodeDuration.Text, out int duration) ? duration : 0,
                TimeUntilNewEpisodeInSeconds = ConvertToSeconds(timeUntilNewEpisodeInSeconds.Text),
                NextEpisodeDateTime = nextEpisodeDate?.GetSelectedDateTime(),
                StartDate = startDatePicker?.GetSelectedDate(),
                EndDate = endDatePicker?.GetSelectedDate(),
            };

            Genres[] genres = GetSelectedGenres();
            MediaService.AddMediaToDatabase(newMedia, genres);
            this.Close();
        }
        private void AddBook()
        {
            if (string.IsNullOrEmpty(originalName.Text) || string.IsNullOrEmpty(englishName.Text))
            {
                MessageBox.Show("Original and English names are required.");
                return;
            }

            Book newBook = new Book
            {
                MainType = mainMediaType,
                OriginalName = originalName.Text,
                EnglishName = englishName.Text,
                ImageURL = imageUrlTextBox.Text,
                Status = (status.SelectedIndex > 0) ? (MediaStatus)(status.SelectedIndex) : (MediaStatus)(0),
                PG_Rating = (pg_rating.SelectedIndex > 0) ? (PG_Rating)(pg_rating.SelectedIndex) : (PG_Rating)(0),
                Description = descriptionTextBox.Text,
                IDUserWhoAdded = userId,
                TimeAdded = DateTime.Now,
                Author = AuthorBox.Text,
                PublicationDate = endDatePicker?.GetSelectedDate(),
                Pages = int.TryParse(PagesBox.Text, out int duration) ? duration : 0,
                ISBN = ISBN_Box.Text,
            };

            Genres[] genres = GetSelectedGenres();
            MediaService.AddBookToDatabase(newBook, genres);
            this.Close();
        }

        private Genres[] GetSelectedGenres()
        {
            List<Genres> selectedGenres = new List<Genres>();

            foreach (Control control in genresPanel.Controls)
            {
                if (control is ComboBox genreComboBox)
                {
                    if (genreComboBox.SelectedIndex > 0)
                    {
                        selectedGenres.Add((Genres)genreComboBox.SelectedItem);
                    }
                }
            }

            return selectedGenres.ToArray();
        }

        public int ConvertToSeconds(string time)
        {
            if (string.IsNullOrEmpty(time)) return 0;

            string[] timeParts = time.Split(':');

            if (timeParts.Length != 3)
            {
                return 0;
            }

            int hours = int.Parse(timeParts[0]);
            int minutes = int.Parse(timeParts[1]);
            int seconds = int.Parse(timeParts[2]);
 
            TimeSpan timeSpan = new TimeSpan(hours, minutes, seconds);

            return (int)timeSpan.TotalSeconds;
        }
    }
}
