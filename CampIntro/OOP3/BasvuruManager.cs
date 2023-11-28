namespace OOP3;

public class BasvuruManager
{
    //Method injection
    public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
    {
        //Başvuran bilgilerini değerlendirme
        
        krediManager.Hesapla();
        foreach (var loggerService in loggerServices)
        {
            loggerService.Log();
        }
    }

    public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
    {
        foreach (var kredi in krediler)
        {
            kredi.Hesapla();
        }
    }
}