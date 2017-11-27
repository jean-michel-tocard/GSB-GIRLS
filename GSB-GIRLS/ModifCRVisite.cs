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
    public partial class ModifCRVisite : Accueil
    {
        private GSBgirls maConnexion;
        private Visiteur levisiteur;
        int idMedecin;
        int ceIdRapport;
        RAPPORT ceRapport;
        int idMotif;
        public ModifCRVisite(GSBgirls MaConnexion, Visiteur Levisiteur)
        {
            InitializeComponent();
            InitializeComponent();
            maConnexion = MaConnexion;
            levisiteur = Levisiteur;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* if (fermeture) return;
            var LQuery = Modele.MaConnexion.MEDECIN.ToList()
                           .Where(x => x.idStyle == int.Parse(cboPracticien.SelectedValue.ToString()));*/

        }

        private void CRVisite_Load(object sender, EventArgs e)
        {
            bsRapport.DataSource = maConnexion.RAPPORT;

            Afficher();
        }
        public void modifier()
        {
            cbMotif.Text = ceRapport.MOTIF.libMotif;
            cbNom.Text = ceRapport.MEDECIN.nom;

        }
        public void Afficher()
        {

            //requete vers base de donnees 
            var reqRapport = from R in maConnexion.RAPPORT

                             join M in maConnexion.MEDECIN on R.idMedecin equals M.idMedecin
                             join Mo in maConnexion.MOTIF on R.idMotif equals Mo.idMotif
                             join O in maConnexion.OFFRIR on R.idRapport equals O.idRapport
                             join Me in maConnexion.MEDICAMENT on O.idMedicament equals Me.idMedicament
                             where R.idVisiteur == levisiteur.idVisiteur
                             orderby R.idRapport
                             select new { R.idRapport, M.nom, M.prenom, Mo.libMotif, R.dateRapport, R.bilan };





            // this.dgvRapport.DataSource = ((ObjectQuery)(reqRapport));
            dgv_Rapport.DataSource = reqRapport.ToList();
            dgv_Rapport.Columns[0].HeaderText = "idRapport";
            dgv_Rapport.Columns[1].HeaderText = "nom Medecin";
            dgv_Rapport.Columns[2].HeaderText = "prenom Medecin";
            dgv_Rapport.Columns[3].HeaderText = "libMotif";
            dgv_Rapport.Columns[4].HeaderText = "dateRapport";
            dgv_Rapport.Columns[5].HeaderText = "bilan";
            dgv_Rapport.Columns[6].HeaderText = "etatRapport";

            ceRapport = (RAPPORT)this.bsRapport.Current;

            // on protège certaines zones non modifiables 
            


            var reqRapport2 = from R in maConnexion.RAPPORT
                              where R.idVisiteur == levisiteur.idVisiteur
                              select R;



            var reqMedecin = from M in maConnexion.MEDECIN
                             orderby M.nom
                             select M;
            var reqMotif = from Mo in maConnexion.MOTIF


                           select Mo;

            //bsRapport.DataSource = ((ObjectQuery)(reqRapport2));
            bsRapport.DataSource = reqRapport2.ToList();
            //txt_motif.ReadOnly = true;
            txtPrenom.ReadOnly = true;

            // on charge les infos dans les zones de texte
            this.cbNom.DisplayMember = "nom";
            cbNom.DataSource = ((ObjectQuery)(reqMedecin));

            this.cbMotif.DisplayMember = "libMotif";
            cbMotif.DataSource = ((ObjectQuery)(reqMotif));

            //    txt_nom.Text = ceRapport.Visiteur.nom;
            //    txt_prenom.Text = ceRapport.Visiteur.prenom;
            //  txt_motif.Text = ceRapport.MOTIF.libMotif;          
            //    txt_bilan.Text = ceRapport.bilan; 



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ID,Nom,Prenom,IDspec,adresse");
        }

        private void Modif_Click(object sender, EventArgs e)
        {
            Affecter();
            this.maConnexion.SaveChanges();
            Afficher();
            modifier();
        }
        // Méthode pour affecter les valeurs saisies aux champs de l'enregistrement avant son ajout ou sa mise à jour
        public void Affecter()
        {

            ceRapport = (RAPPORT)this.bsRapport.Current;

            ceRapport.idMotif = idMotif;
            ceRapport.bilan = rtxtBilan.Text;
            ceRapport.idMedecin = idMedecin;
            //  if (cbCloturer.Checked) { ceRapport.etatRapport = true; }

        }

        private void dgvRapport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ceVisiteur = this.dgv_Rapport.CurrentRow;


            int idRapport = (Convert.ToInt32(ceVisiteur.Cells[0].Value));
            string nomMedecin = (Convert.ToString(ceVisiteur.Cells[1].Value).Trim()); // .Trim() = supprime les blancs inutiles
            string prenomMedecin = (Convert.ToString(ceVisiteur.Cells[2].Value).Trim());
            string libMotif = Convert.ToString(ceVisiteur.Cells[3].Value);
            string dateRapport = Convert.ToString(ceVisiteur.Cells[4].Value);
            string bilan = Convert.ToString(ceVisiteur.Cells[5].Value);
            


            rtxtBilan.Text = bilan;
            cbMotif.Text = libMotif;
            txtPrenom.Text = prenomMedecin;
            cbNom.Text = nomMedecin;
         //   if (cloturer) { cbCloturer.Checked = true; txtCloturer.Text = "Votre rapport est cloturé impossible \n de modifier  "; } else { cbCloturer.Checked = false; txtCloturer.Text = "Non cloturé"; }






        }

        private void cbNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var reqMedecin = from M in maConnexion.MEDECIN
                             where M.idMedecin == ceRapport.idMedecin
                             orderby M.nom
                             select M;




            MEDECIN unMedecin = (MEDECIN)this.cbNom.SelectedItem;
            idMedecin = unMedecin.idMedecin;
            txtPrenom.Text = unMedecin.prenom;


        }
        private void dgvRapport_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var ceVisiteur = this.dgv_Rapport.CurrentRow;


            int idRapport = (Convert.ToInt32(ceVisiteur.Cells[0].Value));
            string nomMedecin = (Convert.ToString(ceVisiteur.Cells[1].Value).Trim()); // .Trim() = supprime les blancs inutiles
            string prenomMedecin = (Convert.ToString(ceVisiteur.Cells[2].Value).Trim());
            string libMotif = Convert.ToString(ceVisiteur.Cells[3].Value);
            string dateRapport = Convert.ToString(ceVisiteur.Cells[4].Value);
            string bilan = Convert.ToString(ceVisiteur.Cells[5].Value);


            rtxtBilan.Text = bilan;
            cbMotif.Text = libMotif;
            txtPrenom.Text = prenomMedecin;
            cbNom.Text = nomMedecin;
          //  if (cloturer) { cbCloturer.Checked = true; txtCloturer.Text = "Vôtre rapport est cloteré impossible \n de modifier  "; } else { cbCloturer.Checked = false; txtCloturer.Text = "Non cloturer"; }






        }

        private void cbMotif_SelectedIndexChanged(object sender, EventArgs e)
        {
            MOTIF unMotif = (MOTIF)this.cbMotif.SelectedItem;
            idMotif = unMotif.idMotif;
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            RAPPORT ceRapport = (RAPPORT)this.cbID.SelectedItem;
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
                             select new { R.idRapport, M.nom, M.prenom, Mo.libMotif, R.dateRapport, R.bilan, Me.nomCommercial, O.quantite };



           // this.cbMedicament.DisplayMember = "nomCommercial";
            // cbMedicament.DataSource = ((ObjectQuery)(reqOffrir));
            //cbMedicament.DataSource = reqOffrir.ToList();
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
            string bilan = Convert.ToString(ceVisiteur.Cells[5].Value);


            txtPrenom.Text = prenomMedecin;
            cbNom.Text = nomMedecin;
            cbMotif.Text = libMotif;
            rtxtBilan.Text = bilan;

        }
    }
}
