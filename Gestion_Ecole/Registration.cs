using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Scolaire.Models;
using GestionScolaire.Data;
using GestionScolaire.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gestion_Ecole
{
    public partial class Registration : Form
    {
        List<Etudiant> etudiants = new List<Etudiant>();
        string connectionString = null;
        SqlConnection cnx;
        // server=localhost; database=gestion_ecole;uid=root ;pwd=\"\";"
        public Registration()
        {
            InitializeComponent();

            connectionString = "Data Source=DESKTOP-EFGD3FL\\MSSQLSERVER01; Initial Catalog = gestion_ecole; Integrated Security = True; TrustServerCertificate=true";
            cnx = new SqlConnection(connectionString);
            try
            {
                cnx.Open();
                MessageBox.Show("vous etes connecte");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection" + ex.Message);
            }

        }
        int selectedid = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int studentId = (int)dataGridViewetudiant.SelectedRows[0].Cells["Id"].Value;

            // Créer un nouvel étudiant avec les données modifiées
            Etudiant etudiant = new Etudiant
            {
                Matricule = txtmat.Text,
                Nom = txtnom.Text,
                Prénom = txtprenom.Text,
                DateNaissance = dateN.Value,
                Sexe = cmbsexe.Text,
                Adresse = txtadresse.Text,
                Telephone = txttelephone.Text,
                Email = txtemail.Text,
                ClasseId = (int)cmbClasse.SelectedValue
            };

            // Mettre à jour l'étudiant dans la base de données
            string query = "UPDATE Etudiants SET Matricule = @Matricule, Nom = @Nom, Prénom = @Prénom, DateNaissance = @DateNaissance, " +
                           "Sexe = @Sexe, Adresse = @Adresse, Telephone = @Telephone, Email = @Email, ClasseId = @ClasseId WHERE Id = @Id";

            using (SqlCommand cmd = new SqlCommand(query, cnx))
            {
                cmd.Parameters.AddWithValue("@Id", studentId);
                cmd.Parameters.AddWithValue("@Matricule", etudiant.Matricule);
                cmd.Parameters.AddWithValue("@Nom", etudiant.Nom);
                cmd.Parameters.AddWithValue("@Prénom", etudiant.Prénom);
                cmd.Parameters.AddWithValue("@DateNaissance", etudiant.DateNaissance);
                cmd.Parameters.AddWithValue("@Sexe", etudiant.Sexe);
                cmd.Parameters.AddWithValue("@Adresse", etudiant.Adresse);
                cmd.Parameters.AddWithValue("@Telephone", etudiant.Telephone);
                cmd.Parameters.AddWithValue("@Email", etudiant.Email);
                cmd.Parameters.AddWithValue("@ClasseId", etudiant.ClasseId);

                try
                {
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("etudiant modifié avec succès !");
                    LoadStudents(); // Recharger les étudiants après la modification
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erreur : " + ex.Message);
                }
                finally
                {
                    cnx.Close();
                }
            }
        }

    

        

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmat.Text) || string.IsNullOrEmpty(txtnom.Text) || string.IsNullOrEmpty(txtprenom.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }

            // Vérifier l'âge de l'étudiant
            int age = DateTime.Now.Year - dateN.Value.Year;
            if (age < 10 || age > 100)
            {
                MessageBox.Show("L'âge de l'étudiant doit être compris entre 10 et 100 ans.");
                return;
            }


            Etudiant etudiant = new Etudiant {
                Matricule = txtmat.Text,
                Nom = txtnom.Text,
                Prénom = txtprenom.Text,
                DateNaissance = dateN.Value,
                Sexe = cmbsexe.Text,
                Adresse = txtadresse.Text,
                Telephone = txttelephone.Text,
                Email = txtemail.Text,
                ClasseId = (int)cmbClasse.SelectedValue
                // etudiant.Classe = (Classe)cmbClasse.SelectedItem;

            };
               


            string query = "INSERT INTO Etudiants (Matricule, Nom, Prénom, DateNaissance, Sexe, Adresse, Telephone, Email, ClasseId) " +
                          "VALUES (@Matricule, @Nom, @Prénom, @DateNaissance, @Sexe, @Adresse, @Telephone, @Email, @ClasseId)";
            using (SqlCommand cmd = new SqlCommand(query, cnx))
            {
                cmd.Parameters.AddWithValue("@Matricule", etudiant.Matricule);
                cmd.Parameters.AddWithValue("@Nom", etudiant.Nom);
                cmd.Parameters.AddWithValue("@Prénom", etudiant.Prénom);
                cmd.Parameters.AddWithValue("@DateNaissance", etudiant.DateNaissance);
                cmd.Parameters.AddWithValue("@Sexe", etudiant.Sexe);
                cmd.Parameters.AddWithValue("@Adresse", etudiant.Adresse);
                cmd.Parameters.AddWithValue("@Telephone", etudiant.Telephone);
                cmd.Parameters.AddWithValue("@Email", etudiant.Email);
                cmd.Parameters.AddWithValue("@ClasseId", etudiant.ClasseId);

                try
                {
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    LoadStudents();

                    MessageBox.Show(" data Sucessfully inserted , lastInsertedId ID" );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message);
                }
                finally { 
                    cnx.Close();
                }
            }
           
                
            }

        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            

            using (var db = new GestionScolaireContext())
            {
                cmbClasse.DataSource = db.Classes.ToList();
                cmbClasse.DisplayMember = "NomClasse";
                cmbClasse.ValueMember = "Id";
            }

        }

        private void LoadStudents()
        {
            string query = "SELECT * FROM Etudiants";
            using (SqlCommand cmd = new SqlCommand(query, cnx))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Lier le DataTable au DataGridView
                dataGridViewetudiant.DataSource = dt;
            }
        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            int studentId = (int)dataGridViewetudiant.SelectedRows[0].Cells["Id"].Value;
            string query = "DELETE FROM Etudiants WHERE Id = @Id";

            using (SqlCommand cmd = new SqlCommand(query, cnx))
            {
                cmd.Parameters.AddWithValue("@Id", studentId);

                try
                {
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Étudiant supprimé avec succès !");
                    LoadStudents(); // Recharger les étudiants après la suppression
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    cnx.Close();
                }
            }
          }
        }
}
