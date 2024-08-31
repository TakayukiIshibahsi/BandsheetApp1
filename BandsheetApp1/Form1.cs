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
            // OpenFileDialog�̃C���X�^���X���쐬
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // �t�@�C���̃t�B���^��ݒ�i��F�e�L�X�g�t�@�C���̂݁j
            openFileDialog.Filter = "Csv files (*.csv)|*.csv|All files (*.*)|*.*";

            // �_�C�A���O��\�����A���[�U�[���t�@�C����I�������ꍇ�̏���
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
