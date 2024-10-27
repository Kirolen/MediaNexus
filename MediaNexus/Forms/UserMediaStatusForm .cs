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

namespace MediaNexus.Forms
{
    public partial class UserMediaStatusForm : Form
    {
        public UserMediaStatus newInUserList;
        MainMedia Media;
        public UserMediaStatusForm(UserMediaStatus inUserList, MainMedia media)
        {
            InitializeComponent();
            newInUserList = inUserList;
            Media = media;
        }

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
