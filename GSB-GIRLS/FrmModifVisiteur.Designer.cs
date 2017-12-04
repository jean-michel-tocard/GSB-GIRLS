namespace GSB_GIRLS
{
    partial class FrmModifVisiteur
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
            System.Windows.Forms.Label lblCP;
            System.Windows.Forms.Label dateEmbaucheLabel;
            System.Windows.Forms.Label identifiantLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label rueLabel;
            System.Windows.Forms.Label villeLabel;
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtDateEmbauche = new System.Windows.Forms.TextBox();
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            lblCP = new System.Windows.Forms.Label();
            dateEmbaucheLabel = new System.Windows.Forms.Label();
            identifiantLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            rueLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCP
            // 
            lblCP.AutoSize = true;
            lblCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblCP.Location = new System.Drawing.Point(68, 254);
            lblCP.Name = "lblCP";
            lblCP.Size = new System.Drawing.Size(103, 20);
            lblCP.TabIndex = 24;
            lblCP.Text = "Code Postal :";
            // 
            // dateEmbaucheLabel
            // 
            dateEmbaucheLabel.AutoSize = true;
            dateEmbaucheLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateEmbaucheLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dateEmbaucheLabel.Location = new System.Drawing.Point(28, 212);
            dateEmbaucheLabel.Name = "dateEmbaucheLabel";
            dateEmbaucheLabel.Size = new System.Drawing.Size(143, 20);
            dateEmbaucheLabel.TabIndex = 26;
            dateEmbaucheLabel.Text = "Date d\'embauche :";
            // 
            // identifiantLabel
            // 
            identifiantLabel.AutoSize = true;
            identifiantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            identifiantLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            identifiantLabel.Location = new System.Drawing.Point(387, 149);
            identifiantLabel.Name = "identifiantLabel";
            identifiantLabel.Size = new System.Drawing.Size(88, 20);
            identifiantLabel.TabIndex = 28;
            identifiantLabel.Text = "Identifiant :";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nomLabel.Location = new System.Drawing.Point(28, 118);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(50, 20);
            nomLabel.TabIndex = 30;
            nomLabel.Text = "Nom :";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            passwordLabel.Location = new System.Drawing.Point(388, 119);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(86, 20);
            passwordLabel.TabIndex = 32;
            passwordLabel.Text = "Password :";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            prenomLabel.Location = new System.Drawing.Point(28, 152);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(72, 20);
            prenomLabel.TabIndex = 34;
            prenomLabel.Text = "Prénom :";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rueLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            rueLabel.Location = new System.Drawing.Point(400, 186);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(76, 20);
            rueLabel.TabIndex = 36;
            rueLabel.Text = "Adresse :";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            villeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            villeLabel.Location = new System.Drawing.Point(430, 232);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(46, 20);
            villeLabel.TabIndex = 38;
            villeLabel.Text = "Ville :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(395, 335);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(145, 29);
            this.btnAnnuler.TabIndex = 42;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmer.Location = new System.Drawing.Point(214, 335);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(145, 29);
            this.btnConfirmer.TabIndex = 41;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = false;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // txtCP
            // 
            this.txtCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.Location = new System.Drawing.Point(177, 254);
            this.txtCP.Multiline = true;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(167, 20);
            this.txtCP.TabIndex = 25;
            // 
            // txtDateEmbauche
            // 
            this.txtDateEmbauche.Location = new System.Drawing.Point(177, 212);
            this.txtDateEmbauche.Name = "txtDateEmbauche";
            this.txtDateEmbauche.Size = new System.Drawing.Size(167, 20);
            this.txtDateEmbauche.TabIndex = 27;
            // 
            // txtIdent
            // 
            this.txtIdent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdent.Location = new System.Drawing.Point(489, 148);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(238, 22);
            this.txtIdent.TabIndex = 29;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(106, 117);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(238, 22);
            this.txtNom.TabIndex = 31;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(489, 114);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(238, 22);
            this.txtPass.TabIndex = 33;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(106, 153);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(238, 22);
            this.txtPrenom.TabIndex = 35;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.Location = new System.Drawing.Point(489, 183);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(238, 34);
            this.txtAdresse.TabIndex = 37;
            // 
            // txtVille
            // 
            this.txtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.Location = new System.Drawing.Point(489, 231);
            this.txtVille.Multiline = true;
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(238, 22);
            this.txtVille.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(199, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 33);
            this.label2.TabIndex = 43;
            this.label2.Text = "Modification des informations";
            // 
            // FModifVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(lblCP);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(dateEmbaucheLabel);
            this.Controls.Add(this.txtDateEmbauche);
            this.Controls.Add(identifiantLabel);
            this.Controls.Add(this.txtIdent);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(rueLabel);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.txtVille);
            this.Name = "FModifVisiteur";
            this.Text = "Modification des informations d\'un visiteur";
            this.Load += new System.EventHandler(this.FModifVisiteur_Load);
            this.Controls.SetChildIndex(this.txtVille, 0);
            this.Controls.SetChildIndex(villeLabel, 0);
            this.Controls.SetChildIndex(this.txtAdresse, 0);
            this.Controls.SetChildIndex(rueLabel, 0);
            this.Controls.SetChildIndex(this.txtPrenom, 0);
            this.Controls.SetChildIndex(prenomLabel, 0);
            this.Controls.SetChildIndex(this.txtPass, 0);
            this.Controls.SetChildIndex(passwordLabel, 0);
            this.Controls.SetChildIndex(this.txtNom, 0);
            this.Controls.SetChildIndex(nomLabel, 0);
            this.Controls.SetChildIndex(this.txtIdent, 0);
            this.Controls.SetChildIndex(identifiantLabel, 0);
            this.Controls.SetChildIndex(this.txtDateEmbauche, 0);
            this.Controls.SetChildIndex(dateEmbaucheLabel, 0);
            this.Controls.SetChildIndex(this.txtCP, 0);
            this.Controls.SetChildIndex(lblCP, 0);
            this.Controls.SetChildIndex(this.btnConfirmer, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtDateEmbauche;
        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsVisiteur;
    }
}