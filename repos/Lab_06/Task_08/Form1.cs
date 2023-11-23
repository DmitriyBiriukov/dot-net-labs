using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Привязываем один и тот же ContextMenuStrip ко всем Label.
            label1.ContextMenuStrip = contextMenuStrip1;
            label2.ContextMenuStrip = contextMenuStrip1;
            label3.ContextMenuStrip = contextMenuStrip1;

            // Добавляем обработчики событий для всех пунктов меню.
            foreach (ToolStripMenuItem item in contextMenuStrip1.Items)
            {
                item.Click += ContextMenuItem_Click;
            }
        }

        private void ChangeLabelColor(Label label, Color color)
        {
            label.BackColor = color;
        }

        private void ContextMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            if (menuItem != null)
            {
                ContextMenuStrip contextMenu = menuItem.GetCurrentParent() as ContextMenuStrip;
                Label label = contextMenu.SourceControl as Label;

                if (label != null)
                {
                    // Визначаємо колір залежно від вибраного пункту меню.
                    if (menuItem == item1ToolStripMenuItem)
                    {
                        ChangeLabelColor(label, Color.Green);
                    }
                    else if (menuItem == item2ToolStripMenuItem)
                    {
                        ChangeLabelColor(label, Color.Yellow);
                    }
                    else if (menuItem == item3ToolStripMenuItem)
                    {
                        ChangeLabelColor(label, Color.Red);
                    }
                    else if (menuItem == item4ToolStripMenuItem)
                    {
                        // Додайте логіку для item4
                        ChangeLabelColor(label, Color.Blue);
                    }
                }
            }
        }

    }
}
