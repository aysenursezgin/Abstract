using System;

public abstract class BaseCalisan
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Departman { get; set; }

    // Soyut metod, her alt sınıfta implement edilmelidir
    public abstract void Gorev();
}
