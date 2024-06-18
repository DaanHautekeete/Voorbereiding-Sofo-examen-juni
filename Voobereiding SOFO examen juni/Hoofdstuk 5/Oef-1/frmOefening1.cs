using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_5.Oef_1
{
    public partial class frmOefening1 : Form
    {
        public frmOefening1()
        {
            InitializeComponent();
        }

        private void trackBarRood_Scroll(object sender, EventArgs e)
        {
            AchtergrondkleurVeranderen(trackBarRood.Value, trackBarGroen.Value, trackBarBlauw.Value);
        }

        private void trackBarGroen_Scroll(object sender, EventArgs e)
        {
            AchtergrondkleurVeranderen(trackBarRood.Value, trackBarGroen.Value, trackBarBlauw.Value);

        }

        private void trackBarBlauw_Scroll(object sender, EventArgs e)
        {
            AchtergrondkleurVeranderen(trackBarRood.Value, trackBarGroen.Value, trackBarBlauw.Value);
        }

        //eigen functie maken om achtergrondkleur te veranderen
        private void AchtergrondkleurVeranderen(int intRood, int intGroen, int intBlauw)
        {
            //achtergrondkleur aanpassen
            this.BackColor = Color.FromArgb(intRood, intGroen, intBlauw);

            //tekst in label aanpassen
            lblRGB.Text = "RGB (" + intRood.ToString() + ", " + intGroen.ToString() + ", " + intBlauw.ToString() + ")";
        }


    }
}
