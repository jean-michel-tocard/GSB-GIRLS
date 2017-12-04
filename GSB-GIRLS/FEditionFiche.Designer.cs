namespace GSB_GIRLS
{
    partial class FEditionFiche
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkAccCompt = new System.Windows.Forms.LinkLabel();
            this.tbMatricule = new System.Windows.Forms.TextBox();
            this.tbComptable = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Comptable : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Montant des fiches du mois : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 385);
            this.dataGridView1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSB_GIRLS.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Suivi du remboursement des frais";
            // 
            // linkAccCompt
            // 
            this.linkAccCompt.AutoSize = true;
            this.linkAccCompt.Location = new System.Drawing.Point(0, 269);
            this.linkAccCompt.Name = "linkAccCompt";
            this.linkAccCompt.Size = new System.Drawing.Size(95, 13);
            this.linkAccCompt.TabIndex = 21;
            this.linkAccCompt.TabStop = true;
            this.linkAccCompt.Text = "Accueil Comptable";
            this.linkAccCompt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAccCompt_LinkClicked_1);
            // 
            // tbMatricule
            // 
            this.tbMatricule.Enabled = false;
            this.tbMatricule.Location = new System.Drawing.Point(88, 196);
            this.tbMatricule.Name = "tbMatricule";
            this.tbMatricule.Size = new System.Drawing.Size(155, 20);
            this.tbMatricule.TabIndex = 71;
            // 
            // tbComptable
            // 
            this.tbComptable.Enabled = false;
            this.tbComptable.Location = new System.Drawing.Point(88, 170);
            this.tbComptable.Name = "tbComptable";
            this.tbComptable.Size = new System.Drawing.Size(155, 20);
            this.tbComptable.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Matricule :";
            // 
            // FEditionFiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 807);
            this.Controls.Add(this.tbMatricule);
            this.Controls.Add(this.tbComptable);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkAccCompt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FEditionFiche";
            this.Text = "FEditionFiche";
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.linkAccCompt, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.tbComptable, 0);
            this.Controls.SetChildIndex(this.tbMatricule, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkAccCompt;
        private System.Windows.Forms.TextBox tbMatricule;
        private System.Windows.Forms.TextBox tbComptable;
        private System.Windows.Forms.Label label9;
    }
}