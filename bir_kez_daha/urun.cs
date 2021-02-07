using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace bir_kez_daha
{
   public class urun
    {
        public int agirlik { get; set; }
        public int fiyat { get; set; }
        public string urun_adi { get; set; }
        public string tur { get; set; }
        public int stok { get; set; }
        public string id { get; set; }
        baglanti connect = new baglanti();
        public void Urun()
        {
            SqlCommand Ekle = new SqlCommand("insert into Sipariş_otomasyon.dbo.Items(ItemName,description,shippingWeight,price,stock) values (@ItemName,@description,@shippingWeight,@price,@stock)", connect.Baglanti());
            Ekle.Parameters.AddWithValue("@ItemName", urun_adi);
            Ekle.Parameters.AddWithValue("@description", tur);
            Ekle.Parameters.AddWithValue("@shippingWeight",agirlik );
            Ekle.Parameters.AddWithValue("@price", fiyat);
            Ekle.Parameters.AddWithValue("@stock", stok);
            Ekle.ExecuteNonQuery();
            connect.Baglanti().Close();

        }
      
            
        

        public void UrunGüncelle()
        {

            SqlCommand Ekle = new SqlCommand("update Items set ItemName=@ItemName,description=@description,shippingWeight=@shippingWeight,price=@price,stock=@stock where ItemId=@ItemId", connect.Baglanti());
            Ekle.Parameters.AddWithValue("@ItemName", urun_adi);
            Ekle.Parameters.AddWithValue("@description", tur);
            Ekle.Parameters.AddWithValue("@shippingWeight", agirlik);
            Ekle.Parameters.AddWithValue("@price", fiyat);
            Ekle.Parameters.AddWithValue("@stock", stok);
            Ekle.Parameters.AddWithValue("@ItemId", id);
            Ekle.ExecuteNonQuery();
            connect.Baglanti().Close();
        }
        
         
        



    }
    
}
