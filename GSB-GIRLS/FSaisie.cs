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
            if (e.ColumnIndex == 1)
            {
                txtAjoutLibelle.Text = dgvAutreFrais.CurrentCell.Value.ToString();
                txtAjoutLibelle.Visible = true;
                txtAjoutLibelle.Parent = dgvAutreFrais;
                txtAjoutLibelle.Location = dgvAutreFrais.GetCellDisplayRectangle(e.ColumnIndex, dgvAutreFrais.CurrentCell.RowIndex, true).Location;
                txtAjoutLibelle.Show();
                txtAjoutLibelle.Focus();
            }

            if (e.ColumnIndex == 2)
            {
                nupAjoutMontant.Value = int.Parse(dgvAutreFrais.CurrentCell.Value.ToString());
                nupAjoutMontant.Visible = true;
                nupAjoutMontant.Parent = dgvAutreFrais;
                nupAjoutMontant.Location = dgvAutreFrais.GetCellDisplayRectangle(e.ColumnIndex, dgvAutreFrais.CurrentCell.RowIndex, true).Location;
                nupAjoutMontant.Show();
                nupAjoutMontant.Focus();
            }

        }

        private void dtpAjoutDate_Validated(object sender, EventArgs e)
        {
            dgvAutreFrais.CurrentCell.Value = dtpAjoutDate.Value.ToString("d");
            dtpAjoutDate.Visible = false;
        }
        private void txtAjoutLibelle_Validated(object sender, EventArgs e)
        {
            dgvAutreFrais.CurrentCell.Value = txtAjoutLibelle.Text;
            txtAjoutLibelle.Visible = false;
        }

        private void nupAjoutMontant_Validated(object sender, EventArgs e)
        {
            dgvAutreFrais.CurrentCell.Value = nupAjoutMontant.Value.ToString();
            nupAjoutMontant.Visible = false;
        }

        private void dgvAutreFrais_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = false;
            dgvAutreFrais.Rows[e.RowIndex].ErrorText = "";
            if (dgvAutreFrais.Rows[e.RowIndex].Cells[0].Value == null)
            {
                e.Cancel = true;
                dgvAutreFrais.Rows[e.RowIndex].ErrorText += "La date de ne peut pas être null\n";
            }
            if (dgvAutreFrais.Rows[e.RowIndex].Cells[1].Value.ToString() == "" || dgvAutreFrais.Rows[e.RowIndex].Cells[1].Value == null)
            {
                e.Cancel = true;
                dgvAutreFrais.Rows[e.RowIndex].ErrorText += "Le libellé ne peut pas être null\n";
            }
            if (dgvAutreFrais.Rows[e.RowIndex].Cells[2].Value.ToString() == "0" || dgvAutreFrais.Rows[e.RowIndex].Cells[2].Value == null)
            {
                e.Cancel = true;
                dgvAutreFrais.Rows[e.RowIndex].ErrorText += "le montant ne peut pas être null";
            }
        }

        //ajoute une ligne des frais hors forfaits
        private void btnAjouterLigne_Click(object sender, EventArgs e)
        { 
            if (dgvAutreFrais.RowCount > 0)
            {
                //dgvAutreFrais.RowValidating(dgvAutreFrais, new DataGridViewCellCancelEventArgs(1, dgvAutreFrais.RowCount - 1));
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

            string moisEnCour = DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("yy") + " ";

            // Fiche Frais
            fichefrais uneFiche = new fichefrais();
            uneFiche.idVisiteur = Modele.VisiteurConnect.idVisiteur.ToString();
            uneFiche.mois = moisEnCour;
            uneFiche.nbJustificatifs = 0;
            uneFiche.montantValide = 0;
            uneFiche.dateModif = DateTime.Now;
            uneFiche.idEtat = "CR";
            var ficheFrais = Modele.MaConnexion.fichefrais.ToList()
                    .Where(x => x.idVisiteur == Modele.VisiteurConnect.idVisiteur.ToString() && x.mois == moisEnCour);
            if (ficheFrais.Count() == 0)
            {
               // Modele.MaConnexion.fichefrais.AddObject(uneFiche);
            }
            else
            {
                ficheFrais.First().dateModif = DateTime.Now;
                ficheFrais.First().montantValide = 0;
            }


            // Nuitée
            if (nupQuantiteNuitee != null)
            {
                LigneFraisForfait unFrais = new LigneFraisForfait();
                unFrais.idVisiteur = Modele.VisiteurConnect.idVisiteur.ToString();
                unFrais.mois = moisEnCour;
                unFrais.idFraisForfait = "NUI";
                unFrais.quantite = int.Parse(nupQuantiteNuitee.Value.ToString());
                var ligneNuitee = Modele.MaConnexion.LigneFraisForfait.ToList()
                    .Where(x => x.idVisiteur == Modele.VisiteurConnect.idVisiteur.ToString() && x.mois == moisEnCour && x.idFraisForfait == "NUI");
                MessageBox.Show(ficheFrais.Count().ToString());
                if (ligneNuitee.Count() == 0)
                {
                    //Modele.MaConnexion.LigneFraisForfait.AddObject(unFrais);
                }
                else
                {
                    ligneNuitee.First().quantite = int.Parse(nupQuantiteNuitee.Value.ToString());
                }
            }
            Modele.MaConnexion.SaveChanges();
        }
    
         //annuler l'ajout des renseignements
        private void btnAnnule_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    }
