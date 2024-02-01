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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace market_otomasyonu
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        Repository repository = new Repository();
        Kontrol kontrol = new Kontrol();
        private void Users_Load(object sender, EventArgs e)
        {
            kullaniciGetir();
            bolgeGetir();
            yetkiGetir();
            guvenliksorusuGetir();
        }
        private void kullaniciGetir()
        {
            List<User> list =  kontrol.kullaniciGetir();
            dataGridView_users.DataSource = list;
        }

        private void bolgeGetir ()
        {
            List<string> list = repository.bolgeGetir();

            foreach(string bolge in list)
            {
                comboBox_bolge.Items.Add(bolge);
            }
            comboBox_bolge.SelectedIndex = 0;
           
        }

        private void yetkiGetir()
        {
            comboBox_yetki.Items.Add("admin");
            comboBox_yetki.Items.Add("kasiyer");
            comboBox_yetki.SelectedIndex = 0;
        }

        private void guvenliksorusuGetir () 
        {
            List<string> listguvenliksorusu = repository.guvenliksorusuGetir();
            foreach( string guvenliksorusu in listguvenliksorusu)
            {
                comboBox_guvenliksorusu.Items.Add(guvenliksorusu);
            }
            comboBox_guvenliksorusu.SelectedIndex = 0;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void textboxTemizle()
        {
            for (int i = 0; i < groupBox_users.Controls.Count; i++)
            {
                if (groupBox_users.Controls[i] is TextBox)
                {
                    groupBox_users.Controls[i].Text = string.Empty;
                }
            }
        }
        public User kullanicibilgileri()
        {
            User user = new User();
            user.id= int.Parse(dataGridView_users.SelectedCells[0].Value.ToString());
            user.kullaniciadi = txt_kullaniciadi.Text;
            user.sifre = txt_sifre.Text;
            user.email = txt_email.Text;
            user.yetki = comboBox_yetki.SelectedItem.ToString();
            user.bolge = comboBox_bolge.SelectedItem.ToString();   
            user.guvenlikSorusu = comboBox_guvenliksorusu.SelectedItem.ToString();
            user.guvenlikCevabi = txt_guvenlikCevabi.Text;
            return user;
        }
        public void textleriDoldur()
        {
           // txt_id.Text = dataGridView_users.SelectedCells[0].Value.ToString();
            txt_kullaniciadi.Text = dataGridView_users.CurrentRow.Cells[1].Value.ToString();
            txt_sifre.Text = dataGridView_users.CurrentRow.Cells[2].Value.ToString();
            comboBox_yetki.Text = dataGridView_users.CurrentRow.Cells[3].Value.ToString();
            comboBox_bolge.Text = dataGridView_users.CurrentRow.Cells[4].Value.ToString();
            txt_email.Text= dataGridView_users.CurrentRow.Cells[5].Value.ToString();
            comboBox_guvenliksorusu.Text = dataGridView_users.CurrentRow.Cells[6].Value.ToString();
            txt_guvenlikCevabi.Text = dataGridView_users.CurrentRow.Cells[7].Value.ToString();

        }

        private void dataGridView_users_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textleriDoldur();
        }

        private void btn_kullaniciekle_Click(object sender, EventArgs e)
        {
            LoginStatus result = kontrol.kullaniciEkle(kullanicibilgileri());
            if (result == LoginStatus.basarili)
            {
                MessageBox.Show("Kullanıcı başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_users.DataSource = kontrol.kullaniciGetir();
                textboxTemizle();
            }
            else
            {
                MessageBox.Show("Gerekli alanların hepsini doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_kullaniciguncelle_Click(object sender, EventArgs e)
        {
            LoginStatus result = kontrol.kullaniciGuncelle(kullanicibilgileri());
            if (result == LoginStatus.basarili)
            {
                MessageBox.Show("Kullanıcı başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_users.DataSource = kontrol.kullaniciGetir();
                textboxTemizle();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_kullanicisil_Click(object sender, EventArgs e)
        {
            LoginStatus result = kontrol.kullaniciSil(kullanicibilgileri());
            if (result == LoginStatus.basarili)
            {
                MessageBox.Show("Kullanıcı başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_users.DataSource = kontrol.kullaniciGetir();
                textboxTemizle();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







    }
}
