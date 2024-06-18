using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_6.Oef_6
{
    public partial class frmOefening6 : Form
    {
        public frmOefening6()
        {
            InitializeComponent();
        }

        private void picLeuk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Je hebt gelijk!", "Juiste keuze");
        }

        private void picSaai_MouseEnter(object sender, EventArgs e)
        {
            //nieuw punt maken met random waarden
            Point NieuwePositie = new Point();

            Random random = new Random();

            NieuwePositie.X = random.Next(1, 700);
            NieuwePositie.Y = random.Next(1, 350);

            //nieuwe locatie geven aan de picturebox
            picSaai.Location = NieuwePositie;
        }
    }
}
