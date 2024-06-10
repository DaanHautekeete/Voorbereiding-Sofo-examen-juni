using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_8
{
    public partial class frmOefening8 : Form
    {
        public frmOefening8()
        {
            InitializeComponent();
        }

        private void btnTekenen_Click(object sender, EventArgs e)
        {
            //label leegmaken
            lblUitkomst.Text = "";

            //string aanmaken voor tekens van 1 reeks 
            string strReeks = "";

            //loop voor uitvoer 
            for (int intTellerRij = Convert.ToInt16(txtStartwaarde.Text); intTellerRij <= Convert.ToInt16(txtEindwaarde.Text); intTellerRij++)
            {
                for (int intTellerTeken = 1; intTellerTeken <= intTellerRij; intTellerTeken++)
                {
                    strReeks += txtSymbool.Text;
                }
                lblUitkomst.Text += strReeks + "\n";
                strReeks = "";
            }
        }
    }
}
