using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace SPK_WP
{
    class vektor
    {
        koneksi k = new koneksi();
        
        public vektor()
        {
       
        }

        public int sum_bobot()
        {
            int sum;
            SqlConnection con = k.connect();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select cast(sum(bobot) as int) from kriteria";
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            sum = dr.GetInt32(0);
            con.Close();
            return sum;
        }

        public List<double> perbaikan_bobot()
        {
            int sum = sum_bobot();
            List<double> bobot = new List<double>();

            SqlConnection con = k.connect();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select bobot, atribut from kriteria";
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                double x;
                string atr = dr.GetString(1);
                if (atr != "max")
                    x = (dr.GetDouble(0) / sum) * -1;
                else
                    x = dr.GetDouble(0) / sum;
                bobot.Add(x);
            }
            con.Close();
            return bobot;
        }

        public double vektor_s(List<double> nilai)
        {
            List<double> v_s = new List<double>();
            List<double> bobot = perbaikan_bobot();
            double r = 1.0;

            //Pemangkatan nilai
            for(int i = 0; i < nilai.Count; i++)
            {
                double hasil;
                hasil = Math.Round(Math.Pow(nilai[i], bobot[i]), 3);
                v_s.Add(hasil);
            }

            //Perkalian masing2 array
            for(int i = 0; i < v_s.Count; i++)
            {
                r = r * v_s[i];
            }
            return r;
        }

       
    }
}
