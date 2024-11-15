using System.Drawing;

namespace MediaNexus.Class
{
    /// <summary>
    /// Manages theme-related color settings for the application, based on a light or dark theme preference.
    /// </summary>
    internal class Theme
    {
        /// <summary>
        /// Gets or sets a value indicating whether the theme is dark.
        /// </summary>
        public bool DarkTheme { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Theme"/> class with a specified theme preference.
        /// </summary>
        /// <param name="darkTheme">True for a dark theme, false for a light theme.</param>
        public Theme(bool darkTheme)
        {
            DarkTheme = darkTheme;
        }

        /// <summary>
        /// Gets the default button color based on the theme.
        /// </summary>
        /// <returns>The button color.</returns>
        public Color getDefaultButtonColor()
        {
            return DarkTheme ? Color.FromArgb(58, 58, 58) : Color.FromArgb(204, 255, 204);
        }

        /// <summary>
        /// Gets the default button text color based on the theme.
        /// </summary>
        /// <returns>The button text color.</returns>
        public Color getDefaultButtonTextColor()
        {
            return DarkTheme ? Color.White : Color.Black;
        }

        /// <summary>
        /// Gets the color for response text based on the theme.
        /// </summary>
        /// <returns>The response text color.</returns>
        public Color getResponseTextColor()
        {
            return DarkTheme ? Color.Black : Color.White;
        }

        /// <summary>
        /// Gets the button text color on mouse hover based on the theme.
        /// </summary>
        /// <returns>The hover button text color.</returns>
        public Color getMouseEnterButtonTextColor()
        {
            return DarkTheme ? Color.Orange : Color.Green;
        }

        /// <summary>
        /// Gets the color for the history panel based on the theme.
        /// </summary>
        /// <returns>The history panel color.</returns>
        public Color getHistoryPanelColor()
        {
            return DarkTheme ? Color.FromArgb(233, 247, 251) : Color.FromArgb(58, 58, 58);
        }

        /// <summary>
        /// Gets the default panel color based on the theme.
        /// </summary>
        /// <returns>The panel color.</returns>
        public Color getPanelColor()
        {
            return DarkTheme ? Color.FromArgb(70, 70, 70) : Color.FromArgb(252, 252, 210);
        }

        /// <summary>
        /// Gets the label text color based on the theme.
        /// </summary>
        /// <returns>The label text color.</returns>
        public Color getLabelTextColor()
        {
            return DarkTheme ? Color.White : Color.Black;
        }

        /// <summary>
        /// Gets the color for the sorting panel based on the theme.
        /// </summary>
        /// <returns>The sort panel color.</returns>
        public Color getSortPanelColor()
        {
            return DarkTheme ? Color.FromArgb(70, 70, 70) : Color.FromArgb(214, 252, 210);
        }

        /// <summary>
        /// Gets the button background color on mouse hover based on the theme.
        /// </summary>
        /// <returns>The hover button background color.</returns>
        public Color getMouseEnterButtonColor()
        {
            return DarkTheme ? Color.White : Color.Black;
        }

        /// <summary>
        /// Gets the color for the navigation panel based on the theme.
        /// </summary>
        /// <returns>The navigation panel color.</returns>
        public Color getNavPanelColor()
        {
            return DarkTheme ? Color.FromArgb(20, 20, 20) : Color.FromArgb(255, 255, 204);
        }

        /// <summary>
        /// Gets the color for the main content panel based on the theme.
        /// </summary>
        /// <returns>The main panel color.</returns>
        public Color getMainPanelColor()
        {
            return DarkTheme ? Color.FromArgb(20, 20, 20) : Color.FromArgb(250, 252, 236);
        }

        /// <summary>
        /// Gets the color for the user panel based on the theme.
        /// </summary>
        /// <returns>The user panel color.</returns>
        public Color getUserPanelColor()
        {
            return DarkTheme ? Color.FromArgb(20, 20, 20) : Color.FromArgb(209, 209, 209);
        }
    }
}
