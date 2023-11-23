namespace Task_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox2.Items.Add("Expert PC Ultimate");
            comboBox2.Items.Add("Cobra Advanced");
            comboBox2.Items.Add("Apple iMac");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBox2.SelectedItem.ToString();

            if (selectedOption == "Expert PC Ultimate")
            {
                pictureBox1.Image = Properties.Resources.image1;
            }
            else if (selectedOption == "Cobra Advanced")
            {
                pictureBox1.Image = Properties.Resources.image2;
            }
            else if (selectedOption == "Apple iMac")
            {
                pictureBox1.Image = Properties.Resources.image3;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = comboBox1.SelectedIndex >= 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0)
            {
                int quantity = int.Parse(comboBox1.SelectedItem.ToString());
                int price = 0;

                // Вместо RadioButton теперь используйте comboBox2 для выбора изображения
                string selectedImage = comboBox2.SelectedItem.ToString();

                // Здесь вы можете установить цену на основе выбранного изображения
                if (selectedImage == "Expert PC Ultimate")
                {
                    price = 15000;
                }
                else if (selectedImage == "Cobra Advanced")
                {
                    price = 13000;
                }
                else if (selectedImage == "Apple iMac")
                {
                    price = 25000;
                }

                int total = quantity * price;
                label3.Text = total + " UAH";
            }
        }
    }
}