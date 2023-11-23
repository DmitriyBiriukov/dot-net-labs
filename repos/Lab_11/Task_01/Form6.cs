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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void form7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (Form7 form7 = new Form7())
            {
                form7.BackColor = Color.Red;
                form7.ForeColor = Color.White;
                form7.ShowDialog();
            }
        }
    }
}
