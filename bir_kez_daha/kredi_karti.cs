using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bir_kez_daha
{
   public class kredi_karti :odeme_class
    {
        public long tutar { get; set; }
        public override long Toplam()
        {
            return tutar;
        }
        public override int OdemeYontemi()
        {
            return 1;
        }
        public string KartNo { get; set; }
        public string Kartisim { get; set; }
        public int KartAy { get; set; }
        public int Kartyil { get; set; }
        public int cvc { get; set; }
    
    
    }
    
}
