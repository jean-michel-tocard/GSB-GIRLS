namespace GSB_GIRLS
{
    partial class FRegion
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
            this.label2 = new System.Windows.Forms.Label();
            this.bsregion = new System.Windows.Forms.BindingSource(this.components);
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.retour = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxnom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxprenom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxrue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxville = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxcp = new System.Windows.Forms.TextBox();
            this.dgvVisiteurs = new System.Windows.Forms.DataGridView();
            this.bsVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.dateEmbaucheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsregion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(30, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Régions";
            // 
            // cboRegion
            // 
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(342, 33);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(283, 21);
            this.cboRegion.TabIndex = 7;
            this.cboRegion.SelectedIndexChanged += new System.EventHandler(this.cboRegion_SelectedIndexChanged);
            // 
            // retour
            // 
            this.retour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.Location = new System.Drawing.Point(22, 378);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(77, 26);
            this.retour.TabIndex = 8;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(128, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Responsable";
            // 
            // textBoxnom
            // 
            this.textBoxnom.Location = new System.Drawing.Point(206, 146);
            this.textBoxnom.Name = "textBoxnom";
            this.textBoxnom.Size = new System.Drawing.Size(158, 20);
            this.textBoxnom.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(128, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(128, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Prénom :";
            // 
            // textBoxprenom
            // 
            this.textBoxprenom.Location = new System.Drawing.Point(206, 188);
            this.textBoxprenom.Name = "textBoxprenom";
            this.textBoxprenom.Size = new System.Drawing.Size(158, 20);
            this.textBoxprenom.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(126, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Rue :";
            // 
            // textBoxrue
            // 
            this.textBoxrue.Location = new System.Drawing.Point(206, 227);
            this.textBoxrue.Name = "textBoxrue";
            this.textBoxrue.Size = new System.Drawing.Size(158, 20);
            this.textBoxrue.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(126, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ville :";
            // 
            // textBoxville
            // 
            this.textBoxville.Location = new System.Drawing.Point(206, 269);
            this.textBoxville.Name = "textBoxville";
            this.textBoxville.Size = new System.Drawing.Size(158, 20);
            this.textBoxville.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(126, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cp :";
            // 
            // textBoxcp
            // 
            this.textBoxcp.Location = new System.Drawing.Point(206, 311);
            this.textBoxcp.Name = "textBoxcp";
            this.textBoxcp.Size = new System.Drawing.Size(158, 20);
            this.textBoxcp.TabIndex = 19;
            // 
            // dgvVisiteurs
            // 
            this.dgvVisiteurs.AutoGenerateColumns = false;
            this.dgvVisiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVisiteurDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.rueDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.dateEmbaucheDataGridViewTextBoxColumn});
            this.dgvVisiteurs.DataSource = this.bsVisiteurs;
            this.dgvVisiteurs.Location = new System.Drawing.Point(399, 102);
            this.dgvVisiteurs.Name = "dgvVisiteurs";
            this.dgvVisiteurs.Size = new System.Drawing.Size(445, 187);
            this.dgvVisiteurs.TabIndex = 21;
            // 
            // bsVisiteurs
            // 
            this.bsVisiteurs.DataSource = typeof(GSB_GIRLS.Visiteur);
            // 
            // dateEmbaucheDataGridViewTextBoxColumn
            // 
            this.dateEmbaucheDataGridViewTextBoxColumn.DataPropertyName = "dateEmbauche";
            this.dateEmbaucheDataGridViewTextBoxColumn.HeaderText = "dateEmbauche";
            this.dateEmbaucheDataGridViewTextBoxColumn.Name = "dateEmbaucheDataGridViewTextBoxColumn";
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "cp";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            // 
            // rueDataGridViewTextBoxColumn
            // 
            this.rueDataGridViewTextBoxColumn.DataPropertyName = "rue";
            this.rueDataGridViewTextBoxColumn.HeaderText = "rue";
            this.rueDataGridViewTextBoxColumn.Name = "rueDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // idVisiteurDataGridViewTextBoxColumn
            // 
            this.idVisiteurDataGridViewTextBoxColumn.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.HeaderText = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.Name = "idVisiteurDataGridViewTextBoxColumn";
            // 
            // FRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 419);
            this.Controls.Add(this.dgvVisiteurs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxcp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxville);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxrue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxprenom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxnom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.label2);
            this.Name = "FRegion";
            this.Text = "FRegion";
            this.Load += new System.EventHandler(this.FRegion_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cboRegion, 0);
            this.Controls.SetChildIndex(this.retour, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBoxnom, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBoxprenom, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBoxrue, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.textBoxville, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.textBoxcp, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.dgvVisiteurs, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsregion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsregion;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxnom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxprenom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxrue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxville;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxcp;
        private System.Windows.Forms.DataGridView dgvVisiteurs;
        private System.Windows.Forms.BindingSource bsVisiteurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmbaucheDataGridViewTextBoxColumn;
    }
}