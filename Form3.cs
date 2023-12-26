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
    public partial class Form3 : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=odev; user ID=postgres; password=123456");

        public Form3()
        {
            InitializeComponent();
        }

        private void SanatciAra(string sanatciBilgi)
        {
            baglanti.Open();

            // Kullanıcıdan alınan bilgiye göre sorgu yap
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM sanatcilar WHERE SanatciID = @p_sanatci_id OR AdiSoyadi = @p_adi_soyadi", baglanti);
            command.Parameters.AddWithValue("@p_sanatci_id", DBNull.Value);
            command.Parameters.AddWithValue("@p_adi_soyadi", DBNull.Value);

            // Kullanıcının girdiği bilgiye göre parametreleri ayarla
            if (int.TryParse(sanatciBilgi, out int sanatciID))
            {
                command.Parameters["@p_sanatci_id"].Value = sanatciID;
            }
            else
            {
                command.Parameters["@p_adi_soyadi"].Value = sanatciBilgi;
            }

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            dataGridView2.DataSource = dataTable;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            baglanti.Close();
        }

        private void sanatci_ara_Click(object sender, EventArgs e)
        {
            string sanatciBilgi = Microsoft.VisualBasic.Interaction.InputBox("Sanatçı Bilgisi (ID veya Adı Soyadı):", "Sanatçı Ara");

            if (!string.IsNullOrWhiteSpace(sanatciBilgi))
            {
                SanatciAra(sanatciBilgi);
            }
            else
            {
                MessageBox.Show("Sanatçı bilgisi boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        
        private void Sanatci_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command = new NpgsqlCommand(
                   "INSERT INTO sanatcilar (AdiSoyadi, DogumTarihi, OlumTarihi, Ulke, SanatAkimi) " +
                   "VALUES (@p_santiciAdSoyad, @p_dogumTarihi, @p_olumTarihi, @p_ulke, @p_sanatAkimi)", baglanti);
            command.Parameters.AddWithValue("p_santiciAdSoyad", TxtSanatciAd.Text);
            command.Parameters.AddWithValue("p_dogumTarihi", SanatciDogumDate.Value);
            command.Parameters.AddWithValue("p_olumTarihi", SanatciOlumDate.Value);
            command.Parameters.AddWithValue("p_ulke", TxtUlke.Text);
            command.Parameters.AddWithValue("p_sanatAkimi", TxtSanatAkim.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni Sanatçı Eklendi");

            TxtSanatciAd.Clear();
            SanatciDogumDate.Value = DateTime.Now; 
            SanatciOlumDate.Value = DateTime.Now; 
            TxtUlke.Clear();
            TxtSanatAkim.Clear();

        }

        private void Sanatci_bilgi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT * from sanatcilar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            baglanti.Close();
            dataGridView2.Refresh();

        }

        private void Sanatci_eser_listele_Click(object sender, EventArgs e)
        {
            string sanatciAdSoyad = Microsoft.VisualBasic.Interaction.InputBox("Sanatçının Adı Soyadı:", "Sanatçıya Ait Eserleri Listele");

            baglanti.Open();

            // Sanatçının ID'sini al
            NpgsqlCommand sanatciCommand = new NpgsqlCommand("SELECT sanatciid FROM sanatcilar WHERE AdiSoyadi = @adiSoyadi", baglanti);
            sanatciCommand.Parameters.AddWithValue("@adiSoyadi", sanatciAdSoyad);
            int sanatciID = Convert.ToInt32(sanatciCommand.ExecuteScalar());

            // Sanatçıya ait eserleri listele
            string sorgu = "SELECT EserID, EserAdi, YapimYili, Tur, EserAciklamasi FROM Eserler WHERE sanatciid = @sanatciID";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);

            // NpgsqlDataAdapter'ın SelectCommand özelliğini kontrol et
            if (da.SelectCommand == null)
            {
                da.SelectCommand = new NpgsqlCommand();
            }

            da.SelectCommand.CommandText = sorgu;
            da.SelectCommand.Parameters.AddWithValue("@sanatciID", sanatciID);

            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            dataGridView2.DataSource = dataTable;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            baglanti.Close();
            dataGridView2.Refresh();

        }

        private void Sanatci_Guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            // Seçilen sanatçının ID'sini al
            NpgsqlCommand sanatciCommand = new NpgsqlCommand("SELECT sanatciid FROM sanatcilar WHERE adiSoyadi = @adiSoyadi", baglanti);
            sanatciCommand.Parameters.AddWithValue("@adiSoyadi", TxtSanatciAd.Text);
            int sanatciID = Convert.ToInt32(sanatciCommand.ExecuteScalar());

            // Sanatçıyı güncelle
            NpgsqlCommand updateCommand = new NpgsqlCommand("UPDATE sanatcilar SET adisoyadi = @p_adi_soyadi, dogumtarihi = @p_dogum_tarihi, olumtarihi = @p_olum_tarihi, ulke = @p_ulke, sanatakimi = @p_sanat_akimi WHERE sanatciid = @p_id", baglanti);
            updateCommand.Parameters.AddWithValue("@p_id", sanatciID);
            updateCommand.Parameters.AddWithValue("@p_adi_soyadi", TxtSanatciAd.Text);
            updateCommand.Parameters.AddWithValue("@p_dogum_tarihi", SanatciDogumDate.Value); 
            updateCommand.Parameters.AddWithValue("@p_olum_tarihi", SanatciOlumDate.Value);   
            updateCommand.Parameters.AddWithValue("@p_ulke", TxtUlke.Text);
            updateCommand.Parameters.AddWithValue("@p_sanat_akimi", TxtSanatAkim.Text);

            updateCommand.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Sanatçı Güncellendi");

        }

        private void Sanatci_cikar_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan sanatçı bilgisi al
            string sanatciAdSoyad = Microsoft.VisualBasic.Interaction.InputBox("Sanatçının Adı Soyadı:", "Sanatçı Çıkar");

            if (!string.IsNullOrWhiteSpace(sanatciAdSoyad))
            {
                baglanti.Open();

                // Sanatçının ID'sini al
                NpgsqlCommand sanatciCommand = new NpgsqlCommand("SELECT SanatciID FROM sanatcilar WHERE AdiSoyadi = @adiSoyadi", baglanti);
                sanatciCommand.Parameters.AddWithValue("@adiSoyadi", sanatciAdSoyad);
                int sanatciID = Convert.ToInt32(sanatciCommand.ExecuteScalar());

                // Sanatçıya ait eserleri sil
                NpgsqlCommand eserSilCommand = new NpgsqlCommand("DELETE FROM Eserler WHERE SanatciID = @sanatciID", baglanti);
                eserSilCommand.Parameters.AddWithValue("@sanatciID", sanatciID);
                eserSilCommand.ExecuteNonQuery();

                // Sanatçıyı sil
                NpgsqlCommand sanatciSilCommand = new NpgsqlCommand("DELETE FROM sanatcilar WHERE SanatciID = @sanatciID", baglanti);
                sanatciSilCommand.Parameters.AddWithValue("@sanatciID", sanatciID);
                sanatciSilCommand.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Sanatçı ve Sanatçıya Ait Eserler Başarıyla Silindi");
            }
            else
            {
                MessageBox.Show("Sanatçı bilgisi boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Geri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Ana_Menu_Geri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
