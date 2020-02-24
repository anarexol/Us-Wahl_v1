using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_Wahl
{
    class Program
    {
        static void Main(string[] args)
        {           
            List<Person> list = Wahlvolk.people(500); //Wir erstellen eine Liste mit 500 zufälligen Wählern
            Wahlvolk.NamenInDateiSchreiben(list); // Hier schreiben wir die Liste in eine Datei
            Wahlvolk.abfrage(list); //wir wenden eine Linq abfrage auf die eben erstellte Liste an und geben die Ergebnisse aus
            Console.ReadLine();


            Console.ReadLine();
        }
    }
}
