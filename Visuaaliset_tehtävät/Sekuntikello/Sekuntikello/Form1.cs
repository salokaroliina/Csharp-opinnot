using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics; // otetaan käyttöön system Diagnostics, jotta sekuntikelloa voidaan käyttää

namespace Sekuntikello
{
    public partial class KelloForm : Form
    {
        private Stopwatch ajastin; 
        public KelloForm()
        {
            InitializeComponent();
        }

        private void StartBT_Click(object sender, EventArgs e) // start-buttonia painaessa kello käynnistyy
        {
            ajastin.Start();
        }

        private void StopBT_Click(object sender, EventArgs e) // stop-buttonia painaessa kello pysähtyy
        {
            ajastin.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e) // reset-buttonia painaessa kello nollautuu
        {
            ajastin.Reset();
        }

        private void KelloForm_Load(object sender, EventArgs e) // ohjelman latautuessa saadaan uusi sekuntikello käyttöön
        {
            ajastin = new Stopwatch();
        }
        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            TimerLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", ajastin.Elapsed); // TimerLB näyttää ajan halutussa muodossa (00:00:00.000)
            // tai pitäisi näyttää. :fff ei toimi halutulla tavalla ohjeesta huolimatta
        }
    }
}
