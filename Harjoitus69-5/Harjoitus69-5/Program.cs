using System;


namespace Harjoitus69_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lause; // string-muuttuja lause
            string[] sanat; // taulukko-muuttuja sanat
            int pituus; // kokonaisluku-muuttuja pituus
            int min = 0; // kokonaislukumuuttuja min, jonka arvo on 0
            int max = 0; // kokonaislukumuuttuja max, jonka arvo on 0

            Console.Write("Anna lause: "); // pyydetään käyttäjältä lausetta
            lause = Console.ReadLine(); // luetaan lause-muuttujaan käyttäjän antama lause
            sanat = lause.Split(' '); // hajotetaan annettu lause taulukoksi
            pituus = sanat.Length; // pituus-muuttuja saa arvokseen sanat-taulukon pituuden
                                            // length-loppua käytetään, kun int-muuttujalle haetaan arvo string-muuttujasta

            // haetaan taulukosta lauseen pisin sana
            for (int i = 0; i < pituus; i++) // for-loop, joka käy annetun sanan läpi lause lauseelta
            {
                if (sanat[i].Length > min) // jos taulukon pituus on enemmän kuin min (0), muuttuja min on sama kuin taulukon pituus
                {
                    min = sanat[i].Length;
                    max = i; //max-muuttuja saa arvokseen i:n, eli pisimmän sanan jonka looppi löysi
                }
            }
            Console.WriteLine("Pisin sana lauseessasi on: {0}", sanat[max]); // tulostetaan konsoliin taulukko 'sanat', jonka sisällä on lauseen pisin sana
            Console.Read();
        }
    }
}
