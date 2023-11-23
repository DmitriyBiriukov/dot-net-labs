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
            // Создаем новый экземпляр Form2
            Form2 form2 = new Form2();

            // Открываем Form2 как диалоговое окно
            DialogResult result = form2.ShowDialog();

            // После закрытия Form2 проверяем результат
            if (result == DialogResult.OK)
            {
                // Получаем результаты из Form2
                double perimeter = form2.Perimeter;
                double area = form2.Area;

                // Выводим результаты на метки на Form1
                label4.Text = $"Периметр: {perimeter}";
                label5.Text = $"Площадь: {area}";
            }
        }
    }
}