namespace Berek
{
    internal class Dolgozok
    {
        public string Nev { get; set; }
        public string Nem { get; set; }
        public string Hely { get; set; }
        public int Belepes { get; set; }
        public int Ber { get; set; }

        public Dolgozok(string sor)
        {
            var db = sor.Split(';');
            Nev = db[0];
            Nem = db[1];
            Hely = db[2];
            Belepes = int.Parse(db[3]);
            Ber = int.Parse(db[4]);
        }
    }
}
