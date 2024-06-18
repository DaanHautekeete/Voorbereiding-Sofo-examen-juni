using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_7.Oef_10
{
    public partial class frmOefening10 : Form
    {
        //2D array aanmaken met de provincies en hun hoofdsteden
        string[,] arrProvinciesHoofdsteden = new string[11, 2]
        {
            {"Antwerpen", "Antwerpen"},
            { "Limburg", "Hasselt" },
            {"Oost-Vlaanderen", "Gent"},
            {"Vlaams-Brabant", "Leuven"},
            {"West-Vlaanderen", "Brugge"},
            {"Henegouwen", "Bergen"},
            {"Luik", "Luik" },
            {"Luxemburg", "Aarlen" },
            {"Namen", "Namen" },
            {"Waals-Brabant", "Waver" },
            {"Brussels Hoofdstedelijk Gewest", "Brussel" }
        };

        public frmOefening10()
        {
            InitializeComponent();
        }

        //knop om alle provincies en hoofdsteden te tonen
        private void btnProvinciesTonen_Click(object sender, EventArgs e)
        {
            for (int intTeller = 0; intTeller <= arrProvinciesHoofdsteden.GetUpperBound(0); intTeller++)
            {
                lblProvinciesEnHoofdsteden.Text += arrProvinciesHoofdsteden[intTeller, 0] + " - " + arrProvinciesHoofdsteden[intTeller, 1] + "\n\n";
            }
        }

        private void btnAantalElementen_Click(object sender, EventArgs e)
        {
            lblAantalElementen.Text = arrProvinciesHoofdsteden.Length.ToString();
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            lblRank.Text = arrProvinciesHoofdsteden.Rank.ToString();
        }

        private void btnAantalRijen_Click(object sender, EventArgs e)
        {
            lblAantalRijen.Text = arrProvinciesHoofdsteden.GetLength(0).ToString();
        }

        private void btnAantalKolommen_Click(object sender, EventArgs e)
        {
            lblAantalKolommen.Text = arrProvinciesHoofdsteden.GetLength(1).ToString(); 
        }

        private void btnHoogsteRijIndex_Click(object sender, EventArgs e)
        {
            lblHoogsteRijIndex.Text = arrProvinciesHoofdsteden.GetUpperBound(0).ToString();
        }

        private void btnHoogsteKolomindex_Click(object sender, EventArgs e)
        {
            lblHoogsteKolomindex.Text = arrProvinciesHoofdsteden.GetUpperBound(1).ToString();
        }
    }
}
