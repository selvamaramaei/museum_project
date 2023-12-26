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
    public partial class Form5 : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=odev; user ID=postgres; password=123456");
        public Form5()
        {
            InitializeComponent();
        } 
        // form 5 load olunca combo boxa mevcut bilet id leri yüklensin 
        private void Form5_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select biletid  from biletler order by biletid", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // bize isimler gözükecek ama arka planda id ile çalışılacak
            ziyaretcibiletidcombobox.DisplayMember = "biletid";
            ziyaretcibiletidcombobox.ValueMember = "biletid";
            ziyaretcibiletidcombobox.DataSource = dt;


            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select ziyaretciid  from ziyaretciler order by ziyaretciid", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            // bize isimler gözükecek ama arka planda id ile çalışılacak
            ziyaretciidComboBox.DisplayMember = "ziyaretciid";
            ziyaretciidComboBox.ValueMember = "ziyaretciid";
            ziyaretciidComboBox.DataSource = dt2;

            baglanti.Close();
        }

        private void Ziyaretci_listele_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Tüm ziyaretçi bilgilerini listele
                string sorgu = "SELECT * FROM Ziyaretciler order by ziyaretciid";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                // DataGridView kontrolüne verileri bind et
                dataGridView4.DataSource = dataTable;
                dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void BiletSatislari_listele_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan alınan BiletID değerini MessageBox ile kontrol et
                string biletIdInput = Microsoft.VisualBasic.Interaction.InputBox("Listelemek istediğiniz biletin ID'sini girin:", "Bilet Satışları Listeleme", "");

                // Girdinin boş olmadığını ve geçerli bir tamsayı olduğunu kontrol et
                if (!string.IsNullOrEmpty(biletIdInput) && int.TryParse(biletIdInput, out int biletID))
                {
                    baglanti.Open();

                    // Belirli bir BiletID'ye sahip ziyaretçileri listele
                    string sorgu = "SELECT * FROM Ziyaretciler WHERE BiletID = @biletID order by BiletID ";

                    NpgsqlCommand command = new NpgsqlCommand(sorgu, baglanti);
                    command.Parameters.AddWithValue("@biletID", biletID);

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);

                    // DataGridView kontrolüne verileri bind et
                    dataGridView4.DataSource = dataTable;
                    dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Geçerli bir BiletID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }// bilet idsinine göre ziyaretçileri listeliyor

        private void Ziyaretci_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Kullanıcının girdiği değerleri al
                string adi = ziyaretciad.Text;
                string soyadi = ziyaretcisoyad.Text;
                string telefonNumarasi = ziyaretcino.Text;
                string eposta = ziyaretcimail.Text;
                string adres = ziyaretciadres.Text;
                int biletID = int.Parse(ziyaretcibiletidcombobox.Text);

                // Saklı yordamı çağır
                NpgsqlCommand command = new NpgsqlCommand("ziyaretci_ekle", baglanti);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("p_adi", adi);
                command.Parameters.AddWithValue("p_soyadi", soyadi);
                command.Parameters.AddWithValue("p_telefon_numarasi", telefonNumarasi);
                command.Parameters.AddWithValue("p_eposta", eposta);
                command.Parameters.AddWithValue("p_adres", adres);
                command.Parameters.AddWithValue("p_bilet_id", biletID);

                command.ExecuteNonQuery();

                MessageBox.Show("Ziyaretçi Eklendi");

                // TextBox'ları temizle
                ziyaretciad.Clear();
                ziyaretcisoyad.Clear();
                ziyaretcino.Clear();
                ziyaretcimail.Clear();
                ziyaretciadres.Clear();
                ziyaretcibiletidcombobox.SelectedIndex = -1;
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

        private void Ziyaretci_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Kullanıcının girdiği değerleri al
                int ziyaretciID = int.Parse(ziyaretciidComboBox.Text);
                string adi = ziyaretciad.Text;
                string soyadi = ziyaretcisoyad.Text;
                string telefonNumarasi = ziyaretcino.Text;
                string eposta = ziyaretcimail.Text;
                string adres = ziyaretciadres.Text;
                int biletID = int.Parse(ziyaretcibiletidcombobox.Text);

                NpgsqlCommand command = new NpgsqlCommand("CALL ziyaretci_guncelle(@p_ziyaretci_id, @p_adi, @p_soyadi, @p_telefon_numarasi, @p_eposta, @p_adres, @p_bilet_id)", baglanti);
                command.Parameters.AddWithValue("@p_ziyaretci_id", ziyaretciID);
                command.Parameters.AddWithValue("@p_adi", adi);
                command.Parameters.AddWithValue("@p_soyadi", soyadi);
                command.Parameters.AddWithValue("@p_telefon_numarasi", telefonNumarasi);
                command.Parameters.AddWithValue("@p_eposta", eposta);
                command.Parameters.AddWithValue("@p_adres", adres);
                command.Parameters.AddWithValue("@p_bilet_id", biletID);

                command.ExecuteNonQuery();

                MessageBox.Show("Ziyaretçi Güncellendi");
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

        private void Zyaretci_yorum_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Tüm ziyaretçi bilgilerini listele
                string sorgu = "SELECT * FROM ziyaretcigeribildirimleri order by ziyaretciid";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                // DataGridView kontrolüne verileri bind et
                dataGridView4.DataSource = dataTable;
                dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
