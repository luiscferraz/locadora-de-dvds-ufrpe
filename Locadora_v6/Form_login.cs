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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void funcionáriosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionáriosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_Locadora_v5DataSet);

        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_Locadora_v5DataSet.Funcionários' table. You can move, or remove it, as needed.
            this.funcionáriosTableAdapter.Fill(this.bD_Locadora_v5DataSet.Funcionários);

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            int result = funcionáriosTableAdapter.FillByFuncionariosLogin(bD_Locadora_v5DataSet.Funcionários, tb_login.Text, tb_senha.Text);

            if (result == 1)
            {
                Form_principal menu_principal = new Form_principal();
                menu_principal.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorreto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
