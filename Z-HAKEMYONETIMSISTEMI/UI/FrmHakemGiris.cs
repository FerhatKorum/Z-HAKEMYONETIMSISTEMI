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

namespace Z_HAKEMYONETIMSISTEMI
{
    public partial class FrmHakemGiriş : Form
    {
        public FrmHakemGiriş()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnHakemGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Hakem Where hIsim=@p1 and hTcNo=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtHakemIsim.Text);
            komut.Parameters.AddWithValue("@p2", txtHakemTC.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
                FrmHakemPaneli fr = new FrmHakemPaneli();
                fr.isim = txtHakemIsim.Text;
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
