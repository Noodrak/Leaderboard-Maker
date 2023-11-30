using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetPerso
{
    public partial class FrmParaduclassement : Form
    {
        public FrmParaduclassement()
        {
            InitializeComponent();
        }

        private void CbxNbrjoueur(object sender, EventArgs e)
        {

        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            FrmInfoJoueurs Frminfojoueurs = new FrmInfoJoueurs();
            Frminfojoueurs.ShowDialog();
        }

        private void chbequipe_CheckedChanged(object sender, EventArgs e)
        {
            lblequipe.Show();
        }
    }
}
