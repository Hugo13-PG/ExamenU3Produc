using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ExamenU3Produc
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void imprimirProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CristalReport cristal = new CristalReport();
            cristal.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           PRODUCTO pRODUCTO = new PRODUCTO();
            pRODUCTO.Show();
        }
    }
}
