using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kahvila
{
    public partial class RuokalistaForm : Form
    {
        public RuokalistaForm()
        {
            InitializeComponent(); 
            MeistaPL.Visible = true; // ohjelman käynnistyessä MeistaLB on näkyvissä
            RuoatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void MeistaPL_Paint(object sender, PaintEventArgs e)
        {
            MeistaLB.Text = "Oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n" + // labelin teksti voidaan määritellä myös näin
            "9:00 - 14:30 joka päivä maanantaista torstaihin ja perjantaisin\n" +
            "9:00 - 12:30. " +
            "\n\nKeudan oppilaskunnan kahvilasta saa lämpimien\n" +
            "juomien lisäksi virvokkeita sekä pientä purtavaa sekä makeisia.\n" +
            "Tervetuloa tutustumaan!";
            MeistaLB.Font = new Font("Arial", 12);
        }

        private void MeistaBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = true; // nappia painamalla sivu "vaihtuu", eli vain valittu sivu on näkyvissä
            RuoatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }


        private void RuoatBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            RuoatPL.Visible = true;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void JuomatBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            RuoatPL.Visible = false;
            JuomatPL.Visible = true;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void HerkutBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            RuoatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = true;
            KoriPL.Visible = false;
        }

        private void KoriBt_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            RuoatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = true;
        }

        private void ExitBT_Click(object sender, EventArgs e)
        {
            Application.Exit(); // nappia painamalla ohjelma sulkeutuu
        }

        
    }
}
