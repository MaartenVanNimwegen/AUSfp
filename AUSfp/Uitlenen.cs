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
            string leerlingnr = StudentId.Text;
            string leerlingnaam = StudentName.Text;

            if (StudentId.Text.Length > 0 && StudentName.Text.Length > 0)
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
            else
            {
                MessageBox.Show("Vul alle velden in!");
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