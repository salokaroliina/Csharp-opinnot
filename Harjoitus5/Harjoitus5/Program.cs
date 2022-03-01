using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kluku;
            double dluku;
            string mjono, syote;
        syottoalku:
            Console.WriteLine("Minkä tyyppisen tiedon haluat syöttää (double, int, string (d/i/s)): ");
            syote = Console.ReadLine();
            if (syote == "s" || syote == "d" || syote == "i" || syote == "S" || syote == "D" || syote == "I")
            {
                switch (syote)
                {
                    case "s":
                    case "S":
                        Console.Write("Söytä merkkijono: ");
                        mjono = Console.ReadLine();
                        Console.WriteLine(mjono += "*");
                        Console.Read();
                        break;
                    case "d":
                    case "D":
                    doublealku:
                        Console.Write("Syötä doubleluku: ");
                        try
                        {
                            dluku = Double.Parse(Console.ReadLine());
                            Console.WriteLine(dluku + 1);
                            Console.Read();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Ole hyvä ja anna doubleluku.");
                            goto doublealku;
                        }
                        break;
                    case "i":
                    case "I":
                    intalku:
                        Console.Write("Syötä kokonaisluku: ");
                        try
                        {
                            kluku = Int32.Parse(Console.ReadLine());
                            Console.WriteLine(kluku + 1);
                            Console.Read();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Ole hyvä ja syötä kokonaisluku.");
                            Console.Read();
                            goto intalku;
                        }

                        break;
                    default:
                        Console.WriteLine("Jos päädyt tänne, jossakin on virhe.");
                        Console.Read();
                        break;
                }

            }
            else
            {
                Console.WriteLine("Annoit väärän syötteen. Anna vain kirjain.");
                goto syottoalku;
            }

        }
    }
}
