using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_Ornek
{
    internal class Silindir : Daire
    {
        public double h { get; set; }
        public double HacimHesapla()
        {
            return base.AlanHesapla() * h;
        }
    }
}
