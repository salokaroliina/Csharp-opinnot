using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lukujenJarjestys
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();
        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e) // ohjelma käynnistyy enterin painalluksella
        {
            if(e.KeyChar == (char)Keys.Enter) 
            {
                try // testataan, voidaanko annettu luku muuttaa int-luvuksi ja voidaanko se lisätä jonoon
                {
                    Int32.Parse(uusiLukuTB.Text);
                    if(uusiLukuTB.Text == "-999") // jos annettu luku on -999, ohjelma pysähtyy ja järjestää taulukon suuruusjärjestykseen
                    {
                        uusiLukuTB.Text = ""; // tyhjennetään textbox
                        int[] taulukko = jono.ToArray(); // muutetaan jono taulukkomuotoon
                        Array.Sort(taulukko); // järjestetään taulukko
                        foreach(var jasen in taulukko) // tehdään samat asiat jokaiselle taulukon jäsenelle
                        {
                            VastausLB.Text += jasen + " "; // ohjelma näyttää luvut suuruusjärjestyksessä, välilyönti jokaisen luvun välissä
                        }
                        VastausLB.Visible = true; // muutetaan vastaus näkyväksi
                    }
                    else
                    {
                        VastausLB.Text = ""; // jos ohjelmaa ei olla pysäytetty, uusia lukuja voidaan syöttää
                        VastausLB.Visible = false; 
                        jono.Add(Int32.Parse(uusiLukuTB.Text)); // lisätään jokainen uusi luku jonoon
                        uusiLukuTB.Text = "";
                    }
                            
                }
                catch // jos käyttäjä tekee jonkin virheen, ohjelma kertoo siitä
                {
                    VastausLB.Text = "Virhe!";
                    VastausLB.Visible = true;
                    VastausLB.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
