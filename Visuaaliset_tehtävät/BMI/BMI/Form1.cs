using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0, bmi; // paino, pituus ja laskettava bmi ovat double-muuttujia
            paino = Convert.ToDouble(PainoTB.Text); // muunnetaan annettu luku double-luvuksi
            pituus = Convert.ToDouble(PituusTB.Text);
            bmi = Math.Round(paino / (pituus * pituus), 2); // lasketaan bmi kahden desimaalin tarkkuudella

            if (bmi < 18.5) // jos bmi on alle 18.5, ohjelma kertoo painoindeksin sekä millä mallilla paino on, sekä värjää sen siniseksi
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi + "\n" + "Alipaino"; // \n lisää uuden rivin
                VastausLB.ForeColor = Color.Blue;
                VastausLB.Visible = true;
            }
            else if(bmi < 25) // jos bmi on alle 25, ohjelma kertoo painoindeksin sekä millä mallilla paino on, sekä värjää sen punaiseksi
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi + "\n" + "Normaalipaino";
                VastausLB.ForeColor = Color.Green;
                VastausLB.Visible = true;
            }
            else if(bmi < 40)
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi + "\n" + "Ylipaino";
                VastausLB.ForeColor = Color.Orange;
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi + "\n" + "Huomattava ylipaino";
                VastausLB.ForeColor = Color.Red;
                VastausLB.Visible = true;
            }
        }

        private void PituusTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
