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


        private void FSaisie_Load(object sender, EventArgs e)
        {
            //récupérer le matricule du visiteur
            txtMatricule.Text = Modele.VisiteurConnect.idVisiteur.ToString();

            //Récuperer Nom  du visiteur
            txtNom.Text = Modele.VisiteurConnect.nom + " " + Modele.VisiteurConnect.prenom;
           
               //récupérer Date
            txtMois.Text = DateTime.Now.ToString("MMMM yyyy");

            //recupérer Typevehicule
            cboTypeVehicule.Text = cboTypeVehicule.Items[0].ToString();

            //récupérer MontantUnitaire
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
                .Where(x => x.idVisiteur == Modele.VisiteurConnect.idVisiteur.ToString() && x.mois == moisEnCour);
            if (ficheFrais == null)
            {
                fichefrais uneFiche = new fichefrais();
                uneFiche.idVisiteur = Modele.VisiteurConnect.idVisiteur.ToString();
                uneFiche.mois = moisEnCour;
                uneFiche.nbJustificatifs = 0;
                uneFiche.montantValide = 0;
                uneFiche.dateModif = DateTime.Now;
                uneFiche.idEtat = "CR";
                Modele.MaConnexion.fichefrais.AddObject(uneFiche);
                Modele.MaConnexion.SaveChanges();

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
        //ajoute une ligne des frais hors forfaits
        private void btnAjouterLigne_Click(object sender, EventArgs e)
        { 
            if (dgvAutreFrais.RowCount > 0)
            {
                dgvAutreFrais.RowValidating(dgvAutreFrais, new DataGridViewCellCancelEventArgs(1, dgvAutreFrais.RowCount - 1));
                if (dgvAutreFrais.Rows[dgvAutreFrais.RowCount - 1].ErrorText == "")
                {
                    dgvAutreFrais.Rows.Add(new Object[] { dtpAjoutDate.Value.ToString("d"), "", "0" });
                }
            }
            else
            {
                dgvAutreFrais.Rows.Add(new Object[] { dtpAjoutDate.Value.ToString("d"), "", "0" });
            }
        
    }
       
        //ajout des renseignements
        private void btnAjouter1_Click(object sender, EventArgs e)
        {
           
        }
         //annuler l'ajout des rensiegnements
        private void btnAnnule_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    }
