using System;
using System.Windows.Forms;

public class DatePickerPanel : Panel
{
    protected ComboBox yearComboBox;
    protected ComboBox monthComboBox;
    protected ComboBox dayComboBox;

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

    public DateTime? GetSelectedDate()
    {
        if (yearComboBox.SelectedItem != null && monthComboBox.SelectedItem != null && dayComboBox.SelectedItem != null)
        {
            try
            {
                int year = Convert.ToInt32(yearComboBox.SelectedItem);
                int month = monthComboBox.SelectedIndex + 1; // Індекс місяця починається з 0, тому додаємо 1.
                int day = Convert.ToInt32(dayComboBox.SelectedItem);

                return new DateTime(year, month, day);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Неправильна дата. Будь ласка, перевірте свій вибір.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        return null;
    }

    static public int GetStandrtWidth()
    {
        return 160;
    }
}
