namespace skor_tablo
{
    partial class scoreboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siralama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanici_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam_puan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.skor_anasyf_don = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siralama,
            this.kullanici_adi,
            this.toplam_puan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(65, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 383);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // siralama
            // 
            this.siralama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.siralama.FillWeight = 105.1415F;
            this.siralama.Frozen = true;
            this.siralama.HeaderText = "Sıralama";
            this.siralama.MinimumWidth = 6;
            this.siralama.Name = "siralama";
            this.siralama.ReadOnly = true;
            this.siralama.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.siralama.Width = 234;
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.kullanici_adi.FillWeight = 94.96875F;
            this.kullanici_adi.Frozen = true;
            this.kullanici_adi.HeaderText = "Kullanıcı Adı";
            this.kullanici_adi.MinimumWidth = 6;
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.ReadOnly = true;
            this.kullanici_adi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kullanici_adi.Width = 212;
            // 
            // toplam_puan
            // 
            this.toplam_puan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.toplam_puan.FillWeight = 99.88974F;
            this.toplam_puan.Frozen = true;
            this.toplam_puan.HeaderText = "Toplam Puan";
            this.toplam_puan.MinimumWidth = 6;
            this.toplam_puan.Name = "toplam_puan";
            this.toplam_puan.ReadOnly = true;
            this.toplam_puan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.toplam_puan.Width = 223;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(322, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skor Tablosu";
            // 
            // skor_anasyf_don
            // 
            this.skor_anasyf_don.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skor_anasyf_don.BackColor = System.Drawing.Color.Gold;
            this.skor_anasyf_don.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skor_anasyf_don.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.skor_anasyf_don.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skor_anasyf_don.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skor_anasyf_don.ForeColor = System.Drawing.Color.Black;
            this.skor_anasyf_don.Location = new System.Drawing.Point(640, 14);
            this.skor_anasyf_don.Margin = new System.Windows.Forms.Padding(4);
            this.skor_anasyf_don.Name = "skor_anasyf_don";
            this.skor_anasyf_don.Size = new System.Drawing.Size(150, 33);
            this.skor_anasyf_don.TabIndex = 6;
            this.skor_anasyf_don.Text = "Ana Sayfaya Dön";
            this.skor_anasyf_don.UseVisualStyleBackColor = false;
            this.skor_anasyf_don.Click += new System.EventHandler(this.skor_anasyf_don_Click);
            // 
            // scoreboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.skor_anasyf_don);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "scoreboard";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smash The Math";
            this.Shown += new System.EventHandler(this.scoreboard_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button skor_anasyf_don;
        private System.Windows.Forms.DataGridViewTextBoxColumn siralama;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam_puan;
    }
}

