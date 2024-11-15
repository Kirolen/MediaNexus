using System;
using System.Windows.Forms;

/// <summary>
/// A custom <see cref="Panel"/> control that allows the user to select a date using separate ComboBoxes for the year, month, and day.
/// </summary>
public class DatePickerPanel : Panel
{
    /// <summary>
    /// ComboBox for selecting the year.
    /// </summary>
    protected ComboBox yearComboBox;

    /// <summary>
    /// ComboBox for selecting the month.
    /// </summary>
    protected ComboBox monthComboBox;

    /// <summary>
    /// ComboBox for selecting the day.
    /// </summary>
    protected ComboBox dayComboBox;

    /// <summary>
    /// Initializes a new instance of the <see cref="DatePickerPanel"/> class with ComboBoxes for selecting a year, month, and day.
    /// </summary>
    public DatePickerPanel()
    {
        this.Dock = DockStyle.Top;
        this.Size = new System.Drawing.Size(150, 30);

        yearComboBox = new ComboBox { Dock = DockStyle.Left, Width = 50 };
        for (int i = DateTime.Now.Year; i >= 1900; i--)
        {
            yearComboBox.Items.Add(i);
        }

        monthComboBox = new ComboBox { Dock = DockStyle.Left, Width = 50 };
        string[] monthNames = { "January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November", "December" };

        foreach (var month in monthNames)
        {
            monthComboBox.Items.Add(month);
        }

        dayComboBox = new ComboBox { Dock = DockStyle.Left, Width = 50 };
        for (int i = 1; i <= 31; i++)
        {
            dayComboBox.Items.Add(i);
        }

        this.Controls.Add(yearComboBox);
        this.Controls.Add(monthComboBox);
        this.Controls.Add(dayComboBox);
    }

    /// <summary>
    /// Gets the selected date based on the user's selections in the year, month, and day ComboBoxes.
    /// </summary>
    /// <returns>A <see cref="DateTime"/> representing the selected date, or null if the date selection is incomplete or invalid.</returns>
    public DateTime? GetSelectedDate()
    {
        if (yearComboBox.SelectedItem != null && monthComboBox.SelectedItem != null && dayComboBox.SelectedItem != null)
        {
            try
            {
                int year = Convert.ToInt32(yearComboBox.SelectedItem);
                int month = monthComboBox.SelectedIndex + 1; // Month index starts at 0, so add 1.
                int day = Convert.ToInt32(dayComboBox.SelectedItem);

                return new DateTime(year, month, day);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Invalid date. Please check your selection.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        return null;
    }

    /// <summary>
    /// Gets the standard width for the <see cref="DatePickerPanel"/>.
    /// </summary>
    /// <returns>An integer representing the standard width (160).</returns>
    public static int GetStandrtWidth()
    {
        return 160;
    }
}
