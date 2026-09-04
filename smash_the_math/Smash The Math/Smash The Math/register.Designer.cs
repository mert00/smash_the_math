namespace Görsel_Programlama_Oyunu
{
    partial class frmRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txteposta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtsifreonayla = new System.Windows.Forms.TextBox();
            this.chkSifreGoster = new System.Windows.Forms.CheckBox();
            this.kayit_ol = new System.Windows.Forms.Button();
            this.temizle_butonu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(297, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtkullaniciadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkullaniciadi.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadi.Location = new System.Drawing.Point(301, 73);
            this.txtkullaniciadi.Multiline = true;
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(210, 25);
            this.txtkullaniciadi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(297, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "E - Posta";
            // 
            // txteposta
            // 
            this.txteposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txteposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txteposta.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txteposta.Location = new System.Drawing.Point(301, 129);
            this.txteposta.Multiline = true;
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(210, 25);
            this.txteposta.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(297, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(297, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şifreyi Onayla";
            // 
            // txtsifre
            // 
            this.txtsifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtsifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsifre.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(301, 187);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(210, 25);
            this.txtsifre.TabIndex = 7;
            // 
            // txtsifreonayla
            // 
            this.txtsifreonayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtsifreonayla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsifreonayla.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifreonayla.Location = new System.Drawing.Point(301, 244);
            this.txtsifreonayla.Multiline = true;
            this.txtsifreonayla.Name = "txtsifreonayla";
            this.txtsifreonayla.Size = new System.Drawing.Size(210, 25);
            this.txtsifreonayla.TabIndex = 8;
            // 
            // chkSifreGoster
            // 
            this.chkSifreGoster.AutoSize = true;
            this.chkSifreGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSifreGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSifreGoster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.chkSifreGoster.Location = new System.Drawing.Point(376, 278);
            this.chkSifreGoster.Name = "chkSifreGoster";
            this.chkSifreGoster.Size = new System.Drawing.Size(118, 23);
            this.chkSifreGoster.TabIndex = 9;
            this.chkSifreGoster.Text = "Şifreyi Göster";
            this.chkSifreGoster.UseVisualStyleBackColor = true;
            this.chkSifreGoster.CheckedChanged += new System.EventHandler(this.chkSifreGoster_CheckedChanged);
            // 
            // kayit_ol
            // 
            this.kayit_ol.BackColor = System.Drawing.Color.Gold;
            this.kayit_ol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kayit_ol.FlatAppearance.BorderSize = 0;
            this.kayit_ol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayit_ol.ForeColor = System.Drawing.Color.White;
            this.kayit_ol.Location = new System.Drawing.Point(302, 307);
            this.kayit_ol.Name = "kayit_ol";
            this.kayit_ol.Size = new System.Drawing.Size(210, 26);
            this.kayit_ol.TabIndex = 10;
            this.kayit_ol.Text = "KAYIT OL";
            this.kayit_ol.UseVisualStyleBackColor = false;
            this.kayit_ol.Click += new System.EventHandler(this.kayit_ol_Click);
            // 
            // temizle_butonu
            // 
            this.temizle_butonu.BackColor = System.Drawing.Color.White;
            this.temizle_butonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temizle_butonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temizle_butonu.ForeColor = System.Drawing.Color.Gold;
            this.temizle_butonu.Location = new System.Drawing.Point(302, 348);
            this.temizle_butonu.Name = "temizle_butonu";
            this.temizle_butonu.Size = new System.Drawing.Size(210, 26);
            this.temizle_butonu.TabIndex = 11;
            this.temizle_butonu.Text = "TEMİZLE";
            this.temizle_butonu.UseVisualStyleBackColor = false;
            this.temizle_butonu.Click += new System.EventHandler(this.temizle_butonu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label6.Location = new System.Drawing.Point(310, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Zaten Bir Hesabınız Var Mı ?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gold;
            this.linkLabel1.Location = new System.Drawing.Point(340, 423);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 19);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Girişe Geri Dönün";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.temizle_butonu);
            this.Controls.Add(this.kayit_ol);
            this.Controls.Add(this.chkSifreGoster);
            this.Controls.Add(this.txtsifreonayla);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txteposta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smash The Math";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegister_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txteposta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtsifreonayla;
        private System.Windows.Forms.CheckBox chkSifreGoster;
        private System.Windows.Forms.Button kayit_ol;
        private System.Windows.Forms.Button temizle_butonu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

