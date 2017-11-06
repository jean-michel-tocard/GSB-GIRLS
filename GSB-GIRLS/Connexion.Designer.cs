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
            this.identiTitre = new System.Windows.Forms.Label();
            this.bvalid = new System.Windows.Forms.Button();
            this.bquitter = new System.Windows.Forms.Button();
            this.bsvisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.identifiant = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdent
            // 
            this.txtIdent.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdent.Location = new System.Drawing.Point(345, 205);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(307, 26);
            this.txtIdent.TabIndex = 1;
            // 
            // textMPD
            // 
            this.textMPD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textMPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMPD.Location = new System.Drawing.Point(345, 269);
            this.textMPD.Name = "textMPD";
            this.textMPD.PasswordChar = '♦';
            this.textMPD.Size = new System.Drawing.Size(307, 26);
            this.textMPD.TabIndex = 2;
            // 
            // identiTitre
            // 
            this.identiTitre.AutoSize = true;
            this.identiTitre.BackColor = System.Drawing.Color.Transparent;
            this.identiTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identiTitre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.identiTitre.Location = new System.Drawing.Point(372, 111);
            this.identiTitre.Name = "identiTitre";
            this.identiTitre.Size = new System.Drawing.Size(210, 37);
            this.identiTitre.TabIndex = 3;
            this.identiTitre.Text = "Identification";
            // 
            // bvalid
            // 
            this.bvalid.BackColor = System.Drawing.SystemColors.Highlight;
            this.bvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bvalid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bvalid.Location = new System.Drawing.Point(316, 394);
            this.bvalid.Name = "bvalid";
            this.bvalid.Size = new System.Drawing.Size(114, 33);
            this.bvalid.TabIndex = 4;
            this.bvalid.Text = "Valider";
            this.bvalid.UseVisualStyleBackColor = false;
            this.bvalid.Click += new System.EventHandler(this.button1_Click);
            // 
            // bquitter
            // 
            this.bquitter.BackColor = System.Drawing.SystemColors.Highlight;
            this.bquitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bquitter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bquitter.Location = new System.Drawing.Point(497, 394);
            this.bquitter.Name = "bquitter";
            this.bquitter.Size = new System.Drawing.Size(114, 33);
            this.bquitter.TabIndex = 5;
            this.bquitter.Text = "Quitter";
            this.bquitter.UseVisualStyleBackColor = false;
            this.bquitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // identifiant
            // 
            this.identifiant.AutoSize = true;
            this.identifiant.BackColor = System.Drawing.Color.Transparent;
            this.identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiant.ForeColor = System.Drawing.SystemColors.Highlight;
            this.identifiant.Location = new System.Drawing.Point(180, 204);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(130, 25);
            this.identifiant.TabIndex = 6;
            this.identifiant.Text = "Identifiant :";
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.BackColor = System.Drawing.Color.Transparent;
            this.mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mdp.Location = new System.Drawing.Point(180, 270);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(168, 25);
            this.mdp.TabIndex = 7;
            this.mdp.Text = "Mot de passe :";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(992, 573);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.identifiant);
            this.Controls.Add(this.bquitter);
            this.Controls.Add(this.bvalid);
            this.Controls.Add(this.identiTitre);
            this.Controls.Add(this.textMPD);
            this.Controls.Add(this.txtIdent);
            this.Name = "Connexion";
            this.Controls.SetChildIndex(this.txtIdent, 0);
            this.Controls.SetChildIndex(this.textMPD, 0);
            this.Controls.SetChildIndex(this.identiTitre, 0);
            this.Controls.SetChildIndex(this.bvalid, 0);
            this.Controls.SetChildIndex(this.bquitter, 0);
            this.Controls.SetChildIndex(this.identifiant, 0);
            this.Controls.SetChildIndex(this.mdp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.TextBox textMPD;
        private System.Windows.Forms.Label identiTitre;
        private System.Windows.Forms.Button bvalid;
        private System.Windows.Forms.Button bquitter;
        private System.Windows.Forms.BindingSource bsvisiteurs;
        private System.Windows.Forms.Label identifiant;
        private System.Windows.Forms.Label mdp;
    }
}

