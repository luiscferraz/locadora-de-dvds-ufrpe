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
    public partial class Form_locacao : Form
    {
        public Form_locacao()
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

        private void Form_locacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet2.DVD' table. You can move, or remove it, as needed.
            this.dVDTableAdapter.Fill(this.bD_LocadoraDataSet2.DVD);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.ItensReserva' table. You can move, or remove it, as needed.
            this.itensReservaTableAdapter.Fill(this.bD_LocadoraDataSet.ItensReserva);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.ItensReserva' table. You can move, or remove it, as needed.
            this.itensReservaTableAdapter.Fill(this.bD_LocadoraDataSet.ItensReserva);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Reserva' table. You can move, or remove it, as needed.
            this.reservaTableAdapter.Fill(this.bD_LocadoraDataSet.Reserva);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet1.DVD' table. You can move, or remove it, as needed.
            this.dVDTableAdapter.Fill(this.bD_LocadoraDataSet1.DVD);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.DVD' table. You can move, or remove it, as needed.
            this.dVDTableAdapter.Fill(this.bD_LocadoraDataSet.DVD);
            this.locaçãoBindingSource.AddNew();
            alterardata();
                       
            locaçãoBindingNavigatorSaveItem_Click(sender, e);

            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bD_LocadoraDataSet.Cliente);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Item' table. You can move, or remove it, as needed.
            //this.itemTableAdapter.Fill(this.bD_LocadoraDataSet.Item);
            // TODO: This line of code loads data into the 'bD_LocadoraDataSet.Locação' table. You can move, or remove it, as needed.
            this.locaçãoTableAdapter.Fill(this.bD_LocadoraDataSet.Locação);

            this.locaçãoBindingSource.MoveLast();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            alterardata();
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

        private void button3_Click(object sender, EventArgs e)
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
                    if (itemDataGridView.RowCount > 1)
                    {
                        for (int i = 0; i <= itemDataGridView.RowCount + 1; i++)
                        {
                            this.itemBindingSource.RemoveCurrent();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Informe os DVDs!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (e.KeyChar == 13)
            {
                comboBox2.SelectedValue = textBox1.Text;

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("DVD não cadastrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            textBox1.Text = comboBox2.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.itemBindingSource.RemoveCurrent();
        }


        // ---------------------------------------------------RESERVA---------------------------------------------------------

        private void código_ClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                comboBox3.SelectedValue = código_ClienteTextBox.Text;

                if (comboBox3.Text == "")
                {
                    MessageBox.Show("Cliente não cadastrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            código_ClienteTextBox.Text = comboBox3.SelectedValue.ToString();
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
                        this.bD_LocadoraDataSet.ItensReserva.Rows.Add(null, Convert.ToInt32(código_LocaçãoTextBox.Text), Convert.ToInt32(textBox2.Text), ncopias2);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.itensReservaBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(código_ClienteTextBox.Text) || string.IsNullOrEmpty(comboBox3.Text))
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.reservaBindingSource.AddNew();
            data_da_ReservaDateTimePicker.Text = DateTime.Now.ToShortDateString();
            comboBox3.Text = null;
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

        //---------------------------------------------------------DEVOLUCAO------------------------------------------------

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            int countcliente;
            
            if (e.KeyChar == 13)
            {
                countcliente = this.clienteTableAdapter.FillByCodigoCliente(this.bD_LocadoraDataSet.Cliente, Convert.ToInt32(textBox3.Text));

                if (countcliente == 1)
                {
                    textBox4.Text = this.bD_LocadoraDataSet.Cliente.FindByCódigo_Cliente(Convert.ToInt32(textBox3.Text)).Nome;

                    int nloc = itemTableAdapter.FillByCodigoCliente(this.bD_LocadoraDataSet.Item, Convert.ToInt32(textBox3.Text));

                    if (nloc == 0)
                    {
                        MessageBox.Show("Cliente não possui locações pendentes!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    textBox4.Clear();
                    bD_LocadoraDataSet.Item.Clear();
                    MessageBox.Show("Cliente não existe!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            new Form_devoluçãopesqcliente(this).ShowDialog();
        }

        public void setCodigoCliente(int codigo, String nome)
        {
            textBox3.Text = codigo.ToString();
            textBox4.Text = nome;
        }

        private void button6_Click(object sender, EventArgs e)
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
