﻿namespace Locadora_de_DVDs
{
    partial class Form_locacao
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
            System.Windows.Forms.Label código_do_ClienteLabel;
            System.Windows.Forms.Label data_da_LocaçãoLabel;
            System.Windows.Forms.Label data_da_DevoluçãoLabel;
            System.Windows.Forms.Label código_LocaçãoLabel;
            System.Windows.Forms.Label preço_TotalLabel;
            System.Windows.Forms.Label situaçãoLabel;
            System.Windows.Forms.Label códigoLabel;
            System.Windows.Forms.Label código_ClienteLabel;
            System.Windows.Forms.Label data_da_ReservaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_locacao));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dVDBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.bD_LocadoraDataSet1 = new Locadora_de_DVDs.BD_LocadoraDataSet();
            this.dVDBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dVDBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locaçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_LocadoraDataSet = new Locadora_de_DVDs.BD_LocadoraDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.situaçãoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.código_do_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.código_LocaçãoTextBox = new System.Windows.Forms.TextBox();
            this.data_da_LocaçãoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_da_DevoluçãoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.preço_TotalTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.itemDataGridView1 = new System.Windows.Forms.DataGridView();
            this.Devolver = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.códigoItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoLocaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoDVDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dVDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nºDeCópiasDisponíveisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDaDevoluçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.itensReservaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dVDBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.bD_LocadoraDataSet2 = new Locadora_de_DVDs.BD_LocadoraDataSet();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensReservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.códigoTextBox = new System.Windows.Forms.TextBox();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.código_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.data_da_ReservaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dVDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.locaçãoTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.LocaçãoTableAdapter();
            this.tableAdapterManager = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.ClienteTableAdapter();
            this.itemTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.ItemTableAdapter();
            this.locaçãoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.locaçãoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dVDTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.DVDTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classificação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVDBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bDLocadoraDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservaTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.ReservaTableAdapter();
            this.itensReservaTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.ItensReservaTableAdapter();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            código_do_ClienteLabel = new System.Windows.Forms.Label();
            data_da_LocaçãoLabel = new System.Windows.Forms.Label();
            data_da_DevoluçãoLabel = new System.Windows.Forms.Label();
            código_LocaçãoLabel = new System.Windows.Forms.Label();
            preço_TotalLabel = new System.Windows.Forms.Label();
            situaçãoLabel = new System.Windows.Forms.Label();
            códigoLabel = new System.Windows.Forms.Label();
            código_ClienteLabel = new System.Windows.Forms.Label();
            data_da_ReservaLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LocadoraDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaçãoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LocadoraDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensReservaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LocadoraDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensReservaBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaçãoBindingNavigator)).BeginInit();
            this.locaçãoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLocadoraDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // código_do_ClienteLabel
            // 
            código_do_ClienteLabel.AutoSize = true;
            código_do_ClienteLabel.Location = new System.Drawing.Point(26, 148);
            código_do_ClienteLabel.Name = "código_do_ClienteLabel";
            código_do_ClienteLabel.Size = new System.Drawing.Size(115, 16);
            código_do_ClienteLabel.TabIndex = 2;
            código_do_ClienteLabel.Text = "Código do Cliente";
            // 
            // data_da_LocaçãoLabel
            // 
            data_da_LocaçãoLabel.AutoSize = true;
            data_da_LocaçãoLabel.Location = new System.Drawing.Point(26, 75);
            data_da_LocaçãoLabel.Name = "data_da_LocaçãoLabel";
            data_da_LocaçãoLabel.Size = new System.Drawing.Size(112, 16);
            data_da_LocaçãoLabel.TabIndex = 4;
            data_da_LocaçãoLabel.Text = "Data da Locação";
            // 
            // data_da_DevoluçãoLabel
            // 
            data_da_DevoluçãoLabel.AutoSize = true;
            data_da_DevoluçãoLabel.Location = new System.Drawing.Point(237, 75);
            data_da_DevoluçãoLabel.Name = "data_da_DevoluçãoLabel";
            data_da_DevoluçãoLabel.Size = new System.Drawing.Size(125, 16);
            data_da_DevoluçãoLabel.TabIndex = 6;
            data_da_DevoluçãoLabel.Text = "Data da Devolução";
            // 
            // código_LocaçãoLabel
            // 
            código_LocaçãoLabel.AutoSize = true;
            código_LocaçãoLabel.Location = new System.Drawing.Point(26, 38);
            código_LocaçãoLabel.Name = "código_LocaçãoLabel";
            código_LocaçãoLabel.Size = new System.Drawing.Size(108, 16);
            código_LocaçãoLabel.TabIndex = 22;
            código_LocaçãoLabel.Text = "Código Locação";
            // 
            // preço_TotalLabel
            // 
            preço_TotalLabel.AutoSize = true;
            preço_TotalLabel.Location = new System.Drawing.Point(19, 552);
            preço_TotalLabel.Name = "preço_TotalLabel";
            preço_TotalLabel.Size = new System.Drawing.Size(81, 16);
            preço_TotalLabel.TabIndex = 24;
            preço_TotalLabel.Text = "Preço Total:";
            // 
            // situaçãoLabel
            // 
            situaçãoLabel.AutoSize = true;
            situaçãoLabel.Location = new System.Drawing.Point(267, 552);
            situaçãoLabel.Name = "situaçãoLabel";
            situaçãoLabel.Size = new System.Drawing.Size(64, 16);
            situaçãoLabel.TabIndex = 26;
            situaçãoLabel.Text = "Situação:";
            situaçãoLabel.Visible = false;
            // 
            // códigoLabel
            // 
            códigoLabel.AutoSize = true;
            códigoLabel.Location = new System.Drawing.Point(24, 41);
            códigoLabel.Name = "códigoLabel";
            códigoLabel.Size = new System.Drawing.Size(52, 16);
            códigoLabel.TabIndex = 0;
            códigoLabel.Text = "Código";
            // 
            // código_ClienteLabel
            // 
            código_ClienteLabel.AutoSize = true;
            código_ClienteLabel.Location = new System.Drawing.Point(24, 147);
            código_ClienteLabel.Name = "código_ClienteLabel";
            código_ClienteLabel.Size = new System.Drawing.Size(115, 16);
            código_ClienteLabel.TabIndex = 2;
            código_ClienteLabel.Text = "Código do Cliente";
            // 
            // data_da_ReservaLabel
            // 
            data_da_ReservaLabel.AutoSize = true;
            data_da_ReservaLabel.Location = new System.Drawing.Point(24, 80);
            data_da_ReservaLabel.Name = "data_da_ReservaLabel";
            data_da_ReservaLabel.Size = new System.Drawing.Size(111, 16);
            data_da_ReservaLabel.TabIndex = 4;
            data_da_ReservaLabel.Text = "Data da Reserva";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 628);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.situaçãoTextBox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.preço_TotalTextBox);
            this.tabPage1.Controls.Add(preço_TotalLabel);
            this.tabPage1.Controls.Add(situaçãoLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Locação";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.itemDataGridView);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(14, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 296);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Títulos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Título do DVD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Código do DVD";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dVDBindingSource5, "Código DVD", true));
            this.comboBox2.DataSource = this.dVDBindingSource4;
            this.comboBox2.DisplayMember = "Título";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(240, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(368, 24);
            this.comboBox2.TabIndex = 29;
            this.comboBox2.ValueMember = "Código DVD";
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // dVDBindingSource5
            // 
            this.dVDBindingSource5.DataMember = "DVD";
            this.dVDBindingSource5.DataSource = this.bD_LocadoraDataSet1;
            // 
            // bD_LocadoraDataSet1
            // 
            this.bD_LocadoraDataSet1.DataSetName = "BD_LocadoraDataSet";
            this.bD_LocadoraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dVDBindingSource4
            // 
            this.dVDBindingSource4.DataMember = "DVD";
            this.dVDBindingSource4.DataSource = this.bD_LocadoraDataSet1;
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AutoGenerateColumns = false;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.itemDataGridView.DataSource = this.itemBindingSource;
            this.itemDataGridView.Location = new System.Drawing.Point(17, 88);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.Size = new System.Drawing.Size(603, 152);
            this.itemDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Código DVD";
            this.dataGridViewTextBoxColumn8.DataSource = this.dVDBindingSource3;
            this.dataGridViewTextBoxColumn8.DisplayMember = "Título";
            this.dataGridViewTextBoxColumn8.HeaderText = "DVD";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "Código DVD";
            this.dataGridViewTextBoxColumn8.Width = 300;
            // 
            // dVDBindingSource3
            // 
            this.dVDBindingSource3.DataMember = "DVD";
            this.dVDBindingSource3.DataSource = this.bD_LocadoraDataSet1;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Preço";
            this.dataGridViewTextBoxColumn9.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Classificação";
            this.dataGridViewTextBoxColumn10.HeaderText = "Classificação";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Nº de Cópias Disponíveis";
            this.dataGridViewTextBoxColumn11.HeaderText = "Nº de Cópias Disponíveis";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "LocaçãoItem";
            this.itemBindingSource.DataSource = this.locaçãoBindingSource;
            // 
            // locaçãoBindingSource
            // 
            this.locaçãoBindingSource.DataMember = "Locação";
            this.locaçãoBindingSource.DataSource = this.bD_LocadoraDataSet;
            // 
            // bD_LocadoraDataSet
            // 
            this.bD_LocadoraDataSet.DataSetName = "BD_LocadoraDataSet";
            this.bD_LocadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(532, 549);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 37);
            this.button3.TabIndex = 28;
            this.button3.Text = "Efetuar Locação";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // situaçãoTextBox
            // 
            this.situaçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "Situação", true));
            this.situaçãoTextBox.Location = new System.Drawing.Point(337, 549);
            this.situaçãoTextBox.Name = "situaçãoTextBox";
            this.situaçãoTextBox.Size = new System.Drawing.Size(139, 22);
            this.situaçãoTextBox.TabIndex = 27;
            this.situaçãoTextBox.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(código_do_ClienteLabel);
            this.groupBox1.Controls.Add(this.código_do_ClienteTextBox);
            this.groupBox1.Controls.Add(código_LocaçãoLabel);
            this.groupBox1.Controls.Add(data_da_LocaçãoLabel);
            this.groupBox1.Controls.Add(this.código_LocaçãoTextBox);
            this.groupBox1.Controls.Add(this.data_da_LocaçãoDateTimePicker);
            this.groupBox1.Controls.Add(data_da_DevoluçãoLabel);
            this.groupBox1.Controls.Add(this.data_da_DevoluçãoDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 212);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Locação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome do Cliente";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.locaçãoBindingSource, "Código do Cliente", true));
            this.comboBox1.DataSource = this.clienteBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(368, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "Código Cliente";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bD_LocadoraDataSet;
            // 
            // código_do_ClienteTextBox
            // 
            this.código_do_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "Código do Cliente", true));
            this.código_do_ClienteTextBox.Location = new System.Drawing.Point(29, 169);
            this.código_do_ClienteTextBox.Name = "código_do_ClienteTextBox";
            this.código_do_ClienteTextBox.Size = new System.Drawing.Size(75, 22);
            this.código_do_ClienteTextBox.TabIndex = 3;
            this.código_do_ClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.código_do_ClienteTextBox_KeyPress);
            // 
            // código_LocaçãoTextBox
            // 
            this.código_LocaçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "Código Locação", true));
            this.código_LocaçãoTextBox.Location = new System.Drawing.Point(146, 35);
            this.código_LocaçãoTextBox.Name = "código_LocaçãoTextBox";
            this.código_LocaçãoTextBox.ReadOnly = true;
            this.código_LocaçãoTextBox.Size = new System.Drawing.Size(75, 22);
            this.código_LocaçãoTextBox.TabIndex = 23;
            // 
            // data_da_LocaçãoDateTimePicker
            // 
            this.data_da_LocaçãoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locaçãoBindingSource, "Data da Locação", true));
            this.data_da_LocaçãoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_da_LocaçãoDateTimePicker.Location = new System.Drawing.Point(29, 103);
            this.data_da_LocaçãoDateTimePicker.Name = "data_da_LocaçãoDateTimePicker";
            this.data_da_LocaçãoDateTimePicker.Size = new System.Drawing.Size(126, 22);
            this.data_da_LocaçãoDateTimePicker.TabIndex = 5;
            // 
            // data_da_DevoluçãoDateTimePicker
            // 
            this.data_da_DevoluçãoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locaçãoBindingSource, "Data da Devolução", true));
            this.data_da_DevoluçãoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_da_DevoluçãoDateTimePicker.Location = new System.Drawing.Point(240, 103);
            this.data_da_DevoluçãoDateTimePicker.Name = "data_da_DevoluçãoDateTimePicker";
            this.data_da_DevoluçãoDateTimePicker.Size = new System.Drawing.Size(126, 22);
            this.data_da_DevoluçãoDateTimePicker.TabIndex = 7;
            // 
            // preço_TotalTextBox
            // 
            this.preço_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "Preço Total", true));
            this.preço_TotalTextBox.Location = new System.Drawing.Point(106, 549);
            this.preço_TotalTextBox.Name = "preço_TotalTextBox";
            this.preço_TotalTextBox.Size = new System.Drawing.Size(83, 22);
            this.preço_TotalTextBox.TabIndex = 25;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.itemDataGridView1);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Devolução";
            // 
            // itemDataGridView1
            // 
            this.itemDataGridView1.AutoGenerateColumns = false;
            this.itemDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Devolver,
            this.códigoItemDataGridViewTextBoxColumn,
            this.códigoLocaçãoDataGridViewTextBoxColumn,
            this.códigoDVDDataGridViewTextBoxColumn,
            this.preçoDataGridViewTextBoxColumn,
            this.classificaçãoDataGridViewTextBoxColumn,
            this.nºDeCópiasDisponíveisDataGridViewTextBoxColumn,
            this.dataDaDevoluçãoDataGridViewTextBoxColumn});
            this.itemDataGridView1.DataSource = this.itemBindingSource;
            this.itemDataGridView1.Location = new System.Drawing.Point(75, 204);
            this.itemDataGridView1.Name = "itemDataGridView1";
            this.itemDataGridView1.Size = new System.Drawing.Size(524, 220);
            this.itemDataGridView1.TabIndex = 2;
            // 
            // Devolver
            // 
            this.Devolver.HeaderText = "Devolver";
            this.Devolver.Name = "Devolver";
            // 
            // códigoItemDataGridViewTextBoxColumn
            // 
            this.códigoItemDataGridViewTextBoxColumn.DataPropertyName = "Código Item";
            this.códigoItemDataGridViewTextBoxColumn.HeaderText = "Código Item";
            this.códigoItemDataGridViewTextBoxColumn.Name = "códigoItemDataGridViewTextBoxColumn";
            this.códigoItemDataGridViewTextBoxColumn.Visible = false;
            // 
            // códigoLocaçãoDataGridViewTextBoxColumn
            // 
            this.códigoLocaçãoDataGridViewTextBoxColumn.DataPropertyName = "Código Locação";
            this.códigoLocaçãoDataGridViewTextBoxColumn.HeaderText = "Código Locação";
            this.códigoLocaçãoDataGridViewTextBoxColumn.Name = "códigoLocaçãoDataGridViewTextBoxColumn";
            this.códigoLocaçãoDataGridViewTextBoxColumn.Visible = false;
            // 
            // códigoDVDDataGridViewTextBoxColumn
            // 
            this.códigoDVDDataGridViewTextBoxColumn.DataPropertyName = "Código DVD";
            this.códigoDVDDataGridViewTextBoxColumn.DataSource = this.dVDBindingSource;
            this.códigoDVDDataGridViewTextBoxColumn.DisplayMember = "Título";
            this.códigoDVDDataGridViewTextBoxColumn.HeaderText = "DVD";
            this.códigoDVDDataGridViewTextBoxColumn.Name = "códigoDVDDataGridViewTextBoxColumn";
            this.códigoDVDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.códigoDVDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.códigoDVDDataGridViewTextBoxColumn.ValueMember = "Código DVD";
            this.códigoDVDDataGridViewTextBoxColumn.Width = 380;
            // 
            // dVDBindingSource
            // 
            this.dVDBindingSource.DataMember = "DVD";
            this.dVDBindingSource.DataSource = this.bD_LocadoraDataSet;
            // 
            // preçoDataGridViewTextBoxColumn
            // 
            this.preçoDataGridViewTextBoxColumn.DataPropertyName = "Preço";
            this.preçoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.preçoDataGridViewTextBoxColumn.Name = "preçoDataGridViewTextBoxColumn";
            this.preçoDataGridViewTextBoxColumn.Visible = false;
            // 
            // classificaçãoDataGridViewTextBoxColumn
            // 
            this.classificaçãoDataGridViewTextBoxColumn.DataPropertyName = "Classificação";
            this.classificaçãoDataGridViewTextBoxColumn.HeaderText = "Classificação";
            this.classificaçãoDataGridViewTextBoxColumn.Name = "classificaçãoDataGridViewTextBoxColumn";
            this.classificaçãoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nºDeCópiasDisponíveisDataGridViewTextBoxColumn
            // 
            this.nºDeCópiasDisponíveisDataGridViewTextBoxColumn.DataPropertyName = "Nº de Cópias Disponíveis";
            this.nºDeCópiasDisponíveisDataGridViewTextBoxColumn.HeaderText = "Nº de Cópias Disponíveis";
            this.nºDeCópiasDisponíveisDataGridViewTextBoxColumn.Name = "nºDeCópiasDisponíveisDataGridViewTextBoxColumn";
            this.nºDeCópiasDisponíveisDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataDaDevoluçãoDataGridViewTextBoxColumn
            // 
            this.dataDaDevoluçãoDataGridViewTextBoxColumn.DataPropertyName = "Data da Devolução";
            this.dataDaDevoluçãoDataGridViewTextBoxColumn.HeaderText = "Data da Devolução";
            this.dataDaDevoluçãoDataGridViewTextBoxColumn.Name = "dataDaDevoluçãoDataGridViewTextBoxColumn";
            this.dataDaDevoluçãoDataGridViewTextBoxColumn.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(531, 537);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 37);
            this.button6.TabIndex = 2;
            this.button6.Text = "Devolver";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(20, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(626, 173);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informações da Devolução";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(578, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(202, 55);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(368, 22);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(21, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Data da Devolução";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código do Cliente";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(664, 599);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reserva";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(348, 546);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 37);
            this.button5.TabIndex = 3;
            this.button5.Text = "Nova Reserva";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(528, 546);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 37);
            this.button4.TabIndex = 2;
            this.button4.Text = "Efetuar Reserva";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.itensReservaDataGridView);
            this.groupBox4.Controls.Add(this.comboBox4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Location = new System.Drawing.Point(20, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(626, 300);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Títulos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Código DVD";
            this.dataGridViewTextBoxColumn12.DataSource = this.dVDBindingSource6;
            this.dataGridViewTextBoxColumn12.DisplayMember = "Título";
            this.dataGridViewTextBoxColumn12.HeaderText = "DVD";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn12.ValueMember = "Código DVD";
            this.dataGridViewTextBoxColumn12.Width = 447;
            // 
            // dVDBindingSource6
            // 
            this.dVDBindingSource6.DataMember = "DVD";
            this.dVDBindingSource6.DataSource = this.bD_LocadoraDataSet2;
            // 
            // bD_LocadoraDataSet2
            // 
            this.bD_LocadoraDataSet2.DataSetName = "BD_LocadoraDataSet";
            this.bD_LocadoraDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Nº de Cópias Disponíveis";
            this.dataGridViewTextBoxColumn13.HeaderText = "Nº de Cópias Disponíveis";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // itensReservaBindingSource
            // 
            this.itensReservaBindingSource.DataMember = "ItensReserva";
            this.itensReservaBindingSource.DataSource = this.bD_LocadoraDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.dVDBindingSource4;
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
            this.label5.Location = new System.Drawing.Point(24, 28);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(códigoLabel);
            this.groupBox3.Controls.Add(this.códigoTextBox);
            this.groupBox3.Controls.Add(código_ClienteLabel);
            this.groupBox3.Controls.Add(this.código_ClienteTextBox);
            this.groupBox3.Controls.Add(data_da_ReservaLabel);
            this.groupBox3.Controls.Add(this.data_da_ReservaDateTimePicker);
            this.groupBox3.Location = new System.Drawing.Point(20, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(626, 219);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações da Reserva";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.clienteBindingSource;
            this.comboBox3.DisplayMember = "Nome";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(238, 175);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(368, 24);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.ValueMember = "Código Cliente";
            this.comboBox3.SelectionChangeCommitted += new System.EventHandler(this.comboBox3_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome do Cliente";
            // 
            // códigoTextBox
            // 
            this.códigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Código", true));
            this.códigoTextBox.Location = new System.Drawing.Point(92, 38);
            this.códigoTextBox.Name = "códigoTextBox";
            this.códigoTextBox.ReadOnly = true;
            this.códigoTextBox.Size = new System.Drawing.Size(75, 22);
            this.códigoTextBox.TabIndex = 1;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "Reserva";
            this.reservaBindingSource.DataSource = this.bD_LocadoraDataSet;
            // 
            // código_ClienteTextBox
            // 
            this.código_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Código Cliente", true));
            this.código_ClienteTextBox.Location = new System.Drawing.Point(27, 175);
            this.código_ClienteTextBox.Name = "código_ClienteTextBox";
            this.código_ClienteTextBox.Size = new System.Drawing.Size(75, 22);
            this.código_ClienteTextBox.TabIndex = 3;
            this.código_ClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.código_ClienteTextBox_KeyPress);
            // 
            // data_da_ReservaDateTimePicker
            // 
            this.data_da_ReservaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Data da Reserva", true));
            this.data_da_ReservaDateTimePicker.Location = new System.Drawing.Point(27, 108);
            this.data_da_ReservaDateTimePicker.Name = "data_da_ReservaDateTimePicker";
            this.data_da_ReservaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.data_da_ReservaDateTimePicker.TabIndex = 5;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.bD_LocadoraDataSet1;
            // 
            // dVDBindingSource1
            // 
            this.dVDBindingSource1.DataMember = "DVD";
            this.dVDBindingSource1.DataSource = this.bD_LocadoraDataSet1;
            // 
            // locaçãoTableAdapter
            // 
            this.locaçãoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ItemTableAdapter = this.itemTableAdapter;
            this.tableAdapterManager.ItensReservaTableAdapter = null;
            this.tableAdapterManager.LocaçãoTableAdapter = this.locaçãoTableAdapter;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // locaçãoBindingNavigator
            // 
            this.locaçãoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.locaçãoBindingNavigator.BindingSource = this.locaçãoBindingSource;
            this.locaçãoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.locaçãoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.locaçãoBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.locaçãoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.locaçãoBindingNavigatorSaveItem});
            this.locaçãoBindingNavigator.Location = new System.Drawing.Point(0, 603);
            this.locaçãoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.locaçãoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.locaçãoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.locaçãoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.locaçãoBindingNavigator.Name = "locaçãoBindingNavigator";
            this.locaçãoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.locaçãoBindingNavigator.Size = new System.Drawing.Size(672, 25);
            this.locaçãoBindingNavigator.TabIndex = 1;
            this.locaçãoBindingNavigator.Text = "bindingNavigator1";
            this.locaçãoBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // locaçãoBindingNavigatorSaveItem
            // 
            this.locaçãoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.locaçãoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("locaçãoBindingNavigatorSaveItem.Image")));
            this.locaçãoBindingNavigatorSaveItem.Name = "locaçãoBindingNavigatorSaveItem";
            this.locaçãoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.locaçãoBindingNavigatorSaveItem.Text = "Save Data";
            this.locaçãoBindingNavigatorSaveItem.Click += new System.EventHandler(this.locaçãoBindingNavigatorSaveItem_Click);
            // 
            // dVDTableAdapter
            // 
            this.dVDTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Código Item";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Código Locação";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código Locação";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Código DVD";
            this.dataGridViewTextBoxColumn3.DataSource = this.dVDBindingSource1;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Título";
            this.dataGridViewTextBoxColumn3.HeaderText = "DVD";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Código DVD";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Preço";
            this.dataGridViewTextBoxColumn5.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Classificação
            // 
            this.Classificação.DataPropertyName = "Classificação";
            this.Classificação.HeaderText = "Classificação";
            this.Classificação.Name = "Classificação";
            // 
            // dVDBindingSource2
            // 
            this.dVDBindingSource2.DataMember = "DVD";
            this.dVDBindingSource2.DataSource = this.bD_LocadoraDataSet1;
            // 
            // bDLocadoraDataSet1BindingSource
            // 
            this.bDLocadoraDataSet1BindingSource.DataSource = this.bD_LocadoraDataSet1;
            this.bDLocadoraDataSet1BindingSource.Position = 0;
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // itensReservaTableAdapter
            // 
            this.itensReservaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Código Item";
            this.dataGridViewTextBoxColumn6.HeaderText = "Código Item";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Código Locação";
            this.dataGridViewTextBoxColumn7.HeaderText = "Código Locação";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Código DVD";
            this.dataGridViewTextBoxColumn14.DataSource = this.dVDBindingSource5;
            this.dataGridViewTextBoxColumn14.DisplayMember = "Título";
            this.dataGridViewTextBoxColumn14.HeaderText = "DVD";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn14.ValueMember = "Código DVD";
            this.dataGridViewTextBoxColumn14.Width = 400;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Preço";
            this.dataGridViewTextBoxColumn15.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Classificação";
            this.dataGridViewTextBoxColumn16.HeaderText = "Classificação";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Nº de Cópias Disponíveis";
            this.dataGridViewTextBoxColumn17.HeaderText = "Nº de Cópias Disponíveis";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Código Item";
            this.dataGridViewTextBoxColumn18.HeaderText = "Código Item";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Código Locação";
            this.dataGridViewTextBoxColumn19.HeaderText = "Código Locação";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Código DVD";
            this.dataGridViewTextBoxColumn20.DataSource = this.dVDBindingSource5;
            this.dataGridViewTextBoxColumn20.DisplayMember = "Título";
            this.dataGridViewTextBoxColumn20.HeaderText = "DVD";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn20.ValueMember = "Código DVD";
            this.dataGridViewTextBoxColumn20.Width = 400;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Preço";
            this.dataGridViewTextBoxColumn21.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Classificação";
            this.dataGridViewTextBoxColumn22.HeaderText = "Classificação";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Nº de Cópias Disponíveis";
            this.dataGridViewTextBoxColumn23.HeaderText = "Nº de Cópias Disponíveis";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // Form_locacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 628);
            this.Controls.Add(this.locaçãoBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_locacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locação, Devolução e Reserva";
            this.Load += new System.EventHandler(this.Form_locacao_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LocadoraDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaçãoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LocadoraDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensReservaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LocadoraDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensReservaBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaçãoBindingNavigator)).EndInit();
            this.locaçãoBindingNavigator.ResumeLayout(false);
            this.locaçãoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLocadoraDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private BD_LocadoraDataSet bD_LocadoraDataSet;
        private System.Windows.Forms.BindingSource locaçãoBindingSource;
        private BD_LocadoraDataSetTableAdapters.LocaçãoTableAdapter locaçãoTableAdapter;
        private BD_LocadoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator locaçãoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton locaçãoBindingNavigatorSaveItem;
        private BD_LocadoraDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.TextBox código_LocaçãoTextBox;
        private System.Windows.Forms.TextBox preço_TotalTextBox;
        private System.Windows.Forms.TextBox situaçãoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox código_do_ClienteTextBox;
        private System.Windows.Forms.DateTimePicker data_da_LocaçãoDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_da_DevoluçãoDateTimePicker;
        private BD_LocadoraDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource dVDBindingSource;
        private BD_LocadoraDataSetTableAdapters.DVDTableAdapter dVDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private BD_LocadoraDataSet bD_LocadoraDataSet1;
        private System.Windows.Forms.BindingSource dVDBindingSource1;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.BindingSource dVDBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classificação;
        private System.Windows.Forms.BindingSource dVDBindingSource2;
        private System.Windows.Forms.BindingSource bDLocadoraDataSet1BindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource dVDBindingSource5;
        private System.Windows.Forms.BindingSource dVDBindingSource4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private BD_LocadoraDataSetTableAdapters.ReservaTableAdapter reservaTableAdapter;
        private System.Windows.Forms.TextBox códigoTextBox;
        private System.Windows.Forms.TextBox código_ClienteTextBox;
        private System.Windows.Forms.DateTimePicker data_da_ReservaDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource itensReservaBindingSource;
        private BD_LocadoraDataSetTableAdapters.ItensReservaTableAdapter itensReservaTableAdapter;
        private System.Windows.Forms.DataGridView itensReservaDataGridView;
        private System.Windows.Forms.Button button2;
        private BD_LocadoraDataSet bD_LocadoraDataSet2;
        private System.Windows.Forms.BindingSource dVDBindingSource6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridView itemDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Devolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoLocaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn códigoDVDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nºDeCópiasDisponíveisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDaDevoluçãoDataGridViewTextBoxColumn;
    }
}