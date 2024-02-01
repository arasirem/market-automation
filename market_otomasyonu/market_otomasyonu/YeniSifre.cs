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
    public partial class YeniSifre : Form
    {
        public string kullaniciAdi { get; set; } //class seviyesinde kullanıcıadı tanımladım ve
                                                 //yenisifre sayfası açılmadan mailsifredeg formundaki txtkullaniciadi'na atadım
        public YeniSifre()
        {
            InitializeComponent();
        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            Kontrol kontrol = new Kontrol();
            Form1 form1 = new Form1();
            if(txt_yenisifre.Text == txt_yenisifretkr.Text )
            {
                LoginStatus result =  kontrol.changepassword(kullaniciAdi, txt_yenisifre.Text);
                if(result == LoginStatus.basarili)
                {
                    MessageBox.Show("Şifreniz başarıyla değiştirildi", "Bilgilendirme", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Eksik bilgi girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("İki şifre birbirinden farklı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_yenisifre.Text = string.Empty;
                txt_yenisifretkr.Text = string.Empty;
            }
        }
    }
}
