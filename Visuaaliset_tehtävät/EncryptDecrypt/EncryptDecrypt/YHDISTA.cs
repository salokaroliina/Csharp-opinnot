using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // otetaan käyttöön System.Data sekä MySql.Data.MySqlClient
using MySql.Data.MySqlClient;
using System.Windows.Forms;



// tämän luokan avulla luodaan yhteys tietokantaan
namespace EncryptDecrypt
{
    class YHDISTA
    {

        public string yhteyslause()
        {
            /* palautetaan yhteyslause-metodille datasource, eli minkä tyyppinen datasource on, mistä portista ohjelma pääsee sisään, 
             mikä on käyttäjätunnus ja salasana ja mistä tietokannasta haetaan tiedoa */
            return "datasource = localhost; port = 3306; username = root; password =; database = salasana";
        }

        private MySqlConnection yhteys = new MySqlConnection("datasource = localhost; port = 3306; username = root; password =; database = salasana");

        // metodi, jolla luodaan yhteys tietokantaan 
        public MySqlConnection otaYhteys()
        {
            // palauttaa metodille yhteys-muuttujan, johon on tallennettu yhteyden ottaminen ja tiedot yhteydestä
            // = datasource, portti, käyttäjä, salasana ja database
            return yhteys;
        }

        // metodi yhteyden avaamiselle, käytetään System.Data-kirjastoa
        public void avaaYhteys()
        {
            yhteys.Open();
        }

        // metodi yhteyden sulkemiselle, käytetään System.Data-kirjastoa
        public void suljeYhteys()
        {
            // jos yhteyden tila on auki, suljetaan yhteys
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
