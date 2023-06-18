# BlazorUmzugsAppTest
## Blazor Server App zum Erstellen von Angeboten für Umzugsunternehmen
Die Idee für diese App enstand dadurch, dass ein Bekannrter noch mit Stift und Klemmbrett zum Kunden fährt, um Informationen zur Erstellung eines Angebots aufzunehmen.
<br>
Das Grundgerüst der App steht, ist an sich auch bereits nutzbar. Es ist jedoch noch keine Datenbank angebunden (angegebene Daten sind bisher hart kodiert) und die Oberflächen sind noch nicht gestaltet. Das Hauptaugenmerk lag bisher auf der Funktionalität.
<br><br>
Die App startet mit einer Übersicht an Aufträgen sofern bereits vorhanden. Zu jedem Auftrag lassen sich Adressen (Startadresse, Zieladresse) hinzufügen. Im nächsten Schritt werden Räume benannt und erstellt. In den jeweiligen Räumen befinden sich Positionen, für die man per Checkbox angibt, ob sie abgebaut, aufgebaut und oder nur transportiert werden. Zu den jeweiligen Positionen hat man die Möglich keit, einen Preis einzugeben. Die Summe der Positionspreise ergeben einen Raumpreis, die Summe dieser dann entsprechend den Gesamtpreis des Angebots.
<br><br>
Weitere Schritte:<br>
Als nächstes werde ich eine Datenbank mit Entityframework anbinden (MSSQL).
<br>
Eine App zum Erstellen einer Pdf-Datei per c#-Code habe ich bereits erstellt und wird zu einem späteren Zeitpunkt in die Umzugsapp eingebettet, so dass der User sofort beim Kunden vor Ort ein Angebot per Pdf an den Kunden per Mail schicken kann.
