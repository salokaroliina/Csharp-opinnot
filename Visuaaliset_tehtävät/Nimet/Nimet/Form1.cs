using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Nimet
{
    public partial class Nimet : Form
    {
        public Nimet()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = ""; // VastausLB on tyhjä kunnes siihen kirjataan jotain
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Users\\salok\\source\\repos\\Csharp-opinnot\\pojat.txt"); // haetaan pojat-tiedosto
            string[] tytot = File.ReadAllLines("C:\\Users\\salok\\source\\repos\\Csharp-opinnot\\tytot.txt"); // haetaan tytot-tiedosto
            string nimi = NimiTB.Text; // haetaan annettu nimi
            int laskuriPojat = 1; // lähdetään laskemaan ykkösestä
            int laskuriTytot = 1;
            
            foreach(string poika in pojat) // käydään läpi kaikki taulukon osat
            {
                if(nimi == poika) // jos annettu nimi löytyy poika-taulukosta, ohjelma kertoo monesko nimi se on
                {
                    VastausLB.Text = "Nimesi on " + laskuriPojat + ". suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskuriPojat++; // laskuriin lisätään yksi kunnes löytyy yhteneväisyys
            }
            foreach (string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    VastausLB.Text = "Nimesi on " + laskuriTytot + ". suosituin tyttöjen nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskuriTytot++;
            }
            if(VastausLB.Visible == false) //jos vastausLB ei tule näkyviin, ohjelma kertoo ettei nimi ollut listalla
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta.";
                VastausLB.Visible = true;
            }

        }
    }
}
