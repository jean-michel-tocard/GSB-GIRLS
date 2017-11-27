﻿using System;
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




        private void FETATFRAIS_Load(object sender, EventArgs e)
        {
            //Set Value Matricule
            txtMatricule.Text = Modele.MonVisiteurConnecte.idVisiteur;

            //Set Value Nom
            txtNom.Text = Modele.MonVisiteurConnecte.nom + " " + Modele.MonVisiteurConnecte.prenom;
            //Set Value Date

            txtMois.Text = DateTime.Now.ToString("MMMM yyyy", CultureInfo.CreateSpecificCulture("fr-FR"));

            //Set Valu Typevehicule
            cboTypeVehicule.Text = cboTypeVehicule.Items[0].ToString();

            //Set Value MontantUnitaire
            var MontantUnitaire = Modele.MaConnexion.FraisForfait.ToList()
                .Where(x => x.id == "NUI")
                .Select(x => new { x.montant });
            nupMontantUnitaireNuitee.Value = decimal.Parse(MontantUnitaire.ElementAt(0).montant.ToString());

            MontantUnitaire = Modele.MaConnexion.FraisForfait.ToList()
                 .Where(x => x.id == "REP")
                 .Select(x => new { x.montant });
            nupMontantUnitaireRepasMidi.Value = decimal.Parse(MontantUnitaire.ElementAt(0).montant.ToString());

            MontantUnitaire = Modele.MaConnexion.FraisForfait.ToList()
                .Where(x => x.id == "ETP")
                .Select(x => new { x.montant });
            nupMontantUnitaireRelaisEtape.Value = decimal.Parse(MontantUnitaire.ElementAt(0).montant.ToString());

            nupMontantUnitaireKilometrage.Value = 0.52M;

            string moisEnCour = DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("yyyy");
            var ficheFrais = Modele.MaConnexion.fichefrais.ToList()
                .Where(x => x.idVisiteur == Modele.MonVisiteurConnecte.idVisiteur && x.mois == moisEnCour);
            //if (ficheFrais == null)
            fichefrais uneFiche = new fichefrais();
            uneFiche.idVisiteur = Modele.MonVisiteurConnecte.idVisiteur;
            uneFiche.mois = moisEnCour;
            uneFiche.nbJustificatifs = 0;
            uneFiche.montantValide = 0;
            uneFiche.dateModif = DateTime.Now;
            uneFiche.idEtat = "CR";
            Modele.MaConnexion.fichefrais.AddObject(uneFiche);
            Modele.MaConnexion.SaveChanges();
            int i = 0;
        }


        private void cbNuitee_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNuitee.Checked == true)
                nupQuantiteNuitee.Enabled = true;
            else
                nupQuantiteNuitee.Enabled = false;
        }

        private void cbRepasMidi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRepasMidi.Checked == true)
                nupQuantiteRepasMidi.Enabled = true;
            else
                nupQuantiteRepasMidi.Enabled = false;
        }

        private void cbRelaisEtape_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRelaisEtape.Checked == true)
                nupQuantiteRelaisEtape.Enabled = true;
            else
                nupQuantiteRelaisEtape.Enabled = false;
        }

        private void cbKilometrage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKilometrage.Checked == true)
            {
                nupQuantiteKilometrage.Enabled = true;
                cboTypeVehicule.Enabled = true;
            }
            else
            {
                nupQuantiteKilometrage.Enabled = false;
                cboTypeVehicule.Enabled = false;
            }
        }

        private void cboTypeVehicule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTypeVehicule.Text == "4CV Diesel")
            {
                nupMontantUnitaireKilometrage.Value = 0.52M;
                txtTotalKilometrage.Text = (nupQuantiteKilometrage.Value * nupMontantUnitaireKilometrage.Value).ToString();
            }
            if (cboTypeVehicule.Text == "5/6CV Diesel")
            {
                nupMontantUnitaireKilometrage.Value = 0.58M;
                txtTotalKilometrage.Text = (nupQuantiteKilometrage.Value * nupMontantUnitaireKilometrage.Value).ToString();
            }
            if (cboTypeVehicule.Text == "4CV Essence")
            {
                nupMontantUnitaireKilometrage.Value = 0.62M;
                txtTotalKilometrage.Text = (nupQuantiteKilometrage.Value * nupMontantUnitaireKilometrage.Value).ToString();
            }
            if (cboTypeVehicule.Text == "5/6CV Essence")
            {
                nupMontantUnitaireKilometrage.Value = 0.67M;
                txtTotalKilometrage.Text = (nupQuantiteKilometrage.Value * nupMontantUnitaireKilometrage.Value).ToString();
            }
        }

        private void nupQuantiteNuitee_ValueChanged(object sender, EventArgs e)
        {
            txtTotalNuitee.Text = (nupQuantiteNuitee.Value * nupMontantUnitaireNuitee.Value).ToString();
        }


        private void nupQuantiteRepasMidi_ValueChanged(object sender, EventArgs e)
        {
            txtTotalRepasMidi.Text = (nupQuantiteRepasMidi.Value * nupMontantUnitaireRepasMidi.Value).ToString();
        }

        private void nupQuantiteRelaisEtape_ValueChanged(object sender, EventArgs e)
        {
            txtTotalRelaisEtape.Text = (nupQuantiteRelaisEtape.Value * nupMontantUnitaireRelaisEtape.Value).ToString();
        }

        private void nupQuantiteKilometrage_ValueChanged(object sender, EventArgs e)
        {
            txtTotalKilometrage.Text = (nupQuantiteKilometrage.Value * nupMontantUnitaireKilometrage.Value).ToString();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAutreFrais_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dtpAjoutDate.Visible = true;
                dtpAjoutDate.Parent = dgvAutreFrais;
                dtpAjoutDate.Location = dgvAutreFrais.GetCellDisplayRectangle(e.ColumnIndex, dgvAutreFrais.CurrentCell.RowIndex, true).Location;
                dtpAjoutDate.Show();
                dtpAjoutDate.Focus();
            }


        }

        }

    }
