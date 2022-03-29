using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kysymyksia
{
    public partial class Form1 : Form
    {
        string[] vastaukset = new string[11]; // määritellään tulevan taulukon pituus valmiiksi
        string[] oikeat = new string[] {"","B","D","A","A","C","A","B","A","C","D"}; // määritellään oikeat vastaukset
        int laskuri = 1; // laskuri aloittaa ykkösestä, jotta se ottaa mukaan myös ensimmäisen kysymyksen
        int oikein = 0; // oikeita vastauksia on vielä 0

        public Form1()
        {
            InitializeComponent();
            ARB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged); // kun radiobutton valitaan, se kutsuu metodia
            BRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            CRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            DRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
        }

        private void radiobutton_CheckedChanged(object sender, EventArgs e) // radiobuttonin valinta kutsuu metodia
        {
            if(sender is RadioButton && laskuri <= 10) // jos valittuna on radiobutton ja laskuri on 10 tai alle,
                                                       // ohjelma siirtyy seuraavaan kysymykseen kirjattuaan laskuriin yhden lisää
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                KysymysLB.Text = "Vastaus " + (laskuri) + ". kysymykseen:"; // ohjelmassa kysymyksen numero muuttuu laskurin mukaan
                laskuri++;
            }
            else
            {
                VastausLB.Text = ""; // vastausLB:n teksti pysyy vielä tyhjänä
                ARB.Enabled = false; // buttonit poistuvat käytöstä
                BRB.Enabled = false;
                CRB.Enabled = false;
                DRB.Enabled = false;

                for (int i = 0; i <= 10; i++) // käydään läpi kaikki kysymykset (10)
                {
                    if(vastaukset[i] == oikeat[i]) // jos annettu vastaus on sama kuin oikea vastaus, käyttäjä saa pisteen
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein; // kun kaikki vastaukset on käyty läpi,
                                                                      // ohjelma näyttää kuinka monta vastausta oli oikein
                VastausLB.Visible = true; // tuodaan vastausLB näkyviin
            }
            TyhjaaVastaus(); // vastausten välillä tyhjennetään buttonit
        }

        private void TyhjaaVastaus()
        {
            if(ARB.Checked == true) // jos button on valittu, muutetaan checked-tila falseksi
            {
                ARB.Checked = false;
                laskuri--; 
            }
            if(BRB.Checked == true)
            {
                BRB.Checked = false;
                laskuri--;
            }
            if(CRB.Checked == true)
            {
                CRB.Checked = false;
                laskuri--;
            }
            if(DRB.Checked == true)
            {
                DRB.Checked = false;
                laskuri--;
            }
        }

        private void KysymysLB_Click(object sender, EventArgs e)
        {

        }
    }
}
