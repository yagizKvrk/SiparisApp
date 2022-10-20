using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisApp.Data
{
    public class Siparis
    {
        public int MasaNo { get; set; }

        //TODO
//#warning odenenTutar sipariş detaylarından hesaplanıp otomatik yazılacak

        public decimal OdenecekTutar 
        {
            get
            {
                //1.yol
                return SiparisDetaylari.Sum(x => x.Tutar);
                //decimal toplamTutar = 0;
                //foreach (var item in SiparisDetaylari)
                //{
                //    toplamTutar += item.Tutar;
                //}
                //return toplamTutar;
            }
        }
        public SiparisDurum SipDurumu { get; set; }
        public DateTime AcilisZamani { get; set; } = DateTime.Now;
        public DateTime? KapanisZamani { get; set; }
        public List<SiparisDetay> SiparisDetaylari { get; set; } = new List<SiparisDetay>();
    }

    public enum SiparisDurum
    {
        [Display(Name = "Aktif")]
        Aktif,
        [Display(Name = "Ödendi")]
        Odendi,
        [Display(Name = "İptal")]
        Iptal
    }
}
