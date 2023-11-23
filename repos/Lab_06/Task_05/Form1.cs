namespace Task_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = false;

            // Восстанавливаем стандартный цвет фона чекбоксов
            checkBox1.BackColor = SystemColors.Control;
            checkBox2.BackColor = SystemColors.Control;
            checkBox3.BackColor = SystemColors.Control;
            checkBox4.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли хотя бы один из чекбоксов
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked)
            {
                if (checkBox1.Checked)
                    checkBox1.BackColor = Color.Yellow;
                else
                    checkBox1.BackColor = SystemColors.Control;

                if (checkBox2.Checked)
                    checkBox2.BackColor = Color.Purple;
                else
                    checkBox2.BackColor = SystemColors.Control;

                if (checkBox3.Checked)
                    checkBox3.BackColor = Color.Green;
                else
                    checkBox3.BackColor = SystemColors.Control;

                if (checkBox4.Checked)
                    checkBox4.BackColor = Color.Pink;
                else
                    checkBox4.BackColor = SystemColors.Control;

                MessageBox.Show("Спасибо за выбор!");
            }
            else
            {
                MessageBox.Show("Выберите хотя бы одно увлечение", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
