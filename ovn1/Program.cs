// namespace som används
using System;
using System.Collections.Generic;

namespace ovn1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> djurlista = new List<string>();
            Console.WriteLine("Ange namn på fem djur:");

            for (int ind = 1 ; ind <= 5 ; ind++)
            {
                Console.Write(ind + ": ");
                string djurnamn = Console.ReadLine();
                djurlista.Add(djurnamn);
            }

            Console.WriteLine("Dessa djur finns nu i listan: ");
            foreach (string namn in djurlista)
            {
                Console.WriteLine(namn);
            }
        }
    }
}
