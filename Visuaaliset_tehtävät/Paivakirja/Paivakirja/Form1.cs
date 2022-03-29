using System;
using System.IO; // otetaan käyttöön System IO, jotta voidaan kirjoittaa ja tallentaa tiedostoon
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Paivakirja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\Users\\salok\\OneDrive\\Desktop\\demo.txt"); // luetaan txt-tiedosto
            paivyriTB.Text = teksti;
        }

        private void lisaaBT_Click(object sender, EventArgs e)
        {
            string teksti = ""; // teksti on tyhjä kunnes siihen kirjoitetaan jotain
            teksti += paivyriTB.Text; // lisätään teksti päiväkirjaan
            teksti += " " + DateTime.Now.ToString("dd.MM.yyy HH:mm") + "\n"; // lisätään tekstin perään päivämäärä ja kellonaika, sekä uusi rivi
            TextWriter text = new StreamWriter("C:\\Users\\salok\\OneDrive\\Desktop\\demo.txt"); // tallennetaan tiedosto haluttuun paikkaan
            text.Write(teksti); // kirjoitetaan teksti
            text.Close(); // suljetaan teksi ja ohjelma
            Application.Exit();
        }
    }
}
