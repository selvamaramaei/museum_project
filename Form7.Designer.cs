namespace VTYS_deneme3
{
    partial class Form7
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
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.ürün_listele = new System.Windows.Forms.Button();
            this.labe = new System.Windows.Forms.Label();
            this.StokDegisim = new System.Windows.Forms.Button();
            this.fiyatdegisim = new System.Windows.Forms.Button();
            this.EsyaEkle = new System.Windows.Forms.Button();
            this.EsyaSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.textUrunAd = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtStokMiktar = new System.Windows.Forms.TextBox();
            this.txtTedarikçi = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.EsyaSat = new System.Windows.Forms.Button();
            this.satisListele = new System.Windows.Forms.Button();
            this.anaMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView6
            // 
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(452, 48);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 29;
            this.dataGridView6.Size = new System.Drawing.Size(911, 443);
            this.dataGridView6.TabIndex = 93;
            // 
            // ürün_listele
            // 
            this.ürün_listele.Location = new System.Drawing.Point(12, 418);
            this.ürün_listele.Name = "ürün_listele";
            this.ürün_listele.Size = new System.Drawing.Size(161, 48);
            this.ürün_listele.TabIndex = 96;
            this.ürün_listele.Text = "Ürünleri Listele";
            this.ürün_listele.UseVisualStyleBackColor = true;
            this.ürün_listele.Click += new System.EventHandler(this.ürün_listele_Click);
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(817, 16);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(164, 20);
            this.labe.TabIndex = 105;
            this.labe.Text = "Hediyelik eşya işlemleri";
            // 
            // StokDegisim
            // 
            this.StokDegisim.Location = new System.Drawing.Point(12, 483);
            this.StokDegisim.Name = "StokDegisim";
            this.StokDegisim.Size = new System.Drawing.Size(161, 47);
            this.StokDegisim.TabIndex = 106;
            this.StokDegisim.Text = "Stok değişimi";
            this.StokDegisim.UseVisualStyleBackColor = true;
            this.StokDegisim.Click += new System.EventHandler(this.StokDegisim_Click);
            // 
            // fiyatdegisim
            // 
            this.fiyatdegisim.Location = new System.Drawing.Point(12, 545);
            this.fiyatdegisim.Name = "fiyatdegisim";
            this.fiyatdegisim.Size = new System.Drawing.Size(161, 42);
            this.fiyatdegisim.TabIndex = 107;
            this.fiyatdegisim.Text = "fiyat değişimi";
            this.fiyatdegisim.UseVisualStyleBackColor = true;
            this.fiyatdegisim.Click += new System.EventHandler(this.fiyatdegisim_Click);
            // 
            // EsyaEkle
            // 
            this.EsyaEkle.Location = new System.Drawing.Point(216, 483);
            this.EsyaEkle.Name = "EsyaEkle";
            this.EsyaEkle.Size = new System.Drawing.Size(157, 47);
            this.EsyaEkle.TabIndex = 108;
            this.EsyaEkle.Text = "Hediyelik eşya ekle";
            this.EsyaEkle.UseVisualStyleBackColor = true;
            this.EsyaEkle.Click += new System.EventHandler(this.EsyaEkle_Click);
            // 
            // EsyaSil
            // 
            this.EsyaSil.Location = new System.Drawing.Point(216, 545);
            this.EsyaSil.Name = "EsyaSil";
            this.EsyaSil.Size = new System.Drawing.Size(157, 42);
            this.EsyaSil.TabIndex = 109;
            this.EsyaSil.Text = "Hediyelik eşya sil";
            this.EsyaSil.UseVisualStyleBackColor = true;
            this.EsyaSil.Click += new System.EventHandler(this.EsyaSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 110;
            this.label1.Text = "urun adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 111;
            this.label2.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 112;
            this.label3.Text = "stok miktar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 113;
            this.label4.Text = "tedarikçi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 114;
            this.label5.Text = "kategori";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 115;
            this.label6.Text = "açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(188, 348);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(209, 27);
            this.txtAciklama.TabIndex = 116;
            // 
            // textUrunAd
            // 
            this.textUrunAd.Location = new System.Drawing.Point(188, 61);
            this.textUrunAd.Name = "textUrunAd";
            this.textUrunAd.Size = new System.Drawing.Size(209, 27);
            this.textUrunAd.TabIndex = 117;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(188, 116);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(209, 27);
            this.txtFiyat.TabIndex = 118;
            // 
            // txtStokMiktar
            // 
            this.txtStokMiktar.Location = new System.Drawing.Point(188, 173);
            this.txtStokMiktar.Name = "txtStokMiktar";
            this.txtStokMiktar.Size = new System.Drawing.Size(209, 27);
            this.txtStokMiktar.TabIndex = 119;
            // 
            // txtTedarikçi
            // 
            this.txtTedarikçi.Location = new System.Drawing.Point(188, 228);
            this.txtTedarikçi.Name = "txtTedarikçi";
            this.txtTedarikçi.Size = new System.Drawing.Size(209, 27);
            this.txtTedarikçi.TabIndex = 120;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(188, 288);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(209, 27);
            this.txtKategori.TabIndex = 121;
            // 
            // EsyaSat
            // 
            this.EsyaSat.Location = new System.Drawing.Point(216, 418);
            this.EsyaSat.Name = "EsyaSat";
            this.EsyaSat.Size = new System.Drawing.Size(157, 48);
            this.EsyaSat.TabIndex = 122;
            this.EsyaSat.Text = "Hediyelik eşya sat";
            this.EsyaSat.UseVisualStyleBackColor = true;
            this.EsyaSat.Click += new System.EventHandler(this.EsyaSat_Click);
            // 
            // satisListele
            // 
            this.satisListele.Location = new System.Drawing.Point(434, 545);
            this.satisListele.Name = "satisListele";
            this.satisListele.Size = new System.Drawing.Size(141, 42);
            this.satisListele.TabIndex = 123;
            this.satisListele.Text = "Satışları listele";
            this.satisListele.UseVisualStyleBackColor = true;
            this.satisListele.Click += new System.EventHandler(this.satisListele_Click);
            // 
            // anaMenu
            // 
            this.anaMenu.Location = new System.Drawing.Point(817, 530);
            this.anaMenu.Name = "anaMenu";
            this.anaMenu.Size = new System.Drawing.Size(145, 43);
            this.anaMenu.TabIndex = 124;
            this.anaMenu.Text = "Ana Menu";
            this.anaMenu.UseVisualStyleBackColor = true;
            this.anaMenu.Click += new System.EventHandler(this.anaMenu_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1402, 602);
            this.Controls.Add(this.anaMenu);
            this.Controls.Add(this.satisListele);
            this.Controls.Add(this.EsyaSat);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.txtTedarikçi);
            this.Controls.Add(this.txtStokMiktar);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.textUrunAd);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EsyaSil);
            this.Controls.Add(this.EsyaEkle);
            this.Controls.Add(this.fiyatdegisim);
            this.Controls.Add(this.StokDegisim);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.ürün_listele);
            this.Controls.Add(this.dataGridView6);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView6;
        private Button ürün_listele;
        private Label labe;
        private Button StokDegisim;
        private Button fiyatdegisim;
        private Button EsyaEkle;
        private Button EsyaSil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAciklama;
        private TextBox textUrunAd;
        private TextBox txtFiyat;
        private TextBox txtStokMiktar;
        private TextBox txtTedarikçi;
        private TextBox txtKategori;
        private Button EsyaSat;
        private Button satisListele;
        private Button anaMenu;
    }
}