using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CRUD
{
    public partial class OpiskelijaRekisteri : Form
    {
        // määritetään muuttuja opiskelija käyttämään luokkaa OPISKELIJA
        OPISKELIJA opiskelija = new OPISKELIJA();

        public OpiskelijaRekisteri()
        {
            InitializeComponent();
        }
       
        // ohjelman latautuessa haetaan tiedot OPISKELIJA-luokasta käyttäen metodia haeOpiskelijat
        private void OpiskelijaRekisteri_Load(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
            TietotauluDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 125;
        }

        // tyhjennä-nappia painamalla tekstilaatikot tyhjentyvät
        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            IdTB.Text = "";
            EnimiTB.Text = "";
            SnimiTB.Text = "";
            PuhTB.Text = "";
            SpostiTB.Text = "";
            OnroTB.Text = "";
        }

        // tallenna nappia painamalla tiedot saadaan tallennettua
        private void TallennaBT_Click(object sender, EventArgs e)
        {   
            // luodaan tekstilaatikoista muuttujat
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String puhelin = PuhTB.Text;
            String sposti = SpostiTB.Text;
            int oNro = Int32.Parse(OnroTB.Text);

            // jos yksikään tekstilaatikoista on tyhjä, ohjelma herjaa asiasta
            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || sposti.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE! Vaaditut kentät - etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä Kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                // jos kaikki on OK, kutsutaan OPISKELIJA-luokasta lisaaOpiskelija-metodia, joka lisää tietokantaan halutut tiedot
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi,puhelin, sposti, oNro);

                // jos kaikki menee OK, ohjelma kertoo että opiskelija on lisätty onnistuneesti
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                // jos tapahtuu virhe, ohjelma herjaa asiasta
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // tietotaulu-datagrid saa tiedot OPISKELIJA-luokasta käyttämällä haeOpiskelijat()-metodia
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
            }
        }

        // päivitä-nappia painamalla voidaan päivittää jo olemassa olevia tietoja
        private void PaivitaBT_Click(object sender, EventArgs e)
        {
            // luodaan tekstilaatikoista muuttujat
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String puhelin = PuhTB.Text;
            String sposti = SpostiTB.Text;
            int oNro = Int32.Parse(OnroTB.Text);
            int oid = Int32.Parse(IdTB.Text);

            // jos yksikään kentistä on tyhjänä, ohjelma herjaa asiasta
            if(oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || sposti.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE! Vaaditut kentät - ID, etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä Kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                // muuttuja lisaaAsiakas käyttää OPISKELIJA-luokkaa ja muokkaaOpiskelijaa-metodia
                Boolean lisaaAsiakas = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, sposti, oNro);
                if (lisaaAsiakas)
                {
                    // jos kaikki menee OK, ohjelma kertoo että opiskelija on lisätty
                    MessageBox.Show("Opiskelija lisätty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // jos jotain menee pieleen, ohjelma herjaa siitä
                    MessageBox.Show("Opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        // poista-nappia painamalla voidaan opiskelijan käyttäjätunnus poistaa
        private void PoistaBT_Click(object sender, EventArgs e)
        {
            // käyttäjätunnus on opiskelija-ID
            String ktunnus = IdTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennaBT.PerformClick();
        }

        // taulukon solua klikatessa kyseisen rivin tiedot ilmestyvät tekstilaatikoihin
        private void TietotauluDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // korvataan tekstilaatikoiden sen hetkinen teksti valitun taulukkorivin tiedoilla
            IdTB.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();
            EnimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            SnimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            PuhTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            SpostiTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            OnroTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }

       
    }
}
