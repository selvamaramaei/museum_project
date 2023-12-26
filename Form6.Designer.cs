namespace VTYS_deneme3
{
    partial class Form6
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
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.personelNo = new System.Windows.Forms.Label();
            this.TxtpersonelNo = new System.Windows.Forms.TextBox();
            this.Bi = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Ana_Menu_Geri = new System.Windows.Forms.Button();
            this.Yonetici_listele = new System.Windows.Forms.Button();
            this.calisan_listele = new System.Windows.Forms.Button();
            this.Bilet_istemleri = new System.Windows.Forms.Label();
            this.Personel_listele = new System.Windows.Forms.Button();
            this.calisan_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMaas = new System.Windows.Forms.TextBox();
            this.TurcomboBox = new System.Windows.Forms.ComboBox();
            this.calisanSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(177, 142);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(257, 27);
            this.TxtAdSoyad.TabIndex = 96;
            // 
            // personelNo
            // 
            this.personelNo.AutoSize = true;
            this.personelNo.Location = new System.Drawing.Point(25, 64);
            this.personelNo.Name = "personelNo";
            this.personelNo.Size = new System.Drawing.Size(90, 20);
            this.personelNo.TabIndex = 93;
            this.personelNo.Text = "Personel NO";
            // 
            // TxtpersonelNo
            // 
            this.TxtpersonelNo.Location = new System.Drawing.Point(177, 57);
            this.TxtpersonelNo.Name = "TxtpersonelNo";
            this.TxtpersonelNo.Size = new System.Drawing.Size(257, 27);
            this.TxtpersonelNo.TabIndex = 94;
            // 
            // Bi
            // 
            this.Bi.AutoSize = true;
            this.Bi.Location = new System.Drawing.Point(25, 149);
            this.Bi.Name = "Bi";
            this.Bi.Size = new System.Drawing.Size(73, 20);
            this.Bi.TabIndex = 95;
            this.Bi.Text = "Ad Soyad";
            // 
            // dataGridView5
            // 
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(478, 42);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 29;
            this.dataGridView5.Size = new System.Drawing.Size(911, 490);
            this.dataGridView5.TabIndex = 92;
            // 
            // Ana_Menu_Geri
            // 
            this.Ana_Menu_Geri.Location = new System.Drawing.Point(885, 557);
            this.Ana_Menu_Geri.Name = "Ana_Menu_Geri";
            this.Ana_Menu_Geri.Size = new System.Drawing.Size(132, 29);
            this.Ana_Menu_Geri.TabIndex = 91;
            this.Ana_Menu_Geri.Text = "Ana Menu";
            this.Ana_Menu_Geri.UseVisualStyleBackColor = true;
            this.Ana_Menu_Geri.Click += new System.EventHandler(this.Ana_Menu_Geri_Click);
            // 
            // Yonetici_listele
            // 
            this.Yonetici_listele.Location = new System.Drawing.Point(12, 557);
            this.Yonetici_listele.Name = "Yonetici_listele";
            this.Yonetici_listele.Size = new System.Drawing.Size(195, 29);
            this.Yonetici_listele.TabIndex = 87;
            this.Yonetici_listele.Text = "Yöneticileri listele";
            this.Yonetici_listele.UseVisualStyleBackColor = true;
            this.Yonetici_listele.Click += new System.EventHandler(this.Yonetici_listele_Click);
            // 
            // calisan_listele
            // 
            this.calisan_listele.Location = new System.Drawing.Point(12, 423);
            this.calisan_listele.Name = "calisan_listele";
            this.calisan_listele.Size = new System.Drawing.Size(195, 29);
            this.calisan_listele.TabIndex = 86;
            this.calisan_listele.Text = "Tüm Çalışanları listele";
            this.calisan_listele.UseVisualStyleBackColor = true;
            this.calisan_listele.Click += new System.EventHandler(this.calisan_listele_Click);
            // 
            // Bilet_istemleri
            // 
            this.Bilet_istemleri.Location = new System.Drawing.Point(853, 14);
            this.Bilet_istemleri.Name = "Bilet_istemleri";
            this.Bilet_istemleri.Size = new System.Drawing.Size(202, 25);
            this.Bilet_istemleri.TabIndex = 85;
            this.Bilet_istemleri.Text = "Çalışan işlemleri";
            this.Bilet_istemleri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Personel_listele
            // 
            this.Personel_listele.Location = new System.Drawing.Point(12, 489);
            this.Personel_listele.Name = "Personel_listele";
            this.Personel_listele.Size = new System.Drawing.Size(195, 29);
            this.Personel_listele.TabIndex = 112;
            this.Personel_listele.Text = "Personelleri listele";
            this.Personel_listele.UseVisualStyleBackColor = true;
            this.Personel_listele.Click += new System.EventHandler(this.Personel_listele_Click);
            // 
            // calisan_ekle
            // 
            this.calisan_ekle.Location = new System.Drawing.Point(264, 423);
            this.calisan_ekle.Name = "calisan_ekle";
            this.calisan_ekle.Size = new System.Drawing.Size(170, 29);
            this.calisan_ekle.TabIndex = 113;
            this.calisan_ekle.Text = "Çalışan Ekle";
            this.calisan_ekle.UseVisualStyleBackColor = true;
            this.calisan_ekle.Click += new System.EventHandler(this.calisan_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 114;
            this.label1.Text = "Çalışan Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 115;
            this.label2.Text = "maaş";
            // 
            // TxtMaas
            // 
            this.TxtMaas.Location = new System.Drawing.Point(177, 298);
            this.TxtMaas.Name = "TxtMaas";
            this.TxtMaas.Size = new System.Drawing.Size(257, 27);
            this.TxtMaas.TabIndex = 116;
            // 
            // TurcomboBox
            // 
            this.TurcomboBox.FormattingEnabled = true;
            this.TurcomboBox.Items.AddRange(new object[] {
            "Y",
            "P"});
            this.TurcomboBox.Location = new System.Drawing.Point(177, 220);
            this.TurcomboBox.Name = "TurcomboBox";
            this.TurcomboBox.Size = new System.Drawing.Size(257, 28);
            this.TurcomboBox.TabIndex = 117;
            // 
            // calisanSil
            // 
            this.calisanSil.Location = new System.Drawing.Point(264, 489);
            this.calisanSil.Name = "calisanSil";
            this.calisanSil.Size = new System.Drawing.Size(170, 29);
            this.calisanSil.TabIndex = 118;
            this.calisanSil.Text = "Çalışan Sil";
            this.calisanSil.UseVisualStyleBackColor = true;
            this.calisanSil.Click += new System.EventHandler(this.calisanSil_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1417, 623);
            this.Controls.Add(this.calisanSil);
            this.Controls.Add(this.TurcomboBox);
            this.Controls.Add(this.TxtMaas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calisan_ekle);
            this.Controls.Add(this.Personel_listele);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.personelNo);
            this.Controls.Add(this.TxtpersonelNo);
            this.Controls.Add(this.Bi);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.Ana_Menu_Geri);
            this.Controls.Add(this.Yonetici_listele);
            this.Controls.Add(this.calisan_listele);
            this.Controls.Add(this.Bilet_istemleri);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox TxtAdSoyad;
        private Label personelNo;
        private TextBox TxtpersonelNo;
        private Label Bi;
        private DataGridView dataGridView5;
        private Button Ana_Menu_Geri;
        private Button Yonetici_listele;
        private Button calisan_listele;
        private Label Bilet_istemleri;
        private Button Personel_listele;
        private Button calisan_ekle;
        private Label label1;
        private Label label2;
        private TextBox TxtMaas;
        private ComboBox TurcomboBox;
        private Button calisanSil;
    }
}