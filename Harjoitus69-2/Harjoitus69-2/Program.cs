using System;


namespace Harjoitus69_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku; // kokonaislukumuuttuja
            alku:
            Console.Write("Anna kokonaisluku joka on 10 tai suurempi: "); // pyydetään käyttäjältä numeroa

            try // testataan, onko käyttäjän syöttämä luku oikeassa muodossa (kokonaisluku)
            {
                luku = int.Parse(Console.ReadLine()); // luetaan käyttäjän antama numero luku-muuttujaan
            }
            catch (Exception ex) // mikäli syöte ei ole kokonaisluku, ohjelma herjaa siitä ja palaa alkuun
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi syöte ei ollut kelvollinen. Yritä uudelleen.");
                goto alku;
            }
            if(luku < 10) // jos luku on alle 10, ohjelma herjaa siitä ja palaa alkuun
            {
                Console.WriteLine("Antamasi luku on liian pieni. Syötä kokonaisluku joka on 10 tai suurempi.");
                goto alku;
            }

            for (int k = 0; k < luku; k++) { // for looppi, joka pitää sisällään kahta muuta for-looppia
                                                        // looppi käy läpi käyttäjän antaman luvun niin monta kertaa kuin luku itse on (esim. 10)
                                                        // tämä looppi tulostaa sen sisällä olevat loopit niin monta kertaa kuin käyttäjän antama luku on
            
                for(int i = 0; i < luku; i++) // for-looppi, joka käy läpi käyttäjän antaman luvun niin monta kertaa kuin luku itse on
                {
                    Console.Write(luku + " "); // tulostaa konsoliin käyttäjän syöttämän luvun välilyönnin kanssa
                }
                Console.Write('\n'); // tulostetaan konsoliin pakollinen rivinvaihto

                for (int j = 0; j < luku; j++) // for-looppi käy luku-muuttujan uudelleen läpi
                {
                    Console.Write(luku); // tulostetaan konsoliin käyttäjän syöttämä luku, mutta ilman välilyöntiä
                }
                Console.Write('\n'); // tulostetaan konsoliin pakollinen rivinvaihto
            }

        Console.ReadLine(); // konsoli näyttää tuloksen vasta kun kaikki loopit ovat pysähtyneet
        }
    }
}
