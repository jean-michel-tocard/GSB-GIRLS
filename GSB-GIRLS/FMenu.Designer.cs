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
            this.gestionDesComptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsRégionsEtSecteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vosInformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesComptesToolStripMenuItem,
            this.gestionDesVisiteursToolStripMenuItem,
            this.informationsRégionsEtSecteursToolStripMenuItem,
            this.vosInformationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesComptesToolStripMenuItem
            // 
            this.gestionDesComptesToolStripMenuItem.Name = "gestionDesComptesToolStripMenuItem";
            this.gestionDesComptesToolStripMenuItem.Size = new System.Drawing.Size(197, 27);
            this.gestionDesComptesToolStripMenuItem.Text = "Gestion des Comptes";
            this.gestionDesComptesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesComptesToolStripMenuItem_Click);
            // 
            // gestionDesVisiteursToolStripMenuItem
            // 
            this.gestionDesVisiteursToolStripMenuItem.Name = "gestionDesVisiteursToolStripMenuItem";
            this.gestionDesVisiteursToolStripMenuItem.Size = new System.Drawing.Size(192, 27);
            this.gestionDesVisiteursToolStripMenuItem.Text = "Gestion des visiteurs";
            // 
            // informationsRégionsEtSecteursToolStripMenuItem
            // 
            this.informationsRégionsEtSecteursToolStripMenuItem.Name = "informationsRégionsEtSecteursToolStripMenuItem";
            this.informationsRégionsEtSecteursToolStripMenuItem.Size = new System.Drawing.Size(300, 27);
            this.informationsRégionsEtSecteursToolStripMenuItem.Text = "Informations Régions et Secteurs";
            this.informationsRégionsEtSecteursToolStripMenuItem.Click += new System.EventHandler(this.informationsRégionsEtSecteursToolStripMenuItem_Click);
            // 
            // vosInformationsToolStripMenuItem
            // 
            this.vosInformationsToolStripMenuItem.Name = "vosInformationsToolStripMenuItem";
            this.vosInformationsToolStripMenuItem.Size = new System.Drawing.Size(160, 27);
            this.vosInformationsToolStripMenuItem.Text = "Vos informations";
            this.vosInformationsToolStripMenuItem.Click += new System.EventHandler(this.vosInformationsToolStripMenuItem_Click);
            // 
            // MenuVisiteurRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSB_GIRLS.Properties.Resources.logo;
            this.ClientSize = new System.Drawing.Size(992, 573);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuVisiteurRegion";
            this.Text = "Menu";
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesComptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationsRégionsEtSecteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vosInformationsToolStripMenuItem;
    }
}