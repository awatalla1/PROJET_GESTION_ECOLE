namespace Gestion_Ecole
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_etudiant = new System.Windows.Forms.Panel();
            this.btn_regis = new System.Windows.Forms.Button();
            this.btn_Metudiant = new System.Windows.Forms.Button();
            this.btn_menuEtudiant = new System.Windows.Forms.Button();
            this.btn_menuCours = new System.Windows.Forms.Button();
            this.panel_cours = new System.Windows.Forms.Panel();
            this.btn_Mcours = new System.Windows.Forms.Button();
            this.btn_noscours = new System.Windows.Forms.Button();
            this.btn_menuNote = new System.Windows.Forms.Button();
            this.panel_note = new System.Windows.Forms.Panel();
            this.btn_Mnote = new System.Windows.Forms.Button();
            this.btn_noteetudiant = new System.Windows.Forms.Button();
            this.btn_menuProf = new System.Windows.Forms.Button();
            this.panel_prof = new System.Windows.Forms.Panel();
            this.btn_Mprof = new System.Windows.Forms.Button();
            this.btn_profs = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_etudiant.SuspendLayout();
            this.panel_cours.SuspendLayout();
            this.panel_note.SuspendLayout();
            this.panel_prof.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel_prof);
            this.panel1.Controls.Add(this.btn_menuProf);
            this.panel1.Controls.Add(this.panel_note);
            this.panel1.Controls.Add(this.btn_menuNote);
            this.panel1.Controls.Add(this.panel_cours);
            this.panel1.Controls.Add(this.btn_menuCours);
            this.panel1.Controls.Add(this.panel_etudiant);
            this.panel1.Controls.Add(this.btn_menuEtudiant);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 663);
            this.panel1.TabIndex = 0;
            // 
            // panel_etudiant
            // 
            this.panel_etudiant.Controls.Add(this.btn_Metudiant);
            this.panel_etudiant.Location = new System.Drawing.Point(0, 162);
            this.panel_etudiant.Name = "panel_etudiant";
            this.panel_etudiant.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_etudiant.Size = new System.Drawing.Size(230, 84);
            this.panel_etudiant.TabIndex = 1;
            // 
            // btn_regis
            // 
            this.btn_regis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_regis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_regis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regis.ForeColor = System.Drawing.Color.White;
            this.btn_regis.Location = new System.Drawing.Point(134, 54);
            this.btn_regis.Name = "btn_regis";
            this.btn_regis.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_regis.Size = new System.Drawing.Size(188, 156);
            this.btn_regis.TabIndex = 1;
            this.btn_regis.Text = "Registration";
            this.btn_regis.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_regis.UseVisualStyleBackColor = false;
            this.btn_regis.Click += new System.EventHandler(this.btn_regis_Click);
            // 
            // btn_Metudiant
            // 
            this.btn_Metudiant.FlatAppearance.BorderSize = 0;
            this.btn_Metudiant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Metudiant.ForeColor = System.Drawing.Color.White;
            this.btn_Metudiant.Location = new System.Drawing.Point(0, 38);
            this.btn_Metudiant.Name = "btn_Metudiant";
            this.btn_Metudiant.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Metudiant.Size = new System.Drawing.Size(227, 37);
            this.btn_Metudiant.TabIndex = 2;
            this.btn_Metudiant.Text = "Manage etudiant";
            this.btn_Metudiant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Metudiant.UseVisualStyleBackColor = true;
            this.btn_Metudiant.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_menuEtudiant
            // 
            this.btn_menuEtudiant.FlatAppearance.BorderSize = 0;
            this.btn_menuEtudiant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuEtudiant.ForeColor = System.Drawing.Color.White;
            this.btn_menuEtudiant.Location = new System.Drawing.Point(0, 112);
            this.btn_menuEtudiant.Name = "btn_menuEtudiant";
            this.btn_menuEtudiant.Size = new System.Drawing.Size(230, 44);
            this.btn_menuEtudiant.TabIndex = 2;
            this.btn_menuEtudiant.Text = "ETUDIANTS";
            this.btn_menuEtudiant.UseVisualStyleBackColor = true;
            this.btn_menuEtudiant.Click += new System.EventHandler(this.btn_menuEtudiant_Click);
            // 
            // btn_menuCours
            // 
            this.btn_menuCours.FlatAppearance.BorderSize = 0;
            this.btn_menuCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuCours.ForeColor = System.Drawing.Color.White;
            this.btn_menuCours.Location = new System.Drawing.Point(3, 252);
            this.btn_menuCours.Name = "btn_menuCours";
            this.btn_menuCours.Size = new System.Drawing.Size(230, 44);
            this.btn_menuCours.TabIndex = 3;
            this.btn_menuCours.Text = "COURS";
            this.btn_menuCours.UseVisualStyleBackColor = true;
            this.btn_menuCours.Click += new System.EventHandler(this.btn_menuCours_Click);
            // 
            // panel_cours
            // 
            this.panel_cours.Controls.Add(this.btn_Mcours);
            this.panel_cours.Controls.Add(this.btn_noscours);
            this.panel_cours.Location = new System.Drawing.Point(3, 302);
            this.panel_cours.Name = "panel_cours";
            this.panel_cours.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_cours.Size = new System.Drawing.Size(230, 84);
            this.panel_cours.TabIndex = 4;
            // 
            // btn_Mcours
            // 
            this.btn_Mcours.FlatAppearance.BorderSize = 0;
            this.btn_Mcours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mcours.ForeColor = System.Drawing.Color.White;
            this.btn_Mcours.Location = new System.Drawing.Point(0, 38);
            this.btn_Mcours.Name = "btn_Mcours";
            this.btn_Mcours.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Mcours.Size = new System.Drawing.Size(227, 37);
            this.btn_Mcours.TabIndex = 2;
            this.btn_Mcours.Text = "Manage cours";
            this.btn_Mcours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Mcours.UseVisualStyleBackColor = true;
            // 
            // btn_noscours
            // 
            this.btn_noscours.FlatAppearance.BorderSize = 0;
            this.btn_noscours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noscours.ForeColor = System.Drawing.Color.White;
            this.btn_noscours.Location = new System.Drawing.Point(0, 0);
            this.btn_noscours.Name = "btn_noscours";
            this.btn_noscours.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_noscours.Size = new System.Drawing.Size(227, 32);
            this.btn_noscours.TabIndex = 1;
            this.btn_noscours.Text = "Nos cours";
            this.btn_noscours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_noscours.UseVisualStyleBackColor = true;
            // 
            // btn_menuNote
            // 
            this.btn_menuNote.FlatAppearance.BorderSize = 0;
            this.btn_menuNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuNote.ForeColor = System.Drawing.Color.White;
            this.btn_menuNote.Location = new System.Drawing.Point(-3, 392);
            this.btn_menuNote.Name = "btn_menuNote";
            this.btn_menuNote.Size = new System.Drawing.Size(230, 44);
            this.btn_menuNote.TabIndex = 5;
            this.btn_menuNote.Text = "NOTES";
            this.btn_menuNote.UseVisualStyleBackColor = true;
            this.btn_menuNote.Click += new System.EventHandler(this.btn_menuNote_Click);
            // 
            // panel_note
            // 
            this.panel_note.Controls.Add(this.btn_Mnote);
            this.panel_note.Controls.Add(this.btn_noteetudiant);
            this.panel_note.Location = new System.Drawing.Point(3, 442);
            this.panel_note.Name = "panel_note";
            this.panel_note.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_note.Size = new System.Drawing.Size(230, 84);
            this.panel_note.TabIndex = 6;
            // 
            // btn_Mnote
            // 
            this.btn_Mnote.FlatAppearance.BorderSize = 0;
            this.btn_Mnote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mnote.ForeColor = System.Drawing.Color.White;
            this.btn_Mnote.Location = new System.Drawing.Point(0, 38);
            this.btn_Mnote.Name = "btn_Mnote";
            this.btn_Mnote.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Mnote.Size = new System.Drawing.Size(227, 37);
            this.btn_Mnote.TabIndex = 2;
            this.btn_Mnote.Text = "Manage notes";
            this.btn_Mnote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Mnote.UseVisualStyleBackColor = true;
            // 
            // btn_noteetudiant
            // 
            this.btn_noteetudiant.FlatAppearance.BorderSize = 0;
            this.btn_noteetudiant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noteetudiant.ForeColor = System.Drawing.Color.White;
            this.btn_noteetudiant.Location = new System.Drawing.Point(0, 0);
            this.btn_noteetudiant.Name = "btn_noteetudiant";
            this.btn_noteetudiant.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_noteetudiant.Size = new System.Drawing.Size(227, 32);
            this.btn_noteetudiant.TabIndex = 1;
            this.btn_noteetudiant.Text = "Note etudiants";
            this.btn_noteetudiant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_noteetudiant.UseVisualStyleBackColor = true;
            // 
            // btn_menuProf
            // 
            this.btn_menuProf.FlatAppearance.BorderSize = 0;
            this.btn_menuProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuProf.ForeColor = System.Drawing.Color.White;
            this.btn_menuProf.Location = new System.Drawing.Point(-3, 532);
            this.btn_menuProf.Name = "btn_menuProf";
            this.btn_menuProf.Size = new System.Drawing.Size(230, 44);
            this.btn_menuProf.TabIndex = 7;
            this.btn_menuProf.Text = "PROFS";
            this.btn_menuProf.UseVisualStyleBackColor = true;
            this.btn_menuProf.Click += new System.EventHandler(this.btn_menuProf_Click);
            // 
            // panel_prof
            // 
            this.panel_prof.Controls.Add(this.btn_Mprof);
            this.panel_prof.Controls.Add(this.btn_profs);
            this.panel_prof.Location = new System.Drawing.Point(3, 582);
            this.panel_prof.Name = "panel_prof";
            this.panel_prof.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_prof.Size = new System.Drawing.Size(230, 84);
            this.panel_prof.TabIndex = 8;
            // 
            // btn_Mprof
            // 
            this.btn_Mprof.FlatAppearance.BorderSize = 0;
            this.btn_Mprof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mprof.ForeColor = System.Drawing.Color.White;
            this.btn_Mprof.Location = new System.Drawing.Point(0, 38);
            this.btn_Mprof.Name = "btn_Mprof";
            this.btn_Mprof.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Mprof.Size = new System.Drawing.Size(227, 37);
            this.btn_Mprof.TabIndex = 2;
            this.btn_Mprof.Text = "Manage prof";
            this.btn_Mprof.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Mprof.UseVisualStyleBackColor = true;
            // 
            // btn_profs
            // 
            this.btn_profs.FlatAppearance.BorderSize = 0;
            this.btn_profs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profs.ForeColor = System.Drawing.Color.White;
            this.btn_profs.Location = new System.Drawing.Point(0, 0);
            this.btn_profs.Name = "btn_profs";
            this.btn_profs.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_profs.Size = new System.Drawing.Size(227, 32);
            this.btn_profs.TabIndex = 1;
            this.btn_profs.Text = "Professeurs";
            this.btn_profs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profs.UseVisualStyleBackColor = true;
            this.btn_profs.Click += new System.EventHandler(this.button12_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(230, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 91);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(656, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "ISI GROUP";
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btn_regis);
            this.panel3.Location = new System.Drawing.Point(230, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 500);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(153, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 663);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_etudiant.ResumeLayout(false);
            this.panel_cours.ResumeLayout(false);
            this.panel_note.ResumeLayout(false);
            this.panel_prof.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_etudiant;
        private System.Windows.Forms.Button btn_regis;
        private System.Windows.Forms.Button btn_Metudiant;
        private System.Windows.Forms.Button btn_menuEtudiant;
        private System.Windows.Forms.Panel panel_note;
        private System.Windows.Forms.Button btn_Mnote;
        private System.Windows.Forms.Button btn_noteetudiant;
        private System.Windows.Forms.Button btn_menuNote;
        private System.Windows.Forms.Panel panel_cours;
        private System.Windows.Forms.Button btn_Mcours;
        private System.Windows.Forms.Button btn_noscours;
        private System.Windows.Forms.Button btn_menuCours;
        private System.Windows.Forms.Panel panel_prof;
        private System.Windows.Forms.Button btn_Mprof;
        private System.Windows.Forms.Button btn_profs;
        private System.Windows.Forms.Button btn_menuProf;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}