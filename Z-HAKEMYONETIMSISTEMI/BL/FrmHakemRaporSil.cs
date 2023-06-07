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
    public partial class FrmHakemRaporSil : Form
    {
        public FrmHakemRaporSil()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmHakemRaporSil_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from HakemRapor", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtMacNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtHakemIsim.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbTakim1.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbTakim2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMacSonuc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void BtnHakemRaporSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From HakemRapor where HRMacNo = @p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtMacNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Raporunuz Başarıyla Silinmiştir.");
        }
    }
}
