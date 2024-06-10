using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_2
{
    public partial class frmOefening2 : Form
    {
        //var aanmaken voor het getal en uitkomst
        int intGetal, intUitkomst;

        public frmOefening2()
        {
            InitializeComponent();
            //vraag getal aan gebruiker
            intGetal = Convert.ToInt32(Interaction.InputBox("Geef een getal in", "Invoer getal"));

            //loop voor de som van alle voorafgaande getallen op te tellen
            for (int intTeller = 0; intTeller <= intGetal; intTeller++)
            {
                intUitkomst += intTeller;
            }

            //uitvoer in labels
            lblIngegevenGetal.Text = "Het ingegeven getal: " + intGetal.ToString();
            lblSom.Text = "De som van alle voorafgaande getallen: " + intUitkomst.ToString();
        }
    }
}
