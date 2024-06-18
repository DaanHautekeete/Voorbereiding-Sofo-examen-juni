using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_14
{
    public partial class frmOefening14 : Form
    {
        public frmOefening14()
        {
            InitializeComponent();
        }

        //knop om een bestand te kunnen kiezen
        private void btnBladeren_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            cobAfbeeldingen.Items.Add(openFileDialog1.FileName);
        }

        private void cobAfbeeldingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foto laden uit de combobox[
            picFoto.Load((string)cobAfbeeldingen.SelectedItem);
        }
    }
}
