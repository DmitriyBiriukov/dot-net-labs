namespace Task__01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ��������, ��� ��� ������ TextBox'� ���������
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                // ���� �� TextBox'�� ����, ������ ���������
                MessageBox.Show("������� ��� ������!", "��������",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // ��������� ������ ����� ���� ��� ��������� �����
                textBox1.BackColor = Color.Yellow; // ���������� �����
                textBox2.BackColor = Color.Green; // ���������� �����
                textBox3.BackColor = Color.Blue; //���������� �����
                textBox4.BackColor = Color.Red; // ���������� ����

                // ������������ ��������� �� �������� ��������
                MessageBox.Show("������ ����������! �������)");

                // �� ������ �������� ����� �� ����� ������ �� ������ ������
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.BackColor = SystemColors.Window;
            textBox2.BackColor = SystemColors.Window;
            textBox3.BackColor = SystemColors.Window;
            textBox4.BackColor = SystemColors.Window;
        }
    }
}