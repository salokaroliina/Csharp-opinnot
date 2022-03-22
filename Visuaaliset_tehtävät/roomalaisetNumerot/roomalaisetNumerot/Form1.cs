using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roomalaisetNumerot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void muutaBT_Click(object sender, EventArgs e)
        {
            int luku1, luku2, luku3, luku4; // int-muuttujat jokaiselle lukutyypille
            string roomaLuku = ""; // roomaLuku näyttää muunnetun luvun roomalaisina numeroina
            
            // tuhatluku
            if(lukuTB.Text.Length > 3) // jos syötetyn tekstin pituus on enemmän kuin 3, kyseessä on tuhatluku
            {
            luku1 = Convert.ToInt32(lukuTB.Text.Substring(0,1)); // tuhannet. otetaan syötetystä luvusta substring, nollannes on tuhansille
            luku2 = Convert.ToInt32(lukuTB.Text.Substring(1,1)); // sadat. otetaan syötetystä luvusta substring, ensimmäinen on sadoille
            luku3 = Convert.ToInt32(lukuTB.Text.Substring(2,1)); // kymmenet. otetaan syötetystä luvusta substring, toinen on kymmenille
            luku4 = Convert.ToInt32(lukuTB.Text.Substring(3,1)); // ykköset. otetaan syötetystä luvusta substring, kolmas on ykkösille
                // muistio itselle: substring = monesko, monennesta(mistä)
                if (luku1 % 3 == 0) // jos jakojäännös kolmella tuhannesta on 0, vastaukseksi saadaan "MMM"
                {
                    roomaLuku += "MMM";
                }
                else if(luku1 % 2 == 0) // jos jakojäännös kahdella tuhannesta on 0, vastaukseksi saadaan "MM", jne.
                {
                    roomaLuku += "MM";
                }
                else if(luku1 % 1 == 0)
                {
                    roomaLuku += "M";
                }
                else
                {
                    roomaLuku += "";
                }
                roomaLuku += sadat(luku2, roomaLuku); // kutsutaan metodia sadat, joka antaa vastauksen sataluvuille
                roomaLuku += kymmenet(luku3, roomaLuku); // kutsutaan metodia kymmenet, joka antaa vastauksen kymmenluvuille
                roomaLuku += ykkoset(luku4, roomaLuku); // kutsutaan metodia ykkoset, joka antaa vastauksen ykkösluvuille
            }

            // sataluku
            else if (lukuTB.Text.Length > 2) //jos syötetyn tekstin pituus on enemmän kuin 2, kyseessä on sataluku
            {
                luku2 = Convert.ToInt32(lukuTB.Text.Substring(0, 1)); // sadat
                luku3 = Convert.ToInt32(lukuTB.Text.Substring(1, 1)); // kymmenet
                luku4 = Convert.ToInt32(lukuTB.Text.Substring(2, 1)); // ykköset
                roomaLuku += sadat(luku2, roomaLuku);
                roomaLuku += kymmenet(luku3, roomaLuku);
                roomaLuku += ykkoset(luku4, roomaLuku);
            }

            // kymmenluku
            else if(lukuTB.Text.Length > 1) // jos syötetyn tekstin pituus on enemmän kuin 1, kyseessä on kymmenluku
            {
                luku3 = Convert.ToInt32(lukuTB.Text.Substring(0, 1)); // kymmenet
                luku4 = Convert.ToInt32(lukuTB.Text.Substring(1, 1)); // ykköset
                roomaLuku += kymmenet(luku3, roomaLuku);
                roomaLuku += ykkoset(luku4, roomaLuku);
            }
            
            // ykkösluku
            else if(lukuTB.Text.Length > 0) // jos syötetyn tekstin pituus on enemmän kuin 0, kyseessä on ykkösluku
            {
                luku4 = Convert.ToInt32(lukuTB.Text.Substring(0, 1)); // ykköset
                roomaLuku += ykkoset(luku4, roomaLuku);
            }
            tulosLB.Text = roomaLuku; // muutetaan tulosLB:n teksti saaduksi roomalaisluvuksi
            tulosLB.Visible = true; // muutetaan vastaus näkyväksi
        }
        private string sadat(int luku2, string roomaLuku) // metodi "sadat", jota on ylempänä kutsuttu
        {
            if (luku2 % 9 == 0 && luku2 != 0) // = luku 900
            {
                return "CM";
            }
            else if (luku2 % 8 == 0 && luku2 != 0) // = luku 800
            {
                return "DCCC";
            }
            else if (luku2 % 7 == 0 && luku2 != 0) // = luku 700
            {
                return "DCC";
            }
            else if(luku2 % 6 == 0 && luku2 != 0) // = luku 600
            {
                return "DC";
            }
            else if(luku2 % 5 == 0 && luku2 != 0) // = luku 500
            {
                return "D";
            }
            else if(luku2 % 4 == 0 && luku2 != 0) // = luku 400
            {
                return "CD";
            }
            else if(luku2 % 3 == 0 && luku2 != 0) // = luku 300
            {
                return "CCC";
            }    
            else if(luku2 % 2 == 0 && luku2 != 0) // = luku 200
            {
                return "CC";
            }    
            else if(luku2 % 1 == 0 && luku2 != 0) // = luku 100
            {
                return "C";
            }
            else
            {
                return ""; // = 0
            }
        }
        private string kymmenet(int luku3, string roomaLuku) // metodi "kymmenet", jota on ylempänä kutsuttu
        {
            if (luku3 % 9 == 0 && luku3 != 0) // = 90
            {
                return "XC";
            }
            else if (luku3 % 8 == 0 && luku3 != 0) // = 80
            {
                return "LCCC";
            }
            else if (luku3 % 7 == 0 && luku3 != 0) // = 70
            {
                return "LCC";
            }
            else if (luku3 % 6 == 0 && luku3 != 0) // = 60
            {
                return "LC";
            }
            else if (luku3 % 5 == 0 && luku3 != 0) // = 50
            {
                return "L";
            }
            else if (luku3 % 4 == 0 && luku3 != 0) // = 40
            {
                return "LX";
            }
            else if (luku3 % 3 == 0 && luku3 != 0) // = 30
            {
                return "XXX";
            }
            else if (luku3 % 2 == 0 && luku3 != 0) // = 20
            {
                return "XX";
            }
            else if (luku3 % 1 == 0 && luku3 != 0) // = 10
            {
                return "X";
            }
            else
            {
                return ""; // = 0
            }
        }
        private string ykkoset(int luku4, string roomaLuku) // metodi "kymmenet", jota on ylempänä kutsuttu
        {
            if (luku4 % 9 == 0 && luku4 != 0) // = 9
            {
                return "IX";
            }
            else if (luku4 % 8 == 0 && luku4 != 0) // = 8
            {
                return "VIII";
            }
            else if (luku4 % 7 == 0 && luku4 != 0) // = 7
            {
                return "VII";
            }
            else if (luku4 % 6 == 0 && luku4 != 0) // = 6
            {
                return "VI";
            }
            else if (luku4 % 5 == 0 && luku4 != 0) // = 5
            {
                return "V";
            }
            else if (luku4 % 4 == 0 && luku4 != 0) // = 4
            {
                return "IV";
            }
            else if (luku4 % 3 == 0 && luku4 != 0) // = 3
            {
                return "III";
            }
            else if (luku4 % 2 == 0 && luku4 != 0) // = 2
            {
                return "II";
            }
            else if (luku4 % 1 == 0 && luku4 != 0)// = 1
            {
                return "I";
            }
            else
            {
                return ""; // = 0
            }
        }
    }
}
