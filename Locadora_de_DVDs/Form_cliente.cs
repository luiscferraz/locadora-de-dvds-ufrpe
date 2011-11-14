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
                try
                {
                    this.Validate();
                    this.clienteBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                    MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao salvar o registro!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form_cliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bD_LocadoraDataSet.Cliente);

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
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                    this.clienteTableAdapter.Fill(this.bD_LocadoraDataSet.Cliente);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            clienteBindingNavigatorSaveItem_Click(sender, e);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            this.clienteTableAdapter.FillByPesquisarCliente(bD_LocadoraDataSet.Cliente, textBox8.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.clienteTableAdapter.FillByPesquisarCliente(bD_LocadoraDataSet.Cliente, textBox1.Text);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomeTextBox.Text) || string.IsNullOrEmpty(endereçoTextBox.Text) || string.IsNullOrEmpty(bairroTextBox.Text) || string.IsNullOrEmpty(cidadeTextBox.Text) || string.IsNullOrEmpty(rGMaskedTextBox.Text) || string.IsNullOrEmpty(cPFMaskedTextBox.Text) || string.IsNullOrEmpty(telefoneMaskedTextBox.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    this.Validate();
                    this.clienteBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                    MessageBox.Show("Alteração realizada com sucesso!", "Alterar Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao salvar o registro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clienteBindingNavigatorSaveItem_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toolStripButton9_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.MovePrevious();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.MoveFirst();
        }
    }
}
