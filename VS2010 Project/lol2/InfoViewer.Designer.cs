namespace lol2
{
    partial class InfoViewer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosDataGridView = new System.Windows.Forms.DataGridView();
            this.equipmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.repairing = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.typenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentshortinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_inspectorDataSet = new lol2.tech_inspectorDataSet();
            this.addDeviceButton = new System.Windows.Forms.Button();
            this.deleteDeviceButton = new System.Windows.Forms.Button();
            this.editInfoButton = new System.Windows.Forms.Button();
            this.detailedInfoButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deviceNumberLabel = new System.Windows.Forms.Label();
            this.deviceNumberTextBox = new System.Windows.Forms.TextBox();
            this.deviceTypeLabel = new System.Windows.Forms.Label();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationLabel = new System.Windows.Forms.Label();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.newCheckBox = new System.Windows.Forms.CheckBox();
            this.movedCheckBox = new System.Windows.Forms.CheckBox();
            this.repairingCheckBox = new System.Windows.Forms.CheckBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.typesTableAdapter();
            this.equipment_shortinfoTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.equipment_shortinfoTableAdapter();
            this.locationsTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.locationsTableAdapter();
            this.statesTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.statesTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.equipmentCountStatusLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentshortinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            this.filterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editTemplateToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.addToolStripMenuItem.Text = "Додати пристрій до бази";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editTemplateToolStripMenuItem
            // 
            this.editTemplateToolStripMenuItem.Name = "editTemplateToolStripMenuItem";
            this.editTemplateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editTemplateToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.editTemplateToolStripMenuItem.Text = "Редагувати типи обладнання";
            this.editTemplateToolStripMenuItem.Click += new System.EventHandler(this.editTemplatesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(248, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.closeToolStripMenuItem.Text = "Закрити вікно";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
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
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cutToolStripMenuItem.Text = "Вирізати";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.pasteToolStripMenuItem.Text = "Вставити";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
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
            // infosDataGridView
            // 
            this.infosDataGridView.AllowUserToAddRows = false;
            this.infosDataGridView.AllowUserToDeleteRows = false;
            this.infosDataGridView.AllowUserToOrderColumns = true;
            this.infosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infosDataGridView.AutoGenerateColumns = false;
            this.infosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentidDataGridViewTextBoxColumn,
            this.moved,
            this.repairing,
            this.typenameDataGridViewTextBoxColumn,
            this.locationnameDataGridViewTextBoxColumn,
            this.statenameDataGridViewTextBoxColumn,
            this.purchase_date,
            this.locationidDataGridViewTextBoxColumn,
            this.stateidDataGridViewTextBoxColumn,
            this.typeidDataGridViewTextBoxColumn});
            this.infosDataGridView.DataSource = this.equipmentshortinfoBindingSource;
            this.infosDataGridView.Location = new System.Drawing.Point(12, 117);
            this.infosDataGridView.Name = "infosDataGridView";
            this.infosDataGridView.ReadOnly = true;
            this.infosDataGridView.Size = new System.Drawing.Size(589, 319);
            this.infosDataGridView.TabIndex = 2;
            // 
            // equipmentidDataGridViewTextBoxColumn
            // 
            this.equipmentidDataGridViewTextBoxColumn.DataPropertyName = "equipment_id";
            this.equipmentidDataGridViewTextBoxColumn.HeaderText = "Інвентарний номер";
            this.equipmentidDataGridViewTextBoxColumn.Name = "equipmentidDataGridViewTextBoxColumn";
            this.equipmentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moved
            // 
            this.moved.DataPropertyName = "moved";
            this.moved.HeaderText = "moved";
            this.moved.Name = "moved";
            this.moved.ReadOnly = true;
            this.moved.Visible = false;
            // 
            // repairing
            // 
            this.repairing.DataPropertyName = "repairing";
            this.repairing.HeaderText = "repairing";
            this.repairing.Name = "repairing";
            this.repairing.ReadOnly = true;
            this.repairing.Visible = false;
            // 
            // typenameDataGridViewTextBoxColumn
            // 
            this.typenameDataGridViewTextBoxColumn.DataPropertyName = "type_name";
            this.typenameDataGridViewTextBoxColumn.HeaderText = "Тип обладнання";
            this.typenameDataGridViewTextBoxColumn.Name = "typenameDataGridViewTextBoxColumn";
            this.typenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationnameDataGridViewTextBoxColumn
            // 
            this.locationnameDataGridViewTextBoxColumn.DataPropertyName = "location_name";
            this.locationnameDataGridViewTextBoxColumn.HeaderText = "Розташування";
            this.locationnameDataGridViewTextBoxColumn.Name = "locationnameDataGridViewTextBoxColumn";
            this.locationnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statenameDataGridViewTextBoxColumn
            // 
            this.statenameDataGridViewTextBoxColumn.DataPropertyName = "state_name";
            this.statenameDataGridViewTextBoxColumn.HeaderText = "Технічний стан";
            this.statenameDataGridViewTextBoxColumn.Name = "statenameDataGridViewTextBoxColumn";
            this.statenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchase_date
            // 
            this.purchase_date.DataPropertyName = "purchase_date";
            this.purchase_date.HeaderText = "Дата покупки";
            this.purchase_date.Name = "purchase_date";
            this.purchase_date.ReadOnly = true;
            // 
            // locationidDataGridViewTextBoxColumn
            // 
            this.locationidDataGridViewTextBoxColumn.DataPropertyName = "location_id";
            this.locationidDataGridViewTextBoxColumn.HeaderText = "location_id";
            this.locationidDataGridViewTextBoxColumn.Name = "locationidDataGridViewTextBoxColumn";
            this.locationidDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationidDataGridViewTextBoxColumn.Visible = false;
            // 
            // stateidDataGridViewTextBoxColumn
            // 
            this.stateidDataGridViewTextBoxColumn.DataPropertyName = "state_id";
            this.stateidDataGridViewTextBoxColumn.HeaderText = "state_id";
            this.stateidDataGridViewTextBoxColumn.Name = "stateidDataGridViewTextBoxColumn";
            this.stateidDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateidDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeidDataGridViewTextBoxColumn
            // 
            this.typeidDataGridViewTextBoxColumn.DataPropertyName = "type_id";
            this.typeidDataGridViewTextBoxColumn.HeaderText = "type_id";
            this.typeidDataGridViewTextBoxColumn.Name = "typeidDataGridViewTextBoxColumn";
            this.typeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipmentshortinfoBindingSource
            // 
            this.equipmentshortinfoBindingSource.DataMember = "equipment_shortinfo";
            this.equipmentshortinfoBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // tech_inspectorDataSet
            // 
            this.tech_inspectorDataSet.DataSetName = "tech_inspectorDataSet";
            this.tech_inspectorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addDeviceButton.Location = new System.Drawing.Point(310, 442);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(143, 33);
            this.addDeviceButton.TabIndex = 3;
            this.addDeviceButton.Text = "Додати обладнання";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            this.addDeviceButton.Click += new System.EventHandler(this.addDeviceButton_Click);
            // 
            // deleteDeviceButton
            // 
            this.deleteDeviceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteDeviceButton.Location = new System.Drawing.Point(459, 442);
            this.deleteDeviceButton.Name = "deleteDeviceButton";
            this.deleteDeviceButton.Size = new System.Drawing.Size(143, 33);
            this.deleteDeviceButton.TabIndex = 4;
            this.deleteDeviceButton.Text = "Видалити обладнання";
            this.deleteDeviceButton.UseVisualStyleBackColor = true;
            this.deleteDeviceButton.Click += new System.EventHandler(this.deleteDeviceButton_Click);
            // 
            // editInfoButton
            // 
            this.editInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editInfoButton.Location = new System.Drawing.Point(161, 442);
            this.editInfoButton.Name = "editInfoButton";
            this.editInfoButton.Size = new System.Drawing.Size(143, 33);
            this.editInfoButton.TabIndex = 5;
            this.editInfoButton.Text = "Редагувати інформацію";
            this.editInfoButton.UseVisualStyleBackColor = true;
            this.editInfoButton.Click += new System.EventHandler(this.editInfoButton_Click);
            // 
            // detailedInfoButton
            // 
            this.detailedInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.detailedInfoButton.Location = new System.Drawing.Point(12, 442);
            this.detailedInfoButton.Name = "detailedInfoButton";
            this.detailedInfoButton.Size = new System.Drawing.Size(143, 33);
            this.detailedInfoButton.TabIndex = 6;
            this.detailedInfoButton.Text = "Детальна інформація";
            this.detailedInfoButton.UseVisualStyleBackColor = true;
            this.detailedInfoButton.Click += new System.EventHandler(this.detailedInfoButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(470, 32);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(110, 43);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Обновити";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deviceNumberLabel
            // 
            this.deviceNumberLabel.AutoSize = true;
            this.deviceNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceNumberLabel.Location = new System.Drawing.Point(3, 16);
            this.deviceNumberLabel.Name = "deviceNumberLabel";
            this.deviceNumberLabel.Size = new System.Drawing.Size(110, 13);
            this.deviceNumberLabel.TabIndex = 20;
            this.deviceNumberLabel.Text = "Інвентарний номер :";
            // 
            // deviceNumberTextBox
            // 
            this.deviceNumberTextBox.Location = new System.Drawing.Point(6, 32);
            this.deviceNumberTextBox.Name = "deviceNumberTextBox";
            this.deviceNumberTextBox.Size = new System.Drawing.Size(110, 20);
            this.deviceNumberTextBox.TabIndex = 21;
            // 
            // deviceTypeLabel
            // 
            this.deviceTypeLabel.AutoSize = true;
            this.deviceTypeLabel.Location = new System.Drawing.Point(119, 16);
            this.deviceTypeLabel.Name = "deviceTypeLabel";
            this.deviceTypeLabel.Size = new System.Drawing.Size(95, 13);
            this.deviceTypeLabel.TabIndex = 22;
            this.deviceTypeLabel.Text = "Тип обладнання :";
            // 
            // locationComboBox
            // 
            this.locationComboBox.DataSource = this.locationsBindingSource;
            this.locationComboBox.DisplayMember = "location_name";
            this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(238, 32);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(110, 21);
            this.locationComboBox.TabIndex = 25;
            this.locationComboBox.ValueMember = "location_id";
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "locations";
            this.locationsBindingSource.DataSource = this.tech_inspectorDataSet;
            this.locationsBindingSource.Sort = "location_id";
            // 
            // typeSelectionComboBox
            // 
            this.typeSelectionComboBox.DataSource = this.typesBindingSource;
            this.typeSelectionComboBox.DisplayMember = "type_name";
            this.typeSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeSelectionComboBox.FormattingEnabled = true;
            this.typeSelectionComboBox.Location = new System.Drawing.Point(122, 31);
            this.typeSelectionComboBox.Name = "typeSelectionComboBox";
            this.typeSelectionComboBox.Size = new System.Drawing.Size(110, 21);
            this.typeSelectionComboBox.TabIndex = 23;
            this.typeSelectionComboBox.ValueMember = "type_id";
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "types";
            this.typesBindingSource.DataSource = this.tech_inspectorDataSet;
            this.typesBindingSource.Sort = "type_id";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(235, 16);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(86, 13);
            this.locationLabel.TabIndex = 24;
            this.locationLabel.Text = "Розташування :";
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.newCheckBox);
            this.filterGroupBox.Controls.Add(this.movedCheckBox);
            this.filterGroupBox.Controls.Add(this.repairingCheckBox);
            this.filterGroupBox.Controls.Add(this.stateLabel);
            this.filterGroupBox.Controls.Add(this.stateComboBox);
            this.filterGroupBox.Controls.Add(this.deviceNumberTextBox);
            this.filterGroupBox.Controls.Add(this.refreshButton);
            this.filterGroupBox.Controls.Add(this.locationLabel);
            this.filterGroupBox.Controls.Add(this.locationComboBox);
            this.filterGroupBox.Controls.Add(this.deviceTypeLabel);
            this.filterGroupBox.Controls.Add(this.deviceNumberLabel);
            this.filterGroupBox.Controls.Add(this.typeSelectionComboBox);
            this.filterGroupBox.Location = new System.Drawing.Point(12, 27);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(590, 84);
            this.filterGroupBox.TabIndex = 26;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Фільтри";
            // 
            // newCheckBox
            // 
            this.newCheckBox.AutoSize = true;
            this.newCheckBox.Location = new System.Drawing.Point(122, 58);
            this.newCheckBox.Name = "newCheckBox";
            this.newCheckBox.Size = new System.Drawing.Size(115, 17);
            this.newCheckBox.TabIndex = 32;
            this.newCheckBox.Text = "Нове обладнання";
            this.newCheckBox.UseVisualStyleBackColor = true;
            // 
            // movedCheckBox
            // 
            this.movedCheckBox.AutoSize = true;
            this.movedCheckBox.Location = new System.Drawing.Point(326, 58);
            this.movedCheckBox.Name = "movedCheckBox";
            this.movedCheckBox.Size = new System.Drawing.Size(145, 17);
            this.movedCheckBox.TabIndex = 31;
            this.movedCheckBox.Text = "Тимчасово перенесено";
            this.movedCheckBox.UseVisualStyleBackColor = true;
            // 
            // repairingCheckBox
            // 
            this.repairingCheckBox.AutoSize = true;
            this.repairingCheckBox.Location = new System.Drawing.Point(238, 58);
            this.repairingCheckBox.Name = "repairingCheckBox";
            this.repairingCheckBox.Size = new System.Drawing.Size(82, 17);
            this.repairingCheckBox.TabIndex = 30;
            this.repairingCheckBox.Text = "На ремонті";
            this.repairingCheckBox.UseVisualStyleBackColor = true;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(351, 16);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(85, 13);
            this.stateLabel.TabIndex = 27;
            this.stateLabel.Text = "Технічний стан:";
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataSource = this.statesBindingSource;
            this.stateComboBox.DisplayMember = "state_name";
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(354, 32);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(110, 21);
            this.stateComboBox.TabIndex = 26;
            this.stateComboBox.ValueMember = "state_id";
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "states";
            this.statesBindingSource.DataSource = this.tech_inspectorDataSet;
            this.statesBindingSource.Sort = "state_id";
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // equipment_shortinfoTableAdapter
            // 
            this.equipment_shortinfoTableAdapter.ClearBeforeFill = true;
            // 
            // locationsTableAdapter
            // 
            this.locationsTableAdapter.ClearBeforeFill = true;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.equipmentCountStatusLable});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(612, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(132, 17);
            this.toolStripStatusLabel1.Text = "Знайдено обладнання:";
            // 
            // equipmentCountStatusLable
            // 
            this.equipmentCountStatusLable.Name = "equipmentCountStatusLable";
            this.equipmentCountStatusLable.Size = new System.Drawing.Size(13, 17);
            this.equipmentCountStatusLable.Text = "0";
            // 
            // InfoViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 509);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.detailedInfoButton);
            this.Controls.Add(this.editInfoButton);
            this.Controls.Add(this.deleteDeviceButton);
            this.Controls.Add(this.addDeviceButton);
            this.Controls.Add(this.infosDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(628, 547);
            this.Name = "InfoViewer";
            this.Text = "Облік наявних комп’ютерів і комплектуючих на кафедрі та їх технічного стану";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfoViewer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentshortinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView infosDataGridView;
        private System.Windows.Forms.Button addDeviceButton;
        private System.Windows.Forms.Button deleteDeviceButton;
        private System.Windows.Forms.Button editInfoButton;
        private System.Windows.Forms.Button detailedInfoButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label deviceNumberLabel;
        private System.Windows.Forms.TextBox deviceNumberTextBox;
        private System.Windows.Forms.Label deviceTypeLabel;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.ComboBox typeSelectionComboBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placementdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyenddateDataGridViewTextBoxColumn;
        private tech_inspectorDataSet tech_inspectorDataSet;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private tech_inspectorDataSetTableAdapters.typesTableAdapter typesTableAdapter;
        private System.Windows.Forms.BindingSource equipmentshortinfoBindingSource;
        private tech_inspectorDataSetTableAdapters.equipment_shortinfoTableAdapter equipment_shortinfoTableAdapter;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private tech_inspectorDataSetTableAdapters.locationsTableAdapter locationsTableAdapter;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private tech_inspectorDataSetTableAdapters.statesTableAdapter statesTableAdapter;
        private System.Windows.Forms.CheckBox newCheckBox;
        private System.Windows.Forms.CheckBox movedCheckBox;
        private System.Windows.Forms.CheckBox repairingCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn moved;
        private System.Windows.Forms.DataGridViewCheckBoxColumn repairing;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel equipmentCountStatusLable;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}