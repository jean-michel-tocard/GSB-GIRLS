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
    public partial class FSaisie : Form
    {
        public FSaisie()
        {
            InitializeComponent();
        }

        private void linkMesFiches_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FMesFrais fparMesFrais = new FMesFrais();
            fparMesFrais.MdiParent = this;
            fparMesFrais.Show();
        }

        private void btnAjouter1_Click(object sender, EventArgs e)
        {
           
        }
    }
    
}
