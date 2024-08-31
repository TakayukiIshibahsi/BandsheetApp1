using BandsheetApp1.Method;

namespace BandsheetApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                // �I�����ꂽ�t�@�C���̃p�X���擾
                string selectedFilePath = openFileDialog.FileName;

                // �t�@�C���p�X�����x����e�L�X�g�{�b�N�X�ɕ\��
                MessageBox.Show("Selected file: " + selectedFilePath);
                CsvFile csvFile = new CsvFile();
                csvFile.ReadCsvFile(selectedFilePath);
            }
        }
    }
}
