using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace GSB_GIRLS
{
    public partial class CreationRapport : Form
    {
        private GSBgirls maConnexion;
        private Visiteur levisiteur;
        // creation des proprietés nessecaire a la création d'un Rapport 
        MOTIF leMotif;
        RAPPORT leRapport;
        MEDECIN leMedecin;
        OFFRIR lOffre;
        MEDICAMENT leMedicament;
        public CreationRapport(GSBgirls MaConnexion, Visiteur Levisiteur)
        {
            InitializeComponent();
            maConnexion = MaConnexion;
            levisiteur = Levisiteur;

            // requete  de recuperation  d'element dans la base de donnée
            var reqMedecin = from M in maConnexion.MEDECIN
                             select M;


            var reqMotif = from Mo in maConnexion.MOTIF
                           select Mo;


            var reqmedi = from M in maConnexion.MEDICAMENT
                          select M;
            // recuperation des requete effectuer et affectation du champ selectionner dans la combobox
            this.cbMedecin.DisplayMember = "Patronyme";
            cbMedecin.DataSource = ((ObjectQuery)(reqMedecin));

            this.cbMed.DisplayMember = "nomCommercial";
            cbMed.DataSource = ((ObjectQuery)(reqmedi));

            this.cbMotif.DisplayMember = "libMotif";
            cbMotif.DataSource = ((ObjectQuery)(reqMotif));

        }

        private void CreationRapport_Load(object sender, EventArgs e)
        {
            lbInformation.Text = "Utilisateur Connecté  : " + levisiteur.nom + "  " + levisiteur.prenom;
        }

        private void cbMotif_SelectedIndexChanged(object sender, EventArgs e)
        {
            // recuperation du motif actuellement selectionné par  l'utilisateur
            MOTIF unMotif = (MOTIF)this.cbMotif.SelectedItem;
            leMotif = unMotif;
        }

        private void cbMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            // recuperation du medecin, actuellement selectionné par  l'utilisateur
            MEDECIN unMedecin = (MEDECIN)this.cbMedecin.SelectedItem;
            leMedecin = unMedecin;
        }

        private void cbMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            MEDICAMENT unMedicament = (MEDICAMENT)this.cbMed.SelectedItem;
            leMedicament = unMedicament;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment enregistrer ?";
            string caption = "Vôtre enregistrestrement à été pris en compte  fermeture de fenêtre";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Affichage de la boîte de dialogue 
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Affecter();
                maConnexion.RAPPORT.Add(leRapport);
                //maConnexion.AddObject("RAPPORT", leRapport)
                maConnexion.OFFRIR.Add(lOffre);
                //maConnexion.AddObject("OFFRIR", lOffre);// ajout a la base de données
                this.maConnexion.SaveChanges();                 // sauvegarde l'ajout dans la base de donnees
                /* Si l'utilisateur confirme en cliquant sur Yes */
                /* fermeture de l'application, libération des ressources */
                this.Close();// Pour quitter l'application
            }
        
        }
        public void Affecter()
        {
            leRapport = new RAPPORT();
            lOffre = new OFFRIR();

            // affectatoion des proprieter a l'objet rapport et offrir
            leRapport.dateRapport = dtpDate.Value;
            leRapport.idMotif = leMotif.idMotif;
            leRapport.bilan = txtBilan.Text;
            leRapport.idVisiteur = levisiteur.idVisiteur;
            leRapport.idMedecin = leMedecin.idMedecin;
            lOffre.idRapport = leRapport.idRapport;
            lOffre.idMedicament = leMedicament.idMedicament;
            lOffre.quantite = Convert.ToInt32(txtQuantMed.Text);
        }
    }
}
