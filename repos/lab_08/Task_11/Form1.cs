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

        private void button1_Click(object sender, EventArgs e)
        {
            // ��������� ��� ��������� ������ ��� ������� ��������� ������
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