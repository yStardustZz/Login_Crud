using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Crud.Formulários
{
    public partial class frmCadCelulares : Form
    {
        public frmCadCelulares()
        {
            InitializeComponent();
        }

        private void Tb_CelularesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_CelularesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Agenda);

        }

        private void FrmCadCelulares_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.tb_Celulares'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_CelularesTableAdapter.Fill(this.dataSet_Agenda.tb_Celulares);

        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirma exclusão?", "Excluindo registro...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                tb_CelularesBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dataSet_Agenda);


            }
        }
    }
}
