using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bir_kez_daha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbmusteri.Checked == true)
            {
                giris_servisi giris = new giris_servisi();
                bool kontrol = giris.KullaniciUyeDogrula(txtkullanici.Text, txtsifre.Text);
                if (kontrol == true)
                {
                    anasayfa ana = new anasayfa();
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Sifre!");
                }
            }
            else if (rdbyonetici.Checked == true)
            {
                giris_servisi giris = new giris_servisi();
                bool kontrol = giris.YoneticiDogrula(txtkullanici.Text, txtsifre.Text);
                if (kontrol == true)
                {
                    yönetici yon = new yönetici();
                    yon.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Sifre!");
                }
            }
            else
            {
                MessageBox.Show("Giris Tipinizi Seçiniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayit_ol kayit = new kayit_ol();
            kayit.Show();
            Form1 giris = new Form1();
            giris.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtsifre.PasswordChar = '\0';
            }
            else
            {
                txtsifre.PasswordChar = '*'; 
            }
        }
    }
}
