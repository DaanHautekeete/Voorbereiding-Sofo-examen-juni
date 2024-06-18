using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_8.Oef_2
{
    public partial class frmOefening2 : Form
    {
        public frmOefening2()
        {
            InitializeComponent();
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            //nieuw object aanmaken van de leerling
            Leerling leerling = new Leerling();

            //waarden geven aan de eigenschappen van object leerling
            if (txtVoornaamValue.Text.Trim() != string.Empty)
            {
                leerling.Voornaam = txtVoornaamValue.Text;
            }
            else
            {
                MessageBox.Show("Geef een voornaam in aub", "Ongeldige invoer");
            }

            if (txtAchternaamValue.Text.Trim() != string.Empty)
            {
                leerling.Familienaam = txtAchternaamValue.Text;
            }
            else
            {
                MessageBox.Show("Geef een familienaam in aub", "Ongeldige inveoer");
            }

            //geboortedatum controleren op juiste invoer
            DateTime dtmGeboortedatum = new DateTime();

            if (DateTime.TryParse(txtGeboortedatumValue.Text, out dtmGeboortedatum))
            {
                leerling.Geboortedatum = dtmGeboortedatum;
            }
            else
            {
                MessageBox.Show("Geef een geldige geboortedatum in aub", "Ongeldige invoer");
            }

            //klas toewijzen aan de leerling
            if (cmbKlassen.SelectedIndex != 0)
            {
                leerling.Klas = cmbKlassen.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Gelieve een klas te selecteren", "Ongeldige keuze");
            }

            //volledige naam samenstellen
            leerling.VolledigeNaam = leerling.Voornaam + " " + leerling.Familienaam;

            //leeftijd van de leerling berekenen
            leerling.Leeftijd = DateTime.Today.Year - leerling.Geboortedatum.Year;

            //controleren of de leerling dit jaar al verjaard is
            if (DateTime.Today < leerling.Geboortedatum.AddYears(leerling.Leeftijd))
            {
                leerling.Leeftijd--;
            }


            //leerling toevoegen aan de juiste klas 
            switch (cmbKlassen.SelectedIndex)
            {
                case 1:
                    lsbLeerlingen5IB.Items.Add(leerling.VolledigeNaam.ToString() + " (" + leerling.Leeftijd + " jaar)");
                    break;
                case 2:
                    lsbLeerlingen5BI.Items.Add(leerling.VolledigeNaam.ToString() + " (" + leerling.Leeftijd + " jaar)");
                    break;
                case 3:
                    lsbLeerlingen5HA.Items.Add(leerling.VolledigeNaam.ToString() + " (" + leerling.Leeftijd + " jaar)");
                    break;
            }
        }
    }
}
