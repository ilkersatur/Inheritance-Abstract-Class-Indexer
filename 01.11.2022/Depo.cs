using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._11._2022
{
    internal class Depo
    {
        string[] depo = { "defter", "silgi", "pergel" };
        public string this[int indis] //ismi yok!!! //bir sınıfta imzası farklı olmak koşulu ile birden fazla indexer olabilir
        {
            get { return depo[indis]; }
            set { depo[indis] = value; }

        }
    }
}
