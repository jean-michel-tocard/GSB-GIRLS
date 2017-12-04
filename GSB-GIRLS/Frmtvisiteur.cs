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
    
    public partial class Frmtvisiteur : Accueil
    {
        private GSBgirls maConnexion;
        private Visiteur levisiteur;
        bool fermeture = false;

        public Frmtvisiteur()
        {
            InitializeComponent();
            maConnexion = new GSBgirls();
            bsVisiteurs.DataSource = maConnexion.Visiteur.ToList();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            fermeture = true;
            this.Close();
        }

        private void FormulaireVisiteurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            fermeture = true;
        }

        private void FVisiteur_Load(object sender, EventArgs e)
        {
            bsVisiteurs.DataSource = maConnexion.Visiteur.ToList();
            var LQuery = maConnexion.Visiteur.ToList()
                .Select(x => new
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
    }
}
