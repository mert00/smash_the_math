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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            txtsifre.PasswordChar = '•';
            txtsifreonayla.PasswordChar = '•';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signin girisFormu = new signin(); // Giriş ekranını açıyoruz
            girisFormu.Show(); // Giriş ekranını gösteriyoruz
            this.Close(); // Kayıt ekranını kapatıyoruz
        }


        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            // Şifreyi göster kutusu işaretli ise şifreyi düz metin olarak gösterir, değilse gizler
            txtsifre.PasswordChar = chkSifreGoster.Checked ? '\0' : '•';
            txtsifreonayla.PasswordChar = chkSifreGoster.Checked ? '\0' : '•';
        }

        private void kayit_ol_Click(object sender, EventArgs e)
        {
            // Gerekli alanların doldurulup doldurulmadığını kontrol ediyoruz
            if (string.IsNullOrEmpty(txtkullaniciadi.Text) ||
                string.IsNullOrEmpty(txteposta.Text) ||
                string.IsNullOrEmpty(txtsifre.Text) ||
                string.IsNullOrEmpty(txtsifreonayla.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(GlobalVariables.ConnectionString))
                {
                    con.Open();

                    // Kullanıcı adı mevcut mu kontrol et
                    string checkUsernameQuery = "SELECT COUNT(1) FROM dbo.KullaniciTablosu WHERE kullanici_adi = @kullanici_adi";
                    using (SqlCommand checkUsernameCmd = new SqlCommand(checkUsernameQuery, con))
                    {
                        checkUsernameCmd.Parameters.AddWithValue("@kullanici_adi", txtkullaniciadi.Text);
                        int usernameCount = Convert.ToInt32(checkUsernameCmd.ExecuteScalar());

                        if (usernameCount > 0)
                        {
                            MessageBox.Show("Bu kullanıcı adı zaten alınmış. Lütfen başka bir kullanıcı adı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtkullaniciadi.Text = "";
                            txteposta.Text = "";
                            txtsifre.Text = "";
                            txtsifreonayla.Text = "";
                            txtkullaniciadi.Focus();
                            return;
                        }
                    }

                    // E-posta mevcut mu kontrol et
                    string checkEmailQuery = "SELECT COUNT(1) FROM dbo.KullaniciTablosu WHERE e_posta = @e_posta";
                    using (SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, con))
                    {
                        checkEmailCmd.Parameters.AddWithValue("@e_posta", txteposta.Text);
                        int emailCount = Convert.ToInt32(checkEmailCmd.ExecuteScalar());

                        if (emailCount > 0)
                        {
                            MessageBox.Show("Bu e-posta adresi zaten alınmış. Lütfen başka bir e-posta giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtkullaniciadi.Text = "";
                            txteposta.Text = "";
                            txtsifre.Text = "";
                            txtsifreonayla.Text = "";
                            txtkullaniciadi.Focus();
                            return;
                        }
                    }

                    // E-posta adresinin geçerliliğini kontrol et
                    string email = txteposta.Text;
                    string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Basit bir e-posta regex patterni
                    if (!Regex.IsMatch(email, emailPattern))
                        {
                            MessageBox.Show("Geçerli bir e-posta adresi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Şifre ve şifre onayı aynı mı kontrol ediyoruz
                        if (txtsifre.Text != txtsifreonayla.Text)
                        {
                            MessageBox.Show("Şifreler uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtsifreonayla.Text = "";
                            txtsifreonayla.Focus();
                            return;
                        }
                    // Kullanıcıyı ekle
                    string query = "INSERT INTO dbo.KullaniciTablosu (kullanici_adi, e_posta, sifre) VALUES (@kullanici_adi, @e_posta, @sifre)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@kullanici_adi", txtkullaniciadi.Text);
                        cmd.Parameters.AddWithValue("@e_posta", txteposta.Text);
                        cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kayıt başarılı! Şimdi giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Giriş ekranına geçiş
                signin signinForm = new signin();
                signinForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void temizle_butonu_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre alanlarını temizliyoruz.
            txtkullaniciadi.Text = "";
            txteposta.Text = "";
            txtsifre.Text = "";
            txtsifreonayla.Text = "";

            // İmleci kullanıcı adı alanına odaklıyoruz.
            txtkullaniciadi.Focus();
        }

        private void frmRegister_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter tuşuna basıldığında "Kayıt Ol" butonuna tıkla
            if (e.KeyCode == Keys.Enter)
            {
                kayit_ol.PerformClick(); // Kayıt Ol butonuna tıklar
            }
        }
    }
}