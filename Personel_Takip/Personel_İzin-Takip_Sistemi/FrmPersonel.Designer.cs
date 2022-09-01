namespace Personel_İzin_Takip_Sistemi
{
    partial class FrmPersonel
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSifre = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnTümü = new System.Windows.Forms.Button();
            this.BtnBekliyor = new System.Windows.Forms.Button();
            this.BtnReddedilmiş = new System.Windows.Forms.Button();
            this.BtnOnaylanmış = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btnİzin = new System.Windows.Forms.Button();
            this.DateİzinBaslangıc = new System.Windows.Forms.DateTimePicker();
            this.DateİzinBitis = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtİzinAçıklama = new System.Windows.Forms.RichTextBox();
            this.TxtİzinBaşlık = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.LblBugunTarih = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LblBugunSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblSifre);
            this.groupBox1.Controls.Add(this.LblMail);
            this.groupBox1.Controls.Add(this.LblSoyad);
            this.groupBox1.Controls.Add(this.LblAd);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(264, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şifre:";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(109, 37);
            this.LblId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(56, 23);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "NULL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mail:";
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.Location = new System.Drawing.Point(109, 173);
            this.LblSifre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(56, 23);
            this.LblSifre.TabIndex = 0;
            this.LblSifre.Text = "NULL";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(109, 142);
            this.LblMail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(56, 23);
            this.LblMail.TabIndex = 0;
            this.LblMail.Text = "NULL";
            // 
            // LblSoyad
            // 
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Location = new System.Drawing.Point(109, 106);
            this.LblSoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(56, 23);
            this.LblSoyad.TabIndex = 0;
            this.LblSoyad.Text = "NULL";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(109, 73);
            this.LblAd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(56, 23);
            this.LblAd.TabIndex = 0;
            this.LblAd.Text = "NULL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 173);
            this.dataGridView1.TabIndex = 1;
            // 
            // BtnTümü
            // 
            this.BtnTümü.Location = new System.Drawing.Point(678, 2);
            this.BtnTümü.Name = "BtnTümü";
            this.BtnTümü.Size = new System.Drawing.Size(123, 33);
            this.BtnTümü.TabIndex = 27;
            this.BtnTümü.Text = "Tümü";
            this.BtnTümü.UseVisualStyleBackColor = true;
            this.BtnTümü.Click += new System.EventHandler(this.BtnTümü_Click);
            // 
            // BtnBekliyor
            // 
            this.BtnBekliyor.Location = new System.Drawing.Point(546, 2);
            this.BtnBekliyor.Name = "BtnBekliyor";
            this.BtnBekliyor.Size = new System.Drawing.Size(126, 33);
            this.BtnBekliyor.TabIndex = 24;
            this.BtnBekliyor.Text = "Bekliyor";
            this.BtnBekliyor.UseVisualStyleBackColor = true;
            this.BtnBekliyor.Click += new System.EventHandler(this.BtnBekliyor_Click);
            // 
            // BtnReddedilmiş
            // 
            this.BtnReddedilmiş.Location = new System.Drawing.Point(414, 2);
            this.BtnReddedilmiş.Name = "BtnReddedilmiş";
            this.BtnReddedilmiş.Size = new System.Drawing.Size(126, 33);
            this.BtnReddedilmiş.TabIndex = 25;
            this.BtnReddedilmiş.Text = "Reddedilmiş";
            this.BtnReddedilmiş.UseVisualStyleBackColor = true;
            this.BtnReddedilmiş.Click += new System.EventHandler(this.BtnReddedilmiş_Click);
            // 
            // BtnOnaylanmış
            // 
            this.BtnOnaylanmış.Location = new System.Drawing.Point(282, 2);
            this.BtnOnaylanmış.Name = "BtnOnaylanmış";
            this.BtnOnaylanmış.Size = new System.Drawing.Size(126, 33);
            this.BtnOnaylanmış.TabIndex = 26;
            this.BtnOnaylanmış.Text = "Onaylanmış";
            this.BtnOnaylanmış.UseVisualStyleBackColor = true;
            this.BtnOnaylanmış.Click += new System.EventHandler(this.BtnOnaylanmış_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btnİzin);
            this.groupBox2.Controls.Add(this.DateİzinBaslangıc);
            this.groupBox2.Controls.Add(this.DateİzinBitis);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtİzinAçıklama);
            this.groupBox2.Controls.Add(this.TxtİzinBaşlık);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 269);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İzin İste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "label5";
            // 
            // Btnİzin
            // 
            this.Btnİzin.Location = new System.Drawing.Point(370, 160);
            this.Btnİzin.Name = "Btnİzin";
            this.Btnİzin.Size = new System.Drawing.Size(197, 72);
            this.Btnİzin.TabIndex = 32;
            this.Btnİzin.Text = "İzin İste";
            this.Btnİzin.UseVisualStyleBackColor = true;
            this.Btnİzin.Click += new System.EventHandler(this.Btnİzin_Click);
            // 
            // DateİzinBaslangıc
            // 
            this.DateİzinBaslangıc.Location = new System.Drawing.Point(457, 58);
            this.DateİzinBaslangıc.Name = "DateİzinBaslangıc";
            this.DateİzinBaslangıc.Size = new System.Drawing.Size(169, 30);
            this.DateİzinBaslangıc.TabIndex = 31;
            // 
            // DateİzinBitis
            // 
            this.DateİzinBitis.Location = new System.Drawing.Point(457, 98);
            this.DateİzinBitis.Name = "DateİzinBitis";
            this.DateİzinBitis.Size = new System.Drawing.Size(169, 30);
            this.DateİzinBitis.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 23);
            this.label13.TabIndex = 29;
            this.label13.Text = "İzin Bitiş:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(314, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 23);
            this.label14.TabIndex = 30;
            this.label14.Text = "İzin Başlangıç:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "Açıklama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Başlık";
            // 
            // TxtİzinAçıklama
            // 
            this.TxtİzinAçıklama.Location = new System.Drawing.Point(12, 124);
            this.TxtİzinAçıklama.Name = "TxtİzinAçıklama";
            this.TxtİzinAçıklama.Size = new System.Drawing.Size(260, 132);
            this.TxtİzinAçıklama.TabIndex = 24;
            this.TxtİzinAçıklama.Text = "";
            // 
            // TxtİzinBaşlık
            // 
            this.TxtİzinBaşlık.Location = new System.Drawing.Point(12, 58);
            this.TxtİzinBaşlık.Name = "TxtİzinBaşlık";
            this.TxtİzinBaşlık.Size = new System.Drawing.Size(260, 30);
            this.TxtİzinBaşlık.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(659, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 23);
            this.label15.TabIndex = 30;
            this.label15.Text = "Tarih";
            // 
            // LblBugunTarih
            // 
            this.LblBugunTarih.AutoSize = true;
            this.LblBugunTarih.Location = new System.Drawing.Point(659, 308);
            this.LblBugunTarih.Name = "LblBugunTarih";
            this.LblBugunTarih.Size = new System.Drawing.Size(127, 23);
            this.LblBugunTarih.TabIndex = 30;
            this.LblBugunTarih.Text = "Bugunun Tarihi";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(659, 349);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 23);
            this.label17.TabIndex = 30;
            this.label17.Text = "Saat";
            // 
            // LblBugunSaat
            // 
            this.LblBugunSaat.AutoSize = true;
            this.LblBugunSaat.Location = new System.Drawing.Point(659, 390);
            this.LblBugunSaat.Name = "LblBugunSaat";
            this.LblBugunSaat.Size = new System.Drawing.Size(124, 23);
            this.LblBugunSaat.TabIndex = 30;
            this.LblBugunSaat.Text = "Bugunun Saati";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 11F);
            this.label6.Location = new System.Drawing.Point(284, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "İzin Taleplerim";
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 489);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnTümü);
            this.Controls.Add(this.BtnBekliyor);
            this.Controls.Add(this.BtnReddedilmiş);
            this.Controls.Add(this.LblBugunSaat);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.LblBugunTarih);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtnOnaylanmış);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSifre;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnTümü;
        private System.Windows.Forms.Button BtnBekliyor;
        private System.Windows.Forms.Button BtnReddedilmiş;
        private System.Windows.Forms.Button BtnOnaylanmış;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox TxtİzinAçıklama;
        private System.Windows.Forms.TextBox TxtİzinBaşlık;
        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DateİzinBaslangıc;
        private System.Windows.Forms.DateTimePicker DateİzinBitis;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Btnİzin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LblBugunTarih;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LblBugunSaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}