using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus69_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sana, uusisana; // string-muuttujat sana ja uusisana
            int pituus; // kokonaislukumuuttuja pituus

            Console.Write("Anna jokin sana: "); // pyydetään käyttäjältä sana
            sana = Console.ReadLine(); // luetaan annettu sana muuttujaan sana

            pituus = sana.Length; // muuttujan pituudeksi annetaan annetun sanan pituus
            char[] kirjaimet = new char[pituus]; // merkki-taulukko, jonka sisällä on tieto annetun sanan pituudesta

           for (int i = 0; i < pituus; i++) // for-loop käy muuttujan pituus läpi
                kirjaimet[i] = sana[i]; // taulukko kirjaimet saa arvokseen annetun sanan
            kirjaimet[0] = sana[pituus - 1]; // taulukon kirjaimet nollannes kirjain saa arvokseen annetun sanan viimeisen kirjaimen
            kirjaimet[pituus - 1] = sana[0]; // taulukon kirjaimet viimeinen kirjain saa arvokseen annetun sanan nollannen kirjaimen
            uusisana = String.Join(" ", kirjaimet); // uusisana-muuttuja liitetään kirjaimet-taulukkoon
           
            Console.WriteLine("Antamasi sana oli: {0}. Antamasi sana on nyt: {1}", sana,uusisana); // tulostetaan konsoliin uudelleen järjestelty sana
            Console.ReadLine();
        }
    }
}
