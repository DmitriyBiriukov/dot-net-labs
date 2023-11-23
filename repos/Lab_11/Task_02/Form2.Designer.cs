namespace Task_01
{
    partial class Form2
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
            menuStrip1 = new MenuStrip();
            form4ToolStripMenuItem = new ToolStripMenuItem();
            form5ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { form4ToolStripMenuItem, form5ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1549, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // form4ToolStripMenuItem
            // 
            form4ToolStripMenuItem.Name = "form4ToolStripMenuItem";
            form4ToolStripMenuItem.Size = new Size(102, 36);
            form4ToolStripMenuItem.Text = "Form3";
            form4ToolStripMenuItem.Click += form4ToolStripMenuItem_Click;
            // 
            // form5ToolStripMenuItem
            // 
            form5ToolStripMenuItem.Name = "form5ToolStripMenuItem";
            form5ToolStripMenuItem.Size = new Size(102, 36);
            form5ToolStripMenuItem.Text = "Form4";
            form5ToolStripMenuItem.Click += form5ToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 128);
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(671, 358);
            label1.Name = "label1";
            label1.Size = new Size(206, 72);
            label1.TabIndex = 2;
            label1.Text = "FORM2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(738, 516);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(671, 594);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 788);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem form4ToolStripMenuItem;
        private ToolStripMenuItem form5ToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
    }
}