namespace Task_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Створення і налаштування TableLayoutPanel
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill; // Заповнює весь контейнер форми
            tableLayoutPanel.RowCount = 1; // Один рядок
            tableLayoutPanel.ColumnCount = 5; // 5 стовпців
            tableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;

            // Встановлення розмірів стовпців
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));

            // Додавання TableLayoutPanel до форми
            this.Controls.Add(tableLayoutPanel);

            // Додавання кнопок до TableLayoutPanel
            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                button.Text = "Кнопка " + (i + 1);

                // Налаштування розмірів кнопок
                if (i == 0 || i == 4)
                {
                    button.Width = 358;
                    button.Height = 452;
                }
                else if (i == 1 || i == 3)
                {
                    button.Width = 270;
                    button.Height = 350;
                }
                else if (i == 2)
                {
                    button.Width = 224;
                    button.Height = 231;
                }

                // Відцентрування кнопок
                button.Anchor = AnchorStyles.None;

                tableLayoutPanel.Controls.Add(button);
            }
        }


    }
}