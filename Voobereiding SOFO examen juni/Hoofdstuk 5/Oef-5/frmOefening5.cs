using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_5.Oef_5
{
    public partial class frmOefening5 : Form
    {
        public frmOefening5()
        {
            InitializeComponent();
        }

        private void btnBerekenLeeftijd_Click(object sender, EventArgs e)
        {
            //datetime maken vanuit de textbox
            DateTime dtmGeboortedatum = Convert.ToDateTime(txtGeboortejaar.Text);

            //uitvoer weergeven met de eigen functie
            lblLeeftijd.Text = LeeftijdBerkenen(dtmGeboortedatum);
        }

        //eigen functie om leeftijd te berekenen
        private string LeeftijdBerkenen(DateTime dtmGeboortedatum)
        {
            //var aanmaken voor de leeftijd
            int intLeeftijd;

            //leeftijd berekenen
            intLeeftijd = DateTime.Today.Year - dtmGeboortedatum.Year;

            //controleren of de persoon al jarig is geweest dit jaar
            //als de datum van vandaag nog niet voorbij de datum van je geboortedatum + je originele leeftijd is => dan verminderen we de leeftijd met 1
            if (DateTime.Today < dtmGeboortedatum.AddYears(intLeeftijd))
            {
                intLeeftijd--;
            }

            return "Je bent " + intLeeftijd + " jaar oud";
        }
    }
}
