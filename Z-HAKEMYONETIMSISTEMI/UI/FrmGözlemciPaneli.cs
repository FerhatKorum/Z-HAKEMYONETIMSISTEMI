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

namespace Z_HAKEMYONETIMSISTEMI
{
    public partial class FrmGözlemciPaneli : Form
    {
        public FrmGözlemciPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnGözlemciRaporEkle_Click(object sender, EventArgs e)
        {
            FrmGözlemciRaporEkle fr = new FrmGözlemciRaporEkle();
            fr.Show();
        }

        private void btnGözlemciRaporDüzenle_Click(object sender, EventArgs e)
        {
            FrmGözlemciRaporDüzenle fr = new FrmGözlemciRaporDüzenle();
            fr.Show();
        }

        public string GözlemciIsim;
        private void FrmGözlemciPaneli_Load(object sender, EventArgs e)
        {
            lblGözlemciIsim.Text = GözlemciIsim;

            SqlCommand komut = new SqlCommand("Select gIsim,gSoyisim From Gözlemci where gIsim = @p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblGözlemciIsim.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                label1.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from GözlemciRapor", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("select * from Duyurular", bgl.baglanti());
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;
        }

        private void btnGözlemciRaporSil_Click(object sender, EventArgs e)
        {
            FrmGözlemciRaporSil fr = new FrmGözlemciRaporSil();
            fr.Show();
        }
    }
}
