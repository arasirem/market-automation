using market_otomasyonu.enumaration;
using market_otomasyonu.kontrol;
using market_otomasyonu.model;
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
    public partial class SifreDegistirme : Form
    {       
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {
            Kontrol kontrol = new Kontrol();
            List<loginTable> loginTableList = kontrol.getLoginTable();
            
            foreach (loginTable loginTable in loginTableList)
            {
                comboBox1.Items.Add(loginTable.guvenlikSorusu.ToString());
            }

            comboBox1.SelectedIndex = 0;
            
        }

        private void btn_sorgula_Click(object sender, EventArgs e)
        {
            Kontrol kontrol = new Kontrol();
            LoginStatus result = kontrol.doAuthentication(txt_kullaniciadi.Text.ToLower(), comboBox1.SelectedItem.ToString(), txt_guvenlikcevabi.Text.ToLower());
            if(result==LoginStatus.basarili)
            {
                MailSifreDegistirme mailSifreDegistirme = new MailSifreDegistirme();
                mailSifreDegistirme.kullaniciadi_mail = txt_kullaniciadi.Text;
                mailSifreDegistirme.Show();
                this.Hide();
            }
            else if(result==LoginStatus.basarisiz)
            {
                MessageBox.Show("Girdiğiniz bilgiler hatalıdır!","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_kullaniciadi.Text=string.Empty;
                txt_guvenlikcevabi.Text=string.Empty;
            }
            else
            {
                MessageBox.Show("Eksik bilgi girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_kullaniciadi.Text = string.Empty;
                txt_guvenlikcevabi.Text = string.Empty;
            }
        }

        private void lbl_girissayfasi_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

    }
}
