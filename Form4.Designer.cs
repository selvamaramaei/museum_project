namespace VTYS_deneme3
{
    partial class Form4
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
            this.TxtBiletFiyat = new System.Windows.Forms.TextBox();
            this.BiletAdi = new System.Windows.Forms.Label();
            this.TxtBiletAd = new System.Windows.Forms.TextBox();
            this.Bilet_fiyat = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Ana_Menu_Geri = new System.Windows.Forms.Button();
            this.Bilet_listele = new System.Windows.Forms.Button();
            this.BiletSatislari_listele = new System.Windows.Forms.Button();
            this.Bilet_Guncelle = new System.Windows.Forms.Button();
            this.Bilet_Ekle = new System.Windows.Forms.Button();
            this.Bilet_istemleri = new System.Windows.Forms.Label();
            this.BiletSatisi = new System.Windows.Forms.Button();
            this.stok_miktari = new System.Windows.Forms.Label();
            this.aciklama = new System.Windows.Forms.Label();
            this.TxtBiletAcikmama = new System.Windows.Forms.TextBox();
            this.TxtBiletStok = new System.Windows.Forms.TextBox();
            this.biletid = new System.Windows.Forms.TextBox();
            this.Biletsil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBiletFiyat
            // 
            this.TxtBiletFiyat.Location = new System.Drawing.Point(171, 188);
            this.TxtBiletFiyat.Name = "TxtBiletFiyat";
            this.TxtBiletFiyat.Size = new System.Drawing.Size(257, 27);
            this.TxtBiletFiyat.TabIndex = 46;
            // 
            // BiletAdi
            // 
            this.BiletAdi.AutoSize = true;
            this.BiletAdi.Location = new System.Drawing.Point(19, 108);
            this.BiletAdi.Name = "BiletAdi";
            this.BiletAdi.Size = new System.Drawing.Size(66, 20);
            this.BiletAdi.TabIndex = 38;
            this.BiletAdi.Text = "Bilet Adı";
            // 
            // TxtBiletAd
            // 
            this.TxtBiletAd.Location = new System.Drawing.Point(171, 108);
            this.TxtBiletAd.Name = "TxtBiletAd";
            this.TxtBiletAd.Size = new System.Drawing.Size(257, 27);
            this.TxtBiletAd.TabIndex = 39;
            // 
            // Bilet_fiyat
            // 
            this.Bilet_fiyat.AutoSize = true;
            this.Bilet_fiyat.Location = new System.Drawing.Point(12, 188);
            this.Bilet_fiyat.Name = "Bilet_fiyat";
            this.Bilet_fiyat.Size = new System.Drawing.Size(80, 20);
            this.Bilet_fiyat.TabIndex = 40;
            this.Bilet_fiyat.Text = "Bilet fiyatı ";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(472, 43);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(911, 499);
            this.dataGridView3.TabIndex = 37;
            // 
            // Ana_Menu_Geri
            // 
            this.Ana_Menu_Geri.Location = new System.Drawing.Point(871, 561);
            this.Ana_Menu_Geri.Name = "Ana_Menu_Geri";
            this.Ana_Menu_Geri.Size = new System.Drawing.Size(132, 29);
            this.Ana_Menu_Geri.TabIndex = 36;
            this.Ana_Menu_Geri.Text = "Ana Menu";
            this.Ana_Menu_Geri.UseVisualStyleBackColor = true;
            this.Ana_Menu_Geri.Click += new System.EventHandler(this.Ana_Menu_Geri_Click);
            // 
            // Bilet_listele
            // 
            this.Bilet_listele.Location = new System.Drawing.Point(12, 475);
            this.Bilet_listele.Name = "Bilet_listele";
            this.Bilet_listele.Size = new System.Drawing.Size(132, 29);
            this.Bilet_listele.TabIndex = 34;
            this.Bilet_listele.Text = "Biletleri listele";
            this.Bilet_listele.UseVisualStyleBackColor = true;
            this.Bilet_listele.Click += new System.EventHandler(this.Bilet_listele_Click);
            // 
            // BiletSatislari_listele
            // 
            this.BiletSatislari_listele.Location = new System.Drawing.Point(207, 547);
            this.BiletSatislari_listele.Name = "BiletSatislari_listele";
            this.BiletSatislari_listele.Size = new System.Drawing.Size(175, 29);
            this.BiletSatislari_listele.TabIndex = 33;
            this.BiletSatislari_listele.Text = "Bilet satışlarını listele";
            this.BiletSatislari_listele.UseVisualStyleBackColor = true;
            this.BiletSatislari_listele.Click += new System.EventHandler(this.BiletSatislari_listele_Click);
            // 
            // Bilet_Guncelle
            // 
            this.Bilet_Guncelle.Location = new System.Drawing.Point(207, 401);
            this.Bilet_Guncelle.Name = "Bilet_Guncelle";
            this.Bilet_Guncelle.Size = new System.Drawing.Size(132, 29);
            this.Bilet_Guncelle.TabIndex = 32;
            this.Bilet_Guncelle.Text = "Biletleri Güncelle";
            this.Bilet_Guncelle.UseVisualStyleBackColor = true;
            this.Bilet_Guncelle.Click += new System.EventHandler(this.Bilet_Guncelle_Click);
            // 
            // Bilet_Ekle
            // 
            this.Bilet_Ekle.Location = new System.Drawing.Point(12, 401);
            this.Bilet_Ekle.Name = "Bilet_Ekle";
            this.Bilet_Ekle.Size = new System.Drawing.Size(132, 29);
            this.Bilet_Ekle.TabIndex = 31;
            this.Bilet_Ekle.Text = "Bilet Ekle ";
            this.Bilet_Ekle.UseVisualStyleBackColor = true;
            this.Bilet_Ekle.Click += new System.EventHandler(this.Bilet_Ekle_Click);
            // 
            // Bilet_istemleri
            // 
            this.Bilet_istemleri.Location = new System.Drawing.Point(847, 15);
            this.Bilet_istemleri.Name = "Bilet_istemleri";
            this.Bilet_istemleri.Size = new System.Drawing.Size(202, 25);
            this.Bilet_istemleri.TabIndex = 30;
            this.Bilet_istemleri.Text = "Bilet işlemleri";
            this.Bilet_istemleri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BiletSatisi
            // 
            this.BiletSatisi.Location = new System.Drawing.Point(19, 547);
            this.BiletSatisi.Name = "BiletSatisi";
            this.BiletSatisi.Size = new System.Drawing.Size(132, 29);
            this.BiletSatisi.TabIndex = 47;
            this.BiletSatisi.Text = "Bilet sat";
            this.BiletSatisi.UseVisualStyleBackColor = true;
            this.BiletSatisi.Click += new System.EventHandler(this.BiletSatisi_Click);
            // 
            // stok_miktari
            // 
            this.stok_miktari.AutoSize = true;
            this.stok_miktari.Location = new System.Drawing.Point(12, 266);
            this.stok_miktari.Name = "stok_miktari";
            this.stok_miktari.Size = new System.Drawing.Size(86, 20);
            this.stok_miktari.TabIndex = 48;
            this.stok_miktari.Text = "stok miktarı";
            // 
            // aciklama
            // 
            this.aciklama.AutoSize = true;
            this.aciklama.Location = new System.Drawing.Point(12, 336);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(68, 20);
            this.aciklama.TabIndex = 51;
            this.aciklama.Text = "açıklama";
            // 
            // TxtBiletAcikmama
            // 
            this.TxtBiletAcikmama.Location = new System.Drawing.Point(171, 329);
            this.TxtBiletAcikmama.Name = "TxtBiletAcikmama";
            this.TxtBiletAcikmama.Size = new System.Drawing.Size(257, 27);
            this.TxtBiletAcikmama.TabIndex = 52;
            // 
            // TxtBiletStok
            // 
            this.TxtBiletStok.Location = new System.Drawing.Point(171, 259);
            this.TxtBiletStok.Name = "TxtBiletStok";
            this.TxtBiletStok.Size = new System.Drawing.Size(257, 27);
            this.TxtBiletStok.TabIndex = 53;
            // 
            // biletid
            // 
            this.biletid.Location = new System.Drawing.Point(263, 43);
            this.biletid.Name = "biletid";
            this.biletid.Size = new System.Drawing.Size(129, 27);
            this.biletid.TabIndex = 54;
            // 
            // Biletsil
            // 
            this.Biletsil.Location = new System.Drawing.Point(207, 475);
            this.Biletsil.Name = "Biletsil";
            this.Biletsil.Size = new System.Drawing.Size(132, 29);
            this.Biletsil.TabIndex = 55;
            this.Biletsil.Text = "Bileti Sil";
            this.Biletsil.UseVisualStyleBackColor = true;
            this.Biletsil.Click += new System.EventHandler(this.Biletsil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Güncellemek istediğiniz bilet id";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1402, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Biletsil);
            this.Controls.Add(this.biletid);
            this.Controls.Add(this.TxtBiletStok);
            this.Controls.Add(this.TxtBiletAcikmama);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.stok_miktari);
            this.Controls.Add(this.BiletSatisi);
            this.Controls.Add(this.TxtBiletFiyat);
            this.Controls.Add(this.BiletAdi);
            this.Controls.Add(this.TxtBiletAd);
            this.Controls.Add(this.Bilet_fiyat);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.Ana_Menu_Geri);
            this.Controls.Add(this.Bilet_listele);
            this.Controls.Add(this.BiletSatislari_listele);
            this.Controls.Add(this.Bilet_Guncelle);
            this.Controls.Add(this.Bilet_Ekle);
            this.Controls.Add(this.Bilet_istemleri);
            this.Name = "Form4";
            this.Text = "Bilet işlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox TxtBiletFiyat;
        private Label BiletAdi;
        private TextBox TxtBiletAd;
        private Label Bilet_fiyat;
        private DataGridView dataGridView3;
        private Button Ana_Menu_Geri;
        private Button Bilet_listele;
        private Button BiletSatislari_listele;
        private Button Bilet_Guncelle;
        private Button Bilet_Ekle;
        private Label Bilet_istemleri;
        private Button BiletSatisi;
        private Label stok_miktari;
        private Label aciklama;
        private TextBox TxtBiletAcikmama;
        private TextBox TxtBiletStok;
        private TextBox biletid;
        private Button Biletsil;
        private Label label1;
    }
}