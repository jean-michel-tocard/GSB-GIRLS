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
            this.Profil = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsRégionsEtSecteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_util = new System.Windows.Forms.DataGridView();
            this.gestionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msDonnées = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Profil,
            this.informationsRégionsEtSecteursToolStripMenuItem});
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
            // Profil
            // 
            this.Profil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesUtilisateursToolStripMenuItem,
            this.msDonnées});
            this.Profil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Profil.Name = "Profil";
            this.Profil.Size = new System.Drawing.Size(63, 27);
            this.Profil.Text = "Profil";
            this.Profil.Click += new System.EventHandler(this.gestionCompte_Click);
            // 
            // informationsRégionsEtSecteursToolStripMenuItem
            // 
            this.informationsRégionsEtSecteursToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.informationsRégionsEtSecteursToolStripMenuItem.Name = "informationsRégionsEtSecteursToolStripMenuItem";
            this.informationsRégionsEtSecteursToolStripMenuItem.Size = new System.Drawing.Size(300, 27);
            this.informationsRégionsEtSecteursToolStripMenuItem.Text = "Informations Régions et Secteurs";
            this.informationsRégionsEtSecteursToolStripMenuItem.Click += new System.EventHandler(this.informationsRégionsEtSecteursToolStripMenuItem_Click);
            // 
            // dgv_util
            // 
            this.dgv_util.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_util.Location = new System.Drawing.Point(102, 55);
            this.dgv_util.Name = "dgv_util";
            this.dgv_util.Size = new System.Drawing.Size(516, 305);
            this.dgv_util.TabIndex = 2;
            // 
            // gestionDesUtilisateursToolStripMenuItem
            // 
            this.gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            this.gestionDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(273, 28);
            this.gestionDesUtilisateursToolStripMenuItem.Text = "Gestion des Utilisateurs";
            // 
            // msDonnées
            // 
            this.msDonnées.Name = "msDonnées";
            this.msDonnées.Size = new System.Drawing.Size(273, 28);
            this.msDonnées.Text = "Voir Données";
            this.msDonnées.Click += new System.EventHandler(this.msDonnées_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 412);
            this.Controls.Add(this.dgv_util);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenu";
            this.Text = "Menu";
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.dgv_util, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_util)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionVisiteur;
        private System.Windows.Forms.ToolStripMenuItem Profil;
        private System.Windows.Forms.ToolStripMenuItem informationsRégionsEtSecteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_util;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msDonnées;
    }
}