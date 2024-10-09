using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Components
{
    static public TableLayoutPanel CreateTableLayoutPanel(int rows, int cols,Cursor cursor = null)
    {
        TableLayoutPanel table = new TableLayoutPanel
        {
            ColumnCount = cols,
            RowCount = rows,
            Margin =  new Padding(0),
            Dock = DockStyle.Fill,
            Cursor = cursor ?? Cursors.Default
        };

        return table;
    }

}