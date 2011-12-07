namespace Locadora_de_DVDs
{
    partial class Form_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_entrar = new System.Windows.Forms.Button();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.bD_LocadoraDataSet = new Locadora_de_DVDs.BD_LocadoraDataSet();
            this.funcionáriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionáriosTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.FuncionáriosTableAdapter();
            this.tableAdapterManager = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LocadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionáriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("bt_cancelar.Image")));
            this.bt_cancelar.Location = new System.Drawing.Point(438, 0);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(22, 25);
            this.bt_cancelar.TabIndex = 16;
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_entrar
            // 
            this.bt_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_entrar.Location = new System.Drawing.Point(438, 215);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(22, 22);
            this.bt_entrar.TabIndex = 15;
            this.bt_entrar.Text = "Entrar";
            this.bt_entrar.UseVisualStyleBackColor = true;
            this.bt_entrar.Click += new System.EventHandler(this.bt_entrar_Click);
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(257, 215);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(176, 20);
            this.tb_senha.TabIndex = 14;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(12, 215);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(176, 20);
            this.tb_login.TabIndex = 12;
            // 
            // bD_LocadoraDataSet
            // 
            this.bD_LocadoraDataSet.DataSetName = "BD_LocadoraDataSet";
            this.bD_LocadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionáriosBindingSource
            // 
            this.funcionáriosBindingSource.DataMember = "Funcionários";
            this.funcionáriosBindingSource.DataSource = this.bD_LocadoraDataSet;
            // 
            // funcionáriosTableAdapter
            // 
            this.funcionáriosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CaixaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Contas_a_PagarTableAdapter = null;
            this.tableAdapterManager.Contas_a_ReceberTableAdapter = null;
            this.tableAdapterManager.DVDTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.FuncionáriosTableAdapter = this.funcionáriosTableAdapter;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.ItensReservaTableAdapter = null;
            this.tableAdapterManager.LocaçãoTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 257);
            this.Controls.Add(this.bt_entrar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_login";
            this.Load += new System.EventHandler(this.Form_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_LocadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionáriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_entrar;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_login;
        private BD_LocadoraDataSet bD_LocadoraDataSet;
        private System.Windows.Forms.BindingSource funcionáriosBindingSource;
        private BD_LocadoraDataSetTableAdapters.FuncionáriosTableAdapter funcionáriosTableAdapter;
        private BD_LocadoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_cancelar;
    }
}