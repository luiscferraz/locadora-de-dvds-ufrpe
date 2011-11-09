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
    public partial class Form_funcionarios : Form
    {
        public Form_funcionarios()
        {
            InitializeComponent();
        }

        private void funcionáriosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.funcionáriosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_Locadora_v5DataSet);
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_Locadora_v5DataSet.Funcionários' table. You can move, or remove it, as needed.
            this.funcionáriosTableAdapter.Fill(this.bD_Locadora_v5DataSet.Funcionários);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem_Click(sender, e);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox9.Text) || string.IsNullOrEmpty(textBox10.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (checkBox1.Checked == false && (textBox12.Text != "" || textBox13.Text != ""))
                {
                    MessageBox.Show("Permissão de acesso desativada: Login e Senha não podem ser definidos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (checkBox1.Checked == true && (textBox12.Text == "" || textBox13.Text == ""))
                {
                    MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    funcionáriosBindingNavigatorSaveItem_Click(sender, e);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.funcionáriosTableAdapter.FillByFuncionariosNome(bD_Locadora_v5DataSet.Funcionários, textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.funcionáriosTableAdapter.FillByFuncionariosNome(bD_Locadora_v5DataSet.Funcionários, textBox1.Text);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir essa funcionário?", "Excluir Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Funcionário excluído com sucesso!", "Excluir Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Validate();
                    this.funcionáriosBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_Locadora_v5DataSet);
                    this.funcionáriosTableAdapter.Fill(this.bD_Locadora_v5DataSet.Funcionários);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (acessoCheckBox.Checked == false && (loginTextBox.Text != "" || senhaTextBox.Text != ""))
            {
                MessageBox.Show("Permissão de acesso desativada: Login e Senha não podem ser definidos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (acessoCheckBox.Checked == true && (loginTextBox.Text == "" || senhaTextBox.Text == ""))
            {
                MessageBox.Show("Preencha os campos de Login e Senha", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    this.Validate();
                    this.funcionáriosBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_Locadora_v5DataSet);
                    MessageBox.Show("Alteração realizada com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao salvar o registro!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
