using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Task_8
{
    public partial class Form1 : Form
    {
        private TextBox textBox;
        private string currentFilePath;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Створення основного вікна
            this.Text = "Text Editor";
            this.Size = new Size(800, 600);

            // Створення текстового поля
            textBox = new TextBox();
            textBox.Dock = DockStyle.Fill;
            textBox.Multiline = true;
            textBox.ScrollBars = ScrollBars.Both;
            this.Controls.Add(textBox);

            // Створення меню
            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
            ToolStripMenuItem editMenu = new ToolStripMenuItem("Edit");
            ToolStripMenuItem helpMenu = new ToolStripMenuItem("Help");

            // Додаємо елементи меню "File"
            ToolStripMenuItem newFileMenuItem = new ToolStripMenuItem("New");
            newFileMenuItem.Click += NewFileMenuItem_Click;
            fileMenu.DropDownItems.Add(newFileMenuItem);

            ToolStripMenuItem openFileMenuItem = new ToolStripMenuItem("Open");
            openFileMenuItem.Click += OpenFileMenuItem_Click;
            fileMenu.DropDownItems.Add(openFileMenuItem);

            ToolStripMenuItem saveFileMenuItem = new ToolStripMenuItem("Save");
            saveFileMenuItem.Click += SaveFileMenuItem_Click;
            fileMenu.DropDownItems.Add(saveFileMenuItem);

            // Додаємо елементи меню "Edit"
            ToolStripMenuItem fontColorMenuItem = new ToolStripMenuItem("Font Color");
            fontColorMenuItem.Click += FontColorMenuItem_Click;
            editMenu.DropDownItems.Add(fontColorMenuItem);

            ToolStripMenuItem currentPositionMenuItem = new ToolStripMenuItem("Current Position");
            currentPositionMenuItem.Click += CurrentPositionMenuItem_Click;
            editMenu.DropDownItems.Add(currentPositionMenuItem);

            // Додаємо елементи меню "Help"
            ToolStripMenuItem aboutMenuItem = new ToolStripMenuItem("About");
            aboutMenuItem.Click += AboutMenuItem_Click;
            helpMenu.DropDownItems.Add(aboutMenuItem);

            // Додаємо всі меню до основного меню
            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(editMenu);
            menuStrip.Items.Add(helpMenu);

            // Додаємо меню до форми
            this.Controls.Add(menuStrip);
        }

        private void NewFileMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            currentFilePath = null;
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                textBox.Text = File.ReadAllText(currentFilePath);
            }
        }

        private void SaveFileMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFilePath == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                }
                else
                {
                    return; // Відмінено користувачем
                }
            }
            File.WriteAllText(currentFilePath, textBox.Text);
        }

        private void FontColorMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = colorDialog.Color;
            }
        }

        private void CurrentPositionMenuItem_Click(object sender, EventArgs e)
        {
            int currentPosition = textBox.SelectionStart;
            int currentLine = textBox.GetLineFromCharIndex(currentPosition);
            int currentColumn = currentPosition - textBox.GetFirstCharIndexFromLine(currentLine);

            MessageBox.Show($"Current Position: Line {currentLine + 1}, Column {currentColumn + 1}", "Current Position");
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text Editor\n\nDeveloped by Dmytro Biriukov", "About");
        }
    }
}
