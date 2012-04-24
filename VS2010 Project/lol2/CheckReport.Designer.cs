namespace lol2
{
    partial class CheckReport
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
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.версіяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розробникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.startCheckButton = new System.Windows.Forms.Button();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_inspectorDataSet = new lol2.tech_inspectorDataSet();
            this.locationLabel = new System.Windows.Forms.Label();
            this.responsibleLabel = new System.Windows.Forms.Label();
            this.responsibleTextBox = new System.Windows.Forms.TextBox();
            this.locationEquipmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.equipment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placementdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warrantyenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.movedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.templocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentsTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.equipmentsTableAdapter();
            this.locationsTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.locationsTableAdapter();
            this.editAllButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.generalInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationEquipmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.saveChangesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeWindowToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.startToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.startToolStripMenuItem.Text = "Розпочати профілактику";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // saveChangesToolStripMenuItem
            // 
            this.saveChangesToolStripMenuItem.Enabled = false;
            this.saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
            this.saveChangesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveChangesToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.saveChangesToolStripMenuItem.Text = "Завершити профілактику";
            this.saveChangesToolStripMenuItem.Click += new System.EventHandler(this.saveChangesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(253, 6);
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.closeWindowToolStripMenuItem.Text = "Закрити вікно";
            this.closeWindowToolStripMenuItem.Click += new System.EventHandler(this.closeWindowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
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
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.допомогаToolStripMenuItem,
            this.версіяToolStripMenuItem,
            this.розробникиToolStripMenuItem});
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            this.допомогаToolStripMenuItem.Click += new System.EventHandler(this.допомогаToolStripMenuItem_Click);
            // 
            // версіяToolStripMenuItem
            // 
            this.версіяToolStripMenuItem.Name = "версіяToolStripMenuItem";
            this.версіяToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.версіяToolStripMenuItem.Text = "Версія";
            this.версіяToolStripMenuItem.Click += new System.EventHandler(this.версіяToolStripMenuItem_Click);
            // 
            // розробникиToolStripMenuItem
            // 
            this.розробникиToolStripMenuItem.Name = "розробникиToolStripMenuItem";
            this.розробникиToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.розробникиToolStripMenuItem.Text = "Розробники";
            this.розробникиToolStripMenuItem.Click += new System.EventHandler(this.розробникиToolStripMenuItem_Click);
            // 
            // generalInformationGroupBox
            // 
            this.generalInformationGroupBox.Controls.Add(this.startCheckButton);
            this.generalInformationGroupBox.Controls.Add(this.locationComboBox);
            this.generalInformationGroupBox.Controls.Add(this.locationLabel);
            this.generalInformationGroupBox.Controls.Add(this.responsibleLabel);
            this.generalInformationGroupBox.Controls.Add(this.responsibleTextBox);
            this.generalInformationGroupBox.Location = new System.Drawing.Point(12, 36);
            this.generalInformationGroupBox.Name = "generalInformationGroupBox";
            this.generalInformationGroupBox.Size = new System.Drawing.Size(558, 80);
            this.generalInformationGroupBox.TabIndex = 4;
            this.generalInformationGroupBox.TabStop = false;
            this.generalInformationGroupBox.Text = "Загальна інформація";
            // 
            // startCheckButton
            // 
            this.startCheckButton.Location = new System.Drawing.Point(432, 38);
            this.startCheckButton.Name = "startCheckButton";
            this.startCheckButton.Size = new System.Drawing.Size(120, 35);
            this.startCheckButton.TabIndex = 8;
            this.startCheckButton.Text = "Розпочати ";
            this.startCheckButton.UseVisualStyleBackColor = true;
            this.startCheckButton.Click += new System.EventHandler(this.startCheckButton_Click);
            // 
            // locationComboBox
            // 
            this.locationComboBox.DataSource = this.locationsBindingSource;
            this.locationComboBox.DisplayMember = "location_name";
            this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(220, 46);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(189, 21);
            this.locationComboBox.TabIndex = 7;
            this.locationComboBox.ValueMember = "location_name";
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "locations";
            this.locationsBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // tech_inspectorDataSet
            // 
            this.tech_inspectorDataSet.DataSetName = "tech_inspectorDataSet";
            this.tech_inspectorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(224, 30);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(62, 13);
            this.locationLabel.TabIndex = 6;
            this.locationLabel.Text = "Аудиторія :";
            // 
            // responsibleLabel
            // 
            this.responsibleLabel.AutoSize = true;
            this.responsibleLabel.Location = new System.Drawing.Point(10, 31);
            this.responsibleLabel.Name = "responsibleLabel";
            this.responsibleLabel.Size = new System.Drawing.Size(90, 13);
            this.responsibleLabel.TabIndex = 1;
            this.responsibleLabel.Text = "Відповідальний :";
            // 
            // responsibleTextBox
            // 
            this.responsibleTextBox.Location = new System.Drawing.Point(6, 47);
            this.responsibleTextBox.Name = "responsibleTextBox";
            this.responsibleTextBox.Size = new System.Drawing.Size(193, 20);
            this.responsibleTextBox.TabIndex = 0;
            // 
            // locationEquipmentsDataGridView
            // 
            this.locationEquipmentsDataGridView.AllowUserToAddRows = false;
            this.locationEquipmentsDataGridView.AllowUserToDeleteRows = false;
            this.locationEquipmentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationEquipmentsDataGridView.AutoGenerateColumns = false;
            this.locationEquipmentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.locationEquipmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationEquipmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipment_id,
            this.location_name,
            this.state_name,
            this.priceDataGridViewTextBoxColumn,
            this.type_name,
            this.purchasedateDataGridViewTextBoxColumn,
            this.placementdateDataGridViewTextBoxColumn,
            this.warrantyenddateDataGridViewTextBoxColumn,
            this.repairingDataGridViewCheckBoxColumn,
            this.movedDataGridViewCheckBoxColumn,
            this.templocationDataGridViewTextBoxColumn});
            this.locationEquipmentsDataGridView.DataSource = this.equipmentsBindingSource;
            this.locationEquipmentsDataGridView.Location = new System.Drawing.Point(12, 122);
            this.locationEquipmentsDataGridView.Name = "locationEquipmentsDataGridView";
            this.locationEquipmentsDataGridView.ReadOnly = true;
            this.locationEquipmentsDataGridView.Size = new System.Drawing.Size(824, 427);
            this.locationEquipmentsDataGridView.TabIndex = 5;
            this.locationEquipmentsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.locationEquipmentsDataGridView_CellMouseDoubleClick);
            // 
            // equipment_id
            // 
            this.equipment_id.DataPropertyName = "equipment_id";
            this.equipment_id.HeaderText = "Інвентарний номер";
            this.equipment_id.Name = "equipment_id";
            this.equipment_id.ReadOnly = true;
            // 
            // location_name
            // 
            this.location_name.DataPropertyName = "location_name";
            this.location_name.HeaderText = "Розташування";
            this.location_name.Name = "location_name";
            this.location_name.ReadOnly = true;
            // 
            // state_name
            // 
            this.state_name.DataPropertyName = "state_name";
            this.state_name.HeaderText = "Стан";
            this.state_name.Name = "state_name";
            this.state_name.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // type_name
            // 
            this.type_name.DataPropertyName = "type_name";
            this.type_name.HeaderText = "Тип";
            this.type_name.Name = "type_name";
            this.type_name.ReadOnly = true;
            // 
            // purchasedateDataGridViewTextBoxColumn
            // 
            this.purchasedateDataGridViewTextBoxColumn.DataPropertyName = "purchase_date";
            this.purchasedateDataGridViewTextBoxColumn.HeaderText = "Дата покупки";
            this.purchasedateDataGridViewTextBoxColumn.Name = "purchasedateDataGridViewTextBoxColumn";
            this.purchasedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placementdateDataGridViewTextBoxColumn
            // 
            this.placementdateDataGridViewTextBoxColumn.DataPropertyName = "placement_date";
            this.placementdateDataGridViewTextBoxColumn.HeaderText = "Дата розміщення";
            this.placementdateDataGridViewTextBoxColumn.Name = "placementdateDataGridViewTextBoxColumn";
            this.placementdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // warrantyenddateDataGridViewTextBoxColumn
            // 
            this.warrantyenddateDataGridViewTextBoxColumn.DataPropertyName = "warranty_end_date";
            this.warrantyenddateDataGridViewTextBoxColumn.HeaderText = "Закінчення гарантії";
            this.warrantyenddateDataGridViewTextBoxColumn.Name = "warrantyenddateDataGridViewTextBoxColumn";
            this.warrantyenddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repairingDataGridViewCheckBoxColumn
            // 
            this.repairingDataGridViewCheckBoxColumn.DataPropertyName = "repairing";
            this.repairingDataGridViewCheckBoxColumn.HeaderText = "На ремонті";
            this.repairingDataGridViewCheckBoxColumn.Name = "repairingDataGridViewCheckBoxColumn";
            this.repairingDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // movedDataGridViewCheckBoxColumn
            // 
            this.movedDataGridViewCheckBoxColumn.DataPropertyName = "moved";
            this.movedDataGridViewCheckBoxColumn.HeaderText = "Переміщений";
            this.movedDataGridViewCheckBoxColumn.Name = "movedDataGridViewCheckBoxColumn";
            this.movedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // templocationDataGridViewTextBoxColumn
            // 
            this.templocationDataGridViewTextBoxColumn.DataPropertyName = "temp_location";
            this.templocationDataGridViewTextBoxColumn.HeaderText = "Тимчасове розташування";
            this.templocationDataGridViewTextBoxColumn.Name = "templocationDataGridViewTextBoxColumn";
            this.templocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // equipmentsBindingSource
            // 
            this.equipmentsBindingSource.DataMember = "equipments";
            this.equipmentsBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // equipmentsTableAdapter
            // 
            this.equipmentsTableAdapter.ClearBeforeFill = true;
            // 
            // locationsTableAdapter
            // 
            this.locationsTableAdapter.ClearBeforeFill = true;
            // 
            // editAllButton
            // 
            this.editAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editAllButton.Enabled = false;
            this.editAllButton.Location = new System.Drawing.Point(702, 81);
            this.editAllButton.Name = "editAllButton";
            this.editAllButton.Size = new System.Drawing.Size(120, 35);
            this.editAllButton.TabIndex = 6;
            this.editAllButton.Text = "Редагувати виділене";
            this.editAllButton.UseVisualStyleBackColor = true;
            this.editAllButton.Click += new System.EventHandler(this.editAllButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.finishButton.Enabled = false;
            this.finishButton.Location = new System.Drawing.Point(576, 81);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(120, 35);
            this.finishButton.TabIndex = 7;
            this.finishButton.Text = "Завершити профілактику";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // CheckReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 562);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.editAllButton);
            this.Controls.Add(this.locationEquipmentsDataGridView);
            this.Controls.Add(this.generalInformationGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "CheckReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Протокол по профілактиці";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckReport_FormClosing);
            this.Load += new System.EventHandler(this.CheckReport_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.generalInformationGroupBox.ResumeLayout(false);
            this.generalInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationEquipmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem версіяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розробникиToolStripMenuItem;
        private System.Windows.Forms.GroupBox generalInformationGroupBox;
        private System.Windows.Forms.Label responsibleLabel;
        private System.Windows.Forms.TextBox responsibleTextBox;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Button startCheckButton;
        private System.Windows.Forms.DataGridView locationEquipmentsDataGridView;
        private tech_inspectorDataSet tech_inspectorDataSet;
        private System.Windows.Forms.BindingSource equipmentsBindingSource;
        private tech_inspectorDataSetTableAdapters.equipmentsTableAdapter equipmentsTableAdapter;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private tech_inspectorDataSetTableAdapters.locationsTableAdapter locationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button editAllButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn state_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placementdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn repairingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn movedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
    }
}