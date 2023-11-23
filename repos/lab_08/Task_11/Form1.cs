namespace Task_11
{
    public partial class Form1 : Form
    {

        private bool isStateA = true;
        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Зміна стану та заголовка форми
            if (isStateA)
            {
                Text = "Стан A";
            }
            else
            {
                Text = "Стан B";
            }

            // Перемикаємо стан
            isStateA = !isStateA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Запускаємо або зупиняємо таймер при кожному натисканні кнопки
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
    }
}