//Koni degiskenler=new Koni();
//Console.WriteLine("yükseklik");
//degiskenler.h = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("yarıçap");
//degiskenler.Yariçap = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"Daire Alanı={degiskenler.AlanHesapla()}\nSilindirin Hacmi={degiskenler.HacimHesapla()}\nKoni Hacmi={degiskenler.KoniHacimHesapla()}");

using Kalitim_Ornek;

Daire d = new Daire() { Yaricap = 3 };
Silindir silindir = new Silindir() { Yaricap = 3, h = 5 };
Koni koni = new Koni() { Yaricap = 3, h = 5 };
Console.WriteLine(d.AlanHesapla());
Console.WriteLine(silindir.HacimHesapla());
Console.WriteLine(koni.KoniHacimHesapla());