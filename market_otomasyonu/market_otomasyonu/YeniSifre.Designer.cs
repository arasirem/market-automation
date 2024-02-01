namespace market_otomasyonu
{
    partial class YeniSifre
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
            this.grpbox_sifredegistir = new System.Windows.Forms.GroupBox();
            this.txt_yenisifretkr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_yenisifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.grpbox_sifredegistir.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox_sifredegistir
            // 
            this.grpbox_sifredegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpbox_sifredegistir.Controls.Add(this.txt_yenisifretkr);
            this.grpbox_sifredegistir.Controls.Add(this.label5);
            this.grpbox_sifredegistir.Controls.Add(this.txt_yenisifre);
            this.grpbox_sifredegistir.Controls.Add(this.label4);
            this.grpbox_sifredegistir.Controls.Add(this.btn_degistir);
            this.grpbox_sifredegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox_sifredegistir.Location = new System.Drawing.Point(12, 12);
            this.grpbox_sifredegistir.Name = "grpbox_sifredegistir";
            this.grpbox_sifredegistir.Size = new System.Drawing.Size(415, 168);
            this.grpbox_sifredegistir.TabIndex = 1;
            this.grpbox_sifredegistir.TabStop = false;
            this.grpbox_sifredegistir.Text = "Şifre Değiştirme";
            // 
            // txt_yenisifretkr
            // 
            this.txt_yenisifretkr.Location = new System.Drawing.Point(211, 74);
            this.txt_yenisifretkr.Name = "txt_yenisifretkr";
            this.txt_yenisifretkr.Size = new System.Drawing.Size(177, 26);
            this.txt_yenisifretkr.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Yeni Şifre Tekrar:";
            // 
            // txt_yenisifre
            // 
            this.txt_yenisifre.Location = new System.Drawing.Point(211, 42);
            this.txt_yenisifre.Name = "txt_yenisifre";
            this.txt_yenisifre.Size = new System.Drawing.Size(177, 26);
            this.txt_yenisifre.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yeni Şifre:";
            // 
            // btn_degistir
            // 
            this.btn_degistir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_degistir.Location = new System.Drawing.Point(15, 119);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(373, 42);
            this.btn_degistir.TabIndex = 2;
            this.btn_degistir.Text = "DEĞİŞTİR";
            this.btn_degistir.UseVisualStyleBackColor = false;
            this.btn_degistir.Click += new System.EventHandler(this.btn_degistir_Click);
            // 
            // YeniSifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 196);
            this.Controls.Add(this.grpbox_sifredegistir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YeniSifre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniSifre";
            this.grpbox_sifredegistir.ResumeLayout(false);
            this.grpbox_sifredegistir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox_sifredegistir;
        private System.Windows.Forms.TextBox txt_yenisifretkr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_yenisifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_degistir;
    }
}