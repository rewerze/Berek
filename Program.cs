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
Console.WriteLine($"4. feladat: A bérek átlaga: {Math.Round(linqAVG / 1000, 1)}E Ft");

Console.WriteLine("5. feladat: Kérem a részleg nevét: ");
string reszlegNev = Console.ReadLine();


Console.WriteLine("6. feladat");


Console.WriteLine("7.feladat: Statisztika");
var linqStat = dolgozok.GroupBy(d => d.Hely);
foreach (var grp in linqStat) Console.WriteLine($"\t{grp.Key,-15}\t-{grp.Count(),4} fő");





