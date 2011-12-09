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
    public partial class Form_Locacao_S : Form
    {
        public Form_Locacao_S()
        {
            InitializeComponent();
        }

        private void alterardata()
        {
            data_da_LocaçãoDateTimePicker.Text = DateTime.Now.ToShortDateString();
            data_da_DevoluçãoDateTimePicker.Text = DateTime.Now.AddDays(3).ToShortDateString();
        }  

        private void locaçãoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locaçãoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);

        }

        private void Form_Locacao_S_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.DVD' table. You can move, or remove it, as needed.
            this.dVDTableAdapter.Fill(this.bD_LocadoraDataSet.DVD);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bD_LocadoraDataSet.Cliente);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Locação' table. You can move, or remove it, as needed.
            this.locaçãoTableAdapter.Fill(this.bD_LocadoraDataSet.Locação);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(código_do_ClienteTextBox.Text) && string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Informe o cliente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (itemDataGridView.RowCount > 1)
                {
                    locaçãoBindingNavigatorSaveItem_Click(sender, e);
                    MessageBox.Show("Locação realizada com sucesso!", "Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // if (itemDataGridView.RowCount > 1)
                    //{
                    //  for (int i = 0; i <= itemDataGridView.RowCount + 1; i++)
                    // {
                    //   this.itemBindingSource.RemoveCurrent();
                    //}
                    //  }
                    //}
                    //else
                    //{
                    //  MessageBox.Show("Informe os DVDs!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    // }
                }
            }
        }
        private void código_do_ClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                comboBox1.SelectedValue = código_do_ClienteTextBox.Text;

                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Cliente não cadastrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            código_do_ClienteTextBox.Text = comboBox1.SelectedValue.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                títuloComboBox.SelectedValue = textBox1.Text;

                if (títuloComboBox.Text == "")
                {
                    MessageBox.Show("DVD não cadastrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //if (cod == 1)
                //{
                    //this.dVDTableAdapter.UpdateQuery
                //}
            }

            int cod;

            try
            {
                if (e.KeyChar == 13)
                {
                    cod = this.dVDTableAdapter.FillByConsultaDVD(bD_LocadoraDataSet.DVD, Convert.ToInt32(textBox1.Text));

                    this.dVDTableAdapter.Fill(bD_LocadoraDataSet.DVD);

                    string preco = this.bD_LocadoraDataSet.DVD.FindByCódigo_DVD(Convert.ToInt32(textBox1.Text)).Preço;
                    int ncopias = this.bD_LocadoraDataSet.DVD.FindByCódigo_DVD(Convert.ToInt32(textBox1.Text)).Nº_de_Cópias_Disponíveis;
                    string clas = this.bD_LocadoraDataSet.DVD.FindByCódigo_DVD(Convert.ToInt32(textBox1.Text)).Classificação;
                    //double n = Convert.ToDouble(preco);

                    if (ncopias > 0)
                    {
                        if (cod == 1)
                        {
                            this.bD_LocadoraDataSet.Item.Rows.Add(null, Convert.ToInt32(código_LocaçãoTextBox.Text), Convert.ToInt32(textBox1.Text), preco, clas, ncopias);

                            //double soma = Convert.ToDouble(this.itemTableAdapter.ItemSomaPreço());
                            //preço_TotalTextBox.Text = Convert.ToString(soma);
                        }
                        else
                        {
                            MessageBox.Show("DVD não encontrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("DVD indisponível!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar!" + ex.Message);
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox1.Text = títuloComboBox.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.itemBindingSource.RemoveCurrent();
        }
    }
}
