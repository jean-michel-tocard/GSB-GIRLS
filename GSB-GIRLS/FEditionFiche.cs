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
    public partial class FEditionFiche : Form
    {
        public FEditionFiche()
        {
            InitializeComponent();
        }

        private void linkSuiviFiche_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FSuiviFiche fparSuiviFiche = new FSuiviFiche();
            fparSuiviFiche.MdiParent = this;
            fparSuiviFiche.Show();
        }
    }
}
