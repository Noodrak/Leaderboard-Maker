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
    public partial class FrmBienvenue : Form
    {
        public FrmBienvenue()
        {
            InitializeComponent();
        }

        private void FrmBienvenue_Load(object sender, EventArgs e)
        {

        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmParaduclassement frmParaduclassement = new FrmParaduclassement();
            frmParaduclassement.ShowDialog();
        }
    }
}
