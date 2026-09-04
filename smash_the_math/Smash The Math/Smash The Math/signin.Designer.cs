namespace Görsel_Programlama_Oyunu
{
    partial class signin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.temizle_butonu = new System.Windows.Forms.Button();
            this.giris_yap = new System.Windows.Forms.Button();
            this.chkSifreGoster = new System.Windows.Forms.CheckBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label6.Location = new System.Drawing.Point(336, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = " Hesabınız Yok Mu ?";
            // 
            // temizle_butonu
            // 
            this.temizle_butonu.BackColor = System.Drawing.Color.White;
            this.temizle_butonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temizle_butonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temizle_butonu.ForeColor = System.Drawing.Color.Gold;
            this.temizle_butonu.Location = new System.Drawing.Point(303, 320);
            this.temizle_butonu.Name = "temizle_butonu";
            this.temizle_butonu.Size = new System.Drawing.Size(216, 35);
            this.temizle_butonu.TabIndex = 25;
            this.temizle_butonu.Text = "TEMİZLE";
            this.temizle_butonu.UseVisualStyleBackColor = false;
            this.temizle_butonu.Click += new System.EventHandler(this.temizle_butonu_Click);
            // 
            // giris_yap
            // 
            this.giris_yap.BackColor = System.Drawing.Color.Gold;
            this.giris_yap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giris_yap.FlatAppearance.BorderSize = 0;
            this.giris_yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris_yap.ForeColor = System.Drawing.Color.White;
            this.giris_yap.Location = new System.Drawing.Point(303, 263);
            this.giris_yap.Name = "giris_yap";
            this.giris_yap.Size = new System.Drawing.Size(216, 35);
            this.giris_yap.TabIndex = 24;
            this.giris_yap.Text = "GİRİŞ YAP";
            this.giris_yap.UseVisualStyleBackColor = false;
            this.giris_yap.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkSifreGoster
            // 
            this.chkSifreGoster.AutoSize = true;
            this.chkSifreGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSifreGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSifreGoster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.chkSifreGoster.Location = new System.Drawing.Point(382, 221);
            this.chkSifreGoster.Name = "chkSifreGoster";
            this.chkSifreGoster.Size = new System.Drawing.Size(118, 23);
            this.chkSifreGoster.TabIndex = 23;
            this.chkSifreGoster.Text = "Şifreyi Göster";
            this.chkSifreGoster.UseVisualStyleBackColor = true;
            this.chkSifreGoster.CheckedChanged += new System.EventHandler(this.chkSifreGoster_CheckedChanged_1);
            // 
            // txtsifre
            // 
            this.txtsifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtsifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsifre.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(303, 170);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(216, 28);
            this.txtsifre.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(307, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Şifre";
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtkullaniciadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkullaniciadi.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadi.Location = new System.Drawing.Point(303, 86);
            this.txtkullaniciadi.Multiline = true;
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(216, 28);
            this.txtkullaniciadi.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(307, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giriş Ekranı";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gold;
            this.linkLabel1.Location = new System.Drawing.Point(353, 408);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 19);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hesap Oluştur";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.temizle_butonu);
            this.Controls.Add(this.giris_yap);
            this.Controls.Add(this.chkSifreGoster);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smash The Math";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.signin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button temizle_butonu;
        private System.Windows.Forms.Button giris_yap;
        private System.Windows.Forms.CheckBox chkSifreGoster;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}