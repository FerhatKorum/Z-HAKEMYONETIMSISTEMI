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
    public partial class FrmSekreterPaneli : Form
    {
        public FrmSekreterPaneli()
        {
            InitializeComponent();
        }

       
        private void btnHakemEkle_Click(object sender, EventArgs e)
        {
            FrmHakemEkle fr = new FrmHakemEkle();
            fr.Show();
            
        }

        private void btnHakemGüncelle_Click(object sender, EventArgs e)
        {
            FrmHakemDüzenle fr = new FrmHakemDüzenle();
            fr.Show();
            
        }

        private void btnGözlemciEkle_Click(object sender, EventArgs e)
        {
            FrmGözlemciEkle fr = new FrmGözlemciEkle();
            fr.Show();
            
        }

        private void btnGözlemciGüncelle_Click(object sender, EventArgs e)
        {
            FrmGözlemciDüzenle fr = new FrmGözlemciDüzenle();
            fr.Show();
           
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            FrmDuyuruOlustur_ fr = new FrmDuyuruOlustur_();
            fr.Show();
            
        }

        private void btnTakimlar_Click(object sender, EventArgs e)
        {
            FrmTakimlar fr = new FrmTakimlar();
            fr.Show();
            
        }

        private void btnILHakemKurulu_Click(object sender, EventArgs e)
        {
            FrmILHakemKurulu fr = new FrmILHakemKurulu();
            fr.Show();
            
        }

        private void btnDernek_Click(object sender, EventArgs e)
        {
            FrmDernek fr = new FrmDernek();
            fr.Show();
            
        }
            sqlbaglantisi bgl = new sqlbaglantisi();

        public string SekreterIsim;

        private void FrmSekreterPaneli_Load(object sender, EventArgs e)
        {
            lblSekreterIsim.Text = SekreterIsim;

            SqlCommand komut = new SqlCommand("Select sAdi,sSoyadi From Sekreter where sAdi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblSekreterIsim.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                lblIsimSoyisim.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Hakem", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt2 = new DataTable();    
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Gözlemci",bgl.baglanti());
            da2 .Fill(dt2);
            dataGridView2 .DataSource = dt2;
        }

        private void btnHakemSil_Click(object sender, EventArgs e)
        {
            FrmHakemSil fr = new FrmHakemSil();
            fr.Show();
        }

        private void btnGözlemciSil_Click(object sender, EventArgs e)
        {
            FrmGözlemciSil fr = new FrmGözlemciSil();
            fr.Show();
        }
    }
}
