//indexer ------- (Indeksleyiciler)
//özel tanımlı property lerdir
using _01._11._2022;

Depo depo = new Depo();
Console.WriteLine(depo[0]);
//class içerisindeki koleksiyonlara hızlı erişim imkanı sağlanyan yapılara indexer denir.

string mesaj = "merhaba";
Console.WriteLine(mesaj[1]);
/*------------------------------------------
 Inheritance --- Miras,Kalıtım,Türetme
 Ortak yapıları bir sonrakı nesile(sınıfa) aktarılması
 Çoklu kalıtım c# da yoktur042
 Aynı seviyede sadece 1 sınıftan türeyebilir
*/

Base @base = new Base();
Derived derived = new Derived();