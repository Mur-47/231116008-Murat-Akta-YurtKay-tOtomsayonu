using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
        

namespace _231116008_Murat_Aktaş_YurtKayıtOtomsayonu
{
   

    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source = AKTAS; Initial Catalog = YurtKayitOtomasyonu; Integrated Security = True; ");
            baglan.Open();
            return baglan;
        }
    }
}
