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
    public partial class FrmLabo : Accueil
    {
        private GSBgirls maConnexion;
        private Visiteur levisiteur;
        bool fermeture = false;
        public FrmLabo()
        {
            InitializeComponent();
            maConnexion = new GSBgirls();
            bsVisiteurs.DataSource = maConnexion.Visiteur.ToList();
        }

        private void FormulaireVisiteurs_Load(object sender, EventArgs e)
        {
            cboLabo.ValueMember = "idLabo"; // permet de stocker l'identifiant
            cboLabo.DisplayMember = "nomLabo";
            bsLabo.DataSource = maConnexion.Laboratoire.ToList();
            cboLabo.DataSource = bsLabo;
        }

        private void cboLabo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fermeture) return;
            var LQuery = maConnexion.Visiteur.ToList()
                .Where(x => x.idLabo == int.Parse(cboLabo.SelectedValue.ToString()))
                .Select(x => new
            {
                x.nom,
                x.prenom,
                x.rue,
                x.cp,
                x.ville,
                x.dateEmbauche
            }).OrderBy(x => x.nom);

            bsVisiteurs.DataSource = LQuery;
            dgvVisiteurs.DataSource = bsVisiteurs;
            dgvVisiteurs.Columns[0].HeaderText = "Nom";
            dgvVisiteurs.Columns[1].HeaderText = "Prénom";
            dgvVisiteurs.Columns[2].HeaderText = "Adresse";
            dgvVisiteurs.Columns[3].HeaderText = "Code Postal";
            dgvVisiteurs.Columns[4].HeaderText = "Ville";
            dgvVisiteurs.Columns[5].HeaderText = "Date d'embauche";
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

