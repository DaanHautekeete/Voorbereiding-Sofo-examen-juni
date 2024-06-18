using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_5.Oef_4
{
    public partial class frmOefening4 : Form
    {
        //var aanamken voor de verschillende delen van de bankrekening
        int intControle, intControlecijfer;
        long lngOptelling;

        public frmOefening4()
        {
            InitializeComponent();
        }

        //eigen functie om de bankrekening te controleren
        private void ControlerenBankrekening()
        {
            //var maken voor de optelling van de eerste 2 delen het bakrekeningnr.
            string strOptelling = txtBanknummer.Text + txtClientNummer.Text;

            //getal die we opgevangen hebben omzetten naar een getal
            lngOptelling = Convert.ToInt64(strOptelling);

            //controlecijfer opslaan
            intControlecijfer = Convert.ToInt16(txtControleCijfer.Text);

            //controleren of controlecijfer klopt
            if (lngOptelling % 97 == intControlecijfer)
            {
                MessageBox.Show("Het bankrekeningnummer is geldig", "Controle bankrekeningnummer");
            }
            else
            {
                MessageBox.Show("Het bankrekeningnummer is ongeldig", "Controle bankrekeningnummer");
            }

            //tekstboxen leegmaken + focus op de eerste
            txtBanknummer.Clear();
            txtClientNummer.Clear();
            txtClientNummer.Enabled = false;
            txtControleCijfer.Clear();
            txtControleCijfer.Enabled = false;
            txtBanknummer.Focus();
        }



        //tekst in banknummer verandert
        private void txtBanknummer_TextChanged(object sender, EventArgs e)
        {
            //controleren of de maximumwaarde ingegeven is
            if (txtBanknummer.Text.Length == txtBanknummer.MaxLength)
            {
                //volgend textbox inschakelen + focus
                txtClientNummer.Enabled = true;
                txtClientNummer.Focus();
            }
        }

        //tekst in clientnummer verandert
        private void txtClientNummer_TextChanged(object sender, EventArgs e)
        {
            //controleren of de maximumwaarde ingegeven is
            if (txtClientNummer.Text.Length == txtClientNummer.MaxLength)
            {
                //volgend textbox inschakelen + focus
                txtControleCijfer.Enabled = true;
                txtControleCijfer.Focus();
            }
        }

        //tekst in controlecijfer verandert
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
