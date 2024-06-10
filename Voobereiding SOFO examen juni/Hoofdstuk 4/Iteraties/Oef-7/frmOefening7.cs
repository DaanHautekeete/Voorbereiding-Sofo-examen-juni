using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_7
{
    public partial class frmOefening7 : Form
    {
        public frmOefening7()
        {
            InitializeComponent();
        }

        private void btnTonen_Click(object sender, EventArgs e)
        {
            //Var aanmaken
            int intGetal1 = 0;
            int intGetal2 = 1;
            int intSom;

            lblUitvoer.Text = "0 1 ";

            //loop om de eerste 40 getallen weer te geven
            for (int intTeller = 1; intTeller <= 40; intTeller++)
            {
                intSom = intGetal1 + intGetal2;

                lblUitvoer.Text += intSom + " ";

                intGetal1 = intGetal2;
                intGetal2 = intSom;
            }

        }
    }
}
