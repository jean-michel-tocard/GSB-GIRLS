namespace GSB_GIRLS
{
    partial class CreationRapport
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
            this.cbMedecin = new System.Windows.Forms.ComboBox();
            this.cbMotif = new System.Windows.Forms.ComboBox();
            this.cbMed = new System.Windows.Forms.ComboBox();
            this.txtQuantMed = new System.Windows.Forms.TextBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.lbMedecin = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbMotif = new System.Windows.Forms.Label();
            this.lbBilan = new System.Windows.Forms.Label();
            this.lbMed = new System.Windows.Forms.Label();
            this.lbQuant = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lbInformation = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbMedecin
            // 
            this.cbMedecin.FormattingEnabled = true;
            this.cbMedecin.Location = new System.Drawing.Point(181, 27);
            this.cbMedecin.Name = "cbMedecin";
            this.cbMedecin.Size = new System.Drawing.Size(176, 21);
            this.cbMedecin.TabIndex = 0;
            this.cbMedecin.SelectedIndexChanged += new System.EventHandler(this.cbMedecin_SelectedIndexChanged);
            // 
            // cbMotif
            // 
            this.cbMotif.FormattingEnabled = true;
            this.cbMotif.Location = new System.Drawing.Point(181, 105);
            this.cbMotif.Name = "cbMotif";
            this.cbMotif.Size = new System.Drawing.Size(176, 21);
            this.cbMotif.TabIndex = 1;
            this.cbMotif.SelectedIndexChanged += new System.EventHandler(this.cbMotif_SelectedIndexChanged);
            // 
            // cbMed
            // 
            this.cbMed.FormattingEnabled = true;
            this.cbMed.Location = new System.Drawing.Point(181, 179);
            this.cbMed.Name = "cbMed";
            this.cbMed.Size = new System.Drawing.Size(176, 21);
            this.cbMed.TabIndex = 3;
            this.cbMed.SelectedIndexChanged += new System.EventHandler(this.cbMed_SelectedIndexChanged);
            // 
            // txtQuantMed
            // 
            this.txtQuantMed.Location = new System.Drawing.Point(181, 216);
            this.txtQuantMed.Name = "txtQuantMed";
            this.txtQuantMed.Size = new System.Drawing.Size(176, 20);
            this.txtQuantMed.TabIndex = 4;
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(181, 143);
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(176, 20);
            this.txtBilan.TabIndex = 5;
            // 
            // lbMedecin
            // 
            this.lbMedecin.AutoSize = true;
            this.lbMedecin.Location = new System.Drawing.Point(116, 30);
            this.lbMedecin.Name = "lbMedecin";
            this.lbMedecin.Size = new System.Drawing.Size(48, 13);
            this.lbMedecin.TabIndex = 6;
            this.lbMedecin.Text = "Medecin";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(83, 69);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(81, 13);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "Date du rapport";
            // 
            // lbMotif
            // 
            this.lbMotif.AutoSize = true;
            this.lbMotif.Location = new System.Drawing.Point(134, 108);
            this.lbMotif.Name = "lbMotif";
            this.lbMotif.Size = new System.Drawing.Size(30, 13);
            this.lbMotif.TabIndex = 8;
            this.lbMotif.Text = "Motif";
            // 
            // lbBilan
            // 
            this.lbBilan.AutoSize = true;
            this.lbBilan.Location = new System.Drawing.Point(134, 146);
            this.lbBilan.Name = "lbBilan";
            this.lbBilan.Size = new System.Drawing.Size(30, 13);
            this.lbBilan.TabIndex = 9;
            this.lbBilan.Text = "Bilan";
            // 
            // lbMed
            // 
            this.lbMed.AutoSize = true;
            this.lbMed.Location = new System.Drawing.Point(99, 182);
            this.lbMed.Name = "lbMed";
            this.lbMed.Size = new System.Drawing.Size(65, 13);
            this.lbMed.TabIndex = 10;
            this.lbMed.Text = "Medicament";
            // 
            // lbQuant
            // 
            this.lbQuant.AutoSize = true;
            this.lbQuant.Location = new System.Drawing.Point(56, 219);
            this.lbQuant.Name = "lbQuant";
            this.lbQuant.Size = new System.Drawing.Size(108, 13);
            this.lbQuant.TabIndex = 11;
            this.lbQuant.Text = "Quantité Medicament";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(312, 272);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 12;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // lbInformation
            // 
            this.lbInformation.AutoSize = true;
            this.lbInformation.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformation.Location = new System.Drawing.Point(40, 262);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(124, 33);
            this.lbInformation.TabIndex = 13;
            this.lbInformation.Text = "Informations";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(181, 63);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(176, 20);
            this.dtpDate.TabIndex = 14;
            // 
            // CreationRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 337);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.lbQuant);
            this.Controls.Add(this.lbMed);
            this.Controls.Add(this.lbBilan);
            this.Controls.Add(this.lbMotif);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbMedecin);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.txtQuantMed);
            this.Controls.Add(this.cbMed);
            this.Controls.Add(this.cbMotif);
            this.Controls.Add(this.cbMedecin);
            this.Name = "CreationRapport";
            this.Text = "CreationRapport";
            this.Load += new System.EventHandler(this.CreationRapport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMedecin;
        private System.Windows.Forms.ComboBox cbMotif;
        private System.Windows.Forms.ComboBox cbMed;
        private System.Windows.Forms.TextBox txtQuantMed;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.Label lbMedecin;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbMotif;
        private System.Windows.Forms.Label lbBilan;
        private System.Windows.Forms.Label lbMed;
        private System.Windows.Forms.Label lbQuant;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}