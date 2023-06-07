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
    public partial class FrmHakemDüzenle : Form
    {
        public FrmHakemDüzenle()
        {
            InitializeComponent();
        }

        void HakemTemizle()
        {
            txtHakemIsim.Text = "";
            txtHakemSoyisim.Text = "";
            cmbHakemKlasman.Text = "";
            mskHakemTcNo.Text = "";
            txtHakemLisansNo.Text = "";
            mskHakemCepTel.Text = "";
            txtHakemIsim.Focus();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            HakemTemizle();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmHakemDüzenle_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Hakem", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtHakemIsim.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtHakemSoyisim.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbHakemKlasman.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskHakemTcNo.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtHakemLisansNo.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskHakemCepTel.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnHakemDüzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Hakem set hIsim=@p1, hSoyisim=@p2,hKlasman=@p3,hTcNo=@p4,hLisansNo=@p5,hCepTel=@p6 where hIsim=@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtHakemIsim.Text);
            komut.Parameters.AddWithValue("@p2", txtHakemSoyisim.Text);
            komut.Parameters.AddWithValue("@p3", cmbHakemKlasman.Text);
            komut.Parameters.AddWithValue("@p4", mskHakemTcNo.Text);
            komut.Parameters.AddWithValue("@p5", txtHakemLisansNo.Text);
            komut.Parameters.AddWithValue("@p6", mskHakemCepTel.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Hakem Güncelleme İşlemi Başarıyla Yapılmıştır.");
        }
    }
}
