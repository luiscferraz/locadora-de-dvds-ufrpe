﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Locadora_de_DVDs
{
    public partial class Form_principal : Form
    {
        DateTime data_hora;
        
        public Form_principal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            String data = String.Format("{0:d}", data_hora);
            String hora = data_hora.ToLongTimeString();
            lb_status1.Text = data;
            lb_status2.Text = hora;
        }

        private void bt_clientes_Click(object sender, EventArgs e)
        {
            new Form_cliente().ShowDialog();
        }

        private void bt_acervo_Click(object sender, EventArgs e)
        {
            new Form_acervo().ShowDialog();
        }

        private void bt_fornecedores_Click(object sender, EventArgs e)
        {
            new Form_fornecedores().ShowDialog();
        }

        private void bt_funcionarios_Click(object sender, EventArgs e)
        {
            new Form_funcionarios().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Acesso_Contas fm = new Form_Acesso_Contas() ;
            fm.Show() ;
        }

        private void bt_caixa_Click(object sender, EventArgs e)
        {
            new Form_Caixa().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form_Locacao_S().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form_Devolucao().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form_Reserva().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
