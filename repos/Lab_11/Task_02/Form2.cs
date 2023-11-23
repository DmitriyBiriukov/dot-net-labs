using System;
using System.Drawing;
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

                // Передаємо інформацію з Form2 до Form3
                form3.SetCallingFormInfo("Form2", textBox1.Text);

                form3.ShowDialog();

                // Оновлюємо інформацію в TextBox на Form2 після повернення з Form3
                textBox1.Text = form3.Information;
            }
        }

        private void form5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form4 form4 = new Form4())
            {
                form4.BackColor = Color.Green;
                form4.ForeColor = Color.Black;

                // Передаємо інформацію з Form2 до Form4
                form4.SetCallingFormInfo("Form2", textBox.Text);

                form4.ShowDialog();

                // Оновлюємо інформацію в TextBox на Form2 після повернення з Form4
                textBox1.Text = form4.Information;
            }
        }
    }
}
