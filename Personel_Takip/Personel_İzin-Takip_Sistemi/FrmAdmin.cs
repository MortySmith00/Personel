using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_İzin_Takip_Sistemi
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        BaglantiSinif baglan = new BaglantiSinif();


        void izingetir()
        {
            // izinler listesi
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            bgl.Open();
            SqlDataAdapter da = new SqlDataAdapter("select  ID,BASLIK,KONU,BASLANGIC,BITIS,PERSONELAD,PERSONELSOYAD,DURUM from TBLIZINLER", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.Close();
        }

        void personelgetir()
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            // personel listesi
            bgl.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select  ID,AD,SOYAD,KULLANICIAD,SIFRE,MAIL from TBLPERSONEL where DURUM='True'", bgl);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            bgl.Close();
        }


        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            izingetir();


            personelgetir();


        }

        private void BtnOnaylanmış_Click(object sender, EventArgs e)
        {
            // onaylanmış izinler listesi
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            bgl.Open();
            SqlDataAdapter da = new SqlDataAdapter("select  ID,BASLIK,KONU,BASLANGIC,BITIS,PERSONELAD,PERSONELSOYAD,DURUM from TBLIZINLER where DURUM='Onaylandı'", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.Close();
        }

        private void BtnReddedilmiş_Click(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            // reddedilmiş izinler listesi
            bgl.Open();
            SqlDataAdapter da = new SqlDataAdapter("select  ID,BASLIK,KONU,BASLANGIC,BITIS,PERSONELAD,PERSONELSOYAD,DURUM from TBLIZINLER where DURUM='Reddedildi'", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.Close();
        }

        private void BtnBekliyor_Click(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            // bekleyen izinler listesi
            bgl.Open();
            SqlDataAdapter da = new SqlDataAdapter("select  ID,BASLIK,KONU,BASLANGIC,BITIS,PERSONELAD,PERSONELSOYAD,DURUM from TBLIZINLER where DURUM='Bekliyor'", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.Close();
        }

        private void BtnTümü_Click(object sender, EventArgs e)
        {
            izingetir();
        }

        public string izinıd;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            izinıd = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtİzinBaşlık.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtİzinAçıklama.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtİzinBaşlangıç.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtizinBitiş.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtİzinPersonelAd.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtİzinPersonelSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            TxtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        public string personelıd;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            personelıd = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtPersonelAd.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtPersonelSoyad.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtPersonelKullanıcıAd.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtPersonelMail.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtPersonelŞifre.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void BtnOnayla_Click(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            bgl.Open();
            SqlCommand cmd = new SqlCommand("update TBLIZINLER set DURUM=@p1 where ID=@p2", bgl);
            cmd.Parameters.AddWithValue("@p1", "Onaylandı");
            cmd.Parameters.AddWithValue("@p2", izinıd);
            cmd.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("İzin Verildi");

            izingetir();
        }

        private void BtnReddet_Click(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            bgl.Open();
            SqlCommand cmd = new SqlCommand("update TBLIZINLER set DURUM=@p1 where ID=@p2", bgl);
            cmd.Parameters.AddWithValue("@p1", "Reddedildi");
            cmd.Parameters.AddWithValue("@p2", izinıd);
            cmd.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Reddedildi");

            izingetir();

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            bgl.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLPERSONEL (AD,SOYAD,KULLANICIAD,SIFRE,MAIL,DURUM) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl);
            cmd.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPersonelSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", TxtPersonelKullanıcıAd.Text);
            cmd.Parameters.AddWithValue("@p4", TxtPersonelŞifre.Text);
            cmd.Parameters.AddWithValue("@p5", TxtPersonelMail.Text);
            cmd.Parameters.AddWithValue("@p6", "True");
            cmd.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Personel Sisteme Kaydedildi");
            personelgetir();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            bgl.Open();
            SqlCommand cmd = new SqlCommand("update TBLPERSONEL set DURUM='False' where ID=@p1", bgl);
            cmd.Parameters.AddWithValue("@p1", personelıd);
            cmd.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Personel Pasif Duruma Getirildi");
            personelgetir();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            bgl.Open();
            SqlCommand cmd = new SqlCommand("update TBLPERSONEL set AD=@p1,SOYAD=@p2,KULLANICIAD=@p3,SIFRE=@p4,MAIL=@p5 where ID=@p6", bgl);
            cmd.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPersonelSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", TxtPersonelKullanıcıAd.Text);
            cmd.Parameters.AddWithValue("@p4", TxtPersonelŞifre.Text);
            cmd.Parameters.AddWithValue("@p5", TxtPersonelMail.Text);
            cmd.Parameters.AddWithValue("@p6", personelıd);
            cmd.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Personel Bilgileri Güncellendi");
            personelgetir();

        }
    }
}
