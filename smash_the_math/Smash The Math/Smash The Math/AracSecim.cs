using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smash_The_Math
{
    public partial class AracSecim : Form
    {
        // Seçilen arabanın ön ekini (renk) tutacak değişken
        private string secilenAracPrefix = "";

        // Dışarıdan erişilecek olan seçilmiş araba yolları
        public string SecilenAracPath { get; private set; }
        public string SecilenEzilmisAracPath { get; private set; }


        public AracSecim()
        {
            InitializeComponent();
        }

        private void AracSecim_Load(object sender, EventArgs e)
        {
            // Başlangıçta buton pasif olsun, seçim yapılınca aktifleşsin
            btnOyunaBasla.Enabled = false;
        }

        // Seçim yapıldığında görsel geri bildirim vermek için ortak bir metot
        private void ResetBorders()
        {
            pictureBoxRed.BorderStyle = BorderStyle.None;
            pictureBoxBlue.BorderStyle = BorderStyle.None;
            pictureBoxGreen.BorderStyle = BorderStyle.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxRed_Click(object sender, EventArgs e)
        {
            secilenAracPrefix = "red";
            ResetBorders();
            pictureBoxRed.BorderStyle = BorderStyle.FixedSingle; // Seçileni belirt
            btnOyunaBasla.Enabled = true; // Butonu aktifleştir
        }

        private void pictureBoxBlue_Click(object sender, EventArgs e)
        {
            secilenAracPrefix = "blue";
            ResetBorders();
            pictureBoxBlue.BorderStyle = BorderStyle.FixedSingle;
            btnOyunaBasla.Enabled = true;
        }

        private void pictureBoxGreen_Click(object sender, EventArgs e)
        {
            secilenAracPrefix = "green";
            ResetBorders();
            pictureBoxGreen.BorderStyle = BorderStyle.FixedSingle;
            btnOyunaBasla.Enabled = true;
        }

        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(secilenAracPrefix))
            {
                MessageBox.Show("Lütfen bir araç seçin!");
                return;
            }

            // Seçime göre dosya yollarını oluştur
            string basePath = @"C:\Görsel Ve Mat Proje\img\";
            SecilenAracPath = $"{basePath}{secilenAracPrefix} car.png";
            SecilenEzilmisAracPath = $"{basePath}crushed {secilenAracPrefix} car.png";

            // Formun başarıyla kapatıldığını belirt
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
