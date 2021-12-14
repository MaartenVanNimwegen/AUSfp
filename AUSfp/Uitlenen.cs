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
    public partial class Uitlenen : Form
    {
        Artikel artikel;

        public Uitlenen(Artikel artkl)
        {
            InitializeComponent();
            artikel = artkl;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void inleverUitleenIcon_Click(object sender, EventArgs e)
        {
            int leerlingnr = Int32.Parse(StudentId.Text);
            string leerlingnaam = StudentName.Text;

            if (leerlingnr <= 0)
            {
                MessageBox.Show("Student nummer is niet geldig.");
            }
            else if (leerlingnaam.Length <= 0)
            {
                MessageBox.Show("Student naam is niet geldig");
            }
            else
            {

                MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = testdatabase; User ID = root; Password = ");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE artikelen SET status='1', leerlingnummer='" + leerlingnr + "', inleverdatum='" + TurnInDateTime.Value.Date + "' WHERE id='" + artikel.Id + "'", connection);
                cmd.ExecuteReader();

                MessageBox.Show("Artikel succesvol uitgeleend.");

                Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
