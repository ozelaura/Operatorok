// See https://aka.ms/new-console-template for more information


//1.Feladat
List<string> kifejezesek = new List<string>();
foreach (var item in File.ReadAllLines("kifejezesek.txt"))
{
    kifejezesek.Add(item);
}

//2.feladat
Console.WriteLine($"2. feladat: Kifejezések száma: {kifejezesek.Count}");

//3.feladat
Console.WriteLine($"3. feladat: Kifejezések maradékos osztással: {kifejezesek.Where(x => x.Contains("mod")).Count()}");

//4.feladat
bool van = false;
foreach (var item in kifejezesek)
{
    string[] itemElemek = item.Split(' ');
    var elsoSzam = int.Parse(itemElemek[0]);
    var masodikSzam = int.Parse(itemElemek[2]);

    if (elsoSzam % 10 == 0 && masodikSzam % 10 == 0)
    {
        van = true;
        break;
    }
}

if (van)
{
    Console.WriteLine("4. feladat: Van ilyen kifejezés!");
}
else
{
    Console.WriteLine("4. feladat: Nincs ilyen kifejezés!");

}

//5.feladat
Console.WriteLine($"5. feladat: Statisztika");
Console.WriteLine($"\tmod -> {kifejezesek.Where(x => x.Contains("mod")).Count()} db");
Console.WriteLine($"\t/ -> {kifejezesek.Where(x => x.Contains("/")).Count()} db");
Console.WriteLine($"\tdiv -> {kifejezesek.Where(x => x.Contains("div")).Count()} db");
Console.WriteLine($"\t- -> {kifejezesek.Where(x => x.Contains("-")).Count()} db");
Console.WriteLine($"\tx -> {kifejezesek.Where(x => x.Contains("x")).Count()} db");
Console.WriteLine($"\t+ -> {kifejezesek.Where(x => x.Contains("+")).Count()} db");