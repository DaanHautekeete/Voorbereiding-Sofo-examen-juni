using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_7.Oef_2
{
    public partial class frmOefening2 : Form
    {
        //array maken met alle maanden in
        string[] arrMaanden = new string[12] { "Januari", "Februari", "Maart", "April", "Mei", "Juni", "Juli", "Augustus", "September", "Oktober", "November", "December" };

        public frmOefening2()
        {
            InitializeComponent();
        }

        private void btnToonMaand_Click(object sender, EventArgs e)
        {
            //datum aanmaken
            DateTime dtmGeboortedatum = Convert.ToDateTime(txtGeboortedatum.Text);

            lblMaandVanGeboorte.Text = "Je bent geboren in de maand " + arrMaanden[(dtmGeboortedatum.Month - 1)];
        }
    }
}
