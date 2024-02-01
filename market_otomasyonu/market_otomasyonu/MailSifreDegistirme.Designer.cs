namespace market_otomasyonu
{
    partial class MailSifreDegistirme
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
            this.grpbox_maililedegistirme = new System.Windows.Forms.GroupBox();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.btn_dogrulamakodu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_girissayfasi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dogrulamakodu = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.grpbox_maililedegistirme.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox_maililedegistirme
            // 
            this.grpbox_maililedegistirme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpbox_maililedegistirme.Controls.Add(this.btn_onayla);
            this.grpbox_maililedegistirme.Controls.Add(this.btn_dogrulamakodu);
            this.grpbox_maililedegistirme.Controls.Add(this.label2);
            this.grpbox_maililedegistirme.Controls.Add(this.lbl_girissayfasi);
            this.grpbox_maililedegistirme.Controls.Add(this.label1);
            this.grpbox_maililedegistirme.Controls.Add(this.txt_dogrulamakodu);
            this.grpbox_maililedegistirme.Controls.Add(this.txt_mail);
            this.grpbox_maililedegistirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox_maililedegistirme.Location = new System.Drawing.Point(12, 12);
            this.grpbox_maililedegistirme.Name = "grpbox_maililedegistirme";
            this.grpbox_maililedegistirme.Size = new System.Drawing.Size(457, 302);
            this.grpbox_maililedegistirme.TabIndex = 0;
            this.grpbox_maililedegistirme.TabStop = false;
            this.grpbox_maililedegistirme.Text = "Mail ile Değiştirme";
            // 
            // btn_onayla
            // 
            this.btn_onayla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_onayla.Location = new System.Drawing.Point(336, 217);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(98, 34);
            this.btn_onayla.TabIndex = 4;
            this.btn_onayla.Text = "Onayla";
            this.btn_onayla.UseVisualStyleBackColor = false;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // btn_dogrulamakodu
            // 
            this.btn_dogrulamakodu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dogrulamakodu.Location = new System.Drawing.Point(187, 137);
            this.btn_dogrulamakodu.Name = "btn_dogrulamakodu";
            this.btn_dogrulamakodu.Size = new System.Drawing.Size(247, 42);
            this.btn_dogrulamakodu.TabIndex = 2;
            this.btn_dogrulamakodu.Text = "Doğrulama kodu gönder";
            this.btn_dogrulamakodu.UseVisualStyleBackColor = false;
            this.btn_dogrulamakodu.Click += new System.EventHandler(this.btn_dogrulamakodu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doğrulama kodu:";
            // 
            // lbl_girissayfasi
            // 
            this.lbl_girissayfasi.AutoSize = true;
            this.lbl_girissayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_girissayfasi.ForeColor = System.Drawing.Color.Blue;
            this.lbl_girissayfasi.Location = new System.Drawing.Point(6, 37);
            this.lbl_girissayfasi.Name = "lbl_girissayfasi";
            this.lbl_girissayfasi.Size = new System.Drawing.Size(166, 24);
            this.lbl_girissayfasi.TabIndex = 5;
            this.lbl_girissayfasi.Text = "Giriş sayfasına dön";
            this.lbl_girissayfasi.Click += new System.EventHandler(this.lbl_girissayfasi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mail Adresiniz:";
            // 
            // txt_dogrulamakodu
            // 
            this.txt_dogrulamakodu.Location = new System.Drawing.Point(200, 221);
            this.txt_dogrulamakodu.Name = "txt_dogrulamakodu";
            this.txt_dogrulamakodu.Size = new System.Drawing.Size(124, 26);
            this.txt_dogrulamakodu.TabIndex = 3;
            // 
            // txt_mail
            // 
            this.txt_mail.AllowDrop = true;
            this.txt_mail.Location = new System.Drawing.Point(187, 94);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(247, 26);
            this.txt_mail.TabIndex = 1;
            // 
            // MailSifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 326);
            this.Controls.Add(this.grpbox_maililedegistirme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MailSifreDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailSifreDegistirme";
            this.Load += new System.EventHandler(this.MailSifreDegistirme_Load);
            this.grpbox_maililedegistirme.ResumeLayout(false);
            this.grpbox_maililedegistirme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox_maililedegistirme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dogrulamakodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.TextBox txt_dogrulamakodu;
        private System.Windows.Forms.Label lbl_girissayfasi;
        public System.Windows.Forms.TextBox txt_mail;
    }
}