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
    public partial class teaching : Form
    {
        public teaching()
        {
            InitializeComponent();
        }

        private void teaching_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Görsel Ve Mat Proje\img\nasil_oynanir_2.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
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
    }
}
