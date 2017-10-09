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
    public partial class FVisiteur : Form
    {
        public FVisiteur()
        {
            InitializeComponent();
        }

        private void linkSaisieFrais_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FSaisie fparSaisieFrais = new FSaisie();
            fparSaisieFrais.MdiParent = this;
            fparSaisieFrais.Show();
        }

    }
}
