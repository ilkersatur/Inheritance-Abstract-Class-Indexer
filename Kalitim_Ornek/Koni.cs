using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_Ornek
{
    internal class Koni : Silindir
    {
        public double KoniHacimHesapla()
        {
            return base.HacimHesapla() / 3;
        }
    }
}
