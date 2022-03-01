using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeiKaro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nimi;
            Console.WriteLine("Kirjoita nimesi: ");
            nimi = Console.ReadLine();
            Console.WriteLine("Hei " + nimi);
            Console.ReadLine();
        }
    }
}
