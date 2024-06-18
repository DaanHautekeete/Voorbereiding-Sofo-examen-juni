using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_4.Iteraties.Oef_13
{
    public partial class frmOefening13 : Form
    {
        public frmOefening13()
        {
            InitializeComponent();
        }

        //knop om defecte computers toe te voegen
        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            //dialogresult aanmaken
            DialogResult dlgKeuzeInvoer = new DialogResult();

            //loop die alle gekozen computers overloopt
            foreach (var Computer in checkedlistboxComputers.CheckedItems)
            {
                //naam van de computer toevoegen aan de listbox
                lsbDefecteComputers.Items.Add("+++++++++++" + Computer.ToString() + "+++++++++++");

                //inputbox weergeven voor het probleem
                lsbDefecteComputers.Items.Add("Probleem " + Computer.ToString() + ": " + Interaction.InputBox("Geef een beschrijving voor het probleem van:\n\n" + Computer.ToString(), "Invoer probleem"));

                //messagebox weergeven om nog een probleem in te geven
                dlgKeuzeInvoer = MessageBox.Show("Wenst u nog een probleem in te geven voor:\n\n" + Computer.ToString(), "Nog een probleem?", MessageBoxButtons.YesNo);

                //loop om problemen in te geven
                while (dlgKeuzeInvoer == DialogResult.Yes)
                {
                    //inputbox weergeven voor het probleem
                    lsbDefecteComputers.Items.Add("Probleem " + Computer.ToString() + ": " + Interaction.InputBox("Geef een beschrijving voor het probleem van:\n\n" + Computer.ToString(), "Invoer probleem").Trim() + "\n");

                    //messagebox weergeven om nog een probleem in te geven
                    dlgKeuzeInvoer = MessageBox.Show("Wenst u nog een probleem in te geven voor:\n\n" + Computer.ToString(), "Nog een probleem?", MessageBoxButtons.YesNo);
                }
            }
        }

        //knop om alles te resetten
        private void btnReset_Click(object sender, EventArgs e)
        {
            //informatie in listbox legen
            lsbDefecteComputers.Items.Clear();

            //loop om alle checkboxen op unchecked te zetten
            for (int intTeller = 0; intTeller < checkedlistboxComputers.Items.Count; intTeller++)
            {
                //item deselecteren
                checkedlistboxComputers.SetItemChecked(intTeller, false);
            }

            checkedlistboxComputers.SelectedItem = null;
        }
    }
}
