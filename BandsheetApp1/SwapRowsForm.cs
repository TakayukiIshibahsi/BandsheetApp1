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
    public partial class SwapRowsForm : Form
    {
        public int Row1 { get; private set; }
        public int Row2 { get; private set; }
        public SwapRowsForm()
        {
            InitializeComponent();
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int row1) && int.TryParse(textBox2.Text, out int row2))
            {
                Row1 = row1;
                Row2 = row2;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("行数には有効な整数値を入力してください。");
            }
        }
    }
}
