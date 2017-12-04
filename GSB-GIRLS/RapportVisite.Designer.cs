namespace GSB_GIRLS
{
    partial class RapportVisite
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
            this.cbNum = new System.Windows.Forms.ComboBox();
            this.cbMedicament = new System.Windows.Forms.ComboBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.lbInformation = new System.Windows.Forms.Label();
            this.lbTitre = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.Label();
            this.lbQuantite = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbMedicament = new System.Windows.Forms.Label();
            this.lbMotif = new System.Windows.Forms.Label();
            this.lbBilan = new System.Windows.Forms.Label();
            this.dgv_Rapport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rapport)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNum
            // 
            this.cbNum.FormattingEnabled = true;
            this.cbNum.Location = new System.Drawing.Point(314, 12);
            this.cbNum.Name = "cbNum";
            this.cbNum.Size = new System.Drawing.Size(121, 21);
            this.cbNum.TabIndex = 0;
            this.cbNum.SelectedIndexChanged += new System.EventHandler(this.cbNum_SelectedIndexChanged);
            // 
            // cbMedicament
            // 
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(94, 248);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(100, 21);
            this.cbMedicament.TabIndex = 1;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(314, 270);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(100, 20);
            this.txtQuantite.TabIndex = 3;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(314, 232);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(314, 191);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(94, 191);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 6;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(94, 220);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 7;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(94, 274);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(100, 20);
            this.txtMotif.TabIndex = 8;
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(94, 300);
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(320, 20);
            this.txtBilan.TabIndex = 9;
            // 
            // lbInformation
            // 
            this.lbInformation.AutoSize = true;
            this.lbInformation.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformation.Location = new System.Drawing.Point(18, 323);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(124, 33);
            this.lbInformation.TabIndex = 10;
            this.lbInformation.Text = "Informations";
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Location = new System.Drawing.Point(46, 12);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(116, 13);
            this.lbTitre.TabIndex = 11;
            this.lbTitre.Text = "Visualisation du rapport";
            // 
            // txtNum
            // 
            this.txtNum.AutoSize = true;
            this.txtNum.Location = new System.Drawing.Point(223, 15);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(85, 13);
            this.txtNum.TabIndex = 12;
            this.txtNum.Text = "Numero Rapport";
            // 
            // lbQuantite
            // 
            this.lbQuantite.AutoSize = true;
            this.lbQuantite.Location = new System.Drawing.Point(255, 273);
            this.lbQuantite.Name = "lbQuantite";
            this.lbQuantite.Size = new System.Drawing.Size(47, 13);
            this.lbQuantite.TabIndex = 14;
            this.lbQuantite.Text = "Quantité";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Location = new System.Drawing.Point(215, 235);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(87, 13);
            this.lbPrenom.TabIndex = 15;
            this.lbPrenom.Text = "Prenom Medecin";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(229, 194);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(73, 13);
            this.lbNom.TabIndex = 16;
            this.lbNom.Text = "Nom Medecin";
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(7, 194);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(85, 13);
            this.lbNum.TabIndex = 17;
            this.lbNum.Text = "Numero Rapport";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(21, 223);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(71, 13);
            this.lbDate.TabIndex = 18;
            this.lbDate.Text = "Date Rapport";
            // 
            // lbMedicament
            // 
            this.lbMedicament.AutoSize = true;
            this.lbMedicament.Location = new System.Drawing.Point(23, 251);
            this.lbMedicament.Name = "lbMedicament";
            this.lbMedicament.Size = new System.Drawing.Size(65, 13);
            this.lbMedicament.TabIndex = 19;
            this.lbMedicament.Text = "Medicament";
            // 
            // lbMotif
            // 
            this.lbMotif.AutoSize = true;
            this.lbMotif.Location = new System.Drawing.Point(58, 277);
            this.lbMotif.Name = "lbMotif";
            this.lbMotif.Size = new System.Drawing.Size(30, 13);
            this.lbMotif.TabIndex = 20;
            this.lbMotif.Text = "Motif";
            // 
            // lbBilan
            // 
            this.lbBilan.AutoSize = true;
            this.lbBilan.Location = new System.Drawing.Point(58, 303);
            this.lbBilan.Name = "lbBilan";
            this.lbBilan.Size = new System.Drawing.Size(30, 13);
            this.lbBilan.TabIndex = 21;
            this.lbBilan.Text = "Bilan";
            // 
            // dgv_Rapport
            // 
            this.dgv_Rapport.AllowUserToAddRows = false;
            this.dgv_Rapport.AllowUserToDeleteRows = false;
            this.dgv_Rapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rapport.Location = new System.Drawing.Point(9, 36);
            this.dgv_Rapport.Name = "dgv_Rapport";
            this.dgv_Rapport.ReadOnly = true;
            this.dgv_Rapport.Size = new System.Drawing.Size(434, 149);
            this.dgv_Rapport.TabIndex = 22;
            this.dgv_Rapport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRapport_CellContentClick);
            // 
            // RapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 365);
            this.Controls.Add(this.dgv_Rapport);
            this.Controls.Add(this.lbBilan);
            this.Controls.Add(this.lbMotif);
            this.Controls.Add(this.lbMedicament);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.lbQuantite);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lbTitre);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.cbMedicament);
            this.Controls.Add(this.cbNum);
            this.Name = "RapportVisite";
            this.Text = "RapportVisite";
            this.Load += new System.EventHandler(this.RapportVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNum;
        private System.Windows.Forms.ComboBox cbMedicament;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.Label txtNum;
        private System.Windows.Forms.Label lbQuantite;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbMedicament;
        private System.Windows.Forms.Label lbMotif;
        private System.Windows.Forms.Label lbBilan;
        private System.Windows.Forms.DataGridView dgv_Rapport;
    }
}