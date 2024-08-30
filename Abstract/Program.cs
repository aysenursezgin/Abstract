using System;

class Program
{
    static void Main()
    {
        // Yazılım geliştirici nesnesi oluşturuluyor
        YazilimGelistirici yazilimGelistirici = new YazilimGelistirici("Alperen", "Sezgin");

        // Proje yöneticisi nesnesi oluşturuluyor
        ProjeYoneticisi projeYoneticisi = new ProjeYoneticisi("Ayşenur", "Sezgin");

        // Satış temsilcisi nesnesi oluşturuluyor
        SatisTemsilcisi satisTemsilcisi = new SatisTemsilcisi("Mehmet", "Algül");

        // Her çalışanın görevi yazdırılıyor
        yazilimGelistirici.Gorev();
        projeYoneticisi.Gorev();
        satisTemsilcisi.Gorev();
    }
}
