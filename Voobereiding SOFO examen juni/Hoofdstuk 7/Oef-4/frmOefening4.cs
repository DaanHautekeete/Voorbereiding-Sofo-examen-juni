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

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_7.Oef_4
{
    public partial class frmOefening4 : Form
    {
        //array aanmaken voor de diersoorten
        string[] arrDiersoorten = new string[5];
        string[] arrDiersoortenAlfabetisch = new string[5];
        string[] arrDiersoortenOmgekeerd = new string[5];

        public frmOefening4()
        {
            InitializeComponent();

            //aan de hand van inputboxen de array met diersoorten vullen
            for (int intTeller = 0; intTeller <= arrDiersoorten.GetUpperBound(0); intTeller++)
            {
                arrDiersoorten[intTeller] = Interaction.InputBox("Geef een diersoort in", "Invoer dier " + (intTeller + 1));
            }

            //datasource van eerste listbox gelijkstellen aan de originele array van de diersoorten
            lsbStandaard.DataSource = arrDiersoorten;


        }

        //knop om alfabetisch te sorteren
        private void btnSorteer_Click(object sender, EventArgs e)
        {
            //originele array klonen naar de alfabetische array
            Array.Copy(arrDiersoorten, arrDiersoortenAlfabetisch, arrDiersoorten.Length);

            //kopie van de array alfabetisch sorteren
            Array.Sort(arrDiersoortenAlfabetisch);

            //datasource van de listbox gelijkstellen aan de array
            lsbAlfabetisch.DataSource = arrDiersoortenAlfabetisch;
        }

        //knop om alfabetisch gesorteerde lijst om te draaien
        private void btnOmdraaien_Click(object sender, EventArgs e)
        {
            //alfabetische array klonen naar de omgekeerde array
            Array.Copy(arrDiersoortenAlfabetisch, arrDiersoortenOmgekeerd, arrDiersoortenAlfabetisch.Length);

            //array omdraaien
            Array.Reverse(arrDiersoortenOmgekeerd);

            //datasource gelijkstellen aan de array
            lsbOmgekeerd.DataSource = arrDiersoortenOmgekeerd;
        }
    }
}
