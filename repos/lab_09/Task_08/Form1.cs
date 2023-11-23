using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_08
{
    public partial class Form1 : Form
    {
        private int selectedPrice = 0; // Переменная для хранения выбранной цены

        public Form1()
        {
            InitializeComponent();
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
                int total = selectedPrice * quantity;
                label3.Text = total + " UAH";

                // Добавление скидки, если количество больше 5
                if (quantity > 5)
                {
                    double discount = 0.15; // 15% скидка
                    double discountedTotal = total - (total * discount);
                    label4.Text = "Оптова ціна: " + discountedTotal + " UAH";
                }
                else
                {
                    label4.Text = ""; // Очистить label4, если скидка не применяется
                }
            }
        }



        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                selectedPrice = 15000;
                pictureBox1.Image = Properties.Resources.image1;
            }
            else if (radioButton2.Checked)
            {
                selectedPrice = 13000;
                pictureBox1.Image = Properties.Resources.image2;
            }
            else if (radioButton3.Checked)
            {
                selectedPrice = 25000;
                pictureBox1.Image = Properties.Resources.image3;
            }
        }
    }
}
