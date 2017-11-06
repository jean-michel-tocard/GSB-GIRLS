namespace GSB_GIRLS
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.textMPD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(316, 193);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(307, 20);
            this.txtIdent.TabIndex = 1;
            // 
            // textMPD
            // 
            this.textMPD.Location = new System.Drawing.Point(316, 280);
            this.textMPD.Name = "textMPD";
            this.textMPD.Size = new System.Drawing.Size(307, 20);
            this.textMPD.TabIndex = 2;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(992, 573);
            this.Controls.Add(this.textMPD);
            this.Controls.Add(this.txtIdent);
            this.Name = "Connexion";
            this.Controls.SetChildIndex(this.txtIdent, 0);
            this.Controls.SetChildIndex(this.textMPD, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.BindingSource bsvisiteur;
        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.TextBox textMPD;
    }
}

