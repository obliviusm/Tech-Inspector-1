namespace lol2
{
    partial class DeviceTemplateEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копіюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вирізатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.версіяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розробникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ліцензіяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.deviceTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.okEditButton = new System.Windows.Forms.Button();
            this.okNewButton = new System.Windows.Forms.Button();
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.addNewParameterButton = new System.Windows.Forms.Button();
            this.addParameterButton = new System.Windows.Forms.Button();
            this.addParameterComboBox = new System.Windows.Forms.ComboBox();
            this.addParameterLabel = new System.Windows.Forms.Label();
            this.configurationDataGridView = new System.Windows.Forms.DataGridView();
            this.parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveChangesButton = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.вихідToolStripMenuItem.Text = "&Вихід";
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
            this.копіюватиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.копіюватиToolStripMenuItem.Text = "&Копіювати";
            // 
            // вставToolStripMenuItem
            // 
            this.вставToolStripMenuItem.Name = "вставToolStripMenuItem";
            this.вставToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.вставToolStripMenuItem.Text = "&Вставити";
            // 
            // вирізатиToolStripMenuItem
            // 
            this.вирізатиToolStripMenuItem.Name = "вирізатиToolStripMenuItem";
            this.вирізатиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.версіяToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.версіяToolStripMenuItem.Text = "&Версія";
            // 
            // розробникиToolStripMenuItem
            // 
            this.розробникиToolStripMenuItem.Name = "розробникиToolStripMenuItem";
            this.розробникиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.розробникиToolStripMenuItem.Text = "&Розробники";
            // 
            // ліцензіяToolStripMenuItem
            // 
            this.ліцензіяToolStripMenuItem.Name = "ліцензіяToolStripMenuItem";
            this.ліцензіяToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ліцензіяToolStripMenuItem.Text = "&Ліцензія";
            // 
            // typeSelectionComboBox
            // 
            this.typeSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeSelectionComboBox.FormattingEnabled = true;
            this.typeSelectionComboBox.Items.AddRange(new object[] {
            "Комп\'ютер",
            "Принтер",
            "Проектор",
            "Інше"});
            this.typeSelectionComboBox.Location = new System.Drawing.Point(143, 38);
            this.typeSelectionComboBox.Name = "typeSelectionComboBox";
            this.typeSelectionComboBox.Size = new System.Drawing.Size(178, 21);
            this.typeSelectionComboBox.TabIndex = 10;
            // 
            // deviceTypeLabel
            // 
            this.deviceTypeLabel.AutoSize = true;
            this.deviceTypeLabel.Location = new System.Drawing.Point(19, 41);
            this.deviceTypeLabel.Name = "deviceTypeLabel";
            this.deviceTypeLabel.Size = new System.Drawing.Size(118, 13);
            this.deviceTypeLabel.TabIndex = 9;
            this.deviceTypeLabel.Text = "Редагувати існуючий :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Створити новий :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 12;
            // 
            // okEditButton
            // 
            this.okEditButton.Location = new System.Drawing.Point(327, 36);
            this.okEditButton.Name = "okEditButton";
            this.okEditButton.Size = new System.Drawing.Size(75, 23);
            this.okEditButton.TabIndex = 13;
            this.okEditButton.Text = "OK";
            this.okEditButton.UseVisualStyleBackColor = true;
            // 
            // okNewButton
            // 
            this.okNewButton.Location = new System.Drawing.Point(327, 65);
            this.okNewButton.Name = "okNewButton";
            this.okNewButton.Size = new System.Drawing.Size(75, 23);
            this.okNewButton.TabIndex = 14;
            this.okNewButton.Text = "OK";
            this.okNewButton.UseVisualStyleBackColor = true;
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configurationGroupBox.Controls.Add(this.addNewParameterButton);
            this.configurationGroupBox.Controls.Add(this.addParameterButton);
            this.configurationGroupBox.Controls.Add(this.addParameterComboBox);
            this.configurationGroupBox.Controls.Add(this.addParameterLabel);
            this.configurationGroupBox.Controls.Add(this.configurationDataGridView);
            this.configurationGroupBox.Location = new System.Drawing.Point(6, 108);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(595, 352);
            this.configurationGroupBox.TabIndex = 15;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Конфігурація обладнання";
            // 
            // addNewParameterButton
            // 
            this.addNewParameterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewParameterButton.Location = new System.Drawing.Point(332, 312);
            this.addNewParameterButton.Name = "addNewParameterButton";
            this.addNewParameterButton.Size = new System.Drawing.Size(111, 23);
            this.addNewParameterButton.TabIndex = 4;
            this.addNewParameterButton.Text = "Додати новий тип";
            this.addNewParameterButton.UseVisualStyleBackColor = true;
            this.addNewParameterButton.Click += new System.EventHandler(this.addNewParameterButton_Click);
            // 
            // addParameterButton
            // 
            this.addParameterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addParameterButton.Location = new System.Drawing.Point(227, 312);
            this.addParameterButton.Name = "addParameterButton";
            this.addParameterButton.Size = new System.Drawing.Size(98, 23);
            this.addParameterButton.TabIndex = 3;
            this.addParameterButton.Text = "Додати";
            this.addParameterButton.UseVisualStyleBackColor = true;
            this.addParameterButton.Click += new System.EventHandler(this.addParameterButton_Click);
            // 
            // addParameterComboBox
            // 
            this.addParameterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addParameterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addParameterComboBox.FormattingEnabled = true;
            this.addParameterComboBox.Location = new System.Drawing.Point(20, 312);
            this.addParameterComboBox.Name = "addParameterComboBox";
            this.addParameterComboBox.Size = new System.Drawing.Size(189, 21);
            this.addParameterComboBox.TabIndex = 2;
            // 
            // addParameterLabel
            // 
            this.addParameterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addParameterLabel.AutoSize = true;
            this.addParameterLabel.Location = new System.Drawing.Point(17, 295);
            this.addParameterLabel.Name = "addParameterLabel";
            this.addParameterLabel.Size = new System.Drawing.Size(93, 13);
            this.addParameterLabel.TabIndex = 1;
            this.addParameterLabel.Text = "Додати атрибут :";
            // 
            // configurationDataGridView
            // 
            this.configurationDataGridView.AllowUserToDeleteRows = false;
            this.configurationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.configurationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.configurationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.configurationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parameter,
            this.value});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.configurationDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.configurationDataGridView.Location = new System.Drawing.Point(7, 20);
            this.configurationDataGridView.Name = "configurationDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.configurationDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.configurationDataGridView.Size = new System.Drawing.Size(582, 263);
            this.configurationDataGridView.TabIndex = 0;
            // 
            // parameter
            // 
            this.parameter.HeaderText = "Атрибут";
            this.parameter.Name = "parameter";
            this.parameter.ToolTipText = "Атрибути притаманні поточному типу обладнання";
            // 
            // value
            // 
            this.value.HeaderText = "Регулярний вираз атрибуту";
            this.value.Name = "value";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(469, 56);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(132, 32);
            this.saveChangesButton.TabIndex = 16;
            this.saveChangesButton.Text = "Зберегти зміни";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // DeviceTemplateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 465);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.configurationGroupBox);
            this.Controls.Add(this.okNewButton);
            this.Controls.Add(this.okEditButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeSelectionComboBox);
            this.Controls.Add(this.deviceTypeLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DeviceTemplateEditor";
            this.Text = "Редактор шаблонів обладнання";
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
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копіюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вирізатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem версіяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розробникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ліцензіяToolStripMenuItem;
        private System.Windows.Forms.ComboBox typeSelectionComboBox;
        private System.Windows.Forms.Label deviceTypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button okEditButton;
        private System.Windows.Forms.Button okNewButton;
        private System.Windows.Forms.GroupBox configurationGroupBox;
        private System.Windows.Forms.Button addNewParameterButton;
        private System.Windows.Forms.Button addParameterButton;
        private System.Windows.Forms.ComboBox addParameterComboBox;
        private System.Windows.Forms.Label addParameterLabel;
        private System.Windows.Forms.DataGridView configurationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Button saveChangesButton;
    }
}