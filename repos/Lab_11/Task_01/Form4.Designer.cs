namespace Task_01
{
    partial class Form4
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
            form6ToolStripMenuItem = new ToolStripMenuItem();
            form7ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { form6ToolStripMenuItem, form7ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1630, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // form6ToolStripMenuItem
            // 
            form6ToolStripMenuItem.Name = "form6ToolStripMenuItem";
            form6ToolStripMenuItem.Size = new Size(102, 36);
            form6ToolStripMenuItem.Text = "Form5";
            form6ToolStripMenuItem.Click += form6ToolStripMenuItem_Click;
            // 
            // form7ToolStripMenuItem
            // 
            form7ToolStripMenuItem.Name = "form7ToolStripMenuItem";
            form7ToolStripMenuItem.Size = new Size(102, 36);
            form7ToolStripMenuItem.Text = "Form6";
            form7ToolStripMenuItem.Click += form7ToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(695, 349);
            label1.Name = "label1";
            label1.Size = new Size(206, 72);
            label1.TabIndex = 2;
            label1.Text = "FORM4";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1630, 776);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Form4";
            Text = "Form4";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem form6ToolStripMenuItem;
        private ToolStripMenuItem form7ToolStripMenuItem;
        private Label label1;
    }
}