namespace Task_12
{
    public partial class Form1 : Form
    {
        private bool isTimerRunning = false;
        private int timerInterval = 500;
        private bool isStateA = true;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isTimerRunning)
            {
                timer1.Stop();
                isTimerRunning = false;
                button1.Text = "��������� ������";
            }
            else
            {
                timer1.Start();
                isTimerRunning = true;
                button1.Text = "�������� ������";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int newInterval) && newInterval > 0)
            {
                timer1.Interval = newInterval;
                timerInterval = newInterval;
                textBox1.Text = timerInterval.ToString();
            }
            else
            {
                MessageBox.Show("������ ��������� �������� ��� ������� (���� ����� ����� 0).");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ���� ����� �� ��������� �����
            if (isStateA)
            {
                Text = "���� A";
            }
            else
            {
                Text = "���� B";
            }

            // ���������� ����
            isStateA = !isStateA;
        }
    }
}