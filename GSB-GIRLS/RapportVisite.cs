using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace GSB_GIRLS
{
    public partial class RapportVisite : Accueil
    {
        private GSBgirls maConnexion;
        private Visiteur levisiteur;
        int ceIdRapport;
        private bool finchargement = false;
        public RapportVisite(GSBgirls MaConnexion, Visiteur Levisiteur)
        {
            InitializeComponent();
            maConnexion = MaConnexion;
            levisiteur = Levisiteur;
        }

        private void cbNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!finchargement) return;
            RAPPORT ceRapport = (RAPPORT)this.cbNum.SelectedItem;
            ceIdRapport = ceRapport.idRapport;

            var reqOffrir = from O in maConnexion.OFFRIR
                            join R in maConnexion.RAPPORT on O.idRapport equals R.idRapport
                            join M in maConnexion.MEDICAMENT on O.idMedicament equals M.idMedicament
                            where O.idRapport == ceIdRapport
                            select new { M.nomCommercial, O.quantite };
            var reqRapport = from R in maConnexion.RAPPORT

                             join M in maConnexion.MEDECIN on R.idMedecin equals M.idMedecin
                             join Mo in maConnexion.MOTIF on R.idMotif equals Mo.idMotif
                             join O in maConnexion.OFFRIR on R.idRapport equals O.idRapport
                             join Me in maConnexion.MEDICAMENT on O.idMedicament equals Me.idMedicament

                             where R.idRapport == ceIdRapport

                             orderby R.idRapport
                             select new { R.idRapport, M.nom, M.prenom, Mo.libMotif, R.dateRapport, R.bilan, Me.nomCommercial, O.quantite};


            
            this.cbMedicament.DisplayMember = "nomCommercial";
           // cbMedicament.DataSource = ((ObjectQuery)(reqOffrir));
            cbMedicament.DataSource = reqOffrir.ToList();
            //this.dgvRapport.DataSource = ((ObjectQuery)(reqRapport));
            this.dgv_Rapport.DataSource = reqRapport.ToList();



            // Appliquer des styles par défaut aux données du dataGridview
            dgv_Rapport.DefaultCellStyle.BackColor = Color.Bisque;
            dgv_Rapport.DefaultCellStyle.Font = new Font("Calibri", 9);
            dgv_Rapport.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // les ajouts et suppressions sont interdits
            dgv_Rapport.AllowUserToAddRows = false;
            dgv_Rapport.AllowUserToDeleteRows = false;

            dgv_Rapport.Columns[0].HeaderText = "ID";
            dgv_Rapport.Columns[1].HeaderText = "Nom";
            dgv_Rapport.Columns[2].HeaderText = "Prenom";
            dgv_Rapport.Columns[3].HeaderText = "libellé";
            dgv_Rapport.Columns[4].HeaderText = "Date";
            dgv_Rapport.Columns[5].HeaderText = "Bilan";
            dgv_Rapport.Columns[6].HeaderText = "Nom Commercial";
            dgv_Rapport.Columns[7].HeaderText = "Quantité";

            // les colonnes sont redimensionnées automatiquement, le nom est mis en gras
            dgv_Rapport.AutoResizeColumns();
            dgv_Rapport.Columns[1].Width = 120;
            dgv_Rapport.Columns[1].DefaultCellStyle.Font = new Font("Calibri", 9, FontStyle.Bold);
            dgv_Rapport.Columns[2].Width = 120;
            var ceVisiteur = this.dgv_Rapport.CurrentRow;


            int idRapport = (Convert.ToInt32(ceVisiteur.Cells[0].Value));
            string nomMedecin = (Convert.ToString(ceVisiteur.Cells[1].Value).Trim()); // .Trim() = supprime les blancs inutiles
            string prenomMedecin = (Convert.ToString(ceVisiteur.Cells[2].Value).Trim());
            string libMotif = Convert.ToString(ceVisiteur.Cells[3].Value);
            string dateRapport = Convert.ToString(ceVisiteur.Cells[4].Value);
            string bilan = Convert.ToString(ceVisiteur.Cells[5].Value);
            string medicament = Convert.ToString(ceVisiteur.Cells[6].Value);
            string quantite = Convert.ToString(ceVisiteur.Cells[7].Value);


            txtPrenom.Text = prenomMedecin;
            txtNumero.Text = (Convert.ToString(idRapport));
            txtNom.Text = nomMedecin;
            txtDate.Text = dateRapport;
            txtMotif.Text = libMotif;
            txtBilan.Text = bilan;
            txtQuantite.Text = quantite;
            cbMedicament.Text = medicament;
        }

        private void RapportVisite_Load(object sender, EventArgs e)
        {
            
            var reqRap = from R in maConnexion.RAPPORT
                         orderby R.idRapport
                         where R.idVisiteur == levisiteur.idVisiteur
                         select R;

            try
            {
                this.cbNum.DisplayMember = "idRapport";

               // this.cbNum.DataSource = ((ObjectQuery)(reqRap)).Execute(MergeOption.AppendOnly);
                this.cbNum.DataSource = reqRap.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finchargement = true;

            // information utilisateur 
            lbInformation.Text = "Utilisateur Connecté  : " + levisiteur.nom + "  " + levisiteur.prenom;

        }

        private void dgvRapport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRapport(object sender, DataGridViewCellMouseEventArgs e)
        {
              
            
        }
    }
}
