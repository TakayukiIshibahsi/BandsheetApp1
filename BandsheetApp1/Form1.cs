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
            // OpenFileDialogのインスタンスを作成
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // ファイルのフィルタを設定（例：テキストファイルのみ）
            openFileDialog.Filter = "Csv files (*.csv)|*.csv|All files (*.*)|*.*";

            // ダイアログを表示し、ユーザーがファイルを選択した場合の処理
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 選択されたファイルのパスを取得
                string selectedFilePath = openFileDialog.FileName;

                // ファイルパスをラベルやテキストボックスに表示
                MessageBox.Show("Selected file: " + selectedFilePath);
                CsvFile csvFile = new CsvFile();
                csvFile.ReadCsvFile(selectedFilePath);
            }
        }
    }
}
