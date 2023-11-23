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

            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    // Отримайте інформацію з Form2 і встановіть її в мітку на Form1
                    label2.Text = "Form2: " + form2.Information;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Main Form";
        }
    }
}