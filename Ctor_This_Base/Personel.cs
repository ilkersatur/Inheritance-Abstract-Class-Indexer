using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctor_This_Base
{
    internal class Personel
    {
        public int PerID { get; set; }
        public string AdSoyad { get; set; }
        public double Maas { get; set; }
        public string Adres { get; set; }
        //public Personel(int id, string ad, double maas, string adres)
        //{
        //    PerID = id;
        //    AdSoyad = ad;
        //    Maas = maas;
        //    Adres = adres;
        //}
        //public Personel(int id, string ad, double maas)
        //{
        //    PerID = id;
        //    AdSoyad = ad;
        //    Maas = maas;

        //}
        //public Personel(int id, string ad)
        //{
        //    PerID = id;
        //    AdSoyad = ad;
        //}
        //public Personel(int id)
        //{
        //    PerID = id;
        //}
        public Personel(int id, string ad, double maas, string adres)
        {
            PerID = id;
            AdSoyad = ad;
            Maas = maas;
            Adres = adres;
        }
        public Personel(int id) : this(id, "", 0, "")
        {
        }
        public Personel(int id, string ad) : this(id, ad, 0, "")
        {
        }
        public Personel(int id, string ad, int maas) : this(id, ad, maas, "")
        {
        }
    }
}
