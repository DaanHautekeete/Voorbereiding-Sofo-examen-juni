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

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_9
{
    public partial class frmOefening9 : Form
    {
        public frmOefening9()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //tekst in label verwijderen 
            lblMelding.Text = "";

            //random getal genereren
            Random random = new Random();

            //Var aanmaken
            int intTeRadenGetal = random.Next(1, 11);
            int intGeradenGetal, intAantalPogingen = 1;

            intGeradenGetal = Convert.ToInt16(Interaction.InputBox("Geef een getal in tussen 1 en 10"));

            //loop als het ingevoerde getal niet gelijk is aan het te raden getal
            while(intGeradenGetal != intTeRadenGetal && intAantalPogingen != 10)
            {
                //foutmeldingen weergeven
                if (intGeradenGetal > 10 || intGeradenGetal < 1)
                {
                    MessageBox.Show("Geef een getal in tussen de 1 en 10"); 
                }
                intAantalPogingen++;

                //inputbox weergeven
                intGeradenGetal = Convert.ToInt16(Interaction.InputBox("Geef een getal in tussen 1 en 10"));

            }

            //controleren of de gebruiker verloren heeft
            if (intAantalPogingen == 10 && intGeradenGetal != intTeRadenGetal)
            {
                lblMelding.Text = "Je hebt verloren, volgende keer beter";
            }
            else
            {
                lblMelding.Text = "Goed geraden, je hebt er " + intAantalPogingen.ToString() + " pogingen voor nodig gehad";
            }
        }
    }
}
