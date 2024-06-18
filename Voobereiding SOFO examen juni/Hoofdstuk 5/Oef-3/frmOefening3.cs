using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_5.Oef_3
{
    public partial class frmOefening3 : Form
    {
        //var aanamken voor de verschillende delen van de bankrekening
        int intControle, intOptelling, intControlecijfer;

        public frmOefening3()
        {
            InitializeComponent();
        }

        //eigen functie om de bankrekening te controleren
        private void ControlerenBankrekening()
        {
            //var maken voor de optelling van de eerste 2 delen het bakrekeningnr.
            string strOptelling = txtBanknummer.Text + txtClientNummer.Text;

            //getal die we opgevangen hebben omzetten naar een getal
            intOptelling = Convert.ToInt32(strOptelling);

            //restwaarde bepalen om de controle correct uit te kunnen voeren
            intControle = intOptelling % 97;

            //controlecijfer opslaan
            intControlecijfer = Convert.ToInt16(txtControleCijfer.Text);

            //controleren of controlecijfer klopt
            if (intControle == intControlecijfer)
            {
                MessageBox.Show("Het bankrekeningnummer is geldig", "Controle bankrekeningnummer");
            }
            else
            {
                MessageBox.Show("Het bankrekeningnummer is ongeldig", "Controle bankrekeningnummer");
            }
        }

        private void txtControleCijfer_TextChanged(object sender, EventArgs e)
        {
            //kijken of alles ingevuld is
            if (txtControleCijfer.Text.Length == txtControleCijfer.MaxLength)
            {
                //bankrekeningnummer controleren met eigen functie
                ControlerenBankrekening();
            }
        }
    }
}
