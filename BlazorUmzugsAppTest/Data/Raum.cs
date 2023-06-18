namespace BlazorUmzugsAppTest.Data
{
    public class Raum
    {
        public string Bezeichnung { get; set; }
        public decimal RaumPreis { get
            {
                return Positionen.Sum(x => x.Preis);
            }
        }
        public List<Position> Positionen { get; set; } = new();
    }
}