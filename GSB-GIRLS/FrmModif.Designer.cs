namespace GSB_GIRLS
{
    partial class FrmModif
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
            this.retour2 = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
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
            this.btnModif.Location = new System.Drawing.Point(476, 333);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(106, 29);
            this.btnModif.TabIndex = 7;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // retour2
            // 
            this.retour2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.retour2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour2.Location = new System.Drawing.Point(12, 365);
            this.retour2.Name = "retour2";
            this.retour2.Size = new System.Drawing.Size(77, 26);
            this.retour2.TabIndex = 8;
            this.retour2.Text = "Retour";
            this.retour2.UseVisualStyleBackColor = false;
            this.retour2.Click += new System.EventHandler(this.retour_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.SystemColors.Window;
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Location = new System.Drawing.Point(335, 333);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(109, 29);
            this.btnajouter.TabIndex = 9;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.bajouter_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.BackColor = System.Drawing.SystemColors.Window;
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.Location = new System.Drawing.Point(195, 333);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(101, 29);
            this.btnSupp.TabIndex = 10;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = false;
            this.btnSupp.Visible = false;
            //this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // FModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 403);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.retour2);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.dgvVisiteurs);
            this.Controls.Add(this.label2);
            this.Name = "FModif";
            this.Text = "Toutes des informations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FModif_FormClosing);
            this.Load += new System.EventHandler(this.FModif_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dgvVisiteurs, 0);
            this.Controls.SetChildIndex(this.btnModif, 0);
            this.Controls.SetChildIndex(this.retour2, 0);
            this.Controls.SetChildIndex(this.btnajouter, 0);
            this.Controls.SetChildIndex(this.btnSupp, 0);
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
        private System.Windows.Forms.Button retour2;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnSupp;
    }
}