using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPK_WP
{
    public partial class Penilaian : Form
    {
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> nilai = new List<double>();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                double n = int.Parse(row.Cells[2].Value.ToString());
                nilai.Add(n);
            }

            vektor v = new vektor();
            lbl_bobot.Text = "Bobot masing-masing kriteria: " + string.Join(" , ", v.perbaikan_bobot());
            double vv = v.vektor_s(nilai);

            double x = Math.Round(vv, 3);
            lbl_vektor.Text = "Hasil Vektor S: " + x;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[2].Value = null;
            }
        }
    }
}
