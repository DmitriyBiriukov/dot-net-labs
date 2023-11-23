using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form2 form3 = new Form2())
            {
                form3.BackColor = Color.Blue;
                form3.ForeColor = Color.White;
                form3.ShowDialog();
            }
        }

    }
}