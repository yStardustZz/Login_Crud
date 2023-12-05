using Login_Crud.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Crud
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void CelularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCelulares objCadCelulares = new frmCadCelulares();
            objCadCelulares.MdiParent = this;
            objCadCelulares.Show();

        }
    }
}
