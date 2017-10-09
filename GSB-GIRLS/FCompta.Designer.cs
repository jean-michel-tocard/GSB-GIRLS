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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkSuiviFiche = new System.Windows.Forms.LinkLabel();
            this.linkEdition = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 281);
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
            // linkSuiviFiche
            // 
            this.linkSuiviFiche.AutoSize = true;
            this.linkSuiviFiche.Location = new System.Drawing.Point(21, 234);
            this.linkSuiviFiche.Name = "linkSuiviFiche";
            this.linkSuiviFiche.Size = new System.Drawing.Size(98, 13);
            this.linkSuiviFiche.TabIndex = 8;
            this.linkSuiviFiche.TabStop = true;
            this.linkSuiviFiche.Text = "Suivi fiches de frais";
            this.linkSuiviFiche.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSuiviFiche_LinkClicked);
            // 
            // linkEdition
            // 
            this.linkEdition.AutoSize = true;
            this.linkEdition.Location = new System.Drawing.Point(18, 209);
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
            this.label1.Location = new System.Drawing.Point(392, 64);
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
            // FCompta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 515);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkSuiviFiche);
            this.Controls.Add(this.linkEdition);
            this.Controls.Add(this.label1);
            this.Name = "FCompta";
            this.Text = "FSuiviC";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkSuiviFiche;
        private System.Windows.Forms.LinkLabel linkEdition;
        private System.Windows.Forms.Label label1;
    }
}