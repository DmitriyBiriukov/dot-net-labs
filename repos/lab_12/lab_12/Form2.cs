using lab_12;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка пароля
            if (textBox3.Text == textBox4.Text)
            {

                string userFilePath = @"C:\Users\dmitriybirukov\source\repos\lab_12\lab_12\data.txt";
                using (StreamWriter writer = new StreamWriter(userFilePath, true))
                {
                    writer.WriteLine($"{textBox1.Text},{textBox2.Text},{textBox3.Text}");
                }

                // Переход на Form4
                Form4 form4 = new Form4(textBox1.Text, textBox2.Text, textBox3.Text);
                this.Hide();
                form4.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Переход на Form3
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
    }
}
