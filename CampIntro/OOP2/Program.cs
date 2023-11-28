using OOP2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.MusteriNo = "12345";
musteri1.Adı = "Hasan Can";
musteri1.Soyadi = "Midi";
musteri1.Id = 1;


//Kodlama.io

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "54321";
musteri2.SirketAdi = "Kodlama.io";
musteri2.VergiNo = "1234567890";

//SOLID prensipleri

Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();
//Hem gerçek hem tüzel müşterinin referansını tutabiliyor.

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
musteriManager.Ekle(musteri3);
musteriManager.Ekle(musteri4);
