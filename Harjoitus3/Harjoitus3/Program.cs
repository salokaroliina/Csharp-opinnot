using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // kirjoitetaan sijainti johon ohjelma voi tarvittaessa palata
        Alku:
            // pyydetään käyttäjältä kokonaislukua
            Console.WriteLine("Syötä kokonaisluku (0-9) :");
            string luku = Console.ReadLine();

            // switch-case on järkevä ratkaisu kun vaihtoehtoja on useampia
            switch (luku)
            {
                case "0":
                    Console.WriteLine("Nolla");
                    Console.ReadLine();
                    break;
                case "1":
                    Console.WriteLine("Yksi");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Kaksi");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Kolme");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Neljä");
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("Viisi");
                    Console.ReadLine();
                    break;
                case "6":
                    Console.WriteLine("Kuusi");
                    Console.ReadLine();
                    break;
                case "7":
                    Console.WriteLine("Seitsemän");
                    Console.ReadLine();
                    break;
                case "8":
                    Console.WriteLine("Kahdeksan");
                    Console.ReadLine();
                    break;
                case "9":
                    Console.WriteLine("Yhdeksän");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Luku ei kelpaa!");
                    Console.ReadLine();
                    // jos käyttäjä ei ole syöttänyt kokonaislukua, ohjelma palauttaa käyttäjän aina alkuun ja pyytää lukua uudelleen
                    goto Alku;
                    break;

            }
        }
    }
}
