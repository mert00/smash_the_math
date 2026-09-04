using skor_tablo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smash_The_Math
{
    public partial class hakkimizda : Form
    {
        public hakkimizda()
        {
            InitializeComponent();
        }

        private void profile_buton_Click(object sender, EventArgs e)
        {
            start_basla start = new start_basla();
            start.Show();
            this.Close();
        }

        private void profile_buton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hedef URL
            string url = "https://www.linkedin.com/in/mete-yusuf-gündoğdu-9b97202a9/";

            try
            {
                // Varsayılan tarayıcıda URL'yi aç
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı açılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hedef URL
            string url = "https://www.linkedin.com/in/tuğba-nur-4a5321332/";

            try
            {
                // Varsayılan tarayıcıda URL'yi aç
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı açılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Hedef URL
            string url = "https://www.linkedin.com/in/mert-kapar-b49a20249/";

            try
            {
                // Varsayılan tarayıcıda URL'yi aç
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı açılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
