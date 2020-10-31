using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_AuliyaUswatunKhasanah_027
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void jumlah_Click(object sender, EventArgs e)
        {
            

            
        }

        private void kurang_Click(object sender, EventArgs e)
        {
            
            
        }

        private void kali_Click(object sender, EventArgs e)
        {
            
        }

        private void bagi_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hasil;

            hasil = Convert.ToInt32(angka1.Text) + Convert.ToInt32(angka2.Text);
            jumlah.Text = hasil.ToString();

            hasil = Convert.ToInt32(angka1.Text) - Convert.ToInt32(angka2.Text);
            kurang.Text = hasil.ToString();

            hasil = Convert.ToInt32(angka1.Text) * Convert.ToInt32(angka2.Text);
            kali.Text = hasil.ToString();

            hasil = Convert.ToInt32(angka1.Text) / Convert.ToInt32(angka2.Text);
            bagi.Text = hasil.ToString();
        }
    }
}
