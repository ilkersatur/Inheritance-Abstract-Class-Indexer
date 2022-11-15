//base türeyen sınıflarda bir sınıfın base classına veri aktarmak için kullanılır
using Base_Ornek;

Daire daire = new Daire(5);
Console.WriteLine(daire.Alan);
Silindir silindir = new Silindir(5, 5);
Console.WriteLine(silindir.Silindir_Hacim);
Koni koni = new Koni(5, 5);
Console.WriteLine(koni.Koni_Hacim);
