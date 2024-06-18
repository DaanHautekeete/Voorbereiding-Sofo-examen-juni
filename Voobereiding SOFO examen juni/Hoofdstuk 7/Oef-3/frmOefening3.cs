using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_7.Oef_3
{
    public partial class frmOefening3 : Form
    {
        //array aanmaken voor de getallen
        int[] arrGetallen = new int[7];

        //object van klasse ramdom maken
        Random random = new Random();

        public frmOefening3()
        {
            InitializeComponent();

            //array vullen met random getallen
            for (int intTeller = 0; intTeller <= arrGetallen.GetUpperBound(0); intTeller++)
            {
                arrGetallen[intTeller] = random.Next(0, 11);
            }

            lsbRandomGetallen.DataSource = arrGetallen;

            //gegevens tonen in de labels
            lblAantalGetallen.Text = "Aantal getallen: " + Convert.ToString(arrGetallen.Length);
            lblHoogsteIndexwaarde.Text = "Hooogste indexwaarde: " + Convert.ToString(arrGetallen.GetUpperBound(0));
            lblHoogsteWaarde.Text = "Hoogste waarde: " + Convert.ToString(arrGetallen.Max());
            lblLaagsteWaarde.Text = "Laagste waarde: " + Convert.ToString(arrGetallen.Min());
        }
    }
}
