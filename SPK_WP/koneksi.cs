using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SPK_WP
{
    class koneksi
    {
      
        public SqlConnection connect()
        {
            SqlConnection sqcon = new SqlConnection();
            sqcon.ConnectionString = "Data Source=LAPTOP-IFK92F3Q; initial catalog=rate_pegawai; user id=sa; password=1234567890;";
            return sqcon;
        }
    }
}
