using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GSB_GIRLS
{
    public partial class Connexion : Accueil
    {
        private GSBgirls maConnexion;
        public Connexion()
        {
            InitializeComponent();
            maConnexion = new GSBgirls();
            bsuser.DataSource = maConnexion.Visiteur.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filteredData = maConnexion.Visiteur.ToList()
                         .Where(x => x.identifiant.Equals(txtID.Text));
            if (filteredData.ToList().Count == 0)
            {
                MessageBox.Show("Identifiant non valide");
            }
            else
            {
                bsuser.DataSource = filteredData; // application du filtre
                bsuser.MoveFirst();
                Visiteur monuser = (Visiteur)bsuser.Current;
                MD5 monMD5 = MD5.Create();
                string passwdCrypte = GetMd5Hash(monMD5, txtMDP.Text);
                string pswdc = monuser.password.Substring(2); // Pbs de l'hexa 0x sur sqlserver
                if (pswdc.Equals(passwdCrypte) || monuser.password.Equals(passwdCrypte))
                {
                   // MessageBox.Show("Connexion établie");

                    /*  var FilteredData = Modele.MaConnexion.Region.ToList()
                         .Where(x => x.idRegion == int.Parse(x.idVisiteur));*/

                  /*  if (int.Parse(Modele.UnSecteur.idVisiteur) == int.Parse(Modele.visiteurConnect.idVisiteur))
                    {*/
                        MenuVisiteurRegion menu = new MenuVisiteurRegion();
                        //menu.MdiParent = this;
                        menu.Show();
                        this.Hide();

                    /*  }

                      else
                      {
                          MenuSimple menuS = new MenuSimple();
                          //menu.MdiParent = this;
                          menuS.Show();
                      }*/
                }
                else
                {
                    MessageBox.Show("Mot de passe invalide");
                }
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

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
