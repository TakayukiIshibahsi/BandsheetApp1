using BandsheetApp1.Method;
using BandsheetApp1.Object;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BandsheetApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetColumnWidths()
        {
            dataGridView1.Columns["BandName"].Width = 150;
            dataGridView1.Columns["MemberNames"].Width = 900;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // OpenFileDialogのインスタンスを作成
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // ファイルのフィルタを設定（例：テキストファイルのみ）
            openFileDialog.Filter = "Csv files (*.csv)|*.csv|All files (*.*)|*.*";

            // ダイアログを表示し、ユーザーがファイルを選択した場合の処理
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                MessageBox.Show("Selected file: " + selectedFilePath);

                CsvFile csvFile = new CsvFile();
                List<Band> bands = csvFile.ReadCsvFile(selectedFilePath);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bands;
                SetColumnWidths();

                this.Refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

        }
    }
}
