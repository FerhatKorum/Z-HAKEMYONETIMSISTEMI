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
    public partial class FrmDuyuruOlustur_ : Form
    {
        public FrmDuyuruOlustur_()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Duyurular(dMetni) values(@p1)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", rchDuyuruOlustur.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Ekleme Islemi Basariyla Gercekestirilmistir.");
        }
    }
}
