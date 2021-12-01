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
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login myForm = new Login();
            myForm.ShowDialog();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void SearchIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
