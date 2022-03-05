using System;

namespace Harjoitus68_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nimi, tervehdys; // string-muuttujat nimi ja tervehdys
            Console.Write("Kirjoita nimesi: "); // pyydetään käyttäjältä tämän nimeä
            nimi = Console.ReadLine(); // string nimi lukee konsoliin syötetyn tekstin
            tervehdys = nimesi(nimi); // string tervehdys kutsuu nimesi-metodia 
            Console.WriteLine(tervehdys); // konsoliin kirjoittuu teksti "Hei (antamasi nimi)"
            Console.ReadLine();
            
        }
        static string nimesi(string name) // ulkopuolinen metodi, joka määrää mitä konsoliin kirjoittuu
        {
            return ("Hei " + name); 
        }
    }
}
