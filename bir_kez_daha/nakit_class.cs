using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bir_kez_daha
{
    public class nakit_class:odeme_class
    {
        public long tutar { get; set; }
        public override long Toplam()
        {
            return tutar;
        }
        public override int OdemeYontemi()
        {
            return 2;
        }
        public string ad_soyad { get; set; }


    }
}
