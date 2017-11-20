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
    public partial class CRVisite : Form
    {
        private GSBgirls maConnexion;
        private Visiteur levisiteur;
        int idMedecin;
        RAPPORT ceRapport;
        int idMotif;
        public CRVisite(GSBgirls MaConnexion, Visiteur Levisiteur)
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





            this.dgvRapport.DataSource = ((ObjectQuery)(reqRapport));

            dgvRapport.Columns[0].HeaderText = "idRapport";
            dgvRapport.Columns[1].HeaderText = "nom Medecin";
            dgvRapport.Columns[2].HeaderText = "prenom Medecin";
            dgvRapport.Columns[3].HeaderText = "libMotif";
            dgvRapport.Columns[4].HeaderText = "dateRapport";
            dgvRapport.Columns[5].HeaderText = "bilan";
            dgvRapport.Columns[6].HeaderText = "etatRapport";

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

            bsRapport.DataSource = ((ObjectQuery)(reqRapport2));

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
            var ceVisiteur = this.dgvRapport.CurrentRow;


            int idRapport = (Convert.ToInt32(ceVisiteur.Cells[0].Value));
            string nomMedecin = (Convert.ToString(ceVisiteur.Cells[1].Value).Trim()); // .Trim() = supprime les blancs inutiles
            string prenomMedecin = (Convert.ToString(ceVisiteur.Cells[2].Value).Trim());
            string libMotif = Convert.ToString(ceVisiteur.Cells[3].Value);
            string dateRapport = Convert.ToString(ceVisiteur.Cells[4].Value);
            string bilan = Convert.ToString(ceVisiteur.Cells[5].Value);
            bool cloturer = Convert.ToBoolean(ceVisiteur.Cells[6].Value);


            rtxtBilan.Text = bilan;
            cbMotif.Text = libMotif;
            txtPrenom.Text = prenomMedecin;
            cbNom.Text = nomMedecin;
         //   if (cloturer) { cbCloturer.Checked = true; txtCloturer.Text = "Votre rapport est cloteré impossible \n de modifier  "; } else { cbCloturer.Checked = false; txtCloturer.Text = "Non cloturé"; }






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
            var ceVisiteur = this.dgvRapport.CurrentRow;


            int idRapport = (Convert.ToInt32(ceVisiteur.Cells[0].Value));
            string nomMedecin = (Convert.ToString(ceVisiteur.Cells[1].Value).Trim()); // .Trim() = supprime les blancs inutiles
            string prenomMedecin = (Convert.ToString(ceVisiteur.Cells[2].Value).Trim());
            string libMotif = Convert.ToString(ceVisiteur.Cells[3].Value);
            string dateRapport = Convert.ToString(ceVisiteur.Cells[4].Value);
            string bilan = Convert.ToString(ceVisiteur.Cells[5].Value);
            bool cloturer = Convert.ToBoolean(ceVisiteur.Cells[6].Value);


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
    }
}
