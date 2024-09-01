using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BandsheetApp1
{
    public partial class SheetSizeForm : Form
    {
        public int ColumnCount { get; private set; }
        public int RowCount { get; private set; }

        public SheetSizeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtColumns.Text, out int columns) && int.TryParse(txtRows.Text, out int rows))
            {
                ColumnCount = columns;
                RowCount = rows;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("列数と行数には有効な整数値を入力してください。");
            }
        }
    }
}
