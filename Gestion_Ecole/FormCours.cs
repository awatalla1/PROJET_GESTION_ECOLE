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
    public partial class FormCours : Form
    {
        string connectionString = null;
        SqlConnection cnx;
        public FormCours()
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
        private void btnajout_cours_Click(object sender, EventArgs e)
        {
            string nomCours = txtnomcours.Text.ToString();
            string description = txtdescription.Text.ToString();
            string query = "INSERT INTO Cours (NomCours, Description) VALUES (@NomCours, @Description)";

            using (SqlCommand cmd = new SqlCommand(query, cnx))
            {
                cmd.Parameters.AddWithValue("@NomCours", nomCours);
                cmd.Parameters.AddWithValue("@Description", description);

                try
                {
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cours ajouté avec succès !");
                    LoadCours();
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





        private void FormCours_Load(object sender, EventArgs e)
        {

        }

        private void btnsupp_cours_Click(object sender, EventArgs e)
        {
            int CoursId = (int)dataGridViewcours.SelectedRows[0].Cells["Id"].Value;
            string query = "DELETE FROM Cours WHERE Id = @Id";
            using (SqlCommand cmd = new SqlCommand(query, cnx))
            {
                cmd.Parameters.AddWithValue("@Id", CoursId);

                try
                {
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cours supprimé avec succès !");
                   
                    LoadCours(); // Recharger la liste des cours
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally {  
                    cnx.Close(); 
                }

            }

        }

        private void LoadCours()
        {
            string query = "SELECT * FROM Cours";
            using (SqlCommand cmd = new SqlCommand(query, cnx))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewcours.DataSource = dt;
            }
        }


    }
}

    


