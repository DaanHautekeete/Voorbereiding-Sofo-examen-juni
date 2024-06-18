using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_7.Oef_7
{
    public partial class frmOefening7 : Form
    {
        //array maken voor de getallen
        int[] arrGetallen = new int[10];
        

        public frmOefening7()
        {
            InitializeComponent();

        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            //label leegmaken
            lblWaardenArray.Text = "";

            //object maken van de klasse random
            Random random = new Random();

            //var maken voor het getal
            int intGetal, intIndexGetal;

            //10 random getallen opslaan in de array 
            for (int intTeller = 0; intTeller <= arrGetallen.GetUpperBound(0); intTeller++)
            {
                intGetal = random.Next(1, 101);

                //index van getal opslaan in var 
                intIndexGetal = Array.IndexOf(arrGetallen, intGetal);

                //zolang het getal voorkomt in de array => nieuw getal 
                while (intIndexGetal > 0)
                {
                    //nieuw random getal opslaan
                    intGetal = random.Next(1,101);

                    //index van getal opslaan in var 
                    intIndexGetal = Array.IndexOf(arrGetallen, intGetal);
                }

                //getal toevoegen aan de array
                arrGetallen[intTeller] = intGetal;
            }

            //array sorteren
            Array.Sort(arrGetallen);

            //getallen weergeven in het label
            foreach (var getal in arrGetallen)
            {
                lblWaardenArray.Text += getal.ToString() + "\n";
            }
        }
    }
}
