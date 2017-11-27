namespace GSB_GIRLS
{
    partial class FCompta
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkEdition = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboChoixV = new System.Windows.Forms.ComboBox();
            this.cboMois = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvFraisForfait = new System.Windows.Forms.DataGridView();
            this.dgvFraisHorsForfait = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bsChoixV = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bsFraisForfait = new System.Windows.Forms.BindingSource(this.components);
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.bsMois = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisHorsForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChoixV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMois)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(18, 301);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Déconnexion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Comptable : ";
            // 
            // linkEdition
            // 
            this.linkEdition.AutoSize = true;
            this.linkEdition.Location = new System.Drawing.Point(18, 264);
            this.linkEdition.Name = "linkEdition";
            this.linkEdition.Size = new System.Drawing.Size(109, 13);
            this.linkEdition.TabIndex = 7;
            this.linkEdition.TabStop = true;
            this.linkEdition.Text = "Edition fiches du mois";
            this.linkEdition.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdition_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suivi du rembourssement des frais";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSB_GIRLS.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Choix du visiteur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(749, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mois :";
            // 
            // cboChoixV
            // 
            this.cboChoixV.FormattingEnabled = true;
            this.cboChoixV.Location = new System.Drawing.Point(474, 135);
            this.cboChoixV.Name = "cboChoixV";
            this.cboChoixV.Size = new System.Drawing.Size(121, 21);
            this.cboChoixV.TabIndex = 14;
            this.cboChoixV.SelectedIndexChanged += new System.EventHandler(this.cboChoixV_SelectedIndexChanged);
            // 
            // cboMois
            // 
            this.cboMois.FormattingEnabled = true;
            this.cboMois.Location = new System.Drawing.Point(814, 135);
            this.cboMois.Name = "cboMois";
            this.cboMois.Size = new System.Drawing.Size(121, 21);
            this.cboMois.TabIndex = 15;
            this.cboMois.SelectedIndexChanged += new System.EventHandler(this.cboMois_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "frais au forfait";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "frais hors forfait";
            // 
            // dgvFraisForfait
            // 
            this.dgvFraisForfait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFraisForfait.Location = new System.Drawing.Point(306, 246);
            this.dgvFraisForfait.Name = "dgvFraisForfait";
            this.dgvFraisForfait.Size = new System.Drawing.Size(756, 122);
            this.dgvFraisForfait.TabIndex = 18;
            // 
            // dgvFraisHorsForfait
            // 
            this.dgvFraisHorsForfait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFraisHorsForfait.Location = new System.Drawing.Point(306, 465);
            this.dgvFraisHorsForfait.Name = "dgvFraisHorsForfait";
            this.dgvFraisHorsForfait.Size = new System.Drawing.Size(756, 255);
            this.dgvFraisHorsForfait.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nombre de justificatifs : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 794);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Valider cette fiche";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 487);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(962, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Actualiser";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(962, 726);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Actualiser";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(508, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Validation des frais par Comptable";
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(82, 169);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(155, 20);
            this.txtNom.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Matricule :";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Enabled = false;
            this.txtMatricule.Location = new System.Drawing.Point(73, 209);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(164, 20);
            this.txtMatricule.TabIndex = 64;
            // 
            // FCompta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 874);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvFraisHorsForfait);
            this.Controls.Add(this.dgvFraisForfait);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboMois);
            this.Controls.Add(this.cboChoixV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkEdition);
            this.Controls.Add(this.label1);
            this.Name = "FCompta";
            this.Text = "FCompta";
            this.Load += new System.EventHandler(this.FCompta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisHorsForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChoixV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMois)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkEdition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboChoixV;
        private System.Windows.Forms.ComboBox cboMois;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvFraisForfait;
        private System.Windows.Forms.DataGridView dgvFraisHorsForfait;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bsChoixV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bsFraisForfait;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.BindingSource bsMois;
    }
}