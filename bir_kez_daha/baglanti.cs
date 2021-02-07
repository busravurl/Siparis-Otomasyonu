using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace bir_kez_daha
{
   public class baglanti
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-BKRH9DR;Initial Catalog=Sipariş_otomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
