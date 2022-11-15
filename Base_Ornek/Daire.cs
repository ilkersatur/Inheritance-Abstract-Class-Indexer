using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Ornek
{
    internal class Daire
    {
        public double Alan { get; set; }
        public Daire(double r)
        {
            Alan = r * r * Math.PI;

        }
    }
}
