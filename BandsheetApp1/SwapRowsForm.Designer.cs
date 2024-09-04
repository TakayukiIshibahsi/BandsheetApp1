namespace BandsheetApp1
{
    partial class SwapRowsForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            swapButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F);
            label1.Location = new Point(148, 31);
            label1.Name = "label1";
            label1.Size = new Size(314, 32);
            label1.TabIndex = 0;
            label1.Text = "入れ替える行を選択してください";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(368, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.changeAllow;
            pictureBox1.Location = new Point(241, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // swapButton
            // 
            swapButton.Location = new Point(203, 208);
            swapButton.Name = "swapButton";
            swapButton.Size = new Size(185, 52);
            swapButton.TabIndex = 4;
            swapButton.Text = "Swap";
            swapButton.UseVisualStyleBackColor = true;
            swapButton.Click += swapButton_Click;
            // 
            // SwapRowsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 281);
            Controls.Add(swapButton);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "SwapRowsForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "SwapRowsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button swapButton;
    }
}