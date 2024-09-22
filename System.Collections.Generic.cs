using System;
using System.Collections.Generic;

namespace Inlämning_2_OOP
{
    // Basklass Person
    public class Person
    {
        public string Namn { get; private set; }
        public int Personnummer { get; private set; }

        public Person(string namn, int personnummer)
        {
            Namn = namn;
            Personnummer = personnummer;
        }

        public virtual void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Personnummer: {Personnummer}");
        }
    }

    // Subklass Elev
    public class Elev : Person
    {
        public int ElevID { get; private set; }
        private List<Kurs> kurser = new List<Kurs>();

        public Elev(string namn, int personnummer, int elevID)
            : base(namn, personnummer)
        {
            ElevID = elevID;
        }

        public void SkickaInArbete()
        {
            // Implementera logik för att skicka in arbete
            Console.WriteLine($"{Namn} skickade in arbete.");
        }

        public void LäggTillKurs(Kurs kurs)
        {
            kurser.Add(kurs);
            Console.WriteLine($"{Namn} är nu inskriven i kursen {kurs.KursNamn()}.");
        }
    }

    // Subklass Lärare
    public class Lärare : Person
    {
        public int LärarID { get; private set; }

        public Lärare(string namn, int personnummer, int lärarID)
            : base(namn, personnummer)
        {
            LärarID = lärarID;
        }

        public void TilldelaUppgift()
        {
            // Implementera logik för att tilldela uppgift
            Console.WriteLine($"{Namn} tilldelade en uppgift.");
        }
    }

    // Klass Kurs
    public class Kurs
    {
        public int KursID { get; private set; }
        public string Kursnamn { get; private set; }
        public Lärare Lärare { get; private set; }

        public Kurs(int kursID, string kursnamn, Lärare lärare)
        {
            KursID = kursID;
            Kursnamn = kursnamn;
            Lärare = lärare;
        }

        public string KursNamn()
        {
            return Kursnamn;
        }
    }

    // Klass Betyg
    public class Betyg
    {
        public int Poäng { get; private set; }
        public Kurs Kurs { get; private set; }
        public Elev Elev { get; private set; }

        public Betyg(int poäng, Kurs kurs, Elev elev)
        {
            Poäng = poäng;
            Kurs = kurs;
            Elev = elev;
        }

        public void GeBetyg()
        {
            // Implementera logik för att ge betyg
            Console.WriteLine($"Betyg {Poäng} gavs till {Elev.Namn} i kursen {Kurs.KursNamn()}.");
        }
    }

}
