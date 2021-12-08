﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
     Om bij een artikel en zijn properties te komen doe je dit:

            ArtikelDataList = Items[artikelnr - 1]

        artikelnr - 1 is er omdat de list start met positie 0, niet 1



    Om bij een artikel zijn naam te komen doe je dit:

            ArtikelNaam = Items[artikelnr - 1][0]

        De laatste [0] is omdat je positie 0 van de list met properties selecteert. Als je de categorie wilt hebben doe je dus [1]
*/

namespace AUSfp
{
    public partial class Start : Form
    {
        bool userIsLoggedIn = false;
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
        private void LoginBtn_Click(object sender, EventArgs e)
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
            ManageItemsBtn.Visible = weergeven;
            LoginBtn.Visible = !weergeven;
            LogoutBtn.Visible = weergeven;
            NameLabel.Visible = weergeven;
            DeleteBtn.Visible = weergeven;
            wijzigIcon.Visible = weergeven;
            inleverUitleenIcon.Visible = weergeven;
            naamLenerLabel.Visible = weergeven;
        }
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

        private void dataGridViewIngelogd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /// <summary>
        /// Deze functie converteerd een SQL ding naar een list
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

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
        /// <summary>
        /// wanneer er een rij word geselecteerd word de informatie in het rechter deel van het scherm veranderd naar de info uit het rechter deel van het scherm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void testsbtntnt_Click(object sender, EventArgs e)
        {
            CategorieBeheer myForm = new CategorieBeheer();
            DialogResult dialogResult = myForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                userIsLoggedIn = true;
                showHeaderItems(userIsLoggedIn);
            }

        }

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
    }
}
