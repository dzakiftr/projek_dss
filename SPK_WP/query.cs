using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SPK_WP
{
    class query
    {
        koneksi k = new koneksi();
        string x;
        public SqlCommand manipulate(string command)
        {
            SqlConnection sq = k.connect();
            sq.Open();

            string cmd = command;
            SqlCommand scm = new SqlCommand(cmd, sq);
            scm.ExecuteNonQuery();
            sq.Close();

            return scm;
        }
    }
}
