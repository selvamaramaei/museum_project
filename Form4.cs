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
{
    public partial class Form4 : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=odev; user ID=postgres; password=123456");

        public Form4()
        {
            InitializeComponent();
        }

        private void Bilet_listele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT * from biletler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            baglanti.Close();
            dataGridView3.Refresh();

        }

        private void BiletSatislari_listele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT * from biletsatislar order by biletid";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            baglanti.Close();
            dataGridView3.Refresh();

        }

        private void Bilet_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command = new NpgsqlCommand("Call public.bilet_ekle(@p_bilet_adi, @p_fiyat, @p_stok_miktari, @p_aciklama)", baglanti);
            command.Parameters.AddWithValue("@p_bilet_adi", TxtBiletAd.Text);
            command.Parameters.AddWithValue("@p_fiyat",  int.Parse(TxtBiletFiyat.Text));
            command.Parameters.AddWithValue("@p_stok_miktari", int.Parse(TxtBiletStok.Text));
            command.Parameters.AddWithValue("@p_aciklama", TxtBiletAcikmama.Text);

            command.ExecuteNonQuery(); 
            baglanti.Close();
            MessageBox.Show("Bilet Eklendi");

            TxtBiletAd.Clear();
            TxtBiletFiyat.Clear();
            TxtBiletStok.Clear();
            TxtBiletAcikmama.Clear();
        }

        private void Bilet_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand command = new NpgsqlCommand("Call public.bilet_guncelle(@p_bilet_id, @p_bilet_adi, @p_fiyat, @p_stok_miktari, @p_aciklama)", baglanti);

              
                int biletID = int.Parse(biletid.Text);

                command.Parameters.AddWithValue("@p_bilet_id", biletID);
                command.Parameters.AddWithValue("@p_bilet_adi", TxtBiletAd.Text);
                command.Parameters.AddWithValue("@p_fiyat", int.Parse(TxtBiletFiyat.Text));
                command.Parameters.AddWithValue("@p_stok_miktari", int.Parse(TxtBiletStok.Text));
                command.Parameters.AddWithValue("@p_aciklama", TxtBiletAcikmama.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Bilet Güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();

            }
        }

        private void Biletsil_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan silinecek biletin ID'sini girmesini iste
                string biletIdInput = Microsoft.VisualBasic.Interaction.InputBox("Silmek istediğiniz biletin ID'sini girin:", "Bilet Silme", "");

                // Girdinin boş olmadığını ve geçerli bir tamsayı olduğunu kontrol et
                if (!string.IsNullOrEmpty(biletIdInput) && int.TryParse(biletIdInput, out int biletID))
                {
                    baglanti.Open();

                    // Saklı yordamı çağır
                    NpgsqlCommand command = new NpgsqlCommand("CALL public.bilet_sil(@p_bilet_id)", baglanti);
                    command.Parameters.AddWithValue("@p_bilet_id", biletID);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Bilet Silindi");
                }
                else
                {
                    MessageBox.Show("Geçersiz Bilet ID. Lütfen geçerli bir tamsayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void BiletSatisi_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan satmak istediği bilet ID'sini al
                int biletID = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Satmak istediğiniz biletin ID'sini girin:", "Bilet ID", "", -1, -1));
                
                int biletsayisi = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Satmak istediğiniz bilet sayısını girin:", "Bilet sayısı", "", -1, -1));

                // PostgreSQL sorgusunu çalıştır
                baglanti.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand($"UPDATE biletsat SET  = stokMiktari - {biletsayisi}  WHERE biletid = {biletID};", baglanti))
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

        private void Ana_Menu_Geri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
