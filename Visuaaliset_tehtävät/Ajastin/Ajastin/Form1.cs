using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics; // otetaan käyttöön System Diagnostics, jotta ajastinta voidaan käyttää

namespace Ajastin
{
    public partial class LaskuriForm : Form
    {
        public LaskuriForm()
        {
            InitializeComponent();
        }

        private int aika;

        // HUOMIO ITSELLE: DESIGN PUOLELLA TIMER INTERVAL MUUTETTU 1000, JOKA VASTAA OIKEAA SEKUNTIA
        private void LaskuriForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false; // stop-buttonia ei voi alussa käyttää
            for (int i = 0; i < 62; i++) // luodaan ajastimeen valittavat numerot for-loopin avulla (60)
            {
                MinuutitCB.Items.Add(i.ToString()); // lisätään loopista saadut luvut MinuutitCB:hen
                SekunnitCB.Items.Add(i.ToString()); // lisätään loopista saadut luvut SekunntiCB:hen
            }
            MinuutitCB.SelectedIndex = 10; // määritellään oletusluku minuuteille
            SekunnitCB.SelectedIndex = 0; // määritellään oletusluku sekunneille
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false; // start-buttonia ei voida käyttää kun ajastin on käynnissä
            StopBT.Enabled = true;  // stop-button palautuu käyttöön
            int minuutit = int.Parse(MinuutitCB.SelectedItem.ToString()); // parsitaan käyttäjän antamat minuutit int-muotoon
            int sekunnit = int.Parse(SekunnitCB.SelectedItem.ToString()); // parsitaan käyttäjän antamat sekunnit int-muotoon
            aika = (minuutit * 60) + sekunnit;
            LaskuriTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true; // start-button palautuu käyttöön ohjelman pysähdyttyä
            StopBT.Enabled = false; // stop-button poistuu käytöstä ohjelman pysähdyttyä
            aika = 0; // nollataan aika
            LaskuriTM.Enabled = false; // ajastin poistuu käytöstä
            AikaLB.Text = "00:00"; // tyhjennetään näytettävä aika
        }

        private void LaskuriTM_Tick(object sender, EventArgs e)
        {
            if(aika > 0) // jos aika on enemmän kuin 0, aika pienenee kunnes se pääsee 0:aan
            {
                aika--;
                int minuutit = aika / 60;
                int sekunnit = aika - (minuutit * 60);
                AikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString(); // AikaLB näyttää kuluvan ajan
            }
            else
            {
                LaskuriTM.Stop(); // jos ohjelma pääsee loppuun, laskuri pysähtyy
                
            }
        }
    }
}
