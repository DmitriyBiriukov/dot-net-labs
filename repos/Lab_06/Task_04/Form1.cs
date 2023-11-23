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
            // ��������������� ����������� ���� ���� �����������
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
            // ���������, ������� �� ���� �� ����������� � �������� �� 1 �� 4
            bool citySelected = radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked;

            // ���������, ������� �� ���� �� ����������� � �������� �� 6 �� 8
            bool transportSelected = radioButton6.Checked || radioButton7.Checked || radioButton8.Checked;

            // ���� ���� �� ����������� � �������� �� 1 �� 4 � ���� �� ����������� � �������� �� 6 �� 8 �������,
            // ������� ��������� "������� �� �����"
            if (citySelected && transportSelected)
            {
                MessageBox.Show("������� �� �����!");
            }
            else
            {
                // ����� ������� ��������� "�������� ����� � ���������"
                MessageBox.Show("�������� ����� � ���������", "��������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // �������� ���� ���� ����������� �� ������ �� ���������
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
