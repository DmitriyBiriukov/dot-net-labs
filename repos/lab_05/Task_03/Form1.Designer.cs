namespace Task_03
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Red;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(145, 278);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 50);
            textBox1.TabIndex = 0;
            textBox1.Text = "TEXT1";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 0, 192);
            textBox2.Font = new Font("Segoe UI", 17F, FontStyle.Underline, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(128, 64, 64);
            textBox2.Location = new Point(665, 262);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 68);
            textBox2.TabIndex = 1;
            textBox2.Text = "TEXT2";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Blue;
            textBox3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Fuchsia;
            textBox3.Location = new Point(1206, 274);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(266, 54);
            textBox3.TabIndex = 2;
            textBox3.Text = "TEXT3";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1605, 712);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}