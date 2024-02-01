namespace market_otomasyonu
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kullaniciekle = new System.Windows.Forms.Button();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_guvenlikCevabi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_kullanicisil = new System.Windows.Forms.Button();
            this.btn_kullaniciguncelle = new System.Windows.Forms.Button();
            this.comboBox_yetki = new System.Windows.Forms.ComboBox();
            this.comboBox_bolge = new System.Windows.Forms.ComboBox();
            this.groupBox_users = new System.Windows.Forms.GroupBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_cikis = new System.Windows.Forms.Button();
            this.comboBox_guvenliksorusu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.groupBox_users.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Location = new System.Drawing.Point(16, 15);
            this.dataGridView_users.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.RowHeadersWidth = 51;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView_users.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_users.RowTemplate.Height = 24;
            this.dataGridView_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_users.Size = new System.Drawing.Size(973, 308);
            this.dataGridView_users.TabIndex = 0;
            this.dataGridView_users.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_users_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-6, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // btn_kullaniciekle
            // 
            this.btn_kullaniciekle.BackColor = System.Drawing.Color.Silver;
            this.btn_kullaniciekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kullaniciekle.Location = new System.Drawing.Point(92, 288);
            this.btn_kullaniciekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kullaniciekle.Name = "btn_kullaniciekle";
            this.btn_kullaniciekle.Size = new System.Drawing.Size(189, 62);
            this.btn_kullaniciekle.TabIndex = 7;
            this.btn_kullaniciekle.Text = "Kayıt Ekle";
            this.btn_kullaniciekle.UseVisualStyleBackColor = false;
            this.btn_kullaniciekle.Click += new System.EventHandler(this.btn_kullaniciekle_Click);
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(122, 54);
            this.txt_kullaniciadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_kullaniciadi.Multiline = true;
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(281, 26);
            this.txt_kullaniciadi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(122, 101);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_sifre.Multiline = true;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(281, 26);
            this.txt_sifre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yetki:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bölge:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(475, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "E-mail:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(683, 76);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(283, 26);
            this.txt_email.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(465, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Güvenlik cevabı:";
            // 
            // txt_guvenlikCevabi
            // 
            this.txt_guvenlikCevabi.Location = new System.Drawing.Point(682, 177);
            this.txt_guvenlikCevabi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_guvenlikCevabi.Multiline = true;
            this.txt_guvenlikCevabi.Name = "txt_guvenlikCevabi";
            this.txt_guvenlikCevabi.Size = new System.Drawing.Size(284, 24);
            this.txt_guvenlikCevabi.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(465, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Güvenlik sorusu:";
            // 
            // btn_kullanicisil
            // 
            this.btn_kullanicisil.BackColor = System.Drawing.Color.Silver;
            this.btn_kullanicisil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kullanicisil.Location = new System.Drawing.Point(289, 288);
            this.btn_kullanicisil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kullanicisil.Name = "btn_kullanicisil";
            this.btn_kullanicisil.Size = new System.Drawing.Size(189, 62);
            this.btn_kullanicisil.TabIndex = 8;
            this.btn_kullanicisil.Text = "Kayıt Sil";
            this.btn_kullanicisil.UseVisualStyleBackColor = false;
            this.btn_kullanicisil.Click += new System.EventHandler(this.btn_kullanicisil_Click);
            // 
            // btn_kullaniciguncelle
            // 
            this.btn_kullaniciguncelle.BackColor = System.Drawing.Color.Silver;
            this.btn_kullaniciguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kullaniciguncelle.Location = new System.Drawing.Point(496, 288);
            this.btn_kullaniciguncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kullaniciguncelle.Name = "btn_kullaniciguncelle";
            this.btn_kullaniciguncelle.Size = new System.Drawing.Size(189, 62);
            this.btn_kullaniciguncelle.TabIndex = 9;
            this.btn_kullaniciguncelle.Text = "Kayıt Güncelle";
            this.btn_kullaniciguncelle.UseVisualStyleBackColor = false;
            this.btn_kullaniciguncelle.Click += new System.EventHandler(this.btn_kullaniciguncelle_Click);
            // 
            // comboBox_yetki
            // 
            this.comboBox_yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_yetki.FormattingEnabled = true;
            this.comboBox_yetki.Location = new System.Drawing.Point(122, 152);
            this.comboBox_yetki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_yetki.Name = "comboBox_yetki";
            this.comboBox_yetki.Size = new System.Drawing.Size(283, 28);
            this.comboBox_yetki.TabIndex = 2;
            // 
            // comboBox_bolge
            // 
            this.comboBox_bolge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bolge.FormattingEnabled = true;
            this.comboBox_bolge.Location = new System.Drawing.Point(120, 200);
            this.comboBox_bolge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_bolge.Name = "comboBox_bolge";
            this.comboBox_bolge.Size = new System.Drawing.Size(283, 28);
            this.comboBox_bolge.TabIndex = 3;
            // 
            // groupBox_users
            // 
            this.groupBox_users.Controls.Add(this.txt_guvenlikCevabi);
            this.groupBox_users.Controls.Add(this.btn_cikis);
            this.groupBox_users.Controls.Add(this.btn_kullaniciguncelle);
            this.groupBox_users.Controls.Add(this.btn_kullanicisil);
            this.groupBox_users.Controls.Add(this.txt_sifre);
            this.groupBox_users.Controls.Add(this.btn_kullaniciekle);
            this.groupBox_users.Controls.Add(this.label1);
            this.groupBox_users.Controls.Add(this.label4);
            this.groupBox_users.Controls.Add(this.label5);
            this.groupBox_users.Controls.Add(this.label2);
            this.groupBox_users.Controls.Add(this.txt_email);
            this.groupBox_users.Controls.Add(this.label6);
            this.groupBox_users.Controls.Add(this.txt_kullaniciadi);
            this.groupBox_users.Controls.Add(this.label7);
            this.groupBox_users.Controls.Add(this.label3);
            this.groupBox_users.Controls.Add(this.comboBox_guvenliksorusu);
            this.groupBox_users.Controls.Add(this.comboBox_yetki);
            this.groupBox_users.Controls.Add(this.comboBox_bolge);
            this.groupBox_users.Location = new System.Drawing.Point(16, 330);
            this.groupBox_users.Name = "groupBox_users";
            this.groupBox_users.Size = new System.Drawing.Size(973, 377);
            this.groupBox_users.TabIndex = 5;
            this.groupBox_users.TabStop = false;
            this.groupBox_users.Text = "KULLANICI PANELİ";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Silver;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(697, 288);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(189, 62);
            this.btn_cikis.TabIndex = 10;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // comboBox_guvenliksorusu
            // 
            this.comboBox_guvenliksorusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_guvenliksorusu.FormattingEnabled = true;
            this.comboBox_guvenliksorusu.Location = new System.Drawing.Point(682, 126);
            this.comboBox_guvenliksorusu.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_guvenliksorusu.Name = "comboBox_guvenliksorusu";
            this.comboBox_guvenliksorusu.Size = new System.Drawing.Size(283, 28);
            this.comboBox_guvenliksorusu.TabIndex = 5;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1002, 719);
            this.Controls.Add(this.groupBox_users);
            this.Controls.Add(this.dataGridView_users);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            this.groupBox_users.ResumeLayout(false);
            this.groupBox_users.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kullaniciekle;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_guvenlikCevabi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_kullanicisil;
        private System.Windows.Forms.Button btn_kullaniciguncelle;
        private System.Windows.Forms.ComboBox comboBox_yetki;
        private System.Windows.Forms.ComboBox comboBox_bolge;
        private System.Windows.Forms.GroupBox groupBox_users;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.ComboBox comboBox_guvenliksorusu;
    }
}