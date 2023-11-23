namespace Task_01
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
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1. Єрусалим", "2. Тель-Авів", "3. Хайфа", "4. Ашдод", "5. Беер-Шева", "6. Нетанья", "7. Ейлат" });
            comboBox1.Location = new Point(912, 297);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Items.AddRange(new object[] { "1. Єрусалим", "2. Тель-Авів", "3. Хайфа", "4. Ашдод", "5. Беер-Шева", "6. Нетанья", "7. Ейлат" });
            listBox1.Location = new Point(414, 240);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(246, 132);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(414, 53);
            label1.Name = "label1";
            label1.Size = new Size(769, 98);
            label1.TabIndex = 2;
            label1.Text = "7 міст Ізраїлю";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 784);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label1;
    }
}