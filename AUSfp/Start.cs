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
    public partial class Start : Form
    {
        bool userIsLoggedIn = false;

        public Start()
        {
            InitializeComponent();
            showHeaderItems(false);
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

        private void NameLabel_VisibleChanged(object sender, EventArgs e)
        {
            NameLabel.Text = Login.welkomNaam;
        }

        private void dataGridViewIngelogd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
