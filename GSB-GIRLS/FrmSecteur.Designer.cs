namespace GSB_GIRLS
{
    partial class FrmSecteur
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
            this.cboSecteur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVisiteurs = new System.Windows.Forms.DataGridView();
            this.bsVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.bssecteur = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxcp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxville = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxrue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxprenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssecteur)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSecteur
            // 
            this.cboSecteur.FormattingEnabled = true;
            this.cboSecteur.Location = new System.Drawing.Point(355, 38);
            this.cboSecteur.Name = "cboSecteur";
            this.cboSecteur.Size = new System.Drawing.Size(283, 21);
            this.cboSecteur.TabIndex = 9;
            this.cboSecteur.SelectedIndexChanged += new System.EventHandler(this.cboSecteur_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(43, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Secteurs";
            // 
            // dgvVisiteurs
            // 
            this.dgvVisiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteurs.Location = new System.Drawing.Point(368, 107);
            this.dgvVisiteurs.Name = "dgvVisiteurs";
            this.dgvVisiteurs.Size = new System.Drawing.Size(405, 187);
            this.dgvVisiteurs.TabIndex = 22;
            // 
            // bsVisiteurs
            // 
            this.bsVisiteurs.DataSource = typeof(GSB_GIRLS.Visiteur);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(72, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Cp :";
            // 
            // textBoxcp
            // 
            this.textBoxcp.Location = new System.Drawing.Point(152, 287);
            this.textBoxcp.Name = "textBoxcp";
            this.textBoxcp.Size = new System.Drawing.Size(158, 20);
            this.textBoxcp.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(72, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ville :";
            // 
            // textBoxville
            // 
            this.textBoxville.Location = new System.Drawing.Point(152, 245);
            this.textBoxville.Name = "textBoxville";
            this.textBoxville.Size = new System.Drawing.Size(158, 20);
            this.textBoxville.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(72, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Rue :";
            // 
            // textBoxrue
            // 
            this.textBoxrue.Location = new System.Drawing.Point(152, 203);
            this.textBoxrue.Name = "textBoxrue";
            this.textBoxrue.Size = new System.Drawing.Size(158, 20);
            this.textBoxrue.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(74, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Prénom :";
            // 
            // textBoxprenom
            // 
            this.textBoxprenom.Location = new System.Drawing.Point(152, 164);
            this.textBoxprenom.Name = "textBoxprenom";
            this.textBoxprenom.Size = new System.Drawing.Size(158, 20);
            this.textBoxprenom.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(74, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nom :";
            // 
            // textBoxnom
            // 
            this.textBoxnom.Location = new System.Drawing.Point(152, 122);
            this.textBoxnom.Name = "textBoxnom";
            this.textBoxnom.Size = new System.Drawing.Size(158, 20);
            this.textBoxnom.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Responsable";
            // 
            // retour
            // 
            this.retour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.Location = new System.Drawing.Point(12, 364);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(77, 26);
            this.retour.TabIndex = 34;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // FSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 402);
            this.Controls.Add(this.retour);
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
            this.Controls.Add(this.dgvVisiteurs);
            this.Controls.Add(this.cboSecteur);
            this.Controls.Add(this.label2);
            this.Name = "FSecteur";
            this.Text = "FSecteur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormulaireVisiteurs_FormClosing);
            this.Load += new System.EventHandler(this.FSecteur_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cboSecteur, 0);
            this.Controls.SetChildIndex(this.dgvVisiteurs, 0);
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
            this.Controls.SetChildIndex(this.retour, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssecteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSecteur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVisiteurs;
        private System.Windows.Forms.BindingSource bsVisiteurs;
        private System.Windows.Forms.BindingSource bssecteur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxcp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxville;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxrue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxprenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button retour;
    }
}