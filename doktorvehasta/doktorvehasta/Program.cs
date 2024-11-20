using System;
using System.Collections.Generic;

// Hasta sınıfı: Bir hastayı Ad, Yaş ve TC Kimlik Numarası ile temsil eder
public class Hasta
{
    public string Ad { get; private set; }
    public int Yas { get; private set; }
    public string TcKimlikNo { get; private set; }

    // Hasta oluşturucu
    public Hasta(string ad, int yas, string tcKimlikNo)
    {
        Ad = ad;
        Yas = yas;
        TcKimlikNo = tcKimlikNo;
    }

    // Hasta bilgilerini görüntüleme
    public override string ToString()
    {
        return $"{Ad}, Yaş: {Yas}, TC Kimlik No: {TcKimlikNo}";
    }
}

// Doktor sınıfı: Bir doktoru Ad, Uzmanlık ve hasta listesi ile temsil eder
public class Doktor
{
    public string Ad { get; private set; }
    public string Uzmanlik { get; private set; }
    public List<Hasta> Hastalar { get; private set; }

    // Doktor oluşturucu
    public Doktor(string ad, string uzmanlik)
    {
        Ad = ad;
        Uzmanlik = uzmanlik;
        Hastalar = new List<Hasta>();
    }

    // Bir hastayı doktora ekleme metodu
    public void HastaEkle(Hasta hasta)
    {
        if (hasta != null)
        {
            Hastalar.Add(hasta);
        }
        else
        {
            Console.WriteLine("Geçersiz hasta.");
        }
    }

    // Doktorun detaylarını ve hastalarını görüntüleme
    public void DoktorDetaylariniGoster()
    {
        Console.WriteLine($"Doktor: {Ad}, Uzmanlık: {Uzmanlik}");
        Console.WriteLine("Hastalar:");
        foreach (var hasta in Hastalar)
        {
            Console.WriteLine($"  - {hasta}");
        }
    }
}

// Program sınıfı: Uygulamanın ana giriş noktası
public class Program
{
    public static void Main(string[] args)
    {
        // Bazı hastalar oluşturuluyor
        var hasta1 = new Hasta("Alice Johnson", 30, "12345678901");
        var hasta2 = new Hasta("Bob Smith", 45, "98765432101");
        var hasta3 = new Hasta("Charlie Brown", 60, "11223344556");

        // Bir doktor oluşturuluyor ve hastalarına atanıyor
        var doktor1 = new Doktor("Dr. Sarah Lee", "Kardiyolog");
        doktor1.HastaEkle(hasta1);
        doktor1.HastaEkle(hasta3);

        var doktor2 = new Doktor("Dr. John Doe", "Endokrinolog");
        doktor2.HastaEkle(hasta2);

        // Doktor detayları ve hastalarını görüntüleme
        doktor1.DoktorDetaylariniGoster();
        Console.WriteLine();
        doktor2.DoktorDetaylariniGoster();
    }
}
