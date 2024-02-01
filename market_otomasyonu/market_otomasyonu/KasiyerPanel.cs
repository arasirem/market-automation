using AForge.Video.DirectShow;
using market_otomasyonu.kontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace market_otomasyonu
{
    public partial class KasiyerPanel : Form
    {
        //2. sayıyı yazmazsa oluşan hatayı düzelt 
        //eşittir tuşuna basınca düzelt

        double sayi1;
        double sayi2;
        string islemtipi;
        public KasiyerPanel()
        {
            InitializeComponent();
        }

        private void btn_anamenu_Click(object sender, EventArgs e)
        {
            Form1 form1=new Form1();
            form1.Show();
            this.Hide();
        }

        FilterInfoCollection fic;
        VideoCaptureDevice vcd;

        private void KasiyerPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
            txt_islem.Text = "0";

            groupBox_meyvesebzeurunleri.Visible = true;
            groupBox1.Visible=false;
            groupBox_etTavuk.Visible = false;
            groupBox_bakliyat.Visible = false;

            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice); //cihaza bağlı kameraları aldı fic'te topladı

            foreach (FilterInfo camera in fic)
            {
                comboBox_kameraac.Items.Add(camera.Name);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hour.Text = DateTime.Now.Hour.ToString() + ": ";
            lbl_min.Text = DateTime.Now.Minute.ToString() + ": ";
            lbl_second.Text = DateTime.Now.Second.ToString();

            try
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox_kamera.Image);

                if (result != null)
                {
                    txt_barkod.Text = result.Text;
                    timer1.Stop();
                    barcod_okuma();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error decoding barcode: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           



        }

        private void secilentus(object sender, EventArgs e)
        {
            if (txt_islem.Text.Contains(",") && ((Button)sender).Text == ",")
            {
                
            }

            if (txt_islem.Text == "0")
            {
                if (((Button)sender).Text != "0" && ((Button)sender).Text != ",")
                {
                    txt_islem.Text = "";
                }
                else if (((Button)sender).Text == "0")
                {
                    return;
                }
            }

            if (((Button)sender).Text == "," && !txt_islem.Text.Contains(","))
            {
                txt_islem.Text += ((Button)sender).Text;
            }
            else if (((Button)sender).Text != ",")
            {
                txt_islem.Text += ((Button)sender).Text;
            }





        }


        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_islem.Clear();
            txt_islem.Text = "0";
        }

        private void btn_toplama_Click(object sender, EventArgs e)
        {
            islemtipi = "+";
            sayi1 = double.Parse(txt_islem.Text);
            txt_islem.Text = "";
        }

        private void btn_cikarma_Click(object sender, EventArgs e)
        {
            islemtipi = "-";
            sayi1 = double.Parse(txt_islem.Text);
            txt_islem.Text = "";

        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            islemtipi = "*";
            sayi1 = double.Parse(txt_islem.Text);
            txt_islem.Text = "";

        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            islemtipi = "/";
            sayi1 = double.Parse(txt_islem.Text);
            txt_islem.Text = "";

        }

       

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_islem.Text))
            {
                sayi2 = double.Parse(txt_islem.Text);
            }
            else
            {
                sayi2 = 0;
            }

            if (islemtipi == "+")
            {
                txt_islem.Text = (sayi1+sayi2).ToString();
            }
            else if (islemtipi == "-")
            {
                txt_islem.Text = (sayi1 - sayi2).ToString();
            }
            else if (islemtipi == "*")
            {
                txt_islem.Text = (sayi1 * sayi2).ToString();
            }
            else if (islemtipi == "/")
            {
                if(sayi2!=0)
                {
                    txt_islem.Text = (sayi1 / sayi2).ToString();
                }
                else
                {
                    txt_islem.Text = "HATA";
                }
            }
            else 
            {
            }
        }

        private void btn_sil_Click_1(object sender, EventArgs e)
        {
            if (txt_islem.Text.Length != 1 && txt_islem.Text != "0")
            {
                txt_islem.Text = txt_islem.Text.Substring(0, txt_islem.Text.Length - 1);
            }
            else
            {
                txt_islem.Text = "0";
            }
        }

        private void btn_kameraac_Click(object sender, EventArgs e)
        {
            if (comboBox_kameraac.SelectedIndex >= 0)
            {
                vcd = new VideoCaptureDevice(fic[comboBox_kameraac.SelectedIndex].MonikerString); //fic içindeki seçilen kamera
                vcd.NewFrame += Vcd_NewFrame; //vcd.NewFrame += tab yapınca otomotik newframe metodları yüklenir
                vcd.Start();
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Lütfen bir kamera seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox_kamera.Image = (Bitmap)eventArgs.Frame.Clone(); //framei klonlayıp pictureboxta kamerayı aç
        }

        private void btn_kamerakapat_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            pictureBox_kamera.Image = Image.FromFile(@"C:\Users\tilve\OneDrive\Resimler\depositphotos_274938238-stock-illustration-abstract-color-camera.jpg");
        }

        private void pictureBox_suturunleri_Click(object sender, EventArgs e)
        {
            groupBox_meyvesebzeurunleri.Visible = false;
            groupBox_etTavuk.Visible = false;
            groupBox_bakliyat.Visible = false;
            groupBox1.Visible = true;
        }

        private void pictureBox_meyvesebze_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox_etTavuk.Visible = false;
            groupBox_bakliyat.Visible = false;
            groupBox_meyvesebzeurunleri.Visible = true;
        }

        private void pictureBox_etTavuk_Click(object sender, EventArgs e)
        {
            groupBox_meyvesebzeurunleri.Visible = false;
            groupBox1.Visible = false;
            groupBox_bakliyat.Visible = false;
            groupBox_etTavuk.Visible = true;
        }

        private void pictureBox_bakliyat_Click(object sender, EventArgs e)
        {
            groupBox_meyvesebzeurunleri.Visible = false;
            groupBox1.Visible = false;
            groupBox_etTavuk.Visible = false;
            groupBox_bakliyat.Visible = true;
        }

        private void txt_barkod_TextChanged(object sender, EventArgs e)
        {

        }


        public void barcod_okuma()
        {
            Kontrol kontrol = new Kontrol();
            Urunler targeturun = kontrol.urunGetir(txt_barkod.Text);
            txt_islem.Text = targeturun.fiyat.ToString();
            lbl_urunismi.Text = targeturun.urunismi.ToString();
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "store-scanner-beep-90395 (1).wav";
            soundPlayer.Play();
        }

        private void btn_araBarcod_Click(object sender, EventArgs e)
        {
            barcod_okuma();
        }
    }
}
