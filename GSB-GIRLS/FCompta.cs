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
    public partial class FCompta : Form
    {
        public FCompta()
        {
            InitializeComponent();
        }

        private void linkEdition_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FEditionFiche fparEditionFiche = new FEditionFiche();
            fparEditionFiche.MdiParent = this;
            fparEditionFiche.Show();
        }

        private void FCompta_Load(object sender, EventArgs e)
        {
            cboChoixV.ValueMember = "idVisiteur";
            cboChoixV.DisplayMember = "nom"+"prenom";
            bsChoixV.DataSource = Modele.MaConnexion.Visiteur.ToList();
            cboChoixV.DataSource = bsChoixV;
        }

        private void cboChoixV_SelectedIndexChanged(object sender, EventArgs e)
        {
            var LQuery = Modele.MaConnexion.fichefrais.ToList()
                           .Where(x => x.idVisiteur == int.Parse(cboChoixV.SelectedValue.ToString()));
            BindingSource bs = new BindingSource();
            bs.DataSource = LQuery;
            bs.MoveFirst();
            fichefrais ffrais = (fichefrais)bs.Current;
            cboMois.DataSource = fichefrais.mois.ToString();

        }
    }
}
