using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_İzin_Takip_Sistemi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
           
            FrmAdminGiris fra = new FrmAdminGiris();
            fra.Show();
          
           

        }

        private void BtnPersonel_Click(object sender, EventArgs e)
        {

            FrmPersonelGiris frp = new FrmPersonelGiris();
            frp.Show();
         

        }
    }
}
