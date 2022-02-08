//перевод изображения в ч/б
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2(string filename)
        {            
            InitializeComponent();
            double brightness;
            pictureBox1.Image = Image.FromFile(filename);
            Bitmap bmp = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);          
            for(int i=0; i<bmp.Height; i++)
            {
                for (int j = 0; j<bmp.Width;j++)
                {
                    var pixel = bmp.GetPixel(j, i);                     
                    brightness = 0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B;                       // вычисление яркости пикселя
                    bmp.SetPixel(j, i, Color.FromArgb((int)brightness, (int)brightness, (int)brightness));
                }
                progressBar1.Value++;
            }
            pictureBox2.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog qq = new SaveFileDialog();
            qq.Filter = "png|*.png|jpg|*.jpg|jpeg|*.jpeg|bmp|*.bmp";
            if(qq.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(qq.FileName);                        //сохранение измененной картинки
            }
        }
    }
}
