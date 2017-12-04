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
        bool fermeture = false;
        public FMesFrais()
        {
            InitializeComponent();
        }

        private void linkSaisieFrais_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ficheDeFrais fs = new ficheDeFrais();
            //menu.MdiParent = this;
            fs.Show();
            this.Hide();
        }

        private void FMesFrais_Load(object sender, EventArgs e)
        {
            tbVisiteur.Text = Modele.MonVisiteur.nom + " " + Modele.MonVisiteur.prenom;
            tbMatricule.Text = Modele.MonVisiteur.idVisiteur;

            for (int j = 11; j >= 0; j--)
            {
                cbMois.Items.Add(DateTime.Now.AddMonths(-j).ToString("MM") + "/" + DateTime.Now.AddMonths(-j).ToString("yy") + " ");
            }
            cbMois.Text = DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("yy") + " ";
            Modele.Mois1 = cbMois.Text;


        }


        private void chargement()
        {
            dgvAutresFrais.DataSource = null;
            var LQueryTest = Modele.MaConnexion.fichefrais.ToList()
                .Where(x => x.idVisiteur == Modele.MonVisiteur.idVisiteur && x.mois == cbMois.Text)
                .Select(x => new { x.Etat.libelle });
            if (LQueryTest.Count() > 0)
            {
                bsFraisForfaitaires.DataSource = LQueryTest;
                dgvFraisForfaitaires.DataSource = bsFraisForfaitaires;
                tbEtat.Text = dgvFraisForfaitaires.Rows[0].Cells[0].Value.ToString();
            }
            else { tbEtat.Text = "Fiche non créée"; }

            var LQuery = Modele.MaConnexion.LigneFraisForfait.ToList()
                .Where(x => x.idVisiteur == Modele.MonVisiteur.idVisiteur && x.idFraisForfait == x.FraisForfait.id && x.mois == cbMois.Text)
                .Select(x => new { x.FraisForfait.libelle, x.idFraisForfait, x.quantite, x.FraisForfait.montant, test = x.quantite * x.FraisForfait.montant, x.fichefrais.idEtat });

            bsFraisForfaitaires.DataSource = LQuery;

            dgvFraisForfaitaires.DataSource = bsFraisForfaitaires;
            dgvFraisForfaitaires.Columns[0].HeaderText = "Frais Forfaitaires";
            dgvFraisForfaitaires.Columns[1].Visible = false;
            dgvFraisForfaitaires.Columns[2].HeaderText = "Quantité";
            dgvFraisForfaitaires.Columns[3].HeaderText = "Montant unitaire";
            dgvFraisForfaitaires.Columns[4].HeaderText = "Total";
            dgvFraisForfaitaires.Columns[5].Visible = false;

            float total = 0;
            for (int j = 0; j < dgvFraisForfaitaires.Rows.Count; j++)
            {
                total += float.Parse(dgvFraisForfaitaires.Rows[j].Cells[4].Value.ToString());
            }
            lbTotal.Text = total.ToString();
            var LQuery2 = Modele.MaConnexion.LigneFraisHorsForfait.ToList()
                .Where(x => x.idVisiteur == Modele.MonVisiteur.idVisiteur && x.mois == cbMois.Text)
                .Select(x => new { x.id, x.date, x.libelle, x.montant });

            bsAutresFrais.DataSource = LQuery2;
            dgvAutresFrais.DataSource = bsAutresFrais;
            dgvAutresFrais.Columns[0].Visible = false;
            dgvAutresFrais.Columns[1].HeaderText = "Date";
            dgvAutresFrais.Columns[2].HeaderText = "Libellé";
            dgvAutresFrais.Columns[3].HeaderText = "Montant";
        }
        private void cbMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargement();

        }


        private void btnAjout_Click(object sender, EventArgs e)
        {
           
        }

        private void btnModifFraisForfait_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            try
            {
                var filteredData = Modele.MaConnexion.LigneFraisHorsForfait.ToList()
   .Where(x => x.id == (int.Parse(dgvAutresFrais.SelectedRows[0].Cells[0].Value.ToString())));
                if (filteredData.Count() > 0)
                {
                    BindingSource bsMaLigne = new BindingSource();
                    bsMaLigne.DataSource = filteredData; // application du filtre
                    LigneFraisHorsForfait maLigne = new LigneFraisHorsForfait();
                    bsMaLigne.MoveFirst();
                    maLigne = (LigneFraisHorsForfait)bsMaLigne.Current;
                    Modele.MaConnexion.LigneFraisHorsForfait.Remove(maLigne);
                    Modele.MaConnexion.SaveChanges();
                    chargement();
                    MessageBox.Show("Ligne supprimé");
                }
                else
                {
                    MessageBox.Show("Aucune ligne sélectionnée");
                }
            }
            catch
            {
                MessageBox.Show("Aucune ligne sélectionnée");
            }
        }

        private void btnSupprimerForfait_Click(object sender, EventArgs e)
        {
           
        }
        private void FormulaireVisiteurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            fermeture = true;
        }
        private void retour_Click(object sender, EventArgs e)
        {
            fermeture = true;
            this.Close();
        }
    }
}
