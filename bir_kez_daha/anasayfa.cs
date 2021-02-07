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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sipariş_otomasyonDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.sipariş_otomasyonDataSet.Items);

        }
        baglanti connect = new baglanti();

        static string conString = @"Data Source=DESKTOP-BKRH9DR;Initial Catalog=Sipariş_otomasyon;Integrated Security=True";
        SqlConnection bag = new SqlConnection(conString);

        private void button1_Click(object sender, EventArgs e)
        {

            bag.Open();

            siparis siparis = new siparis();


            siparis.miktar = Convert.ToInt32(textBox2.Text.ToString());
            siparis.id = textBox1.Text;
            siparis.agirlik = Convert.ToInt32(textBox3.Text.ToString());
            siparis.fiyat = Convert.ToInt32(textBox4.Text.ToString());

            SqlCommand eksilt = new SqlCommand("update  Items set stock-= @miktar where ItemId=@ItemId", bag);

            eksilt.Parameters.AddWithValue("@ItemId", textBox1.Text);
            eksilt.Parameters.AddWithValue("@miktar", siparis.miktar);
            eksilt.ExecuteNonQuery();

            odeme odeme = new odeme();
            odeme.Show();
            bag.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bag.Open();


            string kayit = "SELECT * from Items where ItemId=@ItemId";

            SqlCommand komut = new SqlCommand(kayit, bag);
            komut.Parameters.AddWithValue("@ItemId", textBox1.Text);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["ItemId"].ToString();

                textBox4.Text = dr["shippingWeight"].ToString();

                textBox3.Text = dr["price"].ToString();
            }
            else
                MessageBox.Show("ürün Bulunamadı.");


            int s1, s2;
            s1 = Convert.ToInt32(textBox2.Text);
            s2 = Convert.ToInt32(textBox3.Text);
            label5.Text = "Toplam Fiyat=" + s1 * s2;

            int s3, s4;
            s3 = Convert.ToInt32(textBox2.Text);
            s4 = Convert.ToInt32(textBox4.Text);
            label6.Text = "Toplam Ağırlık=" + s3 * s4;



            // label5.Text = Convert.ToInt32(label4.Text.ToString()) *Convert.ToInt32( label3.Text.ToString());













            bag.Close();

            button1.Show();

        }
    }
}
