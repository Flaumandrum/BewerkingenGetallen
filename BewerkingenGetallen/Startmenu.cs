using System;
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
    public partial class Startmenu : Form
    {
        public Startmenu()
        {
            InitializeComponent();
        }

        private void btnOptellen_Click(object sender, EventArgs e)
        {
            // aanmaken nieuw formulier
            FrmOptellen nieuwFrm = new FrmOptellen();
            // Hiden oud form
            Hide();

            // tonen nieuw form
            nieuwFrm.ShowDialog();

            // tonen oud form
            Show(); 
        }

        private void btnVermenigvuldigen_Click(object sender, EventArgs e)
        {
            // aanmaken nieuw formulier
            FrmVermenigvuldigen nieuwFrm = new FrmVermenigvuldigen();
            // Hiden oud form
            Hide();

            // tonen nieuw form
            nieuwFrm.ShowDialog();

            // tonen oud form
            Show();
        }

        private void btnVerminderen_Click(object sender, EventArgs e)
        {
            // aanmaken nieuw formulier
            FrmVerminderen nieuwFrm = new FrmVerminderen();
            // Hiden oud form
            Hide();

            // tonen nieuw form
            nieuwFrm.ShowDialog();

            // tonen oud form
            Show();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            // Afsluiten 
            Close();
        }
    }
}
