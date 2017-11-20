namespace GSB_GIRLS
{
    partial class CRVisite
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
            this.dgvRapport = new System.Windows.Forms.DataGridView();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.rtxtBilan = new System.Windows.Forms.RichTextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Modification = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Modif = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMotif = new System.Windows.Forms.ComboBox();
            this.cbNom = new System.Windows.Forms.ComboBox();
            this.cbCloturer = new System.Windows.Forms.CheckBox();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRapport
            // 
            this.dgvRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapport.Location = new System.Drawing.Point(304, 175);
            this.dgvRapport.Name = "dgvRapport";
            this.dgvRapport.Size = new System.Drawing.Size(227, 150);
            this.dgvRapport.TabIndex = 1;
            this.dgvRapport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRapport_CellContentClick);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(105, 85);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(68, 20);
            this.txtNum.TabIndex = 2;
            // 
            // rtxtBilan
            // 
            this.rtxtBilan.Location = new System.Drawing.Point(105, 190);
            this.rtxtBilan.Name = "rtxtBilan";
            this.rtxtBilan.Size = new System.Drawing.Size(170, 135);
            this.rtxtBilan.TabIndex = 3;
            this.rtxtBilan.Text = "";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(105, 138);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(156, 20);
            this.txtPrenom.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Navy;
            this.textBox3.Location = new System.Drawing.Point(54, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(286, 31);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "RAPPORTS DE VISITE";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom Practicien";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prenom Practicien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(41, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Motif Visite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(51, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "BILAN";
            // 
            // Modification
            // 
            this.Modification.AutoSize = true;
            this.Modification.BackColor = System.Drawing.Color.Transparent;
            this.Modification.Location = new System.Drawing.Point(327, 75);
            this.Modification.Name = "Modification";
            this.Modification.Size = new System.Drawing.Size(115, 13);
            this.Modification.TabIndex = 12;
            this.Modification.Text = "Modification de rapport";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Modif
            // 
            this.Modif.Location = new System.Drawing.Point(158, 365);
            this.Modif.Name = "Modif";
            this.Modif.Size = new System.Drawing.Size(70, 23);
            this.Modif.TabIndex = 16;
            this.Modif.Text = "Modifier";
            this.Modif.UseVisualStyleBackColor = true;
            this.Modif.Click += new System.EventHandler(this.Modif_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(14, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Numéro Rapport";
            // 
            // cbMotif
            // 
            this.cbMotif.FormattingEnabled = true;
            this.cbMotif.Location = new System.Drawing.Point(105, 164);
            this.cbMotif.Name = "cbMotif";
            this.cbMotif.Size = new System.Drawing.Size(156, 21);
            this.cbMotif.TabIndex = 19;
            this.cbMotif.SelectedIndexChanged += new System.EventHandler(this.cbMotif_SelectedIndexChanged);
            // 
            // cbNom
            // 
            this.cbNom.FormattingEnabled = true;
            this.cbNom.Location = new System.Drawing.Point(105, 111);
            this.cbNom.Name = "cbNom";
            this.cbNom.Size = new System.Drawing.Size(156, 21);
            this.cbNom.TabIndex = 20;
            this.cbNom.SelectedIndexChanged += new System.EventHandler(this.cbNom_SelectedIndexChanged);
            // 
            // cbCloturer
            // 
            this.cbCloturer.AutoSize = true;
            this.cbCloturer.Location = new System.Drawing.Point(105, 331);
            this.cbCloturer.Name = "cbCloturer";
            this.cbCloturer.Size = new System.Drawing.Size(62, 17);
            this.cbCloturer.TabIndex = 21;
            this.cbCloturer.Text = "Clôturer";
            this.cbCloturer.UseVisualStyleBackColor = true;
            // 
            // CRVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 429);
            this.Controls.Add(this.cbCloturer);
            this.Controls.Add(this.cbNom);
            this.Controls.Add(this.cbMotif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Modif);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Modification);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.rtxtBilan);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.dgvRapport);
            this.Name = "CRVisite";
            this.Text = "CRVisite";
            this.Load += new System.EventHandler(this.CRVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRapport;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.RichTextBox rtxtBilan;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Modification;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Modif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMotif;
        private System.Windows.Forms.ComboBox cbNom;
        private System.Windows.Forms.CheckBox cbCloturer;
        private System.Windows.Forms.BindingSource bsRapport;
    }
}