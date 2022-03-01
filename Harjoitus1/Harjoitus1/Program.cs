using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String luku1, luku2;
            int num1, num2;
            Console.WriteLine("Anna 1. kokonaisluku: ");
            luku1 = Console.ReadLine();
            Console.WriteLine("Anna 2. kokonaisluku: ");
            luku2 = Console.ReadLine();
            num1 = Int32.Parse(luku1);
            num2 = Int32.Parse(luku2);

            // jos käyttäjän antama luku 1 on pienempi kuin luku 2, ohjelma laittaa ne syötettyyn järjestykseen
            if (num1 <= num2)
            {
                Console.WriteLine(num1 + " " + num2);
            }
            else
            {
                // jos syötetty 1 luku on suurempi kuin luku 2, ohjelma kääntää ne järjestykseen
                Console.WriteLine(num2 + " " + num1);
            }
            Console.ReadLine();

        }
    }
}
