namespace Task_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Form2 form2 = new Form2();
                form2.SelectedItem = comboBox1.SelectedItem.ToString();
                // ���������� �������� ������ �������, ���� ����������
                // form2.AdditionalData = "�������������� ����������";
                form2.Show();
            }
            else
            {
                MessageBox.Show("�������� ������� � comboBox1", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}