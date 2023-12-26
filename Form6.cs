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
    public partial class Form6 : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=odev; user ID=postgres; password=123456");
        public Form6()
        {
            InitializeComponent();
        }

        private void calisan_listele_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT * FROM \"Calisanlar\"";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);

                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                dataGridView5.DataSource = dataTable;
                dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void Personel_listele_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT * FROM \"Personel\"";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);

                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                dataGridView5.DataSource = dataTable;
                dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void Yonetici_listele_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT * FROM \"Yoneticiler\"";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);

                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                dataGridView5.DataSource = dataTable;
                dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        

        private void calisan_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan çalışan bilgilerini al
                int personelNO = int.Parse(TxtpersonelNo.Text);
                int maas = int.Parse(TxtMaas.Text);
                string adSoyad = TxtAdSoyad.Text;
                string Tur = TurcomboBox.Text;  // TurcomboBox'ın Text özelliğini alıyoruz

                // Sorguyu hazırla ve çalıştır
                string sorgu = "INSERT INTO \"Calisanlar\" (\"personelNo\",\"adisoyadi\",\"turu\", \"maas\") VALUES (@PersonelNo,@adSoyad, @Tur, @maas)";

                using (NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti))
                {
                    baglanti.Open();  // Burada bağlantıyı açıyoruz

                    komut.Parameters.AddWithValue("@personelNo", personelNO);
                    komut.Parameters.AddWithValue("@maas", maas);
                    komut.Parameters.AddWithValue("@adSoyad", adSoyad);
                    komut.Parameters.AddWithValue("@Tur", Tur);

                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show("Çalışan başarıyla eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Çalışan eklenirken bir hata oluştu.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();  // Bağlantıyı kapatmak için finally bloğu içinde
            }
        }

        private void calisanSil_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan personel numarasını al
                string personelNOString = Microsoft.VisualBasic.Interaction.InputBox("Silmek istediğiniz çalışanın Personel No'sunu girin:", "Çalışan Sil", "");

                // Personel numarası boşsa veya geçerli bir sayı değilse işlemi iptal et
                if (string.IsNullOrEmpty(personelNOString) || !int.TryParse(personelNOString, out int personelNO))
                {
                    MessageBox.Show("Geçerli bir Personel No giriniz.");
                    return;
                }

                baglanti.Open();

                // Sorguyu hazırla ve çalıştır
                string sorgu = "DELETE FROM \"Calisanlar\" WHERE \"personelNo\" = @personelNO";

                using (NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@personelNO", personelNO);

                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show("Çalışan başarıyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen Personel No'ya sahip çalışan bulunamadı.");
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

        private void Ana_Menu_Geri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
