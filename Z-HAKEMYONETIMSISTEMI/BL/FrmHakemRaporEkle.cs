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
    public partial class FrmHakemRaporEkle : Form
    {
        public FrmHakemRaporEkle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnHakemRaporGönder_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO HakemRapor(HRMacNo,HRHakemIsim,HRTakim1,HRTakim2,HRMacSonuc) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtMacNo.Text);
            komut.Parameters.AddWithValue("@p2", txtHakemIsim.Text);
            komut.Parameters.AddWithValue("@p3", cmbTakim1.Text);
            komut.Parameters.AddWithValue("@p4", cmbTakim2.Text);
            komut.Parameters.AddWithValue("@p5", mskMacSonuc.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Rapor Yönetime Gönderilmiştir, Müsabakalarınızda Başarılar Dileriz.");
        }
    }
}
