using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_6.Oef_2
{
    public partial class frmOefening2 : Form
    {
        //var aanmaken voor teller
        int intTeller = 0;

        public frmOefening2()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //interval van timer instellen 
            tmrTimer.Interval = Convert.ToInt16(txtTimerInterval.Text);

            //nodige zaken in- en uitschakelen
            txtTimerInterval.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            //timer starten
            tmrTimer.Start();
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            intTeller++;

            //label aanpassen
            lblTimer.Text = intTeller.ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //timer stoppen
            tmrTimer.Stop();

            //nodige zaken in- en uitschakelen
            btnStop.Enabled = false;
            btnReset.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //nodige zaken in- en uitschakelen
            btnStart.Enabled = true;
            btnReset.Enabled = false;
            txtTimerInterval.Enabled = true;

            //alles resetten
            txtTimerInterval.Clear();
            lblTimer.Text = "";
            intTeller = 0;
        }
    }
}
