namespace OOP3;

public class BasvuruManager
{
    public void BasvuruYap(IKrediManager krediManager)
    {
        krediManager.Hesapla();
    }
}