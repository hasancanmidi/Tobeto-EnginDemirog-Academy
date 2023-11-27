//Dont Repeat Yourself - DRY - Clean Code - Best Practice

using System.Threading.Channels;
using Metods;

Urun urun1 = new Urun();
urun1.Name = "Elma";
urun1.Price = 15;
urun1.About = "Elmadır bu";

Urun urun2 = new Urun();
urun2.Name = "Karpuz";
urun2.Price = 95;
urun2.About = "Karpuz bu";

Urun[] urunler = new Urun[] { urun1, urun2 };

//Type Safe
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Name);
    Console.WriteLine(urun.Price);
    Console.WriteLine(urun.About);
    Console.WriteLine("------------------");
}

Console.WriteLine("-----------------------------------------");

//instance - örnek
//encapsulation

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);
sepetManager.EkleAlternatif("Armut","yesil armut",13,123); 


/*
 Çok doğru bir kullanım olmuyor, çünkü farklı farklı sayfalarda ekle yaptığımız durumda
 içerik değiştiğinde örneğin: stock property'si eklediğimizde tüm kodları değiştirmek zorunda kalacağız.
 */
