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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            bandNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberNamesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bandBindingSource = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bandBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Yu Gothic UI", 16F);
            label1.Location = new Point(0, -1);
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bandNameDataGridViewTextBoxColumn, memberNamesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bandBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Yu Gothic UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(120, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1261, 680);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            button1.Location = new Point(1478, 593);
            button1.Name = "button1";
            button1.Size = new Size(193, 100);
            button1.TabIndex = 2;
            button1.Text = "バンド練習表自動作成";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1718, 813);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
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
    }
}
