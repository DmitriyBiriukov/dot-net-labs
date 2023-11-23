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
                timer.Start();
                button1.Enabled = false;
                button2.Enabled = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                isRunning = false;
                timer.Stop();
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }
    }
}