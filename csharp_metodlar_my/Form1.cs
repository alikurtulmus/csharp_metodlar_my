using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_metodlar_my
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //metodlar global alana yazılır. kod tekrarını önlemek adına diğer kapsamların da içinde kullanılır.
        //metodun public ya da private olarak belirlemezsek program otomatik olarak private olarak belirler.
        
        //GERİYE DEĞER DÖNDÜRMEYEN METODLAR

        //geriye herhangi bir değer döndürmeyen metodlar void kullanılarak oluşturulur.

        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus(); //işlem tamamlandıktan sonra imleci texbox1'e getirmesini istedik
        }

        void renklendir()
        {
            textBox1.BackColor=Color.Green;
            textBox2.BackColor = Color.BlueViolet;
            textBox3.BackColor = Color.YellowGreen;
            textBox4.BackColor = Color.Yellow;

        }
      
        void doldur()
        {
            textBox5.Text = textBox4.Text;
            textBox6.Text = textBox3.Text;
            textBox7.Text = textBox2.Text;
            textBox8.Text = textBox1.Text;
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doldur();
        }

    

        //GERİYE DEĞER DÖNDÜREN METODLAR

        //geriye değer döndüren metodlarla değişkenin türünü tanımlamak yeterli olacaktır.

       
        int topla(int s1, int s2)
        {
            int toplam = s1 + s2;
            textBox11.Text = toplam.ToString();

            return toplam; //geriye döndürülen değer "toplam" değişkeni oldu
        }

        int cikar(int s1, int s2)
        {
            int fark = s1 - s2;
            textBox11.Text = fark.ToString();
            return fark;
            
        }
        int carp(int s1, int s2)
        {
            int carpim = s1 * s2;
            textBox11.Text = carpim.ToString();
            return carpim;
                  }
        double bol(double s1, double s2)
        {
            double bolum = s1 / s2;
            textBox11.Text = bolum.ToString();
            return bolum;
        }
        
        
        private void button4_Click(object sender, EventArgs e)
        {
            topla(Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cikar(Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            carp(Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bol(Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox10.Text));
           
        }
    }
}
