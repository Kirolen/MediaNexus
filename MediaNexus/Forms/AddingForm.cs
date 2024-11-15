using MediaNexus_Backend;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaNexus
{
    /// <summary>
    /// Represents a form used for adding media items such as books or other types of media,
    /// with fields and controls specific to the selected media type and user ID.
    /// </summary>
    public partial class AddingForm : Form
    {
        /// <summary>
        /// Specifies the type of media being added (e.g., Book, Media, Game, Comics).
        /// </summary>
        readonly MainMediaType mainMediaType;

        /// <summary>
        /// Stores the unique identifier of the user interacting with the form,
        /// ensuring that added media is associated with the correct user.
        /// </summary>
        readonly int userId;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddingForm"/> class with specified media type,
        /// user ID, and layout based on the selected content type (e.g., "media" or "book").
        /// </summary>
        /// <param name="type">A string that defines the type of content ("media" or "book") to configure the form layout.</param>
        /// <param name="mediaType">The main type of media, used to set media-specific properties.</param>
        /// <param name="id">The ID of the user adding the media; defaults to 0 if not specified.</param>
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

        /// <summary>
        /// Handles the "Add Media" button click event by calling <see cref="AddMedia"/> to create and save a new media entry.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event data.</param>
        private void AddMediaButton_Click(object sender, EventArgs e)
        {
            AddMedia();
        }

        /// <summary>
        /// Handles the "Add Book" button click event by calling <see cref="AddBook"/> to create and save a new book entry.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event data.</param>
        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AddBook();
        }

        /// <summary>
        /// Creates and populates a <see cref="Media"/> object with data entered in the form,
        /// validates required fields, and adds the media to the database through <see cref="MediaService.AddMediaToDatabase"/>.
        /// </summary>
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

        /// <summary>
        /// Creates and populates a <see cref="Book"/> object with data entered in the form,
        /// validates required fields, and adds the book to the database through <see cref="MediaService.AddBookToDatabase"/>.
        /// </summary>
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

        /// <summary>
        /// Retrieves the selected genres from the genres panel by iterating through its controls 
        /// and checking for <see cref="ComboBox"/> controls with valid genre selections.
        /// </summary>
        /// <returns>An array of <see cref="Genres"/> that were selected by the user.</returns>
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

        /// <summary>
        /// Converts a time string in the format "hh:mm:ss" to the total number of seconds.
        /// If the input is null, empty, or incorrectly formatted, returns 0.
        /// </summary>
        /// <param name="time">The time string in "hh:mm:ss" format.</param>
        /// <returns>An integer representing the total seconds, or 0 if the input is invalid.</returns>
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
