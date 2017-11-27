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
    public partial class FMesFrais : Form
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
                cboMois.DataSource = ffrais.mois;

                txtEtat.Text = ffrais.idEtat;
                txtMontant.Text = ffrais.montantValide.ToString();
                txtNbJustificatifs.Text = ffrais.nbJustificatifs.ToString();
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
