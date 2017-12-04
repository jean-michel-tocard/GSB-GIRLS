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
    public partial class FrmModifVisiteur : Accueil
    {
        private Visiteur vVisiteur;
        private GSBgirls maConnexion;

        public FrmModifVisiteur(Visiteur visite)
        {
            InitializeComponent();
            vVisiteur = visite;
            maConnexion = new GSBgirls();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            try
            {
                vVisiteur.nom = txtNom.Text;
                vVisiteur.prenom = txtPrenom.Text;
                vVisiteur.rue = txtAdresse.Text;
                vVisiteur.ville = txtVille.Text;
                vVisiteur.cp = txtCP.Text;
                vVisiteur.password = txtPass.Text;
                vVisiteur.identifiant = txtIdent.Text;
                vVisiteur.dateEmbauche = txtDateEmbauche.Text;

                Modele.MaConnexion.SaveChanges();
                MessageBox.Show("Modification réussie", "Action");

                FrmModif modif = new FrmModif();
                modif.Show();
                this.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Enregistrement d'une erreur : " + ex.ToString(), "Action");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler les modifications ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmModif modif = new FrmModif();
                modif.Show();
                this.Hide();
            }
            else
            {
                //
            }
        }

        private void FModifVisiteur_Load(object sender, EventArgs e)
        {
            bsVisiteur.DataSource = maConnexion.Visiteur.ToList();

            txtNom.Text = vVisiteur.nom;
            txtPrenom.Text = vVisiteur.prenom;
            txtAdresse.Text = vVisiteur.rue;
            txtVille.Text = vVisiteur.ville;
            txtCP.Text = vVisiteur.cp;
            txtPass.Text = vVisiteur.password;
            txtIdent.Text = vVisiteur.identifiant;
            txtDateEmbauche.Text = vVisiteur.dateEmbauche;
        }
    }
}
    



