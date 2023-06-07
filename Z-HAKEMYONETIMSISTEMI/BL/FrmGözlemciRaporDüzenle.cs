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
    public partial class FrmGözlemciRaporDüzenle : Form
    {
        public FrmGözlemciRaporDüzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnGözlemciRaporDüzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update GözlemciRapor set GRHakemIsim = @p1,GRTakim1=@p2,GRTakim2=@p3,GRMacSonuc=@p4,GRHakemYorum=@p5 where GRMacNo = @p6", bgl.baglanti());

            komut.Parameters.AddWithValue("@p6", txtMacNo.Text); //Koşul olarak belirttim tekrar güncelleme yapmayacaktır.

            komut.Parameters.AddWithValue("@p1", txtHakemIsim.Text);
            komut.Parameters.AddWithValue("@p2", cmbTakim1.Text);
            komut.Parameters.AddWithValue("@p3", cmbTakim2.Text);
            komut.Parameters.AddWithValue("@p4", mskMacSonuc.Text);
            komut.Parameters.AddWithValue("@p5", txtGözlemciYorum.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Rapor Güncelleme İşlemi Başarıyla Yapılmıştır.");
        }
        private void FrmGözlemciRaporDüzenle_Load(object sender, EventArgs e)
        {
            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter("select * from GözlemciRapor", bgl.baglanti());
            da5.Fill(dt5);
            dataGridView1.DataSource = dt5;
        }

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
    }
}
