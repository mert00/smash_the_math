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
    public partial class sonuclar : Form
    {
        public sonuclar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scoreboard scoreboard = new scoreboard();
            scoreboard.Show();
            this.Close();
        }

        private void profile_buton_Click(object sender, EventArgs e)
        {
            start_basla start = new start_basla();
            start.Show();
            this.Close();
        }
    }
}
