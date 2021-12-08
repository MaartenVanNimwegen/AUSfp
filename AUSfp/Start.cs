using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUSfp
{
    public partial class Start : Form
    {
        bool userIsLoggedIn = false;
        public string rowIndex = "";
        List<Artikel> Items = new List<Artikel>();

        public Start()
        {
            InitializeComponent();

            showHeaderItems(false);

            RefreshDataGrid();
        }
        /// <summary>
        /// bij klik van de login knop word gekeken of de gebruiker correct is ingelogd. Als er goed is ingelogd is DialogResult OK en anders niet. Als deze OK is word UserIsLoggedIn true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login myForm = new Login();
            DialogResult dialogResult = myForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                userIsLoggedIn = true;
                showHeaderItems(userIsLoggedIn);
            }
        }
        /// <summary>
        /// Wanneer bool showHeaderItems true is geeft het de dingen weer die je moet zien wanneer je bent ingelogd en wanneer je niet bent ingelogd laat hij de andere dingen zien.
        /// </summary>
        /// <param name="weergeven"></param>
        public void showHeaderItems(bool weergeven)
        {
            LoginBtn.Visible = !weergeven;
            LogoutBtn.Visible = weergeven;
            LogoutBtn.Visible = weergeven;
            ManageItemsBtn.Visible = weergeven;            
            inleverUitleenIcon.Visible = weergeven;
            wijzigIcon.Visible = weergeven;
            DeleteBtn.Visible = weergeven;
            lenerLable.Visible = weergeven;
            leerlingnummerLable.Visible = weergeven;
            toegevoegddoorLable.Visible = weergeven;
            toegevoegdopLable.Visible = weergeven;
        }
        /// <summary>
        /// logt persoon uit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            userIsLoggedIn = false;
            showHeaderItems(userIsLoggedIn);
        }
        /// <summary>
        /// update naam wanneer label weergave word geupdate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameLabel_VisibleChanged(object sender, EventArgs e)
        {
            NameLabel.Text = Login.welkomNaam;
        }
        /// <summary>
        /// Deze functie converteerd alle artikelen van de database naar een list
        /// </summary>
        /// <param name="sqllist"></param>
        private void ArtikelenList()
        {
            Items = new List<Artikel>();

            string query = "SELECT * FROM artikelen";

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = "Data Source = localhost; convert zero datetime=True; Initial Catalog = testdatabase; User ID = root; Password = ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Artikel myArtikel = new Artikel();
                            myArtikel.Id = reader.GetInt32(0);
                            myArtikel.Naam = reader.GetString(1);
                            myArtikel.Categorie = reader.GetString(2);
                            myArtikel.Lener = reader.GetString(3);
                            myArtikel.Inleverdatum = reader.GetDateTime(4);
                            myArtikel.Status = reader.GetInt32(5);
                            myArtikel.Leerlingnummer = reader.GetInt32(6);
                            myArtikel.Beschrijving = reader.GetString(7);
                            myArtikel.Toevoeger= reader.GetString(8);
                            myArtikel.ToegevoegdOp = reader.GetDateTime(9);

                            Items.Add(myArtikel);
                        }
                    }
                    reader.Close();
                }
            }
        }
        /// <summary>
        /// voegd data toe aan tabel voor elke rij uit database
        /// </summary>
        private void RefreshDataGrid()
        {
            ArtikelenList();

            for (int i = 1; i <= Items.Count; i++)
            {
                var Item = Items[i - 1];

                if (Item != null)
                {
                    DataGrid.Rows.Add(i.ToString(), Item.Naam, Item.Categorie, Item.Status, Item.Inleverdatum);
                }
            }
        }
        /// <summary>
        /// Opent login scherm en kijkt naar of er is ingelogd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ArtikelToevoegen myForm = new ArtikelToevoegen();
            DialogResult dialogResult = myForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                userIsLoggedIn = true;
                showHeaderItems(userIsLoggedIn);
            }
        }
        /// <summary>
        /// geeft rowIndex de waarde van de geselcteerde row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.CurrentCell != null)
            {
                string rowIndex = DataGrid.SelectedCells[0].Value.ToString();

                Artikel artikel = GetArtikel(int.Parse(rowIndex));
                
                ShowDetails(artikel);
                
                
            }
        }

        /// <summary>
        /// deze functie kijkt naar welke rij is geselecteerd en geeft dan de info van de geselecteerde rij aan een artikelen lijst
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Artikel GetArtikel(int id)
        {

            Artikel artikel = new Artikel();

            MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = testdatabase; User ID = root; Password = ");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from artikelen where id = " + id, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                artikel.Id = (int)reader["id"];
                artikel.Naam = (string)reader["naam"];
                artikel.Categorie = (string)reader["categorie"];
                artikel.Lener = (string)reader["lener"];
                artikel.Inleverdatum = (DateTime)reader["inleverdatum"];
                artikel.Status = (int)reader["status"];
                artikel.Leerlingnummer = (int)reader["leerlingnummer"];
                artikel.Beschrijving = (string)reader["beschrijving"];
                artikel.Toevoeger = (string)reader["toevoeger"];
                artikel.ToegevoegdOp = (DateTime)reader["toegevoegdOp"];


            }

            return artikel;

        }
        /// <summary>
        /// Deze functie geeft de juiste informatie vanuit de functie hierboven op het scherm weer
        /// </summary>
        /// <param name="artikel"></param>
        private void ShowDetails(Artikel artikel)
        {
            if (artikel.Status == 0)
            {
                statusLable.Text = "Beschikbaarheid: Beschikbaar";
            }
            else if (artikel.Status == 1)
            {
                statusLable.Text = "Beschikbaarheid: Onbeschikbaar";
            }
            naamLable.Text = artikel.Naam.ToString();
            beschrijvingLable.Text = artikel.Beschrijving.ToString();
            artikelnrLable.Text = "Artikelnummer: " + artikel.Id.ToString();
            categorieLable.Text = "Categorie: " + artikel.Categorie.ToString();

            inleverdatumLable.Text = "Inleverdatum: " + artikel.Inleverdatum.ToString();
            lenerLable.Text = "Uitgeleend aan: " + artikel.Lener.ToString();
            leerlingnummerLable.Text = "Leerlingnummer: " + artikel.Leerlingnummer.ToString();
            toegevoegddoorLable.Text = "Toegevoegd door: " + artikel.Toevoeger.ToString();
            toegevoegdopLable.Text = "Toegevoegd op: " + artikel.ToegevoegdOp.ToString();
        }
    }
}
