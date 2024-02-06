using Workspace;

Console.WriteLine("Hello, World!");


Vatandas vatandas = new()
{
    Ad = "Umut",
    Soyad = "Ozcan",
    DogumYili = 2000,
    TcNo = 1234567890,
};

// SOLID
// Single Responsibility

Class1.SelamVer();
int sayi = Class1.Sayı();
Console.WriteLine(sayi);
Class1.SelamVer("Umut");
Class1.Topla(17, 28);
Class1.Topla();

Console.WriteLine();
// Arrays

string ogr1 = "Ahmet";
string ogr2 = "Mehmet";
string ogr3 = "Ali";
Console.WriteLine(ogr1);
Console.WriteLine(ogr2);
Console.WriteLine(ogr3);
Console.WriteLine();

string[] ogrenciler = [ogr1, ogr2, ogr3]; // new yerine collection ile basit yazılabilir
foreach (var ogr in ogrenciler)
{
    Console.WriteLine(ogr);
}

Console.ReadKey();