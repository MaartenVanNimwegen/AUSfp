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
    public partial class ArtikelWijzigen : Form
    {
        private string naam = "";
        private string beschrijving = "";
        private string categorie = "";
        private static string id = "";

        public ArtikelWijzigen(string rowId)
        {
            InitializeComponent();
            id = rowId;


            MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = testdatabase; User ID = root; Password = ");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from artikelen where id = " + id, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                naam = (string)reader["naam"];
                categorie = (string)reader["categorie"];
                beschrijving = (string)reader["beschrijving"];
            }
            wijzigTitleTextbox.Text = naam;
            WijzigCategorieDropdown.Text = categorie;
            WijzigBeschrijvingTextbox.Text = beschrijving;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WijzigItemBtn_Click(object sender, EventArgs e)
        {
            naam = wijzigTitleTextbox.Text;
            beschrijving = WijzigBeschrijvingTextbox.Text;
            categorie = WijzigCategorieDropdown.Text;
            
            if (wijzigTitleTextbox.Text == "")
            {
                MessageBox.Show("Dit veld mag niet leeg zijn.");
            }
            else if (wijzigTitleTextbox.Text.Length > 100)
            {
                MessageBox.Show("De naam mag niet langer zijn dan 100 karakters.");
            }
            else
            {
                MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = testdatabase; User ID = root; Password = ");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE artikelen SET naam='" + naam + "', categorie='" + categorie + "', beschrijving='" + beschrijving + "' WHERE id='" + id + "'", connection);
                cmd.ExecuteReader();
                MessageBox.Show("Artikel gewijzigd");
                Close();
            }
        }
        /// <summary>
        /// leegt de titel box wanneer je erin springt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wijzigTitleTextbox_Enter_1(object sender, EventArgs e)
        {
            wijzigTitleTextbox.Text = "";
        }
        /// <summary>
        /// leegt de beschrijving box wanneer je erin springt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WijzigBeschrijvingTextbox_Enter_1(object sender, EventArgs e)
        {
            WijzigBeschrijvingTextbox.Text = "";
        }
    }
}
