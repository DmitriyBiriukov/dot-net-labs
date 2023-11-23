using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_05
{
    public partial class Form2 : Form
    {
        public string SelectedItem { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (SelectedItem == "1. Єрусалим")
            {
                label1.Text = "Єрусалим";
                pictureBox1.Image = Properties.Resources.Image1; // Замените "Image1" на имя вашего изображения в ресурсах
                label2.Text = "Єрусалим є столицею та найбільш священним місцем для трьох основних світових релігій - юдаїзму, християнства та ісламу. Місто багате історією та культурою, його старовинний центр включений до списку Світової спадщини ЮНЕСКО.";
            }
            else if (SelectedItem == "2. Тель-Авів")
            {
                label1.Text = "Тель-Авів";
                pictureBox1.Image = Properties.Resources.Image2; // Замените "Image2" на имя вашего изображения в ресурсах
                label2.Text = "Тель-Авів вважається економічним і культурним центром Ізраїлю, відомим своїми сучасними хмарами і великою кількістю пляжів. Місто славиться своєю динамічною атмосферою, модними кафе і нічним життям.";
            }
            else if (SelectedItem == "3. Хайфа")
            {
                label1.Text = "Хайфа";
                pictureBox1.Image = Properties.Resources.Image3; // Замените "Image2" на имя вашего изображения в ресурсах
                label2.Text = "Розташована на узбережжі Середземного моря, Хайфа є важливим портом та індустріальним центром. Місто також славиться Багдадським садом, який є одним із найкрасивіших садів у світі.";
            }
            else if (SelectedItem == "4. Беер-Шева")
            {
                label1.Text = "Беер-Шева";
                pictureBox1.Image = Properties.Resources.Image4; // Замените "Image2" на имя вашего изображения в ресурсах
                label2.Text = "Розташована в південній частині країни, Беер-Шева відома своєю історією, що налічує тисячоліття. Місто є важливим центром для інновацій та технологічного розвитку.";
            }
            else if (SelectedItem == "5. Іерихон")
            {
                label1.Text = "Іерихон";
                pictureBox1.Image = Properties.Resources.Image5; // Замените "Image2" на имя вашего изображения в ресурсах
                label2.Text = "Як одне з найстаріших міст у світі, Іерихон розташований в долині ріки Йордан. Він відомий своєю археологічною спадщиною і красивими оазисами.";
            }
            else if (SelectedItem == "6. Нетанья")
            {
                label1.Text = "Нетанья";
                pictureBox1.Image = Properties.Resources.Image6; // Замените "Image2" на имя вашего изображения в ресурсах
                label2.Text = "Розташована на узбережжі Середземного моря, Нетанья є популярним курортним містом, відомим своїми пляжами, кафе та розвагами.";
            }
            else if (SelectedItem == "7. Ашдод")
            {
                label1.Text = "Ашдод";
                pictureBox1.Image = Properties.Resources.Image7; // Замените "Image2" на имя вашего изображения в ресурсах
                label2.Text = "Ашдод - важливий портовий місто, розташоване на узбережжі Середземного моря. Місто має історію, яка налічує тисячоліття, і є важливим торговим та промисловим центром.";
            }
        }
    }
}
