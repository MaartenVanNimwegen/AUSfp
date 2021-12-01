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
        bool userIsLoggedIN = false;


        public Start()
        {
            InitializeComponent();
        }
        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void SearchIcon_Click(object sender, EventArgs e)
        {

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
                userIsLoggedIN = true;
            }
        }
        private void showHeaderItems(bool showHeaderItems)
        {
           
        }


        private void ItemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
