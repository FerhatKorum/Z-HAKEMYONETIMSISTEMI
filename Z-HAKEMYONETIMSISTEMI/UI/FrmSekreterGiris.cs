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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnSekreterGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Sekreter Where sAdi=@p1 and sSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtSekreterIsim.Text);
            komut.Parameters.AddWithValue("@p2", txtSekreterSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterPaneli fr = new FrmSekreterPaneli();
                fr.SekreterIsim = txtSekreterIsim.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş!");
            }
            bgl.baglanti().Close();
        }
    }
}
