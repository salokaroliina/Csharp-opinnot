using System;


namespace Harjoitus7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero; // kokonaisluku-muuttuja "numero"
        alkusana: // kohta, johon ohjelma voidaan määrätä palaamaan
            Console.Write("Anna numero (0-999), jonka ohjelma muuttaa sanaksi: "); // käyttäjältä pyydetään numeroa
            try // HUOM!! TÄRKEÄ!! 
                // testataan AINA, onko syötetty asia mitä on vaadittu
            {
                numero = int.Parse(Console.ReadLine()); // katsotaan, voidaanko syötetty luku parsia kokonaisluvuksi
            }
            catch (Exception ex) // mikäli syötetty asia ei ole oikeassa muodossa, ohjelma huomauttaa asiasta
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi arvo ei ole kokonaisluku!");
                goto alkusana; // ohjelma palaa alkuun
            }
            if (numero > 999 || numero < 0) // jos syötetty luku on suurempi kuin 999 tai pienempi kuin 0
                                            // ohjelma huomauttaa asiasta ja palaa alkuun
            {
                Console.WriteLine("Annoit luvun, joka ei ole välillä 0-999");
                goto alkusana;
            }
            else if (numero < 10) // jos syötetty luku on alle 10, ykkoset-metodi käynnistyy
            {
                string ykkonen; // string-muuttuja ykkonen, jolla voidaan kutsua muuttujaa ykkonen
                ykkonen = ykkoset(numero);
                Console.WriteLine(ykkonen); // haluttu luku kirjoitetaan sanana konsoliin
            }
            else if (numero < 20) // jos syötetty luku on alle 20, poikkeuskymmenet-metodi käynnistyy
            {
                string poikkeus;
                poikkeus = poikkeuskymmenet(numero);
                Console.WriteLine(poikkeus);
            }
            else if (numero < 100) // jos syötetty luku on alle 100, kymmenet-metodi käynnistyy
            {
                string kymmenen;
                kymmenen = kymmenet(numero);
                Console.WriteLine(kymmenen);
            }
            else if (numero < 1000) // jos syötetty luku on alle 1000, sadat-metodi käynnistyy
            {
                string sata;
                sata = sadat(numero);
                Console.WriteLine(sata);
            }

            static string ykkoset(int number) // ykkoset-metodi, jolla argumenttina kokonaisluku, jonka käyttäjä syöttää
            {
                switch (number)
                {
                    case 1:
                        return "Yksi";
                        break;
                    case 2:
                        return "Kaksi";
                        break;
                    case 3:
                        return "Kolme";
                        break;
                    case 4:
                        return "Neljä";
                        break;
                    case 5:
                        return "Viisi";
                        break;
                    case 6:
                        return "Kuusi";
                        break;
                    case 7:
                        return "Seitsemän";
                        break;
                    case 8:
                        return "Kahdeksan";
                        break;
                    case 9:
                        return "Yhdeksän";
                        break;
                    default:
                        return "Puppua";
                        break;
                }
            }//ykkoset loppu

            static string poikkeuskymmenet(int number)// poikkeuskymmenet-metodi
            {
                switch (number)
                {
                    case 10:
                        return "Kymmenen";
                        break;
                    case 11:
                        return "Yksitoista";
                        break;
                    case 12:
                        return "Kaksitoista";
                        break;
                    case 13:
                        return "Kolmetoista";
                        break;
                    case 14:
                        return "Neljätoista";
                        break;
                    case 15:
                        return "Viisitoista";
                        break;
                    case 16:
                        return "Kuusitoista";
                        break;
                    case 17:
                        return "Seitsemäntoista";
                        break;
                    case 18:
                        return "Kahdeksantoista";
                        break;
                    case 19:
                        return "Yhdeksäntoista";
                        break;
                    default:
                        return "Huttua";
                        break;
                }
            }//poikkeuskymmenet loppu

            static string kymmenet(int number)// kymmenet-metodi
            {
                string x = Convert.ToString(number); // käännetään kokonaisluku string-muotoon
                string eka = x.Substring(0, 1); // string eka:lle annetaan arvoksi kokonaisluvun ensimmäinen luku
                string toka = x.Substring(1, 1); // string toka:lle annetaan arvoksi kokonaisluvun nollas luku
                number = Int32.Parse(eka); // parsitaan muuttuja eka takaisin kokonaisluvuksi ja siirretään se number-muuttujalle
                int toinen = Int32.Parse(toka); // kokonaislukumuuttuja toinen:lle parsitaan toka-muuttuja arvoksi
                string y = ykkoset(toinen); // string y kutsuu ykkoset-muuttujaa, jonka argumenttina on kokonaislukumuuttuja toinen

                switch (number)
                {
                    case 2:
                        return "Kaksikymmentä " + y;
                        break;
                    case 3:
                        return "Kolmekymmentä " + y;
                        break;
                    case 4:
                        return "Neljäkymmentä " + y;
                        break;
                    case 5:
                        return "Viisikymmentä " + y;
                        break;
                    case 6:
                        return "Kuusikymmentä " + y;
                        break;
                    case 7:
                        return "Seitsemänkymmentä " + y;
                        break;
                    case 8:
                        return "Kahdeksankymmentä " + y;
                        break;
                    case 9:
                        return "Yhdeksänkymmentä " + y;
                        break;
                    default:
                        return "Nuppua";
                        break;
                }

            }//kymmenet loppu

            static string sadat(int number) // sadat-metodi
            {

                string x = Convert.ToString(number); // käännetään kokonaisluku string-muotoon
                string eka = x.Substring(0, 1); // 
                string toka = x.Substring(1, 1);
                number = Int32.Parse(eka);
                int toinen = Int32.Parse(toka);
                string y = ykkoset(toinen);

                switch (number)
                {
                    case 1:
                        return "Sata ";
                        break;
                    case 2:
                        return y + " Sataa";
                        break;
                    default:
                        return "Puppua!";
                        break;
                }

            }
        }
    }
}