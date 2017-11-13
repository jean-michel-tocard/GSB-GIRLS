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
            this.txtmdp = new System.Windows.Forms.TextBox();
            this.bsvisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.valider = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(288, 136);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(300, 20);
            this.txtIdent.TabIndex = 1;
            // 
            // txtmdp
            // 
            this.txtmdp.Location = new System.Drawing.Point(288, 184);
            this.txtmdp.Name = "txtmdp";
            this.txtmdp.PasswordChar = '*';
            this.txtmdp.Size = new System.Drawing.Size(300, 20);
            this.txtmdp.TabIndex = 2;
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.valider.Location = new System.Drawing.Point(304, 278);
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
            this.quitter.Location = new System.Drawing.Point(477, 278);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(75, 23);
            this.quitter.TabIndex = 4;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = false;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(281, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Identification";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(91, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Identifiant :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(91, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mot de passe :";
            // 
            // Connexion
            // 
            this.ClientSize = new System.Drawing.Size(823, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.txtmdp);
            this.Controls.Add(this.txtIdent);
            this.Name = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.TextBox txtmdp;
        private System.Windows.Forms.BindingSource bsvisiteurs;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

