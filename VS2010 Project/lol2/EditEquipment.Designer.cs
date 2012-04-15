namespace lol2
{
    partial class EditEquipment
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
            this.stateSelectLabel = new System.Windows.Forms.Label();
            this.stateSelectComboBox = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.equipmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_inspectorDataSet = new lol2.tech_inspectorDataSet();
            this.deviceNumberLabel = new System.Windows.Forms.Label();
            this.deviceNumberTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.deviceTypeLabel = new System.Windows.Forms.Label();
            this.typeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.dateGroupBox = new System.Windows.Forms.GroupBox();
            this.warrantyEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.placementDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.purchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.warrantyEndDateLabel = new System.Windows.Forms.Label();
            this.placementDateLabel = new System.Windows.Forms.Label();
            this.purchaseDateLabel = new System.Windows.Forms.Label();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.configurationDataGridView = new System.Windows.Forms.DataGridView();
            this.equipmentsTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.equipmentsTableAdapter();
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.typesTableAdapter();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.statesTableAdapter();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationsTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.locationsTableAdapter();
            this.attributeslistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attributes_listTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.attributes_listTableAdapter();
            this.equipmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributevalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).BeginInit();
            this.dateGroupBox.SuspendLayout();
            this.configurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributeslistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stateSelectLabel);
            this.groupBox1.Controls.Add(this.stateSelectComboBox);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.deviceNumberLabel);
            this.groupBox1.Controls.Add(this.deviceNumberTextBox);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.deviceTypeLabel);
            this.groupBox1.Controls.Add(this.typeSelectionComboBox);
            this.groupBox1.Controls.Add(this.locationComboBox);
            this.groupBox1.Controls.Add(this.locationLabel);
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 153);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальна інформація";
            // 
            // stateSelectLabel
            // 
            this.stateSelectLabel.AutoSize = true;
            this.stateSelectLabel.Location = new System.Drawing.Point(14, 102);
            this.stateSelectLabel.Name = "stateSelectLabel";
            this.stateSelectLabel.Size = new System.Drawing.Size(92, 13);
            this.stateSelectLabel.TabIndex = 23;
            this.stateSelectLabel.Text = "Технічний стан* :";
            // 
            // stateSelectComboBox
            // 
            this.stateSelectComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.equipmentsBindingSource, "state_id", true));
            this.stateSelectComboBox.DataSource = this.statesBindingSource;
            this.stateSelectComboBox.DisplayMember = "state_name";
            this.stateSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateSelectComboBox.FormattingEnabled = true;
            this.stateSelectComboBox.Location = new System.Drawing.Point(127, 99);
            this.stateSelectComboBox.Name = "stateSelectComboBox";
            this.stateSelectComboBox.Size = new System.Drawing.Size(152, 21);
            this.stateSelectComboBox.TabIndex = 22;
            this.stateSelectComboBox.ValueMember = "state_id";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentsBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(127, 126);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(152, 20);
            this.priceTextBox.TabIndex = 21;
            // 
            // equipmentsBindingSource
            // 
            this.equipmentsBindingSource.DataMember = "equipments";
            this.equipmentsBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // tech_inspectorDataSet
            // 
            this.tech_inspectorDataSet.DataSetName = "tech_inspectorDataSet";
            this.tech_inspectorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceNumberLabel
            // 
            this.deviceNumberLabel.AutoSize = true;
            this.deviceNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceNumberLabel.Location = new System.Drawing.Point(14, 22);
            this.deviceNumberLabel.Name = "deviceNumberLabel";
            this.deviceNumberLabel.Size = new System.Drawing.Size(114, 13);
            this.deviceNumberLabel.TabIndex = 2;
            this.deviceNumberLabel.Text = "Інвентарний номер* :";
            // 
            // deviceNumberTextBox
            // 
            this.deviceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentsBindingSource, "equipment_id", true));
            this.deviceNumberTextBox.Location = new System.Drawing.Point(127, 19);
            this.deviceNumberTextBox.Name = "deviceNumberTextBox";
            this.deviceNumberTextBox.Size = new System.Drawing.Size(152, 20);
            this.deviceNumberTextBox.TabIndex = 3;
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
            this.deviceTypeLabel.Size = new System.Drawing.Size(99, 13);
            this.deviceTypeLabel.TabIndex = 4;
            this.deviceTypeLabel.Text = "Тип обладнання* :";
            // 
            // typeSelectionComboBox
            // 
            this.typeSelectionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.equipmentsBindingSource, "type_id", true));
            this.typeSelectionComboBox.DataSource = this.typesBindingSource;
            this.typeSelectionComboBox.DisplayMember = "type_name";
            this.typeSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeSelectionComboBox.Enabled = false;
            this.typeSelectionComboBox.FormattingEnabled = true;
            this.typeSelectionComboBox.Location = new System.Drawing.Point(127, 45);
            this.typeSelectionComboBox.Name = "typeSelectionComboBox";
            this.typeSelectionComboBox.Size = new System.Drawing.Size(152, 21);
            this.typeSelectionComboBox.TabIndex = 5;
            this.typeSelectionComboBox.ValueMember = "type_id";
            // 
            // locationComboBox
            // 
            this.locationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.equipmentsBindingSource, "location_id", true));
            this.locationComboBox.DataSource = this.locationsBindingSource;
            this.locationComboBox.DisplayMember = "location_name";
            this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(127, 72);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(152, 21);
            this.locationComboBox.TabIndex = 19;
            this.locationComboBox.ValueMember = "location_id";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(14, 75);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(90, 13);
            this.locationLabel.TabIndex = 18;
            this.locationLabel.Text = "Розташування *:";
            // 
            // dateGroupBox
            // 
            this.dateGroupBox.Controls.Add(this.warrantyEndDateTimePicker);
            this.dateGroupBox.Controls.Add(this.placementDateTimePicker);
            this.dateGroupBox.Controls.Add(this.purchaseDateTimePicker);
            this.dateGroupBox.Controls.Add(this.warrantyEndDateLabel);
            this.dateGroupBox.Controls.Add(this.placementDateLabel);
            this.dateGroupBox.Controls.Add(this.purchaseDateLabel);
            this.dateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateGroupBox.Location = new System.Drawing.Point(305, 8);
            this.dateGroupBox.Name = "dateGroupBox";
            this.dateGroupBox.Size = new System.Drawing.Size(366, 101);
            this.dateGroupBox.TabIndex = 26;
            this.dateGroupBox.TabStop = false;
            this.dateGroupBox.Text = "Дата";
            // 
            // warrantyEndDateTimePicker
            // 
            this.warrantyEndDateTimePicker.Checked = false;
            this.warrantyEndDateTimePicker.CustomFormat = "";
            this.warrantyEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.equipmentsBindingSource, "warranty_end_date", true));
            this.warrantyEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.warrantyEndDateTimePicker.Location = new System.Drawing.Point(197, 72);
            this.warrantyEndDateTimePicker.Name = "warrantyEndDateTimePicker";
            this.warrantyEndDateTimePicker.ShowCheckBox = true;
            this.warrantyEndDateTimePicker.Size = new System.Drawing.Size(163, 20);
            this.warrantyEndDateTimePicker.TabIndex = 27;
            // 
            // placementDateTimePicker
            // 
            this.placementDateTimePicker.Checked = false;
            this.placementDateTimePicker.CustomFormat = "";
            this.placementDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.equipmentsBindingSource, "placement_date", true));
            this.placementDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.placementDateTimePicker.Location = new System.Drawing.Point(197, 46);
            this.placementDateTimePicker.Name = "placementDateTimePicker";
            this.placementDateTimePicker.ShowCheckBox = true;
            this.placementDateTimePicker.Size = new System.Drawing.Size(163, 20);
            this.placementDateTimePicker.TabIndex = 26;
            // 
            // purchaseDateTimePicker
            // 
            this.purchaseDateTimePicker.Checked = false;
            this.purchaseDateTimePicker.CustomFormat = "";
            this.purchaseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.equipmentsBindingSource, "purchase_date", true));
            this.purchaseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.purchaseDateTimePicker.Location = new System.Drawing.Point(197, 19);
            this.purchaseDateTimePicker.Name = "purchaseDateTimePicker";
            this.purchaseDateTimePicker.ShowCheckBox = true;
            this.purchaseDateTimePicker.Size = new System.Drawing.Size(163, 20);
            this.purchaseDateTimePicker.TabIndex = 25;
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
            // saveChangesButton
            // 
            this.saveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChangesButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(554, 489);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(132, 32);
            this.saveChangesButton.TabIndex = 25;
            this.saveChangesButton.Text = "Зберегти зміни";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.configurationGroupBox.Controls.Add(this.configurationDataGridView);
            this.configurationGroupBox.Location = new System.Drawing.Point(3, 167);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(688, 316);
            this.configurationGroupBox.TabIndex = 24;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Конфігурація обладнання";
            // 
            // configurationDataGridView
            // 
            this.configurationDataGridView.AllowUserToAddRows = false;
            this.configurationDataGridView.AllowUserToDeleteRows = false;
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
            this.configurationDataGridView.Size = new System.Drawing.Size(675, 291);
            this.configurationDataGridView.TabIndex = 0;
            // 
            // equipmentsTableAdapter
            // 
            this.equipmentsTableAdapter.ClearBeforeFill = true;
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "types";
            this.typesBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "states";
            this.statesBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "locations";
            this.locationsBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // locationsTableAdapter
            // 
            this.locationsTableAdapter.ClearBeforeFill = true;
            // 
            // attributeslistBindingSource
            // 
            this.attributeslistBindingSource.DataMember = "attributes_list";
            this.attributeslistBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // attributes_listTableAdapter
            // 
            this.attributes_listTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentidDataGridViewTextBoxColumn
            // 
            this.equipmentidDataGridViewTextBoxColumn.DataPropertyName = "equipment_id";
            this.equipmentidDataGridViewTextBoxColumn.HeaderText = "equipment_id";
            this.equipmentidDataGridViewTextBoxColumn.Name = "equipmentidDataGridViewTextBoxColumn";
            this.equipmentidDataGridViewTextBoxColumn.Visible = false;
            // 
            // attributeidDataGridViewTextBoxColumn
            // 
            this.attributeidDataGridViewTextBoxColumn.DataPropertyName = "attribute_id";
            this.attributeidDataGridViewTextBoxColumn.HeaderText = "attribute_id";
            this.attributeidDataGridViewTextBoxColumn.Name = "attributeidDataGridViewTextBoxColumn";
            this.attributeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // attributenameDataGridViewTextBoxColumn
            // 
            this.attributenameDataGridViewTextBoxColumn.DataPropertyName = "attribute_name";
            this.attributenameDataGridViewTextBoxColumn.HeaderText = "attribute_name";
            this.attributenameDataGridViewTextBoxColumn.Name = "attributenameDataGridViewTextBoxColumn";
            this.attributenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attributevalueDataGridViewTextBoxColumn
            // 
            this.attributevalueDataGridViewTextBoxColumn.DataPropertyName = "attribute_value";
            this.attributevalueDataGridViewTextBoxColumn.HeaderText = "attribute_value";
            this.attributevalueDataGridViewTextBoxColumn.Name = "attributevalueDataGridViewTextBoxColumn";
            // 
            // EditEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateGroupBox);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.configurationGroupBox);
            this.Name = "EditEquipment";
            this.Text = "Редагування обладнання";
            this.Load += new System.EventHandler(this.EditEquipment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).EndInit();
            this.dateGroupBox.ResumeLayout(false);
            this.dateGroupBox.PerformLayout();
            this.configurationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configurationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributeslistBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label stateSelectLabel;
        private System.Windows.Forms.ComboBox stateSelectComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label deviceNumberLabel;
        private System.Windows.Forms.TextBox deviceNumberTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label deviceTypeLabel;
        private System.Windows.Forms.ComboBox typeSelectionComboBox;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.GroupBox dateGroupBox;
        private System.Windows.Forms.DateTimePicker warrantyEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker placementDateTimePicker;
        private System.Windows.Forms.DateTimePicker purchaseDateTimePicker;
        private System.Windows.Forms.Label warrantyEndDateLabel;
        private System.Windows.Forms.Label placementDateLabel;
        private System.Windows.Forms.Label purchaseDateLabel;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.GroupBox configurationGroupBox;
        private System.Windows.Forms.DataGridView configurationDataGridView;
        private tech_inspectorDataSet tech_inspectorDataSet;
        private System.Windows.Forms.BindingSource equipmentsBindingSource;
        private tech_inspectorDataSetTableAdapters.equipmentsTableAdapter equipmentsTableAdapter;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private tech_inspectorDataSetTableAdapters.typesTableAdapter typesTableAdapter;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private tech_inspectorDataSetTableAdapters.statesTableAdapter statesTableAdapter;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private tech_inspectorDataSetTableAdapters.locationsTableAdapter locationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributevalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource attributeslistBindingSource;
        private tech_inspectorDataSetTableAdapters.attributes_listTableAdapter attributes_listTableAdapter;
    }
}