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
    public partial class ficheDeFrais : Accueil
    {
        bool fermeture = false;
        private string prixNUI, prixREP;
        private int nbFH = 0;
        public ficheDeFrais()
        {
            InitializeComponent();
        }




        private void ficheDeFrais_Load(object sender, EventArgs e)
        {
            
            tbVisiteur.Text = Modele.MonVisiteur.nom + " " + Modele.MonVisiteur.prenom;
            tbMatricule.Text = Modele.MonVisiteur.idVisiteur;
            cbTypeVehicule.Text = "4CV DIESEL";
            for (int j = 11; j >= 0; j--)
            {
                cbMois.Items.Add(DateTime.Now.AddMonths(-j).ToString("MM") + "/" + DateTime.Now.AddMonths(-j).ToString("yy") + " ");
            }
            cbMois.Text = Modele.Mois1;
            recupererPrix("NUI");
            recupererPrix("REP");
            if (Modele.Action == 1)
            {
                groupBox2.Visible = true;
                lbTypeVehicule.Visible = true;
                cbTypeVehicule.Visible = true;
                dgvFrais.Visible = false;
                gbFrais.Visible = false;
                button1.Text = "Ajouter";
            }
            if (Modele.Action == 2)
            {
                groupBox2.Visible = false;
                lbTypeVehicule.Visible = false;
                cbTypeVehicule.Visible = false;
                dgvFrais.Visible = true;
               gbFrais.Visible = true;
            }

        }
        private void recupererPrix(string monID)
        {

            var filteredData = Modele.MaConnexion.FraisForfait.ToList()
                      .Where(x => x.id == monID);

            bsFrais.DataSource = filteredData;
            bsFrais.MoveFirst();
            FraisForfait fraisForfait = (FraisForfait)bsFrais.Current;
            if (monID == "NUI")
            {
                prixNUI = fraisForfait.montant.ToString();
                tbMontantNuitée.Text = prixNUI;
            }
            else if (monID == "REP")
            {
                prixREP = fraisForfait.montant.ToString();
                tbMontantRepasMidi.Text = prixREP;
            }

        }

        private void textboxNuitée_TextChanged(object sender, EventArgs e)
        {
            tbTotalNuitée.Text = (double.Parse(tbQuantitéNuitée.Text) * double.Parse(prixNUI)).ToString();
        }

        private void textbox_Repas_TextChanged(object sender, EventArgs e)
        {
            tbTotalRepasMidi.Text = (double.Parse(tbMontantRepasMidi.Text) * double.Parse(tbQuantitéRepasMidi.Text)).ToString();
        }

        private void textbox_Kilo_TextChanged(object sender, EventArgs e)
        {
            tbTotalKilométrage.Text = (double.Parse(tbQuantitéKilométrage.Text) * double.Parse(tbMontantKilométrage.Text)).ToString();

        }



        private void btnRetour_Click(object sender, EventArgs e)
        {

            

        }

        private void cbTypeVehicule_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Modele.Action == 1)
            {
                ajoutBDD();
            }
            else if (Modele.Action == 2)
            {
                ajoutBDD();
                ajoutBDDHF();
            }
        }
        public void ajoutBDDHF()
        {
            var filtreddata2 = Modele.MaConnexion.fichefrais.ToList().Where(x => x.idVisiteur == "a17" && x.mois == cbMois.Text.Substring(0, 6));
            fichefrais Fiche = new fichefrais();
            Fiche = (fichefrais)filtreddata2.ElementAt(0);
            if (Fiche.idEtat == "CL")
            {
                MessageBox.Show("ERREUR : Fiche du mois de " + cbMois.Text + " cloturé.", "Action");
            }
            else
            {
                nbFH = 0;
                LigneFraisHorsForfait maLigne = new LigneFraisHorsForfait();
                maLigne.idVisiteur = Modele.MonVisiteur.idVisiteur;
                maLigne.mois = cbMois.Text.Substring(0, 6);
                if (dgvFrais.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvFrais.Rows)
                    {
                        DateTime now = DateTime.Today;
                        if (DateTime.Parse(row.Cells["Date"].Value.ToString()) > now.AddYears(-1) && DateTime.Parse(row.Cells["Date"].Value.ToString()) <= now)
                        {
                            maLigne.date = DateTime.Parse(row.Cells["Date"].Value.ToString());
                            maLigne.libelle = row.Cells["Libelle"].Value.ToString();
                            maLigne.montant = int.Parse(row.Cells["Montant"].Value.ToString());
                            Modele.MaConnexion.LigneFraisHorsForfait.Add(maLigne);
                            Modele.MaConnexion.SaveChanges();
                            nbFH++;
                        }
                        else
                        {
                            MessageBox.Show("ERREUR, la " + (nbFH + 1) + "eme ligne n'entre pas dans l'interval de date attendu !", "Action");
                        }

                    }
                    MessageBox.Show("Enregistrement de " + nbFH + " frais hors forfait", "Action");


                }
            }
        }

        public void ajoutBDD()
        {
            bool ajout = false;
            var LQueryExist = Modele.MaConnexion.fichefrais.ToList()
                                  .Where(x => x.idVisiteur == Modele.MonVisiteur.idVisiteur && x.mois == cbMois.Text);
            if (LQueryExist.Count() == 0)
            {
                ajout = true;
                fichefrais maFiche = new fichefrais();
                maFiche.idVisiteur = Modele.MonVisiteur.idVisiteur;
                maFiche.mois = cbMois.Text.Substring(0, 6);
                maFiche.idEtat = "CR";
                maFiche.dateModif = DateTime.Today;
                Modele.MaConnexion.fichefrais.Add(maFiche);
                Modele.MaConnexion.SaveChanges();
            }

            if (ajout)
            {
                Cloture(cbMois.SelectedIndex); // MODIF
            }

            LigneFraisForfait maLigne = new LigneFraisForfait();
            maLigne.idVisiteur = Modele.MonVisiteur.idVisiteur;
            maLigne.mois = cbMois.Text.Substring(0, 6);
            var filtreddata2 = Modele.MaConnexion.fichefrais.ToList().Where(x => x.idVisiteur == "a17" && x.mois == cbMois.Text.Substring(0, 6));
            fichefrais Fiche = new fichefrais();
            Fiche = (fichefrais)filtreddata2.ElementAt(0);
            if (Fiche.idEtat == "CL")
            {
                MessageBox.Show("ERREUR : Fiche du mois de " + cbMois.Text + " cloturé.", "Action");
            }
            else
            {

                if (double.Parse(tbQuantitéNuitée.Text) > 0)
                {
                    maLigne.idFraisForfait = "NUI";
                    maLigne.quantite = int.Parse(tbQuantitéNuitée.Text);
                    var filtreddata = Modele.MaConnexion.LigneFraisForfait.ToList().Where(x => x.idVisiteur == "a17" && x.idFraisForfait == "NUI" && x.mois == cbMois.Text.Substring(0, 6));

                    if (filtreddata.Count() > 0)
                    {
                        LigneFraisForfait lig = (LigneFraisForfait)filtreddata.ElementAt(0);
                        lig.quantite += maLigne.quantite;
                        Modele.MaConnexion.SaveChanges();
                        MessageBox.Show("Enregistrement de " + tbQuantitéNuitée.Text + " nuitée(s)", "Action");
                    }
                    else
                    {
                        Modele.MaConnexion.LigneFraisForfait.Add(maLigne);
                        Modele.MaConnexion.SaveChanges();
                        MessageBox.Show("Enregistrement de " + tbQuantitéNuitée.Text + " nuitée(s)", "Action");
                    }
                }
                if (double.Parse(tbQuantitéRepasMidi.Text) > 0)
                {
                    LigneFraisForfait maLigne2 = new LigneFraisForfait();
                    maLigne2.idVisiteur = Modele.MonVisiteur.idVisiteur;
                    maLigne2.mois = cbMois.Text.Substring(0, 6);
                    maLigne2.idFraisForfait = "REP";
                    maLigne2.quantite = int.Parse(tbQuantitéRepasMidi.Text);
                    var filtreddata = Modele.MaConnexion.LigneFraisForfait.ToList().Where(x => x.idVisiteur == "a17" && x.idFraisForfait == "REP" && x.mois == cbMois.Text.Substring(0, 6));

                    if (filtreddata.Count() > 0)
                    {

                        LigneFraisForfait lig = (LigneFraisForfait)filtreddata.ElementAt(0);
                        lig.quantite += maLigne2.quantite;
                        Modele.MaConnexion.SaveChanges();
                        MessageBox.Show("Enregistrement de " + tbQuantitéRepasMidi.Text + " repas", "Action");
                    }
                    else
                    {
                        Modele.MaConnexion.LigneFraisForfait.Add(maLigne2);
                        Modele.MaConnexion.SaveChanges();
                        MessageBox.Show("Enregistrement de " + tbQuantitéRepasMidi.Text + " repas", "Action");
                    }
                }
                if (double.Parse(tbQuantitéKilométrage.Text) > 0 && double.Parse(tbMontantKilométrage.Text) > 0)
                {
                    LigneFraisForfait maLigne3 = new LigneFraisForfait();
                    maLigne3.idVisiteur = Modele.MonVisiteur.idVisiteur;
                    maLigne3.mois = cbMois.Text.Substring(0, 6);
                    if (cbTypeVehicule.Text == "4CV DIESEL")
                    {
                        maLigne3.idFraisForfait = "4cD";
                    }
                    else if (cbTypeVehicule.Text == "5/6CV DIESEL")
                    {
                        maLigne3.idFraisForfait = "5cD";
                    }
                    else if (cbTypeVehicule.Text == "4CV ESSENCE")
                    {
                        maLigne3.idFraisForfait = "4cE";
                    }
                    else if (cbTypeVehicule.Text == "5/6CV ESSENCE")
                    {
                        maLigne3.idFraisForfait = "5cE";
                    }

                    maLigne3.quantite = int.Parse(tbQuantitéKilométrage.Text);
                    var filtreddata = Modele.MaConnexion.LigneFraisForfait.ToList().Where(x => x.idVisiteur == "a17" && x.idFraisForfait == maLigne3.idFraisForfait && x.mois == cbMois.Text.Substring(0, 6));

                    if (filtreddata.Count() > 0)
                    {
                        LigneFraisForfait lig = (LigneFraisForfait)filtreddata.ElementAt(0);
                        lig.quantite += maLigne3.quantite;
                        Modele.MaConnexion.SaveChanges();
                        MessageBox.Show("Enregistrement de " + tbQuantitéKilométrage.Text + " kilometres", "Action");
                    }
                    else
                    {
                        Modele.MaConnexion.LigneFraisForfait.Add(maLigne3);
                        Modele.MaConnexion.SaveChanges();
                        MessageBox.Show("Enregistrement de " + tbQuantitéKilométrage.Text + " kilometres", "Action");
                    }
                }
            }
        }
        public void Cloture(int moisEnCours)
        {

            string moisAvant;
            if (moisEnCours == 0)
            {
                moisAvant = "11/16 ";
            }
            else
            {
                moisAvant = cbMois.Items[moisEnCours - 1].ToString().Substring(0, 6);
            }
            var filtreddata = Modele.MaConnexion.fichefrais.ToList().Where(x => x.idVisiteur == Modele.MonVisiteur.idVisiteur && x.mois == moisAvant);
            if (filtreddata.Count() > 0)
            {
                fichefrais lig = (fichefrais)filtreddata.ElementAt(0);
                lig.idEtat = "CL";
                lig.dateModif = DateTime.Today;
                Modele.MaConnexion.SaveChanges();
            }
            else
            {
                fichefrais maFiche = new fichefrais();
                maFiche.idVisiteur = Modele.MonVisiteur.idVisiteur;
                maFiche.mois = moisAvant.Substring(0, 6);
                maFiche.idEtat = "CL";
                maFiche.dateModif = DateTime.Today;
                Modele.MaConnexion.fichefrais.Add(maFiche);
                Modele.MaConnexion.SaveChanges();
            }
            MessageBox.Show("Fiche du mois de " + moisAvant + " cloturé.", "Action");
        }

        private void btnTotal_Click_1(object sender, EventArgs e)
        {

        }

        private void cbTypeVehicule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeVehicule.Text == "4CV DIESEL")
            {
                var filteredData = Modele.MaConnexion.FraisForfait.ToList()
              .Where(x => x.id == "4cD");
                bsKm.DataSource = filteredData;
                bsKm.MoveFirst();
                FraisForfait fraisForfait2 = (FraisForfait)bsKm.Current;
                tbMontantKilométrage.Text = fraisForfait2.montant.ToString();
            }
            if (cbTypeVehicule.Text == "5/6CV DIESEL")
            {
                var filteredData = Modele.MaConnexion.FraisForfait.ToList()
              .Where(x => x.id == "5cD");
                bsKm.DataSource = filteredData;
                bsKm.MoveFirst();
                FraisForfait fraisForfait2 = (FraisForfait)bsKm.Current;
                tbMontantKilométrage.Text = fraisForfait2.montant.ToString();
            }
            if (cbTypeVehicule.Text == "4CV ESSENCE")
            {
                var filteredData = Modele.MaConnexion.FraisForfait.ToList()
              .Where(x => x.id == "4cE");
                bsKm.DataSource = filteredData;
                bsKm.MoveFirst();
                FraisForfait fraisForfait2 = (FraisForfait)bsKm.Current;
                tbMontantKilométrage.Text = fraisForfait2.montant.ToString();
            }
            if (cbTypeVehicule.Text == "5/6CV ESSENCE")
            {
                var filteredData = Modele.MaConnexion.FraisForfait.ToList()
              .Where(x => x.id == "5cE");
                bsKm.DataSource = filteredData;
                bsKm.MoveFirst();
                FraisForfait fraisForfait2 = (FraisForfait)bsKm.Current;
                tbMontantKilométrage.Text = fraisForfait2.montant.ToString();
            }
            textbox_Kilo_TextChanged(sender, e);

        }
        private void FormulaireVisiteurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            fermeture = true;
        }
        private void retour_Click(object sender, EventArgs e)
        {
            fermeture = true;
            this.Close();
        }

        private void cbMois_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkMesFiches_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FMesFrais mf = new FMesFrais();
            //menu.MdiParent = this;
            mf.Show();
            this.Hide();
        }



    }
}

