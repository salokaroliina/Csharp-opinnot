using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TulostaBT_Click(object sender, EventArgs e) // ohjelma käynnistyy nappia painamalla
        {
            string teksti = ViestiTB.Text; // haetaan string-muuttujaan 'teksti' teksti ViestiTB-textboxista
            TulostusLB.Text = teksti; // TulostusLB-labelin teksti muuttuu siksi, jonka käyttäjä on syöttänyt
            TulostusLB.Visible = true; // TulostusLB-labelin näkyvyys oli määritelty falseksi, joten muutetaan se takaisin trueksi
        }
    }
}
