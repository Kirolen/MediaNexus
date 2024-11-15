using System;
using System.Windows.Forms;

/// <summary>
/// A custom <see cref="DatePickerPanel"/> control that extends date selection with hour and minute selection.
/// </summary>
public class DateTimePickerPanel : DatePickerPanel
{
    /// <summary>
    /// ComboBox for selecting the hour.
    /// </summary>
    private readonly ComboBox hourComboBox;

    /// <summary>
    /// ComboBox for selecting the minute.
    /// </summary>
    private readonly ComboBox minuteComboBox;

    /// <summary>
    /// Initializes a new instance of the <see cref="DateTimePickerPanel"/> class, 
    /// which includes ComboBoxes for selecting hours and minutes in addition to the date.
    /// </summary>
    public DateTimePickerPanel() : base()
    {
        hourComboBox = new ComboBox { Dock = DockStyle.Left, Width = 40 };
        for (int i = 0; i < 24; i++)
        {
            hourComboBox.Items.Add(i.ToString("D2"));
        }

        minuteComboBox = new ComboBox { Dock = DockStyle.Left, Width = 40 };
        for (int i = 0; i < 60; i++)
        {
            minuteComboBox.Items.Add(i.ToString("D2"));
        }

        this.Controls.Add(hourComboBox);
        this.Controls.Add(minuteComboBox);
    }

    /// <summary>
    /// Gets the selected date and time based on the user's selections in the date, hour, and minute ComboBoxes.
    /// </summary>
    /// <returns>A <see cref="DateTime"/> representing the selected date and time, or null if the selection is incomplete.</returns>
    public DateTime? GetSelectedDateTime()
    {
        DateTime? selectedDate = GetSelectedDate();
        if (selectedDate.HasValue && hourComboBox.SelectedItem != null && minuteComboBox.SelectedItem != null)
        {
            int hour = Convert.ToInt32(hourComboBox.SelectedItem);
            int minute = Convert.ToInt32(minuteComboBox.SelectedItem);

            return new DateTime(selectedDate.Value.Year, selectedDate.Value.Month, selectedDate.Value.Day, hour, minute, 0);
        }
        return null;
    }

    /// <summary>
    /// Gets the standard width for the <see cref="DateTimePickerPanel"/>, including space for time selection.
    /// </summary>
    /// <returns>An integer representing the standard width (240).</returns>
    new public static int GetStandrtWidth()
    {
        return 240;
    }
}
