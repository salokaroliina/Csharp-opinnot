using System;


namespace Harjoitus68_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, yhteen, vahennys, kerto; //  kokonaislukumuuttujat
            double jako; // jako-muuttuja on double-luku, sillä jakolaskun tulos saattaa olla desimaaliluku
        alku: // kohta, johon ohjelma voidaan määrätä palaamaan
            Console.WriteLine("Anna ensimmäinen kokonaisluku: "); // pyydetään käyttäjältä ensimmäistä kokonaislukua

            try // testataan onko syötetty luku oikeassa muodossa
            {
                luku1 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex) // jos luku ei ole oikeassa muodossa, ohjelma herjaa siitä
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi syöte ei ollut kokonaisluku. Yritä uudelleen.");
                goto alku; // ohjelma palaa alkuun ja pyytää lukua uudelleen
            }
        tokaluku: // jos ensimmäinen luku on oikein mutta seuraava ei, ohjelma voi palata tähän pyytämään lukua uudelleen
            Console.WriteLine("Anna seuraava kokonaisluku: ");

            try // testataan onko luku oikeassa muodossa
            {
                luku2 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex) // jos luku ei ole oikeassa muodossa, ohjelma herjaa siitä
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi syöte ei ollut luku. Yritä uudelleen.");
                goto tokaluku; // ohjelma palaa pyytämään toista lukua uudelleen
            }

            yhteen = yhteenlasku(luku1, luku2); // muuttuja yhteen kutsuu yhteenlasku-metodia, jonka toimittaa yhteenlaskun
            vahennys = vahennyslasku(luku1, luku2); // muuttuja vahennys kutsuu vahennyslasku-metodia, joka toimittaa vähennyslaskun
            jako = jakolasku(luku1, luku2); // muuttuja jako kutsuu jakolasku-metodia, joka suorittaa jakolaskun
            kerto = kertolasku(luku1, luku2); // muuttuja kerto kutsuu kertolasku-metodia, joka suorittaa kertolaskun
            Console.WriteLine("Yhteenlaskun summa: " + yhteen); // Konsoliin kirjoitetaan kunkin laskutoimituksen tulos omalle rivilleen
            Console.WriteLine("Vähennyslaskun summa: " + vahennys);
            Console.WriteLine("Jakolaskun summa: " + jako);
            Console.WriteLine("Kertolaskun summa: " + kerto);
            Console.ReadLine();
        }

        static int yhteenlasku(int eka, int toka) // yhteenlasku-metodi, joka palauttaa arvokseen yhteenlaskutoimituksen
        {
            return (eka + toka);
        }

        static int vahennyslasku(int eka, int toka) // vahennyslasku-metodi, joka palauttaa arvokseen vähennyslaskutoimituksen
        {
            return (eka - toka);
        }

        static double jakolasku(int eka, int toka) // jakolasku-metodi, joka palauttaa arvokseen jakolaskutoimituksen
                                                   // !HUOM! koska jalokaskun tulos saattaa olla desimaaliluku, eli double-luku, metodi määritellään doubleksi
        {
            return (eka / toka);
        }
        static int kertolasku(int eka, int toka) // kertolasku-metodi, joka palauttaa arvokseen kertolaskutoimituksen
        {
            return (eka * toka);
        }
    }
}
