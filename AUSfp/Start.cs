using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AUSfp
{
    public partial class Start : Form
    {
        bool userIsLoggedIn = false;
        public string rowIndex = "";
        List<Artikel> Items = new List<Artikel>();
        string UserEmail = "";

        

        public Start()
        {
            InitializeComponent();

            showHeaderItems(false);
            teamsLogo.Visible = false;
            ContactLable.Visible = false;

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

                inleverdatumLable.Visible = false;
                lenerLable.Visible = false;
                leerlingnummerLable.Visible = false;
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
            artikelToevoegen.Visible = weergeven;
            inleverUitleenIcon.Visible = weergeven;
            wijzigIcon.Visible = weergeven;
            DeleteBtn.Visible = weergeven;
            lenerLable.Visible = weergeven;
            leerlingnummerLable.Visible = weergeven;
            toegevoegddoorLable.Visible = weergeven;
            toegevoegdopLable.Visible = weergeven;
            uitleenInleverLable.Visible = weergeven;
            WijzigLable.Visible = weergeven;
            VerwijderLable.Visible = weergeven;

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
            string query = "";
            string valueToSearch = "";
            valueToSearch = SearchBar.Text;
            /// Search engine
            if (SearchBar.Text.Length > 0)
            {
                query = "SELECT * FROM artikelen WHERE CONCAT (id, naam, categorie, inleverdatum, leerlingnummer, lener) LIKE '%" + valueToSearch + "%'";
            }
            else if (SearchBar.Text.Length == 0)
            {
                query = "SELECT * FROM artikelen";
            }
            Items = new List<Artikel>();


            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = "Data Source = localhost; convert zero datetime=True; Initial Catalog = AUSfp; User ID = root; Password = ";
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
                            myArtikel.Artikelnummer = reader.GetString(1);
                            myArtikel.Naam = reader.GetString(2);
                            myArtikel.Categorie = reader.GetString(3);
                            myArtikel.Lener = reader.GetString(4);
                            myArtikel.Inleverdatum = reader.GetDateTime(5);
                            myArtikel.Leerlingnummer = reader.GetInt32(7);
                            myArtikel.Beschrijving = reader.GetString(8);
                            myArtikel.Toevoeger = reader.GetString(9);
                            myArtikel.ToegevoegdOp = reader.GetDateTime(10);

                            if (reader.GetInt32(6) == 0)
                            {
                                myArtikel.StatusString = "Beschikbaar";
                            }
                            else if (reader.GetInt32(6) == 1)
                            {
                                myArtikel.StatusString = "Uitgeleend";
                            }

                            Items.Add(myArtikel);
                        }
                    }
                    reader.Close();
                }
            }
        }
        /// <summary>
        /// wanneer zoek knop gedrukt wordt functie uitgevoerd.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchIcon_Click_1(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
        /// <summary>
        /// voegd data toe aan tabel voor elke rij uit database
        /// </summary>
        private void RefreshDataGrid()
        {
            DataGrid.Rows.Clear();

            ArtikelenList();

            for (int i = 1; i <= Items.Count; i++)
            {
                var Item = Items[i - 1];

                if (Item != null)
                {
                    DataGrid.Rows.Add(Item.Id, Item.Artikelnummer, Item.Naam, Item.Categorie, Item.StatusString, Item.Inleverdatum);
                }
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
                rowIndex = DataGrid.SelectedCells[0].Value.ToString();

                Artikel artikel = GetArtikel(int.Parse(rowIndex));

                ShowDetails(artikel);
            }
        }

        /// <summary>
        /// deze functie kijkt naar welke rij is geselecteerd en geeft dan de info van de geselecteerde rij aan een artikelen lijst
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Artikel GetArtikel(int id)
        {

            Artikel artikel = new Artikel();

            MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = AUSfp; User ID = root; Password = ");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from artikelen where id = " + id, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                artikel.Id = (int)reader["id"];
                artikel.Artikelnummer = (string)reader["Artikelnummer"];
                artikel.Naam = (string)reader["naam"];
                artikel.Categorie = (string)reader["categorie"];
                artikel.Lener = (string)reader["lener"];
                artikel.Inleverdatum = (DateTime)reader["inleverdatum"];
                artikel.Status = (int)reader["status"];
                artikel.Leerlingnummer = (int)reader["leerlingnummer"];
                artikel.Beschrijving = (string)reader["beschrijving"];
                artikel.Toevoeger = (string)reader["toevoeger"];
                artikel.ToegevoegdOp = (DateTime)reader["toegevoegdOp"];
                artikel.img = (string)reader["img"];
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
                uitleenInleverLable.Text = "Uitlenen";
                if (userIsLoggedIn == true)
                {
                    VerwijderLable.Visible = true;
                    DeleteBtn.Visible = true;
                    lenerLable.Visible = false;
                    leerlingnummerLable.Visible = false;
                    inleverdatumLable.Visible = false;
                }
            }
            else if (artikel.Status == 1)
            {

                if (userIsLoggedIn == true)
                {
                    lenerLable.Visible = true;
                    lenerLable.Text = "Uitgeleend aan: " + artikel.Lener.ToString();

                    leerlingnummerLable.Visible = true;
                    leerlingnummerLable.Text = "Leerlingnummer: " + artikel.Leerlingnummer.ToString();

                    inleverdatumLable.Visible = true;
                    inleverdatumLable.Text = "Inleverdatum: " + artikel.Inleverdatum.ToString();

                }
                else if (userIsLoggedIn == false)
                {
                    lenerLable.Visible = false;
                    leerlingnummerLable.Visible = false;
                    inleverdatumLable.Visible = false;
                }
                statusLable.Text = "Beschikbaarheid: Uitgeleend";
                uitleenInleverLable.Text = "Inleveren";
                DeleteBtn.Visible = false;
                VerwijderLable.Visible = false;
            }

            naamLable.Text = artikel.Naam;
            beschrijvingLable.Text = artikel.Beschrijving;
            ArtikelnummerLable.Text = "Artikelnummer: " + artikel.Artikelnummer;
            categorieLable.Text = "Categorie: " + artikel.Categorie;
            toegevoegddoorLable.Text = "Toegevoegd door: " + artikel.Toevoeger;
            toegevoegdopLable.Text = "Toegevoegd op: " + artikel.ToegevoegdOp.ToString();

            if (artikel.Leerlingnummer.ToString() == "0")
            {
                teamsLogo.Visible = false;
                ContactLable.Visible = false;
            }
            else if (artikel.Leerlingnummer.ToString() != "0" && userIsLoggedIn == true)
            {
                teamsLogo.Visible = true;
                ContactLable.Visible = true;
                UserEmail = artikel.Leerlingnummer.ToString() + "@edu.rocfriesepoort.nl";
            }

            ItemImgPictureBox.ImageLocation = artikel.img;


        }
        /// <summary>
        /// opent het scherm waarin artikelen kunnen worden toegevoegd en refreshed de datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void artikelToevoegen_Click(object sender, EventArgs e)
        {
            ArtikelToevoegen myForm = new ArtikelToevoegen();
            myForm.ShowDialog();

            RefreshDataGrid();
        }
        /// <summary>
        /// opent het scherm waarin artikelen kunnen worden gewijzigd en refreshed de datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wijzigIcon_Click(object sender, EventArgs e)
        {
            ArtikelWijzigen artikelForm = new ArtikelWijzigen(rowIndex);
            artikelForm.ShowDialog();

            RefreshDataGrid();
        }
        /// <summary>
        /// verwijderd het geselecteerde scherm na bevesteging
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Weet je zeker dat je dit artikel wilt verwijderen?", "Artikel verwijderen", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = AUSfp; User ID = root; Password = ");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE  from artikelen where id =" + rowIndex, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                RefreshDataGrid();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        /// <summary>
        /// refresched de datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click_1(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }



        private void inleverUitleenIcon_Click(object sender, EventArgs e)
        {
            rowIndex = DataGrid.SelectedCells[0].Value.ToString();
            Artikel artikel = GetArtikel(int.Parse(rowIndex));



            MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = AUSfp; User ID = root; Password = ");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from artikelen WHERE id = '" + artikel.Id + "' AND status = '1'", connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MySqlConnection connection1 = new MySqlConnection("Data Source = localhost; Initial Catalog = AUSfp; User ID = root; Password = ");
                connection1.Open();
                MySqlCommand cmd1 = new MySqlCommand("UPDATE artikelen SET status='0', leerlingnummer='0', lener='0' WHERE id='" + artikel.Id + "'", connection1);
                MySqlDataReader reader1 = cmd1.ExecuteReader();

                reader1.Close();
                cmd1.Dispose();
                connection1.Close();

                MessageBox.Show("Artikel succesvol ingeleverd.");
            }
            else
            {
                Uitlenen UitleenForm = new Uitlenen(artikel);
                UitleenForm.ShowDialog();
            }

            reader.Close();
            cmd.Dispose();
            connection.Close();

            RefreshDataGrid();
        }
        /// <summary>
        /// verwijst bij enter klik naar de zoek functie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchIcon_Click_1(this, new EventArgs());
            }
        }
        /// <summary>
        /// opent chat met leerlingnummer van persoon waaraan artikel is uitgeleend
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeamsImg_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://teams.microsoft.com/l/chat/0/0?users=" + UserEmail);
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            SearchIcon_Click_1(this, new EventArgs());
        }

        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (userIsLoggedIn == true)
            {
                inleverUitleenIcon_Click(this, new EventArgs());
            }
        }
    }
}
