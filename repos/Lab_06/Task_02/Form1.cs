namespace Task_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Добавляем Label
            Label label = new Label();
            label.Text = "7 міст Ізраїлю";
            label.Font = new System.Drawing.Font("Arial", 25);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Size = new System.Drawing.Size(769, 98);
            label.Location = new System.Drawing.Point(414, 53);
            this.Controls.Add(label);

            // Добавляем ComboBox
            ComboBox comboBox = new ComboBox();
            comboBox.Size = new System.Drawing.Size(242, 40);
            comboBox.Location = new System.Drawing.Point(912, 297);
            comboBox.Items.AddRange(new string[] { "Єрусалим", "Тель-Авів", "Хайфа", "Ашдод", "Беер-Шева", "Нетанья", "Ейлат" });
            this.Controls.Add(comboBox);

            // Добавляем ListBox
            ListBox listBox = new ListBox();
            listBox.Size = new System.Drawing.Size(246, 132);
            listBox.Location = new System.Drawing.Point(414, 240);
            listBox.Items.AddRange(new string[] { "Єрусалим", "Тель-Авів", "Хайфа", "Ашдод", "Беер-Шева", "Нетанья", "Ейлат" });
            this.Controls.Add(listBox);
        }
    }
}