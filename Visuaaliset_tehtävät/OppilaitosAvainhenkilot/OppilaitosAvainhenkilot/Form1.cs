using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // HUOM!! threading tasks tarvitaan, jotta ohjelma toimii. Huomioi tämä kun valitset versiota jota käytät (4.7.2)
using System.Windows.Forms;

namespace OppilaitosAvainhenkilot
{
    public partial class AvainhenkilotForm : Form
    {
        DataTable oppilaitos = new DataTable(); // luodaan datatable oppilaitoksen tiedoille
        DataTable vastuuHenkilot = new DataTable(); // luodaan datatable vastuuhenkilöiden tiedoille
        DataTable yhteys = new DataTable(); // luodaan datatable kahden datatablen yhteyslinkiksi

        public AvainhenkilotForm()
        {
            InitializeComponent();
        }

        private void AvainhenkilotForm_Load(object sender, EventArgs e) // ohjelman latautuessa tapahtuu seuraavat asiat:
        {
            taytaOppilaitosTaulukko(); // täytetään oppilaitosten tiedot
            taytaVastuuhenkiloTaulukko(); // täytetään vastuuhenkilöiden tiedot
            OppilaitoksetCB.DataSource = oppilaitos; // oppilaitos-pudotusvalikko saa tietonsa oppilaitos-taulukosta
            OppilaitoksetCB.DisplayMember = "ONimi"; // oppilaitos-pudotusvalikossa näkyy oppilaitoksen nimi
        }

        private void OppilaitoksetCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string viite = oppilaitos.Rows[OppilaitoksetCB.SelectedIndex]["OID"].ToString(); // viitteenä taulukoiden välillä toimii OID eli oppilaitoksen ID
            OosoiteLB.Text = oppilaitos.Rows[OppilaitoksetCB.SelectedIndex]["OOsoite"].ToString(); // näkyviin tulevat tiedot haetaan taulukosta ja muutetaan string-muotoon
            OpostinumeroLB.Text = oppilaitos.Rows[OppilaitoksetCB.SelectedIndex]["OPostinumero"].ToString();
            OpostitoimipaikkaLB.Text = oppilaitos.Rows[OppilaitoksetCB.SelectedIndex]["OPostitoimipaikka"].ToString();
            OpuhelinLB.Text = oppilaitos.Rows[OppilaitoksetCB.SelectedIndex]["OPuhelin"].ToString();

            yhteys = vastuuHenkilot.Select("OID =" + viite).CopyToDataTable(); /* luodaan yhteys kahden taulukon välille 
                                                                                vastuuHenkilot-taulukon OID on sama kuin oppilaitos-taulukon OID
                                                                                tämä toimii linkkinä kahden taulukon välillä
                                                                                kopioidaan tiedot yhteys-taulukkoon OID:n perusteella
                                                                                */
                                                                               
            VastuuhenkiloCB.DataSource = yhteys; // vastuuhenkilö-pudotusvalikko saa tietonsa yhteys-taulukosta
            VastuuhenkiloCB.DisplayMember = "Vnimi"; // vastuuhenkilö-pudotusvalikossa näkyy vastuuhenkilön nimi
        }

            private void VastuuhenkiloCB_TextChanged(object sender, EventArgs e)
        {
            VtitteliLB.Text = yhteys.Rows[VastuuhenkiloCB.SelectedIndex]["Vtitteli"].ToString(); // näkyvät tiedot saavat tietonsa yhteys-taulukosta
            VosastoLB.Text = yhteys.Rows[VastuuhenkiloCB.SelectedIndex]["VOsasto"].ToString();
            VsahkopostiLB.Text = yhteys.Rows[VastuuhenkiloCB.SelectedIndex]["VSahkoposti"].ToString();
            VpuhelinLB.Text = yhteys.Rows[VastuuhenkiloCB.SelectedIndex]["VPuhelin"].ToString();
        }

        private void taytaOppilaitosTaulukko()
        {
            oppilaitos.Columns.Add("OID", typeof(int)); // yhteinen tekijä kahden taulukon välillä, muodossa int
            oppilaitos.Columns.Add("ONimi"); // luodaan sarakkeet oppilaitos-taulukkoon
            oppilaitos.Columns.Add("OOsoite");
            oppilaitos.Columns.Add("OPostinumero");
            oppilaitos.Columns.Add("OPostitoimipaikka");
            oppilaitos.Columns.Add("OPuhelin");

            oppilaitos.Rows.Add(1, "StadinAO", "Hattulantie 2", "00550", "Helsinki", "09 310 8600"); // annetaan tiedot oppilaitos-taulukkoon
            oppilaitos.Rows.Add(2, "Omnia", "Armas Launiksen katu 9", "02650", "Espoo", "046 877 1371");
            oppilaitos.Rows.Add(3, "Varia", "Rälssitie 13", "01530", "Vantaa", "040 182 4668");
            oppilaitos.Rows.Add(4, "Keuda", "Sibeliuksenväylä 55 A", "04400", "Järvenpää", "09 27 381");
        }

        private void taytaVastuuhenkiloTaulukko()
        {
            vastuuHenkilot.Columns.Add("OID",typeof(int)); // yhteinen tekijä kahden taulukon välillä, muodossa int
            vastuuHenkilot.Columns.Add("VNimi"); // luodaan sarakkeet vastuuHenkilot-taulukkoon
            vastuuHenkilot.Columns.Add("VTitteli");
            vastuuHenkilot.Columns.Add("VOsasto");
            vastuuHenkilot.Columns.Add("VSahkoposti");
            vastuuHenkilot.Columns.Add("VPuhelin");

            vastuuHenkilot.Rows.Add(1, "Sirpa Lindroos", "Rehtori", "Kampus 1", "sirpa.lindroos@hel.fi", "050 540 4434"); // annetaan tiedot vastuuHenkilot-taulukkoon
            vastuuHenkilot.Rows.Add(1, "Hanna Laurila", "Rehtori", "Kaupus 2", "hanna.laurila@hel.fi", "040 676 5583");
            vastuuHenkilot.Rows.Add(1, "Annele Ranta", "Rehtori", "Kampus 3", "annele.ranta@hel.fi", "040 631 5667");
            vastuuHenkilot.Rows.Add(1, "Eeva Sahlman", "Rehtori", "Kampus 4", "eeva.sahlman@hel.fi", "040 336 1017");
            vastuuHenkilot.Rows.Add(1, "Marko Aaltonen", "Rehtori", "Kampus 5", "marko.aaltonen@hel.fi", "050 511 8115");
            vastuuHenkilot.Rows.Add(2, "Tuula Antola", "Koulutuskuntayhtymän johtaja", "Yleishallinto", "tuula.antola@omnia.fi", "");
            vastuuHenkilot.Rows.Add(2, "Tapio Siukonen", "Hallintojohtaja", "Yleishallinto", "tapio.siukonen@omnia.fi", "044 369 6600");
            vastuuHenkilot.Rows.Add(2, "Tuukko Soini", "Kehittämisjohtaja", "Yleishallinto", "tuukka.soini@omnia.fi", "046 877 2952");
            vastuuHenkilot.Rows.Add(2, "Riikka-Maria Yli-Suomu", "Liiketoimintajohtaja", "Elinvoima- ja työllisyyspalvelut", "riikka-maria.yli-suomu@omnia.fi", "050 348 6544");
            vastuuHenkilot.Rows.Add(2, "Maija Aaltola", "Rehtori", "Koulutus- ja opiskelijapalvelut", "maija-aaltola@omnia.fi", "050 384 9354");
            vastuuHenkilot.Rows.Add(2, "Kai Iivari", "Talousjohtaja", "Talous ja hankintapalvelut", "kai.iivari@omnia.fi", "0400 306 691");
            vastuuHenkilot.Rows.Add(2, "Päivi Korhonen", "Viestintäjohtaja", "Viestintä- ja markkinointipalvelut", "paivi.korhonen@omnia.fi", "040 126 7599");
            vastuuHenkilot.Rows.Add(3, "Pekka Tauriainen", "Rehtori", "", "pekka.tauriainen@vantaa.fi", "050 312 4514");
            vastuuHenkilot.Rows.Add(3, "Anne Heinonen", "Työelämäpalvelupäällikkö", "", "anne.heinonen@vantaa.fi", "040 524 1242");
            vastuuHenkilot.Rows.Add(3, "Tuula Kiistinen", "Yhteisten palveluiden päällikkö", "", "tuula.kiiskinen@vantaa.fi", "040 193 9048");
            vastuuHenkilot.Rows.Add(4, "Tiina Halmevuo", "Kuntayhtymän johtaja", "Hallinto- ja johtamispalvelut", "tiina.halmevuo@keuda.fi", "050 336 9709");
            vastuuHenkilot.Rows.Add(4, "Anna Mari Leinonen", "Rehtori", "Hallinto", "annamari.leinonen@keuda.fi", "040 174 4523");
            vastuuHenkilot.Rows.Add(4, "Anne Vuorinen", "Johtaja", "Yritys- ja elinvoimapalvelut", "anne.vuorinen@keuda.fi", "050 415 0974");
            vastuuHenkilot.Rows.Add(4, "Hanna Nyrönen", "Viestintä- ja markkinointipäällikkö", "Viestintäpalvelut", "hanna.nyronen@keuda.fi", "040 521 8428");
            vastuuHenkilot.Rows.Add(4, "Maarit Flinck", "Asianhallintapäällikkö", "Hallinto- ja johtamispalvelut", "maarit.flinck@keuda.fi", "0500 837 357");

        }

       
    }
}
