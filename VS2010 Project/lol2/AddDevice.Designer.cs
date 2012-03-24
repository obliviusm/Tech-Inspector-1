namespace lol2
{
    partial class AddDevice
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новийФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиТипиОбладнанняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копіюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вирізатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.версіяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розробникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ліцензіяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceNumberLabel = new System.Windows.Forms.Label();
            this.deviceNumberTextBox = new System.Windows.Forms.TextBox();
            this.deviceTypeLabel = new System.Windows.Forms.Label();
            this.typeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.removeSelectedAttrButton = new System.Windows.Forms.Button();
            this.addNewParameterButton = new System.Windows.Forms.Button();
            this.addParameterButton = new System.Windows.Forms.Button();
            this.addParameterComboBox = new System.Windows.Forms.ComboBox();
            this.addParameterLabel = new System.Windows.Forms.Label();
            this.configurationDataGridView = new System.Windows.Forms.DataGridView();
            this.parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.dateGroupBox = new System.Windows.Forms.GroupBox();
            this.serviceEndTextBox = new System.Windows.Forms.MaskedTextBox();
            this.placementDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.purchaseDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.warrantyEndLabel = new System.Windows.Forms.Label();
            this.placementDateLabel = new System.Windows.Forms.Label();
            this.purchaseDateLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.configurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationDataGridView)).BeginInit();
            this.dateGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новийФайлToolStripMenuItem,
            this.редагуватиТипиОбладнанняToolStripMenuItem,
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
            // редагуватиТипиОбладнанняToolStripMenuItem
            // 
            this.редагуватиТипиОбладнанняToolStripMenuItem.Name = "редагуватиТипиОбладнанняToolStripMenuItem";
            this.редагуватиТипиОбладнанняToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.редагуватиТипиОбладнанняToolStripMenuItem.Text = "Редаг&увати типи обладнання";
            this.редагуватиТипиОбладнанняToolStripMenuItem.Click += new System.EventHandler(this.редагуватиТипиОбладнанняToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.вихідToolStripMenuItem.Text = "&Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копіюватиToolStripMenuItem,
            this.вставToolStripMenuItem,
            this.вирізатиToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "&Правка";
            // 
            // копіюватиToolStripMenuItem
            // 
            this.копіюватиToolStripMenuItem.Name = "копіюватиToolStripMenuItem";
            this.копіюватиToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.копіюватиToolStripMenuItem.Text = "&Копіювати";
            // 
            // вставToolStripMenuItem
            // 
            this.вставToolStripMenuItem.Name = "вставToolStripMenuItem";
            this.вставToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.вставToolStripMenuItem.Text = "&Вставити";
            // 
            // вирізатиToolStripMenuItem
            // 
            this.вирізатиToolStripMenuItem.Name = "вирізатиToolStripMenuItem";
            this.вирізатиToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.вирізатиToolStripMenuItem.Text = "&Вирізати";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.версіяToolStripMenuItem,
            this.розробникиToolStripMenuItem,
            this.ліцензіяToolStripMenuItem});
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "&Про програму";
            // 
            // версіяToolStripMenuItem
            // 
            this.версіяToolStripMenuItem.Name = "версіяToolStripMenuItem";
            this.версіяToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.версіяToolStripMenuItem.Text = "&Версія";
            // 
            // розробникиToolStripMenuItem
            // 
            this.розробникиToolStripMenuItem.Name = "розробникиToolStripMenuItem";
            this.розробникиToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.розробникиToolStripMenuItem.Text = "&Розробники";
            // 
            // ліцензіяToolStripMenuItem
            // 
            this.ліцензіяToolStripMenuItem.Name = "ліцензіяToolStripMenuItem";
            this.ліцензіяToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ліцензіяToolStripMenuItem.Text = "&Ліцензія";
            // 
            // deviceNumberLabel
            // 
            this.deviceNumberLabel.AutoSize = true;
            this.deviceNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceNumberLabel.Location = new System.Drawing.Point(11, 22);
            this.deviceNumberLabel.Name = "deviceNumberLabel";
            this.deviceNumberLabel.Size = new System.Drawing.Size(110, 13);
            this.deviceNumberLabel.TabIndex = 2;
            this.deviceNumberLabel.Text = "Інвентарний номер :";
            // 
            // deviceNumberTextBox
            // 
            this.deviceNumberTextBox.Location = new System.Drawing.Point(127, 19);
            this.deviceNumberTextBox.Name = "deviceNumberTextBox";
            this.deviceNumberTextBox.Size = new System.Drawing.Size(152, 20);
            this.deviceNumberTextBox.TabIndex = 3;
            // 
            // deviceTypeLabel
            // 
            this.deviceTypeLabel.AutoSize = true;
            this.deviceTypeLabel.Location = new System.Drawing.Point(11, 51);
            this.deviceTypeLabel.Name = "deviceTypeLabel";
            this.deviceTypeLabel.Size = new System.Drawing.Size(95, 13);
            this.deviceTypeLabel.TabIndex = 4;
            this.deviceTypeLabel.Text = "Тип обладнання :";
            // 
            // typeSelectionComboBox
            // 
            this.typeSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeSelectionComboBox.FormattingEnabled = true;
            this.typeSelectionComboBox.Location = new System.Drawing.Point(127, 48);
            this.typeSelectionComboBox.Name = "typeSelectionComboBox";
            this.typeSelectionComboBox.Size = new System.Drawing.Size(152, 21);
            this.typeSelectionComboBox.TabIndex = 5;
            this.typeSelectionComboBox.TextChanged += new System.EventHandler(this.typeSelectionComboBox_TextChanged);
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configurationGroupBox.Controls.Add(this.removeSelectedAttrButton);
            this.configurationGroupBox.Controls.Add(this.addNewParameterButton);
            this.configurationGroupBox.Controls.Add(this.addParameterButton);
            this.configurationGroupBox.Controls.Add(this.addParameterComboBox);
            this.configurationGroupBox.Controls.Add(this.addParameterLabel);
            this.configurationGroupBox.Controls.Add(this.configurationDataGridView);
            this.configurationGroupBox.Location = new System.Drawing.Point(6, 237);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(674, 285);
            this.configurationGroupBox.TabIndex = 7;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Конфігурація обладнання";
            // 
            // removeSelectedAttrButton
            // 
            this.removeSelectedAttrButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeSelectedAttrButton.Location = new System.Drawing.Point(215, 240);
            this.removeSelectedAttrButton.Name = "removeSelectedAttrButton";
            this.removeSelectedAttrButton.Size = new System.Drawing.Size(193, 23);
            this.removeSelectedAttrButton.TabIndex = 5;
            this.removeSelectedAttrButton.Text = "Видалити виділений атрибут";
            this.removeSelectedAttrButton.UseVisualStyleBackColor = true;
            this.removeSelectedAttrButton.Click += new System.EventHandler(this.removeSelectedAttrButton_Click);
            // 
            // addNewParameterButton
            // 
            this.addNewParameterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewParameterButton.Location = new System.Drawing.Point(215, 213);
            this.addNewParameterButton.Name = "addNewParameterButton";
            this.addNewParameterButton.Size = new System.Drawing.Size(193, 23);
            this.addNewParameterButton.TabIndex = 4;
            this.addNewParameterButton.Text = "Додати новий атрибут";
            this.addNewParameterButton.UseVisualStyleBackColor = true;
            this.addNewParameterButton.Click += new System.EventHandler(this.addNewParameterButton_Click);
            // 
            // addParameterButton
            // 
            this.addParameterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addParameterButton.Location = new System.Drawing.Point(20, 240);
            this.addParameterButton.Name = "addParameterButton";
            this.addParameterButton.Size = new System.Drawing.Size(189, 23);
            this.addParameterButton.TabIndex = 3;
            this.addParameterButton.Text = "Додати вибраний атрибут";
            this.addParameterButton.UseVisualStyleBackColor = true;
            this.addParameterButton.Click += new System.EventHandler(this.addParameterButton_Click);
            // 
            // addParameterComboBox
            // 
            this.addParameterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addParameterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addParameterComboBox.FormattingEnabled = true;
            this.addParameterComboBox.Location = new System.Drawing.Point(20, 213);
            this.addParameterComboBox.Name = "addParameterComboBox";
            this.addParameterComboBox.Size = new System.Drawing.Size(189, 21);
            this.addParameterComboBox.TabIndex = 2;
            // 
            // addParameterLabel
            // 
            this.addParameterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addParameterLabel.AutoSize = true;
            this.addParameterLabel.Location = new System.Drawing.Point(17, 196);
            this.addParameterLabel.Name = "addParameterLabel";
            this.addParameterLabel.Size = new System.Drawing.Size(93, 13);
            this.addParameterLabel.TabIndex = 1;
            this.addParameterLabel.Text = "Додати атрибут :";
            // 
            // configurationDataGridView
            // 
            this.configurationDataGridView.AllowUserToAddRows = false;
            this.configurationDataGridView.AllowUserToDeleteRows = false;
            this.configurationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configurationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.configurationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.configurationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parameter,
            this.value});
            this.configurationDataGridView.Location = new System.Drawing.Point(7, 19);
            this.configurationDataGridView.Name = "configurationDataGridView";
            this.configurationDataGridView.Size = new System.Drawing.Size(661, 165);
            this.configurationDataGridView.TabIndex = 0;
            // 
            // parameter
            // 
            this.parameter.HeaderText = "Атрибут";
            this.parameter.Name = "parameter";
            this.parameter.ReadOnly = true;
            this.parameter.ToolTipText = "Атрибути притаманні поточному типу обладнання";
            // 
            // value
            // 
            this.value.HeaderText = "Значення";
            this.value.Name = "value";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(6, 194);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(132, 32);
            this.saveChangesButton.TabIndex = 17;
            this.saveChangesButton.Text = "Зберегти зміни";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(11, 94);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(86, 13);
            this.locationLabel.TabIndex = 18;
            this.locationLabel.Text = "Розташування :";
            // 
            // locationComboBox
            // 
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(127, 91);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(152, 21);
            this.locationComboBox.TabIndex = 19;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(11, 123);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(35, 13);
            this.priceLabel.TabIndex = 20;
            this.priceLabel.Text = "Ціна :";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(127, 120);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(152, 20);
            this.priceTextBox.TabIndex = 21;
            // 
            // dateGroupBox
            // 
            this.dateGroupBox.Controls.Add(this.serviceEndTextBox);
            this.dateGroupBox.Controls.Add(this.placementDateTextBox);
            this.dateGroupBox.Controls.Add(this.purchaseDateTextBox);
            this.dateGroupBox.Controls.Add(this.warrantyEndLabel);
            this.dateGroupBox.Controls.Add(this.placementDateLabel);
            this.dateGroupBox.Controls.Add(this.purchaseDateLabel);
            this.dateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateGroupBox.Location = new System.Drawing.Point(308, 33);
            this.dateGroupBox.Name = "dateGroupBox";
            this.dateGroupBox.Size = new System.Drawing.Size(302, 101);
            this.dateGroupBox.TabIndex = 22;
            this.dateGroupBox.TabStop = false;
            this.dateGroupBox.Text = "Дата";
            // 
            // serviceEndTextBox
            // 
            this.serviceEndTextBox.Location = new System.Drawing.Point(197, 66);
            this.serviceEndTextBox.Mask = "00/00/0000";
            this.serviceEndTextBox.Name = "serviceEndTextBox";
            this.serviceEndTextBox.Size = new System.Drawing.Size(88, 20);
            this.serviceEndTextBox.TabIndex = 5;
            this.serviceEndTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // placementDateTextBox
            // 
            this.placementDateTextBox.Location = new System.Drawing.Point(197, 44);
            this.placementDateTextBox.Mask = "00/00/0000";
            this.placementDateTextBox.Name = "placementDateTextBox";
            this.placementDateTextBox.Size = new System.Drawing.Size(88, 20);
            this.placementDateTextBox.TabIndex = 4;
            this.placementDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // purchaseDateTextBox
            // 
            this.purchaseDateTextBox.Location = new System.Drawing.Point(197, 22);
            this.purchaseDateTextBox.Mask = "00/00/0000";
            this.purchaseDateTextBox.Name = "purchaseDateTextBox";
            this.purchaseDateTextBox.Size = new System.Drawing.Size(88, 20);
            this.purchaseDateTextBox.TabIndex = 3;
            this.purchaseDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // warrantyEndLabel
            // 
            this.warrantyEndLabel.AutoSize = true;
            this.warrantyEndLabel.Location = new System.Drawing.Point(17, 69);
            this.warrantyEndLabel.Name = "warrantyEndLabel";
            this.warrantyEndLabel.Size = new System.Drawing.Size(172, 13);
            this.warrantyEndLabel.TabIndex = 2;
            this.warrantyEndLabel.Text = "Кінець гарантії обслуговування :";
            // 
            // placementDateLabel
            // 
            this.placementDateLabel.AutoSize = true;
            this.placementDateLabel.Location = new System.Drawing.Point(17, 47);
            this.placementDateLabel.Name = "placementDateLabel";
            this.placementDateLabel.Size = new System.Drawing.Size(103, 13);
            this.placementDateLabel.TabIndex = 1;
            this.placementDateLabel.Text = "Дата розміщення :";
            // 
            // purchaseDateLabel
            // 
            this.purchaseDateLabel.AutoSize = true;
            this.purchaseDateLabel.Location = new System.Drawing.Point(17, 25);
            this.purchaseDateLabel.Name = "purchaseDateLabel";
            this.purchaseDateLabel.Size = new System.Drawing.Size(83, 13);
            this.purchaseDateLabel.TabIndex = 0;
            this.purchaseDateLabel.Text = "Дата покупки :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.deviceNumberLabel);
            this.groupBox1.Controls.Add(this.deviceNumberTextBox);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.deviceTypeLabel);
            this.groupBox1.Controls.Add(this.locationComboBox);
            this.groupBox1.Controls.Add(this.typeSelectionComboBox);
            this.groupBox1.Controls.Add(this.locationLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 155);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальна інформація";
            // 
            // AddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateGroupBox);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.configurationGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AddDevice";
            this.Text = "Додання нового обладнання";
            this.Load += new System.EventHandler(this.AddDevice_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.configurationGroupBox.ResumeLayout(false);
            this.configurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationDataGridView)).EndInit();
            this.dateGroupBox.ResumeLayout(false);
            this.dateGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новийФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копіюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вирізатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem версіяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розробникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ліцензіяToolStripMenuItem;
        private System.Windows.Forms.Label deviceNumberLabel;
        private System.Windows.Forms.TextBox deviceNumberTextBox;
        private System.Windows.Forms.Label deviceTypeLabel;
        private System.Windows.Forms.ComboBox typeSelectionComboBox;
        private System.Windows.Forms.GroupBox configurationGroupBox;
        private System.Windows.Forms.DataGridView configurationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Button addParameterButton;
        private System.Windows.Forms.ComboBox addParameterComboBox;
        private System.Windows.Forms.Label addParameterLabel;
        private System.Windows.Forms.Button addNewParameterButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.ToolStripMenuItem редагуватиТипиОбладнанняToolStripMenuItem;
        private System.Windows.Forms.Button removeSelectedAttrButton;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.GroupBox dateGroupBox;
        private System.Windows.Forms.Label warrantyEndLabel;
        private System.Windows.Forms.Label placementDateLabel;
        private System.Windows.Forms.Label purchaseDateLabel;
        private System.Windows.Forms.MaskedTextBox serviceEndTextBox;
        private System.Windows.Forms.MaskedTextBox placementDateTextBox;
        private System.Windows.Forms.MaskedTextBox purchaseDateTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}