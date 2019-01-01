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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            Hitung p = new Hitung();
            main_panel.Controls.Clear();
            p.TopLevel = false;
            p.AutoScroll = true;
            p.AutoSize = true;
            main_panel.Controls.Add(p);
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Penilaian p = new Penilaian();
            main_panel.Controls.Clear();
            p.TopLevel = false;
            p.AutoScroll = true;
            p.AutoSize = true;
            main_panel.Controls.Add(p);
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kriteria p = new Kriteria();
            main_panel.Controls.Clear();
            p.TopLevel = false;
            p.AutoScroll = true;
            p.AutoSize = true;
            main_panel.Controls.Add(p);
            p.Show();
        }
    }
}
