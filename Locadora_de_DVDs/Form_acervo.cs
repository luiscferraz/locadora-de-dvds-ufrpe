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
    public partial class Form_acervo : Form
    {
        public Form_acervo()
        {
            InitializeComponent();
        }

        private void dVDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    this.Validate();
                    this.dVDBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                    MessageBox.Show("Inclusão realizada com sucesso!", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dVDTableAdapter.Fill(this.bD_LocadoraDataSet.DVD);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao salvar o registro!" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Form_acervo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.DVD' table. You can move, or remove it, as needed.
            this.dVDTableAdapter.Fill(this.bD_LocadoraDataSet.DVD);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir esse Título?", "Excluir DVD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Validate();
                    this.dVDBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                    MessageBox.Show("Título excluído com sucesso!", "Excluir DVD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dVDTableAdapter.Fill(this.bD_LocadoraDataSet.DVD);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            dVDBindingNavigatorSaveItem_Click(sender, e);
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(títuloTextBox.Text) || string.IsNullOrEmpty(gêneroTextBox.Text) || string.IsNullOrEmpty(classificaçãoTextBox.Text) || string.IsNullOrEmpty(código_do_FornecedorTextBox.Text) || string.IsNullOrEmpty(nº_de_Cópias_DisponíveisTextBox.Text) || string.IsNullOrEmpty(preçoMaskedTextBox.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    this.Validate();
                    this.dVDBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                    MessageBox.Show("Alteração realizada com sucesso!", "Alterar Título", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dVDTableAdapter.Fill(this.bD_LocadoraDataSet.DVD);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao salvar o registro!" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dVDTableAdapter.FillByPesquisarDVD(bD_LocadoraDataSet.DVD, textBox1.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            this.dVDTableAdapter.FillByPesquisarDVD(bD_LocadoraDataSet.DVD, textBox8.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripButton14_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dVDBindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dVDBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.dVDBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.dVDBindingSource.MoveFirst();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dVDBindingNavigatorSaveItem_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.dVDBindingSource.AddNew();
        }
    }
}
