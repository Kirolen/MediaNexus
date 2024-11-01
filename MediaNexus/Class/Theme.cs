using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNexus.Class
{
    internal class Theme
    {
        public bool DarkTheme { get; set; }

        public Theme(bool darkTheme)
        {
            DarkTheme = darkTheme;
        }
        public Color getDefaultButtonColor()
        {
            return DarkTheme ? Color.FromArgb(58, 58, 58) : Color.FromArgb(204, 255, 204);
        }
        public Color getDefaultButtonTextColor()
        {
            return DarkTheme ? Color.White : Color.Black;
        }

        public Color getResponseTextColor()
        {
            return DarkTheme ? Color.Black : Color.White;
        }
        public Color getMouseEnterButtonTextColor()
        {
            return DarkTheme ? Color.Orange : Color.Green;
        }
        public Color getHistoryPanelColor()
        {
            return DarkTheme ? Color.FromArgb(233, 247, 251) : Color.FromArgb(58, 58, 58);
        }
        public Color getPanelColor()
        {
            return DarkTheme ? Color.FromArgb(70, 70, 70) : Color.FromArgb(252, 252, 210);
        }
        public Color getLabelTextColor()
        {
            return DarkTheme ? Color.White : Color.Black;
        }

        public Color getSortPanelColor()
        {
            return DarkTheme ? Color.FromArgb(70, 70, 70) : Color.FromArgb(214, 252, 210);
        }

        public Color getMouseEnterButtonColor()
        {
            return DarkTheme ? Color.White : Color.Black;
        }

        public Color getNavPanelColor()
        {
            return DarkTheme ? Color.FromArgb(20, 20, 20) : Color.FromArgb(255, 255, 204); ;
        }

        public Color getMainPanelColor()
        {
            return DarkTheme ? Color.FromArgb(20, 20, 20) : Color.FromArgb(250, 252, 236);
        }

        public Color getUserPanelColor()
        {
            return DarkTheme ? Color.FromArgb(20, 20, 20) : Color.FromArgb(209, 209, 209);
        }

    }
}
