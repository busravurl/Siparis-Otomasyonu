using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bir_kez_daha
{
    public partial class kayit_ol : Form
    {
        public kayit_ol()
        {
            InitializeComponent();
        }
        musteri musteri = new musteri();
        private void button1_Click(object sender, EventArgs e)
        {
            musteri.ad_soyad = textBox1.Text;
            musteri.kullanici_adi = textBox2.Text;
            musteri.sifre = textBox3.Text;
            musteri.adres = textBox4.Text;
            
            musteri.KisiEkle();
            MessageBox.Show("Yeni Üye Eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
