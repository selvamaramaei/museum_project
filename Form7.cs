using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_deneme3
    // HEDİYELİK EŞYA

{
    public partial class Form7 : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=odev; user ID=postgres; password=123456");
        public Form7()
        {
            InitializeComponent();
        }

        private void ürün_listele_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM HediyelikEsyalar order by urunid";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                dataGridView6.DataSource = dataTable;
                dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void fiyatdegisim_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan UrunID bilgisini al
                int urunID = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ürün ID'sini girin:", "Ürün ID", "", -1, -1));

                // Kullanıcıdan yeni fiyat bilgisini al
                decimal yeniFiyat = Convert.ToDecimal(Microsoft.VisualBasic.Interaction.InputBox("Yeni fiyatı girin:", "Yeni Fiyat", "", -1, -1));

                // PostgreSQL sorgusunu hazırla
                string sorgu = $"SELECT hediyelik_esya_fiyat_degistir({urunID}, {yeniFiyat})";

                // PostgreSQL sorgusunu çalıştır
                baglanti.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglanti))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Fiyat güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void StokDegisim_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan UrunID bilgisini al
                int urunID = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ürün ID'sini girin:", "Ürün ID", "", -1, -1));

                // Kullanıcıdan yeni stok miktarı bilgisini al
                int yeniStokMiktar = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Yeni stok miktarını girin:", "Yeni Stok Miktarı", "", -1, -1));

                // PostgreSQL sorgusunu hazırla
                string sorgu = $"SELECT * FROM hediyelik_esya_stok_degistir({urunID}, {yeniStokMiktar})";


                // PostgreSQL sorgusunu çalıştır
                baglanti.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglanti))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Stok güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void EsyaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan ürün bilgilerini al
                string urunAdi = textUrunAd.Text;
                decimal fiyat = Convert.ToDecimal(txtFiyat.Text);
                int stokMiktari = Convert.ToInt32(txtStokMiktar.Text);
                string tedarikci = txtTedarikçi.Text;
                string kategori = txtKategori.Text;
                string aciklama = txtAciklama.Text;

                // PostgreSQL sorgusunu hazırla
                string sorgu = $"INSERT INTO HediyelikEsyalar (UrunAdi, Fiyat, StokMiktari, Tedarikci, Kategori, Aciklama) " +
                               $"VALUES ('{urunAdi}', {fiyat}, {stokMiktari}, '{tedarikci}', '{kategori}', '{aciklama}')";

                // PostgreSQL sorgusunu çalıştır
                baglanti.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglanti))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Ürün eklendi.");

                // TextBox'ları temizle
                textUrunAd.Clear();
                txtFiyat.Clear();
                txtStokMiktar.Clear();
                txtTedarikçi.Clear();
                txtKategori.Clear();
                txtAciklama.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void EsyaSil_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan silmek istediği ürünün ID'sini al
                int urunID = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Silmek istediğiniz ürünün ID'sini girin:", "Ürün ID", "", -1, -1));

                // PostgreSQL sorgusunu hazırla
                string sorgu = $"DELETE FROM HediyelikEsyalar WHERE UrunID = {urunID}";

                // PostgreSQL sorgusunu çalıştır
                baglanti.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglanti))
                {
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Ürün silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen ID'ye sahip ürün bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void EsyaSat_Click(object sender, EventArgs e)
        {
                try
                {
                    // Kullanıcıdan satmak istediği ürünün ID'sini al
                    int urunID = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Satmak istediğiniz ürünün ID'sini girin:", "Ürün ID", "", -1, -1));

                    // PostgreSQL sorgusunu çalıştır
                    baglanti.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand($"UPDATE HediyelikEsyalar SET StokMiktari = StokMiktari - 1  WHERE urunid = {urunID};", baglanti))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Ürün satıldı.");

                    // Optional: Refresh the product list or perform any other necessary actions
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }

        }

        private void satisListele_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM public.\"hediyelikEsyaSatislar\" order by urunid";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                dataGridView6.DataSource = dataTable;
                dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void anaMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

         


    }


