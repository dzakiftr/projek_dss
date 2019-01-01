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
    public partial class Penilaian : Form
    {
        vektor v = new vektor();
        koneksi k = new koneksi();
        
        public Penilaian()
        {
            InitializeComponent();
        }

        private void Penilaian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rate_pegawai_connected_dataset.vPegawai' table. You can move, or remove it, as needed.
            this.vPegawaiTableAdapter.Fill(this.rate_pegawai_connected_dataset.vPegawai);
            // TODO: This line of code loads data into the 'rate_pegawai_connected_dataset.kriteria' table. You can move, or remove it, as needed.
            this.kriteriaTableAdapter.Fill(this.rate_pegawai_connected_dataset.kriteria);

        }

        public void refresh()
        {

        }

        public double vs()
        {
            List<double> nilai = new List<double>();
            double vs;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                double n = (int.Parse(row.Cells[2].Value.ToString()));
                nilai.Add(n);
            }

            vs = v.vektor_s(nilai);
            return vs;
        }

        public SqlCommand sqcom(string command)
        {
            SqlConnection sq = k.connect();
            sq.Open();

            string cmd = command;
            SqlCommand scm = new SqlCommand(cmd, sq);
            scm.ExecuteNonQuery();
            sq.Close();

            return scm;
        }

        public void ivs()
        {
            double v = vs();
            int nik = int.Parse(lblNIK.Text);

            string command = String.Format("INSERT INTO vektor_S (NIK, vektor_s) VALUES ({0}, {1})", nik, v);
            sqcom(command);
        }

        public void insert_nilai()
        {
            string cmd;
            int nik = int.Parse(lblNIK.Text);
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cmd = String.Format("INSERT INTO penilaian (id_kriteria, NIK, nilai) VALUES ({0}, {1}, {2})",
                    dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    nik,
                    dataGridView1.Rows[i].Cells[2].Value.ToString());
                sqcom(cmd);
            }
        }

        public void cleardg()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[2].Value = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ivs();
            insert_nilai();
            cleardg();
            vPegawaiBindingSource.MoveNext();
            MessageBox.Show("Success");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
