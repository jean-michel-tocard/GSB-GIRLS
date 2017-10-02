namespace GSB_GIRLS
{
    partial class ListeVisiteur
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.bLabo = new System.Windows.Forms.Button();
            this.bsecteur = new System.Windows.Forms.Button();
            this.bregion = new System.Windows.Forms.Button();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des visiteurs après sélection d\'un laboratoire, d\'un secteur ou d\'une régio" +
    "n :";
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(307, 76);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.Size = new System.Drawing.Size(357, 296);
            this.dgvVisiteur.TabIndex = 1;
            // 
            // bLabo
            // 
            this.bLabo.BackColor = System.Drawing.SystemColors.Desktop;
            this.bLabo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bLabo.Location = new System.Drawing.Point(29, 130);
            this.bLabo.Name = "bLabo";
            this.bLabo.Size = new System.Drawing.Size(110, 38);
            this.bLabo.TabIndex = 2;
            this.bLabo.Text = "Laboratoire";
            this.bLabo.UseVisualStyleBackColor = false;
            this.bLabo.Click += new System.EventHandler(this.bLabo_Click);
            // 
            // bsecteur
            // 
            this.bsecteur.BackColor = System.Drawing.SystemColors.Desktop;
            this.bsecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsecteur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bsecteur.Location = new System.Drawing.Point(29, 191);
            this.bsecteur.Name = "bsecteur";
            this.bsecteur.Size = new System.Drawing.Size(110, 38);
            this.bsecteur.TabIndex = 3;
            this.bsecteur.Text = "Secteur";
            this.bsecteur.UseVisualStyleBackColor = false;
            // 
            // bregion
            // 
            this.bregion.BackColor = System.Drawing.SystemColors.Desktop;
            this.bregion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bregion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bregion.Location = new System.Drawing.Point(29, 252);
            this.bregion.Name = "bregion";
            this.bregion.Size = new System.Drawing.Size(110, 38);
            this.bregion.TabIndex = 4;
            this.bregion.Text = "Région";
            this.bregion.UseVisualStyleBackColor = false;
            // 
            // ListeVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(676, 411);
            this.Controls.Add(this.bregion);
            this.Controls.Add(this.bsecteur);
            this.Controls.Add(this.bLabo);
            this.Controls.Add(this.dgvVisiteur);
            this.Controls.Add(this.label1);
            this.Name = "ListeVisiteur";
            this.Text = "Liste des visiteurs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.Button bLabo;
        private System.Windows.Forms.Button bsecteur;
        private System.Windows.Forms.Button bregion;
        private System.Windows.Forms.BindingSource bsVisiteur;
    }
}