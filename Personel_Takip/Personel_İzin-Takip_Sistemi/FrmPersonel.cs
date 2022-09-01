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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        BaglantiSinif baglan = new BaglantiSinif();

        void listele()
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            bgl.Open();
            SqlDataAdapter da = new SqlDataAdapter("select  ID,BASLIK,KONU,BASLANGIC,BITIS,PERSONELAD,PERSONELSOYAD,DURUM from TBLIZINLER where PERSONELSOYAD='" + LblSoyad.Text + "'", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.Close();
        }
        public string kullanıcıad;
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            bgl.Open();
            SqlCommand cmd = new SqlCommand("select ID,AD,SOYAD,MAIL,SIFRE from TBLPERSONEL WHERE KULLANICIAD=@p1", bgl);
            cmd.Parameters.AddWithValue("@p1", kullanıcıad);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblId.Text = dr[0].ToString();
                LblAd.Text = dr[1].ToString();
                LblSoyad.Text = dr[2].ToString();
                LblMail.Text = dr[3].ToString();
                LblSifre.Text = dr[4].ToString();
            }
            bgl.Close();

            listele();
            timer1.Start();
     
     
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblBugunTarih.Text = DateTime.Now.ToShortDateString();
            LblBugunSaat.Text = DateTime.Now.ToShortTimeString();
        }

        private void BtnOnaylanmış_Click(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            // onaylanmış izinler listesi
            bgl.Open();
            SqlDataAdapter da = new SqlDataAdapter("select  ID,BASLIK,KONU,BASLANGIC,BITIS,PERSONELAD,PERSONELSOYAD,DURUM from TBLIZINLER where DURUM='Onaylandı' and PERSONELSOYAD='" + LblSoyad.Text + "'", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.Close();

        }

        private void BtnReddedilmiş_Click(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            // onaylanmış izinler listesi
            bgl.Open();
            SqlDataAdapter da = new SqlDataAdapter("select  ID,BASLIK,KONU,BASLANGIC,BITIS,PERSONELAD,PERSONELSOYAD,DURUM from TBLIZINLER where DURUM='Reddedildi' and PERSONELSOYAD='" + LblSoyad.Text + "'", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.Close();
        }

        private void BtnBekliyor_Click(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            // onaylanmış izinler listesi
            bgl.Open();
            SqlDataAdapter da = new SqlDataAdapter("select  ID,BASLIK,KONU,BASLANGIC,BITIS,PERSONELAD,PERSONELSOYAD,DURUM from TBLIZINLER where DURUM='Bekliyor' and PERSONELSOYAD='" + LblSoyad.Text + "'", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.Close();
        }

        private void BtnTümü_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btnİzin_Click(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            bgl.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLIZINLER  (BASLIK,KONU,BASLANGIC,BITIS,PERSONELAD,PERSONELSOYAD,DURUM) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",bgl);
            cmd.Parameters.AddWithValue("@p1", TxtİzinBaşlık.Text);
            cmd.Parameters.AddWithValue("@p2", TxtİzinAçıklama.Text);
            cmd.Parameters.AddWithValue("@p3", DateİzinBaslangıc.Text);
            cmd.Parameters.AddWithValue("@p4", DateİzinBitis.Text);
            cmd.Parameters.AddWithValue("@p5", LblAd.Text);
            cmd.Parameters.AddWithValue("@p6", LblSoyad.Text);
            cmd.Parameters.AddWithValue("@p7", "Bekliyor");
            cmd.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("İzin Oluşturuldu");
            listele();


        }
    }
}
