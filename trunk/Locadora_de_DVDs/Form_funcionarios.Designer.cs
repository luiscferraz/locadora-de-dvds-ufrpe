namespace Locadora_de_DVDs
{
    partial class Form_funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_funcionarios));
            System.Windows.Forms.Label código_FuncionárioLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label admissãoLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label endereçoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label e_MailLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label acessoLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bD_LocadoraDataSet = new Locadora_de_DVDs.BD_LocadoraDataSet();
            this.funcionáriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionáriosTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.FuncionáriosTableAdapter();
            this.tableAdapterManager = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.TableAdapterManager();
            this.funcionáriosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.funcionáriosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.código_FuncionárioTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.admissãoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rGMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.endereçoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.e_MailTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.acessoCheckBox = new System.Windows.Forms.CheckBox();
            código_FuncionárioLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            admissãoLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            endereçoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            e_MailLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            acessoLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LocadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionáriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionáriosBindingNavigator)).BeginInit();
            this.funcionáriosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(código_FuncionárioLabel);
            this.tabPage1.Controls.Add(this.código_FuncionárioTextBox);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.nomeTextBox);
            this.tabPage1.Controls.Add(admissãoLabel);
            this.tabPage1.Controls.Add(this.admissãoDateTimePicker);
            this.tabPage1.Controls.Add(rGLabel);
            this.tabPage1.Controls.Add(this.rGMaskedTextBox);
            this.tabPage1.Controls.Add(cPFLabel);
            this.tabPage1.Controls.Add(this.cPFMaskedTextBox);
            this.tabPage1.Controls.Add(endereçoLabel);
            this.tabPage1.Controls.Add(this.endereçoTextBox);
            this.tabPage1.Controls.Add(bairroLabel);
            this.tabPage1.Controls.Add(this.bairroTextBox);
            this.tabPage1.Controls.Add(cidadeLabel);
            this.tabPage1.Controls.Add(this.cidadeTextBox);
            this.tabPage1.Controls.Add(telefoneLabel);
            this.tabPage1.Controls.Add(this.telefoneMaskedTextBox);
            this.tabPage1.Controls.Add(e_MailLabel);
            this.tabPage1.Controls.Add(this.e_MailTextBox);
            this.tabPage1.Controls.Add(loginLabel);
            this.tabPage1.Controls.Add(this.loginTextBox);
            this.tabPage1.Controls.Add(senhaLabel);
            this.tabPage1.Controls.Add(this.senhaTextBox);
            this.tabPage1.Controls.Add(acessoLabel);
            this.tabPage1.Controls.Add(this.acessoCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(624, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(624, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Excluir / Alterar";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(624, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consultar";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.tableAdapterManager.LocaçãoTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // funcionáriosBindingNavigator
            // 
            this.funcionáriosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.funcionáriosBindingNavigator.BindingSource = this.funcionáriosBindingSource;
            this.funcionáriosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.funcionáriosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.funcionáriosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.funcionáriosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.funcionáriosBindingNavigatorSaveItem});
            this.funcionáriosBindingNavigator.Location = new System.Drawing.Point(0, 447);
            this.funcionáriosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.funcionáriosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.funcionáriosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.funcionáriosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.funcionáriosBindingNavigator.Name = "funcionáriosBindingNavigator";
            this.funcionáriosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.funcionáriosBindingNavigator.Size = new System.Drawing.Size(632, 25);
            this.funcionáriosBindingNavigator.TabIndex = 1;
            this.funcionáriosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // funcionáriosBindingNavigatorSaveItem
            // 
            this.funcionáriosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.funcionáriosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionáriosBindingNavigatorSaveItem.Image")));
            this.funcionáriosBindingNavigatorSaveItem.Name = "funcionáriosBindingNavigatorSaveItem";
            this.funcionáriosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.funcionáriosBindingNavigatorSaveItem.Text = "Save Data";
            this.funcionáriosBindingNavigatorSaveItem.Click += new System.EventHandler(this.funcionáriosBindingNavigatorSaveItem_Click);
            // 
            // código_FuncionárioLabel
            // 
            código_FuncionárioLabel.AutoSize = true;
            código_FuncionárioLabel.Location = new System.Drawing.Point(61, 37);
            código_FuncionárioLabel.Name = "código_FuncionárioLabel";
            código_FuncionárioLabel.Size = new System.Drawing.Size(52, 16);
            código_FuncionárioLabel.TabIndex = 0;
            código_FuncionárioLabel.Text = "Código";
            // 
            // código_FuncionárioTextBox
            // 
            this.código_FuncionárioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "Código Funcionário", true));
            this.código_FuncionárioTextBox.Location = new System.Drawing.Point(195, 34);
            this.código_FuncionárioTextBox.Name = "código_FuncionárioTextBox";
            this.código_FuncionárioTextBox.Size = new System.Drawing.Size(75, 22);
            this.código_FuncionárioTextBox.TabIndex = 1;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(61, 65);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(56, 16);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome  *";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(195, 62);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(408, 22);
            this.nomeTextBox.TabIndex = 3;
            // 
            // admissãoLabel
            // 
            admissãoLabel.AutoSize = true;
            admissãoLabel.Location = new System.Drawing.Point(61, 94);
            admissãoLabel.Name = "admissãoLabel";
            admissãoLabel.Size = new System.Drawing.Size(80, 16);
            admissãoLabel.TabIndex = 4;
            admissãoLabel.Text = "Admissão  *";
            // 
            // admissãoDateTimePicker
            // 
            this.admissãoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.funcionáriosBindingSource, "Admissão", true));
            this.admissãoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.admissãoDateTimePicker.Location = new System.Drawing.Point(195, 90);
            this.admissãoDateTimePicker.Name = "admissãoDateTimePicker";
            this.admissãoDateTimePicker.Size = new System.Drawing.Size(109, 22);
            this.admissãoDateTimePicker.TabIndex = 5;
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(61, 121);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(39, 16);
            rGLabel.TabIndex = 6;
            rGLabel.Text = "RG  *";
            // 
            // rGMaskedTextBox
            // 
            this.rGMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "RG", true));
            this.rGMaskedTextBox.Location = new System.Drawing.Point(195, 118);
            this.rGMaskedTextBox.Mask = "0.000.000";
            this.rGMaskedTextBox.Name = "rGMaskedTextBox";
            this.rGMaskedTextBox.Size = new System.Drawing.Size(75, 22);
            this.rGMaskedTextBox.TabIndex = 7;
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(345, 121);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(45, 16);
            cPFLabel.TabIndex = 8;
            cPFLabel.Text = "CPF  *";
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(420, 118);
            this.cPFMaskedTextBox.Mask = "000.000.000-00";
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(109, 22);
            this.cPFMaskedTextBox.TabIndex = 9;
            // 
            // endereçoLabel
            // 
            endereçoLabel.AutoSize = true;
            endereçoLabel.Location = new System.Drawing.Point(61, 149);
            endereçoLabel.Name = "endereçoLabel";
            endereçoLabel.Size = new System.Drawing.Size(78, 16);
            endereçoLabel.TabIndex = 10;
            endereçoLabel.Text = "Endereço  *";
            // 
            // endereçoTextBox
            // 
            this.endereçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "Endereço", true));
            this.endereçoTextBox.Location = new System.Drawing.Point(195, 146);
            this.endereçoTextBox.Name = "endereçoTextBox";
            this.endereçoTextBox.Size = new System.Drawing.Size(408, 22);
            this.endereçoTextBox.TabIndex = 11;
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(61, 177);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(55, 16);
            bairroLabel.TabIndex = 12;
            bairroLabel.Text = "Bairro  *";
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "Bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(195, 174);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(408, 22);
            this.bairroTextBox.TabIndex = 13;
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(61, 205);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(63, 16);
            cidadeLabel.TabIndex = 14;
            cidadeLabel.Text = "Cidade  *";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(195, 202);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(408, 22);
            this.cidadeTextBox.TabIndex = 15;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(61, 233);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(73, 16);
            telefoneLabel.TabIndex = 16;
            telefoneLabel.Text = "Telefone  *";
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(195, 230);
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(408, 22);
            this.telefoneMaskedTextBox.TabIndex = 17;
            // 
            // e_MailLabel
            // 
            e_MailLabel.AutoSize = true;
            e_MailLabel.Location = new System.Drawing.Point(61, 289);
            e_MailLabel.Name = "e_MailLabel";
            e_MailLabel.Size = new System.Drawing.Size(49, 16);
            e_MailLabel.TabIndex = 18;
            e_MailLabel.Text = "E-Mail:";
            // 
            // e_MailTextBox
            // 
            this.e_MailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "E-Mail", true));
            this.e_MailTextBox.Location = new System.Drawing.Point(195, 286);
            this.e_MailTextBox.Name = "e_MailTextBox";
            this.e_MailTextBox.Size = new System.Drawing.Size(200, 22);
            this.e_MailTextBox.TabIndex = 19;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(61, 317);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(44, 16);
            loginLabel.TabIndex = 20;
            loginLabel.Text = "Login:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(195, 314);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(200, 22);
            this.loginTextBox.TabIndex = 21;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(61, 345);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(50, 16);
            senhaLabel.TabIndex = 22;
            senhaLabel.Text = "Senha:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(195, 342);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(200, 22);
            this.senhaTextBox.TabIndex = 23;
            // 
            // acessoLabel
            // 
            acessoLabel.AutoSize = true;
            acessoLabel.Location = new System.Drawing.Point(61, 375);
            acessoLabel.Name = "acessoLabel";
            acessoLabel.Size = new System.Drawing.Size(57, 16);
            acessoLabel.TabIndex = 24;
            acessoLabel.Text = "Acesso:";
            // 
            // acessoCheckBox
            // 
            this.acessoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.funcionáriosBindingSource, "Acesso", true));
            this.acessoCheckBox.Location = new System.Drawing.Point(195, 370);
            this.acessoCheckBox.Name = "acessoCheckBox";
            this.acessoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.acessoCheckBox.TabIndex = 25;
            this.acessoCheckBox.Text = "checkBox1";
            this.acessoCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form_funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 472);
            this.Controls.Add(this.funcionáriosBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form_funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.Form_funcionarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LocadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionáriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionáriosBindingNavigator)).EndInit();
            this.funcionáriosBindingNavigator.ResumeLayout(false);
            this.funcionáriosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private BD_LocadoraDataSet bD_LocadoraDataSet;
        private System.Windows.Forms.BindingSource funcionáriosBindingSource;
        private BD_LocadoraDataSetTableAdapters.FuncionáriosTableAdapter funcionáriosTableAdapter;
        private BD_LocadoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator funcionáriosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton funcionáriosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox código_FuncionárioTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker admissãoDateTimePicker;
        private System.Windows.Forms.MaskedTextBox rGMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.TextBox endereçoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.TextBox e_MailTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.CheckBox acessoCheckBox;
    }
}