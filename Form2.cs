using System;
using Npgsql;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Microsoft.VisualBasic;

namespace VTYS_deneme3
{
    public partial class Form2 : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=odev; user ID=postgres; password=123456");

        public Form2()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select sanatciid, adisoyadi from sanatcilar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // bize isimler gözükecek ama arka planda id ile çalışılacak
            Sanatci_isim_comboBox.DisplayMember = "AdiSoyadi";
            Sanatci_isim_comboBox.ValueMember = "sanatciid";
            Sanatci_isim_comboBox.DataSource = dt;
            baglanti.Close();
        }
        // veritabanına veri ekleme
        private void Eser_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT eser_ekle(@p_eseradi, @p_santiciAdSoyad, @p_yapimyili, @p_tur, @p_eseraciklama)", baglanti);
            command.Parameters.AddWithValue("p_eseradi", txtEserAdi.Text);
            command.Parameters.AddWithValue("p_santiciAdSoyad", Sanatci_isim_comboBox.Text);
            command.Parameters.AddWithValue("p_yapimyili", int.Parse(TxtYapimYili.Text));
            command.Parameters.AddWithValue("p_tur", txtTur.Text);
            command.Parameters.AddWithValue("p_eseraciklama", txtEserAciklama.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Eser Eklendi");
            // Tüm textbox'ları temizle
            txtEserAdi.Text = "";
            Sanatci_isim_comboBox.SelectedIndex = -1; // veya .Text = ""; - bağlı olduğunuz duruma bağlı
            TxtYapimYili.Text = "";
            txtTur.Text = "";
            txtEserAciklama.Text = "";

        }

        // veritabınından veri çekme
        private void Eser_bilgi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT Eserler.EserID, Eserler.EserAdi, Sanatcilar.AdiSoyadi AS SanatciAdSoyad, Eserler.YapimYili, Eserler.Tur, Eserler.EserAciklamasi FROM Eserler JOIN Sanatcilar ON Eserler.SanatciID = Sanatcilar.SanatciID  order by eserid";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
            dataGridView1.Refresh();
        }

        // veritabanından veri silmek 
        private void Eser_cikar_Click(object sender, EventArgs e)
        {
            
            string eserAdi = Microsoft.VisualBasic.Interaction.InputBox("Çıkarmak İstediğiniz Eserin Adını Giriniz (camel case giriniz)", "Eser Arama", "");

            if (string.IsNullOrEmpty(eserAdi))
                return;

            baglanti.Open();


            NpgsqlCommand checkCommand = new NpgsqlCommand("SELECT COUNT(*) FROM \"eserler\" WHERE \"eseradi\" = @eserAdi", baglanti);
            checkCommand.Parameters.AddWithValue("@eserAdi", eserAdi);
            int eserCount = Convert.ToInt32(checkCommand.ExecuteScalar());

            if (eserCount > 0)
            {
                // Eğer eser varsa kullanıcıya sor
                DialogResult result = MessageBox.Show("Eseri silinsin mi?", "Eser Silme", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // PostgreSQL fonksiyonunu çağır
                    NpgsqlCommand command = new NpgsqlCommand("SELECT eser_cikar(@eserAdi)", baglanti);
                    command.Parameters.AddWithValue("@eseradi", eserAdi);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Eser silindi.");
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Close();
                }
         
            }
            else
            {
                MessageBox.Show("Belirtilen eser bulunamadı.", "Hata");
            }
            baglanti.Close();

        }

        // veritabanından veri güncelleme 
        private void Eser_Guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            // Seçilen sanatçının adını al
            string sanatciAdSoyad = Sanatci_isim_comboBox.Text;

            // Sanatçının ID'sini al
            NpgsqlCommand sanatciCommand = new NpgsqlCommand("SELECT sanatciid FROM sanatcilar WHERE AdiSoyadi = @adiSoyadi", baglanti);
            sanatciCommand.Parameters.AddWithValue("@adiSoyadi", sanatciAdSoyad);
            int sanatciID = Convert.ToInt32(sanatciCommand.ExecuteScalar());

            // Kontrol et: Eser tablosunda böyle bir eser var mı?
            NpgsqlCommand eserCheckCommand = new NpgsqlCommand("SELECT COUNT(*) FROM eserler WHERE eseradi = @p_eseradi", baglanti);
            eserCheckCommand.Parameters.AddWithValue("@p_eseradi", txtEserAdi.Text);
            int eserCount = Convert.ToInt32(eserCheckCommand.ExecuteScalar());

            if (eserCount > 0)
            {
                // Eseri güncelle
                NpgsqlCommand updateCommand = new NpgsqlCommand("UPDATE eserler SET eseradi = @p_eseradi, sanatciid = @p_sanatciid, yapimyili = @p_yapimyili, tur = @p_tur, eseraciklamasi = @p_eseraciklama WHERE eseradi = @p_eseradi", baglanti);
                updateCommand.Parameters.AddWithValue("@p_eseradi", txtEserAdi.Text);
                updateCommand.Parameters.AddWithValue("@p_sanatciid", sanatciID);
                if (!string.IsNullOrEmpty(TxtYapimYili.Text))
                {
                    updateCommand.Parameters.AddWithValue("@p_yapimyili", int.Parse(TxtYapimYili.Text));
                }
                else
                {
                    updateCommand.Parameters.AddWithValue("@p_yapimyili", DBNull.Value);
                }
                updateCommand.Parameters.AddWithValue("@p_tur", txtTur.Text);
                updateCommand.Parameters.AddWithValue("@p_eseraciklama", txtEserAciklama.Text);

                updateCommand.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Eser Güncellendi");
            }
            else
            {
                MessageBox.Show("Böyle bir eser mevcut değil.");
                baglanti.Close();
            }
            // Tüm textbox'ları temizle
            txtEserAdi.Text = "";
            Sanatci_isim_comboBox.SelectedIndex = -1; 
            TxtYapimYili.Text = "";
            txtTur.Text = "";
            txtEserAciklama.Text = "";

        }

        private void Ana_Menu_Geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            

        }

    }
}
