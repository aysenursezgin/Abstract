public class ProjeYoneticisi : BaseCalisan
{
    public ProjeYoneticisi(string ad, string soyad)
    {
        Ad = ad;
        Soyad = soyad;
        Departman = "Proje Yönetimi";
    }

    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad} proje yöneticisi olarak çalışıyorum.");
    }
}

