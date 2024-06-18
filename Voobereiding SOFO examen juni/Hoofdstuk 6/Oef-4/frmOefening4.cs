using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_6.Oef_4
{
    public partial class frmOefening4 : Form
    {
        //var maken voor de timer
        int intTimer;

        public frmOefening4()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //var van timer instellen
            intTimer = Convert.ToInt16(txtAantalSeconden.Text);

            //timer starten
            tmrCountdown.Start();
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            //timer verminderen met 1
            intTimer--;

            //timer weergeven in label
            txtAantalSeconden.Text = Convert.ToString(intTimer);

            //controleren of timer 0 is
            if (intTimer == 0)
            {
                lblTijdOver.Show();
                tmrCountdown.Stop();
            }
        }

        private void btnWis_Click(object sender, EventArgs e)
        {
            //alles wissen
            lblTijdOver.Hide();
            txtAantalSeconden.Clear();
        }
    }
}
