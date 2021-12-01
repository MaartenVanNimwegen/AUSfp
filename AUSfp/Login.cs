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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// username inputfield wordt leeg gemaakt wanneer er op word geklikt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usernameInput_Click(object sender, EventArgs e)
        {
            usernameInput.Text = "";
        }
        /// <summary>
        /// passwordfield wordt leeg gemaakt wanneer er op word geklikt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordInput_Click(object sender, EventArgs e)
        {
            passwordInput.Text = "";
        }
        /// <summary>
        /// Wanneer de loginBtn word geklikt word er ingelogd.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Data Source = localhost; Initial Catalog = testdatabase; User ID = root; Password = ");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from users where username = '" + usernameInput.Text + "' AND password = '" + passwordInput.Text + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                
            }
            else
            {
                MessageBox.Show("Gebruikersnaam en wachtwoord komen niet overeen!", "Er is een fout opgetreden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            usernameInput.Text = string.Empty;
            passwordInput.Text = string.Empty;
            reader.Close();
            cmd.Dispose();
            con.Close();        
        }
    }
}