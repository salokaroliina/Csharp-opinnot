using System;

namespace Harjoitus69_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku = 99; // kokonaislukumuuttuja 'luku', jolle on jo annettu arvoksi 99
            
            for (int i = 0; i < luku; i++) // for-loop käy läpi luku-muuttujan yksi kerrallaan (koska luku-muuttujan arvo on 99, looppi pysähtyy siihen)
            {
                i = i + 1; // annetaan i:lle arvoksi i + 1, jolloin konsoliin tulostuu joka toinen luku 1-99 väliltä
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
