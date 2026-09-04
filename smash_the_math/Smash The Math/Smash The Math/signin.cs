using Smash_The_Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Görsel_Programlama_Oyunu
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
            // Şifrenin gizlenmesini sağlamak için PasswordChar özelliğini ayarlıyoruz.
            txtsifre.PasswordChar = '•';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister kayitFormu = new frmRegister(); // Kayıt ekranını açıyoruz
            kayitFormu.Show(); // Kayıt ekranını gösteriyoruz
            this.Hide(); // Giriş ekranını gizliyoruz
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı veya şifre boşsa uyarı ver
            if (txtkullaniciadi.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifreyi girin.");
                return;
            }

            try
            {
                // SQL bağlantısını aç
                //string connectionString = @"Data Source=DESKTOP-PR7BV4J\SQLEXPRESS;Initial Catalog=SmashTheMathDB;Integrated Security=True";

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Veritabani\SmashTheMathDB.mdf;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Kullanıcı adı olup olmadığını kontrol et
                    string checkUserQuery = "SELECT COUNT(1) FROM KullaniciTablosu WHERE kullanici_adi = @kullanici_adi";
                    using (SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, con))
                    {
                        checkUserCmd.Parameters.AddWithValue("@kullanici_adi", txtkullaniciadi.Text);
                        int userExists = Convert.ToInt32(checkUserCmd.ExecuteScalar());

                        if (userExists == 0)
                        {
                            // Kullanıcı adı bulunamadıysa
                            MessageBox.Show("Hesabınız bulunamadı, lütfen kayıt olunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtkullaniciadi.Text = "";
                            txtsifre.Text = "";
                            txtkullaniciadi.Focus();
                            return;
                        }
                    }

                    // Kullanıcı adı mevcutsa şifreyi kontrol et
                    string checkPasswordQuery = "SELECT COUNT(1) FROM KullaniciTablosu WHERE kullanici_adi = @kullanici_adi AND sifre = @sifre";
                    using (SqlCommand checkPasswordCmd = new SqlCommand(checkPasswordQuery, con))
                    {
                        checkPasswordCmd.Parameters.AddWithValue("@kullanici_adi", txtkullaniciadi.Text);
                        checkPasswordCmd.Parameters.AddWithValue("@sifre", txtsifre.Text);

                        int validCredentials = Convert.ToInt32(checkPasswordCmd.ExecuteScalar());

                        if (validCredentials == 1)
                        {
                            // Giriş başarılı, ana formu aç
                            MessageBox.Show("Giriş başarılı!");

                            // Kullanıcı giriş yaptı, kullanıcı adını global değişkene at
                            GlobalVariables.KullaniciAdi = txtkullaniciadi.Text;

                            // Ana formu aç
                            start_basla startBasla = new start_basla();
                            startBasla.Show();
                            this.Hide(); // Giriş formunu gizle
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtkullaniciadi.Text = "";
                            txtsifre.Text = "";
                            txtkullaniciadi.Focus();
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında bir hata oluştu: " + ex.Message);
            }
        }

        private void chkSifreGoster_CheckedChanged_1(object sender, EventArgs e)
        {
            // Şifreyi göster kutusu işaretli ise şifreyi düz metin olarak gösterir, değilse gizler
            txtsifre.PasswordChar = chkSifreGoster.Checked ? '\0' : '•';
        }

        private void temizle_butonu_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre alanlarını temizliyoruz.
            txtkullaniciadi.Text = "";
            txtsifre.Text = "";


            // İmleci kullanıcı adı alanına odaklıyoruz.
            txtkullaniciadi.Focus();
        }

        private void signin_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter tuşuna basıldığında "Giriş Yap" butonuna tıkla
            if (e.KeyCode == Keys.Enter)
            {
                giris_yap.PerformClick(); // Giriş Yap butonuna tıklar
            }
        }
    }
}