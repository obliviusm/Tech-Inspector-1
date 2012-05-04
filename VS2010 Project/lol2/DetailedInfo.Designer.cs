namespace lol2
{
    partial class DetailedInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.equipment_idTextBox = new System.Windows.Forms.TextBox();
            this.equipmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_inspectorDataSet = new lol2.tech_inspectorDataSet();
            this.type_idTextBox = new System.Windows.Forms.TextBox();
            this.location_idTextBox = new System.Windows.Forms.TextBox();
            this.state_idTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.stateSelectLabel = new System.Windows.Forms.Label();
            this.deviceNumberLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.deviceTypeLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.dateGroupBox = new System.Windows.Forms.GroupBox();
            this.histotyButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.movedPlaceLabel = new System.Windows.Forms.Label();
            this.movedCheckBox = new System.Windows.Forms.CheckBox();
            this.repairingCheckBox = new System.Windows.Forms.CheckBox();
            this.warrantyEndDateLabel = new System.Windows.Forms.Label();
            this.placementDateLabel = new System.Windows.Forms.Label();
            this.purchaseDateLabel = new System.Windows.Forms.Label();
            this.purchase_dateTextBox = new System.Windows.Forms.TextBox();
            this.placement_dateTextBox = new System.Windows.Forms.TextBox();
            this.warranty_end_dateTextBox = new System.Windows.Forms.TextBox();
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.configurationDataGridView = new System.Windows.Forms.DataGridView();
            this.equipmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributevalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributeslistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentsTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.equipmentsTableAdapter();
            this.tableAdapterManager = new lol2.tech_inspectorDataSetTableAdapters.TableAdapterManager();
            this.typesTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.typesTableAdapter();
            this.locationsTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.locationsTableAdapter();
            this.statesTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.statesTableAdapter();
            this.attributes_listTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.attributes_listTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).BeginInit();
            this.dateGroupBox.SuspendLayout();
            this.configurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributeslistBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.equipment_idTextBox);
            this.groupBox1.Controls.Add(this.type_idTextBox);
            this.groupBox1.Controls.Add(this.location_idTextBox);
            this.groupBox1.Controls.Add(this.state_idTextBox);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.stateSelectLabel);
            this.groupBox1.Controls.Add(this.deviceNumberLabel);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.deviceTypeLabel);
            this.groupBox1.Controls.Add(this.locationLabel);
            this.groupBox1.Location = new System.Drawing.Point(1, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 179);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальна інформація";
            // 
            // equipment_idTextBox
            // 
            this.equipment_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentsBindingSource, "equipment_id", true));
            this.equipment_idTextBox.Location = new System.Drawing.Point(130, 19);
            this.equipment_idTextBox.Name = "equipment_idTextBox";
            this.equipment_idTextBox.ReadOnly = true;
            this.equipment_idTextBox.Size = new System.Drawing.Size(150, 20);
            this.equipment_idTextBox.TabIndex = 24;
            // 
            // equipmentsBindingSource
            // 
            this.equipmentsBindingSource.AllowNew = false;
            this.equipmentsBindingSource.DataMember = "equipments";
            this.equipmentsBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // tech_inspectorDataSet
            // 
            this.tech_inspectorDataSet.DataSetName = "tech_inspectorDataSet";
            this.tech_inspectorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // type_idTextBox
            // 
            this.type_idTextBox.Location = new System.Drawing.Point(130, 45);
            this.type_idTextBox.Name = "type_idTextBox";
            this.type_idTextBox.ReadOnly = true;
            this.type_idTextBox.Size = new System.Drawing.Size(150, 20);
            this.type_idTextBox.TabIndex = 26;
            // 
            // location_idTextBox
            // 
            this.location_idTextBox.Location = new System.Drawing.Point(130, 71);
            this.location_idTextBox.Name = "location_idTextBox";
            this.location_idTextBox.ReadOnly = true;
            this.location_idTextBox.Size = new System.Drawing.Size(150, 20);
            this.location_idTextBox.TabIndex = 28;
            // 
            // state_idTextBox
            // 
            this.state_idTextBox.Location = new System.Drawing.Point(130, 97);
            this.state_idTextBox.Name = "state_idTextBox";
            this.state_idTextBox.ReadOnly = true;
            this.state_idTextBox.Size = new System.Drawing.Size(150, 20);
            this.state_idTextBox.TabIndex = 30;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentsBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(130, 123);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(150, 20);
            this.priceTextBox.TabIndex = 32;
            // 
            // stateSelectLabel
            // 
            this.stateSelectLabel.AutoSize = true;
            this.stateSelectLabel.Location = new System.Drawing.Point(14, 102);
            this.stateSelectLabel.Name = "stateSelectLabel";
            this.stateSelectLabel.Size = new System.Drawing.Size(88, 13);
            this.stateSelectLabel.TabIndex = 23;
            this.stateSelectLabel.Text = "Технічний стан :";
            // 
            // deviceNumberLabel
            // 
            this.deviceNumberLabel.AutoSize = true;
            this.deviceNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceNumberLabel.Location = new System.Drawing.Point(14, 22);
            this.deviceNumberLabel.Name = "deviceNumberLabel";
            this.deviceNumberLabel.Size = new System.Drawing.Size(110, 13);
            this.deviceNumberLabel.TabIndex = 2;
            this.deviceNumberLabel.Text = "Інвентарний номер :";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(14, 129);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(35, 13);
            this.priceLabel.TabIndex = 20;
            this.priceLabel.Text = "Ціна :";
            // 
            // deviceTypeLabel
            // 
            this.deviceTypeLabel.AutoSize = true;
            this.deviceTypeLabel.Location = new System.Drawing.Point(14, 48);
            this.deviceTypeLabel.Name = "deviceTypeLabel";
            this.deviceTypeLabel.Size = new System.Drawing.Size(95, 13);
            this.deviceTypeLabel.TabIndex = 4;
            this.deviceTypeLabel.Text = "Тип обладнання :";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(14, 75);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(86, 13);
            this.locationLabel.TabIndex = 18;
            this.locationLabel.Text = "Розташування :";
            // 
            // dateGroupBox
            // 
            this.dateGroupBox.Controls.Add(this.histotyButton);
            this.dateGroupBox.Controls.Add(this.textBox1);
            this.dateGroupBox.Controls.Add(this.movedPlaceLabel);
            this.dateGroupBox.Controls.Add(this.movedCheckBox);
            this.dateGroupBox.Controls.Add(this.repairingCheckBox);
            this.dateGroupBox.Controls.Add(this.warrantyEndDateLabel);
            this.dateGroupBox.Controls.Add(this.placementDateLabel);
            this.dateGroupBox.Controls.Add(this.purchaseDateLabel);
            this.dateGroupBox.Controls.Add(this.purchase_dateTextBox);
            this.dateGroupBox.Controls.Add(this.placement_dateTextBox);
            this.dateGroupBox.Controls.Add(this.warranty_end_dateTextBox);
            this.dateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateGroupBox.Location = new System.Drawing.Point(303, 40);
            this.dateGroupBox.Name = "dateGroupBox";
            this.dateGroupBox.Size = new System.Drawing.Size(376, 179);
            this.dateGroupBox.TabIndex = 25;
            this.dateGroupBox.TabStop = false;
            this.dateGroupBox.Text = "Додаткова інформація";
            // 
            // histotyButton
            // 
            this.histotyButton.Location = new System.Drawing.Point(207, 150);
            this.histotyButton.Name = "histotyButton";
            this.histotyButton.Size = new System.Drawing.Size(150, 23);
            this.histotyButton.TabIndex = 43;
            this.histotyButton.Text = "Історія";
            this.histotyButton.UseVisualStyleBackColor = true;
            this.histotyButton.Click += new System.EventHandler(this.histotyButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentsBindingSource, "temp_location", true));
            this.textBox1.Location = new System.Drawing.Point(207, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 42;
            // 
            // movedPlaceLabel
            // 
            this.movedPlaceLabel.AutoSize = true;
            this.movedPlaceLabel.Location = new System.Drawing.Point(16, 126);
            this.movedPlaceLabel.Name = "movedPlaceLabel";
            this.movedPlaceLabel.Size = new System.Drawing.Size(182, 13);
            this.movedPlaceLabel.TabIndex = 41;
            this.movedPlaceLabel.Text = "Місце тимчасового розташування:";
            // 
            // movedCheckBox
            // 
            this.movedCheckBox.AutoSize = true;
            this.movedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.equipmentsBindingSource, "moved", true));
            this.movedCheckBox.Enabled = false;
            this.movedCheckBox.Location = new System.Drawing.Point(112, 98);
            this.movedCheckBox.Name = "movedCheckBox";
            this.movedCheckBox.Size = new System.Drawing.Size(151, 17);
            this.movedCheckBox.TabIndex = 40;
            this.movedCheckBox.Text = "Тимчасово перенесено?";
            this.movedCheckBox.UseVisualStyleBackColor = true;
            // 
            // repairingCheckBox
            // 
            this.repairingCheckBox.AutoSize = true;
            this.repairingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.equipmentsBindingSource, "repairing", true));
            this.repairingCheckBox.Enabled = false;
            this.repairingCheckBox.Location = new System.Drawing.Point(18, 98);
            this.repairingCheckBox.Name = "repairingCheckBox";
            this.repairingCheckBox.Size = new System.Drawing.Size(88, 17);
            this.repairingCheckBox.TabIndex = 39;
            this.repairingCheckBox.Text = "На ремонті?";
            this.repairingCheckBox.UseVisualStyleBackColor = true;
            // 
            // warrantyEndDateLabel
            // 
            this.warrantyEndDateLabel.AutoSize = true;
            this.warrantyEndDateLabel.Location = new System.Drawing.Point(16, 75);
            this.warrantyEndDateLabel.Name = "warrantyEndDateLabel";
            this.warrantyEndDateLabel.Size = new System.Drawing.Size(172, 13);
            this.warrantyEndDateLabel.TabIndex = 2;
            this.warrantyEndDateLabel.Text = "Кінець гарантії обслуговування :";
            // 
            // placementDateLabel
            // 
            this.placementDateLabel.AutoSize = true;
            this.placementDateLabel.Location = new System.Drawing.Point(16, 48);
            this.placementDateLabel.Name = "placementDateLabel";
            this.placementDateLabel.Size = new System.Drawing.Size(103, 13);
            this.placementDateLabel.TabIndex = 1;
            this.placementDateLabel.Text = "Дата розміщення :";
            // 
            // purchaseDateLabel
            // 
            this.purchaseDateLabel.AutoSize = true;
            this.purchaseDateLabel.Location = new System.Drawing.Point(16, 22);
            this.purchaseDateLabel.Name = "purchaseDateLabel";
            this.purchaseDateLabel.Size = new System.Drawing.Size(83, 13);
            this.purchaseDateLabel.TabIndex = 0;
            this.purchaseDateLabel.Text = "Дата покупки :";
            // 
            // purchase_dateTextBox
            // 
            this.purchase_dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentsBindingSource, "purchase_date", true));
            this.purchase_dateTextBox.Location = new System.Drawing.Point(207, 19);
            this.purchase_dateTextBox.Name = "purchase_dateTextBox";
            this.purchase_dateTextBox.ReadOnly = true;
            this.purchase_dateTextBox.Size = new System.Drawing.Size(150, 20);
            this.purchase_dateTextBox.TabIndex = 34;
            // 
            // placement_dateTextBox
            // 
            this.placement_dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentsBindingSource, "placement_date", true));
            this.placement_dateTextBox.Location = new System.Drawing.Point(207, 45);
            this.placement_dateTextBox.Name = "placement_dateTextBox";
            this.placement_dateTextBox.ReadOnly = true;
            this.placement_dateTextBox.Size = new System.Drawing.Size(150, 20);
            this.placement_dateTextBox.TabIndex = 36;
            // 
            // warranty_end_dateTextBox
            // 
            this.warranty_end_dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentsBindingSource, "warranty_end_date", true));
            this.warranty_end_dateTextBox.Location = new System.Drawing.Point(207, 72);
            this.warranty_end_dateTextBox.Name = "warranty_end_dateTextBox";
            this.warranty_end_dateTextBox.ReadOnly = true;
            this.warranty_end_dateTextBox.Size = new System.Drawing.Size(150, 20);
            this.warranty_end_dateTextBox.TabIndex = 38;
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configurationGroupBox.Controls.Add(this.configurationDataGridView);
            this.configurationGroupBox.Location = new System.Drawing.Point(1, 225);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(679, 302);
            this.configurationGroupBox.TabIndex = 24;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Конфігурація обладнання";
            // 
            // configurationDataGridView
            // 
            this.configurationDataGridView.AllowUserToAddRows = false;
            this.configurationDataGridView.AllowUserToDeleteRows = false;
            this.configurationDataGridView.AllowUserToOrderColumns = true;
            this.configurationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configurationDataGridView.AutoGenerateColumns = false;
            this.configurationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.configurationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.configurationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentidDataGridViewTextBoxColumn,
            this.attributeidDataGridViewTextBoxColumn,
            this.attributenameDataGridViewTextBoxColumn,
            this.attributevalueDataGridViewTextBoxColumn});
            this.configurationDataGridView.DataSource = this.attributeslistBindingSource;
            this.configurationDataGridView.Location = new System.Drawing.Point(7, 19);
            this.configurationDataGridView.Name = "configurationDataGridView";
            this.configurationDataGridView.ReadOnly = true;
            this.configurationDataGridView.Size = new System.Drawing.Size(666, 277);
            this.configurationDataGridView.TabIndex = 0;
            // 
            // equipmentidDataGridViewTextBoxColumn
            // 
            this.equipmentidDataGridViewTextBoxColumn.DataPropertyName = "equipment_id";
            this.equipmentidDataGridViewTextBoxColumn.HeaderText = "equipment_id";
            this.equipmentidDataGridViewTextBoxColumn.Name = "equipmentidDataGridViewTextBoxColumn";
            this.equipmentidDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipmentidDataGridViewTextBoxColumn.Visible = false;
            // 
            // attributeidDataGridViewTextBoxColumn
            // 
            this.attributeidDataGridViewTextBoxColumn.DataPropertyName = "attribute_id";
            this.attributeidDataGridViewTextBoxColumn.HeaderText = "attribute_id";
            this.attributeidDataGridViewTextBoxColumn.Name = "attributeidDataGridViewTextBoxColumn";
            this.attributeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.attributeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // attributenameDataGridViewTextBoxColumn
            // 
            this.attributenameDataGridViewTextBoxColumn.DataPropertyName = "attribute_name";
            this.attributenameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.attributenameDataGridViewTextBoxColumn.Name = "attributenameDataGridViewTextBoxColumn";
            this.attributenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attributevalueDataGridViewTextBoxColumn
            // 
            this.attributevalueDataGridViewTextBoxColumn.DataPropertyName = "attribute_value";
            this.attributevalueDataGridViewTextBoxColumn.HeaderText = "Значення";
            this.attributevalueDataGridViewTextBoxColumn.Name = "attributevalueDataGridViewTextBoxColumn";
            this.attributevalueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attributeslistBindingSource
            // 
            this.attributeslistBindingSource.DataMember = "attributes_list";
            this.attributeslistBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // equipmentsTableAdapter
            // 
            this.equipmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.action_typesTableAdapter = null;
            this.tableAdapterManager.attributes_listTableAdapter = null;
            this.tableAdapterManager.attributesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.equipment_shortinfoTableAdapter = null;
            this.tableAdapterManager.equipments_has_attributesTableAdapter = null;
            this.tableAdapterManager.equipmentsTableAdapter = this.equipmentsTableAdapter;
            this.tableAdapterManager.historyTableAdapter = null;
            this.tableAdapterManager.locationsTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.statesTableAdapter = null;
            this.tableAdapterManager.typesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lol2.tech_inspectorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_listTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // locationsTableAdapter
            // 
            this.locationsTableAdapter.ClearBeforeFill = true;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // attributes_listTableAdapter
            // 
            this.attributes_listTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.closeToolStripMenuItem.Text = "Закрити вікно";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editToolStripMenuItem.Text = "Правка";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.copyToolStripMenuItem.Text = "Копіювати";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.helpToolStripMenuItem.Text = "Допомога";
            // 
            // instructionToolStripMenuItem
            // 
            this.instructionToolStripMenuItem.Name = "instructionToolStripMenuItem";
            this.instructionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.instructionToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.instructionToolStripMenuItem.Text = "Інструкція користувача";
            this.instructionToolStripMenuItem.Click += new System.EventHandler(this.instructionToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.aboutToolStripMenuItem.Text = "Про програму";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // DetailedInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 543);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateGroupBox);
            this.Controls.Add(this.configurationGroupBox);
            this.MinimumSize = new System.Drawing.Size(703, 582);
            this.Name = "DetailedInfo";
            this.Text = "Детальна інформація";
            this.Load += new System.EventHandler(this.DetailedInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).EndInit();
            this.dateGroupBox.ResumeLayout(false);
            this.dateGroupBox.PerformLayout();
            this.configurationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configurationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributeslistBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label stateSelectLabel;
        private System.Windows.Forms.Label deviceNumberLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label deviceTypeLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.GroupBox dateGroupBox;
        private System.Windows.Forms.Label warrantyEndDateLabel;
        private System.Windows.Forms.Label placementDateLabel;
        private System.Windows.Forms.Label purchaseDateLabel;
        private System.Windows.Forms.GroupBox configurationGroupBox;
        private System.Windows.Forms.DataGridView configurationDataGridView;
        private tech_inspectorDataSet tech_inspectorDataSet;
        private System.Windows.Forms.BindingSource equipmentsBindingSource;
        private tech_inspectorDataSetTableAdapters.equipmentsTableAdapter equipmentsTableAdapter;
        private tech_inspectorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private tech_inspectorDataSetTableAdapters.typesTableAdapter typesTableAdapter;
        private System.Windows.Forms.TextBox equipment_idTextBox;
        private System.Windows.Forms.TextBox type_idTextBox;
        private System.Windows.Forms.TextBox location_idTextBox;
        private System.Windows.Forms.TextBox state_idTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox purchase_dateTextBox;
        private System.Windows.Forms.TextBox placement_dateTextBox;
        private System.Windows.Forms.TextBox warranty_end_dateTextBox;
        private tech_inspectorDataSetTableAdapters.locationsTableAdapter locationsTableAdapter;
        private tech_inspectorDataSetTableAdapters.statesTableAdapter statesTableAdapter;
        private System.Windows.Forms.BindingSource attributeslistBindingSource;
        private tech_inspectorDataSetTableAdapters.attributes_listTableAdapter attributes_listTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributevalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label movedPlaceLabel;
        private System.Windows.Forms.CheckBox movedCheckBox;
        private System.Windows.Forms.CheckBox repairingCheckBox;
        private System.Windows.Forms.Button histotyButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    }
}