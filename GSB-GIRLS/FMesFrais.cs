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
    public partial class FMesFrais : Accueil
    {
        public FMesFrais()
        {
            InitializeComponent();
        }

        private void linkSaisieFrais_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FSaisie fparSaisieFrais = new FSaisie();
            fparSaisieFrais.MdiParent = this;
            fparSaisieFrais.Show();
        }

        private void FMesFrais_Load(object sender, EventArgs e)
        {
            cboMois.ValueMember = "idVisiteur";
            cboMois.DisplayMember = "mois";
            bsMois.DataSource = Modele.MaConnexion.FraisForfait.ToList();
            cboMois.DataSource = bsMois;
        }

        private void cboMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var LQuery = Modele.MaConnexion.fichefrais.ToList()
                               .Where(x => x.idVisiteur == cboMois.SelectedValue.ToString());
                BindingSource bs = new BindingSource();
                bs.DataSource = LQuery;
                bs.MoveFirst();
                fichefrais ffrais = (fichefrais)bs.Current;
                LigneFraisHorsForfait lhf = (LigneFraisHorsForfait)bs.Current;
                cboMois.DataSource = ffrais.mois;
                //affiche etat montant nbjustificatifs
                txtEtat.Text = ffrais.idEtat;
                txtMontant.Text = ffrais.montantValide.ToString();
                txtNbJustificatifs.Text = ffrais.nbJustificatifs.ToString();
               
                // affiche dans la dgv les éléments forfaitisés            
                bsMois.DataSource = LQuery;
                dgvElementForfaitise.DataSource = bsMois;
                dgvElementForfaitise.Columns[0].HeaderText = "libelle";
                dgvElementForfaitise.Columns[1].HeaderText = "montant";
                dgvElementForfaitise.Columns[2].Visible = false;
                //afiche dans la dgv les éléments hors forfaits 
                dgvHorsForfait.DataSource = bsMois;
                dgvHorsForfait.Columns[0].HeaderText = lhf.libelle;
                dgvHorsForfait.Columns[1].HeaderText = lhf.date.ToString();
                dgvHorsForfait.Columns[2].HeaderText = lhf.montant.ToString();

            }
            catch
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNbJustificatifs_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
