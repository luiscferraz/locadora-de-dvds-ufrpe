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
    public partial class Form_Reserva : Form
    {
        public Form_Reserva()
        {
            InitializeComponent();
        }

        private void reservaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);

        }

        private void Form_Reserva_Load(object sender, EventArgs e)
        {
            {
                // TODO: This line of code loads data into the 'bD_LocadoraDataSet2.DVD' table. You can move, or remove it, as needed.
                this.dVDTableAdapter.Fill(this.bD_LocadoraDataSet.DVD);
                // TODO: This line of code loads data into the 'bD_LocadoraDataSet.ItensReserva' table. You can move, or remove it, as needed.
                this.itensReservaTableAdapter.Fill(this.bD_LocadoraDataSet.ItensReserva);
                // TODO: This line of code loads data into the 'bD_LocadoraDataSet.ItensReserva' table. You can move, or remove it, as needed.
                this.itensReservaTableAdapter.Fill(this.bD_LocadoraDataSet.ItensReserva);
                // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Reserva' table. You can move, or remove it, as needed.
                this.reservaTableAdapter.Fill(this.bD_LocadoraDataSet.Reserva);
                // TODO: This line of code loads data into the 'bD_LocadoraDataSet1.DVD' table. You can move, or remove it, as needed.
                this.dVDTableAdapter.Fill(this.bD_LocadoraDataSet.DVD);
                // TODO: This line of code loads data into the 'bD_LocadoraDataSet.DVD' table. You can move, or remove it, as needed.
                this.dVDTableAdapter.Fill(this.bD_LocadoraDataSet.DVD);
                this.dVDBindingSource.AddNew();
                //alterardata();

                reservaBindingNavigatorSaveItem_Click(sender, e);

                // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Cliente' table. You can move, or remove it, as needed.
                this.clienteTableAdapter.Fill(this.bD_LocadoraDataSet.Cliente);
                // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
                //this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);
                // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Locação' table. You can move, or remove it, as needed.
                this.reservaTableAdapter.Fill(this.bD_LocadoraDataSet.Reserva);

                this.reservaBindingSource.MoveLast();
            }

        }
        private void código_ClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                código_ClienteComboBox.SelectedValue = código_ClienteTextBox.Text;

                if (código_ClienteComboBox.Text == "")
                {
                    MessageBox.Show("Cliente não cadastrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            código_ClienteTextBox.Text = código_ClienteComboBox.SelectedValue.ToString();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                comboBox4.SelectedValue = textBox2.Text;

                if (comboBox4.Text == "")
                {
                    MessageBox.Show("Cliente não cadastrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            int cod2;

            try
            {
                if (e.KeyChar == 13)
                {
                    cod2 = this.dVDTableAdapter.FillByConsultaDVD(bD_LocadoraDataSet.DVD, Convert.ToInt32(textBox2.Text));

                    this.dVDTableAdapter.Fill(bD_LocadoraDataSet.DVD);

                    int ncopias2 = this.bD_LocadoraDataSet.DVD.FindByCódigo_DVD(Convert.ToInt32(textBox2.Text)).Nº_de_Cópias_Disponíveis;

                    if (cod2 == 1)
                    {
                        this.bD_LocadoraDataSet.ItensReserva.Rows.Add(null, Convert.ToInt32(códigoTextBox.Text), Convert.ToInt32(textBox2.Text), ncopias2);
                    }
                    else
                    {
                        MessageBox.Show("DVD não encontrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox2.Text = comboBox4.SelectedValue.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(código_ClienteTextBox.Text) || string.IsNullOrEmpty(código_ClienteComboBox.Text))
            {
                MessageBox.Show("Informe o cliente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (itensReservaDataGridView.RowCount > 1)
                {
                    reservaBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(this.bD_LocadoraDataSet);

                    MessageBox.Show("Reserva realizada com sucesso!", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Informe os DVDs!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.reservaBindingSource.AddNew();
            data_da_ReservaDateTimePicker.Text = DateTime.Now.ToShortDateString();
            código_ClienteComboBox.Text = null;
            comboBox4.Text = null;
            textBox2.Text = null;
            if (itensReservaDataGridView.RowCount > 1)
            {
                for (int i = 0; i <= itensReservaDataGridView.RowCount + 1; i++)
                {
                    this.itensReservaBindingSource.RemoveCurrent();
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.itensReservaBindingSource.RemoveCurrent();
        }
    }
}
