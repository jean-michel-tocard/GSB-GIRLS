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
            bsvisiteurs.DataSource = maConnexion.Visiteur.ToList();
        }

        public static void ThreadProc()
        {
            Application.Run(new FMenu());
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
            var filteredData = maConnexion.Visiteur.ToList()
                           .Where(x => x.identifiant.Equals(txtIdent.Text));
            if (filteredData.ToList().Count == 0)
            {
                MessageBox.Show("Identifiant non valide");
            }
            else
            {

                bsvisiteurs.DataSource = filteredData; // application du filtre
                bsvisiteurs.MoveFirst();
                Visiteur monuser = (Visiteur)bsvisiteurs.Current;
                MD5 monMD5 = MD5.Create();
                string passwdCrypte = GetMd5Hash(monMD5, textMPD.Text);
                string pswdc = monuser.password.Substring(2); // Pbs de l'hexa 0x sur sqlserver
                if (pswdc.Equals(passwdCrypte) || monuser.password.Equals(passwdCrypte))
                {
                    MessageBox.Show("Vous êtes bien connecté !");
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                    t.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mot de passe non valide");
                }
            }

        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
