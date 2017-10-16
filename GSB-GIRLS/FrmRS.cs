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
    public partial class FrmRS : Accueil
    {

        private GSBgirls maConnexion;

        public FrmRS()
        {
            InitializeComponent();
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new GSBgirls();
            /* le  bindingSourcebsVisiteur est connecté à la table Visiteur de la BDD  via la chaîne de connexion */
            bsSecteur.DataSource = maConnexion.Visiteur.ToList();
        }

        private void bsecteur_Click(object sender, EventArgs e)
        {
            var LQuery = Modele.MaConnexion.Secteur.ToList();

            bsSecteur.DataSource = LQuery;
            dgvSecteur.DataSource = bsSecteur;
            dgvSecteur.Columns[0].HeaderText = "NOM";
            dgvSecteur.Columns[1].HeaderText = "PRENOM";
            dgvSecteur.Columns[2].HeaderText = "STYLE";
            dgvSecteur.Columns[3].HeaderText = "Né le";
            dgvSecteur.Columns[4].HeaderText = "Mort le";
            dgvSecteur.Columns[5].HeaderText = "Informations";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuVisiteurRegion menuv = new MenuVisiteurRegion();
            menuv.Show();
            this.Hide();
        }
    }
}
