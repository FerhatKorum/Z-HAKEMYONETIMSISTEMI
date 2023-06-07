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
    public partial class FrmTakimlar : Form
    {
        public FrmTakimlar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmTakimlar_Load(object sender, EventArgs e)
        {
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Select * from Takimlar",bgl.baglanti());
            da4.Fill(dt4);
            dataGridView1.DataSource = dt4;
        }

        private void btnTakimEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into Takimlar (tIsim) values (@p1)",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1",txtTakimAdi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Takim Ekleme Başariyla Gerçekleştirildi.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtTakimId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtTakimAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();


        }

        private void btnTakimGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Takimlar set tIsim=@p1 where tId=@p2", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtTakimAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtTakimId.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Takim Güncelleme İşlemi Başarıyla Yapılmıştır.");
        }

        private void btnTakimSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Takimlar where tId = @p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtTakimId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Takim Başarılı Bir Şekilde Silinmiştir.");
        }
    }
}
