using market_otomasyonu.dao;
using market_otomasyonu.enumaration;
using market_otomasyonu.kontrol;
using market_otomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace market_otomasyonu
{
    public partial class MailSifreDegistirme : Form
    {

        public string kullaniciadi_mail;
        int code;
        public MailSifreDegistirme()
        {
            InitializeComponent();    
        } 
        private void MailSifreDegistirme_Load(object sender, EventArgs e)
        {

        }

        private void lbl_girissayfasi_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_dogrulamakodu_Click(object sender, EventArgs e)
        {
            try
            {
                Kontrol kontrol =new Kontrol();
                SifreDegistirme sifreDegistirme = new SifreDegistirme();
                LoginStatus result = kontrol.checkEmail(kullaniciadi_mail);
                if (result == LoginStatus.basarili)
                {
                    Repository repository = new Repository();
                    string email = repository.checkEmail(kullaniciadi_mail);
                    if (email.ToString().Trim().Equals(txt_mail.Text.Trim(), StringComparison.OrdinalIgnoreCase))//trimle boşluklar ihmal edilecek
                    {

                        Random random = new Random();
                        code = random.Next(111111, 999999);

                        SmtpClient sc = new SmtpClient();
                        sc.Port = 587;
                        sc.Host = "smtp-mail.outlook.com";
                        sc.EnableSsl = true;

                        MailAddress mailAlan = new MailAddress(txt_mail.Text);
                        MailAddress mailGönderen = new MailAddress("iremarass1@outlook.com", "İrem Aras");
                        MailMessage message = new MailMessage();

                        message.To.Add(mailAlan);
                        message.From = mailGönderen;
                        message.Subject = "Şifre Değiştirme";
                        message.Body = "Şifrenizi değiştirmek için doğrulama kodunuz: " + code;

                        sc.Credentials = new System.Net.NetworkCredential("iremarass1@outlook.com", "266632iA"); // maili gönderenin kullanıcı adı ve şifresi
                        sc.Send(message);
                        MessageBox.Show("Doğrulama kodunuz gönderildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adınız ya da email adresiniz yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Kullanıcı adınız ya da email adresiniz yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            if (txt_dogrulamakodu.Text == code.ToString())
            {
                SifreDegistirme sifreDegistirme = new SifreDegistirme();
                YeniSifre yenisifre = new YeniSifre();
                yenisifre.kullaniciAdi = kullaniciadi_mail;  // Set the username
                yenisifre.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış kod girdiniz!","Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_mail.Text = string.Empty;
            }
        }
    }
}
