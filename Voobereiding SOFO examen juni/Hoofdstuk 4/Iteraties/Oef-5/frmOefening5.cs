using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_5
{
    public partial class frmOefening5 : Form
    {
        //int aanmaken voor de uitkomst
        int intUitkomst;

        public frmOefening5()
        {
            InitializeComponent();

            //listbox vullen met tafels => loop 
            for (int intTeller = 1; intTeller <= 10; intTeller++)
            {
                lsbTafels.Items.Add(intTeller);
            }
        }

        //code om een tafel te selecteren
        private void lsbTafels_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int intTeller = 1; intTeller <= 10; intTeller++)
            {
                intUitkomst = Convert.ToInt16(lsbTafels.SelectedItem) * intTeller;

                lblTafels.Text += intTeller.ToString() + "x" + lsbTafels.SelectedItem.ToString() + " = " + intUitkomst.ToString(); 
            }
        }
    }
}
