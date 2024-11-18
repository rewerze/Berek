using Berek;
using System.Text;

List<Dolgozok> dolgozok = [];
StreamReader sr = new("..\\..\\..\\src\\berek2020.txt", Encoding.UTF8);

sr.ReadLine();
while (!sr.EndOfStream)
{
    dolgozok.Add(new(sr.ReadLine()));
}
sr.Close();


Console.WriteLine($"3. feladat: Dolgozók száma: {dolgozok.Count()} fő");

var linqAVG = dolgozok.Average(d => d.Ber);
Console.WriteLine($"4. feladat: A bérek átlaga: {Math.Round(linqAVG / 1000, 1)} eFt");

Console.Write("5. feladat: Kérem a részleg nevét: ");
string reszlegNev = Console.ReadLine();


Console.Write("6. feladat: ");
var linqReszleg = dolgozok.FirstOrDefault(d => d.Hely == reszlegNev);
if (linqReszleg != null)
{
    var linqMax = dolgozok.OrderByDescending(d => d.Ber).Where(d => d.Hely == reszlegNev).First();
    var linqMaxi = dolgozok.IndexOf(linqMax);
    Console.WriteLine(
        $"A legtöbbet dolgozó a megadott részlegen" +
        $"\n\tNév: {dolgozok[linqMaxi].Nev}" +
        $"\n\tNem: {dolgozok[linqMaxi].Nem}" +
        $"\n\tBelépés: {dolgozok[linqMaxi].Belepes}" +
        $"\n\tBér: {dolgozok[linqMaxi].Ber:000 000} Forint");
}
else
{
    Console.WriteLine("Nincs ilyen részleg");
}


Console.WriteLine("7.feladat: Statisztika");
var linqStat = dolgozok.GroupBy(d => d.Hely);
foreach (var grp in linqStat) Console.WriteLine($"\t{grp.Key,-15}\t-{grp.Count(),4} fő");





