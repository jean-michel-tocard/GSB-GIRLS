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
    public partial class FModif : Accueil
    {
        private GSBgirls maConnexion;
        private Visiteur levisiteur;
        bool fermeture = false;
        public FModif()
        {
            InitializeComponent();
            maConnexion = new GSBgirls();
            bsVisiteurs.DataSource = maConnexion.Visiteur.ToList();
        }

        private void FModif_FormClosing(object sender, FormClosingEventArgs e)
        {
            fermeture = true;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
              var filteredData = Modele.MaConnexion.Visiteur.ToList()
             .Where(x => x.idVisiteur == dgvVisiteurs.SelectedRows[0].Cells[6].Value.ToString());

              BindingSource bs= new BindingSource();
              bs.DataSource = filteredData; // application du filtre
              bs.MoveFirst();

              Visiteur monVisiteur = (Visiteur)bs.Current;

              FModifVisiteur fmodifvisiteur = new FModifVisiteur(monVisiteur);
              fmodifvisiteur.Show();
        }

        private void FModif_Load(object sender, EventArgs e)
        {
            bsVisiteurs.DataSource = maConnexion.Visiteur.ToList();

            if (fermeture) return;
            var LQuery = maConnexion.Visiteur.ToList()/*.Where(x => x.idVisiteur == dgvVisiteurs.SelectedRows[0].Cells[5].Value.ToString())*/.Select(x => new
            {
                x.nom,
                x.prenom,
                x.rue,
                x.cp,
                x.ville,
                x.identifiant,
                x.idVisiteur
            }).OrderBy(x => x.nom);

             bsVisiteurs.DataSource = LQuery;
            //bsVisiteurs.DataSource = maConnexion.Visiteur.OrderBy(x=>x.nom).ToList();
            
            dgvVisiteurs.DataSource = bsVisiteurs;
            
            dgvVisiteurs.Columns[0].HeaderText = "Nom";
            dgvVisiteurs.Columns[1].HeaderText = "Prénom";
            dgvVisiteurs.Columns[2].HeaderText = "Adresse";
            dgvVisiteurs.Columns[3].HeaderText = "Code Postal";
            dgvVisiteurs.Columns[4].HeaderText = "Ville";
            dgvVisiteurs.Columns[5].HeaderText = "Identifiant";
            
            dgvVisiteurs.Columns[6].Visible = false;
            dgvVisiteurs.Rows[0].Selected = true;
        }

        private void retour_Click(object sender, EventArgs e)
        {
            FMenu menu = new FMenu(maConnexion, levisiteur);
            //menu.MdiParent = this;
            menu.Show();
            this.Hide();
        }
    }
}

