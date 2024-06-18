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

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_7.Oef_6
{
    public partial class frmOefening6 : Form
    {
        //arrays aanmaken voor de verschillende klassen
        string[] arrLeerlingen5AI = new string[] { "Arnaud", "Bas", "Caitlin", "Jari", "Kethlijne", "Lana", "Mateo" };

        string[] arrLeerlingen5NI1 = new string[] { "Emiel", "Guillaume", "Ina", "Jordan", "Lander", "Simon" };

        string[] arrLeerlingen5NI2 = new string[] { "Conan", "Milan", "Seraphin", "Timon", "Victor" };

        //bool aanmaken voor het toevoegen
        bool blnToevoegen;

        public frmOefening6()
        {
            InitializeComponent();
        }

        //knop om leerlingen weer te geven in listbox
        private void btn5AI_Click(object sender, EventArgs e)
        {
            //array alfabetisch sorteren
            Array.Sort(arrLeerlingen5AI);

            //datasource van listbox gelijkstellen aan de array
            lsbLeerlingen5AI.DataSource = arrLeerlingen5AI;
        }

        //knop om leerlingen weer te geven in listbox
        private void btn5NI1_Click(object sender, EventArgs e)
        {
            //array alfabetisch sorteren
            Array.Sort(arrLeerlingen5NI1);

            //datasource van listbox gelijkstellen aan de array
            lsbLeerlingen5NI1.DataSource = arrLeerlingen5NI1;
        }


        //knop om leerlingen weer te geven in listbox
        private void btn5NI2_Click(object sender, EventArgs e)
        {
            //array alfabetisch sorteren
            Array.Sort(arrLeerlingen5NI2);

            //datasource van listbox gelijkstellen aan de array
            lsbLeerlingen5NI2.DataSource = arrLeerlingen5NI2;
        }

        //knop om nieuwe leerlingen toe te voegen
        private void btnNieuweLeerlingInvoeren_Click(object sender, EventArgs e)
        {
            //bool aanpassen
            blnToevoegen = true;

            //var aanmaken voor de naam
            string strNaam;

            if (rdb5AI.Checked)
            {
                while (blnToevoegen)
                {
                    strNaam = Interaction.InputBox("Geef een naam in\nGeef EINDE in om te stoppen");

                    if (strNaam == "EINDE")
                    {
                        blnToevoegen = false;
                    }
                    else
                    {
                        //naam toevoegen aan de array
                        Array.Resize(ref arrLeerlingen5AI, arrLeerlingen5AI.Length + 1);

                        arrLeerlingen5AI[arrLeerlingen5AI.GetUpperBound(0)] = strNaam;

                        //array alfabetisch sorteren
                        Array.Sort(arrLeerlingen5AI);

                        //datasource van listbox gelijkstellen aan de array
                        lsbLeerlingen5AI.DataSource = arrLeerlingen5AI;
                    }
                }
            }
            else if (rdb5NI1.Checked)
            {
                while (blnToevoegen)
                {
                    strNaam = Interaction.InputBox("Geef een naam in\nGeef EINDE in om te stoppen");

                    if (strNaam == "EINDE")
                    {
                        blnToevoegen = false;
                    }
                    else
                    {
                        //naam toevoegen aan de array
                        Array.Resize(ref arrLeerlingen5NI1, arrLeerlingen5NI1.Length + 1);

                        arrLeerlingen5NI1[arrLeerlingen5NI1.GetUpperBound(0)] = strNaam;

                        //array alfabetisch sorteren
                        Array.Sort(arrLeerlingen5NI1);

                        //datasource van listbox gelijkstellen aan de array
                        lsbLeerlingen5NI1.DataSource = arrLeerlingen5NI1;
                    }
                }
            }
            else
            {
                while (blnToevoegen)
                {
                    strNaam = Interaction.InputBox("Geef een naam in\nGeef EINDE in om te stoppen");

                    if (strNaam == "EINDE")
                    {
                        blnToevoegen = false;
                    }
                    else
                    {
                        //naam toevoegen aan de array
                        Array.Resize(ref arrLeerlingen5NI2, arrLeerlingen5NI2.Length + 1);

                        arrLeerlingen5NI2[arrLeerlingen5NI2.GetUpperBound(0)] = strNaam;

                        //array alfabetisch sorteren
                        Array.Sort(arrLeerlingen5NI2);

                        //datasource van listbox gelijkstellen aan de array
                        lsbLeerlingen5NI2.DataSource = arrLeerlingen5NI2;
                    }
                }
            }
        }
    }
}
