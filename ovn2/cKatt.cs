// namespace som används
using System;
using System.Collections.Generic;

namespace ovn2
{
    // public = klassen kan användas av andra projekt
    // standard är 'internal' = endast det egna projektet kan använda
    public class cKatt
    {
        // deklaration av klassens data
        private string namn;
        private int age;

        // constructor, initierar klassens datafält
        // constructor lämnar inget returvärde
        // constructor måste ha samma namn som klassen
        // this används när man refererar till klassens egna variabler
        public cKatt(string namnIn, int ageIn)
        {
            namn = namnIn;
            age = ageIn;
        }
        public void Talk()
        {
            Console.Write($"Katten heter {namn}, är {age} år ");
            Console.WriteLine("och säger mjau.");
        }
    }
}