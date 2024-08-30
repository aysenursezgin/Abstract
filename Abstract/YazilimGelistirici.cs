public class YazilimGelistirici : BaseCalisan
{
    public YazilimGelistirici(string ad, string soyad)
    {
        Ad = ad;
        Soyad = soyad;
        Departman = "Yazılım";
    }

    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad} yazılım geliştirici olarak çalışıyorum.");
    }
}
