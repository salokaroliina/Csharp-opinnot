using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus68_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, summa; // kokonaislukumuuttujat
        alku: // kohta, johon ohjelma voidaan ohjata palaamaan
            Console.WriteLine("Anna ensimmäinen kokonaisluku: "); // pyydetään käyttäjältä ensimmäistä kokonaislukua

            try // testataan, onko annettu luku oikeassa muodossa
            {
                luku1 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex) // mikäli luku ei ole oikeassa muodossa, ohjelma herjaa siitä
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luku ei ollut kokonaisluku. Yritä uudelleen.");
                goto alku; // ohjelma palaa alkuun
            }

        tokaluku: // mikäli ensimmäinen luku on oikein, mutta toinen ei, ohjelma palaa tähän kohtaan pyytämään toista lukua uudelleen
            Console.WriteLine("Anna seuraava kokonaisluku: "); // pyydetään käyttäjältä seuraavaa kokonaislukua

            try // testataan, onko annettu luku oikeassa muodossa
            {
                luku2 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex) // mikäli luku ei ole oikeassa muodossa, ohjelma herjaa siitä
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luku ei ollut kokonaisluku. Yritä uudelleen.");
                goto tokaluku; // ohjelma palaa pyytämään seuraavaa lukua uudelleen
            }
            summa = jakojaannos(luku1, luku2); // summa kutsuu jakojaannos-metodia, joka suorittaa jakojäännös-laskutoimituksen
            Console.WriteLine("Syöttämiesi lukujen jakojäännös: " + summa); // kirjoitetaan konsoliin laskutoimituksen tulos
            Console.ReadLine();
        }

        static int jakojaannos(int eka, int toka) // jakojaannos-metodi, joka suorittaa jakojäännös-laskutoimituksen annetuilla luvuilla
        {
            return (eka % toka);
        }
    }
}
