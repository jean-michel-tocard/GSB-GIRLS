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

        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void msDonnées_Click(object sender, EventArgs e)
        {
            var req = from v in maConnexion.Visiteur

                      select v;
            this.dgv_util.DataSource = ((ObjectQuery)(req));

            // les ajouts et suppressions sont interdits
            dgv_util.AllowUserToAddRows = false;
            dgv_util.AllowUserToDeleteRows = false;
        
            // L'entête de colonne des autres champs sont modifiés
            if (levisiteur.droit == 1)
            {
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
                this.dgv_util.DataSource = ((ObjectQuery)(requete));

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
                this.dgv_util.DataSource = ((ObjectQuery)(requete));

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
            if (levisiteur.droit == 1)
            {
                msGestionUser.Visible = false;
            }

            dgv_util.Hide();
            //msRapportVisite.Visible = false;
            msProfil.Visible = false;
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
    }
}
