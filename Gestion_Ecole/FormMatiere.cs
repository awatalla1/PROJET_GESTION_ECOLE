using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Ecole
{
    public partial class FormMatiere : Form
    {
        string connectionString = null;
        SqlConnection cnx;
        public FormMatiere()
        {
            InitializeComponent();
            connectionString = "Data Source=DESKTOP-EFGD3FL\\MSSQLSERVER01; Initial Catalog = gestion_ecole; Integrated Security = True; TrustServerCertificate=true";
            cnx = new SqlConnection(connectionString);
        }

        private void btn_ajoutmatiere_Click(object sender, EventArgs e)
        {
            
            string nomMatiere = txtnommatiere.Text.ToString();
            int coursId = (int)cmbcours.SelectedValue;

            if (string.IsNullOrEmpty(nomMatiere))
            {
                MessageBox.Show("Veuillez entrer un nom de matière.");
                return;
            }

            string query = "INSERT INTO Matieres (NomMatière, CoursId) VALUES (@NomMatière)";

            using (SqlCommand cmd = new SqlCommand(query, cnx))
            {
                cmd.Parameters.AddWithValue("@NomMatière", nomMatiere);
               // cmd.Parameters.AddWithValue("@CoursId", coursId);

                try
                {
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Matière ajoutée avec succès !");
                    LoadMatieres(); 
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

        private void LoadMatieres()
        {
            string query = "SELECT * FROM Matieres";
            using (SqlCommand cmd = new SqlCommand(query, cnx))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewmatiere.DataSource = dt;
            }
        }
    }
    }

