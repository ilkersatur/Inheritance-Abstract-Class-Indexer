/*       
                   new(instance)      :
class                  ✓              ✓ 
abstract class         x              ✓  (soyut sınıfın instance alamıyoruz ama türetebiliriz
                                          soyut sınıflar aktarma ,kütüphane, amaçlı kullanılır)
sealed class           ✓              x  (mühürlü sınıflarda türetme yapılmaz)
static class           x              x  (statik sınıflar üzerinde veri tutulmaz, birşeyler yaptırmak için
                                          kullanılır, RAM in statik bölgesinde tutulur,kopyası kullanılır, 
                                          bir class static ise tüm içerik statik olur)
 */

using Sınıflar_Abstract_Class;

//Sekil sekil =new Sekil();   abstract olduğu için 
//Cizim Cizim = new Cizim();   static olduğu için 

Cizim.Ciz(new Daire());
Cizim.Ciz(new Silindir());