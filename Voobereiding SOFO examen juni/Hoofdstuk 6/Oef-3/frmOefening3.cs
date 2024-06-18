using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_6.Oef_3
{
    public partial class frmOefening3 : Form
    {
        public frmOefening3()
        {
            InitializeComponent();
            
            //klok starten
            tmrKlok.Start();
        }

        private void tmrKlok_Tick(object sender, EventArgs e)
        {
            lblKlok.Text = DateTime.Now.ToString("HH:mm:ss:ff");
        }
    }
}
