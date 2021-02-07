using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bir_kez_daha
{
    public class cek:odeme_class
    {
        public long tutar { get; set; }
        public override long Toplam()
        {
            return tutar;
        }
        public override int OdemeYontemi()
        {
            return 3;
        }
        public string ad { get; set; }
        public string bankaId { get; set; }
    }
}
