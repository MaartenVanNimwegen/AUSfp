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
            MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = AUSfp; User ID = root; Password = ");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE artikelen SET status='0', leerlingnummer='0', lener='0' WHERE id='" + artikel.Id + "'", connection);
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
