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
                this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Funcionários' table. You can move, or remove it, as needed.
            this.funcionáriosTableAdapter.Fill(this.bD_LocadoraDataSet.Funcionários);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomeTextBox.Text) || string.IsNullOrEmpty(endereçoTextBox.Text) || string.IsNullOrEmpty(bairroTextBox.Text) || string.IsNullOrEmpty(cidadeTextBox.Text) || string.IsNullOrEmpty(rGMaskedTextBox.Text) || string.IsNullOrEmpty(cPFMaskedTextBox.Text) || string.IsNullOrEmpty(telefoneMaskedTextBox.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (acessoCheckBox.Checked == false && (loginTextBox.Text != "" || senhaTextBox.Text != ""))
                {
                    MessageBox.Show("Permissão de acesso desativada: Login e Senha não podem ser definidos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (acessoCheckBox.Checked == true && (loginTextBox.Text == "" || senhaTextBox.Text == ""))
                {
                    MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    funcionáriosBindingNavigatorSaveItem_Click(sender, e);
                }
            }
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
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                    this.funcionáriosTableAdapter.Fill(this.bD_LocadoraDataSet.Funcionários);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(maskedTextBox1.Text) || string.IsNullOrEmpty(maskedTextBox2.Text) || string.IsNullOrEmpty(maskedTextBox3.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (checkBox1.Checked == false && (textBox8.Text != "" || textBox9.Text != ""))
                {
                    MessageBox.Show("Permissão de acesso desativada: Login e Senha não podem ser definidos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (checkBox1.Checked == true && (textBox8.Text == "" || textBox9.Text == ""))
                {
                    MessageBox.Show("Preencha os campos de Login e Senha", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        this.Validate();
                        this.funcionáriosBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                        MessageBox.Show("Alteração realizada com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Falha ao salvar o registro!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.funcionáriosTableAdapter.FillByPesquisarFuncionario(bD_LocadoraDataSet.Funcionários, textBox1.Text);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            this.funcionáriosTableAdapter.FillByPesquisarFuncionario(bD_LocadoraDataSet.Funcionários, textBox10.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripButton7_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.funcionáriosBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toolStripButton9_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.funcionáriosBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.funcionáriosBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.funcionáriosBindingSource.MovePrevious();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.funcionáriosBindingSource.MoveFirst();
        }
    }
}

