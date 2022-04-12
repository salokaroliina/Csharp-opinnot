using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // otetaan käyttöön System.Data sekä MySql.Data.MySqlClient
using MySql.Data.MySqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;



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
            String ktunnus = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 4).ToLower();
            String salis = salasana();
            String salattu = Encrypt(salis);

            // uusi MySqlCommand "komento"
            MySqlCommand komento = new MySqlCommand();
            
            // käytetään SQL:ää tätä kautta
            // lisätään halutut tiedot yhteystiedot-taulukkoon
            // VALUES eli arvot ilmaistaan @nimi
            String lisayskysely = "INSERT INTO yhteystiedot " + 
                "(etunimi,sukunimi,puhelin,sahkoposti,opiskelijanumero,ktunnus, salasana) " +
                "VALUES (@enm, @snm, @puh, @eml, @ono, @usr, @ssa);";
            
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
            komento.Parameters.Add("@usr", MySqlDbType.VarChar).Value = ktunnus;
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salattu;
            MessageBox.Show("Käyttäjätunnuksesi on " + ktunnus + "\nSalasanasi on " + salis + "\nSalattuna se on" + salattu + "\nkirjoita nämä visusti talteen");

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
            MySqlCommand komento = new MySqlCommand("SELECT oid, etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero, ktunnus, salasana FROM yhteystiedot", yhteys.otaYhteys());

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

            // cryptattu salasana, löytyy SQL:stä
            String salattu = "Avj5YglX899hY7yPKt5mXLAStGaNCOyU2hNOfTTfMJI=";
            // decryptataan salasana
            String salasana = Decrypt(salattu);
            // näytetään salasana
            MessageBox.Show(salasana);
   
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

        public String salasana()
        {
            char[] merkkijono = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            String ssana = "";
            Random r = new Random();
            for(int i = 0; i < 15; i++)
            {
                int rInt = r.Next(0, 61);
                ssana += merkkijono[rInt];
            }
            return ssana;
        }

        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";

            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);

            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });

                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";

            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });

                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}
