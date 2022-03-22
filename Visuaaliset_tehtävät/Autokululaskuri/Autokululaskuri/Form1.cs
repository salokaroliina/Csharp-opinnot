using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autokululaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, neste, vakuutus, muutKulut, bensa, pesut, huollot, renkaat, kilometrit, kustannukset; // double-muuttujat kaikille syötettäville tiedoille
            try // testataan, voidaanko annetut luvut muuttaa double-luvuiksi
            {
                laina = Convert.ToDouble(lainaTB.Text); // muunnetaan tekstinä syötetty tieto double-luvuksi
                neste = Convert.ToDouble(nesteTB.Text);
                vakuutus = Convert.ToDouble(vakuutusTB.Text);
                muutKulut = Convert.ToDouble(muutKulutTB.Text);
                bensa = Convert.ToDouble(bensaTB.Text);
                pesut = Convert.ToDouble(pesutTB.Text);
                huollot = Convert.ToDouble(huollotTB.Text);
                renkaat = Convert.ToDouble(renkaatTB.Text);
                kilometrit = Convert.ToDouble(KilometritCB.Text);
                kustannukset = (laina + neste + vakuutus + muutKulut + bensa + pesut + huollot + renkaat) / (kilometrit / 12); // lasketaan yhteen kulut

                kustannuksetLB.Text = "Kustannukset kilometria kohti ovat: " + Convert.ToString(kustannukset); // jaetaan kulut kuukausittaisella kilometrimäärällä 
                kustannuksetLB.Visible = true; // muutetaan tulos näkyväksi
            }
            catch // jos ilmenee virhe, ohjelma ilmoittaa siitä
            {
                kustannuksetLB.Text = "VIRHE!";
                kustannuksetLB.Visible = true;
            }


            
            
        }

    }
}
