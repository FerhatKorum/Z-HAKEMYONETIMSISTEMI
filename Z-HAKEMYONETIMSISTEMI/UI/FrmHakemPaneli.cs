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
    public partial class FrmHakemPaneli : Form
    {
        public FrmHakemPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnHakemRaporEkle_Click(object sender, EventArgs e)
        {
            FrmHakemRaporEkle fr = new FrmHakemRaporEkle();
            fr.Show();       
        }

        private void btnHakemRaporDüzenle_Click(object sender, EventArgs e)
        {
            FrmHakemRaporDüzenle fr = new FrmHakemRaporDüzenle();
            fr.Show();  
        }

          public string isim;
        private void FrmHakemPaneli_Load(object sender, EventArgs e)
        {
            lblIsim.Text = isim;

            SqlCommand komut = new SqlCommand("Select hIsim,hSoyisim From Hakem where hIsim=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblIsim.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                lblIsimSoyisim.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from HakemRapor" ,bgl.baglanti());
            da.Fill(dt);
            dataGridView3.DataSource = dt;

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Duyurular", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void btnHakemRaporSil_Click(object sender, EventArgs e)
        {
            FrmHakemRaporSil fr = new FrmHakemRaporSil();
            fr.Show();
        }

        private void lblIsimSoyisim_Click(object sender, EventArgs e)
        {

        }
    }
}
