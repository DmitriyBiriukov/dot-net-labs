namespace Task_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // �������� ������ ���� � ComboBox
            string selectedCity = comboBox1.SelectedItem.ToString();

            // �������� ������ ���� � MsgBox
            MessageBox.Show("������ ����: " + selectedCity, "����������");
        }
    }
}