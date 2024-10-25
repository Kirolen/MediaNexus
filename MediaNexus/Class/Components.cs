using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class Components
{
    static public CheckBox CreateCheckBox(string text, Color? backColor = null)
    {
        return new CheckBox
        {
            Text = text,
            BackColor = backColor ?? Color.Transparent, 
            AutoSize = true 
        };
    }
    static public TableLayoutPanel CreateTableLayoutPanel(int rows, int cols, List<RowStyle> rowStyles = null, List<ColumnStyle> colStyles = null, Cursor cursor = null)
    {
        TableLayoutPanel table = new TableLayoutPanel
        {
            ColumnCount = cols,
            RowCount = rows,
            Margin = new Padding(0),
            Dock = DockStyle.Fill,
            Cursor = cursor ?? Cursors.Default
        };

        // Apply row styles
        if (rowStyles != null)
        {
            for (int i = 0; i < rows; i++)
            {
                if (i < rowStyles.Count)
                {
                    var style = rowStyles[i];
                    table.RowStyles.Add(new RowStyle(style.SizeType, style.Height));
                }
                else
                {
                    // If there are fewer styles than rows, use AutoSize as a fallback
                    table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }
            }
        }

        // Apply column styles
        if (colStyles != null)
        {
            for (int i = 0; i < cols; i++)
            {
                if (i < colStyles.Count)
                {
                    var style = colStyles[i];
                    table.ColumnStyles.Add(new ColumnStyle(style.SizeType, style.Width));
                }
                else
                {
                    // If there are fewer styles than columns, use AutoSize as a fallback
                    table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                }
            }
        }

        return table;
    }
}
