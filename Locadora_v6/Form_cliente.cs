using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Locadora_v6
{
    public partial class Form_cliente : Form
    {
        public Form_cliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(maskedTextBox1.Text) || string.IsNullOrEmpty(maskedTextBox2.Text) || string.IsNullOrEmpty(maskedTextBox3.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_Locadora_v5DataSet);
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form_cliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_Locadora_v5DataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bD_Locadora_v5DataSet.Cliente);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir essa conta?", "Excluir Conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Conta excluída com sucesso!", "Excluir Conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Validate();
                    this.clienteBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_Locadora_v5DataSet);
                    this.clienteTableAdapter.Fill(this.bD_Locadora_v5DataSet.Cliente);
                }
            }
            catch (Exception ex)
            {                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.clienteTableAdapter.FillByClienteNome(bD_Locadora_v5DataSet.Cliente, textBox1.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            this.clienteTableAdapter.FillByClienteNome(bD_Locadora_v5DataSet.Cliente, textBox11.Text);
        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            clienteBindingNavigatorSaveItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void clienteBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            clienteBindingNavigatorSaveItem_Click(sender, e);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_Locadora_v5DataSet);
                MessageBox.Show("Alteração realizada com sucesso!", "Alterar Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clienteBindingNavigatorSaveItem_Click(sender, e);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
