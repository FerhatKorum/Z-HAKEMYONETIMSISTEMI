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
    public partial class FrmGözlemciDüzenle : Form
    {
        public FrmGözlemciDüzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmGözlemciDüzenle_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Gözlemci", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtGözlemciIsim.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtGözlemciSoyisim.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbGözlemciKlasman.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskGözlemciTcNo.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtGözlemciLisansNo.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskGözlemciCepTel.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnGözlemciDüzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Gözlemci set gIsim=@p1, gSoyisim=@p2,gKlasman=@p3,gTcNo=@p4,gLisansNo=@p5,gCepTel=@p6 where gIsim=@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtGözlemciIsim.Text);
            komut.Parameters.AddWithValue("@p2", txtGözlemciSoyisim.Text);
            komut.Parameters.AddWithValue("@p3", cmbGözlemciKlasman.Text);
            komut.Parameters.AddWithValue("@p4", mskGözlemciTcNo.Text);
            komut.Parameters.AddWithValue("@p5", txtGözlemciLisansNo.Text);
            komut.Parameters.AddWithValue("@p6", mskGözlemciCepTel.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Gözlemci Güncelleme İşlemi Başarıyla Yapılmıştır.");
        }

        void GözlemciSil()
        {
            txtGözlemciIsim.Text = "";
            txtGözlemciSoyisim.Text = "";
            cmbGözlemciKlasman.Text = "";
            mskGözlemciTcNo.Text = "";
            txtGözlemciLisansNo.Text = "";
            mskGözlemciCepTel.Text = "";
            txtGözlemciIsim.Focus();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            GözlemciSil();
        }
    }
}
