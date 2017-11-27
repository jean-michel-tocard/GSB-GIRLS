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
        private bool bLoad = true;
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
            cboChoixV.DisplayMember = "np";
             bsChoixV.DataSource = Modele.MaConnexion.Visiteur.OrderBy(x => x.nom).ThenBy(x=>x.prenom).ToList();
            cboChoixV.DataSource = bsChoixV;
            bLoad = false;
        }

        private void cboChoixV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bLoad) return;
            var LQuery = Modele.MaConnexion.fichefrais.ToList()
                           .Where(x => x.idVisiteur == cboChoixV.SelectedValue.ToString());
            BindingSource bs = new BindingSource();
            bs.DataSource = LQuery;
            bs.MoveFirst();
            fichefrais ffrais = (fichefrais)bs.Current;
            cboMois.DataSource =ffrais.mois;

        }

        private void cboMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }


    }
}
