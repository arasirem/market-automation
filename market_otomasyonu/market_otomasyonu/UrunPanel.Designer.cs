namespace market_otomasyonu
{
    partial class UrunPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox_urun = new System.Windows.Forms.GroupBox();
            this.txt_urunismi = new System.Windows.Forms.TextBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_urunguncelle = new System.Windows.Forms.Button();
            this.btn_urunsil = new System.Windows.Forms.Button();
            this.txt_qrkod = new System.Windows.Forms.TextBox();
            this.btn_urunekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_urun = new System.Windows.Forms.DataGridView();
            this.dateTime_olusturma = new System.Windows.Forms.DateTimePicker();
            this.dateTime_guncelleme = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ciro = new System.Windows.Forms.TextBox();
            this.groupBox_urun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_urun)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_urun
            // 
            this.groupBox_urun.Controls.Add(this.label5);
            this.groupBox_urun.Controls.Add(this.txt_barkod);
            this.groupBox_urun.Controls.Add(this.dateTime_guncelleme);
            this.groupBox_urun.Controls.Add(this.dateTime_olusturma);
            this.groupBox_urun.Controls.Add(this.txt_ciro);
            this.groupBox_urun.Controls.Add(this.txt_fiyat);
            this.groupBox_urun.Controls.Add(this.txt_kilo);
            this.groupBox_urun.Controls.Add(this.txt_urunismi);
            this.groupBox_urun.Controls.Add(this.btn_cikis);
            this.groupBox_urun.Controls.Add(this.btn_urunguncelle);
            this.groupBox_urun.Controls.Add(this.btn_urunsil);
            this.groupBox_urun.Controls.Add(this.txt_qrkod);
            this.groupBox_urun.Controls.Add(this.btn_urunekle);
            this.groupBox_urun.Controls.Add(this.label1);
            this.groupBox_urun.Controls.Add(this.label9);
            this.groupBox_urun.Controls.Add(this.label4);
            this.groupBox_urun.Controls.Add(this.label8);
            this.groupBox_urun.Controls.Add(this.label2);
            this.groupBox_urun.Controls.Add(this.label6);
            this.groupBox_urun.Controls.Add(this.txt_id);
            this.groupBox_urun.Controls.Add(this.label7);
            this.groupBox_urun.Controls.Add(this.label3);
            this.groupBox_urun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_urun.Location = new System.Drawing.Point(13, 319);
            this.groupBox_urun.Name = "groupBox_urun";
            this.groupBox_urun.Size = new System.Drawing.Size(973, 377);
            this.groupBox_urun.TabIndex = 7;
            this.groupBox_urun.TabStop = false;
            this.groupBox_urun.Text = "ÜRÜN PANELİ";
            // 
            // txt_urunismi
            // 
            this.txt_urunismi.Location = new System.Drawing.Point(573, 51);
            this.txt_urunismi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_urunismi.Multiline = true;
            this.txt_urunismi.Name = "txt_urunismi";
            this.txt_urunismi.Size = new System.Drawing.Size(284, 24);
            this.txt_urunismi.TabIndex = 5;
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Silver;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(697, 288);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(189, 62);
            this.btn_cikis.TabIndex = 12;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_urunguncelle
            // 
            this.btn_urunguncelle.BackColor = System.Drawing.Color.Silver;
            this.btn_urunguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urunguncelle.Location = new System.Drawing.Point(496, 288);
            this.btn_urunguncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_urunguncelle.Name = "btn_urunguncelle";
            this.btn_urunguncelle.Size = new System.Drawing.Size(189, 62);
            this.btn_urunguncelle.TabIndex = 11;
            this.btn_urunguncelle.Text = "Ürün Güncelle";
            this.btn_urunguncelle.UseVisualStyleBackColor = false;
            this.btn_urunguncelle.Click += new System.EventHandler(this.btn_urunguncelle_Click);
            // 
            // btn_urunsil
            // 
            this.btn_urunsil.BackColor = System.Drawing.Color.Silver;
            this.btn_urunsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urunsil.Location = new System.Drawing.Point(289, 288);
            this.btn_urunsil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_urunsil.Name = "btn_urunsil";
            this.btn_urunsil.Size = new System.Drawing.Size(189, 62);
            this.btn_urunsil.TabIndex = 10;
            this.btn_urunsil.Text = "Ürün Sil";
            this.btn_urunsil.UseVisualStyleBackColor = false;
            this.btn_urunsil.Click += new System.EventHandler(this.btn_urunsil_Click);
            // 
            // txt_qrkod
            // 
            this.txt_qrkod.Location = new System.Drawing.Point(122, 101);
            this.txt_qrkod.Margin = new System.Windows.Forms.Padding(4);
            this.txt_qrkod.Multiline = true;
            this.txt_qrkod.Name = "txt_qrkod";
            this.txt_qrkod.Size = new System.Drawing.Size(281, 26);
            this.txt_qrkod.TabIndex = 1;
            // 
            // btn_urunekle
            // 
            this.btn_urunekle.BackColor = System.Drawing.Color.Silver;
            this.btn_urunekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urunekle.Location = new System.Drawing.Point(92, 288);
            this.btn_urunekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_urunekle.Name = "btn_urunekle";
            this.btn_urunekle.Size = new System.Drawing.Size(189, 62);
            this.btn_urunekle.TabIndex = 9;
            this.btn_urunekle.Text = "Ürün Ekle";
            this.btn_urunekle.UseVisualStyleBackColor = false;
            this.btn_urunekle.Click += new System.EventHandler(this.btn_urunekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Güncellenme Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "QRKOD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(448, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kilo:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(122, 54);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(281, 26);
            this.txt_id.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(448, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ürün ismi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Oluşturulmas Tarihi:";
            // 
            // dataGridView_urun
            // 
            this.dataGridView_urun.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView_urun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_urun.Location = new System.Drawing.Point(13, 4);
            this.dataGridView_urun.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_urun.Name = "dataGridView_urun";
            this.dataGridView_urun.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView_urun.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_urun.RowTemplate.Height = 24;
            this.dataGridView_urun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_urun.Size = new System.Drawing.Size(973, 308);
            this.dataGridView_urun.TabIndex = 6;
            this.dataGridView_urun.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_urun_CellContentDoubleClick);
            // 
            // dateTime_olusturma
            // 
            this.dateTime_olusturma.Location = new System.Drawing.Point(203, 194);
            this.dateTime_olusturma.Name = "dateTime_olusturma";
            this.dateTime_olusturma.Size = new System.Drawing.Size(200, 26);
            this.dateTime_olusturma.TabIndex = 3;
            // 
            // dateTime_guncelleme
            // 
            this.dateTime_guncelleme.Location = new System.Drawing.Point(203, 241);
            this.dateTime_guncelleme.Name = "dateTime_guncelleme";
            this.dateTime_guncelleme.Size = new System.Drawing.Size(200, 26);
            this.dateTime_guncelleme.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Barkod:";
            // 
            // txt_barkod
            // 
            this.txt_barkod.Location = new System.Drawing.Point(122, 152);
            this.txt_barkod.Margin = new System.Windows.Forms.Padding(4);
            this.txt_barkod.Multiline = true;
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(283, 26);
            this.txt_barkod.TabIndex = 2;
            // 
            // txt_kilo
            // 
            this.txt_kilo.Location = new System.Drawing.Point(573, 98);
            this.txt_kilo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kilo.Multiline = true;
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.Size = new System.Drawing.Size(284, 24);
            this.txt_kilo.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(448, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fiyat:";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(573, 148);
            this.txt_fiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fiyat.Multiline = true;
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(284, 24);
            this.txt_fiyat.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(448, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ciro:";
            // 
            // txt_ciro
            // 
            this.txt_ciro.Location = new System.Drawing.Point(573, 194);
            this.txt_ciro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ciro.Multiline = true;
            this.txt_ciro.Name = "txt_ciro";
            this.txt_ciro.Size = new System.Drawing.Size(284, 24);
            this.txt_ciro.TabIndex = 8;
            // 
            // UrunPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1005, 706);
            this.Controls.Add(this.groupBox_urun);
            this.Controls.Add(this.dataGridView_urun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UrunPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunPanel";
            this.Load += new System.EventHandler(this.UrunPanel_Load);
            this.groupBox_urun.ResumeLayout(false);
            this.groupBox_urun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_urun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_urun;
        private System.Windows.Forms.TextBox txt_urunismi;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_urunguncelle;
        private System.Windows.Forms.Button btn_urunsil;
        private System.Windows.Forms.TextBox txt_qrkod;
        private System.Windows.Forms.Button btn_urunekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_urun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.DateTimePicker dateTime_guncelleme;
        private System.Windows.Forms.DateTimePicker dateTime_olusturma;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.TextBox txt_ciro;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}