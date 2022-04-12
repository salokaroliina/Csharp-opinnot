using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // otetaan käyttöön System.Data sekä MySql.Data.MySqlClient
using MySql.Data.MySqlClient;

namespace CRUD
{
    class OPISKELIJA
    {
        // käytetään YHDISTA-luokkaa ja luodaan uusi muuttuja
        YHDISTA yhteys = new YHDISTA();

        // metodi, jolla lisätään opiskelija tietokantaan
        // metodin argumentteina oppilaan tiedot, jotka tietokantaan ollaan lisäämässä
        public bool lisaaOpiskelija(String enimi, String snimi, String puh, String email, int onro)
        {
            // uusi MySqlCommand "komento"
            MySqlCommand komento = new MySqlCommand();
            
            // käytetään SQL:ää tätä kautta
            // lisätään halutut tiedot yhteystiedot-taulukkoon
            // VALUES eli arvot ilmaistaan @nimi
            String lisayskysely = "INSERT INTO yhteystiedot " + 
                "(etunimi,sukunimi,puhelin,sahkoposti,opiskelijanumero) " +
                "VALUES (@enm, @snm, @puh, @eml, @ono);";
            
            // annetaan käsky käyttää lisayskyselyä (ylempänä)
            komento.CommandText = lisayskysely;
            // annetaan käsky luoda yhteys ja käyttää otaYhteys()-metodia
            komento.Connection = yhteys.otaYhteys();
            
            // käskylle annettavat tiedot, jotka se lisää tietokantaan
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;

            /* avataan yhteys
             paitsi jos yhteys on jo käynnissä, suljetaan se*/
            yhteys.avaaYhteys();
            if(komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        public DataTable haeOpiskelijat()
        {
            // luodaan komento hakea halutut tiedot tietokannasta
            MySqlCommand komento = new MySqlCommand("SELECT oid, etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero FROM yhteystiedot", yhteys.otaYhteys());

            // DataAdapterin tehtävä on täyttää taulukko
            MySqlDataAdapter adapteri = new MySqlDataAdapter();

            // luodaan uusi DataTable "taulu", joka näyttää taulukon valitut tiedot
            DataTable taulu = new DataTable();

            // annetaan käsky täyttää taulu eli näyttää tiedot
            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        // metodi jolla voidaan muokata opiskelijan tietoja
        // metodille annetaan argumenteiksi tiedot joita halutaan voida muokata
        public bool muokkaaOpiskelijaa(int oid, String enimi, String snimi, String puh, String email, int onro)
        {   
            // luodaan uusi komento
            MySqlCommand komento = new MySqlCommand();

            // muuttuja paivityskysely päivittää SQL:ssä halutut tiedot käyttäen oid:ta (opiskelija-id) avainkenttänä
            String paivityskysely = "UPDATE yhteystiedot SET Etunimi = @enm," +
                "Sukunimi = @snm, puhelin = @puh, sahkoposti = @eml, opiskelijanumero = @ono WHERE oid = @oid";

            // annetaan käsky käyttää muuttujaa paivityskysely
            komento.CommandText = paivityskysely;
            // annetaan komento ottaa yhteys tietokantaan
            komento.Connection = yhteys.otaYhteys();

            // annetaan päivitettävät tiedot
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;
            komento.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oid;

            // avataan ja suljetaan yhteys tietokantaan
            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        // metodi jolla poistetaan opiskelija tietokannasta (poistetaan käyttäjätunnus)
        public bool poistaOpiskelija(String ktunnus)
        {
            // luodaan uusi komento
            MySqlCommand komento = new MySqlCommand();
            // muuttuja poistokysely poistaa halutut tiedot tietokannasta, tällä kertaa käyttäjätunnuksen jolloin kaikki henkilön tiedot poistuvat
            String poistokysely = "DELETE FROM yhteystiedot WHERE oid = @ktu";
            // annetaan käsky suorittaa poisto
            komento.CommandText = poistokysely;
            // annetaan käsky ottaa yhteys tietokantaan
            komento.Connection = yhteys.otaYhteys();

            // kerrotaan komennolle mikä tieto on kyseessä
            komento.Parameters.Add("@ktu", MySqlDbType.UInt32).Value = ktunnus;

            // avataan ja suljetaan yhteys tietokantaan
            yhteys.avaaYhteys();
            if(komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
    }
}
