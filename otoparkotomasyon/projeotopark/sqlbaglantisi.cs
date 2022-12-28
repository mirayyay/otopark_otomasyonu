using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace projeotopark
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=localhost;Initial Catalog=veritabanı;Integrated Security=True");
            baglan.Open();
            return baglan;
            
        }

    }

}
