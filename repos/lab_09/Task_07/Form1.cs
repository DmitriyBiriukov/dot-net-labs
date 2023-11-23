using System;
using System.Windows.Forms;

namespace Task_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Image = Properties.Resources.image1; // Замените на реальное имя вашей картинки
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBox1.Image = Properties.Resources.image2; // Замените на реальное имя вашей картинки
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                pictureBox1.Image = Properties.Resources.image3; // Замените на реальное имя вашей картинки
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = comboBox1.SelectedIndex >= 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                int quantity = int.Parse(comboBox1.SelectedItem.ToString());
                int price = 0;

                if (radioButton1.Checked)
                {
                    price = 15000;
                }
                else if (radioButton2.Checked)
                {
                    price = 13000;
                }
                else if (radioButton3.Checked)
                {
                    price = 25000;
                }

                int total = quantity * price;
                label3.Text = total + " UAH";
            }
        }
    }
}
