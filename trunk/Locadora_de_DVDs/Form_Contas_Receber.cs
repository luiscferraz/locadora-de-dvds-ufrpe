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
    public partial class Form_Contas_Receber : Form
    {
        public Form_Contas_Receber()
        {
            InitializeComponent();
        }

        private void contas_a_ReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(devedorTextBox.Text) || string.IsNullOrEmpty(valorMaskedTextBox.Text) || string.IsNullOrEmpty(dataDateTimePicker.Text) || string.IsNullOrEmpty(vencimentoDateTimePicker.Text) || string.IsNullOrEmpty(forma_de_RecebimentoMaskedTextBox.Text) || string.IsNullOrEmpty(situaçãoTextBox.Text) || string.IsNullOrEmpty(descriçãoTextBox.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    this.Validate();
                    this.contas_a_ReceberBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                    MessageBox.Show("Inclusão realizada com sucesso!", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.contas_a_ReceberTableAdapter.Fill(this.bD_LocadoraDataSet.Contas_a_Receber);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao salvar o registro!" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Form_Contas_Receber_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Contas_a_Receber' table. You can move, or remove it, as needed.
            this.contas_a_ReceberTableAdapter.Fill(this.bD_LocadoraDataSet.Contas_a_Receber);

        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir essa Conta a Pagar ?", "Excluir Conta a Pagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Validate();
                    this.contas_a_ReceberBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                    MessageBox.Show("Conta a Pagar excluído com sucesso!", "Excluir Conta a Pagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.contas_a_ReceberTableAdapter.Fill(this.bD_LocadoraDataSet.Contas_a_Receber);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            contas_a_ReceberBindingNavigatorSaveItem_Click(sender, e);
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(devedorTextBox.Text) || string.IsNullOrEmpty(valorMaskedTextBox.Text) || string.IsNullOrEmpty(dataDateTimePicker.Text) || string.IsNullOrEmpty(vencimentoDateTimePicker.Text) || string.IsNullOrEmpty(forma_de_RecebimentoMaskedTextBox.Text) || string.IsNullOrEmpty(situaçãoTextBox.Text) || string.IsNullOrEmpty(descriçãoTextBox.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    MessageBox.Show("Alteração realizada com sucesso!", "Alterar Conta a Pagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Validate();
                    this. contas_a_ReceberBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                    this. contas_a_ReceberTableAdapter.Fill(this.bD_LocadoraDataSet. Contas_a_Receber);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao salvar o registro!" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.contas_a_ReceberBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contas_a_ReceberBindingNavigatorSaveItem_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.contas_a_ReceberBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.contas_a_ReceberBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.contas_a_ReceberBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.contas_a_ReceberBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            toolStripButton14_Click(sender, e);
        }

    }
}
