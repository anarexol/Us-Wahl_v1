using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace US_Wahl
{
    //Aufstellen der Enums
    enum Geschlecht { Weiblich, Mänlich }
    enum Beeinflußbarkeit { Leicht, Mittel, Schwer }
    enum Schicht { UnterSchicht, UntermittelSchicht, OberemittelSchicht, ObereSchicht }
    enum PolitischeHeimat { Republikaner, Demokraten }
    class Person
    {
        //Properties der Klasse Person
        public int ID { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public  Geschlecht  geschlecht { get; set; }
        public Beeinflußbarkeit  beeinflußbarkeit { get; set; }
        public Schicht schicht { get; set; }
        public PolitischeHeimat politischeHeimat { get; set; }

        //Hier werden die Dateien mit den Vor und Nachnamen geöffnet und in string Arrays geschrieben
        string[] Nachnamearray = File.ReadAllLines("nachnamen-UTF8.txt");
        string[] JungVornamearray = File.ReadAllLines("jungennamen.txt");
        string[] MädchenVornamearray = File.ReadAllLines("maedchennamen.txt");

        static Random zf = new Random();
        public Person() {      //Der Konstruktor von Person, wir erstellen eine Zufallszahl, anhand der wir das Geschlecht zuweisen, je nachdem ob dabei ein Mann oder eine Frau erschaffen wird, werden die anderen Attribute wie Vorname gesetzt.
            geschlecht = (Geschlecht)(zf.Next(2));

            if (geschlecht ==  0){ //Anweisungen werden ausgeführt, wenn die erzeugt Person eine Frau ist (geschlecht == 0)
                Nachname = Nachnamearray[zf.Next(1000)];
                Vorname = MädchenVornamearray[zf.Next(MädchenVornamearray.Length)];
                beeinflußbarkeit = (Beeinflußbarkeit)zf.Next(3);
                politischeHeimat = (PolitischeHeimat)zf.Next(2);
                schicht = (Schicht)zf.Next(4);

            }
            else
            {
                Nachname = Nachnamearray[zf.Next(1000)]; //Anweisungen werden ausgeführt, wenn die erzeugt Person ein Mann ist
                Vorname = JungVornamearray[zf.Next(JungVornamearray.Length)];
                beeinflußbarkeit = (Beeinflußbarkeit)zf.Next(3);
                politischeHeimat = (PolitischeHeimat)zf.Next(2);
                schicht = (Schicht)zf.Next(4);
            }
        }
    }
}
