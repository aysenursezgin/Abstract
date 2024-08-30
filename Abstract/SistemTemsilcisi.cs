public class SatisTemsilcisi : BaseCalisan
{
    public SatisTemsilcisi(string ad, string soyad)
    {
        Ad = ad;
        Soyad = soyad;
        Departman = "Satış";
    }

    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad} satış temsilcisi olarak çalışıyorum.");
    }
}
