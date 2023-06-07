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
    public partial class FrmHakemSil : Form
    {
        public FrmHakemSil()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
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

        private void FrmHakemSil_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Hakem", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnHakemDüzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Hakem where hIsim = @p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtHakemIsim.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Hakeminiz Başarılı Bir Şekilde Silinmiştir.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
