using System;


namespace Harjoitus68_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yhteen, vahennys,kerto; //  kokonaislukumuuttujat
            double jako; // jako-muuttuja on double-luku
            Console.WriteLine("Luvuilla 8 ja 5 tehdyt peruslaskutoimitukset: "); 
            yhteen = yhteenlasku(8,5); // muuttuja yhteen kutsuu yhteenlasku-metodia, jonka toimittaa yhteenlaskun
            vahennys = vahennyslasku(8, 5); // muuttuja vahennys kutsuu vahennyslasku-metodia, joka toimittaa vähennyslaskun
            jako = jakolasku(8, 5); // muuttuja jako kutsuu jakolasku-metodia, joka suorittaa jakolaskun
            kerto = kertolasku(8, 5); // muuttuja kerto kutsuu kertolasku-metodia, joka suorittaa kertolaskun
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
        
        static double jakolasku(double eka, double toka) // jakolasku-metodi, joka palauttaa arvokseen jakolaskutoimituksen
                                                                            // !HUOM! jakolasku-metodi on double, sillä jakolaskun summa voi olla double-luku eli desimaali
        {
            return (eka / toka);
        }
        static int kertolasku(int eka, int toka) // kertolasku-metodi, joka palauttaa arvokseen kertolaskutoimituksen
        {
            return (eka * toka);
        }
    }
}
