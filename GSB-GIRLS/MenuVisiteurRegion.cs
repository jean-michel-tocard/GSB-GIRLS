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
    public partial class MenuVisiteurRegion : Form
    {
        public MenuVisiteurRegion()
        {
            InitializeComponent();
        }

        private void gestionDesComptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCompte gc = new GestionCompte();
            //menu.MdiParent = this;
            gc.Show();
        }

        private void informationsRégionsEtSecteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRS rs = new FrmRS();
            rs.Show();
        }
    }
}
