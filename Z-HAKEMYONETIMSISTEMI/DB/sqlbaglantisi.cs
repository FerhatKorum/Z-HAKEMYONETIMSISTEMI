using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Z_HAKEMYONETIMSISTEMI
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-LCGJ1EN;Initial Catalog=zHYS;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
