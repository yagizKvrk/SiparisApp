using SiparisApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisApp
{
    public partial class frmSiparis : Form
    {
        public frmSiparis(KafeVeri veri, Siparis sip, ListViewItem lvi, Form1 f)
        {
            InitializeComponent();
            db = veri;
            s = sip;
            lv = lvi;
            frm = f;
        }
        Form1 frm;
        ListViewItem lv;
        Siparis s;
        KafeVeri db;

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < db.MasaAdet; i++)
            {
                if(i != s.MasaNo && !db.AktifSiparisler.Any(item => item.MasaNo == i))
                comboBox1.Items.Add(i);               
            }
            lblMasaNo.Text = s.MasaNo < 10 ? "0" + s.MasaNo.ToString() : s.MasaNo.ToString();

            this.Text = "Masa " + s.MasaNo.ToString();

            comboBox1.DataSource = db.Urunler;

            dataGridView1.DataSource = s.SiparisDetaylari;
            lblOdemeTutari.Text = s.OdenecekTutar.ToString() + " ₺";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1 || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Seçim Yapınız.");
            }
            else
            {
                SiparisDetay sip = new SiparisDetay();
                Urun u = (Urun)comboBox1.SelectedItem;

                sip.UrunAdi = u.UrunAd;
                sip.BirimFiyat = u.BirimFiyat;
                sip.Adet = Convert.ToInt32(numericUpDown1.Value);
                sip.IkramMi = checkBox1.Checked;

                s.SiparisDetaylari.Add(sip);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = s.SiparisDetaylari;

                lblOdemeTutari.Text = s.OdenecekTutar.ToString() + " ₺";
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if(s.OdenecekTutar > 0)
            {
                s.SiparisDetaylari = new List<SiparisDetay>();
            }

            decimal odenecekTutar = s.OdenecekTutar;
            SiparisiKapat(SiparisDurum.Iptal);
            this.Close();
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            SiparisiKapat(SiparisDurum.Odendi);
            this.Close();
        }

        void SiparisiKapat(SiparisDurum sipDurum)
        {
            s.KapanisZamani = DateTime.Now;
            s.SipDurumu = sipDurum;

            db.AktifSiparisler.Remove(s);
            db.GecmisSiparisler.Add(s);

            lv.ImageKey = "bos2.png";

        }

        private void btnAnaSayfaDon_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void frmSiparis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (s.SiparisDetaylari.Count == 0)
                SiparisiKapat(SiparisDurum.Iptal);
        }

        private void btnTasi_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;

            int eskiMasa = s.MasaNo;
            int yeniMasa = (int)comboBox1.SelectedItem;

            this.Text = "Masa " + yeniMasa;
            lblMasaNo.Text = s.MasaNo < 10 ? "0" + yeniMasa.ToString() : yeniMasa.ToString();
            s.MasaNo = yeniMasa;

            lv.ImageKey = "bos2.png";

            foreach (ListViewItem item in frm.listView1.Items)
            {
               if((int)item.Tag == yeniMasa)
                {
                    item.ImageKey = "dolu2.png";
                }
            } 
            
        }
    }
}
