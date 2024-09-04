namespace BandsheetApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            bandNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberNamesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bandBindingSource = new BindingSource(components);
            button1 = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bandBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Yu Gothic UI", 16F);
            label1.Location = new Point(16, -1);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 48);
            label1.TabIndex = 0;
            label1.Text = "file";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bandNameDataGridViewTextBoxColumn, memberNamesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bandBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(120, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1261, 718);
            dataGridView1.TabIndex = 1;
            // 
            // bandNameDataGridViewTextBoxColumn
            // 
            bandNameDataGridViewTextBoxColumn.DataPropertyName = "BandName";
            bandNameDataGridViewTextBoxColumn.HeaderText = "BandName";
            bandNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            bandNameDataGridViewTextBoxColumn.Name = "bandNameDataGridViewTextBoxColumn";
            bandNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // memberNamesDataGridViewTextBoxColumn
            // 
            memberNamesDataGridViewTextBoxColumn.DataPropertyName = "MemberNames";
            memberNamesDataGridViewTextBoxColumn.HeaderText = "MemberNames";
            memberNamesDataGridViewTextBoxColumn.MinimumWidth = 8;
            memberNamesDataGridViewTextBoxColumn.Name = "memberNamesDataGridViewTextBoxColumn";
            memberNamesDataGridViewTextBoxColumn.ReadOnly = true;
            memberNamesDataGridViewTextBoxColumn.Width = 2000;
            // 
            // bandBindingSource
            // 
            bandBindingSource.DataSource = typeof(Object.Band);
            // 
            // button1
            // 
            button1.Location = new Point(137, -1);
            button1.Name = "button1";
            button1.Size = new Size(193, 48);
            button1.TabIndex = 2;
            button1.Text = "バンド練習表自動作成";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Location = new Point(120, 146);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 54.6666679F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45.3333321F));
            tableLayoutPanel.Size = new Size(300, 150);
            tableLayoutPanel.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(325, -1);
            button2.Name = "button2";
            button2.Size = new Size(193, 48);
            button2.TabIndex = 4;
            button2.Text = "行の入れ替え";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(515, -1);
            button3.Name = "button3";
            button3.Size = new Size(184, 48);
            button3.TabIndex = 5;
            button3.Text = "バンドの入れ替え";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1751, 879);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bandBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource bandBindingSource;
        private DataGridViewTextBoxColumn bandNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn memberNamesDataGridViewTextBoxColumn;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel;
        private Button button2;
        private Button button3;
    }
}
