namespace market_otomasyonu
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.btn_kullanici = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_second = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_hour = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_urunler = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kullanici
            // 
            this.btn_kullanici.ImageKey = "Custom-Icon-Design-Flatastic-4-Users.512.png";
            this.btn_kullanici.ImageList = this.ımageList1;
            this.btn_kullanici.Location = new System.Drawing.Point(31, 95);
            this.btn_kullanici.Name = "btn_kullanici";
            this.btn_kullanici.Size = new System.Drawing.Size(184, 194);
            this.btn_kullanici.TabIndex = 0;
            this.btn_kullanici.UseVisualStyleBackColor = true;
            this.btn_kullanici.Click += new System.EventHandler(this.btn_kullanici_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "20143_close_exit_icon.png");
            this.ımageList1.Images.SetKeyName(1, "62597_goods_palet_products_shipment_shipping_icon.png");
            this.ımageList1.Images.SetKeyName(2, "Custom-Icon-Design-Flatastic-4-Users.512.png");
            // 
            // lbl_second
            // 
            this.lbl_second.AutoSize = true;
            this.lbl_second.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_second.Location = new System.Drawing.Point(615, 22);
            this.lbl_second.Name = "lbl_second";
            this.lbl_second.Size = new System.Drawing.Size(51, 29);
            this.lbl_second.TabIndex = 6;
            this.lbl_second.Text = "00 ";
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_min.Location = new System.Drawing.Point(558, 22);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(51, 29);
            this.lbl_min.TabIndex = 7;
            this.lbl_min.Text = "00 ";
            // 
            // lbl_hour
            // 
            this.lbl_hour.AutoSize = true;
            this.lbl_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hour.Location = new System.Drawing.Point(505, 22);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(51, 29);
            this.lbl_hour.TabIndex = 10;
            this.lbl_hour.Text = "00 ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_urunler
            // 
            this.btn_urunler.ImageKey = "62597_goods_palet_products_shipment_shipping_icon.png";
            this.btn_urunler.ImageList = this.ımageList1;
            this.btn_urunler.Location = new System.Drawing.Point(257, 95);
            this.btn_urunler.Name = "btn_urunler";
            this.btn_urunler.Size = new System.Drawing.Size(184, 194);
            this.btn_urunler.TabIndex = 1;
            this.btn_urunler.UseVisualStyleBackColor = true;
            this.btn_urunler.Click += new System.EventHandler(this.btn_urunler_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.ImageKey = "20143_close_exit_icon.png";
            this.btn_cikis.ImageList = this.ımageList1;
            this.btn_cikis.Location = new System.Drawing.Point(482, 95);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(184, 194);
            this.btn_cikis.TabIndex = 2;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(698, 332);
            this.Controls.Add(this.lbl_second);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.lbl_hour);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_urunler);
            this.Controls.Add(this.btn_kullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kullanici;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lbl_second;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label lbl_hour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_urunler;
        private System.Windows.Forms.Button btn_cikis;
    }
}