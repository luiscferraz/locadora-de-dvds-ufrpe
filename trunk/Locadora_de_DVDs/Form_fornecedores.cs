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
    public partial class Form_fornecedores : Form
    {
        public Form_fornecedores()
        {
            InitializeComponent();
        }

        private void fornecedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(maskedTextBox1.Text) || string.IsNullOrEmpty(maskedTextBox2.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    this.Validate();
                    this.fornecedoresBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                    MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao salvar o registro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Form_fornecedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.bD_LocadoraDataSet.Fornecedores);

        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            fornecedoresBindingNavigatorSaveItem_Click(sender, e);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(razão_SocialTextBox.Text) || string.IsNullOrEmpty(cPF_CNPJTextBox.Text) || string.IsNullOrEmpty(endereçoTextBox.Text) || string.IsNullOrEmpty(bairroTextBox.Text) || string.IsNullOrEmpty(cidadeTextBox.Text) || string.IsNullOrEmpty(uFTextBox.Text) || string.IsNullOrEmpty(cEPMaskedTextBox.Text) || string.IsNullOrEmpty(telefoneMaskedTextBox.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    this.Validate();
                    this.fornecedoresBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                    MessageBox.Show("Alteração realizada com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao salvar o registro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir essa conta?", "Excluir Conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Conta excluída com sucesso!", "Excluir Conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Validate();
                    this.fornecedoresBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            this.fornecedoresTableAdapter.FillByPesquisarFornecedor(bD_LocadoraDataSet.Fornecedores, textBox10.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.fornecedoresTableAdapter.FillByPesquisarFornecedor(bD_LocadoraDataSet.Fornecedores, textBox1.Text);
        }
    }
}
