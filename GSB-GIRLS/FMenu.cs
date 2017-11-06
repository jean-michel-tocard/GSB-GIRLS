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
    public partial class FMenu : Accueil
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void informationsRégionsEtSecteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRS rs = new FrmRS();
            rs.Show();
            this.Hide();
        }

        private void gestionCompte_Click(object sender, EventArgs e)
        {
            GestionCompte gc = new GestionCompte();
            //menu.MdiParent = this;
            gc.Show();
            this.Hide();
        }

        private void gestionVisiteur_Click(object sender, EventArgs e)
        {

        }

        private void laboratoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLabo labo = new FLabo();
            //menu.MdiParent = this;
            labo.Show();
            this.Hide();
        }

        private void regionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
