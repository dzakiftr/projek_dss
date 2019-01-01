using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPK_WP
{
    public class vektor_s_Info
    {
        int nik_ ;
        string nama_ ;
        string kriteria_ ;
        int nilai_ ;
        double vektor_s_;
        double vektor_v_;

        public int nik
        {
            get { return nik_; }
            set { nik_ = value; }
        }

        public string nama
        {
            get { return nama_; }
            set { nama_ = value; }
        }

        public string kriteria
        {
            get { return kriteria_; }
            set { kriteria_ = value; }
        }

        public int nilai
        {
            get { return nilai_; }
            set { nilai_ = value; }
        }

        public double vs
        {
            get { return vektor_s_; }
            set { vektor_s_ = value; }
        }

        public double vv
        {
            get { return vektor_v_; }
            set { vektor_v_ = value; }
        }
    }
}
