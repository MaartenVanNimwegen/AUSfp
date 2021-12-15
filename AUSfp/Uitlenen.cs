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
                string CorrectDateFormat = TurnInDateTime.Value.Year.ToString() + "-" + TurnInDateTime.Value.Month.ToString() + "-" + TurnInDateTime.Value.Day.ToString();
                //string _optie2 = TurnInDateTime.Value.ToString("yyyy-MM-dd");

                MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = AUSfp; User ID = root; Password = ");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE artikelen SET status='1', leerlingnummer='" + leerlingnr + "', lener='" + leerlingnaam + "', inleverdatum='" + CorrectDateFormat + "' WHERE id='" + artikel.Id + "'", connection);
                cmd.ExecuteReader();

                MessageBox.Show("Artikel succesvol uitgeleend.");

                Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StudentId_Enter(object sender, EventArgs e)
        {
            if (StudentId.Text == "Student nr...")
            {
                StudentId.Text = "";
            }
        }

        private void StudentName_Enter(object sender, EventArgs e)
        {
            if (StudentName.Text == "Student naam...")
            {
                StudentName.Text = "";
            }
        }
    }
}