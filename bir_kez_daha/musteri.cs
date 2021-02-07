using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bir_kez_daha
{
    public class musteri
    {
        public string ad_soyad { get; set; }
        public string kullanici_adi { get; set; }
        public string sifre { get; set; }
        public string adres { get; set; }
        
        baglanti connect = new baglanti();

        public void KisiEkle()
        {
            SqlCommand Ekle = new SqlCommand("insert into Sipariş_otomasyon.dbo.Customers(Name,NickName,CustomerPassword,Adress) values (@Name,@NickName,@CustomerPassword,@Adress)", connect.Baglanti());
            Ekle.Parameters.AddWithValue("@Name", ad_soyad);
            Ekle.Parameters.AddWithValue("@NickName", kullanici_adi);
            Ekle.Parameters.AddWithValue("@CustomerPassword", sifre);
            Ekle.Parameters.AddWithValue("@Adress", adres);
            Ekle.ExecuteNonQuery();
            connect.Baglanti().Close();

        }
    }
}
