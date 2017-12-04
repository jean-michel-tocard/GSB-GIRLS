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
    public partial class FAjoutVisiteur : Accueil
    {
        private GSBgirls maConnexion;

        public FAjoutVisiteur()
        {
            
            InitializeComponent();
            maConnexion = new GSBgirls();
        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            if(textId.Text.Length==0) { MessageBox.Show("Vous n'avez pas rempli l'id !");return; }
            try
            {
                

                var FilteredData = Modele.MaConnexion.Visiteur.ToList()
                            .Where(x => x.idVisiteur == textId.Text);

                

                if (FilteredData.ToList().Count>0)
                {
                    MessageBox.Show("Erreur, id déjà pris, veuillez corriger vos erreurs !");
                    
                }
                else {
                    Visiteur newVisiteur = new Visiteur();
                    newVisiteur.idVisiteur = textId.Text;
                    newVisiteur.nom = txtNom.Text;
                    newVisiteur.prenom = txtPrenom.Text;
                    newVisiteur.rue = txtAdresse.Text;
                    newVisiteur.cp = txtCP.Text;
                    newVisiteur.identifiant = txtIdent.Text;
                    newVisiteur.ville = txtVille.Text;
                    newVisiteur.dateEmbauche = txtDateEmbauche.Text;
                    MD5 monMD5 = MD5.Create();
                    newVisiteur.password = GetMd5Hash(monMD5, txtIdent.Text);
                    
                    if (textdroit.Text.Length == 0 || textidlabo.Text.Length == 0)
                    {
                        MessageBox.Show("Erreur, veuillez remplir le droit et idLabo !");
                        return;
                    }
                    else
                    {

                        newVisiteur.droit = int.Parse(textdroit.Text);
                        newVisiteur.idLabo = int.Parse(textidlabo.Text);
                    }

                    Modele.MaConnexion.Visiteur.Add(newVisiteur);

                    Modele.MaConnexion.SaveChanges();
                    MessageBox.Show("Ajout réussie", "Action");
                    FModif modif = new FModif();
                    modif.Show();
                    this.Hide();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Enregistrement d'une erreur : " + ex.ToString(), "Action");
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler l'ajout ? ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FModif modif = new FModif();
                modif.Show();
                this.Hide();
            }
            else
            {
                //
            }
        }

        static string GetMd5Hash(MD5 MonMD5, string PasswdSaisi)
        {
            // step 1, calculate MD5 hash from input

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = MonMD5.ComputeHash(inputBytes);
            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
