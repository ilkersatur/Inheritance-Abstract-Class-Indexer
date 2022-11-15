using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Ornek
{
    internal class Silindir : Daire
    {
        public double Silindir_Hacim { get; set; }
        public Silindir(double r, double h) : base(r)
        {

            Silindir_Hacim = base.Alan * h;

        }
    }
}
