
using Newtonsoft.Json;
using SiparisApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VerileriOku();
            MasalariOlustur();
        }

        KafeVeri db = new KafeVeri();

        private void tsmUrunler_Click(object sender, EventArgs e)
        {
            UrunlerForm frm = new UrunlerForm(db);
            frm.Show();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = listView1.SelectedItems[0];
            //lvi.tag masa numarası.
            int secilenMasaNo = (int)lvi.Tag;
            

            //Masa boşsa
            Siparis sip = db.AktifSiparisler.FirstOrDefault(item => item.MasaNo == secilenMasaNo);

            if(sip == null)//Masa Boş
            {
                sip = new Siparis();
                sip.MasaNo = secilenMasaNo;
                sip.SipDurumu = SiparisDurum.Aktif;

                db.AktifSiparisler.Add(sip);
                lvi.ImageKey = "dolu2.png";
            }

            frmSiparis frm = new frmSiparis(db, sip, lvi, this);
            frm.Show();
        }

        void MasalariOlustur()
        {
            for (int i = 1; i <= db.MasaAdet; i++)
            { 
                ListViewItem lvi = new ListViewItem();
                lvi.ImageKey = db.AktifSiparisler.Any(x => x.MasaNo == i) ? "Dolu2.png" : "bos2.png";
                lvi.Text = "Masa " + i.ToString();
                lvi.Tag = i;
                listView1.Items.Add(lvi);
            }
        }

        void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                db = JsonConvert.DeserializeObject<KafeVeri>(json);
            }
            catch (Exception)
            {
                db = new KafeVeri();
            }
        }

        void VerileriKaydet()
        {
            string json = JsonConvert.SerializeObject(db);
            File.WriteAllText("veri.json", json);
        }
    }
}
