using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sürükle_Bırak
{
    public partial class Form1 : Form
    {
        bool durum = false;

        Point ilkkonum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            durum = true;
            button1.Cursor = Cursors.SizeAll;
            ilkkonum = e.Location;

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (durum)
            {
                 button1.Left = e.X + button1.Left - (ilkkonum.X); // button.lef ile soldan uzaklığını ayarlıyoruz. Yani e.X dediğimizde buton üzerinde mouseun hareket ettiği pixeli alacağız + butonun soldan uzaklığını ekliyoruz son olarakta ilk mouseın tıklandığı alanı çıkarıyoruz yoksa butonun en solunda olur mouse imleci. Alttakide aynı şekilde Y koordinati için geçerli ,
                button1.Top = e.Y + button1.Top - (ilkkonum.Y); // burada button.height/2 dediğimizde tam y eksenine ortalı şekilde butonu tutar.
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            durum = false;
            button1.Cursor = Cursors.Default;
        }
    }
}
