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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            Kontrol kontrol = new Kontrol();
                User result =  kontrol.login(txt_kullaniciadi.Text,txt_sifre.Text);

            if(result!= null && result.status == LoginStatus.basarili && result.yetki.Trim() == "admin")
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();
            }
            else if (result!=null && result.status==LoginStatus.basarili && result.yetki.Trim() == "kasiyer")
            {
                KasiyerPanel meyveSebzePanel = new KasiyerPanel();
                meyveSebzePanel.Show();
                this.Hide();
            }
            else if (result != null && result.status == LoginStatus.basarisiz)
            {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata",MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else
            {
                MessageBox.Show("Eksik bilgi girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void lbl_sifremiunuttum_Click(object sender, EventArgs e)
        {
            SifreDegistirme sifreDegistirme = new SifreDegistirme();
            sifreDegistirme.Show();
            this.Hide();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Çıkış yapmak mı istiyorsunuz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(DialogResult == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
