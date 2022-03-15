using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VaihdaBT_Click(object sender, EventArgs e) // ohjelma käynnistyy nappia painamalla
        {
            OtsikkoLB.Text = "Heippa maailma!"; // haetaan design-puolelta label 'OtsikkoLB' ja vaihdetaan siihen teksti
        }
    }
}
