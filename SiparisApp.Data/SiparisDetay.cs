using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisApp.Data
{
    public class SiparisDetay
    {
        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public bool IkramMi { get; set; }
        public decimal Tutar 
        {
            get
            {
                if (IkramMi)
                    return 0;
                return Adet * BirimFiyat;
            }
        }


    }
}
