using OOP3;

IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();

IKrediManager tasitKrediManager = new TasitKrediManager();

IKrediManager konutKrediManager = new KonutKrediManager();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(konutKrediManager);