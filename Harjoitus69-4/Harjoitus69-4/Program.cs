using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus69_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eka, toka; // kokonaislukumuuttujat eka ja toka
            alku: // kohta, johon ohjelma voi tarvittaessa palata
            Console.Write("Anna ensimmäinen kokonaisluku: "); // pyydetään käyttäjältä kokonaislukua
            try //testataan, onko käyttäjän antama syöte oikeassa muodossa
            {
                eka = int.Parse(Console.ReadLine()); // luetaan käyttäjän antama luku eka-muuttujaan
            }
            catch (Exception ex) // mikäli syöte on väärässä muodossa, ohjelma herjaa siitä ja palaa alkuun
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luku ei ole kokonaisluku. Yritä uudelleen.");
                goto alku; // ohjelma palaa alkuun
            }
            tokaluku: // jos ensimmäinen luku on ok, mutta toinen ei, ohjelma voi palata pyytämään seuraavaa lukua uudestaan
            Console.Write("Anna toinen kokonaisluku: "); // pyydetään käyttäjältä toista kokonaislukua
            try // testataan, onko käyttäjän antama syöte oikeassa muodossa
            {
                toka = int.Parse(Console.ReadLine()); // luetaan käyttäjän antama luku toka-muuttujaan
            }
            catch(Exception ex) // mikäli syöte on väärässä muodossa, ohjelma herjaa siitä ja palaa pyytämään seuraavaa lukua uudestaan
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luku ei ole kokonaisluku. Yritä uudelleen.");
                goto tokaluku; // ohjelma palaa pyytämään seuraavaa lukua uudelleen
            }

            if(eka >= 0 && toka >=0) // jos muuttujat eka ja toka ovat molemmat 0 tai enemmän, konsoliin tulostetaan teksti joka kertoo molempien olevan pos.
            {
                Console.WriteLine("Molemmat luvut ovat positiivisia");
            }
            else if(eka < 0 && toka < 0) // jos muuttujat eka ja toka ovat pienempiä kuin 0, konsoliin tulostetaan teksti joka kertoo molempien olevan neg.
            {
                Console.WriteLine("Molemmat ovat negatiivisia");
            }
            else
            {
                Console.WriteLine("Toinen on positiivinen ja toinen negatiivinen"); // jos toinen muuttujista eka ja toka on yli 0, konsoliin tulostetaan teksti
                                                                                                            // joka kertoo toisen olevan pos. ja toisen neg.
            }
            Console.Read();
        }
    }
}
