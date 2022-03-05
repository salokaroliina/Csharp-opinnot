using System;


namespace Harjoitus68_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, tulos; // double-luvut celsius ja tulos
        alku:
            Console.Write("Anna celsius-aste luku-muodossa: "); // pyydetään käyttäjältä celsius-astetta
            try // testataan, onko annettu luku oikeassa muodossa
            {
                celsius = double.Parse(Console.ReadLine());  // muutetaan annettu luku oikeaan muotoon
            }
            catch (Exception ex) // jos luku ei ole oikeassa muodossa, ohjelma herjaa siitä
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luku ei ollut oikeassa muodossa. Yritä uudelleen.");
                goto alku; // ohjelma palaa alkuun, mikäli luku ei ollut oikeassa muodossa
            }
            tulos = lampotila(celsius); // tulos kutsuu lampotila-metodia, joka pitää sisällään laskukaavan
                                        // laskukaava menee: x * 1.8 + 32 ( x = käyttäjän syöttämä luku)
            Console.WriteLine(celsius + " celsius-astetta on " + tulos + " fahrenheitia"); // kirjoitetaan konsoliin tulos
            Console.ReadLine();

        }
        static double lampotila(double c) // lampotila-metodi, jonka argumenttina double-luku c
        {
            return (c * 1.8 + 32); // laskukaava, jolla celsius muutetaan fahrenheitiksi (celsius * 1.8 + 32)
                                   // laskukaava palautetaan metodille, jotta metodia kutsuttaessa kaavaa voidaan käyttää suoraan
        }
    }
}
