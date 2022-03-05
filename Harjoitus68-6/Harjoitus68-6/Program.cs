using System;


namespace Harjoitus68_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, summa; // kokonaislukumuuttujat luku1,luku2 ja summa
        alku:
            Console.Write("Anna ensimmäinen kokonaisluku: "); // pyydetään käyttäjältä ensimmäinen kokonaisluku

            try // testataan onko käyttäjän antama syöte kokonaisluku
            {
                luku1 = int.Parse(Console.ReadLine()); // luetaan ensimmäinen annettu luku muuttujaan luku1, muuttaen se samalla kokonaisluvuksi
            }
            catch (Exception ex) // mikäli syötetty luku ei ollut oikeassa muodossa, ohjelma herjaa siitä
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi syöte ei ollut kokonaisluku. Yritä uudelleen.");
                goto alku; // ohjelma palaa alkuun
            }
        tokaluku: // mikäli ensimmäinen luku oli oikeassa muodossa, voi ohjelma palata kohtaan, jossa käyttäjältä pyydetään seuraavaa lukua
            Console.Write("Anna toinen kokonaisluku: "); // pyydetään käyttäjältä toinen kokonaisluku
            try // testataan toisena syötetty luku
            {
                luku2 = int.Parse(Console.ReadLine()); // luetaan toisena annettu luku muuttujaan luku2, muuttaen se samalla kokonaisluvuksi
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi syöte ei ollut luku. Yritä uudelleen.");
                goto tokaluku; // ohjelma palaa kohtaan, jossa pyydetään seuraavaa lukua
            }

            summa = yhteenlasku(luku1, luku2); // summa-muuttuja kutsuu yhteenlasku-metodia, joka laskee yhteen annetut luvut
            Console.WriteLine("Antamisesi lukujen summa on: " + summa); // kirjoitetaan konsoliin lukujen summa
            Console.ReadLine();
        }
        // ohjelman muut metodit on Main-metodin ulkopuolella
        static int yhteenlasku(int eka, int toka) // kokonaisluku-metodi, jonka argumentteina kokonaislukumuuttujat eka ja toka
        {
            return (eka + toka); // palautetaan metodin arvoksi yhteenlasku syötettyjen lukujen kesken
        }
    }
}