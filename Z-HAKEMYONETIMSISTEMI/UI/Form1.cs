using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_HAKEMYONETIMSISTEMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHakemGiris_Click(object sender, EventArgs e)
        {
            FrmHakemGiriş fr = new FrmHakemGiriş();
            fr.Show();
            this.Hide();
        }

        private void btnSekreterGiris_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris fr = new FrmSekreterGiris();
            fr.Show();
            this.Hide();
        }

        private void btnGözlemciGiris_Click(object sender, EventArgs e)
        {
            FrmGözlemciGiris fr = new FrmGözlemciGiris();
            fr.Show();
            this.Hide();
        }
    }
}
