// namespace som används
using System;
using System.Collections.Generic;

namespace ovn3
{
    // public = klassen kan användas av andra projekt
    // standard är 'internal' = endast det egna projektet kan använda
    public class cPerson
    {
        // deklaration av klassens data
        private string fnamn;
        private string enamn;        
        private string age;
        private string yrke;
        private string plats;
        public void SparaForNamn(string namn)
        {
            fnamn = namn;
        }
        public void SparaEfterNamn(string namn)
        {
            enamn = namn;
        }
       public void SparaAge(string age)
        {
            this.age = age;
        }
        public void SparaYrke(string yrke)
        {
            this.yrke = yrke;
        }
        public void SparaPlats(string plats)
        {
            this.plats = plats;
        }
        public void SkrivPersoninfo()
        {            
            Console.Write($"{fnamn} är {age} år och bor i {plats}.");
            Console.Write($" Hen är {yrke} och heter {enamn} i efternamn.");
            Console.WriteLine();
        }
    }
}