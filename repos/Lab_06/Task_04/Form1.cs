namespace Task_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Восстанавливаем стандартный цвет фона радиокнопок
            radioButton1.BackColor = SystemColors.Control;
            radioButton2.BackColor = SystemColors.Control;
            radioButton3.BackColor = SystemColors.Control;
            radioButton4.BackColor = SystemColors.Control;

            radioButton6.BackColor = SystemColors.Control;
            radioButton7.BackColor = SystemColors.Control;
            radioButton8.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли одна из радиокнопок с номерами от 1 до 4
            bool citySelected = radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked;

            // Проверяем, выбрана ли одна из радиокнопок с номерами от 6 до 8
            bool transportSelected = radioButton6.Checked || radioButton7.Checked || radioButton8.Checked;

            // Если одна из радиокнопок с номерами от 1 до 4 и одна из радиокнопок с номерами от 6 до 8 выбраны,
            // выводим сообщение "Спасибо за выбор"
            if (citySelected && transportSelected)
            {
                MessageBox.Show("Спасибо за выбор!");
            }
            else
            {
                // Иначе выводим сообщение "Выберите город и транспорт"
                MessageBox.Show("Выберите город и транспорт", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Изменяем цвет фона радиокнопок на основе их состояния
            radioButton1.BackColor = radioButton1.Checked ? Color.Yellow : SystemColors.Control;
            radioButton2.BackColor = radioButton2.Checked ? Color.Yellow : SystemColors.Control;
            radioButton3.BackColor = radioButton3.Checked ? Color.Yellow : SystemColors.Control;
            radioButton4.BackColor = radioButton4.Checked ? Color.Yellow : SystemColors.Control;

            radioButton6.BackColor = radioButton6.Checked ? Color.Green : SystemColors.Control;
            radioButton7.BackColor = radioButton7.Checked ? Color.Green : SystemColors.Control;
            radioButton8.BackColor = radioButton8.Checked ? Color.Green : SystemColors.Control;
        }
    }
}
