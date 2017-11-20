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
            this.laboratoireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msProfil = new System.Windows.Forms.ToolStripMenuItem();
            this.msGestionUser = new System.Windows.Forms.ToolStripMenuItem();
            this.msDonnées = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsRégionsEtSecteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msVisualiser = new System.Windows.Forms.ToolStripMenuItem();
            this.msAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.msModifier = new System.Windows.Forms.ToolStripMenuItem();
            this.msDeconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_util = new System.Windows.Forms.DataGridView();
            this.lbTitre = new System.Windows.Forms.Label();
            this.lbInformations = new System.Windows.Forms.Label();
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
            this.informationsRégionsEtSecteursToolStripMenuItem,
            this.rapportsToolStripMenuItem,
            this.msDeconnexion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionVisiteur
            // 
            this.gestionVisiteur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratoireToolStripMenuItem,
            this.regionsToolStripMenuItem,
            this.parSecteurToolStripMenuItem,
            this.modificationToolStripMenuItem});
            this.gestionVisiteur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gestionVisiteur.Name = "gestionVisiteur";
            this.gestionVisiteur.Size = new System.Drawing.Size(91, 27);
            this.gestionVisiteur.Text = "Visiteurs";
            this.gestionVisiteur.Click += new System.EventHandler(this.gestionVisiteur_Click);
            // 
            // laboratoireToolStripMenuItem
            // 
            this.laboratoireToolStripMenuItem.Name = "laboratoireToolStripMenuItem";
            this.laboratoireToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.laboratoireToolStripMenuItem.Text = "Par laboratoire";
            this.laboratoireToolStripMenuItem.Click += new System.EventHandler(this.laboratoireToolStripMenuItem_Click);
            // 
            // regionsToolStripMenuItem
            // 
            this.regionsToolStripMenuItem.Name = "regionsToolStripMenuItem";
            this.regionsToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.regionsToolStripMenuItem.Text = "Par régions";
            this.regionsToolStripMenuItem.Click += new System.EventHandler(this.regionsToolStripMenuItem_Click);
            // 
            // parSecteurToolStripMenuItem
            // 
            this.parSecteurToolStripMenuItem.Name = "parSecteurToolStripMenuItem";
            this.parSecteurToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.parSecteurToolStripMenuItem.Text = "Par secteur";
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.modificationToolStripMenuItem.Text = "Modification";
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
            // informationsRégionsEtSecteursToolStripMenuItem
            // 
            this.informationsRégionsEtSecteursToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.informationsRégionsEtSecteursToolStripMenuItem.Name = "informationsRégionsEtSecteursToolStripMenuItem";
            this.informationsRégionsEtSecteursToolStripMenuItem.Size = new System.Drawing.Size(300, 27);
            this.informationsRégionsEtSecteursToolStripMenuItem.Text = "Informations Régions et Secteurs";
            this.informationsRégionsEtSecteursToolStripMenuItem.Click += new System.EventHandler(this.informationsRégionsEtSecteursToolStripMenuItem_Click);
            // 
            // rapportsToolStripMenuItem
            // 
            this.rapportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msVisualiser,
            this.msAjouter,
            this.msModifier});
            this.rapportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rapportsToolStripMenuItem.Name = "rapportsToolStripMenuItem";
            this.rapportsToolStripMenuItem.Size = new System.Drawing.Size(97, 27);
            this.rapportsToolStripMenuItem.Text = "Rapports";
            // 
            // msVisualiser
            // 
            this.msVisualiser.ForeColor = System.Drawing.Color.Black;
            this.msVisualiser.Name = "msVisualiser";
            this.msVisualiser.Size = new System.Drawing.Size(157, 28);
            this.msVisualiser.Text = "Visualiser";
            this.msVisualiser.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // msAjouter
            // 
            this.msAjouter.Name = "msAjouter";
            this.msAjouter.Size = new System.Drawing.Size(157, 28);
            this.msAjouter.Text = "Ajouter";
            // 
            // msModifier
            // 
            this.msModifier.Name = "msModifier";
            this.msModifier.Size = new System.Drawing.Size(157, 28);
            this.msModifier.Text = "Modifier";
            // 
            // msDeconnexion
            // 
            this.msDeconnexion.ForeColor = System.Drawing.Color.White;
            this.msDeconnexion.Name = "msDeconnexion";
            this.msDeconnexion.Size = new System.Drawing.Size(130, 27);
            this.msDeconnexion.Text = "Deconnexion";
            this.msDeconnexion.Click += new System.EventHandler(this.msDeconnexion_Click);
            // 
            // dgv_util
            // 
            this.dgv_util.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_util.Location = new System.Drawing.Point(102, 55);
            this.dgv_util.Name = "dgv_util";
            this.dgv_util.Size = new System.Drawing.Size(516, 305);
            this.dgv_util.TabIndex = 2;
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lbInformations.Location = new System.Drawing.Point(12, 363);
            this.lbInformations.Name = "lbInformations";
            this.lbInformations.Size = new System.Drawing.Size(123, 28);
            this.lbInformations.TabIndex = 4;
            this.lbInformations.Text = "Informations";
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 412);
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
        private System.Windows.Forms.ToolStripMenuItem informationsRégionsEtSecteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_util;
        private System.Windows.Forms.ToolStripMenuItem msGestionUser;
        private System.Windows.Forms.ToolStripMenuItem msDonnées;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.Label lbInformations;
        private System.Windows.Forms.ToolStripMenuItem msDeconnexion;
        private System.Windows.Forms.ToolStripMenuItem rapportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msVisualiser;
        private System.Windows.Forms.ToolStripMenuItem msAjouter;
        private System.Windows.Forms.ToolStripMenuItem msModifier;
    }
}