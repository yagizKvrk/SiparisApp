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
    public partial class UrunlerForm : Form
    {
        public UrunlerForm(KafeVeri veri)
        {
            InitializeComponent();
            db = veri;
            dataGridView1.DataSource = db.Urunler;
        }

        KafeVeri db;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUrunAdi.Text.Trim()))
            {
                MessageBox.Show("Ürün adını girin.");
            }
            else if(numericUpDown1.Value == 0)
            {
                DialogResult dr =  MessageBox.Show("Ürün fiyatını 0 girdiniz. Emin misiniz?","Uyarı!", MessageBoxButtons.YesNo);

                if(dr == DialogResult.Yes)
                {
                    UrunKaydet();
                }
            }
            else
            {
                UrunKaydet();
            }
        }

        void UrunKaydet()
        {
            Urun u = new Urun();
            u.UrunAd = txtUrunAdi.Text.Trim();
            u.BirimFiyat = numericUpDown1.Value;

            try
            {
                db.Urunler.Add(u);
                MessageBox.Show("Ürün Kaydedildi");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = db.Urunler;

                txtUrunAdi.Text = "";
                numericUpDown1.Value = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu.");
            }

            
        }
    }
}
