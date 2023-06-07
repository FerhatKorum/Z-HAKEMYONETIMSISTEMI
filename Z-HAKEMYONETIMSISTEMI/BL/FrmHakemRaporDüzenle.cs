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
    public partial class FrmHakemRaporDüzenle : Form
    {
        public FrmHakemRaporDüzenle()
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
            txtMacSonuc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void FrmHakemRaporDüzenle_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from HakemRapor", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnHakemRaporGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update HakemRapor set HRHakemIsim = @p2,HRTakim1=@p3,HRTakim2=@p4,HRMacSonuc=@p5 where HRMacNo = @p6", bgl.baglanti());

            komut.Parameters.AddWithValue("@p6", txtMacNo.Text); //Koşul olarak belirttim tekrar güncelleme yapmayacaktır.
            komut.Parameters.AddWithValue("@p2", txtHakemIsim.Text);
            komut.Parameters.AddWithValue("@p3", cmbTakim1.Text);
            komut.Parameters.AddWithValue("@p4", cmbTakim2.Text);
            komut.Parameters.AddWithValue("@p5", txtMacSonuc.Text);
           
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Rapor Güncelleme İşlemi Başarıyla Yapılmıştır.");
        }

    }
}
