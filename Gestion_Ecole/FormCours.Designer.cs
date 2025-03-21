namespace Gestion_Ecole
{
    partial class FormCours
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
            this.txtnomcours = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewcours = new System.Windows.Forms.DataGridView();
            this.btnajout_cours = new System.Windows.Forms.Button();
            this.btnsupp_cours = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcours)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnomcours
            // 
            this.txtnomcours.Location = new System.Drawing.Point(121, 54);
            this.txtnomcours.Multiline = true;
            this.txtnomcours.Name = "txtnomcours";
            this.txtnomcours.Size = new System.Drawing.Size(160, 43);
            this.txtnomcours.TabIndex = 0;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(107, 133);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(283, 99);
            this.txtdescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nomcours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // dataGridViewcours
            // 
            this.dataGridViewcours.AllowUserToAddRows = false;
            this.dataGridViewcours.AllowUserToDeleteRows = false;
            this.dataGridViewcours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcours.Location = new System.Drawing.Point(409, 12);
            this.dataGridViewcours.Name = "dataGridViewcours";
            this.dataGridViewcours.ReadOnly = true;
            this.dataGridViewcours.RowHeadersWidth = 62;
            this.dataGridViewcours.RowTemplate.Height = 28;
            this.dataGridViewcours.Size = new System.Drawing.Size(379, 263);
            this.dataGridViewcours.TabIndex = 4;
            // 
            // btnajout_cours
            // 
            this.btnajout_cours.Location = new System.Drawing.Point(317, 338);
            this.btnajout_cours.Name = "btnajout_cours";
            this.btnajout_cours.Size = new System.Drawing.Size(126, 33);
            this.btnajout_cours.TabIndex = 5;
            this.btnajout_cours.Text = "ajouter";
            this.btnajout_cours.UseVisualStyleBackColor = true;
            this.btnajout_cours.Click += new System.EventHandler(this.btnajout_cours_Click);
            // 
            // btnsupp_cours
            // 
            this.btnsupp_cours.Location = new System.Drawing.Point(467, 338);
            this.btnsupp_cours.Name = "btnsupp_cours";
            this.btnsupp_cours.Size = new System.Drawing.Size(126, 33);
            this.btnsupp_cours.TabIndex = 6;
            this.btnsupp_cours.Text = "supprimer";
            this.btnsupp_cours.UseVisualStyleBackColor = true;
            this.btnsupp_cours.Click += new System.EventHandler(this.btnsupp_cours_Click);
            // 
            // FormCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsupp_cours);
            this.Controls.Add(this.btnajout_cours);
            this.Controls.Add(this.dataGridViewcours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtnomcours);
            this.Name = "FormCours";
            this.Text = "FormCours";
            this.Load += new System.EventHandler(this.FormCours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnomcours;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewcours;
        private System.Windows.Forms.Button btnajout_cours;
        private System.Windows.Forms.Button btnsupp_cours;
    }
}