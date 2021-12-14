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
    public partial class ArtikelVerwijderen : Form
    {
        private static string id = "";
        public ArtikelVerwijderen(string rowId)
        {
            InitializeComponent();
            id = rowId;
        }

        private void verwijderenNee_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void verwijderenJa_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = testdatabase; User ID = root; Password = ");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from artikelen where id = " + id, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
        }
    }
}
