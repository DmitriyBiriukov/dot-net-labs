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
            // ��������� � ������������ TableLayoutPanel
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill; // �������� ���� ��������� �����
            tableLayoutPanel.RowCount = 1; // ���� �����
            tableLayoutPanel.ColumnCount = 5; // 5 ��������
            tableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;

            // ������������ ������ ��������
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));

            // ��������� TableLayoutPanel �� �����
            this.Controls.Add(tableLayoutPanel);

            // ��������� ������ �� TableLayoutPanel
            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                button.Text = "������ " + (i + 1);

                // ������������ ������ ������
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

                // ³������������ ������
                button.Anchor = AnchorStyles.None;

                tableLayoutPanel.Controls.Add(button);
            }
        }


    }
}