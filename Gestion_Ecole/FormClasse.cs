using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionScolaire.Data;
using GestionScolaire.Models;

namespace Gestion_Ecole
{
    public partial class FormClasse : Form
    {
        public FormClasse()
        {
            InitializeComponent();
        }

        private void FormClasse_Load(object sender, EventArgs e)
        {

        }

        private void btnajoutclasse_Click(object sender, EventArgs e)
        {
            using (var db = new GestionScolaireContext())
            {
                Classe classe = new Classe();
                classe.NomClasse = txtnomclasse.Text;

                db.Classes.Add(classe);
                db.SaveChanges();
                refresh();

            }
        }

        public void refresh()
        {
            dataGridViewClasse.DataSource = null;
            using (var db = new GestionScolaireContext()) {
                dataGridViewClasse.DataSource = db.Classes.ToList();
             }
        }
    }
}
