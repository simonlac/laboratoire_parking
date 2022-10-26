namespace Laboratoire
{
    partial class Formulaire
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAfficherParking = new System.Windows.Forms.Button();
            this.btnCreerParking = new System.Windows.Forms.Button();
            this.textBoxTaille = new System.Windows.Forms.TextBox();
            this.textBoxNomParking = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSortirVoiture = new System.Windows.Forms.Button();
            this.btnEntrerVoiture = new System.Windows.Forms.Button();
            this.textBoxCouleur = new System.Windows.Forms.TextBox();
            this.textBoxModele = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMarque = new System.Windows.Forms.TextBox();
            this.textBoxNumeroPlaque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(33, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.btnAfficherParking);
            this.tabPage1.Controls.Add(this.btnCreerParking);
            this.tabPage1.Controls.Add(this.textBoxTaille);
            this.tabPage1.Controls.Add(this.textBoxNomParking);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info parking";
            
            // 
            // btnAfficherParking
            // 
            this.btnAfficherParking.Enabled = false;
            this.btnAfficherParking.Location = new System.Drawing.Point(31, 223);
            this.btnAfficherParking.Name = "btnAfficherParking";
            this.btnAfficherParking.Size = new System.Drawing.Size(168, 41);
            this.btnAfficherParking.TabIndex = 5;
            this.btnAfficherParking.Text = "Afficher parking";
            this.btnAfficherParking.UseVisualStyleBackColor = true;
            this.btnAfficherParking.Click += new System.EventHandler(this.btnAfficherParking_Click);
            // 
            // btnCreerParking
            // 
            this.btnCreerParking.Location = new System.Drawing.Point(269, 224);
            this.btnCreerParking.Name = "btnCreerParking";
            this.btnCreerParking.Size = new System.Drawing.Size(139, 40);
            this.btnCreerParking.TabIndex = 4;
            this.btnCreerParking.Text = "Créer parking";
            this.btnCreerParking.UseVisualStyleBackColor = true;
            this.btnCreerParking.Click += new System.EventHandler(this.btn_CreerParking_Click);
            // 
            // textBoxTaille
            // 
            this.textBoxTaille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaille.Location = new System.Drawing.Point(29, 146);
            this.textBoxTaille.Name = "textBoxTaille";
            this.textBoxTaille.Size = new System.Drawing.Size(125, 28);
            this.textBoxTaille.TabIndex = 3;
            this.textBoxTaille.Text = "Taper la taille";
            // 
            // textBoxNomParking
            // 
            this.textBoxNomParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomParking.Location = new System.Drawing.Point(29, 64);
            this.textBoxNomParking.Name = "textBoxNomParking";
            this.textBoxNomParking.Size = new System.Drawing.Size(125, 28);
            this.textBoxNomParking.TabIndex = 2;
            this.textBoxNomParking.Text = "Taper le nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taille";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage2.Controls.Add(this.btnSortirVoiture);
            this.tabPage2.Controls.Add(this.btnEntrerVoiture);
            this.tabPage2.Controls.Add(this.textBoxCouleur);
            this.tabPage2.Controls.Add(this.textBoxModele);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBoxMarque);
            this.tabPage2.Controls.Add(this.textBoxNumeroPlaque);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "InfoVoiture";
            // 
            // btnSortirVoiture
            // 
            this.btnSortirVoiture.Enabled = false;
            this.btnSortirVoiture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortirVoiture.Location = new System.Drawing.Point(263, 308);
            this.btnSortirVoiture.Name = "btnSortirVoiture";
            this.btnSortirVoiture.Size = new System.Drawing.Size(183, 44);
            this.btnSortirVoiture.TabIndex = 9;
            this.btnSortirVoiture.Text = "Sortir voiture";
            this.btnSortirVoiture.UseVisualStyleBackColor = true;
            this.btnSortirVoiture.Click += new System.EventHandler(this.SortirVoiture_Click);
            // 
            // btnEntrerVoiture
            // 
            this.btnEntrerVoiture.Enabled = false;
            this.btnEntrerVoiture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrerVoiture.Location = new System.Drawing.Point(33, 308);
            this.btnEntrerVoiture.Name = "btnEntrerVoiture";
            this.btnEntrerVoiture.Size = new System.Drawing.Size(183, 43);
            this.btnEntrerVoiture.TabIndex = 8;
            this.btnEntrerVoiture.Text = "Entrer voiture";
            this.btnEntrerVoiture.UseVisualStyleBackColor = true;
            this.btnEntrerVoiture.Click += new System.EventHandler(this.btnEntrerVoiture_Click);
            // 
            // textBoxCouleur
            // 
            this.textBoxCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCouleur.Location = new System.Drawing.Point(33, 249);
            this.textBoxCouleur.Name = "textBoxCouleur";
            this.textBoxCouleur.Size = new System.Drawing.Size(183, 28);
            this.textBoxCouleur.TabIndex = 7;
            this.textBoxCouleur.Text = "Taper la couleur ";
            // 
            // textBoxModele
            // 
            this.textBoxModele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModele.Location = new System.Drawing.Point(33, 189);
            this.textBoxModele.Name = "textBoxModele";
            this.textBoxModele.Size = new System.Drawing.Size(183, 28);
            this.textBoxModele.TabIndex = 6;
            this.textBoxModele.Text = "Taper le modèle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Couleur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Modèle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marque";
            // 
            // textBoxMarque
            // 
            this.textBoxMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarque.Location = new System.Drawing.Point(35, 122);
            this.textBoxMarque.Name = "textBoxMarque";
            this.textBoxMarque.Size = new System.Drawing.Size(181, 28);
            this.textBoxMarque.TabIndex = 2;
            this.textBoxMarque.Text = "Taper la marque";
            // 
            // textBoxNumeroPlaque
            // 
            this.textBoxNumeroPlaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroPlaque.Location = new System.Drawing.Point(33, 58);
            this.textBoxNumeroPlaque.Name = "textBoxNumeroPlaque";
            this.textBoxNumeroPlaque.Size = new System.Drawing.Size(183, 28);
            this.textBoxNumeroPlaque.TabIndex = 1;
            this.textBoxNumeroPlaque.Text = "Taper le numéro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numéro plaque";
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Formulaire";
            this.Text = "Laboratoire";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAfficherParking;
        private System.Windows.Forms.Button btnCreerParking;
        private System.Windows.Forms.TextBox textBoxTaille;
        private System.Windows.Forms.TextBox textBoxNomParking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxCouleur;
        private System.Windows.Forms.TextBox textBoxModele;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMarque;
        private System.Windows.Forms.TextBox textBoxNumeroPlaque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSortirVoiture;
        private System.Windows.Forms.Button btnEntrerVoiture;
    }
}

