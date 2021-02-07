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
    public partial class güncelle_sil : Form
    {
        public güncelle_sil()
        {
            InitializeComponent();

        }
        static string conString = @"Data Source=DESKTOP-BKRH9DR;Initial Catalog=Sipariş_otomasyon;Integrated Security=True";
        SqlConnection bag = new SqlConnection(conString);
        baglanti baglanti= new baglanti();
        private void güncelle_sil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sipariş_otomasyonDataSet1.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.sipariş_otomasyonDataSet1.Items);

        }
        urun urun = new urun();
     


        private void button3_Click(object sender, EventArgs e)
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
                ItemName.Text = dr["ItemName"].ToString();
                description.Text = dr["description"].ToString();
                shippingWeight.Text = dr["shippingWeight"].ToString();
                stock.Text = dr["stock"].ToString();
                price.Text = dr["price"].ToString();


            }
            else
                MessageBox.Show("Müşteri Bulunamadı.");
            bag.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            urun.urun_adi = ItemName.Text;
            urun.agirlik = Convert.ToInt32(shippingWeight.Text.ToString());
            urun.tur = description.Text;
            urun.fiyat = Convert.ToInt32(price.Text.ToString());
            urun.stok =Convert.ToInt32( stock.Text.ToString());
            urun.id = textBox1.Text;

            urun.UrunGüncelle();
            MessageBox.Show("Ürün Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bag.Open();


            DialogResult durum = MessageBox.Show(" Ürünü Silmek istediğinizden Emin Misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);


            if (DialogResult.Yes == durum)
            {
                string silmeSorgusu = "DELETE from Items where ItemId=@ItemId";

                SqlCommand silKomutu = new SqlCommand(silmeSorgusu, bag);
                silKomutu.Parameters.AddWithValue("@ItemId", textBox1.Text);
                silKomutu.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi...");

                bag.Close();
                this.Close();
               
            }
        }
    }
}
