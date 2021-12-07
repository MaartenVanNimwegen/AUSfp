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
        Dictionary<int, string> Items = new Dictionary<int, string>(){
            {0, "itemnaam, categorie, lener, inleverdatum, status, leerlingnummer, beschrijving, toevoeger, toevoegdatum"}
        };
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
            deleteIcon.Visible = weergeven;
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
        private void SQL2List()
        {

            string query = "SELECT * FROM artikelen";

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = "Data Source = localhost; Initial Catalog = testdatabase; User ID = root; Password = ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string Props =
                                reader.GetString(1).ToString() + "," +
                                reader.GetString(2).ToString() + "," +
                                reader.GetString(3).ToString() + "," +
                                reader.GetString(4).ToString() + "," +
                                reader.GetInt32(5) + "," +
                                reader.GetInt32(6) + "," +
                                reader.GetString(7).ToString() + "," +
                                reader.GetString(8).ToString() + "," +
                                reader.GetString(9).ToString();

                            Items.Add( reader.GetInt32(0), Props );


                            
                        }
                    }
                    reader.Close();

                }
            }

        }

        private void RefreshDataGrid()
        {
            SQL2List();

            foreach (var ItemData in Items)
            {
                DataGrid.Rows.Add(ItemData);
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
            string naamArtikel = "";
            naamArtikel = DataGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }
    }
}
