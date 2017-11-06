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


        }
        private void FrmRS_Load(object sender, EventArgs e)
        {
            cbSecteur.ValueMember = "idSecteur";//permet de stocker l'identifiant
            cbSecteur.DisplayMember = "libSecteur";
            bsSecteur.DataSource = Modele.MaConnexion.Secteur.ToList();
            cbSecteur.DataSource = bsSecteur;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FMenu menuv = new FMenu();
            menuv.Show();
            this.Hide();
        }
        
        private void cbSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            var LQuery = Modele.MaConnexion.Secteur.ToList()
                        .Where(x => x.idSecteur == int.Parse(cbSecteur.SelectedValue.ToString()))
                        .Select(x => new { x.Visiteur.nom, x.Visiteur.prenom });

            bsSecteur.DataSource = LQuery;
            dgvSecteur.DataSource = bsSecteur;
            dgvSecteur.Columns[0].HeaderText = "Nom du visiteur";
            dgvSecteur.Columns[1].HeaderText = "Prénom du visiteur";

        }


    }
}
