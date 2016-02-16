namespace Moteur
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.codF = new System.Windows.Forms.ComboBox();
            this.Designation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Resultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codF
            // 
            this.codF.FormattingEnabled = true;
            this.codF.Location = new System.Drawing.Point(97, 31);
            this.codF.Name = "codF";
            this.codF.Size = new System.Drawing.Size(45, 21);
            this.codF.TabIndex = 0;
            this.codF.SelectedIndexChanged += new System.EventHandler(this.codF_SelectedIndexChanged);
            // 
            // Designation
            // 
            this.Designation.AutoSize = true;
            this.Designation.Location = new System.Drawing.Point(168, 31);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(0, 13);
            this.Designation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultat : ";
            // 
            // Resultat
            // 
            this.Resultat.AutoSize = true;
            this.Resultat.Location = new System.Drawing.Point(104, 66);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(0, 13);
            this.Resultat.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 248);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Designation);
            this.Controls.Add(this.codF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox codF;
        private System.Windows.Forms.Label Designation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Resultat;
    }
}

