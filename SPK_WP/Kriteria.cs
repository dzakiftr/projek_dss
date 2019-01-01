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
    public partial class Kriteria : Form
    {
        query q = new query();
        public Kriteria()
        {
            InitializeComponent();
        }

        private void Kriteria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rate_pegawai_connected_dataset.kriteria' table. You can move, or remove it, as needed.
            this.kriteriaTableAdapter.Fill(this.rate_pegawai_connected_dataset.kriteria);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bt = double.Parse(txtBobot.Text) / 100;
            string cmd = String.Format("INSERT INTO Kriteria (kriteria, bobot, atribut) VALUES ('{0}', {1}, '{2}')", txtKriteria.Text, bt, cbAtribut.SelectedItem.ToString());

            q.manipulate(cmd);
            this.kriteriaTableAdapter.Fill(this.rate_pegawai_connected_dataset.kriteria);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            string cmd;
            int i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            if(grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >=0)
            {
                 if(dataGridView1.Columns[e.ColumnIndex].Name == "Update")
                 {
                     cmd = String.Format("UPDATE kriteria Set Kriteria = '{0}', bobot = {1}, atribut = '{2}' where id_kriteria = {3}",
                         row.Cells[1].Value.ToString(),
                         row.Cells[2].Value.ToString(),
                         row.Cells[3].Value.ToString(),
                         row.Cells[0].Value.ToString());
                     q.manipulate(cmd);
                     this.kriteriaTableAdapter.Fill(this.rate_pegawai_connected_dataset.kriteria);
                 }
                 else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                 {
                     cmd = String.Format("DELETE From kriteria where id_kriteria = {0}", row.Cells[0].Value.ToString());
                     q.manipulate(cmd);
                     this.kriteriaTableAdapter.Fill(this.rate_pegawai_connected_dataset.kriteria);
                 }
            }
        }
    }
}
