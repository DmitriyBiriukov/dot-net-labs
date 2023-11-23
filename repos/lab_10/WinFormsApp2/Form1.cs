using System.Windows.Forms;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        private int seconds = 0;
        private bool isRunning = false;

        public Form1()
        {
            InitializeComponent();
            // Налаштування таймера
            timer.Interval = 1000; // Оновлення кожну секунду
            timer.Tick += Timer_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                button1.Text = "Стоп";
                int minutes = (int)numericUpDown1.Value;
                int seconds = (int)numericUpDown2.Value;

                // Обчислення загального часу в секундах
                this.seconds = minutes * 60 + seconds;
                timer.Start();
            }
            else
            {
                isRunning = false;
                button1.Text = "Старт";
                timer.Stop();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTimerDisplay();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds % 5 == 0)
            {
                ChangeFormBackgroundColor();
            }

            UpdateTimerDisplay();
        }

        private void UpdateTimerDisplay()
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            label1.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void ChangeFormBackgroundColor()
        {
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            panel1.BackColor = randomColor;
        }
    }
}