namespace BlazorUmzugsAppTest.Data
{
    public static class Datenbank
    {
        public static List<Angebot> Angebote { get; set; } = new List<Angebot>
        {
            new Angebot
            {
                AngebotId = 1,
                Belegdatum = DateTime.Today,
                VonAdresse = new Adresse
                {
                    Vorname = "Hans",
                    Nachname = "Topf",
                    Strasse = "Hansastr. 12",
                    Plz = "46049",
                    Ort = "Oberhausen"
                },
                ZuAdresse = new Adresse
                {
                    Vorname = "Hans",
                    Nachname = "Topf",
                    Strasse = "Bertastr. 345",
                    Plz = "46047",
                    Ort = "Oberhausen"
                },
                Raeume = new List<Raum>
                {
                    new Raum
                    {
                        Bezeichnung = "Wohnzimmer",
                        Positionen = new List<Position>
                        {
                           new Position
                           {
                               Bezeichnung = "Tisch",
                               MitTransport = true,
                               Preis = 50
                           },
                           new Position
                           {
                               Bezeichnung = "Couch",
                               MitTransport = true,
                               Preis = 50
                           },
                        }
                    }
                }
            }
        };
    }
}
