namespace Smash_The_Math
{
    partial class ingame
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingame));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kalp = new System.Windows.Forms.PictureBox();
            this.cansayisi = new System.Windows.Forms.Label();
            this.bolumler = new System.Windows.Forms.Label();
            this.pressbox = new System.Windows.Forms.PictureBox();
            this.arababox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surelabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.sorularbox = new System.Windows.Forms.ListBox();
            this.cevapbox = new System.Windows.Forms.TextBox();
            this.gonderbutonu = new System.Windows.Forms.Button();
            this.ana_syf = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kalp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arababox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(607, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(16, 453);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(155, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(16, 453);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // kalp
            // 
            this.kalp.BackColor = System.Drawing.Color.Transparent;
            this.kalp.Image = ((System.Drawing.Image)(resources.GetObject("kalp.Image")));
            this.kalp.Location = new System.Drawing.Point(32, 38);
            this.kalp.Name = "kalp";
            this.kalp.Size = new System.Drawing.Size(90, 106);
            this.kalp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kalp.TabIndex = 3;
            this.kalp.TabStop = false;
            // 
            // cansayisi
            // 
            this.cansayisi.AutoSize = true;
            this.cansayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cansayisi.Location = new System.Drawing.Point(52, 147);
            this.cansayisi.Name = "cansayisi";
            this.cansayisi.Size = new System.Drawing.Size(52, 55);
            this.cansayisi.TabIndex = 4;
            this.cansayisi.Text = "3";
            // 
            // bolumler
            // 
            this.bolumler.AutoSize = true;
            this.bolumler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bolumler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolumler.ForeColor = System.Drawing.Color.Black;
            this.bolumler.Location = new System.Drawing.Point(31, 268);
            this.bolumler.Name = "bolumler";
            this.bolumler.Size = new System.Drawing.Size(92, 27);
            this.bolumler.TabIndex = 5;
            this.bolumler.Text = "1.Bölüm";
            // 
            // pressbox
            // 
            this.pressbox.BackColor = System.Drawing.Color.Transparent;
            this.pressbox.Image = ((System.Drawing.Image)(resources.GetObject("pressbox.Image")));
            this.pressbox.Location = new System.Drawing.Point(282, -229);
            this.pressbox.Name = "pressbox";
            this.pressbox.Size = new System.Drawing.Size(220, 481);
            this.pressbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pressbox.TabIndex = 6;
            this.pressbox.TabStop = false;
            // 
            // arababox
            // 
            this.arababox.BackColor = System.Drawing.Color.Transparent;
            this.arababox.Image = ((System.Drawing.Image)(resources.GetObject("arababox.Image")));
            this.arababox.Location = new System.Drawing.Point(240, 357);
            this.arababox.Name = "arababox";
            this.arababox.Size = new System.Drawing.Size(306, 96);
            this.arababox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arababox.TabIndex = 7;
            this.arababox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(672, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Süre";
            // 
            // surelabel
            // 
            this.surelabel.AutoSize = true;
            this.surelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surelabel.Location = new System.Drawing.Point(665, 165);
            this.surelabel.Name = "surelabel";
            this.surelabel.Size = new System.Drawing.Size(101, 37);
            this.surelabel.TabIndex = 9;
            this.surelabel.Text = "00:15";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(654, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(124, 83);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // sorularbox
            // 
            this.sorularbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorularbox.FormattingEnabled = true;
            this.sorularbox.ItemHeight = 20;
            this.sorularbox.Location = new System.Drawing.Point(654, 205);
            this.sorularbox.Name = "sorularbox";
            this.sorularbox.Size = new System.Drawing.Size(124, 164);
            this.sorularbox.TabIndex = 11;
            // 
            // cevapbox
            // 
            this.cevapbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevapbox.Location = new System.Drawing.Point(654, 379);
            this.cevapbox.Name = "cevapbox";
            this.cevapbox.Size = new System.Drawing.Size(124, 26);
            this.cevapbox.TabIndex = 0;
            // 
            // gonderbutonu
            // 
            this.gonderbutonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonderbutonu.Location = new System.Drawing.Point(666, 412);
            this.gonderbutonu.Name = "gonderbutonu";
            this.gonderbutonu.Size = new System.Drawing.Size(100, 26);
            this.gonderbutonu.TabIndex = 15;
            this.gonderbutonu.Text = "Gönder";
            this.gonderbutonu.UseVisualStyleBackColor = true;
            this.gonderbutonu.Click += new System.EventHandler(this.gonderbutonu_Click);
            // 
            // ana_syf
            // 
            this.ana_syf.BackColor = System.Drawing.Color.Gold;
            this.ana_syf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ana_syf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ana_syf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ana_syf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ana_syf.ForeColor = System.Drawing.Color.Black;
            this.ana_syf.Location = new System.Drawing.Point(10, 404);
            this.ana_syf.Name = "ana_syf";
            this.ana_syf.Size = new System.Drawing.Size(124, 36);
            this.ana_syf.TabIndex = 17;
            this.ana_syf.Text = "Ana Sayfa";
            this.ana_syf.UseVisualStyleBackColor = false;
            this.ana_syf.Click += new System.EventHandler(this.ana_syf_Click);
            // 
            // ingame
            // 
            this.AcceptButton = this.gonderbutonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.pressbox);
            this.Controls.Add(this.ana_syf);
            this.Controls.Add(this.gonderbutonu);
            this.Controls.Add(this.cevapbox);
            this.Controls.Add(this.sorularbox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.surelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.arababox);
            this.Controls.Add(this.bolumler);
            this.Controls.Add(this.cansayisi);
            this.Controls.Add(this.kalp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ingame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smash The Math";
            this.Load += new System.EventHandler(this.ingame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kalp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arababox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox kalp;
        private System.Windows.Forms.Label cansayisi;
        private System.Windows.Forms.Label bolumler;
        private System.Windows.Forms.PictureBox pressbox;
        private System.Windows.Forms.PictureBox arababox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label surelabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListBox sorularbox;
        private System.Windows.Forms.TextBox cevapbox;
        private System.Windows.Forms.Button gonderbutonu;
        private System.Windows.Forms.Button ana_syf;
        private System.Windows.Forms.Timer timer1;
    }
}

