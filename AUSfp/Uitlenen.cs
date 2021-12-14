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

        }
    }
}
