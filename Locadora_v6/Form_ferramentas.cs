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
    public partial class Form_ferramentas : Form
    {
        public Form_ferramentas()
        {
            InitializeComponent();
        }

        private void bt_backup_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (System.IO.File.Exists(saveFileDialog1.FileName))
                    {
                        System.IO.File.Delete(saveFileDialog1.FileName);
                    }

                    System.IO.File.Copy(Application.StartupPath.ToString() + "\\BD_Locadora_v5.accdb", saveFileDialog1.FileName);
                    MessageBox.Show("Backup realizado com sucesso!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!" + ex.Message);
            }
        }

        private void bt_restaurar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(Application.StartupPath.ToString() + "\\BD_Locadora_v5.accdb"))
                {
                    System.IO.File.Delete(Application.StartupPath.ToString() + "\\BD_Locadora_v5.accdb");
                }

                System.IO.File.Copy(openFileDialog1.FileName, Application.StartupPath.ToString() + "\\BD_Locadora_v5.accdb");
                MessageBox.Show("Backup restaurado com sucesso!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
