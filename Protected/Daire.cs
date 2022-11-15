using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected
{
    internal class Daire
    {
        protected void Islem() { }
    }
    internal class Silindir : Daire
    {
        // sınıfın içerisine doğrudan kod yazılmaz prop ya da metod yazabilirsin
        public Silindir()
        {
            Islem(); //protected olan metodlar sadece kalıtım olan class a açık
        }
    }
}
