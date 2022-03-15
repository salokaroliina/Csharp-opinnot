using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukujenJarjestys
{
    public partial class LukujenJarjestys : Form
    {
        
        List<int>jono = new List<int>(); // luodaan uusi int-lista 'jono', johon syötetyt luvut kerätään
        public LukujenJarjestys()
        {
            InitializeComponent();
        }
        
        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e) // ohjelma käynnistyy enterin painalluksella
        {

            if (e.KeyChar == (char)Keys.Enter) // jos painettu näppäin on enter, ohjelma tarkistaa mitä on syötetty
            {
            
                if (uusiLukuTB.Text == "-999") // jos syötetty teksti on -999, ohjelma järjestää syötetyt luvut järjestykseen 
                {
                    VastausLB.Text = ""; // vastausLB:n alkuperäinen teksti tyhjenee (vastausLB on piilotettu oletuksena)
                    int[] taulukko = jono.ToArray(); // luodaan uusi taulukko jono-muuttujasta (määritelty aivan ensimmäisenä)
                    Array.Sort(taulukko); // järjestetään taulukko
                    foreach(var jasen in taulukko) // haetaan jokainen muuttuja taulukosta (jasen in taulukko)
                    {
                        VastausLB.Text += jasen + " "; // VastausLB:n teksti näyttää syötetyt luvut järjestyksessä, välilyönti kaikkien lukujen välissä
                    }
                    VastausLB.Visible = true; // muutetaan VastausLB näkyväksi
                }
            
                else // jos syötetään muu luku kuin -999, lisätään jono-listaan syötetty luku
                {
                
                    try // testataan onko luku kokonaisluku 
                    {
                        jono.Add(Int32.Parse(uusiLukuTB.Text)); // testataan, voidaanko luku parsia kokonaisluvuksi ja lisätä jonoon
                    }
                    catch
                    {
                        MessageBox.Show("Anna luku oikeassa muodossa"); // mikäli luku on väärässä muodossa, ohjelma ilmoittaa siitä
                        
                    }
                    uusiLukuTB.Text = ""; // tyhjennetään syöttöalue jokaisen enter-painalluksen jälkeen
                }
            }
                
            if (e.KeyChar == (char)Keys.Escape) // jos painettu näppäin on Escape(esc), lomake tyhjenee
            {
                TyhjaaLomake(); // kutsutaan TyhjaaLomake() -metodia
            }
        }


        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = ""; // tyhjennetään syöttöalue
        }
    }
}
