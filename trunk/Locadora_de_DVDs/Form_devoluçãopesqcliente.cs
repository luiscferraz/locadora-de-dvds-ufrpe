using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Locadora_de_DVDs
{
    public partial class Form_devoluçãopesqcliente : Form
    {
        private Form_locacao formdevolucao;

        public Form_devoluçãopesqcliente()
        {
            InitializeComponent();
        }

        public Form_devoluçãopesqcliente(Form_locacao frm)
        {
            formdevolucao = frm;
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);

        }

        private void Form_devoluçãopesqcliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bD_LocadoraDataSet.Cliente);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.clienteTableAdapter.FillByPesquisarCliente(this.bD_LocadoraDataSet.Cliente, textBox1.Text);
        }

        private void clienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formdevolucao.setCodigoCliente(Convert.ToInt32(clienteDataGridView.CurrentRow.Cells[0].Value.ToString()), clienteDataGridView.CurrentRow.Cells[1].Value.ToString());
            this.Dispose();
        }
    }
}
