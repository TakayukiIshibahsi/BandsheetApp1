namespace BandsheetApp1
{
    partial class SheetSizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtColumns = new TextBox();
            txtRows = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtColumns
            // 
            txtColumns.Location = new Point(202, 44);
            txtColumns.Name = "txtColumns";
            txtColumns.Size = new Size(150, 31);
            txtColumns.TabIndex = 0;
            // 
            // txtRows
            // 
            txtRows.Location = new Point(202, 110);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(150, 31);
            txtRows.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 44);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 2;
            label1.Text = "スタジオ数";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 116);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 3;
            label2.Text = "練習可能回数";
            // 
            // button1
            // 
            button1.Location = new Point(392, 110);
            button1.Name = "button1";
            button1.Size = new Size(90, 37);
            button1.TabIndex = 4;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 176);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRows);
            Controls.Add(txtColumns);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtColumns;
        private TextBox txtRows;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}