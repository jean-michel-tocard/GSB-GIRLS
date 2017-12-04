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
    public partial class FEditionFiche : Accueil
    {
        bool fermeture = false;
        public FEditionFiche()
        {
            InitializeComponent();
        }

        private void linkAccCompt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FCompta fparCompta = new FCompta();
            fparCompta.MdiParent = this;
            fparCompta.Show();

        }

        private void linkAccCompt_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FCompta fc = new FCompta();
            //menu.MdiParent = this;
            fc.Show();
            this.Show();
        }

        private void FormulaireVisiteurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            fermeture = true;
        }

        private void retour_Click(object sender, EventArgs e)
        {
            fermeture = true;
            this.Close();
        }
    }
}
