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
    public partial class Inleveren : Form
    {
        Artikel artikel;

        public Inleveren(Artikel artkl)
        {
            InitializeComponent();

            artikel = artkl;
        }

        private void inleverUitleenIcon_Click(object sender, EventArgs e)
        {
            //string JsNotes = "";

            //using (MySqlConnection connection = new MySqlConnection())
            //{
            //    connection.ConnectionString = "Data Source = localhost; convert zero datetime=True; Initial Catalog = AUSfp; User ID = root; Password = ";
            //    using (MySqlCommand command = new MySqlCommand("SELECT * FROM artikelen", connection))
            //    {
            //
            //        connection.Open();
            //        MySqlDataReader reader = command.ExecuteReader();
            //
             //       if (reader.HasRows)
              //      {
               //         while (reader.Read())
             //           {
            //                Artikel myArtikel = new Artikel();
            //                JsNotes = reader.GetString(11);
           //             }
           //             reader.Close();
           //         }
           //     }
           // }

            //Notes notes = JsonConvert.DeserializeOvject<Notes>(JsNotes);


            MySqlConnection connection1 = new MySqlConnection("Data Source = localhost; Initial Catalog = AUSfp; User ID = root; Password = ");
            connection1.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE artikelen SET status='0', leerlingnummer='0', lener='0' WHERE id='" + artikel.Id + "'", connection1);
            cmd.ExecuteReader();

            MessageBox.Show("Artikel succesvol ingeleverd.");

            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Note_Enter(object sender, EventArgs e)
        {
            if (Note.Text == "Notitie...")
            {
                Note.Text = "";
            }
        }
    }
}
