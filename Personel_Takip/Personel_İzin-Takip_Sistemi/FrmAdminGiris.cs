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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        BaglantiSinif baglan = new BaglantiSinif();

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(baglan.Adres);
            bgl.Open();
            SqlCommand cmd = new SqlCommand("select * from TBLADMIN where KULLANICIAD=@p1 and SIFRE=@p2",bgl);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmAdmin fra = new FrmAdmin();
                fra.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Giriş Bilgileri Hatalı Lütfen Kontrol Edin ve Tekrar Deneyin");
            }
            bgl.Close();

        }
    }
}
