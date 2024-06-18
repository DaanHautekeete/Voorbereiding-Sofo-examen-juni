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

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_11
{
    public partial class frmOefening11 : Form
    {
        //var aanmaken voor wachtwoord
        string strWachtwoord = "SintJozefBrugge";
        bool blnIngelogd = false;

        public frmOefening11()
        {
            InitializeComponent();
        }

        private void btnInvoeren_Click(object sender, EventArgs e)
        {
            //bool ingelogd resetten
            blnIngelogd = false;

            //object maken van klasse
            Oef_11.frmOefening11_Welkom frmOefening11_Welkom = new frmOefening11_Welkom();

            //loop om wachtwoord te vragen
            for (int intTeller = 1; intTeller <= 3; intTeller++)
            {
                if (Interaction.InputBox("Geef het wachtwoord in", "Invoer wachtwoord").Trim() == strWachtwoord)
                {
                    frmOefening11_Welkom.Show();

                    blnIngelogd = true;

                    //loop verbreken
                    break;
                }
            }

            if (blnIngelogd != true)
            {
                //programma afsluiten
                Application.Exit();
            }
        }
    }
}
