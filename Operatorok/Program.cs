// See https://aka.ms/new-console-template for more information


//1.Feladat
List<string> kifejezesek = new List<string>();
foreach (var item in File.ReadAllLines("kifejezesek.txt"))
{
    kifejezesek.Add(item);
}

//2.feladat
Console.WriteLine($"2.feladat: Kifejezések száma: {kifejezesek.Count}");