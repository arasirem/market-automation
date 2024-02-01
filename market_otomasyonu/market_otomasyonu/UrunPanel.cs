using market_otomasyonu.enumaration;
using market_otomasyonu.kontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_otomasyonu
{
    public partial class UrunPanel : Form
    {
        public UrunPanel()
        {
            InitializeComponent();
        }
        
        Kontrol kontrol = new Kontrol();

        private void UrunPanel_Load(object sender, EventArgs e)
        {
            UrunGetir();
        }

        private void UrunGetir()
        {
            dataGridView_urun.DataSource = kontrol.TumUrunGetir();
        }

        private Urunler UrunBilgileri()
        {
            Urunler urunler = new Urunler();
            urunler.id = txt_id.Text;
            urunler.qrkod=txt_qrkod.Text;
            urunler.barkodKod = txt_barkod.Text;
            urunler.olusturmaTarihi = DateTime.Parse(dateTime_olusturma.Text);
            urunler.guncellenmetarihi = DateTime.Parse(dateTime_guncelleme.Text);
            urunler.urunismi = txt_urunismi.Text;
            if(!string.IsNullOrEmpty(txt_fiyat.Text) || !string.IsNullOrEmpty(txt_kilo.Text) || !string.IsNullOrEmpty(txt_ciro.Text))
            {
                urunler.fiyat = float.Parse(txt_fiyat.Text);
                urunler.kilo = float.Parse(txt_kilo.Text);
                urunler.ciro = float.Parse(txt_ciro.Text);
            }     
            return urunler;
        }


        private void textleriDoldur()
        {
            txt_id.Text = dataGridView_urun.CurrentRow.Cells[0].Value.ToString();
            txt_qrkod.Text = dataGridView_urun.CurrentRow.Cells[1].Value.ToString();
            txt_barkod.Text = dataGridView_urun.CurrentRow.Cells[2].Value.ToString();
            dateTime_olusturma.Value = DateTime.Parse(dataGridView_urun.CurrentRow.Cells[3].Value.ToString());
            dateTime_guncelleme.Value = DateTime.Parse(dataGridView_urun.CurrentRow.Cells[4].Value.ToString());
            txt_urunismi.Text = dataGridView_urun.CurrentRow.Cells[5].Value.ToString();
            txt_kilo.Text = dataGridView_urun.CurrentRow.Cells[6].Value.ToString();
            txt_fiyat.Text = dataGridView_urun.CurrentRow.Cells[7].Value.ToString();
            txt_ciro.Text = dataGridView_urun.CurrentRow.Cells[8].Value.ToString();

        }


        private void btn_urunekle_Click(object sender, EventArgs e)
        {
            LoginStatus result = kontrol.UrunEkle(UrunBilgileri());
            if (result == LoginStatus.basarili)
            {
                MessageBox.Show("Ürün başarıyla eklendi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information );
                dataGridView_urun.DataSource = kontrol.TumUrunGetir();
            }
            else if (result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Ürün eklenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gerekli tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void dataGridView_urun_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textleriDoldur();
        }

        private void btn_urunguncelle_Click(object sender, EventArgs e)
        {
            LoginStatus result = kontrol.UrunGuncelle(UrunBilgileri());
            if (result == LoginStatus.basarili)
            {
                MessageBox.Show("Ürün başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_urun.DataSource = kontrol.TumUrunGetir();
            }
            else if (result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Ürün güncellenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gerekli tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_urunsil_Click(object sender, EventArgs e)
        {
            LoginStatus result = kontrol.UrunSil(UrunBilgileri());
            if (result == LoginStatus.basarili)
            {
                MessageBox.Show("Ürün başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_urun.DataSource = kontrol.TumUrunGetir();
            }
            else if (result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Ürün silinirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gerekli tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
