using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iän_laskeminen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e) // ohjelma käynnistyy nappia painamalla
        {
            DateTime syntymapaiva = paivamaaraDTP.Value; // päivämäärät määritellään DateTime-muuttujalla
                                                         // syntymapaiva saa arvon käyttäjän syöttämästä päivämäärästä
            DateTime nyt = DateTime.Now; // muuttuja 'nyt' on jatkuvasti tämänhetkinen aika
            double erotus = Math.Round((nyt - syntymapaiva).TotalDays); // erotus on tämänhetkinen aika - syntymäpäivä pyöristettynä kokonaisiksi päiviksi
            VuodetLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta"; // vuodet lasketaan erotus (ylempänä) - vuosi (ml.karkausvuosi). Luku pyöristetään ylöspäin
            KuukaudetLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta"; // kuukaudet lasketaan erotus * kuukaudet / vuodella
            PaivatLB.Text = (erotus + " päivää"); // päivät ovat vain erotus, joka saatiin vähentämällä syntymäpäivä tämänhetkisestä ajasta
            TunnitLB.Text = (erotus * 24 + " tuntia"); // tunnit saadaan kertomalla erotus 24(tunnilla)
            MinuutitLB.Text = (erotus * 24 * 60 + " minuuttia"); // minuutit saadaan kertomalla erotus 24(t) ja 60(minuutilla)
            SekunnitLB.Text = (erotus * 24 * 3600 + " sekuntia"); // sekunnit saadaan kertomalla erotus 24(t), 60(m) ja 3600(sekunnilla)(tunnissa on 3600 sekuntia)
            VuodetLB.Visible = true; // muutetaan kaikki labelit näkyviksi
            KuukaudetLB.Visible = true;
            PaivatLB.Visible = true;
            TunnitLB.Visible = true;
            MinuutitLB.Visible = true;
            SekunnitLB.Visible = true;
        }
    }
}
