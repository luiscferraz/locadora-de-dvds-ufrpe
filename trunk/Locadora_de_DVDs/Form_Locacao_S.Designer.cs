namespace Locadora_de_DVDs
{
    partial class Form_Locacao_S
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
            System.Windows.Forms.Label código_LocaçãoLabel;
            System.Windows.Forms.Label código_do_ClienteLabel;
            System.Windows.Forms.Label data_da_LocaçãoLabel;
            System.Windows.Forms.Label data_da_DevoluçãoLabel;
            System.Windows.Forms.Label preço_TotalLabel;
            System.Windows.Forms.Label situaçãoLabel;
            System.Windows.Forms.Label código_DVDLabel;
            System.Windows.Forms.Label títuloLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Locacao_S));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_LocadoraDataSet = new Locadora_de_DVDs.BD_LocadoraDataSet();
            this.código_LocaçãoTextBox = new System.Windows.Forms.TextBox();
            this.locaçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.código_do_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.data_da_LocaçãoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_da_DevoluçãoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dVDBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.títuloComboBox = new System.Windows.Forms.ComboBox();
            this.dVDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dVDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.locaçãoTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.LocaçãoTableAdapter();
            this.tableAdapterManager = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.TableAdapterManager();
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
            this.preço_TotalTextBox = new System.Windows.Forms.TextBox();
            this.situaçãoTextBox = new System.Windows.Forms.TextBox();
            this.clienteTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.ClienteTableAdapter();
            this.dVDTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.DVDTableAdapter();
            this.itemTableAdapter = new Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.ItemTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            código_LocaçãoLabel = new System.Windows.Forms.Label();
            código_do_ClienteLabel = new System.Windows.Forms.Label();
            data_da_LocaçãoLabel = new System.Windows.Forms.Label();
            data_da_DevoluçãoLabel = new System.Windows.Forms.Label();
            preço_TotalLabel = new System.Windows.Forms.Label();
            situaçãoLabel = new System.Windows.Forms.Label();
            código_DVDLabel = new System.Windows.Forms.Label();
            títuloLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LocadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaçãoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaçãoBindingNavigator)).BeginInit();
            this.locaçãoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // código_LocaçãoLabel
            // 
            código_LocaçãoLabel.AutoSize = true;
            código_LocaçãoLabel.Location = new System.Drawing.Point(14, 34);
            código_LocaçãoLabel.Name = "código_LocaçãoLabel";
            código_LocaçãoLabel.Size = new System.Drawing.Size(108, 16);
            código_LocaçãoLabel.TabIndex = 1;
            código_LocaçãoLabel.Text = "Código Locação";
            // 
            // código_do_ClienteLabel
            // 
            código_do_ClienteLabel.AutoSize = true;
            código_do_ClienteLabel.Location = new System.Drawing.Point(11, 150);
            código_do_ClienteLabel.Name = "código_do_ClienteLabel";
            código_do_ClienteLabel.Size = new System.Drawing.Size(115, 16);
            código_do_ClienteLabel.TabIndex = 3;
            código_do_ClienteLabel.Text = "Código do Cliente";
            // 
            // data_da_LocaçãoLabel
            // 
            data_da_LocaçãoLabel.AutoSize = true;
            data_da_LocaçãoLabel.Location = new System.Drawing.Point(14, 72);
            data_da_LocaçãoLabel.Name = "data_da_LocaçãoLabel";
            data_da_LocaçãoLabel.Size = new System.Drawing.Size(112, 16);
            data_da_LocaçãoLabel.TabIndex = 5;
            data_da_LocaçãoLabel.Text = "Data da Locação";
            // 
            // data_da_DevoluçãoLabel
            // 
            data_da_DevoluçãoLabel.AutoSize = true;
            data_da_DevoluçãoLabel.Location = new System.Drawing.Point(292, 72);
            data_da_DevoluçãoLabel.Name = "data_da_DevoluçãoLabel";
            data_da_DevoluçãoLabel.Size = new System.Drawing.Size(125, 16);
            data_da_DevoluçãoLabel.TabIndex = 7;
            data_da_DevoluçãoLabel.Text = "Data da Devolução";
            // 
            // preço_TotalLabel
            // 
            preço_TotalLabel.AutoSize = true;
            preço_TotalLabel.Location = new System.Drawing.Point(15, 586);
            preço_TotalLabel.Name = "preço_TotalLabel";
            preço_TotalLabel.Size = new System.Drawing.Size(78, 16);
            preço_TotalLabel.TabIndex = 9;
            preço_TotalLabel.Text = "Preço Total";
            // 
            // situaçãoLabel
            // 
            situaçãoLabel.AutoSize = true;
            situaçãoLabel.Location = new System.Drawing.Point(277, 586);
            situaçãoLabel.Name = "situaçãoLabel";
            situaçãoLabel.Size = new System.Drawing.Size(61, 16);
            situaçãoLabel.TabIndex = 11;
            situaçãoLabel.Text = "Situação";
            // 
            // código_DVDLabel
            // 
            código_DVDLabel.AutoSize = true;
            código_DVDLabel.Location = new System.Drawing.Point(35, 31);
            código_DVDLabel.Name = "código_DVDLabel";
            código_DVDLabel.Size = new System.Drawing.Size(84, 16);
            código_DVDLabel.TabIndex = 0;
            código_DVDLabel.Text = "Código DVD";
            // 
            // títuloLabel
            // 
            títuloLabel.AutoSize = true;
            títuloLabel.Location = new System.Drawing.Point(292, 31);
            títuloLabel.Name = "títuloLabel";
            títuloLabel.Size = new System.Drawing.Size(92, 16);
            títuloLabel.TabIndex = 2;
            títuloLabel.Text = "Título do DVD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(código_LocaçãoLabel);
            this.groupBox1.Controls.Add(this.código_LocaçãoTextBox);
            this.groupBox1.Controls.Add(código_do_ClienteLabel);
            this.groupBox1.Controls.Add(this.código_do_ClienteTextBox);
            this.groupBox1.Controls.Add(data_da_LocaçãoLabel);
            this.groupBox1.Controls.Add(this.data_da_LocaçãoDateTimePicker);
            this.groupBox1.Controls.Add(data_da_DevoluçãoLabel);
            this.groupBox1.Controls.Add(this.data_da_DevoluçãoDateTimePicker);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(662, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Locação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome do Cliente";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clienteBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(295, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(282, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Código Cliente";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bD_LocadoraDataSet;
            // 
            // bD_LocadoraDataSet
            // 
            this.bD_LocadoraDataSet.DataSetName = "BD_LocadoraDataSet";
            this.bD_LocadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // código_LocaçãoTextBox
            // 
            this.código_LocaçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "Código Locação", true));
            this.código_LocaçãoTextBox.Location = new System.Drawing.Point(148, 31);
            this.código_LocaçãoTextBox.Name = "código_LocaçãoTextBox";
            this.código_LocaçãoTextBox.ReadOnly = true;
            this.código_LocaçãoTextBox.Size = new System.Drawing.Size(77, 22);
            this.código_LocaçãoTextBox.TabIndex = 2;
            // 
            // locaçãoBindingSource
            // 
            this.locaçãoBindingSource.DataMember = "Locação";
            this.locaçãoBindingSource.DataSource = this.bD_LocadoraDataSet;
            // 
            // código_do_ClienteTextBox
            // 
            this.código_do_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "Código do Cliente", true));
            this.código_do_ClienteTextBox.Location = new System.Drawing.Point(17, 184);
            this.código_do_ClienteTextBox.Name = "código_do_ClienteTextBox";
            this.código_do_ClienteTextBox.Size = new System.Drawing.Size(105, 22);
            this.código_do_ClienteTextBox.TabIndex = 4;
            this.código_do_ClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.código_do_ClienteTextBox_KeyPress);
            // 
            // data_da_LocaçãoDateTimePicker
            // 
            this.data_da_LocaçãoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locaçãoBindingSource, "Data da Locação", true));
            this.data_da_LocaçãoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_da_LocaçãoDateTimePicker.Location = new System.Drawing.Point(17, 103);
            this.data_da_LocaçãoDateTimePicker.Name = "data_da_LocaçãoDateTimePicker";
            this.data_da_LocaçãoDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.data_da_LocaçãoDateTimePicker.TabIndex = 6;
            // 
            // data_da_DevoluçãoDateTimePicker
            // 
            this.data_da_DevoluçãoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locaçãoBindingSource, "Data da Devolução", true));
            this.data_da_DevoluçãoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_da_DevoluçãoDateTimePicker.Location = new System.Drawing.Point(295, 103);
            this.data_da_DevoluçãoDateTimePicker.Name = "data_da_DevoluçãoDateTimePicker";
            this.data_da_DevoluçãoDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.data_da_DevoluçãoDateTimePicker.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 265);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.itemDataGridView);
            this.groupBox3.Controls.Add(títuloLabel);
            this.groupBox3.Controls.Add(this.títuloComboBox);
            this.groupBox3.Controls.Add(código_DVDLabel);
            this.groupBox3.Location = new System.Drawing.Point(1, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(662, 326);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Títulos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 28;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AutoGenerateColumns = false;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.itemDataGridView.DataSource = this.itemBindingSource;
            this.itemDataGridView.Location = new System.Drawing.Point(8, 92);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.Size = new System.Drawing.Size(648, 188);
            this.itemDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Código DVD";
            this.dataGridViewTextBoxColumn3.DataSource = this.dVDBindingSource2;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Título";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código DVD";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Código DVD";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dVDBindingSource2
            // 
            this.dVDBindingSource2.DataMember = "DVD";
            this.dVDBindingSource2.DataSource = this.bD_LocadoraDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Preço";
            this.dataGridViewTextBoxColumn4.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Classificação";
            this.dataGridViewTextBoxColumn5.HeaderText = "Classificação";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nº de Cópias Disponíveis";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nº de Cópias Disponíveis";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.bD_LocadoraDataSet;
            // 
            // títuloComboBox
            // 
            this.títuloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dVDBindingSource, "Título", true));
            this.títuloComboBox.DataSource = this.dVDBindingSource1;
            this.títuloComboBox.DisplayMember = "Título";
            this.títuloComboBox.FormattingEnabled = true;
            this.títuloComboBox.Location = new System.Drawing.Point(295, 53);
            this.títuloComboBox.Name = "títuloComboBox";
            this.títuloComboBox.Size = new System.Drawing.Size(282, 24);
            this.títuloComboBox.TabIndex = 3;
            this.títuloComboBox.ValueMember = "Código DVD";
            this.títuloComboBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // dVDBindingSource
            // 
            this.dVDBindingSource.DataMember = "DVD";
            this.dVDBindingSource.DataSource = this.bD_LocadoraDataSet;
            // 
            // dVDBindingSource1
            // 
            this.dVDBindingSource1.DataMember = "DVD";
            this.dVDBindingSource1.DataSource = this.bD_LocadoraDataSet;
            // 
            // locaçãoTableAdapter
            // 
            this.locaçãoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.ItensReservaTableAdapter = null;
            this.tableAdapterManager.LocaçãoTableAdapter = this.locaçãoTableAdapter;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Locadora_de_DVDs.BD_LocadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // locaçãoBindingNavigator
            // 
            this.locaçãoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.locaçãoBindingNavigator.BindingSource = this.locaçãoBindingSource;
            this.locaçãoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.locaçãoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.locaçãoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.locaçãoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.locaçãoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.locaçãoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.locaçãoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.locaçãoBindingNavigator.Name = "locaçãoBindingNavigator";
            this.locaçãoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.locaçãoBindingNavigator.Size = new System.Drawing.Size(663, 25);
            this.locaçãoBindingNavigator.TabIndex = 2;
            this.locaçãoBindingNavigator.Text = "bindingNavigator1";
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
            // locaçãoBindingNavigatorSaveItem
            // 
            this.locaçãoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.locaçãoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("locaçãoBindingNavigatorSaveItem.Image")));
            this.locaçãoBindingNavigatorSaveItem.Name = "locaçãoBindingNavigatorSaveItem";
            this.locaçãoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.locaçãoBindingNavigatorSaveItem.Text = "Save Data";
            this.locaçãoBindingNavigatorSaveItem.Click += new System.EventHandler(this.locaçãoBindingNavigatorSaveItem_Click);
            // 
            // preço_TotalTextBox
            // 
            this.preço_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "Preço Total", true));
            this.preço_TotalTextBox.Location = new System.Drawing.Point(117, 586);
            this.preço_TotalTextBox.Name = "preço_TotalTextBox";
            this.preço_TotalTextBox.Size = new System.Drawing.Size(101, 22);
            this.preço_TotalTextBox.TabIndex = 10;
            // 
            // situaçãoTextBox
            // 
            this.situaçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "Situação", true));
            this.situaçãoTextBox.Location = new System.Drawing.Point(357, 583);
            this.situaçãoTextBox.Name = "situaçãoTextBox";
            this.situaçãoTextBox.Size = new System.Drawing.Size(117, 22);
            this.situaçãoTextBox.TabIndex = 12;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // dVDTableAdapter
            // 
            this.dVDTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 26);
            this.button2.TabIndex = 13;
            this.button2.Text = "Efetuar Locação";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Locacao_S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 634);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.locaçãoBindingNavigator);
            this.Controls.Add(situaçãoLabel);
            this.Controls.Add(this.situaçãoTextBox);
            this.Controls.Add(this.preço_TotalTextBox);
            this.Controls.Add(preço_TotalLabel);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_Locacao_S";
            this.Text = "Locação";
            this.Load += new System.EventHandler(this.Form_Locacao_S_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LocadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaçãoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaçãoBindingNavigator)).EndInit();
            this.locaçãoBindingNavigator.ResumeLayout(false);
            this.locaçãoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.TextBox código_LocaçãoTextBox;
        private System.Windows.Forms.TextBox código_do_ClienteTextBox;
        private System.Windows.Forms.DateTimePicker data_da_LocaçãoDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_da_DevoluçãoDateTimePicker;
        private System.Windows.Forms.TextBox preço_TotalTextBox;
        private System.Windows.Forms.TextBox situaçãoTextBox;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private BD_LocadoraDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dVDBindingSource;
        private BD_LocadoraDataSetTableAdapters.DVDTableAdapter dVDTableAdapter;
        private System.Windows.Forms.ComboBox títuloComboBox;
        private System.Windows.Forms.BindingSource dVDBindingSource1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private BD_LocadoraDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.BindingSource dVDBindingSource2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}