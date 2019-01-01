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

namespace SPK_WP
{
    public partial class Hitung : Form
    {
        koneksi k = new koneksi();
        vektor v = new vektor();
        query q = new query();

        public Hitung()
        {
            InitializeComponent();
        }

        private void Hitung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rate_pegawai_connected_dataset.kriteria' table. You can move, or remove it, as needed.
            this.kriteriaTableAdapter.Fill(this.rate_pegawai_connected_dataset.kriteria);
            readBobot();
            DataTable t = hasil_h();
            data_hasil.DataSource = t;
        }

        public List<vektor_s_Info> vektor_s_Info()
        {
            List<vektor_s_Info> vsis = new List<vektor_s_Info>();
            SqlConnection con = k.connect();

            using (con)
            {
                con.Open();
                string com = "select distinct nik, nama, vektor_s from vVektor_s";
                SqlCommand sqlcomm = new SqlCommand(com, con);
                using (sqlcomm)
                {
                    SqlDataReader dr = sqlcomm.ExecuteReader();
                    while (dr.Read())
                    {
                        vektor_s_Info vi = new vektor_s_Info();
                        vi.nik = dr.GetInt32(0);
                        vi.nama = dr.GetString(1);
                        vi.vs = dr.GetDouble(2);
                        vsis.Add(vi);
                    }
                }
                con.Close();
            }
            return vsis;
        }

        public void readBobot()
        {
            List<double> bobot = v.perbaikan_bobot();
            for (int row = 0; row < dataGridView1.Rows.Count ; row++)
            {
                dataGridView1[3, row].Value = bobot[row];
            }
        }

        public List<string> kriterias()
        {
            List<string> kriterias = new List<string>();
            SqlConnection con = k.connect();

            using (con)
            {
                con.Open();
                string com = "select distinct kriteria from vVektor_s";
                SqlCommand sqlcomm = new SqlCommand(com, con);
                using (sqlcomm)
                {
                    SqlDataReader dr = sqlcomm.ExecuteReader();
                    while (dr.Read())
                    {
                        string kri = dr.GetString(0);
                        kriterias.Add(kri);
                    }
                }
                con.Close();
            }
            return kriterias;
        }

        public int nilai_k(string kriteria, int nik)
        {
            int nilai;
            SqlConnection con = k.connect();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = String.Format("select nilai from vVektor_s where kriteria = '{0}' and nik = {1}", kriteria, nik);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            nilai = dr.GetInt32(0);
            con.Close();
            return nilai;
        }

        public DataTable hasil_h()
        {
            vektor vkt = new vektor();
            DataTable tb = new DataTable();
            DataRow row;
            List<vektor_s_Info> v = vektor_s_Info();
            List<double> vektor_v = vkt.vektor_v();
            List<string> kr = kriterias();
            tb.Columns.Add("NIK");
            tb.Columns.Add("Nama");
            for (int i = 0; i < kr.Count; i++)
            {
                tb.Columns.Add(kr[i]);
            }
            tb.Columns.Add("Vektor S");
            tb.Columns.Add("Vektor V");


            foreach(var vi in v)
            {
                row = tb.NewRow();
                row["NIK"] = vi.nik;
                row["Nama"] = vi.nama;
                for(int i = 0; i< kr.Count; i++)
                {
                    row[kr[i]] = nilai_k(kr[i], vi.nik);
                }
                row["Vektor S"] = Math.Round(vi.vs, 3);
                row["Vektor V"] = vkt.v_v(vi.nik);
                tb.Rows.Add(row);
            }

            return tb;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
