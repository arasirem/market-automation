namespace market_otomasyonu
{
    partial class SifreDegistirme
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
            this.grpbox_guvenliksoru = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_girissayfasi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sorgula = new System.Windows.Forms.Button();
            this.txt_guvenlikcevabi = new System.Windows.Forms.TextBox();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.grpbox_guvenliksoru.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox_guvenliksoru
            // 
            this.grpbox_guvenliksoru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpbox_guvenliksoru.Controls.Add(this.comboBox1);
            this.grpbox_guvenliksoru.Controls.Add(this.label3);
            this.grpbox_guvenliksoru.Controls.Add(this.label2);
            this.grpbox_guvenliksoru.Controls.Add(this.lbl_girissayfasi);
            this.grpbox_guvenliksoru.Controls.Add(this.label1);
            this.grpbox_guvenliksoru.Controls.Add(this.btn_sorgula);
            this.grpbox_guvenliksoru.Controls.Add(this.txt_guvenlikcevabi);
            this.grpbox_guvenliksoru.Controls.Add(this.txt_kullaniciadi);
            this.grpbox_guvenliksoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox_guvenliksoru.Location = new System.Drawing.Point(12, 12);
            this.grpbox_guvenliksoru.Name = "grpbox_guvenliksoru";
            this.grpbox_guvenliksoru.Size = new System.Drawing.Size(427, 286);
            this.grpbox_guvenliksoru.TabIndex = 0;
            this.grpbox_guvenliksoru.TabStop = false;
            this.grpbox_guvenliksoru.Text = "Güvenlik Sorusu ile Değiştirme";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Güvenlik Cevabı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Güvenlik Sorusu:";
            // 
            // lbl_girissayfasi
            // 
            this.lbl_girissayfasi.AutoSize = true;
            this.lbl_girissayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_girissayfasi.ForeColor = System.Drawing.Color.Blue;
            this.lbl_girissayfasi.Location = new System.Drawing.Point(6, 32);
            this.lbl_girissayfasi.Name = "lbl_girissayfasi";
            this.lbl_girissayfasi.Size = new System.Drawing.Size(166, 24);
            this.lbl_girissayfasi.TabIndex = 3;
            this.lbl_girissayfasi.Text = "Giriş sayfasına dön";
            this.lbl_girissayfasi.Click += new System.EventHandler(this.lbl_girissayfasi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // btn_sorgula
            // 
            this.btn_sorgula.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sorgula.Location = new System.Drawing.Point(21, 189);
            this.btn_sorgula.Name = "btn_sorgula";
            this.btn_sorgula.Size = new System.Drawing.Size(373, 42);
            this.btn_sorgula.TabIndex = 3;
            this.btn_sorgula.Text = "SORGULA";
            this.btn_sorgula.UseVisualStyleBackColor = false;
            this.btn_sorgula.Click += new System.EventHandler(this.btn_sorgula_Click);
            // 
            // txt_guvenlikcevabi
            // 
            this.txt_guvenlikcevabi.Location = new System.Drawing.Point(195, 131);
            this.txt_guvenlikcevabi.Name = "txt_guvenlikcevabi";
            this.txt_guvenlikcevabi.Size = new System.Drawing.Size(199, 26);
            this.txt_guvenlikcevabi.TabIndex = 2;
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(195, 65);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(199, 26);
            this.txt_kullaniciadi.TabIndex = 0;
            // 
            // SifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 310);
            this.Controls.Add(this.grpbox_guvenliksoru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SifreDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreDegistirme";
            this.Load += new System.EventHandler(this.SifreDegistirme_Load);
            this.grpbox_guvenliksoru.ResumeLayout(false);
            this.grpbox_guvenliksoru.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox_guvenliksoru;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sorgula;
        private System.Windows.Forms.TextBox txt_guvenlikcevabi;
        private System.Windows.Forms.Label lbl_girissayfasi;
        public System.Windows.Forms.TextBox txt_kullaniciadi;
    }
}