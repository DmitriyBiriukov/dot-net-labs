using Microsoft.VisualBasic.ApplicationServices;

namespace Task_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            item12ToolStripMenuItem.Click += Form1_Load;
            item12ToolStripMenuItem1.Click += Form1_Load;
            item21ToolStripMenuItem.Click += Form1_Load;
            item22ToolStripMenuItem.Click += Form1_Load;
            item231ToolStripMenuItem.Click += Form1_Load;
            item232ToolStripMenuItem.Click += Form1_Load;
            item233ToolStripMenuItem.Click += Form1_Load;
            item234ToolStripMenuItem.Click += Form1_Load;
            item31ToolStripMenuItem.Click += Form1_Load;
            item32ToolStripMenuItem.Click += Form1_Load;
            item33ToolStripMenuItem.Click += Form1_Load;
            item34ToolStripMenuItem.Click += Form1_Load;
            item321ToolStripMenuItem.Click += Form1_Load;
            item322ToolStripMenuItem.Click += Form1_Load;
            item323ToolStripMenuItem.Click += Form1_Load;
            item324ToolStripMenuItem.Click += Form1_Load;
            item41ToolStripMenuItem.Click += Form1_Load;
            item42ToolStripMenuItem.Click += Form1_Load;
            item44ToolStripMenuItem.Click += Form1_Load;
            item45ToolStripMenuItem.Click += Form1_Load;
            item431ToolStripMenuItem.Click += Form1_Load;
            item432ToolStripMenuItem.Click += Form1_Load;
            item433ToolStripMenuItem.Click += Form1_Load;
            item434ToolStripMenuItem.Click += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Получаем имя выбранного пункта меню
            var menuItem = (ToolStripMenuItem)sender;
            string menuItemName = menuItem.Text;

            // Определяем раздел меню, к которому принадлежит выбранный пункт
            string sectionName = "";

            if (menuItem == item12ToolStripMenuItem1 || menuItem == item12ToolStripMenuItem)
            {
                sectionName = "Раздел 1";
            }
            else if (menuItem == item21ToolStripMenuItem || menuItem == item22ToolStripMenuItem || menuItem == item231ToolStripMenuItem || menuItem == item232ToolStripMenuItem || menuItem == item233ToolStripMenuItem || menuItem == item234ToolStripMenuItem)
            {
                sectionName = "Раздел 2";
            }
            else if (menuItem == item31ToolStripMenuItem || menuItem == item32ToolStripMenuItem || menuItem == item33ToolStripMenuItem || menuItem == item34ToolStripMenuItem || menuItem == item321ToolStripMenuItem || menuItem == item322ToolStripMenuItem || menuItem == item323ToolStripMenuItem || menuItem == item324ToolStripMenuItem)
            {
                sectionName = "Раздел 3";
            }
            else if (menuItem == item41ToolStripMenuItem || menuItem == item42ToolStripMenuItem || menuItem == item44ToolStripMenuItem || menuItem == item45ToolStripMenuItem || menuItem == item431ToolStripMenuItem || menuItem == item432ToolStripMenuItem || menuItem == item433ToolStripMenuItem || menuItem == item434ToolStripMenuItem)
            {
                sectionName = "Раздел 4";
            }

            // Выводим сообщение с названием раздела
            MessageBox.Show("Выбран пункт: " + menuItemName + "\nИз раздела: " + sectionName);
        }
    }
}