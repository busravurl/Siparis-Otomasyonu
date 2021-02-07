using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace bir_kez_daha
{
    public class siparis
    {
        public string id { get; set; }
        public int miktar { get; set; }
        public DateTime tarih { get; set; }
        public string durum { get; set; }
        public int toplam_fiyat { get; set; }
        public int toplam_agirlik { get; set; }
        public int agirlik { get; set; }
        public int fiyat { get; set; }
        

        baglanti connect = new baglanti();
       
            
            
        
          
        public void SiparisEkle()
        {
            urun urun = new urun();
           

            SqlCommand Ekle = new SqlCommand("insert into Sipariş_otomasyon.dbo.Orders(ItemId,piece,OrderDate,shippingWeight,price) values (@ItemId,@piece,@OrderDate,@shippingWeight,@price)", connect.Baglanti());
            string tarih = Convert.ToString(DateTime.Now);
            Ekle.Parameters.AddWithValue("@ItemId", id);
            Ekle.Parameters.AddWithValue("@piece", miktar);
            Ekle.Parameters.AddWithValue("@OrderDate", DateTime.Parse(tarih));
            Ekle.Parameters.AddWithValue("@shippingWeight",agirlik);
            Ekle.Parameters.AddWithValue("@price", fiyat);



            Ekle.ExecuteNonQuery();
            connect.Baglanti().Close();

        }

        


    }
}
