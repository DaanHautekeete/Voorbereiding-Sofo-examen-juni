using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_5.Oef_2
{
    public partial class frmOefening2 : Form
    {
        //var aanmaken voor de stralen van de cirkels
        double dblStraalCirkel1, dblStraalCirkel2;

        public frmOefening2()
        {
            InitializeComponent();

            //inputboxen voor stralen in te geven
            dblStraalCirkel1 = Convert.ToDouble(Interaction.InputBox("Geef een straal in voor cirkel 1", "Invoer straal cirkel 1"));
            dblStraalCirkel2 = Convert.ToDouble(Interaction.InputBox("Geef een straal in voor cirkel 2", "Invoer straal cirkel 2"));

            //waarden in labels plaasten
            lblStraalCirkel1.Text = "Straal cirkel 1: " + dblStraalCirkel1.ToString();
            lblStraalCirkel2.Text = "Straal cirkel 2: " + dblStraalCirkel2.ToString();
        }

        //knop om alles te berekenen
        private void btnBerekenen_Click(object sender, EventArgs e)
        {
            //oppervlakte en straal berekenen voor cirkel 1 met eigen functies + weergeven in label
            lblUitkomstenCirkel1.Text = "De omtrek van cirkel 1 = " + OmtrekBerekenen(dblStraalCirkel1).ToString() + "\nDe oppervlakte van cirkel 1 = " + OppervlakteBerkenen(dblStraalCirkel1).ToString();

            //oppervlakte en straal berekenen voor cirkel 2 met eigen functies + weergeven in label
            lblUitkomstenCirkel2.Text = "De omtrek van cirkel 2 = " + OmtrekBerekenen(dblStraalCirkel2).ToString() + "\nDe oppervlakte van cirkel 2 = " + OppervlakteBerkenen(dblStraalCirkel2).ToString();
        }

        //eigen functies om alles te berekenen
        private double OmtrekBerekenen(double dblStraal)
        {
            double dblOmtrek;

            dblOmtrek = Math.Round((dblStraal * 2) * Math.PI,2);

            return dblOmtrek;
        }

        private double OppervlakteBerkenen(double dblStraal)
        {
            double dblOppervlakte;

            dblOppervlakte = Math.Round(Math.PI * Math.Pow(dblStraal, 2),2);



            return dblOppervlakte;
        }
    }
}
