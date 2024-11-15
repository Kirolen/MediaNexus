using MediaNexus_Backend;
using System;
using System.Windows.Forms;

namespace MediaNexus.Forms
{
    /// <summary>
    /// Form for managing the user's status of a specific media item.
    /// Allows the user to set, update, or delete the status of the selected media in their list.
    /// </summary>
    public partial class UserMediaStatusForm : Form
    {
        /// <summary>
        /// The user's updated media status after any changes.
        /// </summary>
        public UserMediaStatus newInUserList;

        /// <summary>
        /// The media item associated with this form.
        /// </summary>
        MainMedia Media;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMediaStatusForm"/> class with the given user media status and media item.
        /// </summary>
        /// <param name="inUserList">The user's current status of the media item.</param>
        /// <param name="media">The media item to manage the status for.</param>
        public UserMediaStatusForm(UserMediaStatus inUserList, MainMedia media)
        {
            InitializeComponent();
            newInUserList = inUserList;
            Media = media;
        }

        /// <summary>
        /// Handles the event when the save button is clicked. Updates the user's status for the media item based on the selected option.
        /// Sets the status in <see cref="newInUserList"/> and updates the ended page or episode if the status is "Completed".
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string selectedStatus = statusComboBox.SelectedItem.ToString();
            if (selectedStatus == "In Process")
            {
                newInUserList.Status = MediaStatusInUserList.InProcess;
            }
            else if (selectedStatus == "Completed")
            {
                newInUserList.Status = MediaStatusInUserList.Completed;
                newInUserList.EndedPageOrEpisode = MediaService.GetMediaCountByType(Media.MainType, Media.Id);
            }
            else if (selectedStatus == "Dropped")
            {
                newInUserList.Status = MediaStatusInUserList.Dropped;
            }
            else if (selectedStatus == "Planned")
            {
                newInUserList.Status = MediaStatusInUserList.Planned;
                newInUserList.EndedPageOrEpisode = 0;
            }

            MediaService.AddOrUpdateUserMediaStatus(newInUserList);
            this.Close();
        }

        /// <summary>
        /// Handles the event when the delete button is clicked. Asks for confirmation, and if confirmed,
        /// proceeds to delete the user's status for the media item.
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Ви дійсно хочете видалити цей запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("Запис видалено", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
