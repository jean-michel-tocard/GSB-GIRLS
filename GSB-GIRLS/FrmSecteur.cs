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
    public partial class FrmSecteur : Accueil
    {
        // private ICollection<Visiteur> Visiteur1;
        private GSBgirls maConnexion;
        private Visiteur levisiteur;
        bool fermeture = false;
        public FrmSecteur()
        {
            // ICollection<Visiteur> Visiteur1 = new ICollection<Visiteur>();
            InitializeComponent();
            maConnexion = new GSBgirls();
            bsVisiteurs.DataSource = maConnexion.Visiteur.ToList();
            bssecteur.DataSource = maConnexion.Secteur.ToList();

        }

        private void FSecteur_Load(object sender, EventArgs e)
        {
            cboSecteur.ValueMember = "idSecteur"; // permet de stocker l'identifiant
            cboSecteur.DisplayMember = "libSecteur";
            bssecteur.DataSource = maConnexion.Secteur.ToList();
            cboSecteur.DataSource = bssecteur;
        }

        private void retour_Click(object sender, EventArgs e)
        {
            fermeture = true;
            this.Close();
        }

        private void FormulaireVisiteurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
            fermeture = true;
        }

        private void cboSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            var LQuery = Modele.MaConnexion.Secteur.ToList()
                           .Where(x => x.idSecteur == int.Parse(cboSecteur.SelectedValue.ToString()));
            //  Secteur monS = (Secteur)LQuery.First();
              //bsVisiteurs.DataSource = monS.Visiteur;
            bsVisiteurs.DataSource = LQuery;
            /*dgvVisiteurs.Columns[0].HeaderText = "Id";
            dgvVisiteurs.Columns[0].Visible = false;
            dgvVisiteurs.Columns[1].HeaderText = "Nom";
            dgvVisiteurs.Columns[2].HeaderText = "Prénom";
            dgvVisiteurs.Columns[3].HeaderText = "Adresse";
            dgvVisiteurs.Columns[4].HeaderText = "Code Postal";
            dgvVisiteurs.Columns[5].HeaderText = "Ville";
            dgvVisiteurs.Columns[6].HeaderText = "Date d'embauche";*/



            var FilteredData = Modele.MaConnexion.Secteur.ToList()
                           .Where(x => x.idSecteur == int.Parse(cboSecteur.SelectedValue.ToString()));
            BindingSource bs = new BindingSource();
            bs.DataSource = FilteredData;
            bs.MoveFirst();
            Secteur Secteur = (Secteur)bs.Current;
            // textboxid.Text = Region.idVisiteur;

            var requete = Modele.MaConnexion.Secteur.ToList()
                .Where(x => x.idVisiteur == x.Visiteur.idVisiteur);
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = requete;
            bs1.MoveFirst();
            Secteur Secteur2 = (Secteur)bs.Current;
            textBoxnom.Text = Secteur2.Visiteur.nom;
            textBoxprenom.Text = Secteur2.Visiteur.prenom;
            textBoxrue.Text = Secteur2.Visiteur.rue;
            textBoxville.Text = Secteur2.Visiteur.ville;
            textBoxcp.Text = Secteur2.Visiteur.cp;
        }
    }
}