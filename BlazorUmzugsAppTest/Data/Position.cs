namespace BlazorUmzugsAppTest.Data
{
    public class Position
    {
        public string Bezeichnung { get; set; }
        public decimal Preis { get; set; }
        public bool MitAufbau { get; set; }
        public bool MitAbbau { get; set; }
        public bool MitTransport { get; set; }
    }
}