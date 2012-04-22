namespace lol2
{
    partial class EquipmentByDate
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
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.toPurchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromPurchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseDateLabel = new System.Windows.Forms.Label();
            this.deviceNumberTextBox = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deviceTypeLabel = new System.Windows.Forms.Label();
            this.deviceNumberLabel = new System.Windows.Forms.Label();
            this.typeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_inspectorDataSet = new lol2.tech_inspectorDataSet();
            this.detailedInfoButton = new System.Windows.Forms.Button();
            this.typesTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.typesTableAdapter();
            this.equipment_shortinfoTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.equipment_shortinfoTableAdapter();
            this.editInfoButton = new System.Windows.Forms.Button();
            this.deleteDeviceButton = new System.Windows.Forms.Button();
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
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняШаблонівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новийФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeviceButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentshortinfoBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.toPurchaseDateTimePicker);
            this.filterGroupBox.Controls.Add(this.fromPurchaseDateTimePicker);
            this.filterGroupBox.Controls.Add(this.label2);
            this.filterGroupBox.Controls.Add(this.label1);
            this.filterGroupBox.Controls.Add(this.purchaseDateLabel);
            this.filterGroupBox.Controls.Add(this.deviceNumberTextBox);
            this.filterGroupBox.Controls.Add(this.refreshButton);
            this.filterGroupBox.Controls.Add(this.deviceTypeLabel);
            this.filterGroupBox.Controls.Add(this.deviceNumberLabel);
            this.filterGroupBox.Controls.Add(this.typeSelectionComboBox);
            this.filterGroupBox.Location = new System.Drawing.Point(12, 27);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(590, 104);
            this.filterGroupBox.TabIndex = 33;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Фільтри";
            // 
            // toPurchaseDateTimePicker
            // 
            this.toPurchaseDateTimePicker.Checked = false;
            this.toPurchaseDateTimePicker.CustomFormat = "";
            this.toPurchaseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toPurchaseDateTimePicker.Location = new System.Drawing.Point(172, 68);
            this.toPurchaseDateTimePicker.Name = "toPurchaseDateTimePicker";
            this.toPurchaseDateTimePicker.ShowCheckBox = true;
            this.toPurchaseDateTimePicker.Size = new System.Drawing.Size(163, 20);
            this.toPurchaseDateTimePicker.TabIndex = 28;
            // 
            // fromPurchaseDateTimePicker
            // 
            this.fromPurchaseDateTimePicker.Checked = false;
            this.fromPurchaseDateTimePicker.CustomFormat = "";
            this.fromPurchaseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromPurchaseDateTimePicker.Location = new System.Drawing.Point(172, 42);
            this.fromPurchaseDateTimePicker.Name = "fromPurchaseDateTimePicker";
            this.fromPurchaseDateTimePicker.ShowCheckBox = true;
            this.fromPurchaseDateTimePicker.Size = new System.Drawing.Size(163, 20);
            this.fromPurchaseDateTimePicker.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "до";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "від";
            // 
            // purchaseDateLabel
            // 
            this.purchaseDateLabel.AutoSize = true;
            this.purchaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDateLabel.Location = new System.Drawing.Point(145, 16);
            this.purchaseDateLabel.Name = "purchaseDateLabel";
            this.purchaseDateLabel.Size = new System.Drawing.Size(83, 13);
            this.purchaseDateLabel.TabIndex = 24;
            this.purchaseDateLabel.Text = "Дата покупки :";
            // 
            // deviceNumberTextBox
            // 
            this.deviceNumberTextBox.Location = new System.Drawing.Point(6, 32);
            this.deviceNumberTextBox.Name = "deviceNumberTextBox";
            this.deviceNumberTextBox.Size = new System.Drawing.Size(110, 20);
            this.deviceNumberTextBox.TabIndex = 21;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(441, 65);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(143, 33);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Обновити";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deviceTypeLabel
            // 
            this.deviceTypeLabel.AutoSize = true;
            this.deviceTypeLabel.Location = new System.Drawing.Point(3, 59);
            this.deviceTypeLabel.Name = "deviceTypeLabel";
            this.deviceTypeLabel.Size = new System.Drawing.Size(95, 13);
            this.deviceTypeLabel.TabIndex = 22;
            this.deviceTypeLabel.Text = "Тип обладнання :";
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
            // typeSelectionComboBox
            // 
            this.typeSelectionComboBox.DataSource = this.typesBindingSource;
            this.typeSelectionComboBox.DisplayMember = "type_name";
            this.typeSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeSelectionComboBox.FormattingEnabled = true;
            this.typeSelectionComboBox.Location = new System.Drawing.Point(6, 74);
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
            // tech_inspectorDataSet
            // 
            this.tech_inspectorDataSet.DataSetName = "tech_inspectorDataSet";
            this.tech_inspectorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailedInfoButton
            // 
            this.detailedInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.detailedInfoButton.Location = new System.Drawing.Point(12, 492);
            this.detailedInfoButton.Name = "detailedInfoButton";
            this.detailedInfoButton.Size = new System.Drawing.Size(143, 33);
            this.detailedInfoButton.TabIndex = 32;
            this.detailedInfoButton.Text = "Детальна інформація";
            this.detailedInfoButton.UseVisualStyleBackColor = true;
            this.detailedInfoButton.Click += new System.EventHandler(this.detailedInfoButton_Click);
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // equipment_shortinfoTableAdapter
            // 
            this.equipment_shortinfoTableAdapter.ClearBeforeFill = true;
            // 
            // editInfoButton
            // 
            this.editInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editInfoButton.Location = new System.Drawing.Point(161, 492);
            this.editInfoButton.Name = "editInfoButton";
            this.editInfoButton.Size = new System.Drawing.Size(143, 33);
            this.editInfoButton.TabIndex = 31;
            this.editInfoButton.Text = "Редагувати інформацію";
            this.editInfoButton.UseVisualStyleBackColor = true;
            this.editInfoButton.Click += new System.EventHandler(this.editInfoButton_Click);
            // 
            // deleteDeviceButton
            // 
            this.deleteDeviceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteDeviceButton.Location = new System.Drawing.Point(459, 492);
            this.deleteDeviceButton.Name = "deleteDeviceButton";
            this.deleteDeviceButton.Size = new System.Drawing.Size(143, 33);
            this.deleteDeviceButton.TabIndex = 30;
            this.deleteDeviceButton.Text = "Видалити обладнання";
            this.deleteDeviceButton.UseVisualStyleBackColor = true;
            this.deleteDeviceButton.Click += new System.EventHandler(this.deleteDeviceButton_Click);
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
            this.infosDataGridView.Location = new System.Drawing.Point(12, 137);
            this.infosDataGridView.Name = "infosDataGridView";
            this.infosDataGridView.ReadOnly = true;
            this.infosDataGridView.Size = new System.Drawing.Size(589, 349);
            this.infosDataGridView.TabIndex = 28;
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
            this.locationnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // statenameDataGridViewTextBoxColumn
            // 
            this.statenameDataGridViewTextBoxColumn.DataPropertyName = "state_name";
            this.statenameDataGridViewTextBoxColumn.HeaderText = "Технічний стан";
            this.statenameDataGridViewTextBoxColumn.Name = "statenameDataGridViewTextBoxColumn";
            this.statenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.statenameDataGridViewTextBoxColumn.Visible = false;
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
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.вихідToolStripMenuItem.Text = "&Вихід";
            // 
            // редагуванняШаблонівToolStripMenuItem
            // 
            this.редагуванняШаблонівToolStripMenuItem.Name = "редагуванняШаблонівToolStripMenuItem";
            this.редагуванняШаблонівToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.редагуванняШаблонівToolStripMenuItem.Text = "Редагувати типи обладнання";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новийФайлToolStripMenuItem,
            this.редагуванняШаблонівToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // новийФайлToolStripMenuItem
            // 
            this.новийФайлToolStripMenuItem.Name = "новийФайлToolStripMenuItem";
            this.новийФайлToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.новийФайлToolStripMenuItem.Text = "&Додати пристрій до бази";
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addDeviceButton.Location = new System.Drawing.Point(310, 492);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(143, 33);
            this.addDeviceButton.TabIndex = 29;
            this.addDeviceButton.Text = "Додати обладнання";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            this.addDeviceButton.Click += new System.EventHandler(this.addDeviceButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EquipmentByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 531);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.detailedInfoButton);
            this.Controls.Add(this.editInfoButton);
            this.Controls.Add(this.deleteDeviceButton);
            this.Controls.Add(this.infosDataGridView);
            this.Controls.Add(this.addDeviceButton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "EquipmentByDate";
            this.Text = "EquipmentByDate";
            this.Load += new System.EventHandler(this.EquipmentByDate_Load);
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentshortinfoBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox filterGroupBox;
        private tech_inspectorDataSet tech_inspectorDataSet;
        private System.Windows.Forms.TextBox deviceNumberTextBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label deviceTypeLabel;
        private System.Windows.Forms.Label deviceNumberLabel;
        private System.Windows.Forms.ComboBox typeSelectionComboBox;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private System.Windows.Forms.Button detailedInfoButton;
        private tech_inspectorDataSetTableAdapters.typesTableAdapter typesTableAdapter;
        private tech_inspectorDataSetTableAdapters.equipment_shortinfoTableAdapter equipment_shortinfoTableAdapter;
        private System.Windows.Forms.Button editInfoButton;
        private System.Windows.Forms.Button deleteDeviceButton;
        private System.Windows.Forms.DataGridView infosDataGridView;
        private System.Windows.Forms.BindingSource equipmentshortinfoBindingSource;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуванняШаблонівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новийФайлToolStripMenuItem;
        private System.Windows.Forms.Button addDeviceButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label purchaseDateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DateTimePicker toPurchaseDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromPurchaseDateTimePicker;
    }
}