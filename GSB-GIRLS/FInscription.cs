using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GSB_GIRLS
{
    public partial class FInscription : Form
    {
        private Visiteur visiteurConnecte;
        private string passwdCrypte;
        private DateTime date = DateTime.Now;
        private GSBgirls maConnexion;
        public FInscription()
        {
            InitializeComponent();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            if (txtMdp.Text == txtConfirmMDP.Text)
            {
                //instantion d'un nouveau visiteur vide
                Visiteur unVisiteur = new Visiteur();


                using (MD5 md5Hash = MD5.Create())
                {
                    // On crypte le mot de passe saisi en utilisant la méthode GetMD5Hash de la classe CRYPTAGE
                    this.passwdCrypte = CryptageMD5.GetMD5Hash(md5Hash, Convert.ToString(txtMdp.Text));
                }
                //affecte à chaque champ visiteur la valeur saisie

                unVisiteur.idVisiteur = txtID.Text;
                unVisiteur.nom = txtNom.Text;
                unVisiteur.prenom = txtPrenom.Text;
                unVisiteur.identifiant = txtIdent.Text;
                unVisiteur.password = this.passwdCrypte;
                unVisiteur.droit = Convert.ToInt32(txtDroit.Text);
                unVisiteur.idLabo = Convert.ToInt32(txtLabo.Text);
                unVisiteur.rue = txtRue.Text;
                unVisiteur.ville = txtVille.Text;
                unVisiteur.cp = txtCP.Text;
                unVisiteur.dateEmbauche = date.ToString("yyyy-MM-dd"); ;

                try
                {
                    //ajout du visiteur
                  this.maConnexion.Visiteur.Add(unVisiteur);
                    //sauvegarde
                    this.maConnexion.SaveChanges();
                    MessageBox.Show("Visiteur ajouté.");
                    MessageBox.Show(this.passwdCrypte);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }

            }
            else
                Console.WriteLine("Erreur de mot de passe!");
        }
    }
}
