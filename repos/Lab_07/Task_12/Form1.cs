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
            // Отримуємо обране місто з ComboBox
            string selectedCity = comboBox1.SelectedItem.ToString();

            // Виводимо обране місто в MsgBox
            MessageBox.Show("Обране місто: " + selectedCity, "Інформація");
        }
    }
}