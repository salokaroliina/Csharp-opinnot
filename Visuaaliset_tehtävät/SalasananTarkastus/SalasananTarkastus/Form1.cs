using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalasananTarkastus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Jyri" && SalasanaTB.Text == "Ja@kk0Ku1ta") // tarkistetaan, onko molemmat KayttajaTB:n ja SalasanaTB:n teksti oikein
            {
                SalasanaPanel.Visible = false; // mikäli kaikki on oikein, paneelin, jossa tietoja kysyttiin, visibility muuttuu falseksi
                SalasanaOikeinPanel.Visible = true; // aiemmin piilossa olleen paneelin visibility muuttuu trueksi
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!"; // jos tiedot eivät ole oikein, tulee näkyviin virheviesti
                VirheviestiLB.Visible = true;
            }
        }
    }
}
