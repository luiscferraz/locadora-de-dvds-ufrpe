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
    public partial class Form_Acesso_Locacao : Form
    {
        public Form_Acesso_Locacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Locacao_S fm = new Form_Locacao_S();
            fm.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Devolucao fm = new Form_Devolucao();
            fm.Show();
            this.Visible = false ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Reserva fm = new Form_Reserva();
            fm.Show();
            this.Visible = false;
        }
    }
}
