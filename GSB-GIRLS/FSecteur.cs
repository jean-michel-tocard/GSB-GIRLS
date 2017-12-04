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
    public partial class FSecteur : Accueil
    {
        // private ICollection<Visiteur> Visiteur1;
        private GSBgirls maConnexion;
        private Visiteur levisiteur;
        public FSecteur()
        {
            // ICollection<Visiteur> Visiteur1 = new ICollection<Visiteur>();
            InitializeComponent();
            maConnexion = new GSBgirls();
            bsVisiteurs.DataSource = maConnexion.Visiteur.ToList();
            bssecteur.DataSource = maConnexion.Region.ToList();

        }

        private void FRegion_Load(object sender, EventArgs e)
        {
            cboSecteur.ValueMember = "idSecteur"; // permet de stocker l'identifiant
            cboSecteur.DisplayMember = "libSecteur";
            bssecteur.DataSource = maConnexion.Region.ToList();
            cboSecteur.DataSource = bssecteur;
        }
        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

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