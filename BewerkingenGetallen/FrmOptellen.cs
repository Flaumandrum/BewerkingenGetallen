﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BewerkingenGetallen
{
    public partial class FrmOptellen : Form
    {
        public FrmOptellen()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            // Afsluiten
            Close();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            // de gebruiker kan verkeerde gegevens ingeven 
            // Zorg ervoor dat je dit probleem opvangt.
            try
            {
                // neem de gegevens over in variabelen
                int getal1 = int.Parse(txtGetal1.Text);
                int getal2 = int.Parse(txtGetal2.Text);

                MessageBox.Show( Program.Optellen(getal1 , getal2), "Oplossing");
            }
            catch 
            {
                // Foutmelding 
                MessageBox.Show("U gaf geen natuurlijke getallen in." + Environment.NewLine + "Probeer opnieuw.","Computers says no!", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }
    }
}
