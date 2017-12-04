namespace GSB_GIRLS
{
    partial class FMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionVisiteur = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoire = new System.Windows.Forms.ToolStripMenuItem();
            this.regionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msProfil = new System.Windows.Forms.ToolStripMenuItem();
            this.msGestionUser = new System.Windows.Forms.ToolStripMenuItem();
            this.msDonnées = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheDeFrais = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterFicheDeFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesFichesDeFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comptableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesFichesDeFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_util = new System.Windows.Forms.DataGridView();
            this.lbTitre = new System.Windows.Forms.Label();
            this.lbInformations = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_util)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(232)))));
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionVisiteur,
            this.msProfil,
            this.ficheDeFrais,
            this.rapportToolStripMenuItem,
            this.comptableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionVisiteur
            // 
            this.gestionVisiteur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratoire,
            this.regionsToolStripMenuItem,
            this.parSecteurToolStripMenuItem,
            this.modificationToolStripMenuItem});
            this.gestionVisiteur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gestionVisiteur.Name = "gestionVisiteur";
            this.gestionVisiteur.Size = new System.Drawing.Size(91, 27);
            this.gestionVisiteur.Text = "Visiteurs";
            this.gestionVisiteur.Click += new System.EventHandler(this.gestionVisiteur_Click);
            // 
            // laboratoire
            // 
            this.laboratoire.Name = "laboratoire";
            this.laboratoire.Size = new System.Drawing.Size(221, 28);
            this.laboratoire.Text = "Par laboratoire";
            this.laboratoire.Click += new System.EventHandler(this.laboratoireToolStripMenuItem_Click);
            // 
            // regionsToolStripMenuItem
            // 
            this.regionsToolStripMenuItem.Name = "regionsToolStripMenuItem";
            this.regionsToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.regionsToolStripMenuItem.Text = "Par régions";
            this.regionsToolStripMenuItem.Click += new System.EventHandler(this.regionsToolStripMenuItem_Click);
            // 
            // parSecteurToolStripMenuItem
            // 
            this.parSecteurToolStripMenuItem.Name = "parSecteurToolStripMenuItem";
            this.parSecteurToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.parSecteurToolStripMenuItem.Text = "Par secteur";
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.modificationToolStripMenuItem.Text = "Tous les visiteurs";
            this.modificationToolStripMenuItem.Click += new System.EventHandler(this.modificationToolStripMenuItem_Click);
            // 
            // msProfil
            // 
            this.msProfil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msGestionUser,
            this.msDonnées});
            this.msProfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.msProfil.Name = "msProfil";
            this.msProfil.Size = new System.Drawing.Size(63, 27);
            this.msProfil.Text = "Profil";
            this.msProfil.Click += new System.EventHandler(this.gestionCompte_Click);
            // 
            // msGestionUser
            // 
            this.msGestionUser.Name = "msGestionUser";
            this.msGestionUser.Size = new System.Drawing.Size(273, 28);
            this.msGestionUser.Text = "Gestion des Utilisateurs";
            this.msGestionUser.Click += new System.EventHandler(this.gestionDesUtilisateursToolStripMenuItem_Click);
            // 
            // msDonnées
            // 
            this.msDonnées.Name = "msDonnées";
            this.msDonnées.Size = new System.Drawing.Size(273, 28);
            this.msDonnées.Text = "Voir Données";
            this.msDonnées.Click += new System.EventHandler(this.msDonnées_Click);
            // 
            // ficheDeFrais
            // 
            this.ficheDeFrais.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterFicheDeFraisToolStripMenuItem,
            this.mesFichesDeFraisToolStripMenuItem});
            this.ficheDeFrais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ficheDeFrais.Name = "ficheDeFrais";
            this.ficheDeFrais.Size = new System.Drawing.Size(134, 27);
            this.ficheDeFrais.Text = "Fiche de frais";
            this.ficheDeFrais.Click += new System.EventHandler(this.ficheDeFraisToolStripMenuItem_Click);
            // 
            // ajouterFicheDeFraisToolStripMenuItem
            // 
            this.ajouterFicheDeFraisToolStripMenuItem.Name = "ajouterFicheDeFraisToolStripMenuItem";
            this.ajouterFicheDeFraisToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.ajouterFicheDeFraisToolStripMenuItem.Text = "Ajouter fiche de frais";
            this.ajouterFicheDeFraisToolStripMenuItem.Click += new System.EventHandler(this.ajouterFicheDeFraisToolStripMenuItem_Click);
            // 
            // mesFichesDeFraisToolStripMenuItem
            // 
            this.mesFichesDeFraisToolStripMenuItem.Name = "mesFichesDeFraisToolStripMenuItem";
            this.mesFichesDeFraisToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.mesFichesDeFraisToolStripMenuItem.Text = "Mes Fiches de frais";
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualiserToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.ajouterToolStripMenuItem});
            this.rapportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(89, 27);
            this.rapportToolStripMenuItem.Text = "Rapport";
            // 
            // visualiserToolStripMenuItem
            // 
            this.visualiserToolStripMenuItem.Name = "visualiserToolStripMenuItem";
            this.visualiserToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.visualiserToolStripMenuItem.Text = "Visualiser";
            this.visualiserToolStripMenuItem.Click += new System.EventHandler(this.visualiserToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // comptableToolStripMenuItem
            // 
            this.comptableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesFichesDeFraisToolStripMenuItem,
            this.editionToolStripMenuItem});
            this.comptableToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comptableToolStripMenuItem.Name = "comptableToolStripMenuItem";
            this.comptableToolStripMenuItem.Size = new System.Drawing.Size(111, 27);
            this.comptableToolStripMenuItem.Text = "Comptable";
            // 
            // lesFichesDeFraisToolStripMenuItem
            // 
            this.lesFichesDeFraisToolStripMenuItem.Name = "lesFichesDeFraisToolStripMenuItem";
            this.lesFichesDeFraisToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.lesFichesDeFraisToolStripMenuItem.Text = "Les fiches de frais";
            this.lesFichesDeFraisToolStripMenuItem.Click += new System.EventHandler(this.lesFichesDeFraisToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.editionToolStripMenuItem.Text = "Edition";
            this.editionToolStripMenuItem.Click += new System.EventHandler(this.editionToolStripMenuItem_Click);
            // 
            // dgv_util
            // 
            this.dgv_util.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_util.Location = new System.Drawing.Point(17, 164);
            this.dgv_util.Name = "dgv_util";
            this.dgv_util.Size = new System.Drawing.Size(727, 78);
            this.dgv_util.TabIndex = 2;
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitre.Location = new System.Drawing.Point(12, 31);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(64, 28);
            this.lbTitre.TabIndex = 3;
            this.lbTitre.Text = "Menu";
            this.lbTitre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbInformations
            // 
            this.lbInformations.AutoSize = true;
            this.lbInformations.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformations.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbInformations.Location = new System.Drawing.Point(12, 363);
            this.lbInformations.Name = "lbInformations";
            this.lbInformations.Size = new System.Drawing.Size(123, 28);
            this.lbInformations.TabIndex = 4;
            this.lbInformations.Text = "Informations";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(659, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbInformations);
            this.Controls.Add(this.lbTitre);
            this.Controls.Add(this.dgv_util);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.dgv_util, 0);
            this.Controls.SetChildIndex(this.lbTitre, 0);
            this.Controls.SetChildIndex(this.lbInformations, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_util)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionVisiteur;
        private System.Windows.Forms.ToolStripMenuItem msProfil;
        private System.Windows.Forms.ToolStripMenuItem laboratoire;
        private System.Windows.Forms.ToolStripMenuItem regionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_util;
        private System.Windows.Forms.ToolStripMenuItem msGestionUser;
        private System.Windows.Forms.ToolStripMenuItem msDonnées;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.Label lbInformations;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ficheDeFrais;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterFicheDeFraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesFichesDeFraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comptableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesFichesDeFraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
    }
}