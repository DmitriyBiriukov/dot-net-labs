using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                form3.BackColor = Color.Blue;
                form3.ForeColor = Color.White;
                form3.ShowDialog();
            }
        }

        private void form5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form4 form4 = new Form4())
            {
                form4.BackColor = Color.Green;
                form4.ForeColor = Color.Black;
                form4.ShowDialog();
            }
        }
    }
}
