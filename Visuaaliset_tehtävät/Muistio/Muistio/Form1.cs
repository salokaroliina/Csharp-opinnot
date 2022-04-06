using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // otetaan käyttöön System.IO

namespace Muistio
{
    public partial class MuistioForm : Form
    {
        string tiedostopolku = ""; // määritellään tiedostopoluksi tyhjä
        public MuistioForm()
        {
            InitializeComponent();
        }

        // TIEDOSTO-VALIKKO

        // UUSI
        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(TekstiRTB.Text != "")  // jos tekstikenttä ei ole tyhjä, kun uusi-painiketta on painettu, kutsutaan tallenna-metodia
            {
                tallennaToolStripMenuItem_Click(sender, e);
                TekstiRTB.Text = "";
            }
            else
            {
                TekstiRTB.Text = ""; // jos tekstikentässä ei ole mitään, ei tapahdu mitään
            }
        }

        // AVAA
        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog() // käytetään OpenFileDialog-työkalua (design)
            { Filter = "TextDocument|*.Rtf", ValidateNames = true, Multiselect = false}) // avattava tiedosto voi olla vain rtf-muotoinen
                                                                                         // monivalinta ei ole käytössä
            {
                if(atk.ShowDialog() == DialogResult.OK) // jos avaaminen onnistuu, tekstiruudulle tulee tiedostossa ollut teksti
                {
                    using (StreamReader jonolukija = new StreamReader(atk.FileName))
                    {
                        tiedostopolku = atk.FileName;
                        Task<string> text = jonolukija.ReadToEndAsync();
                        TekstiRTB.Rtf = text.Result;
                    }
                }
            }
        }

        // TALLENNA
        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if(string.IsNullOrEmpty(tiedostopolku)) // jos tiedostolla ei vielä ole nimeä, edetään tallentamaan ja antamaan tiedostolle nimi
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                {
                    Filter = "Rich Text Format|*.rtf", // tallennus tapahtuu rtf-muodossa
                    ValidateNames = true
                })
                {
                    if(ttk.ShowDialog() == DialogResult.OK)
                    {
                        using(StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName)) // käytetään StremWriter-työkalua (design)
                        {
                            jonokirjoittaja.WriteLineAsync(TekstiRTB.Rtf);
                        }
                    }
                }
            }
        }

        // TALLENNA NIMELLÄ
        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog ttk = new SaveFileDialog() // käytetään SaveFileDialog-työkalua (design)
            {
                Filter = "Rich Text Format|*.rtf", ValidateNames = true
            })
                if(ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName)) // käytetään StremWriter-työkalua (design)
                    {
                        jonokirjoittaja.WriteLineAsync(TekstiRTB.Rtf);
                    }
                }
        }

        // TULOSTUKSEN ESIKATSELU
        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1; // käytetään printPreviewDialog-työkalua (design)
            printPreviewDialog1.ShowDialog();
        }

        // TULOSTA
        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1; // käytetään printPreviewDialog-työkalua (design)
            if (printDialog1.ShowDialog() == DialogResult.OK) // jos kaikki on ok, dokumentti tulostetaan
            {
                printDocument1.Print();
            }
        }

        // POISTU
        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TekstiRTB.Text, TekstiRTB.Font, Brushes.Black, 12, 10); // määritellään miten teksti tulostetaan;
                                                                                          // mistä tulostetaan (tekstialue), fontti, väri
                                                                                          // sekä tekstin alun sijainti
        }


        //MUOKKAA-VALIKKO

        // UNDO
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.Undo();
        }

        // REDO
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.Redo();
        }

        // KOPIOI
        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.Copy();
        }

        // LEIKKAA
        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.Cut();
        }

        // LIITÄ
        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.Paste();
        }

        // POISTA
        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.SelectedText = "";
        }

        // VALITSE KAIKKI
        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.SelectAll();
        }
        

        private void TekstiRTB_TextChanged(object sender, EventArgs e)
        {
            if(TekstiRTB.Text.Length > 0) // jos tekstikentässä on tekstiä, kopioi- ja leikkaa-työkalut ovat käytössä
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false; // jos tekstikentässä ei ole tekstiä, kyseiset työkalut eivät ole käytössä
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }

        // MUOTOILE-VALIKKO
        
        // TEKSTIN RIVITYS
        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinKorostusToolStripMenuItem.Checked == true) // jos tekstin korostus on valittuna, tekstin rivitystä ei voi valita samalla
            {
                tekstinRivitysToolStripMenuItem.Checked = false;
                TekstiRTB.WordWrap = false;
            }
            else
            {
                tekstinRivitysToolStripMenuItem.Checked = true;
                TekstiRTB.WordWrap = true;
            }
        }

        // KIRJASIN
        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog(); // käytetään ShowDialog-työkalua (design)
            TekstiRTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style); // valitaan fontti, koko ja tyyli
        }

        // TEKSTIN KOROSTUS
        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.SelectionBackColor = Color.Yellow; // määritellään korostusväri
        }

        private void tietoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tietoa tietoa = new tietoa(); // avataan tietoa-ikkuna
            tietoa.ShowDialog();
        }
    }
}
