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
        private string HuidigeImg = "";
        /// <summary>
        /// deze functie bouwd het scherm en zet de huidige info in de velden.
        /// </summary>
        /// <param name="rowId"></param>
        public ArtikelWijzigen(string rowId)
        {
            InitializeComponent();
            id = rowId;


            MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = AUSfp; User ID = root; Password = ");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from artikelen where id = " + id, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                naam = (string)reader["naam"];
                categorie = (string)reader["categorie"];
                beschrijving = (string)reader["beschrijving"];
                HuidigeImg = (string)reader["img"];
            }
            wijzigTitleTextbox.Text = naam;
            categorieTextbox.Text = categorie;
            WijzigBeschrijvingTextbox.Text = beschrijving;
            imgUrl.Text = HuidigeImg;
        }
        /// <summary>
        /// sluit het scherm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// veranderd de info van het artikel naar wat is ingevuld
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WijzigItemBtn_Click(object sender, EventArgs e)
        {
            naam = wijzigTitleTextbox.Text;
            beschrijving = WijzigBeschrijvingTextbox.Text;
            categorie = categorieTextbox.Text;
            
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
                MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = AUSfp; User ID = root; Password = ");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE artikelen SET naam='" + naam + "', categorie='" + categorie + "', beschrijving='" + beschrijving + "', img='" + imgUrl.Text + "' WHERE id='" + id + "'", connection);
                cmd.ExecuteReader();
                MessageBox.Show("Artikel gewijzigd");
                Close();
            }
        }
    }
}
