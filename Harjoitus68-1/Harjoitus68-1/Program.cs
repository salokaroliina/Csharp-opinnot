using System;


namespace Harjoitus68_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summa; // kokonaislukumuuttuja summa
            summa = yhteenlasku(3,5); // summa-muuttuja kutsuu yhteenlasku-metodia, joka laskee yhteen annetut luvut
            Console.WriteLine("3 + 5 = " + summa); // kirjoitetaan konsoliin lukujen summa
            Console.ReadLine();
        }
        // ohjelman muut metodit on Main-metodin ulkopuolella
        static int yhteenlasku(int eka, int toka) // kokonaisluku-metodi, jonka argumentteina kokonaislukumuuttujat eka ja toka
        {
            return (eka + toka); // palautetaan metodin arvoksi yhteenlasku määriteltyjen lukujen kesken
        }
    }
}
