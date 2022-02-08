//перевод изображения в ч/б
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OpenFileDialog qq = new OpenFileDialog();
            qq.Filter = "image|*.png;*.jpg;*.jpeg;*.bmp";
            if (qq.ShowDialog() == DialogResult.OK)
            {
                Form2 pictures = new Form2(qq.FileName);
                pictures.MdiParent = this;                          //создание дочернего окна и отправка туда картинки
                pictures.Show();
            }
        }
    }
}
