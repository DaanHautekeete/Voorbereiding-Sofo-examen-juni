using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_3
{
    public partial class frmOefening3 : Form
    {
        public frmOefening3()
        {
            InitializeComponent();
        }

        private void btnToon_Click(object sender, EventArgs e)
        {
            //tekst verwijderen uit label
            lblSterren.Text = "";
            //var aanmaken voor aantal sterren
            int intAantalSterren = Convert.ToInt16(txtAantalSterren.Text);

            //loop om sterren weer te geven
            for (int intTeller = 0; intTeller < intAantalSterren; intTeller++)
            {
                lblSterren.Text += "*";
            }
        }
    }
}
