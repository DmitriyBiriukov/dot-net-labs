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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void form6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form5 form5 = new Form5())
            {
                form5.BackColor = Color.Yellow;
                form5.ForeColor = Color.Black;
                form5.ShowDialog();
            }
        }

        private void form7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form6 form6 = new Form6())
            {
                form6.BackColor = Color.Orange;
                form6.ForeColor = Color.Black;
                form6.ShowDialog();
            }
        }
    }
}
