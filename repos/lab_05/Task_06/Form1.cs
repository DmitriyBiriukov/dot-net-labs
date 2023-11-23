using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Путь к изображениям
            string[] imagePaths = new string[]
            {
                "\\\\Mac\\Home\\Desktop\\khpi\\5семестр\\DOT.NET\\imgs\\photo1.jpg",
                "\\\\Mac\\Home\\Desktop\\khpi\\5семестр\\DOT.NET\\imgs\\photo2.jpg",
                "\\\\Mac\\Home\\Desktop\\khpi\\5семестр\\DOT.NET\\imgs\\photo3.jpg",
                "\\\\Mac\\Home\\Desktop\\khpi\\5семестр\\DOT.NET\\imgs\\photo4.jpg",
                "\\\\Mac\\Home\\Desktop\\khpi\\5семестр\\DOT.NET\\imgs\\photo5.jpg"
            };

            // Создаем и настраиваем PictureBox'ы программно
            for (int i = 0; i < Math.Min(imagePaths.Length, 5); i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(56 + i * 366, 152);
                pictureBox.Size = new Size(308, 281 - i * 39); // Adjust the height as needed
                pictureBox.Image = Image.FromFile(imagePaths[i]);
                this.Controls.Add(pictureBox); // Добавляем PictureBox на форму
            }
        }
    }
}
