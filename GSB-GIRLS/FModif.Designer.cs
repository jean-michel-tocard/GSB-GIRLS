namespace GSB_GIRLS
{
    partial class FModif
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
            this.bsVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVisiteurs = new System.Windows.Forms.DataGridView();
            this.btnModif = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(264, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tous les visiteurs";
            // 
            // dgvVisiteurs
            // 
            this.dgvVisiteurs.AllowUserToAddRows = false;
            this.dgvVisiteurs.AllowUserToDeleteRows = false;
            this.dgvVisiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteurs.Location = new System.Drawing.Point(135, 86);
            this.dgvVisiteurs.Name = "dgvVisiteurs";
            this.dgvVisiteurs.ReadOnly = true;
            this.dgvVisiteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisiteurs.Size = new System.Drawing.Size(531, 205);
            this.dgvVisiteurs.TabIndex = 6;
            // 
            // btnModif
            // 
            this.btnModif.BackColor = System.Drawing.SystemColors.Window;
            this.btnModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModif.Location = new System.Drawing.Point(289, 333);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(197, 29);
            this.btnModif.TabIndex = 7;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // retour
            // 
            this.retour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.Location = new System.Drawing.Point(12, 365);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(77, 26);
            this.retour.TabIndex = 8;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // FModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 403);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.dgvVisiteurs);
            this.Controls.Add(this.label2);
            this.Name = "FModif";
            this.Text = "Modification des informations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FModif_FormClosing);
            this.Load += new System.EventHandler(this.FModif_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dgvVisiteurs, 0);
            this.Controls.SetChildIndex(this.btnModif, 0);
            this.Controls.SetChildIndex(this.retour, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsVisiteurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVisiteurs;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button retour;
    }
}