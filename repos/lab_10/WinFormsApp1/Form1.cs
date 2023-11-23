using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<string> photoPaths;
        private int currentPhotoIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Открываем диалоговое окно выбора папки для фотографий
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем список файлов из выбранной папки
                string selectedFolderPath = folderDialog.SelectedPath;
                string[] photoFiles = Directory.GetFiles(selectedFolderPath, "*.png"); // Можно изменить расширения файлов по вашему усмотрению

                // Загружаем список фотографий
                photoPaths = new List<string>(photoFiles);
                currentPhotoIndex = 0;

                if (photoPaths.Count > 0)
                {
                    DisplayCurrentPhoto();
                }
                else
                {
                    MessageBox.Show("В выбранной папке нет фотографий.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (photoPaths != null && photoPaths.Count > 0)
            {
                currentPhotoIndex = (currentPhotoIndex + 1) % photoPaths.Count;
                DisplayCurrentPhoto();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (photoPaths != null && photoPaths.Count > 0)
            {
                currentPhotoIndex = (currentPhotoIndex - 1 + photoPaths.Count) % photoPaths.Count;
                DisplayCurrentPhoto();
            }
        }

        private void DisplayCurrentPhoto()
        {
            if (photoPaths != null && photoPaths.Count > 0)
            {
                string currentPhotoPath = photoPaths[currentPhotoIndex];
                pictureBox1.Image = new System.Drawing.Bitmap(currentPhotoPath);
            }
        }
    }
}
