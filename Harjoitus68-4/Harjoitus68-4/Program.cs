using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus68_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summa; // kokonaislukumuuttuja 'summa'
            summa = jakojaannos(5,2); // summa kutsuu jakojaannos-metodia, joka suorittaa jakojäännös-laskutoimituksen
            Console.WriteLine("Lukujen 5 ja 2 jakojäännös on " + summa); // kirjoitetaan konsoliin laskutoimituksen tulos
            Console.ReadLine();
        }

        static int jakojaannos(int eka, int toka) // jakojaannos-metodi, joka suorittaa jakojäännös-laskutoimituksen annetuilla luvuilla
        {
            return (eka % toka);
        }
    }
}
