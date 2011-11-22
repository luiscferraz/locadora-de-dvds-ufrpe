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
            this.Validate();
            this.contas_a_ReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);

        }

        private void Form_Contas_Receber_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Contas_a_Receber' table. You can move, or remove it, as needed.
            this.contas_a_ReceberTableAdapter.Fill(this.bD_LocadoraDataSet.Contas_a_Receber);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.contas_a_ReceberBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contas_a_ReceberBindingNavigatorSaveItem_Click(sender, e);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir essa nota ?", "Excluir Nota", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Validate();
                    this.contas_a_ReceberBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                    MessageBox.Show("Nota excluído com sucesso!", "Excluir Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(devedorTextBox.Text) || string.IsNullOrEmpty(dataDateTimePicker.Text) || string.IsNullOrEmpty(vencimentoDateTimePicker.Text) || string.IsNullOrEmpty(forma_de_RecebimentoTextBox.Text) || string.IsNullOrEmpty(situaçãoTextBox.Text) || string.IsNullOrEmpty(descriçãoTextBox.Text) || string.IsNullOrEmpty(valorTextBox.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    this.Validate();
                    this.contas_a_ReceberBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
                    MessageBox.Show("Alteração realizada com sucesso!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.contas_a_ReceberTableAdapter.Fill(this.bD_LocadoraDataSet.Contas_a_Receber);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao salvar o registro!" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            contas_a_ReceberBindingNavigatorSaveItem_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.contas_a_ReceberBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.contas_a_ReceberBindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.contas_a_ReceberBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.contas_a_ReceberBindingSource.MoveNext();
        }
    }
}
