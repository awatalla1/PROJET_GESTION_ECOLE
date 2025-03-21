namespace Gestion_Ecole
{
    partial class FormClasse
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
            this.btnajoutclasse = new System.Windows.Forms.Button();
            this.btnsuppclasse = new System.Windows.Forms.Button();
            this.btnmodifclasse = new System.Windows.Forms.Button();
            this.dataGridViewClasse = new System.Windows.Forms.DataGridView();
            this.txtnomclasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnajoutclasse
            // 
            this.btnajoutclasse.Location = new System.Drawing.Point(375, 321);
            this.btnajoutclasse.Name = "btnajoutclasse";
            this.btnajoutclasse.Size = new System.Drawing.Size(108, 42);
            this.btnajoutclasse.TabIndex = 0;
            this.btnajoutclasse.Text = "Ajouter";
            this.btnajoutclasse.UseVisualStyleBackColor = true;
            this.btnajoutclasse.Click += new System.EventHandler(this.btnajoutclasse_Click);
            // 
            // btnsuppclasse
            // 
            this.btnsuppclasse.Location = new System.Drawing.Point(489, 321);
            this.btnsuppclasse.Name = "btnsuppclasse";
            this.btnsuppclasse.Size = new System.Drawing.Size(129, 45);
            this.btnsuppclasse.TabIndex = 1;
            this.btnsuppclasse.Text = "Supprimer";
            this.btnsuppclasse.UseVisualStyleBackColor = true;
            // 
            // btnmodifclasse
            // 
            this.btnmodifclasse.Location = new System.Drawing.Point(641, 324);
            this.btnmodifclasse.Name = "btnmodifclasse";
            this.btnmodifclasse.Size = new System.Drawing.Size(118, 39);
            this.btnmodifclasse.TabIndex = 2;
            this.btnmodifclasse.Text = "Modifier";
            this.btnmodifclasse.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClasse
            // 
            this.dataGridViewClasse.AllowUserToAddRows = false;
            this.dataGridViewClasse.AllowUserToDeleteRows = false;
            this.dataGridViewClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClasse.Location = new System.Drawing.Point(2, 12);
            this.dataGridViewClasse.Name = "dataGridViewClasse";
            this.dataGridViewClasse.ReadOnly = true;
            this.dataGridViewClasse.RowHeadersWidth = 62;
            this.dataGridViewClasse.RowTemplate.Height = 28;
            this.dataGridViewClasse.Size = new System.Drawing.Size(482, 228);
            this.dataGridViewClasse.TabIndex = 3;
            // 
            // txtnomclasse
            // 
            this.txtnomclasse.Location = new System.Drawing.Point(111, 285);
            this.txtnomclasse.Multiline = true;
            this.txtnomclasse.Name = "txtnomclasse";
            this.txtnomclasse.Size = new System.Drawing.Size(168, 39);
            this.txtnomclasse.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nomclasse";
            // 
            // FormClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnomclasse);
            this.Controls.Add(this.dataGridViewClasse);
            this.Controls.Add(this.btnmodifclasse);
            this.Controls.Add(this.btnsuppclasse);
            this.Controls.Add(this.btnajoutclasse);
            this.Name = "FormClasse";
            this.Text = "FormClasse";
            this.Load += new System.EventHandler(this.FormClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnajoutclasse;
        private System.Windows.Forms.Button btnsuppclasse;
        private System.Windows.Forms.Button btnmodifclasse;
        private System.Windows.Forms.DataGridView dataGridViewClasse;
        private System.Windows.Forms.TextBox txtnomclasse;
        private System.Windows.Forms.Label label1;
    }
}