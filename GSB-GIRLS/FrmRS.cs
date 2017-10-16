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
            bsVisiteur.DataSource = maConnexion.Visiteur.ToList();
        }

        private void bLabo_Click(object sender, EventArgs e)
        {

            var LQuery = maConnexion.Visiteur.ToList();

            bsVisiteur.DataSource = LQuery;
            dgvVisiteur.DataSource = bsVisiteur;
            dgvVisiteur.Columns[0].HeaderText = "cp";

        }

        private void bsecteur_Click(object sender, EventArgs e)
        {
            
        

        }
    }
}
