namespace GSB_GIRLS
{
    partial class Frmtvisiteur
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
            this.dgvVisiteurs = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.bsVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisiteurs
            // 
            this.dgvVisiteurs.AllowUserToAddRows = false;
            this.dgvVisiteurs.AllowUserToDeleteRows = false;
            this.dgvVisiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteurs.Location = new System.Drawing.Point(101, 79);
            this.dgvVisiteurs.Name = "dgvVisiteurs";
            this.dgvVisiteurs.ReadOnly = true;
            this.dgvVisiteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisiteurs.Size = new System.Drawing.Size(531, 230);
            this.dgvVisiteurs.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(226, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tous les visiteurs";
            // 
            // retour
            // 
            this.retour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.Location = new System.Drawing.Point(26, 345);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(77, 26);
            this.retour.TabIndex = 9;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // Ftvisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 387);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.dgvVisiteurs);
            this.Controls.Add(this.label2);
            this.Name = "Ftvisiteur";
            this.Text = "Ftvisiteur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormulaireVisiteurs_FormClosing);
            this.Load += new System.EventHandler(this.FVisiteur_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dgvVisiteurs, 0);
            this.Controls.SetChildIndex(this.retour, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisiteurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.BindingSource bsVisiteurs;
    }
}