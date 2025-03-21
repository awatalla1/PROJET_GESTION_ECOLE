using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Ecole
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            customizeDesign();
            // Changer le parent de panel_etudiant pour qu'il soit un enfant direct du formulaire principal
           // panel_etudiant.Parent = this; // "this" représente le formulaire principal
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            

        }

        private void customizeDesign()
        {
            panel_etudiant.Visible = false;
            panel_cours.Visible = false;
            panel_note.Visible = false;
            panel_prof.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_etudiant.Visible == true)
                panel_etudiant.Visible = false;

            if (panel_cours.Visible == true)
                panel_cours.Visible = false;

            if (panel_note.Visible == true)
                panel_note.Visible = false;

            if (panel_prof.Visible == true)
                panel_prof.Visible = false;

        }

        private void showSubmenu( Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btn_menuEtudiant_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_etudiant);
        }

        private void btn_regis_Click(object sender, EventArgs e)
        {
            using (Registration res = new Registration ()) {
                res.ShowDialog ();

            }

            

            //Registration registerForm = new Registration();
            //openChildForm(registerForm);
            //hideSubmenu();
        }
       
        

        private void btn_menuCours_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_cours);
        }

        private void btn_menuNote_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_note);
        }

        private void btn_menuProf_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_prof);
        }

        //to show register form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            // Fermer le formulaire actif s'il existe
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Définir le formulaire enfant
            activeForm = childForm;

            // Configurer le formulaire enfant
            childForm.TopLevel = false; // Indique que ce n'est pas une fenêtre de niveau supérieur
            childForm.FormBorderStyle = FormBorderStyle.None; // Supprime la bordure
            childForm.Dock = DockStyle.Fill; // Remplit tout l'espace disponible

            // Ajouter le formulaire enfant à panel_etudiant
            panel_etudiant.Controls.Add(childForm);
            panel_etudiant.Tag = childForm;

            // Mettre le formulaire enfant au premier plan et l'afficher
            childForm.BringToFront();
            childForm.Show();
        }
    }

    }

        

    
        

    




