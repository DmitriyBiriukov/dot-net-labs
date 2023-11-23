namespace Task_04
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
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(128, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 411);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите город";
            // 
            // radioButton4
            // 
            radioButton4.CheckAlign = ContentAlignment.MiddleRight;
            radioButton4.Location = new Point(27, 330);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(294, 58);
            radioButton4.TabIndex = 3;
            radioButton4.Text = "Запорожье";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.CheckAlign = ContentAlignment.MiddleRight;
            radioButton3.Location = new Point(27, 252);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(294, 58);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Одесса";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.CheckAlign = ContentAlignment.MiddleRight;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(27, 169);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(294, 58);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Киев";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.CheckAlign = ContentAlignment.MiddleRight;
            radioButton1.Location = new Point(27, 82);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(294, 58);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Харьков";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(895, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 411);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выберите транспорт";
            // 
            // radioButton6
            // 
            radioButton6.CheckAlign = ContentAlignment.MiddleRight;
            radioButton6.Checked = true;
            radioButton6.Location = new Point(191, 221);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(252, 58);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "Самолет";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.CheckAlign = ContentAlignment.MiddleRight;
            radioButton7.Location = new Point(256, 157);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(187, 58);
            radioButton7.TabIndex = 1;
            radioButton7.Text = "Поезд";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.CheckAlign = ContentAlignment.MiddleRight;
            radioButton8.Location = new Point(234, 81);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(209, 58);
            radioButton8.TabIndex = 0;
            radioButton8.Text = "Автобус";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(206, 592);
            button1.Name = "button1";
            button1.Size = new Size(243, 88);
            button1.TabIndex = 5;
            button1.Text = "Выбрать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1027, 592);
            button2.Name = "button2";
            button2.Size = new Size(230, 92);
            button2.TabIndex = 6;
            button2.Text = "Отказаться";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 708);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private Button button1;
        private Button button2;
    }
}