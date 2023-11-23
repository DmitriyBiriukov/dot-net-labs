namespace Task_03_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // ������� ����� ��������� Form2
            Form2 form2 = new Form2();

            // ��������� Form2 ��� ���������� ����
            DialogResult result = form2.ShowDialog();

            // ����� �������� Form2 ��������� ���������
            if (result == DialogResult.OK)
            {
                // �������� ���������� �� Form2
                double resultValue = form2.Result;

                // ������� ��������� �� ����� �� Form1
                label4.Text = $"��������� ���������: {resultValue}";
            }
        }
    }
}