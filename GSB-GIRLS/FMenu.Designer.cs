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
            this.gestionCompte = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsRégionsEtSecteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(232)))));
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionVisiteur,
            this.gestionCompte,
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
            this.regionsToolStripMenuItem});
            this.gestionVisiteur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gestionVisiteur.Name = "gestionVisiteur";
            this.gestionVisiteur.Size = new System.Drawing.Size(91, 27);
            this.gestionVisiteur.Text = "Visiteurs";
            this.gestionVisiteur.Click += new System.EventHandler(this.gestionVisiteur_Click);
            // 
            // laboratoireToolStripMenuItem
            // 
            this.laboratoireToolStripMenuItem.Name = "laboratoireToolStripMenuItem";
            this.laboratoireToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
            this.laboratoireToolStripMenuItem.Text = "Laboratoire";
            this.laboratoireToolStripMenuItem.Click += new System.EventHandler(this.laboratoireToolStripMenuItem_Click);
            // 
            // regionsToolStripMenuItem
            // 
            this.regionsToolStripMenuItem.Name = "regionsToolStripMenuItem";
            this.regionsToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
            this.regionsToolStripMenuItem.Text = "Régions";
            // 
            // gestionCompte
            // 
            this.gestionCompte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gestionCompte.Name = "gestionCompte";
            this.gestionCompte.Size = new System.Drawing.Size(195, 27);
            this.gestionCompte.Text = "Gestion des comptes";
            this.gestionCompte.Click += new System.EventHandler(this.gestionCompte_Click);
            // 
            // informationsRégionsEtSecteursToolStripMenuItem
            // 
            this.informationsRégionsEtSecteursToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.informationsRégionsEtSecteursToolStripMenuItem.Name = "informationsRégionsEtSecteursToolStripMenuItem";
            this.informationsRégionsEtSecteursToolStripMenuItem.Size = new System.Drawing.Size(300, 27);
            this.informationsRégionsEtSecteursToolStripMenuItem.Text = "Informations Régions et Secteurs";
            this.informationsRégionsEtSecteursToolStripMenuItem.Click += new System.EventHandler(this.informationsRégionsEtSecteursToolStripMenuItem_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 412);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenu";
            this.Text = "Menu";
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionVisiteur;
        private System.Windows.Forms.ToolStripMenuItem gestionCompte;
        private System.Windows.Forms.ToolStripMenuItem informationsRégionsEtSecteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionsToolStripMenuItem;
    }
}