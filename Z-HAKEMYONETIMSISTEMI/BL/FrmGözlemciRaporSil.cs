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
    public partial class FrmGözlemciRaporSil : Form
    {
        public FrmGözlemciRaporSil()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtMacNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtHakemIsim.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbTakim1.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbTakim2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMacSonuc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtGözlemciYorum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtGözleciIsim.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void FrmGözlemciRaporSil_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from GözlemciRapor", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnGözlemciRaporDüzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From GözlemciRapor where GRMacNo = @p1",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtMacNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Raporunuz Başarılı Bir Şekilde Silinmiştir.");

        }
    }
}
