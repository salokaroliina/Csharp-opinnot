using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laskuTehtävät
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lasku 1
            // muuttujat luku1 ja luku2 luetaan stringeina
            String luku1, luku2;
            // muuttuja summa luetaan lukuna
            int summa;
            // konsoliin tulee tekstiä omille riveilleen
            Console.WriteLine("Pluslasku");
            Console.Write("Anna 1. luku: ");
            // luku1 on käyttäjän konsoliin kirjoittama numero
            luku1 = Console.ReadLine();
            // käyttäjältä pyydetään toinen numero
            Console.Write("Anna 2. luku: ");
            // luku2 on käyttäjän konsoliin kirjoittama toinen numero
            luku2 = Console.ReadLine();
            // Int32.Parse muuntaa String-tyyppisen muuttujan int:iksi eli luvuksi
            summa = Int32.Parse(luku1) + Int32.Parse(luku2);
            // konsoliin tulee laskutoimituksen vastaus
            Console.WriteLine("Tulos: " + summa);
            Console.ReadLine();

            // lasku 2
            String luku3, luku4;
            Console.WriteLine("Miinuslasku");
            Console.Write("Anna 1. luku: ");
            luku3 = Console.ReadLine();
            Console.Write("Anna 2. luku: ");
            luku4 = Console.ReadLine();
            summa = Int32.Parse(luku3) - Int32.Parse(luku4);
            Console.WriteLine("Tulos: " + summa);
            Console.ReadLine();

            // lasku 3
            String luku5, luku6;
            Console.WriteLine("Kertolasku");
            Console.Write("Anna 1. luku: ");
            luku5 = Console.ReadLine();
            Console.Write("Anna 2. luku: ");
            luku6 = Console.ReadLine();
            summa = Int32.Parse(luku5) * Int32.Parse(luku6);
            Console.WriteLine("Tulos: " + summa);
            Console.ReadLine();

            // lasku 4
            String luku7, luku8;
            Console.WriteLine("Jakolasku");
            Console.Write("Anna 1. luku: ");
            luku7 = Console.ReadLine();
            Console.Write("Anna 2. luku: ");
            luku8 = Console.ReadLine();
            summa = Int32.Parse(luku7) / Int32.Parse(luku8);
            Console.WriteLine("Tulos: " + summa);
            Console.ReadLine();

            // lasku 5
            String luku9, luku10;
            Console.WriteLine("Jakojäännös");
            Console.Write("Anna 1. luku: ");
            luku9 = Console.ReadLine();
            Console.Write("Anna 2. luku: ");
            luku10 = Console.ReadLine();
            summa = Int32.Parse(luku9) % Int32.Parse(luku10);
            Console.WriteLine("Tulos: " + summa);
            Console.ReadLine();

            // lasku 6
            String luku11, luku12;
            // summa-muuttujaa ei enää käytetä
            // luotiin uudet luku-muuttujat joille string-muotoiset muuttujat annetaan luvuiksi muutettuina
            int num1, num2;
            Console.WriteLine("Pluslasku 2");
            Console.Write("Anna 1. luku: ");
            luku11 = Console.ReadLine();
            Console.Write("Anna 2. luku: ");
            luku12 = Console.ReadLine();
            // luku-muuttujat saavat arvokseen käyttäjän syöttämät numerot luku-muodossa
            num1 = Int32.Parse(luku11);
            num2 = Int32.Parse(luku12);
            Console.Write("Tulos: ");
            Console.WriteLine(num1 += num2);
            Console.ReadLine();

            // lasku 7
            String luku13, luku14;
            int num3, num4;
            Console.WriteLine("Miinuslasku 2");
            Console.Write("Anna 1. luku: ");
            luku13 = Console.ReadLine();
            Console.Write("Anna 2. luku: ");
            luku14 = Console.ReadLine();
            num3 = Int32.Parse(luku13);
            num4 = Int32.Parse(luku14);
            Console.Write("Tulos: ");
            Console.WriteLine(num3 -= num4);
            Console.ReadLine();

            // lasku 8
            String luku15, luku16;
            int num5, num6;
            Console.WriteLine("Kertolasku 2");
            Console.Write("Anna 1. luku: ");
            luku15 = Console.ReadLine();
            Console.Write("Anna 2. luku: ");
            luku16 = Console.ReadLine();
            num5 = Int32.Parse(luku15);
            num6 = Int32.Parse(luku16);
            Console.Write("Tulos: ");
            Console.WriteLine(num6 *= num5 * 5);
            Console.ReadLine();

            // lasku9
            String luku17, luku18;
            int num7, num8;
            Console.WriteLine("Jakolasku 2");
            Console.Write("Anna 1. luku: ");
            luku17 = Console.ReadLine();
            Console.Write("Anna 2. luku: ");
            luku18 = Console.ReadLine();
            num7 = Int32.Parse(luku17);
            num8 = Int32.Parse(luku18);
            Console.Write("Tulos: ");
            Console.WriteLine(num7 /= num8);
            Console.ReadLine();
        }
    }
}
