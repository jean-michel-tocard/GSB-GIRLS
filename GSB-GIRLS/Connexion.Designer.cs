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
            this.components = new System.ComponentModel.Container();
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.textMPD = new System.Windows.Forms.TextBox();
            this.bsvisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.valider = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(100, 93);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(307, 20);
            this.txtIdent.TabIndex = 1;
            // 
            // textMPD
            // 
            this.textMPD.Location = new System.Drawing.Point(100, 180);
            this.textMPD.Name = "textMPD";
            this.textMPD.Size = new System.Drawing.Size(307, 20);
            this.textMPD.TabIndex = 2;
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.valider.Location = new System.Drawing.Point(157, 278);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 3;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = false;
            this.valider.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // quitter
            // 
            this.quitter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.quitter.Location = new System.Drawing.Point(272, 278);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(75, 23);
            this.quitter.TabIndex = 4;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = false;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(823, 413);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.textMPD);
            this.Controls.Add(this.txtIdent);
            this.Name = "Connexion";
            this.Controls.SetChildIndex(this.txtIdent, 0);
            this.Controls.SetChildIndex(this.textMPD, 0);
            this.Controls.SetChildIndex(this.valider, 0);
            this.Controls.SetChildIndex(this.quitter, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.TextBox textMPD;
        private System.Windows.Forms.BindingSource bsvisiteurs;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button quitter;
    }
}

