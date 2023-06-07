using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Z_HAKEMYONETIMSISTEMI
{
    public partial class FrmGözlemciGiris : Form
    {
        public FrmGözlemciGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();    
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Gözlemci Where gIsim=@p1 and gTcNo=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtGözlemciIsim.Text);
            komut.Parameters.AddWithValue("@p2", txtGözlemciTc.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmGözlemciPaneli fr = new FrmGözlemciPaneli();
                fr.GözlemciIsim = txtGözlemciIsim.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş!");
            }
            bgl.baglanti().Close();
        }
    }
}
