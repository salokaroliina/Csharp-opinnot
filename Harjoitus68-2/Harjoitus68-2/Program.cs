using System;


namespace Harjoitus68_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tulos; // double-luvut celsius ja tulos
            tulos = lampotila(10); // tulos kutsuu lampotila-metodia, joka pitää sisällään laskukaavan
                                                   
            Console.WriteLine("10 celsius-astetta on " + tulos + " fahrenheitia."); // kirjoitetaan konsoliin tulos
            Console.ReadLine();
            
        }
       static double lampotila(double c) // lampotila-metodi, jonka argumenttina double-luku c
        {
            return(c * 1.8 + 32); // laskukaava, jolla celsius muutetaan fahrenheitiksi (celsius * 1.8 + 32)
                                        // laskukaava palautetaan metodille, jotta metodia kutsuttaessa kaavaa voidaan käyttää suoraan
        }
    }
}
