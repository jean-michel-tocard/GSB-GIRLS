namespace GSB_GIRLS
{
    partial class FMesFrais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkSaisieFrais = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.bsMois = new System.Windows.Forms.BindingSource(this.components);
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.dgvFMois = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNbJustificatifs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEtat = new System.Windows.Forms.TextBox();
            this.dgvFraisForfaitaires = new System.Windows.Forms.DataGridView();
            this.tbMatricule = new System.Windows.Forms.TextBox();
            this.tbVisiteur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAutresFrais = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSupprimerForfait = new System.Windows.Forms.Button();
            this.btnModifFraisForfait = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.cbMois = new System.Windows.Forms.ComboBox();
            this.bsFraisForfaitaires = new System.Windows.Forms.BindingSource(this.components);
            this.bsAutresFrais = new System.Windows.Forms.BindingSource(this.components);
            this.retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFMois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisForfaitaires)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutresFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisForfaitaires)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAutresFrais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulter mes fiches de frais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mois : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fiche de frais du mois ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSB_GIRLS.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(399, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Etat : Saisie clôturée depuis le ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(399, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Montant validé : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(170, 547);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Elements forfaitisés";
            // 
            // linkSaisieFrais
            // 
            this.linkSaisieFrais.AutoSize = true;
            this.linkSaisieFrais.Location = new System.Drawing.Point(9, 246);
            this.linkSaisieFrais.Name = "linkSaisieFrais";
            this.linkSaisieFrais.Size = new System.Drawing.Size(98, 13);
            this.linkSaisieFrais.TabIndex = 33;
            this.linkSaisieFrais.TabStop = true;
            this.linkSaisieFrais.Text = "Saisie fiche de frais";
            this.linkSaisieFrais.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSaisieFrais_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "Suivi du remboursement des frais";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(566, 445);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(155, 20);
            this.txtMontant.TabIndex = 39;
            // 
            // dgvFMois
            // 
            this.dgvFMois.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFMois.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFMois.Location = new System.Drawing.Point(393, 405);
            this.dgvFMois.Name = "dgvFMois";
            this.dgvFMois.Size = new System.Drawing.Size(342, 111);
            this.dgvFMois.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(399, 481);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Nombre de  justificatifs fournis";
            // 
            // txtNbJustificatifs
            // 
            this.txtNbJustificatifs.Location = new System.Drawing.Point(566, 478);
            this.txtNbJustificatifs.Name = "txtNbJustificatifs";
            this.txtNbJustificatifs.Size = new System.Drawing.Size(155, 20);
            this.txtNbJustificatifs.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(765, 547);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 24);
            this.label11.TabIndex = 44;
            this.label11.Text = "Elements hors forfaits";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Matricule :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Visiteur : ";
            // 
            // tbEtat
            // 
            this.tbEtat.Enabled = false;
            this.tbEtat.Location = new System.Drawing.Point(566, 416);
            this.tbEtat.Name = "tbEtat";
            this.tbEtat.Size = new System.Drawing.Size(155, 20);
            this.tbEtat.TabIndex = 70;
            // 
            // dgvFraisForfaitaires
            // 
            this.dgvFraisForfaitaires.AllowUserToAddRows = false;
            this.dgvFraisForfaitaires.AllowUserToDeleteRows = false;
            this.dgvFraisForfaitaires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFraisForfaitaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFraisForfaitaires.Location = new System.Drawing.Point(25, 583);
            this.dgvFraisForfaitaires.Name = "dgvFraisForfaitaires";
            this.dgvFraisForfaitaires.ReadOnly = true;
            this.dgvFraisForfaitaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFraisForfaitaires.Size = new System.Drawing.Size(483, 249);
            this.dgvFraisForfaitaires.TabIndex = 69;
            // 
            // tbMatricule
            // 
            this.tbMatricule.Enabled = false;
            this.tbMatricule.Location = new System.Drawing.Point(68, 205);
            this.tbMatricule.Name = "tbMatricule";
            this.tbMatricule.Size = new System.Drawing.Size(155, 20);
            this.tbMatricule.TabIndex = 67;
            // 
            // tbVisiteur
            // 
            this.tbVisiteur.Enabled = false;
            this.tbVisiteur.Location = new System.Drawing.Point(68, 179);
            this.tbVisiteur.Name = "tbVisiteur";
            this.tbVisiteur.Size = new System.Drawing.Size(155, 20);
            this.tbVisiteur.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mois à sélectionner :";
            // 
            // dgvAutresFrais
            // 
            this.dgvAutresFrais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutresFrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutresFrais.Location = new System.Drawing.Point(650, 592);
            this.dgvAutresFrais.Name = "dgvAutresFrais";
            this.dgvAutresFrais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutresFrais.Size = new System.Drawing.Size(402, 240);
            this.dgvAutresFrais.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(586, 583);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 20);
            this.label13.TabIndex = 78;
            this.label13.Text = "€";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(533, 583);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(18, 20);
            this.lbTotal.TabIndex = 77;
            this.lbTotal.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(537, 551);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 20);
            this.label14.TabIndex = 76;
            this.label14.Text = "Total :";
            // 
            // btnSupprimerForfait
            // 
            this.btnSupprimerForfait.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerForfait.Location = new System.Drawing.Point(97, 838);
            this.btnSupprimerForfait.Name = "btnSupprimerForfait";
            this.btnSupprimerForfait.Size = new System.Drawing.Size(115, 33);
            this.btnSupprimerForfait.TabIndex = 75;
            this.btnSupprimerForfait.Text = "Supprimer";
            this.btnSupprimerForfait.UseVisualStyleBackColor = true;
            // 
            // btnModifFraisForfait
            // 
            this.btnModifFraisForfait.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifFraisForfait.Location = new System.Drawing.Point(317, 838);
            this.btnModifFraisForfait.Name = "btnModifFraisForfait";
            this.btnModifFraisForfait.Size = new System.Drawing.Size(121, 33);
            this.btnModifFraisForfait.TabIndex = 74;
            this.btnModifFraisForfait.Text = "Modifier";
            this.btnModifFraisForfait.UseVisualStyleBackColor = true;
            // 
            // btnAjout
            // 
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(949, 837);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(115, 33);
            this.btnAjout.TabIndex = 73;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppr.Location = new System.Drawing.Point(729, 837);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(115, 33);
            this.btnSuppr.TabIndex = 72;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            // 
            // cbMois
            // 
            this.cbMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMois.FormattingEnabled = true;
            this.cbMois.Location = new System.Drawing.Point(446, 281);
            this.cbMois.Name = "cbMois";
            this.cbMois.Size = new System.Drawing.Size(100, 21);
            this.cbMois.TabIndex = 79;
            // 
            // retour
            // 
            this.retour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.Location = new System.Drawing.Point(963, 12);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(77, 26);
            this.retour.TabIndex = 80;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // FMesFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 882);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.cbMois);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSupprimerForfait);
            this.Controls.Add(this.btnModifFraisForfait);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.dgvAutresFrais);
            this.Controls.Add(this.tbEtat);
            this.Controls.Add(this.dgvFraisForfaitaires);
            this.Controls.Add(this.tbMatricule);
            this.Controls.Add(this.tbVisiteur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNbJustificatifs);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkSaisieFrais);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFMois);
            this.Name = "FMesFrais";
            this.Text = "FMesFrais";
            this.Load += new System.EventHandler(this.FMesFrais_Load);
            this.Controls.SetChildIndex(this.dgvFMois, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.linkSaisieFrais, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtMontant, 0);
            this.Controls.SetChildIndex(this.txtNbJustificatifs, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.tbVisiteur, 0);
            this.Controls.SetChildIndex(this.tbMatricule, 0);
            this.Controls.SetChildIndex(this.dgvFraisForfaitaires, 0);
            this.Controls.SetChildIndex(this.tbEtat, 0);
            this.Controls.SetChildIndex(this.dgvAutresFrais, 0);
            this.Controls.SetChildIndex(this.btnSuppr, 0);
            this.Controls.SetChildIndex(this.btnAjout, 0);
            this.Controls.SetChildIndex(this.btnModifFraisForfait, 0);
            this.Controls.SetChildIndex(this.btnSupprimerForfait, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.lbTotal, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.cbMois, 0);
            this.Controls.SetChildIndex(this.retour, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFMois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisForfaitaires)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutresFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisForfaitaires)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAutresFrais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkSaisieFrais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bsMois;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.DataGridView dgvFMois;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNbJustificatifs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEtat;
        private System.Windows.Forms.DataGridView dgvFraisForfaitaires;
        private System.Windows.Forms.TextBox tbMatricule;
        private System.Windows.Forms.TextBox tbVisiteur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAutresFrais;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSupprimerForfait;
        private System.Windows.Forms.Button btnModifFraisForfait;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.ComboBox cbMois;
        private System.Windows.Forms.BindingSource bsFraisForfaitaires;
        private System.Windows.Forms.BindingSource bsAutresFrais;
        private System.Windows.Forms.Button retour;
    }
}