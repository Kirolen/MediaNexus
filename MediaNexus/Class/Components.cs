using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Provides methods to create and configure common UI components in Windows Forms.
/// </summary>
public class Components
{
    /// <summary>
    /// Creates a <see cref="TextBox"/> with customizable placeholder text, margin, multiline mode, password mode, and width.
    /// </summary>
    /// <param name="palceHolder">Placeholder text displayed when the <see cref="TextBox"/> is empty.</param>
    /// <param name="needMargin">If true, applies a margin around the <see cref="TextBox"/>. Default is false.</param>
    /// <param name="multiLine">If true, allows multiple lines of text. Default is false.</param>
    /// <param name="isPassword">If true, masks text input for passwords. Default is false.</param>
    /// <param name="fixedWidth">Sets a fixed width. If negative, the <see cref="TextBox"/> uses <see cref="DockStyle.Top"/>. Default is -1.</param>
    /// <returns>A configured <see cref="TextBox"/> instance.</returns>
    public static TextBox addTextBox(string palceHolder, bool needMargin = false, bool multiLine = false, bool isPassword = false, int fixedWidth = -1)
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

    /// <summary>
    /// Adds placeholder functionality to a given <see cref="TextBox"/>.
    /// </summary>
    /// <param name="textBox">The <see cref="TextBox"/> to which the placeholder is applied.</param>
    /// <param name="placeholderText">Text displayed as the placeholder.</param>
    /// <param name="isPassword">Determines if the <see cref="TextBox"/> is used for password input.</param>
    public static void AddPlaceholder(TextBox textBox, string placeholderText, bool isPassword)
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

    /// <summary>
    /// Creates a <see cref="Label"/> with specified name, text, color, and alignment.
    /// </summary>
    /// <param name="labelName">Name of the <see cref="Label"/>.</param>
    /// <param name="labelText">Text displayed on the <see cref="Label"/>.</param>
    /// <param name="foreColor">Foreground color for the text.</param>
    /// <param name="align">Text alignment. Default is <see cref="ContentAlignment.BottomLeft"/>.</param>
    /// <returns>A configured <see cref="Label"/> instance.</returns>
    public static Label createLabel(string labelName, string labelText, Color foreColor, ContentAlignment align = ContentAlignment.BottomLeft)
    {
        return new Label
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
    }

    /// <summary>
    /// Creates a <see cref="CheckBox"/> with specified text and optional background color.
    /// </summary>
    /// <param name="text">Text displayed next to the <see cref="CheckBox"/>.</param>
    /// <param name="backColor">Optional background color. Default is transparent.</param>
    /// <returns>A configured <see cref="CheckBox"/> instance.</returns>
    public static CheckBox CreateCheckBox(string text, Color? backColor = null)
    {
        return new CheckBox
        {
            Text = text,
            BackColor = backColor ?? Color.Transparent,
            AutoSize = true
        };
    }

    /// <summary>
    /// Creates a <see cref="TableLayoutPanel"/> with specified rows, columns, and optional styles.
    /// </summary>
    /// <param name="rows">Number of rows.</param>
    /// <param name="cols">Number of columns.</param>
    /// <param name="rowStyles">Custom row styles. Default is null.</param>
    /// <param name="colStyles">Custom column styles. Default is null.</param>
    /// <param name="cursor">Optional custom cursor. Default is <see cref="Cursors.Default"/>.</param>
    /// <returns>A configured <see cref="TableLayoutPanel"/> instance.</returns>
    public static TableLayoutPanel CreateTableLayoutPanel(int rows, int cols, List<RowStyle> rowStyles = null, List<ColumnStyle> colStyles = null, Cursor cursor = null)
    {
        TableLayoutPanel table = new TableLayoutPanel
        {
            ColumnCount = cols,
            RowCount = rows,
            Margin = new Padding(0),
            Dock = DockStyle.Fill,
            Cursor = cursor ?? Cursors.Default
        };

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
                    table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }
            }
        }

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
                    table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                }
            }
        }

        return table;
    }

    /// <summary>
    /// Creates a <see cref="Panel"/> of specified size and color, centered within a parent panel.
    /// </summary>
    /// <param name="width">Width of the <see cref="Panel"/>.</param>
    /// <param name="height">Height of the <see cref="Panel"/>.</param>
    /// <param name="backColor">Background color of the <see cref="Panel"/>.</param>
    /// <param name="mainPanel">Parent panel for centering.</param>
    /// <returns>A configured <see cref="Panel"/> instance.</returns>
    public static Panel createPanel(int width, int height, Color backColor, Panel mainPanel)
    {
        int xPosition = (mainPanel.Width - width) / 2;
        int yPosition = (mainPanel.Height - height) / 2;

        return new Panel
        {
            Size = new Size(width, height),
            Location = new Point(xPosition, yPosition),
            BackColor = backColor,
            Margin = new Padding(0),
        };
    }
}
