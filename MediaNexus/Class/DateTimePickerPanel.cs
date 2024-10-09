using System;
using System.Windows.Forms;

public class DateTimePickerPanel : DatePickerPanel
{
    private readonly ComboBox hourComboBox;
    private readonly ComboBox minuteComboBox;

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

    new static public int GetStandrtWidth()
    {
        return 240;
    }
}
