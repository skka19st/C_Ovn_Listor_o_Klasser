using System;

namespace ovn3
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            // skapa objekt/instans av klassen cPerson
            // inga värden sätts direkt i contructor
            cPerson personData = new cPerson();

            // samla in personinfo - förnamn
            Console.WriteLine("Vad heter personen i förnamn?");
            string fornamn = Console.ReadLine();
            personData.SparaForNamn(fornamn);

            // efternamn
            Console.WriteLine("Efternamn?");
            string efternamn = Console.ReadLine();
            personData.SparaEfterNamn(efternamn);

            // ålder
            Console.WriteLine("Ålder?");
            string age = Console.ReadLine();
            personData.SparaAge(age);

            // yrke
            Console.WriteLine("Yrke?");
            string yrke = Console.ReadLine();
            personData.SparaYrke(yrke);
            
            // bostadsort
            Console.WriteLine("Bostadsort?");
            string plats = Console.ReadLine();
            personData.SparaPlats(plats);

            // skriv ut personinfo
            Console.Clear();
            personData.SkrivPersoninfo();
        }
    }
}
