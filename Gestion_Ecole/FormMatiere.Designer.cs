namespace Gestion_Ecole
{
    partial class FormMatiere
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
            this.dataGridViewmatiere = new System.Windows.Forms.DataGridView();
            this.txtnommatiere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcours = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ajoutmatiere = new System.Windows.Forms.Button();
            this.btnsupp_matiere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmatiere)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewmatiere
            // 
            this.dataGridViewmatiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmatiere.Location = new System.Drawing.Point(337, 8);
            this.dataGridViewmatiere.Name = "dataGridViewmatiere";
            this.dataGridViewmatiere.RowHeadersWidth = 62;
            this.dataGridViewmatiere.RowTemplate.Height = 28;
            this.dataGridViewmatiere.Size = new System.Drawing.Size(459, 227);
            this.dataGridViewmatiere.TabIndex = 0;
            // 
            // txtnommatiere
            // 
            this.txtnommatiere.Location = new System.Drawing.Point(108, 106);
            this.txtnommatiere.Multiline = true;
            this.txtnommatiere.Name = "txtnommatiere";
            this.txtnommatiere.Size = new System.Drawing.Size(152, 43);
            this.txtnommatiere.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matiere";
            // 
            // cmbcours
            // 
            this.cmbcours.FormattingEnabled = true;
            this.cmbcours.Location = new System.Drawing.Point(118, 192);
            this.cmbcours.Name = "cmbcours";
            this.cmbcours.Size = new System.Drawing.Size(142, 28);
            this.cmbcours.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cours";
            // 
            // btn_ajoutmatiere
            // 
            this.btn_ajoutmatiere.Location = new System.Drawing.Point(421, 332);
            this.btn_ajoutmatiere.Name = "btn_ajoutmatiere";
            this.btn_ajoutmatiere.Size = new System.Drawing.Size(134, 34);
            this.btn_ajoutmatiere.TabIndex = 5;
            this.btn_ajoutmatiere.Text = "ajouter";
            this.btn_ajoutmatiere.UseVisualStyleBackColor = true;
            this.btn_ajoutmatiere.Click += new System.EventHandler(this.btn_ajoutmatiere_Click);
            // 
            // btnsupp_matiere
            // 
            this.btnsupp_matiere.Location = new System.Drawing.Point(572, 332);
            this.btnsupp_matiere.Name = "btnsupp_matiere";
            this.btnsupp_matiere.Size = new System.Drawing.Size(134, 34);
            this.btnsupp_matiere.TabIndex = 6;
            this.btnsupp_matiere.Text = "supprimer";
            this.btnsupp_matiere.UseVisualStyleBackColor = true;
            // 
            // FormMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsupp_matiere);
            this.Controls.Add(this.btn_ajoutmatiere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbcours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnommatiere);
            this.Controls.Add(this.dataGridViewmatiere);
            this.Name = "FormMatiere";
            this.Text = "FormMatiere";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmatiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewmatiere;
        private System.Windows.Forms.TextBox txtnommatiere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ajoutmatiere;
        private System.Windows.Forms.Button btnsupp_matiere;
    }
}