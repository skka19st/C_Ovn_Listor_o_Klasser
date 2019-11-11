using System;

namespace ovn2
{
    class Program
    {
        static void Main(string[] args)
        {
            // skapa objekt/instans av klassen cKatt
            // värden sätts direkt i contructor
            cKatt katt1 = new cKatt("Tussan", 8);
            cKatt katt2 = new cKatt("Oskar", 12);

            // skriv ut info
            katt1.Talk();
            katt2.Talk();
        }
    }
}
