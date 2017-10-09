using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_GIRLS
{
    public partial class Menu : Accueil
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void gestionDesComptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCompte gc = new GestionCompte();
            //menu.MdiParent = this;
            gc.Show();
        }
    }
}
