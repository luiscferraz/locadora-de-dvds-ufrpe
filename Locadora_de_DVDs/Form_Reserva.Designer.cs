﻿namespace Locadora_de_DVDs
{
    partial class Form_Reserva
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
            System.Windows.Forms.Label códigoLabel;
            System.Windows.Forms.Label código_ClienteLabel;
            System.Windows.Forms.Label data_da_ReservaLabel;
            System.Windows.Forms.Label código_ClienteLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Reserva));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.código_ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_LocadoraDataSet = new Locadora_de_DVDs.BD_LocadoraDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.códigoTextBox = new System.Windows.Forms.TextBox();
            this.código_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.data_da_ReservaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.itensReservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservaTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.ReservaTableAdapter();
            this.tableAdapterManager = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.ClienteTableAdapter();
            this.itensReservaTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.ItensReservaTableAdapter();
            this.reservaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reservaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.códigoItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dVDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dVDTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.DVDTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.itensReservaDataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            códigoLabel = new System.Windows.Forms.Label();
            código_ClienteLabel = new System.Windows.Forms.Label();
            data_da_ReservaLabel = new System.Windows.Forms.Label();
            código_ClienteLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LocadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensReservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingNavigator)).BeginInit();
            this.reservaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensReservaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // códigoLabel
            // 
            códigoLabel.AutoSize = true;
            códigoLabel.Location = new System.Drawing.Point(17, 31);
            códigoLabel.Name = "códigoLabel";
            códigoLabel.Size = new System.Drawing.Size(52, 16);
            códigoLabel.TabIndex = 0;
            códigoLabel.Text = "Código";
            // 
            // código_ClienteLabel
            // 
            código_ClienteLabel.AutoSize = true;
            código_ClienteLabel.Location = new System.Drawing.Point(17, 164);
            código_ClienteLabel.Name = "código_ClienteLabel";
            código_ClienteLabel.Size = new System.Drawing.Size(96, 16);
            código_ClienteLabel.TabIndex = 2;
            código_ClienteLabel.Text = "Código Cliente";
            // 
            // data_da_ReservaLabel
            // 
            data_da_ReservaLabel.AutoSize = true;
            data_da_ReservaLabel.Location = new System.Drawing.Point(17, 76);
            data_da_ReservaLabel.Name = "data_da_ReservaLabel";
            data_da_ReservaLabel.Size = new System.Drawing.Size(111, 16);
            data_da_ReservaLabel.TabIndex = 4;
            data_da_ReservaLabel.Text = "Data da Reserva";
            // 
            // código_ClienteLabel1
            // 
            código_ClienteLabel1.AutoSize = true;
            código_ClienteLabel1.Location = new System.Drawing.Point(284, 164);
            código_ClienteLabel1.Name = "código_ClienteLabel1";
            código_ClienteLabel1.Size = new System.Drawing.Size(108, 16);
            código_ClienteLabel1.TabIndex = 6;
            código_ClienteLabel1.Text = "Nome do Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(código_ClienteLabel1);
            this.groupBox1.Controls.Add(this.código_ClienteComboBox);
            this.groupBox1.Controls.Add(códigoLabel);
            this.groupBox1.Controls.Add(this.códigoTextBox);
            this.groupBox1.Controls.Add(código_ClienteLabel);
            this.groupBox1.Controls.Add(this.código_ClienteTextBox);
            this.groupBox1.Controls.Add(data_da_ReservaLabel);
            this.groupBox1.Controls.Add(this.data_da_ReservaDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(16, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(642, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Reserva";
            // 
            // código_ClienteComboBox
            // 
            this.código_ClienteComboBox.DataSource = this.clienteBindingSource;
            this.código_ClienteComboBox.DisplayMember = "Nome";
            this.código_ClienteComboBox.FormattingEnabled = true;
            this.código_ClienteComboBox.Location = new System.Drawing.Point(287, 193);
            this.código_ClienteComboBox.Name = "código_ClienteComboBox";
            this.código_ClienteComboBox.Size = new System.Drawing.Size(292, 24);
            this.código_ClienteComboBox.TabIndex = 7;
            this.código_ClienteComboBox.ValueMember = "Código Cliente";
            this.código_ClienteComboBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox3_SelectionChangeCommitted);
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "Reserva";
            this.reservaBindingSource.DataSource = this.bD_LocadoraDataSet;
            // 
            // bD_LocadoraDataSet
            // 
            this.bD_LocadoraDataSet.DataSetName = "BD_LocadoraDataSet";
            this.bD_LocadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bD_LocadoraDataSet;
            // 
            // códigoTextBox
            // 
            this.códigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Código", true));
            this.códigoTextBox.Location = new System.Drawing.Point(99, 28);
            this.códigoTextBox.Name = "códigoTextBox";
            this.códigoTextBox.ReadOnly = true;
            this.códigoTextBox.Size = new System.Drawing.Size(92, 22);
            this.códigoTextBox.TabIndex = 1;
            // 
            // código_ClienteTextBox
            // 
            this.código_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Código Cliente", true));
            this.código_ClienteTextBox.Location = new System.Drawing.Point(20, 195);
            this.código_ClienteTextBox.Name = "código_ClienteTextBox";
            this.código_ClienteTextBox.Size = new System.Drawing.Size(93, 22);
            this.código_ClienteTextBox.TabIndex = 3;
            this.código_ClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.código_ClienteTextBox_KeyPress);
            // 
            // data_da_ReservaDateTimePicker
            // 
            this.data_da_ReservaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Data da Reserva", true));
            this.data_da_ReservaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_da_ReservaDateTimePicker.Location = new System.Drawing.Point(20, 113);
            this.data_da_ReservaDateTimePicker.Name = "data_da_ReservaDateTimePicker";
            this.data_da_ReservaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.data_da_ReservaDateTimePicker.TabIndex = 5;
            // 
            // itensReservaBindingSource
            // 
            this.itensReservaBindingSource.DataMember = "ItensReserva";
            this.itensReservaBindingSource.DataSource = this.bD_LocadoraDataSet;
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CaixaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.Contas_a_PagarTableAdapter = null;
            this.tableAdapterManager.Contas_a_ReceberTableAdapter = null;
            this.tableAdapterManager.DVDTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.ItensReservaTableAdapter = this.itensReservaTableAdapter;
            this.tableAdapterManager.LocaçãoTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = this.reservaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // itensReservaTableAdapter
            // 
            this.itensReservaTableAdapter.ClearBeforeFill = true;
            // 
            // reservaBindingNavigator
            // 
            this.reservaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reservaBindingNavigator.BindingSource = this.reservaBindingSource;
            this.reservaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reservaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reservaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.reservaBindingNavigatorSaveItem});
            this.reservaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reservaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reservaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reservaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reservaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reservaBindingNavigator.Name = "reservaBindingNavigator";
            this.reservaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reservaBindingNavigator.Size = new System.Drawing.Size(662, 25);
            this.reservaBindingNavigator.TabIndex = 2;
            this.reservaBindingNavigator.Text = "bindingNavigator1";
            this.reservaBindingNavigator.Visible = false;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // reservaBindingNavigatorSaveItem
            // 
            this.reservaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reservaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reservaBindingNavigatorSaveItem.Image")));
            this.reservaBindingNavigatorSaveItem.Name = "reservaBindingNavigatorSaveItem";
            this.reservaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.reservaBindingNavigatorSaveItem.Text = "Save Data";
            this.reservaBindingNavigatorSaveItem.Click += new System.EventHandler(this.reservaBindingNavigatorSaveItem_Click);
            // 
            // códigoItemDataGridViewTextBoxColumn
            // 
            this.códigoItemDataGridViewTextBoxColumn.DataPropertyName = "Código Item";
            this.códigoItemDataGridViewTextBoxColumn.HeaderText = "Código Item";
            this.códigoItemDataGridViewTextBoxColumn.Name = "códigoItemDataGridViewTextBoxColumn";
            // 
            // DVD
            // 
            this.DVD.HeaderText = "Column1";
            this.DVD.Name = "DVD";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 643);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Nova Reserva";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(543, 643);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Efetuar Reserva";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dVDBindingSource
            // 
            this.dVDBindingSource.DataMember = "DVD";
            this.dVDBindingSource.DataSource = this.bD_LocadoraDataSet;
            // 
            // dVDTableAdapter
            // 
            this.dVDTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.itensReservaDataGridView);
            this.groupBox4.Controls.Add(this.comboBox4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Location = new System.Drawing.Point(16, 337);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(642, 300);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Títulos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // itensReservaDataGridView
            // 
            this.itensReservaDataGridView.AutoGenerateColumns = false;
            this.itensReservaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itensReservaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.itensReservaDataGridView.DataSource = this.itensReservaBindingSource;
            this.itensReservaDataGridView.Location = new System.Drawing.Point(16, 96);
            this.itensReservaDataGridView.Name = "itensReservaDataGridView";
            this.itensReservaDataGridView.Size = new System.Drawing.Size(590, 152);
            this.itensReservaDataGridView.TabIndex = 4;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.dVDBindingSource;
            this.comboBox4.DisplayMember = "Título";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(238, 57);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(368, 24);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.ValueMember = "Código DVD";
            this.comboBox4.SelectionChangeCommitted += new System.EventHandler(this.comboBox4_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Título do DVD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Código do DVD";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Código DVD";
            this.dataGridViewTextBoxColumn12.DataSource = this.dVDBindingSource;
            this.dataGridViewTextBoxColumn12.DisplayMember = "Título";
            this.dataGridViewTextBoxColumn12.HeaderText = "DVD";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn12.ValueMember = "Código DVD";
            this.dataGridViewTextBoxColumn12.Width = 447;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Nº de Cópias Disponíveis";
            this.dataGridViewTextBoxColumn13.HeaderText = "Nº de Cópias Disponíveis";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // Form_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 692);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reservaBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Reserva";
            this.Load += new System.EventHandler(this.Form_Reserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LocadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensReservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingNavigator)).EndInit();
            this.reservaBindingNavigator.ResumeLayout(false);
            this.reservaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensReservaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BD_LocadoraDataSet bD_LocadoraDataSet;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private BD_LocadoraDataSetTableAdapters.ReservaTableAdapter reservaTableAdapter;
        private BD_LocadoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reservaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton reservaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox códigoTextBox;
        private System.Windows.Forms.TextBox código_ClienteTextBox;
        private System.Windows.Forms.DateTimePicker data_da_ReservaDateTimePicker;
        private System.Windows.Forms.ComboBox código_ClienteComboBox;
        private BD_LocadoraDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private BD_LocadoraDataSetTableAdapters.ItensReservaTableAdapter itensReservaTableAdapter;
        private System.Windows.Forms.BindingSource itensReservaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn DVD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource dVDBindingSource;
        private BD_LocadoraDataSetTableAdapters.DVDTableAdapter dVDTableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView itensReservaDataGridView;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}