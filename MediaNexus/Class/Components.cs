using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class Components
{
    static public TextBox addTextBox(string palceHolder, bool needMargin = false, bool multiLine = false, bool isPassword = false, int fixedWidth = -1)
    {
        TextBox textBox;
        if (fixedWidth < 0)
        {
            textBox = new TextBox
            {
                Dock = DockStyle.Top,
                Multiline = multiLine,
                Margin = needMargin ? new Padding(5) : new Padding(0),
                PasswordChar = isPassword ? '\0' : '\0'
            };
            AddPlaceholder(textBox, palceHolder, isPassword);
        }
        else
        {
            textBox = new TextBox
            {
                Anchor = AnchorStyles.Left,
                Width = fixedWidth,
                Multiline = multiLine,
                Margin = needMargin ? new Padding(5) : new Padding(0),
                PasswordChar = isPassword ? '\0' : '\0'
            };
            AddPlaceholder(textBox, palceHolder, isPassword);
        }


        return textBox;
    }
    static public void AddPlaceholder(TextBox textBox, string placeholderText, bool isPassword)
    {
        textBox.Text = placeholderText;
        textBox.ForeColor = Color.LightGray;
        textBox.BackColor = Color.Black;

        textBox.Enter += (s, e) =>
        {
            if (textBox.Text == placeholderText)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.White;
                if (isPassword)
                {
                    textBox.PasswordChar = '*';
                }
            }
        };

        textBox.Leave += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = Color.LightGray;
                textBox.PasswordChar = '\0';
            }
        };
    }

    static public Label createLabel(string labelName, string labelText, Color foreColor, ContentAlignment align = ContentAlignment.BottomLeft)
    {

        Label navLabel = new Label
        {
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204))),
            ForeColor = foreColor,
            Margin = new Padding(0),
            Name = labelName,
            TabIndex = 6,
            Text = labelText,
            TextAlign = align
        };

        return navLabel;
    }
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

    static public Panel createPanel(int width, int height, Color backColor, Panel mainPanel)
    {

        int xPosition = (mainPanel.Width - width) / 2;
        int yPosition = (mainPanel.Height - height) / 2;

        Panel MediaPanel = new Panel
        {
            Size = new Size(width, height),
            Location = new Point(xPosition, yPosition),
            BackColor = backColor,
            Margin = new Padding(0),
        };

        return MediaPanel;
    }

}
