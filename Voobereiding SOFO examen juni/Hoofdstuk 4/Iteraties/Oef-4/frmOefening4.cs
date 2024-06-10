using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_4
{
    public partial class frmOefening4 : Form
    {
        public frmOefening4()
        {
            InitializeComponent();
        }

        private void btnGrootste_Click(object sender, EventArgs e)
        {
            //var aanmaken voor grootste getal
            int intGrootsteGetal = 0, intGetal;

            //loop maken voor invoer van de getallen
            for (int intTeller = 1; intTeller <= 10; intTeller++)
            {
                intGetal = Convert.ToInt16(Interaction.InputBox("Geef een getal in", "Invoer getal " + intTeller.ToString()));

                //grootste getal bepalen
                intGrootsteGetal = Math.Max(intGetal, intGrootsteGetal);

            }

            //tekst in label aanpassen
            lblGrootsteGetal.Text = "Grootste getal: " + intGrootsteGetal.ToString();
        }
    }
}
