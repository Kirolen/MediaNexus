using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MediaNexus
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            // Subscribe to the Resize event using +=
            this.Resize += new EventHandler(HomeForm_Resize);
            // Optionally set the minimum size of the form
            this.MinimumSize = new Size(800, 600);
            createNewMediaPanel();
        }

        // Event handler for form resizing



        #region resizing
        private void HomeForm_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void ResizeControls()
        {
            // Оновлюємо розміри основної таблиці
            mainTableLayoutPanel.Size = this.ClientSize;
            navTableLayoutPanel.Width = this.ClientSize.Width;

            // Перезбираємо всі компоненти
            navMenuResize();
            newMediaPanelResize();
            gtnmButtonResize();
            mediaPanelResize();
        }

        private void navMenuResize()
        {
            // Налаштовуємо розміри та розташування панелі меню навігації
            navMenuPanel.Size = new Size(navButton.Width, 130);
            navMenuPanel.Location = new Point(navButton.Location.X, navButton.Location.Y);
        }

        private void newMediaPanelResize()
        {
            if (newMediaPanel != null)
            {
                int widthNewMedia = (int)(mainPanel.Width * 0.75);
                int heightNewMedia = (int)(mainPanel.Height * 0.85);

                int xPosition = (mainPanel.Width - widthNewMedia) / 2;
                int yPosition = (mainPanel.Height - heightNewMedia) / 2;

                newMediaPanel.Size = new Size(widthNewMedia, heightNewMedia);
                newMediaPanel.Location = new Point(xPosition, yPosition);

                // Оновлюємо компоненти всередині newMediaPanel
                gtnmButtonResize();
                mediaPanelResize();
            }
        }

        private void mediaPanelResize()
        {
            if (newMediaPanel != null && mediaBlocksPanel != null && mediaHistoryAndNavPanel != null)
            {
                int widthPanel = newMediaPanel.Width;
                int heightBlocksPanel = (int)(newMediaPanel.Height * 0.6);
                int heightHAVPanel = (int)(newMediaPanel.Height * 0.2);

                // Налаштовуємо розміри панелей
                mediaBlocksPanel.Size = new Size(widthPanel, heightBlocksPanel);
                mediaHistoryAndNavPanel.Size = new Size(widthPanel, heightHAVPanel);

                // Налаштовуємо розташування для mediaBlocksPanel
                mediaBlocksPanel.Location = new Point(
                    (newMediaPanel.Width - widthPanel) / 2,
                    60 // Можна коригувати для вашого дизайну
                );

                // Налаштовуємо розташування для mediaHistoryAndNavPanel
                mediaHistoryAndNavPanel.Location = new Point(
                    (newMediaPanel.Width - widthPanel) / 2,
                    mediaBlocksPanel.Bottom + 10 // Розміщуємо трохи нижче mediaBlocksPanel
                );
            }
        }

        private void gtnmButtonResize()
        {
            if (newMediaPanel != null)
            {
                int widthButton = newMediaPanel.Width;
                int heightButton = 25;

                if (goToNewMediaButton != null)
                {
                    goToNewMediaButton.Size = new Size(widthButton, heightButton);
                    goToNewMediaButton.Location = new Point(
                        (newMediaPanel.Width - widthButton) / 2,
                        25
                    );

                    goToNewMediaButton.Text = getTextGTNMButton();
                }
            }
        }

        private string getTextGTNMButton()
        {
            string buttonText = "Go to new media";

            int buttonWidth = newMediaPanel.Width;

            int gtWidth = TextRenderer.MeasureText(">", goToNewMediaButton.Font).Width;
            int spaceWidth = TextRenderer.MeasureText(" ", goToNewMediaButton.Font).Width;
            int textWidth = TextRenderer.MeasureText(buttonText, goToNewMediaButton.Font).Width;

            int availableWidth = buttonWidth - textWidth - gtWidth;
            int numberOfSpaces = (int)(3.3 * Math.Max(0, availableWidth / spaceWidth));

            string spaces = new string(' ', numberOfSpaces);

            return buttonText + spaces + ">";
        }


        #endregion

        private void navButton_Click(object sender, EventArgs e)
        {
            navMenuPanel.Visible = !navMenuPanel.Visible;
        }

        private void navButton_MouseEnter(object sender, EventArgs e)
        {
            Button navButton = sender as Button;

            if (navButton != null)
            {
                navButton.BackColor = Color.White;
                navButton.ForeColor = Color.Black;
            }
        }

        private void navButton_MouseLeave(object sender, EventArgs e)
        {
            Button navButton = sender as Button;

            if (navButton != null)
            {
                navButton.BackColor = Color.FromArgb(58, 58, 58);
                navButton.ForeColor = Color.White;
            }
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Search")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black; 
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBox.Text = "Search";
                searchTextBox.ForeColor = Color.Gray; 
            }
        }

        
    }
}
