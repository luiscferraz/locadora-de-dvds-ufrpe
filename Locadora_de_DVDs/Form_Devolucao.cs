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
    public partial class Form_Devolucao : Form
    {
        public Form_Devolucao()
        {
            InitializeComponent();
        }

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);

        }

        private void Form_Devolucao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.DVD' table. You can move, or remove it, as needed.
            this.dVDTableAdapter.Fill(this.bD_LocadoraDataSet.DVD);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bD_LocadoraDataSet.Cliente);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);

        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            int countcliente;

            if (e.KeyChar == 13)
            {
                countcliente = this.clienteTableAdapter.FillByCodigoCliente(this.bD_LocadoraDataSet.Cliente, Convert.ToInt32(textBox1.Text));

                if (countcliente == 1)
                {
                    textBox2.Text = this.bD_LocadoraDataSet.Cliente.FindByCódigo_Cliente(Convert.ToInt32(textBox1.Text)).Nome;

                    int nloc = itemTableAdapter.FillByCodigoCliente(this.bD_LocadoraDataSet.Item, Convert.ToInt32(textBox1.Text));

                    if (nloc == 0)
                    {
                        MessageBox.Show("Cliente não possui locações pendentes!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    textBox2.Clear();
                    bD_LocadoraDataSet.Item.Clear();
                    MessageBox.Show("Cliente não existe!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            new Form_devoluçãopesqcliente(this).ShowDialog();
        }

        public void setCodigoCliente(int codigo, String nome)
        {
            textBox1.Text = codigo.ToString();
            textBox2.Text = nome;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < itemDataGridView.Rows.Count; i++)
            {
                if (bool.Parse(itemDataGridView[0, i].EditedFormattedValue.ToString()))
                {
                    itemDataGridView[7, 1].Value = dateTimePicker1.Value.ToShortDateString();
                }

            }

            itemBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);
            MessageBox.Show("Devolução efetuada com sucesso!", "Devolução", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
