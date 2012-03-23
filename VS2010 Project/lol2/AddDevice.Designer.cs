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
            this.addNewParameterButton = new System.Windows.Forms.Button();
            this.addParameterButton = new System.Windows.Forms.Button();
            this.addParameterComboBox = new System.Windows.Forms.ComboBox();
            this.addParameterLabel = new System.Windows.Forms.Label();
            this.configurationDataGridView = new System.Windows.Forms.DataGridView();
            this.parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.редагуватиТипиОбладнанняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedAttrButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.configurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationDataGridView)).BeginInit();
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
            this.deviceNumberLabel.Location = new System.Drawing.Point(23, 36);
            this.deviceNumberLabel.Name = "deviceNumberLabel";
            this.deviceNumberLabel.Size = new System.Drawing.Size(110, 13);
            this.deviceNumberLabel.TabIndex = 2;
            this.deviceNumberLabel.Text = "Інвентарний номер :";
            // 
            // deviceNumberTextBox
            // 
            this.deviceNumberTextBox.Location = new System.Drawing.Point(139, 36);
            this.deviceNumberTextBox.Name = "deviceNumberTextBox";
            this.deviceNumberTextBox.Size = new System.Drawing.Size(152, 20);
            this.deviceNumberTextBox.TabIndex = 3;
            // 
            // deviceTypeLabel
            // 
            this.deviceTypeLabel.AutoSize = true;
            this.deviceTypeLabel.Location = new System.Drawing.Point(23, 65);
            this.deviceTypeLabel.Name = "deviceTypeLabel";
            this.deviceTypeLabel.Size = new System.Drawing.Size(95, 13);
            this.deviceTypeLabel.TabIndex = 4;
            this.deviceTypeLabel.Text = "Тип обладнання :";
            // 
            // typeSelectionComboBox
            // 
            this.typeSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeSelectionComboBox.FormattingEnabled = true;
            this.typeSelectionComboBox.Location = new System.Drawing.Point(139, 63);
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
            this.configurationGroupBox.Location = new System.Drawing.Point(6, 89);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(674, 417);
            this.configurationGroupBox.TabIndex = 7;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Конфігурація обладнання";
            // 
            // addNewParameterButton
            // 
            this.addNewParameterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewParameterButton.Location = new System.Drawing.Point(215, 345);
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
            this.addParameterButton.Location = new System.Drawing.Point(20, 372);
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
            this.addParameterComboBox.Location = new System.Drawing.Point(20, 345);
            this.addParameterComboBox.Name = "addParameterComboBox";
            this.addParameterComboBox.Size = new System.Drawing.Size(189, 21);
            this.addParameterComboBox.TabIndex = 2;
            // 
            // addParameterLabel
            // 
            this.addParameterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addParameterLabel.AutoSize = true;
            this.addParameterLabel.Location = new System.Drawing.Point(17, 328);
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
            this.configurationDataGridView.Location = new System.Drawing.Point(7, 53);
            this.configurationDataGridView.Name = "configurationDataGridView";
            this.configurationDataGridView.Size = new System.Drawing.Size(661, 263);
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
            this.saveChangesButton.Location = new System.Drawing.Point(542, 51);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(132, 32);
            this.saveChangesButton.TabIndex = 17;
            this.saveChangesButton.Text = "Зберегти зміни";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            // 
            // редагуватиТипиОбладнанняToolStripMenuItem
            // 
            this.редагуватиТипиОбладнанняToolStripMenuItem.Name = "редагуватиТипиОбладнанняToolStripMenuItem";
            this.редагуватиТипиОбладнанняToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.редагуватиТипиОбладнанняToolStripMenuItem.Text = "Редаг&увати типи обладнання";
            this.редагуватиТипиОбладнанняToolStripMenuItem.Click += new System.EventHandler(this.редагуватиТипиОбладнанняToolStripMenuItem_Click);
            // 
            // removeSelectedAttrButton
            // 
            this.removeSelectedAttrButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeSelectedAttrButton.Location = new System.Drawing.Point(215, 374);
            this.removeSelectedAttrButton.Name = "removeSelectedAttrButton";
            this.removeSelectedAttrButton.Size = new System.Drawing.Size(193, 23);
            this.removeSelectedAttrButton.TabIndex = 5;
            this.removeSelectedAttrButton.Text = "Видалити виділений атрибут";
            this.removeSelectedAttrButton.UseVisualStyleBackColor = true;
            // 
            // AddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 512);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.configurationGroupBox);
            this.Controls.Add(this.typeSelectionComboBox);
            this.Controls.Add(this.deviceTypeLabel);
            this.Controls.Add(this.deviceNumberTextBox);
            this.Controls.Add(this.deviceNumberLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AddDevice";
            this.Text = "Додання нового обладнання";
            this.Load += new System.EventHandler(this.AddDevice_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.configurationGroupBox.ResumeLayout(false);
            this.configurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationDataGridView)).EndInit();
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
    }
}