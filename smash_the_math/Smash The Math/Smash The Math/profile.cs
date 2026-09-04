using Görsel_Programlama_Oyunu;
using Smash_The_Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace skor_tablo
{
    public partial class kullanici_profil : Form
    {

        public kullanici_profil()
        {
            InitializeComponent();
        }
        private void cıkis_Click(object sender, EventArgs e)
        {
            GlobalVariables.KullaniciAdi = ""; // Global değişkeni sıfırla
            signin signin = new signin();
            signin.Show();
            this.Hide();
        }

        private void bilgilerim_Click(object sender, EventArgs e)
        {
            bilgi_panel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start_basla start = new start_basla();
            start.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Profil Fotoğrafını Seç";
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = openFileDialog.FileName;

                // Seçilen fotoğrafı PictureBox'a yükle
                pictureBox2.Image = Image.FromFile(selectedPath);

                // Veritabanında güncelle
                try
                {
                    using (SqlConnection con = new SqlConnection(GlobalVariables.ConnectionString))
                    {
                        con.Open();

                        string query = "UPDATE KullaniciTablosu SET profil_foto = @profil_foto WHERE kullanici_adi = @kullanici_adi";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@profil_foto", selectedPath);
                            cmd.Parameters.AddWithValue("@kullanici_adi", GlobalVariables.KullaniciAdi);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Profil fotoğrafı başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void kullanici_profil_Load(object sender, EventArgs e)
        {
            label3.Text = GlobalVariables.KullaniciAdi; // Kullanıcı adını göster
            textBox1.Text = GlobalVariables.KullaniciAdi; // Kullanıcı adını textBox1'e yerleştir

            // E-posta bilgisini veritabanından al ve textBox2'ye yerleştir
            try
            {
                using (SqlConnection con = new SqlConnection(GlobalVariables.ConnectionString))
                {
                    con.Open();

                    string query = "SELECT e_posta FROM KullaniciTablosu WHERE kullanici_adi = @kullanici_adi";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@kullanici_adi", GlobalVariables.KullaniciAdi);
                        string eposta = cmd.ExecuteScalar()?.ToString();

                        // E-posta veritabanından alındıysa, textBox2'ye yerleştir
                        if (!string.IsNullOrEmpty(eposta))
                        {
                            textBox2.Text = eposta;
                        }
                        else
                        {
                            textBox2.Text = "E-posta bulunamadı.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Profil fotoğrafını yükle
            try
            {
                string fotoPath = null;

                using (SqlConnection con = new SqlConnection(GlobalVariables.ConnectionString))
                {
                    con.Open();

                    string query = "SELECT profil_foto FROM KullaniciTablosu WHERE kullanici_adi = @kullanici_adi";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@kullanici_adi", GlobalVariables.KullaniciAdi);
                        fotoPath = cmd.ExecuteScalar()?.ToString();

                        if (!string.IsNullOrEmpty(fotoPath) && File.Exists(fotoPath))
                        {
                            pictureBox2.Image = Image.FromFile(fotoPath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profil fotoğrafı yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Toplam puanı yükle
            try
            {
                using (SqlConnection con = new SqlConnection(GlobalVariables.ConnectionString))
                {
                    con.Open();

                    string query = "SELECT skor FROM KullaniciTablosu WHERE kullanici_adi = @kullanici_adi";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@kullanici_adi", GlobalVariables.KullaniciAdi);
                        string toplamPuan = cmd.ExecuteScalar()?.ToString();

                        if (!string.IsNullOrEmpty(toplamPuan))
                        {
                            textBox3.Text = toplamPuan; // Toplam puanı textBox3'e yerleştir
                        }
                        else
                        {
                            textBox3.Text = "0"; // Eğer puan yoksa 0 göster
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Toplam puan yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   
}
