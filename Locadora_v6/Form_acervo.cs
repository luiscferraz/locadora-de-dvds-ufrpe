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
    public partial class Form_acervo : Form
    {
        public Form_acervo()
        {
            InitializeComponent();
        }

        private void dVDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    this.Validate();
                    this.dVDBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_Locadora_v5DataSet);
                    MessageBox.Show("Inclusão realizada com sucesso!", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dVDTableAdapter.Fill(this.bD_Locadora_v5DataSet.DVD);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao salvar o registro!" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form_acervo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_Locadora_v5DataSet.DVD' table. You can move, or remove it, as needed.
            this.dVDTableAdapter.Fill(this.bD_Locadora_v5DataSet.DVD);

        }

        
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir esse Título?", "Excluir DVD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Validate();
                    this.dVDBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_Locadora_v5DataSet);
                    MessageBox.Show("Título excluído com sucesso!", "Excluir DVD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dVDTableAdapter.Fill(this.bD_Locadora_v5DataSet.DVD);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dVDTableAdapter.FillByDVDTitulo(bD_Locadora_v5DataSet.DVD, textBox1.Text);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            dVDBindingNavigatorSaveItem_Click(sender, e);
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.dVDBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_Locadora_v5DataSet);
                MessageBox.Show("Alteração realizada com sucesso!", "Alterar Título", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dVDTableAdapter.Fill(this.bD_Locadora_v5DataSet.DVD);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o registro!" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.dVDTableAdapter.FillByDVDTitulo(bD_Locadora_v5DataSet.DVD, textBox2.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
