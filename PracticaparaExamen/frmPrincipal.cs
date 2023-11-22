using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaparaExamen
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regular regular = new Regular();
            regular.Show();
        }

        private void pregradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pregrado pregrado = new Pregrado();
            pregrado.Show();
        }
    }
}
