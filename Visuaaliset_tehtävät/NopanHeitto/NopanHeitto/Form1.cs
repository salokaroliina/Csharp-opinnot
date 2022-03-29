using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NopanHeitto
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

        private void HeitaBT_Click(object sender, EventArgs e)
        {
            PiirraNoppa(Noppa01PB); // napin painalluksella kutsutaan PiirraNoppa-metodia kahdesti
            PiirraNoppa(Noppa02PB); // koska metodi ei voi kutsua molempia samaan aikaan, Noppa01 ja Noppa02 muutetaan väliaikaisesti NoppaBox
                                    // nimiseksi muuttujaksi, jota metodi käyttää
        }
        private void PiirraNoppa(PictureBox NoppaBox) // PiirraNoppa-metodi antaa satunnaisen luvun, jonka perusteella se näyttää uuden kuvan
        {
            Random satunnainen = new Random(); // luodaan uusi Random-muuttuja
            int noppa = satunnainen.Next(1,7); // annetaan noppa-muuttujalle arvoksi juuri luotu random-luku, 1-7

            switch (noppa) // switch-case joka käy annetut satunnaisluvut läpi ja antaa sen mukaan uuden kuvan nopalle
            {
                case 1:
                    NoppaBox.Image = Properties.Resources.dice01; // muutetaan NoppaBoxin kuvaa vastaamaan saatua satunnaislukua
                    break;
                case 2:
                    NoppaBox.Image = Properties.Resources.dice02;
                    break;
                case 3:
                    NoppaBox.Image = Properties.Resources.dice03;
                    break;
                case 4:
                    NoppaBox.Image = Properties.Resources.dice04;
                    break;
                case 5:
                    NoppaBox.Image = Properties.Resources.dice05;
                    break;
                case 6:
                    NoppaBox.Image = Properties.Resources.dice06;
                    break;
            }
        }
    }
}
