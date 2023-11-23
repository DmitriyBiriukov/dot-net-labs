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
                // Установите значения других свойств, если необходимо
                // form2.AdditionalData = "Дополнительная информация";
                form2.Show();
            }
            else
            {
                MessageBox.Show("Выберите элемент в comboBox1", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}