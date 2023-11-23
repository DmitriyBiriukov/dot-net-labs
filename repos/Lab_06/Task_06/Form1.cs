namespace Task_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            comboBox1.Text = "";
            comboBox2.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем TextBox'ы с 1 по 5
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем ComboBox'ы с 1 по 2
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем RadioButton'ы с 1 по 4
            if (!(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked))
            {
                MessageBox.Show("Введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем RadioButton'ы с 5 по 6
            if (!(radioButton5.Checked || radioButton6.Checked))
            {
                MessageBox.Show("Введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создайте строку, в которой будет храниться сообщение
            string message = $" {groupBox1.Text}:\n {label2.Text}: {textBox1.Text}\n{label3.Text}: {textBox2.Text} \n{label4.Text}: {textBox3.Text}\n{label5.Text}: {textBox4.Text}\n {groupBox2.Text}:\n {label6.Text}: {comboBox1.Text}\n {label7.Text}: {comboBox2.Text}\n {label8.Text}: {textBox5.Text} \n";

            // Создайте переменные для хранения текста выбранных радиокнопок
            string selectedRadioButtonTextPanel1 = "";
            string selectedRadioButtonTextPanel2 = "";

            // Проверьте выбранные RadioButton на panel1 и присвойте их текст переменной
            if (radioButton1.Checked) selectedRadioButtonTextPanel1 = radioButton1.Text;
            if (radioButton2.Checked) selectedRadioButtonTextPanel1 = radioButton2.Text;
            if (radioButton3.Checked) selectedRadioButtonTextPanel1 = radioButton3.Text;
            if (radioButton4.Checked) selectedRadioButtonTextPanel1 = radioButton4.Text;

            // Проверьте выбранные RadioButton на panel2 и присвойте их текст переменной
            if (radioButton5.Checked) selectedRadioButtonTextPanel2 = radioButton5.Text;
            if (radioButton6.Checked) selectedRadioButtonTextPanel2 = radioButton6.Text;

            // Добавьте текст выбранных RadioButton к вашей строке message
            if (!string.IsNullOrEmpty(selectedRadioButtonTextPanel1))
            {
                message += $" {groupBox3.Text}: {selectedRadioButtonTextPanel1}\n";
            }

            if (!string.IsNullOrEmpty(selectedRadioButtonTextPanel2))
            {
                message += $" {label9.Text}: {selectedRadioButtonTextPanel2}\n";
            }


            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}