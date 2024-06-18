using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_6.Oef_1
{
    public partial class frmOefening1 : Form
    {
        public frmOefening1()
        {
            InitializeComponent();

            //timer starten
            tmrAfbeelding.Start();
        }

        private void tmrAfbeelding_Tick(object sender, EventArgs e)
        {
            //random afbeelding weergeven in de picturebox
            int intFoto; 
            Random rndFoto = new Random();

            intFoto = rndFoto.Next(1,5);

            switch (intFoto)
            {
                case 1:
                    picAfbeelding.Image = Properties.Resources.Natuur1;
                    break;
                case 2:
                    picAfbeelding.Image = Properties.Resources.Natuur2;
                    break;
                case 3:
                    picAfbeelding.Image = Properties.Resources.Natuur3;
                    break;
                case 4:
                    picAfbeelding.Image = Properties.Resources.Natuur4;
                    break;
            }
        }
    }
}
