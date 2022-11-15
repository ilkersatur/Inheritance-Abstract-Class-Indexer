using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Ornek
{
    internal class Koni : Silindir
    {
        public double Koni_Hacim { get; set; }
        public Koni(double r, double h) : base(r, h)
        {
            Koni_Hacim = base.Silindir_Hacim / 3;
        }
    }
}
