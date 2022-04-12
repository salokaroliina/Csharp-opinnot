using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // otetaan käyttöön System.Data sekä MySql.Data.MySqlClient
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Eramake; // otetaan käyttöön Eramake-kirjasto, jota käytetään encryptaamisessa

namespace EncryptDecrypt
{
    public partial class EncryptDecrypt : Form
    {
        YHDISTA yhteys = new YHDISTA();
        public EncryptDecrypt()
        {
            InitializeComponent();
        }

        private void EncryptDecrypt_Load(object sender, EventArgs e)
        {
            
        }

        // CRYPTATAAN SALASANA
        private void CryptaaBT_Click(object sender, EventArgs e)
        {
            // haetaan salasana ja cryptataan se käyttäen Eramake-kirjastoa
            String salasana = eCryptography.Encrypt(SalasanaTB.Text);

            // uusi MySqlCommand "komento"
            MySqlCommand komento = new MySqlCommand();

            // käytetään SQL:ää tätä kautta
            // lisätään luotu salasana tietokantaan
            // VALUES eli arvot ilmaistaan @ssa
            String lisayskysely = "INSERT INTO salasana (salasana) VALUES (@ssa);";

            // annetaan käsky käyttää lisayskyselyä (ylempänä)
            komento.CommandText = lisayskysely;
            // annetaan käsky luoda yhteys ja käyttää otaYhteys()-metodia
            komento.Connection = yhteys.otaYhteys();

            // käskylle annettava tieto mitä tietokantaan lisätään
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salasana;
           

            /* avataan yhteys,
             paitsi jos yhteys on jo käynnissä, suljetaan se*/
            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                MessageBox.Show("Salasana cryptattu");
                SalasanaTB.Text = "";
                VastausLB.Text = "";
            }
            else
            {
                yhteys.suljeYhteys();
            }
            CryptattuCB.DataSource = haeSalasanat(salasana);
        }

        // HAETAAN TIEDOT SQL:STÄ COMBOBOXIIN
        public DataTable haeSalasanat(String salasana)
        {
            // uusi data-adapteri, joka hakee halutun asian (salasana) halutusta tietokannasta (salasana)
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT salasana FROM salasana", yhteys.otaYhteys());
            // uusi datatable
            DataTable dt = new DataTable();
            // adapteri täyttää datatablen
            da.Fill(dt);
            // comboboxin datasource tulee datatablesta
            CryptattuCB.DataSource = dt;
            // comboboxissa näkyy (cryptattu)salasana, ja sen value on myös salasana
            CryptattuCB.DisplayMember = "salasana";
            CryptattuCB.ValueMember = "salasana";

            // palautetaan metodille datatable
            return dt;
        }


        // DECRYPTATAAN SALASANA
        private void NaytaBT_Click(object sender, EventArgs e)
        {
            // decryptataan salasana
            String salasana = eCryptography.Decrypt(CryptattuCB.Text);
            // näytetään vastaus
            VastausLB.Text = "Vastaus: " + salasana;
            VastausLB.Visible = true;
        }

    
    }
}
