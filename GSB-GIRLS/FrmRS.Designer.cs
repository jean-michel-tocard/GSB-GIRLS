namespace GSB_GIRLS
{
    partial class FrmRS
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
            this.bsecteur = new System.Windows.Forms.Button();
            this.bregion = new System.Windows.Forms.Button();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informations concernant les secteurs et régions :";
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(275, 75);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.Size = new System.Drawing.Size(587, 116);
            this.dgvVisiteur.TabIndex = 1;
            // 
            // bsecteur
            // 
            this.bsecteur.BackColor = System.Drawing.SystemColors.Desktop;
            this.bsecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsecteur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bsecteur.Location = new System.Drawing.Point(29, 75);
            this.bsecteur.Name = "bsecteur";
            this.bsecteur.Size = new System.Drawing.Size(110, 38);
            this.bsecteur.TabIndex = 3;
            this.bsecteur.Text = "Secteur";
            this.bsecteur.UseVisualStyleBackColor = false;
            this.bsecteur.Click += new System.EventHandler(this.bsecteur_Click);
            // 
            // bregion
            // 
            this.bregion.BackColor = System.Drawing.SystemColors.Desktop;
            this.bregion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bregion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bregion.Location = new System.Drawing.Point(29, 230);
            this.bregion.Name = "bregion";
            this.bregion.Size = new System.Drawing.Size(110, 38);
            this.bregion.TabIndex = 4;
            this.bregion.Text = "Région";
            this.bregion.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 116);
            this.dataGridView1.TabIndex = 5;
            // 
            // FrmRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bregion);
            this.Controls.Add(this.bsecteur);
            this.Controls.Add(this.dgvVisiteur);
            this.Controls.Add(this.label1);
            this.Name = "FrmRS";
            this.Text = "Régions et secteurs";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgvVisiteur, 0);
            this.Controls.SetChildIndex(this.bsecteur, 0);
            this.Controls.SetChildIndex(this.bregion, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.Button bsecteur;
        private System.Windows.Forms.Button bregion;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}