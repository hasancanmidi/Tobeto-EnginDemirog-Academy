namespace OOP3;

public class EsnafKredisiManager:IKrediManager
{
    public void Hesapla()
    {
        Console.WriteLine("Esnaf 1.99 faiziyle Kredisi hesaplandı");
    }

    public void CıktıAl()
    {
        throw new NotImplementedException();
    }
}