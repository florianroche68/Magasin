
namespace magasin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnMagasin = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnMaj = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGerant = new System.Windows.Forms.TextBox();
            this.txtLocalite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCommande = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(163, 71);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(115, 22);
            this.txtNumero.TabIndex = 1;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(311, 71);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(153, 33);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnMagasin
            // 
            this.btnMagasin.Location = new System.Drawing.Point(661, 63);
            this.btnMagasin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMagasin.Name = "btnMagasin";
            this.btnMagasin.Size = new System.Drawing.Size(205, 49);
            this.btnMagasin.TabIndex = 3;
            this.btnMagasin.Text = "Liste des magasins";
            this.btnMagasin.UseVisualStyleBackColor = true;
            this.btnMagasin.Click += new System.EventHandler(this.btnMagasin_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(661, 119);
            this.btnCreer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(205, 47);
            this.btnCreer.TabIndex = 4;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnMaj
            // 
            this.btnMaj.Location = new System.Drawing.Point(661, 174);
            this.btnMaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaj.Name = "btnMaj";
            this.btnMaj.Size = new System.Drawing.Size(205, 47);
            this.btnMaj.TabIndex = 5;
            this.btnMaj.Text = "Mettre à jour";
            this.btnMaj.UseVisualStyleBackColor = true;
            this.btnMaj.Click += new System.EventHandler(this.btnMaj_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(661, 228);
            this.btnSupp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(205, 46);
            this.btnSupp.TabIndex = 6;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGerant);
            this.groupBox1.Controls.Add(this.txtLocalite);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(77, 174);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(501, 180);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            // 
            // txtGerant
            // 
            this.txtGerant.Location = new System.Drawing.Point(112, 103);
            this.txtGerant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGerant.Name = "txtGerant";
            this.txtGerant.Size = new System.Drawing.Size(255, 22);
            this.txtGerant.TabIndex = 3;
            // 
            // txtLocalite
            // 
            this.txtLocalite.Location = new System.Drawing.Point(112, 52);
            this.txtLocalite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocalite.Name = "txtLocalite";
            this.txtLocalite.Size = new System.Drawing.Size(256, 22);
            this.txtLocalite.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gérant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Localité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 377);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choisir une commande";
            // 
            // cboCommande
            // 
            this.cboCommande.FormattingEnabled = true;
            this.cboCommande.Location = new System.Drawing.Point(642, 374);
            this.cboCommande.Name = "cboCommande";
            this.cboCommande.Size = new System.Drawing.Size(184, 24);
            this.cboCommande.TabIndex = 9;
            this.cboCommande.SelectedIndexChanged += new System.EventHandler(this.cboCommande_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 432);
            this.Controls.Add(this.cboCommande);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnMaj);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.btnMagasin);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnMagasin;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnMaj;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGerant;
        private System.Windows.Forms.TextBox txtLocalite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCommande;
    }
}

