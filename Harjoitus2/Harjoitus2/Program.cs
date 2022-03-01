using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] luvut = new int[3];
            luvut[0] = Console.Read();
            Array.Sort(luvut);
            int viimeinen = luvut.Length;
            Console.WriteLine(luvut[viimeinen - 1]);
        }
    }
}


