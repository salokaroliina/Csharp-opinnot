using System;

namespace Harjoitus69_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku = 99; // kokonaislukumuuttuja 'luku', jolle on jo annettu arvoksi 99

            for (int i = 1; i < luku; i++) // for-loop käy läpi luku-muuttujan yksi kerrallaan (koska luku-muuttujan arvo on 99, looppi pysähtyy siihen)
            {
                i = i + 2; // annetaan i:lle arvoksi i + 2, jolloin konsoliin tulostuu joka kolmas luku 1-99 väliltä
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}