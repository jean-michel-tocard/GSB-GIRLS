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
        private Visiteur levisiteur;

        public Connexion()
        {
            InitializeComponent();
            maConnexion = new GSBgirls();
            bsvisiteurs.DataSource = maConnexion.Visiteur.ToList();
        }

        public static void ThreadProc()
        {
            //Application.Run(new FMenu());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            string identifiant = txtIdent.Text;
            string mdp = txtmdp.Text;

            string leIdentifiant = Convert.ToString(txtIdent.Text);
            string lePasswd = Convert.ToString(txtmdp.Text);

            using (MD5 md5Hash = MD5.Create())
            {
                string motCrypte2 = GetMd5Hash(md5Hash, mdp);
                try
                {
                    var reqConnexion = from v in maConnexion.Visiteur
                                       where v.identifiant == identifiant && v.password == motCrypte2
                                       select v;


                    Visiteur unVisiteur = reqConnexion.FirstOrDefault();
                    if (unVisiteur != null)
                    {
                        this.levisiteur = unVisiteur;
                        //lblConnexion.Visible = true;
                        //btnValider.Visible = false;
                        //btnOK.Visible = true;

                        this.Hide();
                        FMenu fMenu = new FMenu(maConnexion, levisiteur);
                        fMenu.ShowDialog();

                    }
                    else
                    {
                        string message = "Erreur de saisie. Recommencez !";
                        string caption = "Vous n'êtes pas autorisé à vous connecter";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            txtIdent.Clear();
                            txtmdp.Clear();

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
