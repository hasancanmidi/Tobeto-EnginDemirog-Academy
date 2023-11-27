namespace Metods;

public class SepetManager
{
    //naming convention
    //syntax
    //parametre
    public void Ekle(Urun urun)
    {
        Console.WriteLine("Sepete Eklendi : " + urun.Name );
    }

    public void EkleAlternatif(string Name, string About , double Price, int stock)
    {
        Console.WriteLine("Sepete Eklendi : " + Name );

    }
}