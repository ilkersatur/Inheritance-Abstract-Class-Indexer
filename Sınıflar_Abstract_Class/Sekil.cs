using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar_Abstract_Class
{
    internal abstract class Sekil
    {
        public string Renk { get; set; }
    }
    internal class Daire : Sekil
    {

    }
    internal sealed class Silindir : Daire
    {
    }
    //internal class Koni : Silindir
    //{
    //silinidir sealed olduğundan olmaz
    //}
    internal static class Cizim
    {
        public static void Ciz(Sekil sekil)
        {
            // herşeyi kapsadı
        }
    }
}
