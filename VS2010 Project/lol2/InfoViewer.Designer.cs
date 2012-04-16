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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новийФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняШаблонівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosDataGridView = new System.Windows.Forms.DataGridView();
            this.equipmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.typesTableAdapter();
            this.equipment_shortinfoTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.equipment_shortinfoTableAdapter();
            this.locationsTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.locationsTableAdapter();
            this.statesTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.statesTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentshortinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            this.filterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.новийФайлToolStripMenuItem.Click += new System.EventHandler(this.новийФайлToolStripMenuItem_Click);
            // 
            // редагуванняШаблонівToolStripMenuItem
            // 
            this.редагуванняШаблонівToolStripMenuItem.Name = "редагуванняШаблонівToolStripMenuItem";
            this.редагуванняШаблонівToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.редагуванняШаблонівToolStripMenuItem.Text = "Редагувати типи обладнання";
            this.редагуванняШаблонівToolStripMenuItem.Click += new System.EventHandler(this.редагуванняШаблонівToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.вихідToolStripMenuItem.Text = "&Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
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
            this.typenameDataGridViewTextBoxColumn,
            this.locationnameDataGridViewTextBoxColumn,
            this.statenameDataGridViewTextBoxColumn,
            this.locationidDataGridViewTextBoxColumn,
            this.stateidDataGridViewTextBoxColumn,
            this.typeidDataGridViewTextBoxColumn});
            this.infosDataGridView.DataSource = this.equipmentshortinfoBindingSource;
            this.infosDataGridView.Location = new System.Drawing.Point(12, 99);
            this.infosDataGridView.Name = "infosDataGridView";
            this.infosDataGridView.ReadOnly = true;
            this.infosDataGridView.Size = new System.Drawing.Size(590, 360);
            this.infosDataGridView.TabIndex = 2;
            // 
            // equipmentidDataGridViewTextBoxColumn
            // 
            this.equipmentidDataGridViewTextBoxColumn.DataPropertyName = "equipment_id";
            this.equipmentidDataGridViewTextBoxColumn.HeaderText = "Інвентарний номер";
            this.equipmentidDataGridViewTextBoxColumn.Name = "equipmentidDataGridViewTextBoxColumn";
            this.equipmentidDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.addDeviceButton.Location = new System.Drawing.Point(310, 465);
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
            this.deleteDeviceButton.Location = new System.Drawing.Point(459, 465);
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
            this.editInfoButton.Location = new System.Drawing.Point(161, 465);
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
            this.detailedInfoButton.Location = new System.Drawing.Point(12, 465);
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
            this.refreshButton.Size = new System.Drawing.Size(110, 22);
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
            this.filterGroupBox.Size = new System.Drawing.Size(590, 66);
            this.filterGroupBox.TabIndex = 26;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Фільтри";
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
            // InfoViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 509);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.detailedInfoButton);
            this.Controls.Add(this.editInfoButton);
            this.Controls.Add(this.deleteDeviceButton);
            this.Controls.Add(this.addDeviceButton);
            this.Controls.Add(this.infosDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "InfoViewer";
            this.Text = "Облік наявних комп’ютерів і комплектуючих на кафедрі та їх технічного стану";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новийФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуванняШаблонівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn;
    }
}