using skor_tablo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smash_The_Math
{
    public partial class start_basla : Form
    {
        public start_basla()
        {
            InitializeComponent();
        }

        // --- DEĞİŞİKLİK BU METOTTA YAPILDI ---
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Yeni açılacak olan araç seçim formunu oluştur.
            AracSecim aracSecimFormu = new AracSecim();

            // 2. Yeni formun boyutunu ve konumunu, bu formla aynı yap.
            aracSecimFormu.Size = this.Size;
            aracSecimFormu.Location = this.Location;

            // --- PÜRÜZSÜZ GEÇİŞ İÇİN EN ÖNEMLİ KISIM ---
            // 3. Ana menüyü görünmez yap (AMA KAPATMA). Opacity=0, formu tamamen şeffaf yapar.
            this.Opacity = 0;
            // ---------------------------------------------

            // 4. Formu bir diyalog olarak göster ve sonucunu BEKLE.
            //    Ana form şeffaf olduğu için kullanıcı sadece bu yeni formu görür.
            DialogResult result = aracSecimFormu.ShowDialog();

            // 5. Araç seçim formu kapandıktan sonra, gelen sonuca göre kontrol et.
            if (result == DialogResult.OK)
            {
                // Kullanıcı "Oyuna Başla"ya bastıysa:

                // Seçim formundan araba resimlerinin yollarını al
                string normalAracPath = aracSecimFormu.SecilenAracPath;
                string ezilmisAracPath = aracSecimFormu.SecilenEzilmisAracPath;

                // Oyunu, seçilen araba bilgileriyle başlat
                ingame gameForm = new ingame(normalAracPath, ezilmisAracPath);

                // Oyun formunun da aynı konumda başlamasını sağlayabiliriz.
                gameForm.Location = aracSecimFormu.Location;
                gameForm.Size = aracSecimFormu.Size;

                gameForm.Show();

                // Oyun başladığı için artık ana menüye ihtiyaç kalmadı, tamamen kapat.
                // Opacity'yi geri 1 yapmaya gerek yok çünkü form kapanıyor.
                this.Close();
            }
            else
            {
                // Kullanıcı seçim yapmadan pencereyi kapattıysa:

                // 6. Ana menüyü tekrar görünür yap.
                this.Opacity = 1;
            }
        }

        private void skor_tablo_buton_Click(object sender, EventArgs e)
        {
            scoreboard scoreboard = new scoreboard();
            scoreboard.Show();
            this.Close();
        }

        private void profile_buton_Click(object sender, EventArgs e)
        {
            kullanici_profil kullanici_Profil = new kullanici_profil();
            kullanici_Profil.Show();
            this.Close();
        }

        private void profile_buton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hakkimizda hakkimizda = new hakkimizda();
            hakkimizda.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teaching teaching = new teaching();
            teaching.Show();
            this.Close();
        }
    }
}