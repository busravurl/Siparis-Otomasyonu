using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace bir_kez_daha
{
    public class giris_servisi
    {
        public bool KullaniciUyeDogrula(string kullaniciAdi, string sifre)
        {
            baglanti connect = new baglanti();

            SqlCommand komut = new SqlCommand("Select * From Customers where NickName =@NickName and CustomerPassword = @CustomerPassword", connect.Baglanti());
            komut.Parameters.AddWithValue("@NickName", kullaniciAdi);
            komut.Parameters.AddWithValue("@CustomerPassword", sifre);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool YoneticiDogrula(string kullaniciAdi, string sifre)
        {
            baglanti connect = new baglanti();

            SqlCommand komut = new SqlCommand("Select * From Managers where ManagerId =@ManagerId and ManagerPassword = @ManagerPassword", connect.Baglanti());
            komut.Parameters.AddWithValue("@ManagerId", kullaniciAdi);
            komut.Parameters.AddWithValue("@ManagerPassword", sifre);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}