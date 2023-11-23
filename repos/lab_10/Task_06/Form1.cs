using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_06
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int seconds;
        private bool isRunning;
        private Color[] backgroundColors = { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange };
        private int colorIndex;
        private Label timerLabel; // Додано Label для відображення секундоміра

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // Одиниця вимірювання - секунда
            timer.Tick += timer_Tick;

            button1.Click += button1_Click;
            button1.Text = "Start";
            isRunning = false;

            colorIndex = 0;
            ChangeBackgroundColor();

            // Ініціалізуємо Label для відображення секундоміра
            timerLabel = new Label();
            timerLabel.Location = new Point(10, 10);
            timerLabel.AutoSize = true;
            Controls.Add(timerLabel);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            timerLabel.Text = TimeSpan.FromSeconds(seconds).ToString(@"mm\:ss");

            if (seconds % 5 == 0)
            {
                ChangeBackgroundColor();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer.Stop();
                button1.Text = "Start";
            }
            else
            {
                timer.Start();
                button1.Text = "Stop";
            }

            isRunning = !isRunning;
        }

        private void ChangeBackgroundColor()
        {
            this.BackColor = backgroundColors[colorIndex];
            colorIndex = (colorIndex + 1) % backgroundColors.Length;
        }
    }
}
