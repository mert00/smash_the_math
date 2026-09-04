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

namespace skor_tablo
{
    public partial class scoreboard : Form
    {
        public scoreboard()
        {
            InitializeComponent();
        }
        private void scoreboard_Shown(object sender, EventArgs e)
        {
            // Veritabanı bağlantısını yap
            using (SqlConnection con = new SqlConnection(GlobalVariables.ConnectionString))
            {
                try
                {
                    con.Open();
                    // Skorları büyükten küçüğe doğru sırala ve sıralama sütunu oluştur
                    string query = @"
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY skor DESC) AS Sıralama,
                    kullanici_adi AS [Kullanıcı Adı],
                    skor AS [Toplam Puan]
                FROM dbo.KullaniciTablosu
                WHERE skor > 0"; // Sadece skoru olanları göster

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // DataGridView'i temizle ve verileri yükle
                        dataGridView1.Columns.Clear(); // Önceki sütunları temizle
                        dataGridView1.DataSource = dt;

                        // DataGridView ayarlarını yap
                        dataGridView1.Columns["Sıralama"].ReadOnly = true;
                        dataGridView1.Columns["Kullanıcı Adı"].ReadOnly = true;
                        dataGridView1.Columns["Toplam Puan"].ReadOnly = true;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yükleme sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void skor_anasyf_don_Click(object sender, EventArgs e)
        {
            start_basla start = new start_basla();
            start.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
