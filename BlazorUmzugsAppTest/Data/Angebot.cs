namespace BlazorUmzugsAppTest.Data
{
    public class Angebot
    {
        public int AngebotId { get; set; }
        public DateTime Belegdatum { get; set; }
        public Adresse VonAdresse { get; set; } = new();
        public Adresse ZuAdresse { get; set; } = new();
        public List<Raum> Raeume { get; set; } = new(); 
        public decimal GesamtPreis
        {
            get
            {
                return Raeume.Sum(x => x.RaumPreis);
            }
        }
    }
}