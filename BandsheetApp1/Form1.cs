using BandsheetApp1.Method;
using BandsheetApp1.Object;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace BandsheetApp1
{
    public partial class Form1 : Form
    {
        public List<Band> Bands = new List<Band>();
        public int Columns, Rows;
        public Band[][] BandSheet;

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
                this.Bands = csvFile.ReadCsvFile(selectedFilePath);
                Member mem = new Member();
                this.Bands = mem.UpdateBandListWeight(this.Bands.ToArray());

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = this.Bands;
                // DataGridView を表示する
                dataGridView1.Visible = true;
                tableLayoutPanel.Visible = false;
                SetColumnWidths();

                this.Refresh();
            }
        }

        private void DebugBandSheet(Band[][] bandSheet)
        {
            var sb = new System.Text.StringBuilder();

            sb.AppendLine($"BandSheet Size: {this.BandSheet.Length} rows"); 

            for (int i = 0; i < bandSheet.Length; i++)
            {
                sb.AppendLine($"Row {i} Size: {bandSheet[i].Length} columns");
                for (int j = 0; j < bandSheet[i].Length; j++)
                {
                    string bandName = bandSheet[i][j]?.BandName ?? "null";
                    string members = bandSheet[i][j]?.MemberNames ?? "null";
                    sb.AppendLine($"Cell ({i}, {j}): {bandName} {members}");
                }
            }

            MessageBox.Show(sb.ToString(), "BandSheet Debug Info");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SheetSizeForm sheetSizeForm = new SheetSizeForm())
            {
                if (sheetSizeForm.ShowDialog() == DialogResult.OK)
                {

                    this.Columns = sheetSizeForm.ColumnCount;
                    this.Rows = sheetSizeForm.RowCount;

                    // DataGridView を非表示にする
                    dataGridView1.Visible = false;

                    // TableLayoutPanel を動的に生成
                    tableLayoutPanel.Visible = true;
                    tableLayoutPanel.Controls.Clear();
                    tableLayoutPanel.ColumnCount = this.Columns + 1;
                    tableLayoutPanel.RowCount = this.Rows;
                    tableLayoutPanel.AutoSize = true;
                    tableLayoutPanel.Location = dataGridView1.Location;

                    // ヘッダー行の追加
                    Form studioInputForm = new Form { Size = new System.Drawing.Size(1500, 200) };
                    studioInputForm.Text = "Enter Studio Names";

                    TableLayoutPanel studioInputPanel = new TableLayoutPanel { ColumnCount = this.Columns + 1, RowCount = 1, Dock = DockStyle.Top };

                    // 各列に TextBox を追加
                    List<TextBox> textBoxList = new List<TextBox>();
                    for (int col = 0; col < this.Columns + 1; col++)
                    {
                        TextBox studioTextBox = new TextBox();
                        if (col == 0)
                        {
                            studioTextBox = new TextBox { Text = "time" };
                        }
                        else
                        {
                            studioTextBox = new TextBox { PlaceholderText = $"Studio {col}" };
                        }
                        textBoxList.Add(studioTextBox);
                        studioInputPanel.Controls.Add(studioTextBox, col, 0);
                    }

                    Button okButton = new Button
                    {
                        Text = "OK",
                        Dock = DockStyle.Right,
                    };

                    okButton.Click += (sender, e) =>
                    {
                        // スタジオ名をヘッダーに反映
                        for (int col = 0; col < this.Columns + 1; col++)
                        {
                            string studioName = textBoxList[col].Text;
                            Label headerLabel = new Label() { Text = studioName, AutoSize = true };
                            tableLayoutPanel.Controls.Add(headerLabel, col, 0);
                        }
                        studioInputForm.Close();
                    };

                    // フォームに追加して表示
                    studioInputForm.Controls.Add(studioInputPanel);
                    studioInputForm.Controls.Add(okButton);
                    studioInputForm.ShowDialog();
                    Member mem = new Member();
                    this.BandSheet = mem.AutomaticBandsheet(this.Columns, this.Rows, this.Bands); 
                    // データ行の追加（仮のデータ）
                    for (int row = 1; row <= this.Rows; row++)
                    {
                        for (int col = 0; col < this.Columns + 1; col++)
                        {
                            TextBox cellTextBox = new TextBox();
                            if (col == 0)
                            {
                                cellTextBox = new TextBox() { Text = $"{row}", AutoSize = true, Size = new System.Drawing.Size(80, 64) };
                            }
                            else
                            {
                                if (row - 1 < this.BandSheet.Length && col - 1 < this.BandSheet[row - 1].Length)
                                {
                                    cellTextBox = new TextBox() { Text = this.BandSheet[row - 1][col - 1].BandName, AutoSize = true, Size = new System.Drawing.Size(128, 64) };
                                }
                            }

                            tableLayoutPanel.Controls.Add(cellTextBox, col, row);
                        }
                    }

                    // フォームに TableLayoutPanel を追加して表示
                    this.Controls.Add(tableLayoutPanel);
                    tableLayoutPanel.BringToFront();
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SwapRowsForm swapRowsForm = new SwapRowsForm())
            {
                if(swapRowsForm.ShowDialog() == DialogResult.OK　&&  this.Columns * this.Rows > 0)
                {
                    // TableLayoutPanel を動的に生成
                    tableLayoutPanel.Visible = true;
                    tableLayoutPanel.Controls.Clear();
                    tableLayoutPanel.ColumnCount = this.Columns + 1;
                    tableLayoutPanel.RowCount = this.Rows;
                    tableLayoutPanel.AutoSize = true;
                    int row1 = swapRowsForm.Row1;
                    int row2 = swapRowsForm.Row2;
                    swapRowsForm.Dispose();
                    //bandSheetの入れ替え
                    Member mem = new Member();
                    this.BandSheet = mem.SwapRows(this.BandSheet, row1, row2, this.Rows); 
                    for (int row = 1; row <= this.Rows; row++)
                    {
                        for (int col = 0; col < this.Columns + 1; col++)
                        {
                            TextBox cellTextBox = new TextBox();
                            if (col == 0)
                            {
                                cellTextBox = new TextBox() { Text = $"{row}", AutoSize = true, Size = new System.Drawing.Size(80, 64) };
                            }
                            else
                            {
                                if (row - 1 < this.BandSheet.Length && col - 1 < this.BandSheet[row - 1].Length)
                                {
                                    cellTextBox = new TextBox() { Text = this.BandSheet[row - 1][col - 1].BandName, AutoSize = true, Size = new System.Drawing.Size(128, 64) };
                                }
                            }

                            tableLayoutPanel.Controls.Add(cellTextBox, col, row);
                        }
                    }

                    // フォームに TableLayoutPanel を追加して表示
                    
                }
            }

        }
    }

}
