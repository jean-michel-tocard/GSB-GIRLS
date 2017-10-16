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
            this.dgvSecteur = new System.Windows.Forms.DataGridView();
            this.bsecteur = new System.Windows.Forms.Button();
            this.bregion = new System.Windows.Forms.Button();
            this.bsSecteur = new System.Windows.Forms.BindingSource(this.components);
            this.dgvRegion = new System.Windows.Forms.DataGridView();
            this.bretour = new System.Windows.Forms.Button();
            this.bmodifier = new System.Windows.Forms.Button();
            this.bajouter = new System.Windows.Forms.Button();
            this.bsupprimer = new System.Windows.Forms.Button();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informations concernant les secteurs et régions :";
            // 
            // dgvSecteur
            // 
            this.dgvSecteur.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSecteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecteur.Location = new System.Drawing.Point(275, 75);
            this.dgvSecteur.Name = "dgvSecteur";
            this.dgvSecteur.Size = new System.Drawing.Size(624, 116);
            this.dgvSecteur.TabIndex = 1;
            // 
            // bsecteur
            // 
            this.bsecteur.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bsecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsecteur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bsecteur.Location = new System.Drawing.Point(29, 87);
            this.bsecteur.Name = "bsecteur";
            this.bsecteur.Size = new System.Drawing.Size(110, 38);
            this.bsecteur.TabIndex = 3;
            this.bsecteur.Text = "Secteur";
            this.bsecteur.UseVisualStyleBackColor = false;
            this.bsecteur.Click += new System.EventHandler(this.bsecteur_Click);
            // 
            // bregion
            // 
            this.bregion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bregion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bregion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bregion.Location = new System.Drawing.Point(29, 228);
            this.bregion.Name = "bregion";
            this.bregion.Size = new System.Drawing.Size(110, 38);
            this.bregion.TabIndex = 4;
            this.bregion.Text = "Région";
            this.bregion.UseVisualStyleBackColor = false;
            // 
            // dgvRegion
            // 
            this.dgvRegion.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegion.Location = new System.Drawing.Point(275, 215);
            this.dgvRegion.Name = "dgvRegion";
            this.dgvRegion.Size = new System.Drawing.Size(624, 116);
            this.dgvRegion.TabIndex = 5;
            // 
            // bretour
            // 
            this.bretour.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bretour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bretour.Location = new System.Drawing.Point(714, 507);
            this.bretour.Name = "bretour";
            this.bretour.Size = new System.Drawing.Size(101, 43);
            this.bretour.TabIndex = 6;
            this.bretour.Text = "Retour";
            this.bretour.UseVisualStyleBackColor = false;
            this.bretour.Click += new System.EventHandler(this.button1_Click);
            // 
            // bmodifier
            // 
            this.bmodifier.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodifier.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bmodifier.Location = new System.Drawing.Point(353, 452);
            this.bmodifier.Name = "bmodifier";
            this.bmodifier.Size = new System.Drawing.Size(110, 38);
            this.bmodifier.TabIndex = 7;
            this.bmodifier.Text = "Modifier";
            this.bmodifier.UseVisualStyleBackColor = false;
            // 
            // bajouter
            // 
            this.bajouter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajouter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bajouter.Location = new System.Drawing.Point(207, 452);
            this.bajouter.Name = "bajouter";
            this.bajouter.Size = new System.Drawing.Size(110, 38);
            this.bajouter.TabIndex = 8;
            this.bajouter.Text = "Ajouter";
            this.bajouter.UseVisualStyleBackColor = false;
            // 
            // bsupprimer
            // 
            this.bsupprimer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bsupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bsupprimer.Location = new System.Drawing.Point(500, 452);
            this.bsupprimer.Name = "bsupprimer";
            this.bsupprimer.Size = new System.Drawing.Size(110, 38);
            this.bsupprimer.TabIndex = 9;
            this.bsupprimer.Text = "Supprimer";
            this.bsupprimer.UseVisualStyleBackColor = false;
            // 
            // FrmRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(992, 573);
            this.Controls.Add(this.bsupprimer);
            this.Controls.Add(this.bajouter);
            this.Controls.Add(this.bmodifier);
            this.Controls.Add(this.bretour);
            this.Controls.Add(this.dgvRegion);
            this.Controls.Add(this.bregion);
            this.Controls.Add(this.bsecteur);
            this.Controls.Add(this.dgvSecteur);
            this.Controls.Add(this.label1);
            this.Name = "FrmRS";
            this.Text = "Régions et secteurs";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgvSecteur, 0);
            this.Controls.SetChildIndex(this.bsecteur, 0);
            this.Controls.SetChildIndex(this.bregion, 0);
            this.Controls.SetChildIndex(this.dgvRegion, 0);
            this.Controls.SetChildIndex(this.bretour, 0);
            this.Controls.SetChildIndex(this.bmodifier, 0);
            this.Controls.SetChildIndex(this.bajouter, 0);
            this.Controls.SetChildIndex(this.bsupprimer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSecteur;
        private System.Windows.Forms.Button bsecteur;
        private System.Windows.Forms.Button bregion;
        private System.Windows.Forms.BindingSource bsSecteur;
        private System.Windows.Forms.DataGridView dgvRegion;
        private System.Windows.Forms.Button bretour;
        private System.Windows.Forms.Button bmodifier;
        private System.Windows.Forms.Button bajouter;
        private System.Windows.Forms.Button bsupprimer;
        private System.Windows.Forms.BindingSource bsRegion;
    }
}