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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_kullanici_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_urunler_Click(object sender, EventArgs e)
        {
           UrunPanel urunPanel = new UrunPanel();
            urunPanel.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hour.Text = DateTime.Now.Hour.ToString() + ": ";
            lbl_min.Text = DateTime.Now.Minute.ToString() + ":";
            lbl_second.Text = DateTime.Now.Second.ToString();
        }
    }
}
