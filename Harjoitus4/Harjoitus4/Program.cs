using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String luku1, luku2, luku3, luku4, luku5;
            int num1, num2, num3, num4, num5;

            Console.WriteLine("Anna 1. kokonaisluku: ");
            luku1 = Console.ReadLine();
            Console.WriteLine("Anna 2. kokonaisluku: ");
            luku2 = Console.ReadLine();
            Console.WriteLine("Anna 3. kokonaisluku: ");
            luku3 = Console.ReadLine();
            Console.WriteLine("Anna 4. kokonaisluku: ");
            luku4 = Console.ReadLine();
            Console.WriteLine("Anna 5. kokonaisluku: ");
            luku5 = Console.ReadLine();

            // muunnetaan käyttäjän antamat numerot luvuiksi
            num1 = Int32.Parse(luku1);
            num2 = Int32.Parse(luku2);
            num3 = Int32.Parse(luku3);
            num4 = Int32.Parse(luku4);
            num5 = Int32.Parse(luku5);

            // ohjelma vertailee käyttäjän syöttämiä lukuja keskenään ja kirjoittaa konsoliin suurimman luvun
            if (num1 >= num2 && num1 >= num3 && num1 >= num4 && num1 >= num5)
            {
                Console.WriteLine("Suurin kokonaisluku: " + num1);
                Console.ReadLine();
            }
            else if (num2 >= num1 && num2 >= num3 && num2 >= num4 && num2 >= num5)
            {
                Console.WriteLine("Suurin kokonaisluku: " + num2);
                Console.ReadLine();
            }
            else if (num3 >= num1 && num3 >= num2 && num3 >= num4 && num3 >= num5)
            {
                Console.WriteLine("Suurin kokonaisluku: " + num3);
                Console.ReadLine();
            }
            else if (num4 >= num1 && num4 >= num2 && num4 >= num3 && num4 >= num5)
            {
                Console.WriteLine("Suurin kokonaisluku: " + num4);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Suurin kokonaisluku: " + num5);
                Console.ReadLine();
            }
        }
    }
}
