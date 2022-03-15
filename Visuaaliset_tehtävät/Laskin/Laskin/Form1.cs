using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e) // ohjelma käynnistyy nappia painamalla
        {
        
            float luku1 = float.Parse(LukuYksiTB.Text); // muutetaan ensimmäisen textboxin tekstisisältö float-luvuksi
            float luku2 = float.Parse(LukuKaksiTB.Text); // tehdään sama toisen textboxin sisällölle
            float vastaus = 0; // vastaus on oletusarvoisesti 0
            string merkki = LaskutoimitusCB.Text; // merkki on pudotusvalikosta tullut matemaattinen merkki
       
            switch (merkki) // switch-case merkki-muuttujalla
            {
                case "+": // jos käyttäjän valinta on plus, vastaus on annettu luku + annettu luku
                    vastaus = luku1 + luku2;
                    break;
                case "-": // jos käyttäjän valinta on miinus, valinta on annettu luku - annettu luku
                    vastaus = luku1 - luku2;
                    break;
                case "*": // kertolasku
                    vastaus = luku1 * luku2;
                    break;
                case "/": // jakolasku
                    vastaus = luku1 / luku2;
                    break;
                default: // jos mikään ylläoleva ei sovi, vastaus on 0
                    vastaus = 0;
                    break;
                
            }
            VastausLB.Text = Convert.ToString(vastaus); // vastausLB-labelin teksti on saatu vastaus muutettuna stringiksi
            VastausLB.Visible = true; // muutetaan VastausLB näkyväksi
        }
    }
}
