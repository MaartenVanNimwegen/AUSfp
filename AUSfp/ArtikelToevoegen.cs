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
        private string img = "";

        public ArtikelToevoegen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// sluit het scherm wanneer er op de cancel knop word gedrukt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// voegt artikelen toe aan de database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            naam = titleTextbox.Text;
            beschrijving = beschrijvingTextbox.Text;
            categorie = CategorieTextbox.Text;
            img = ImgurlTextbox.Text;
            
            MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = AUSfp; User ID = root; Password = ");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `artikelen` (`naam`, `categorie`, `inleverdatum`, `beschrijving`, `toevoeger`, `toegevoegdOp`, `img`) VALUES ( '"+ naam +"', '"+ categorie +"', now(), '"+ beschrijving +"', '"+ Login.naam +"', now(),'" + img + "');", connection);
            cmd.ExecuteReader();
            MessageBox.Show("Artikel toegevoegd");
        }
        /// <summary>
        /// leegt de titel box wanneer je erin springt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titleTextbox_Enter(object sender, EventArgs e)
        {
            titleTextbox.Text = "";
        }
        /// <summary>
        /// leegt de beschrijving box wanneer je erin springt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beschrijvingTextbox_Enter(object sender, EventArgs e)
        {
            beschrijvingTextbox.Text = "";
        }
        /// <summary>
        /// leegt de categorie box wanneer je erin springt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategorieTextbox_Enter(object sender, EventArgs e)
        {
            CategorieTextbox.Text = "";
        }
        /// <summary>
        /// leegt de url box wanneer je erin springt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgurlTextbox_Enter(object sender, EventArgs e)
        {
            ImgurlTextbox.Text = "";
        }
    }
}
