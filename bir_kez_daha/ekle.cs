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
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }
        urun urun = new urun();
        private void button1_Click(object sender, EventArgs e)
        {
            urun.urun_adi = maskedTextBox1.Text;
            urun.agirlik = Convert.ToInt32(textBox2.Text.ToString());
            urun.tur = textBox1.Text;
            urun.fiyat = Convert.ToInt32(textBox3.Text.ToString());
            urun.stok = Convert.ToInt32(textBox4.Text.ToString());

            urun.Urun();
            MessageBox.Show("Ürün Eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
