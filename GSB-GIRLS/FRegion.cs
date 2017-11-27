﻿using System;
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
    public partial class FRegion : Accueil
    {
        //private ArrayList list = new
        private GSBgirls maConnexion;
        private Visiteur levisiteur;
        public FRegion()
        {
            InitializeComponent();
            maConnexion = new GSBgirls();
            bsVisiteurs.DataSource = maConnexion.Visiteur.ToList();
            bsregion.DataSource = maConnexion.Region.ToList();

        }

        private void FRegion_Load(object sender, EventArgs e)
        {
            cboRegion.ValueMember = "idRegion"; // permet de stocker l'identifiant
            cboRegion.DisplayMember = "libRegion";
            bsregion.DataSource = maConnexion.Region.ToList();
            cboRegion.DataSource = bsregion;
        }
        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

           
           /* foreach (Region unVisiteur in Visiteur1)
            {

            }*/

         /*   var LQuery = maConnexion.Visiteur.ToList()
    .Where(x => x.idLabo == int.Parse(cboRegion.SelectedValue.ToString()))
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
            dgvVisiteurs.Columns[5].HeaderText = "Date d'embauche";*/


            /*   var FilteredData = Modele.MaConnexion.Region.ToList()
                              .Where(x => x.idRegion == int.Parse(cboRegion.SelectedValue.ToString()));
               BindingSource bs = new BindingSource();
               bs.DataSource = FilteredData;
               bs.MoveFirst();
               Region Region = (Region)bs.Current;
               textboxid.Text = Region.idVisiteur;

                var requete = Modele.MaConnexion.Region.ToList()
                    .Where(x => x.idVisiteur == x.Visiteur.idVisiteur);
                BindingSource bs1 = new BindingSource();
                bs1.DataSource = requete;
                bs1.MoveFirst();
                Region Region2 = (Region)bs.Current;
                textBoxnom.Text = Region2.Visiteur.nom;
               textBoxprenom.Text = Region2.Visiteur.prenom;
               textBoxrue.Text = Region2.Visiteur.rue;
               textBoxville.Text = Region2.Visiteur.ville;
               textBoxcp.Text = Region2.Visiteur.cp;*/

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
