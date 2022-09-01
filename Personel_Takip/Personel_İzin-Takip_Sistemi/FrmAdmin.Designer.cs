namespace Personel_İzin_Takip_Sistemi
{
    partial class FrmAdmin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.TxtPersonelAd = new System.Windows.Forms.TextBox();
            this.TxtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.TxtPersonelKullanıcıAd = new System.Windows.Forms.TextBox();
            this.TxtPersonelMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPersonelŞifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtizinBitiş = new System.Windows.Forms.TextBox();
            this.TxtİzinBaşlangıç = new System.Windows.Forms.TextBox();
            this.TxtİzinPersonelAd = new System.Windows.Forms.TextBox();
            this.BtnOnayla = new System.Windows.Forms.Button();
            this.BtnReddet = new System.Windows.Forms.Button();
            this.BtnOnaylanmış = new System.Windows.Forms.Button();
            this.BtnReddedilmiş = new System.Windows.Forms.Button();
            this.BtnBekliyor = new System.Windows.Forms.Button();
            this.TxtİzinAçıklama = new System.Windows.Forms.RichTextBox();
            this.TxtİzinBaşlık = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtİzinPersonelSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnTümü = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İzin Talepleri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 194);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 232);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personeller";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(398, 203);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(784, 460);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(126, 33);
            this.BtnGüncelle.TabIndex = 4;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // TxtPersonelAd
            // 
            this.TxtPersonelAd.Location = new System.Drawing.Point(700, 280);
            this.TxtPersonelAd.Name = "TxtPersonelAd";
            this.TxtPersonelAd.Size = new System.Drawing.Size(210, 30);
            this.TxtPersonelAd.TabIndex = 5;
            // 
            // TxtPersonelSoyad
            // 
            this.TxtPersonelSoyad.Location = new System.Drawing.Point(700, 316);
            this.TxtPersonelSoyad.Name = "TxtPersonelSoyad";
            this.TxtPersonelSoyad.Size = new System.Drawing.Size(210, 30);
            this.TxtPersonelSoyad.TabIndex = 5;
            // 
            // TxtPersonelKullanıcıAd
            // 
            this.TxtPersonelKullanıcıAd.Location = new System.Drawing.Point(700, 352);
            this.TxtPersonelKullanıcıAd.Name = "TxtPersonelKullanıcıAd";
            this.TxtPersonelKullanıcıAd.Size = new System.Drawing.Size(210, 30);
            this.TxtPersonelKullanıcıAd.TabIndex = 5;
            // 
            // TxtPersonelMail
            // 
            this.TxtPersonelMail.Location = new System.Drawing.Point(700, 388);
            this.TxtPersonelMail.Name = "TxtPersonelMail";
            this.TxtPersonelMail.Size = new System.Drawing.Size(210, 30);
            this.TxtPersonelMail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Personel Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Personel Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Personel Mail:";
            // 
            // TxtPersonelŞifre
            // 
            this.TxtPersonelŞifre.Location = new System.Drawing.Point(700, 424);
            this.TxtPersonelŞifre.Name = "TxtPersonelŞifre";
            this.TxtPersonelŞifre.Size = new System.Drawing.Size(210, 30);
            this.TxtPersonelŞifre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Personel Şifre:";
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(644, 460);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(126, 33);
            this.BtnSil.TabIndex = 4;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(504, 460);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(126, 33);
            this.BtnEkle.TabIndex = 4;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(692, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "İzin Bitiş:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(692, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "İzin Başlangıç:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(692, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Personel Ad:";
            // 
            // TxtizinBitiş
            // 
            this.TxtizinBitiş.Location = new System.Drawing.Point(835, 166);
            this.TxtizinBitiş.Name = "TxtizinBitiş";
            this.TxtizinBitiş.Size = new System.Drawing.Size(174, 30);
            this.TxtizinBitiş.TabIndex = 11;
            // 
            // TxtİzinBaşlangıç
            // 
            this.TxtİzinBaşlangıç.Location = new System.Drawing.Point(835, 130);
            this.TxtİzinBaşlangıç.Name = "TxtİzinBaşlangıç";
            this.TxtİzinBaşlangıç.Size = new System.Drawing.Size(174, 30);
            this.TxtİzinBaşlangıç.TabIndex = 12;
            // 
            // TxtİzinPersonelAd
            // 
            this.TxtİzinPersonelAd.Location = new System.Drawing.Point(835, 61);
            this.TxtİzinPersonelAd.Name = "TxtİzinPersonelAd";
            this.TxtİzinPersonelAd.Size = new System.Drawing.Size(174, 30);
            this.TxtİzinPersonelAd.TabIndex = 14;
            // 
            // BtnOnayla
            // 
            this.BtnOnayla.Location = new System.Drawing.Point(727, 216);
            this.BtnOnayla.Name = "BtnOnayla";
            this.BtnOnayla.Size = new System.Drawing.Size(126, 33);
            this.BtnOnayla.TabIndex = 7;
            this.BtnOnayla.Text = "Onayla";
            this.BtnOnayla.UseVisualStyleBackColor = true;
            this.BtnOnayla.Click += new System.EventHandler(this.BtnOnayla_Click);
            // 
            // BtnReddet
            // 
            this.BtnReddet.Location = new System.Drawing.Point(859, 216);
            this.BtnReddet.Name = "BtnReddet";
            this.BtnReddet.Size = new System.Drawing.Size(126, 33);
            this.BtnReddet.TabIndex = 8;
            this.BtnReddet.Text = "Reddet";
            this.BtnReddet.UseVisualStyleBackColor = true;
            this.BtnReddet.Click += new System.EventHandler(this.BtnReddet_Click);
            // 
            // BtnOnaylanmış
            // 
            this.BtnOnaylanmış.Location = new System.Drawing.Point(6, 3);
            this.BtnOnaylanmış.Name = "BtnOnaylanmış";
            this.BtnOnaylanmış.Size = new System.Drawing.Size(126, 33);
            this.BtnOnaylanmış.TabIndex = 7;
            this.BtnOnaylanmış.Text = "Onaylanmış";
            this.BtnOnaylanmış.UseVisualStyleBackColor = true;
            this.BtnOnaylanmış.Click += new System.EventHandler(this.BtnOnaylanmış_Click);
            // 
            // BtnReddedilmiş
            // 
            this.BtnReddedilmiş.Location = new System.Drawing.Point(138, 3);
            this.BtnReddedilmiş.Name = "BtnReddedilmiş";
            this.BtnReddedilmiş.Size = new System.Drawing.Size(126, 33);
            this.BtnReddedilmiş.TabIndex = 7;
            this.BtnReddedilmiş.Text = "Reddedilmiş";
            this.BtnReddedilmiş.UseVisualStyleBackColor = true;
            this.BtnReddedilmiş.Click += new System.EventHandler(this.BtnReddedilmiş_Click);
            // 
            // BtnBekliyor
            // 
            this.BtnBekliyor.Location = new System.Drawing.Point(270, 3);
            this.BtnBekliyor.Name = "BtnBekliyor";
            this.BtnBekliyor.Size = new System.Drawing.Size(126, 33);
            this.BtnBekliyor.TabIndex = 7;
            this.BtnBekliyor.Text = "Bekliyor";
            this.BtnBekliyor.UseVisualStyleBackColor = true;
            this.BtnBekliyor.Click += new System.EventHandler(this.BtnBekliyor_Click);
            // 
            // TxtİzinAçıklama
            // 
            this.TxtİzinAçıklama.Location = new System.Drawing.Point(419, 123);
            this.TxtİzinAçıklama.Name = "TxtİzinAçıklama";
            this.TxtİzinAçıklama.Size = new System.Drawing.Size(263, 132);
            this.TxtİzinAçıklama.TabIndex = 20;
            this.TxtİzinAçıklama.Text = "";
            // 
            // TxtİzinBaşlık
            // 
            this.TxtİzinBaşlık.Location = new System.Drawing.Point(422, 68);
            this.TxtİzinBaşlık.Name = "TxtİzinBaşlık";
            this.TxtİzinBaşlık.Size = new System.Drawing.Size(260, 30);
            this.TxtİzinBaşlık.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Başlık";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Açıklama";
            // 
            // TxtİzinPersonelSoyad
            // 
            this.TxtİzinPersonelSoyad.Location = new System.Drawing.Point(835, 94);
            this.TxtİzinPersonelSoyad.Name = "TxtİzinPersonelSoyad";
            this.TxtİzinPersonelSoyad.Size = new System.Drawing.Size(174, 30);
            this.TxtİzinPersonelSoyad.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(692, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Personel Soyad:";
            // 
            // BtnTümü
            // 
            this.BtnTümü.Location = new System.Drawing.Point(402, 3);
            this.BtnTümü.Name = "BtnTümü";
            this.BtnTümü.Size = new System.Drawing.Size(123, 33);
            this.BtnTümü.TabIndex = 23;
            this.BtnTümü.Text = "Tümü";
            this.BtnTümü.UseVisualStyleBackColor = true;
            this.BtnTümü.Click += new System.EventHandler(this.BtnTümü_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(702, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "Durum:";
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(835, 9);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(174, 30);
            this.TxtDurum.TabIndex = 24;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1019, 499);
            this.Controls.Add(this.TxtDurum);
            this.Controls.Add(this.BtnTümü);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtİzinAçıklama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnBekliyor);
            this.Controls.Add(this.BtnReddedilmiş);
            this.Controls.Add(this.BtnOnaylanmış);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtizinBitiş);
            this.Controls.Add(this.TxtİzinBaşlangıç);
            this.Controls.Add(this.TxtİzinBaşlık);
            this.Controls.Add(this.TxtİzinPersonelSoyad);
            this.Controls.Add(this.TxtİzinPersonelAd);
            this.Controls.Add(this.BtnOnayla);
            this.Controls.Add(this.BtnReddet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPersonelŞifre);
            this.Controls.Add(this.TxtPersonelMail);
            this.Controls.Add(this.TxtPersonelKullanıcıAd);
            this.Controls.Add(this.TxtPersonelSoyad);
            this.Controls.Add(this.TxtPersonelAd);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmAdmin";
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.TextBox TxtPersonelAd;
        private System.Windows.Forms.TextBox TxtPersonelSoyad;
        private System.Windows.Forms.TextBox TxtPersonelKullanıcıAd;
        private System.Windows.Forms.TextBox TxtPersonelMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPersonelŞifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtizinBitiş;
        private System.Windows.Forms.TextBox TxtİzinBaşlangıç;
        private System.Windows.Forms.TextBox TxtİzinPersonelAd;
        private System.Windows.Forms.Button BtnOnayla;
        private System.Windows.Forms.Button BtnReddet;
        private System.Windows.Forms.Button BtnOnaylanmış;
        private System.Windows.Forms.Button BtnReddedilmiş;
        private System.Windows.Forms.Button BtnBekliyor;
        private System.Windows.Forms.RichTextBox TxtİzinAçıklama;
        private System.Windows.Forms.TextBox TxtİzinBaşlık;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtİzinPersonelSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnTümü;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtDurum;
    }
}