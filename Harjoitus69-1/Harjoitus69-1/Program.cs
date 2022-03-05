using System;


namespace Harjoitus69_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ika; // kokonaislukumuuttuja
            alku:
            Console.Write("Minkä ikäinen olet? "); // pyydetään käyttäjältä tämän ikää

            try // testataan, onko syötetty tieto kokonaisluku
            {
                ika = int.Parse(Console.ReadLine());
            }
            catch (Exception ex) // mikäli syötetty tieto ei ole kokonaisluku, ohjelma herjaa siitä ja palaa alkuun
            {
                Console.WriteLine(ex.Message);  
                Console.WriteLine("Et antanut ikääsi. Yritä uudelleen.");
                goto alku;
            }

            if (ika <= 0) // jos käyttäjä yrittää antaa iäkseen alle 1, ohjelma herjaa ja palaa alkuun
            {
                Console.WriteLine("Et antanut ikääsi. Yritä uudelleen.");
                goto alku;
            }
            Console.WriteLine("{0} - näytät ikäistäsi nuoremmalta", ika); // ohjelma kertoo käyttäjän näyttävän ikäistään nuoremmalta
                                                                                                // tässä käytetty C#:n omaa tapaa lisätä muuttuja WriteLineen
            Console.ReadLine();
        }
    }
}
