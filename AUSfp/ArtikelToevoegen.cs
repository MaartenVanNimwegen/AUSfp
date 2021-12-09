using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AUSfp
{
    public partial class ArtikelToevoegen : Form
    {
        private string naam = "";
        private string beschrijving = "";
        private string categorie = "";

        public ArtikelToevoegen()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            naam = titleTextbox.Text;
            beschrijving = beschrijvingTextbox.Text;
            categorie = CategorieDropdown.Text;
            
            MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = testdatabase; User ID = root; Password = ");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `artikelen` (`naam`, `categorie`, `beschrijving`, `toevoeger`, `toegevoegdOp`) VALUES ( '"+ naam +"', '"+ categorie +"', '"+ beschrijving +"', '"+ Login.naam +"', now());", connection);
            cmd.ExecuteReader();
            MessageBox.Show("Artikel toegevoegd");
        }
    }
}
