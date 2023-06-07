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
    public partial class FrmGözlemciSil : Form
    {
        public FrmGözlemciSil()
        {
            InitializeComponent();
        }

        private void FrmGözlemciSil_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Gözlemci", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

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

        private void btnGözlemciSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Gözlemci where gIsim = @p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtGözlemciIsim.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gözlemcimiz Başarılı Bir Şekilde Silinmiştir.");
        }
    }
}
