using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;


namespace GSB_GIRLS
{
    public partial class FMenu : Accueil
    {
        private Visiteur levisiteur;
        private GSBgirls maConnexion;
        public FMenu(GSBgirls MaConnexion, Visiteur Levisiteur)
        {
            InitializeComponent();
            maConnexion = MaConnexion;
            levisiteur = Levisiteur;
        }

        private void informationsRégionsEtSecteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRS rs = new FrmRS();
            rs.Show();
            this.Hide();
        }

        private void gestionCompte_Click(object sender, EventArgs e)
        {

        }

        private void gestionVisiteur_Click(object sender, EventArgs e)
        {

        }

        private void laboratoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLabo labo = new FLabo();
            //menu.MdiParent = this;
            labo.Show();
            this.Hide();
        }

        private void regionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRegion region = new FRegion();
            //menu.MdiParent = this;
            region.Show();
            this.Hide();
        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FModif modif= new FModif();
            //menu.MdiParent = this;
            modif.Show();
            this.Hide();
        }

        private void msDonnées_Click(object sender, EventArgs e)
        {
            var req = from v in maConnexion.Visiteur

                      select v;
            //this.dgv_util.DataSource = ((ObjectQuery)(req));
            dgv_util.DataSource = req.ToList();
            // les ajouts et suppressions sont interdits
            dgv_util.AllowUserToAddRows = false;
            dgv_util.AllowUserToDeleteRows = false;

            // L'entête de colonne des autres champs sont modifiés
            if (levisiteur.droit == 1 || levisiteur.droit == null)
            {
                var requete = from v in maConnexion.Visiteur
                              orderby v.nom
                              where v.idVisiteur == levisiteur.idVisiteur
                              select v;
                //this.dgv_util.DataSource = ((ObjectQuery)(requete));
                dgv_util.DataSource = requete.ToList();
                dgv_util.Columns[0].HeaderText = "CodeVisiteur";
                dgv_util.Columns[1].HeaderText = "CodeLabo";
                dgv_util.Columns[2].HeaderText = "Nom";
                dgv_util.Columns[3].HeaderText = "Prenom";
                dgv_util.Columns[4].HeaderText = "Rue";
                dgv_util.Columns[5].HeaderText = "Code Postal";
                dgv_util.Show();
            }
            if (levisiteur.droit == 0 || levisiteur.droit == null)
            {
                var requete = from v in maConnexion.Visiteur
                              orderby v.nom
                              where v.idVisiteur == levisiteur.idVisiteur
                              select v;
                //this.dgv_util.DataSource = ((ObjectQuery)(requete));
                dgv_util.DataSource = requete.ToList();
                dgv_util.Columns[0].HeaderText = "CodeVisiteur";
                dgv_util.Columns[1].HeaderText = "CodeLabo";
                dgv_util.Columns[2].HeaderText = "Nom";
                dgv_util.Columns[3].HeaderText = "Prenom";
                dgv_util.Columns[4].HeaderText = "Rue";
                dgv_util.Columns[5].HeaderText = "Code Postal";
                dgv_util.Show();
            }

            if (levisiteur.droit == 2)
            {
                var requete = from v in maConnexion.Visiteur
                              orderby v.nom
                              where v.droit <= 2
                              select v;
                //this.dgv_util.DataSource = ((ObjectQuery)(requete));
                dgv_util.DataSource = requete.ToList();
                dgv_util.Columns[0].HeaderText = "CodeVisiteur";
                dgv_util.Columns[1].HeaderText = "CodeLabo";
                dgv_util.Columns[2].HeaderText = "Nom";
                dgv_util.Columns[3].HeaderText = "Prenom";
                dgv_util.Columns[4].HeaderText = "Rue";
                dgv_util.Columns[5].HeaderText = "Code Postal";
                dgv_util.Show();
            }
        }

        private void FMenu_Load(object sender, EventArgs e)
        {
            // information utilisateur 
            lbInformations.Text = "Utilisateur Connecté  : " + levisiteur.nom + "  " + levisiteur.prenom;
            // On cache le menu gestion utilisateur si l'utilisateur a le DROIT a 1
            if (levisiteur.droit == 0)
            {
               
                msGestionUser.Visible = false;
                
            }
                dgv_util.Hide();
                //msRapportVisite.Visible = false;
                msProfil.Visible = true;
            
        }

        private void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCompte gc = new GestionCompte();
            //menu.MdiParent = this;
            gc.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment quitter ?";
            string caption = "Fermeture de l'application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Affichage de la boîte de dialogue 
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Connexion con = new Connexion();
                
                con.Show();
                this.Hide();

                /* this.Close();
                 maConnexion.Dispose();  // Pour libérer la connexion à la base de données */
                /*Application.Exit();     // Pour quitter l'application    */
            }
            
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
           RapportVisite rv = new RapportVisite(maConnexion, levisiteur);
            rv.Show();
        }

        private void msAjouter_Click(object sender, EventArgs e)
        {
            CreationRapport crr = new CreationRapport(maConnexion, levisiteur);
            crr.ShowDialog();
        }

        private void msModifier_Click(object sender, EventArgs e)
        {
            ModifCRVisite mcrv = new ModifCRVisite(maConnexion, levisiteur);
            mcrv.ShowDialog();
        }

        private void lbInformations_Click(object sender, EventArgs e)
        {

        }
    }
}
