using System;


namespace Harjoitus68_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, luku; // kokonaislukumuuttujat
            alku: // kohta, johon ohjelma voi palata
            Console.Write("Anna kokonaisluku 1-10 välillä: "); // pyydetään käyttäjältä kokonaisluku

            try // testataan, onko annettu luku oikeassa muodossa
            {
                luku = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luku ei ollut kokonaisluku. Yritä uudelleen.");
                goto alku; // jos luku ei ollut oikeassa muodossa, ohjelma palaa alkuun
            }

            if(luku <= 0 || luku > 10)
            {
                Console.WriteLine("Antamasi luku ei ollut 1-10 välillä. Yritä uudelleen.");
                goto alku;
            }
           
      
            Console.WriteLine(luku + ":n kertotaulu"); // ohjelma kertoo käyttäjälle, minkä luvun kertotaulun se näyttää
            
            for(i = 1; i <= 10; i++) // for-loop käy muuttujan i läpi 10 kertaa, yksi luku kerrallaan
            {
                Console.WriteLine(luku + " x " + i + " = " + luku*i); // konsoliin kirjoitetaan rivi kerrallaan syötetyn luvun kertotaulu
                                                                                        // koodi avattuna: käyttäjän syöttämä luku * for-loopin kierros (1-10)
                Console.ReadLine();

            }
        }

        

        
        
    }
}
