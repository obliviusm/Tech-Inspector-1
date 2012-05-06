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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.removeTypeButton = new System.Windows.Forms.Button();
            this.attributesDataGridView = new System.Windows.Forms.DataGridView();
            this.attributeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.attributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_inspectorDataSet = new lol2.tech_inspectorDataSet();
            this.abortChangesButton = new System.Windows.Forms.Button();
            this.typeNameTextBox = new System.Windows.Forms.TextBox();
            this.parametersLabel = new System.Windows.Forms.Label();
            this.typeNameLabel = new System.Windows.Forms.Label();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.typeSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.newTypeButton = new System.Windows.Forms.Button();
            this.chooseTypeButton = new System.Windows.Forms.Button();
            this.typeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.typesTableAdapter();
            this.attributesTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.attributesTableAdapter();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиТипToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.configurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attributesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).BeginInit();
            this.typeSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.видалитиТипToolStripMenuItem,
            this.toolStripMenuItem1,
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
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.closeToolStripMenuItem.Text = "Закрити вікно";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
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
            // configurationGroupBox
            // 
            this.configurationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configurationGroupBox.Controls.Add(this.removeTypeButton);
            this.configurationGroupBox.Controls.Add(this.attributesDataGridView);
            this.configurationGroupBox.Controls.Add(this.abortChangesButton);
            this.configurationGroupBox.Controls.Add(this.typeNameTextBox);
            this.configurationGroupBox.Controls.Add(this.parametersLabel);
            this.configurationGroupBox.Controls.Add(this.typeNameLabel);
            this.configurationGroupBox.Controls.Add(this.saveChangesButton);
            this.configurationGroupBox.Location = new System.Drawing.Point(6, 91);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(595, 441);
            this.configurationGroupBox.TabIndex = 15;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Параметри типу";
            // 
            // removeTypeButton
            // 
            this.removeTypeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeTypeButton.BackColor = System.Drawing.Color.Coral;
            this.removeTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTypeButton.Location = new System.Drawing.Point(285, 403);
            this.removeTypeButton.Name = "removeTypeButton";
            this.removeTypeButton.Size = new System.Drawing.Size(135, 32);
            this.removeTypeButton.TabIndex = 18;
            this.removeTypeButton.Text = "Видалити тип";
            this.removeTypeButton.UseVisualStyleBackColor = false;
            this.removeTypeButton.Click += new System.EventHandler(this.removeTypeButton_Click);
            // 
            // attributesDataGridView
            // 
            this.attributesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attributesDataGridView.AutoGenerateColumns = false;
            this.attributesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attributesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attributesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attributeidDataGridViewTextBoxColumn,
            this.typeidDataGridViewTextBoxColumn,
            this.attributenameDataGridViewTextBoxColumn,
            this.requiredDataGridViewCheckBoxColumn});
            this.attributesDataGridView.DataSource = this.attributesBindingSource;
            this.attributesDataGridView.Location = new System.Drawing.Point(8, 63);
            this.attributesDataGridView.Name = "attributesDataGridView";
            this.attributesDataGridView.Size = new System.Drawing.Size(582, 334);
            this.attributesDataGridView.TabIndex = 20;
            // 
            // attributeidDataGridViewTextBoxColumn
            // 
            this.attributeidDataGridViewTextBoxColumn.DataPropertyName = "attribute_id";
            this.attributeidDataGridViewTextBoxColumn.HeaderText = "attribute_id";
            this.attributeidDataGridViewTextBoxColumn.Name = "attributeidDataGridViewTextBoxColumn";
            this.attributeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeidDataGridViewTextBoxColumn
            // 
            this.typeidDataGridViewTextBoxColumn.DataPropertyName = "type_id";
            this.typeidDataGridViewTextBoxColumn.HeaderText = "type_id";
            this.typeidDataGridViewTextBoxColumn.Name = "typeidDataGridViewTextBoxColumn";
            this.typeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // attributenameDataGridViewTextBoxColumn
            // 
            this.attributenameDataGridViewTextBoxColumn.DataPropertyName = "attribute_name";
            this.attributenameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.attributenameDataGridViewTextBoxColumn.Name = "attributenameDataGridViewTextBoxColumn";
            // 
            // requiredDataGridViewCheckBoxColumn
            // 
            this.requiredDataGridViewCheckBoxColumn.DataPropertyName = "required";
            this.requiredDataGridViewCheckBoxColumn.HeaderText = "Обовз\'язковий?";
            this.requiredDataGridViewCheckBoxColumn.Name = "requiredDataGridViewCheckBoxColumn";
            // 
            // attributesBindingSource
            // 
            this.attributesBindingSource.DataMember = "attributes";
            this.attributesBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // tech_inspectorDataSet
            // 
            this.tech_inspectorDataSet.DataSetName = "tech_inspectorDataSet";
            this.tech_inspectorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abortChangesButton
            // 
            this.abortChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.abortChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.abortChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abortChangesButton.Location = new System.Drawing.Point(144, 403);
            this.abortChangesButton.Name = "abortChangesButton";
            this.abortChangesButton.Size = new System.Drawing.Size(135, 32);
            this.abortChangesButton.TabIndex = 17;
            this.abortChangesButton.Text = "Відхилити зміни";
            this.abortChangesButton.UseVisualStyleBackColor = false;
            this.abortChangesButton.Click += new System.EventHandler(this.abortChangesButton_Click);
            // 
            // typeNameTextBox
            // 
            this.typeNameTextBox.Location = new System.Drawing.Point(87, 22);
            this.typeNameTextBox.Name = "typeNameTextBox";
            this.typeNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.typeNameTextBox.TabIndex = 19;
            // 
            // parametersLabel
            // 
            this.parametersLabel.AutoSize = true;
            this.parametersLabel.Location = new System.Drawing.Point(11, 47);
            this.parametersLabel.Name = "parametersLabel";
            this.parametersLabel.Size = new System.Drawing.Size(59, 13);
            this.parametersLabel.TabIndex = 18;
            this.parametersLabel.Text = "Атрибути :";
            // 
            // typeNameLabel
            // 
            this.typeNameLabel.AutoSize = true;
            this.typeNameLabel.Location = new System.Drawing.Point(11, 25);
            this.typeNameLabel.Name = "typeNameLabel";
            this.typeNameLabel.Size = new System.Drawing.Size(70, 13);
            this.typeNameLabel.TabIndex = 17;
            this.typeNameLabel.Text = "Назва типу :";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(6, 403);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(132, 32);
            this.saveChangesButton.TabIndex = 16;
            this.saveChangesButton.Text = "Зберегти зміни";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // typeSelectionGroupBox
            // 
            this.typeSelectionGroupBox.Controls.Add(this.newTypeButton);
            this.typeSelectionGroupBox.Controls.Add(this.chooseTypeButton);
            this.typeSelectionGroupBox.Controls.Add(this.typeSelectionComboBox);
            this.typeSelectionGroupBox.Location = new System.Drawing.Point(6, 28);
            this.typeSelectionGroupBox.Name = "typeSelectionGroupBox";
            this.typeSelectionGroupBox.Size = new System.Drawing.Size(595, 57);
            this.typeSelectionGroupBox.TabIndex = 16;
            this.typeSelectionGroupBox.TabStop = false;
            this.typeSelectionGroupBox.Text = "Вибір типу";
            // 
            // newTypeButton
            // 
            this.newTypeButton.Location = new System.Drawing.Point(293, 20);
            this.newTypeButton.Name = "newTypeButton";
            this.newTypeButton.Size = new System.Drawing.Size(115, 23);
            this.newTypeButton.TabIndex = 2;
            this.newTypeButton.Text = "Створити новий тип";
            this.newTypeButton.UseVisualStyleBackColor = true;
            this.newTypeButton.Click += new System.EventHandler(this.newTypeButton_Click);
            // 
            // chooseTypeButton
            // 
            this.chooseTypeButton.Location = new System.Drawing.Point(172, 20);
            this.chooseTypeButton.Name = "chooseTypeButton";
            this.chooseTypeButton.Size = new System.Drawing.Size(115, 23);
            this.chooseTypeButton.TabIndex = 1;
            this.chooseTypeButton.Text = "Вибрати";
            this.chooseTypeButton.UseVisualStyleBackColor = true;
            this.chooseTypeButton.Click += new System.EventHandler(this.chooseTypeButton_Click);
            // 
            // typeSelectionComboBox
            // 
            this.typeSelectionComboBox.DataSource = this.typesBindingSource;
            this.typeSelectionComboBox.DisplayMember = "type_name";
            this.typeSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeSelectionComboBox.FormattingEnabled = true;
            this.typeSelectionComboBox.Location = new System.Drawing.Point(7, 20);
            this.typeSelectionComboBox.Name = "typeSelectionComboBox";
            this.typeSelectionComboBox.Size = new System.Drawing.Size(146, 21);
            this.typeSelectionComboBox.TabIndex = 0;
            this.typeSelectionComboBox.ValueMember = "type_id";
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "types";
            this.typesBindingSource.DataSource = this.tech_inspectorDataSet;
            this.typesBindingSource.Sort = "type_id";
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // attributesTableAdapter
            // 
            this.attributesTableAdapter.ClearBeforeFill = true;
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.createNewToolStripMenuItem.Text = "Створити новий тип";
            this.createNewToolStripMenuItem.Click += new System.EventHandler(this.createNewToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.saveToolStripMenuItem.Text = "Зберегти зміни";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.cancelToolStripMenuItem.Text = "Відхилити зміни";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // видалитиТипToolStripMenuItem
            // 
            this.видалитиТипToolStripMenuItem.Name = "видалитиТипToolStripMenuItem";
            this.видалитиТипToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.видалитиТипToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.видалитиТипToolStripMenuItem.Text = "Видалити тип";
            this.видалитиТипToolStripMenuItem.Click += new System.EventHandler(this.видалитиТипToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 6);
            // 
            // DeviceTemplateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 544);
            this.Controls.Add(this.typeSelectionGroupBox);
            this.Controls.Add(this.configurationGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(624, 583);
            this.Name = "DeviceTemplateEditor";
            this.Text = "Редактор шаблонів обладнання";
            this.Load += new System.EventHandler(this.DeviceTemplateEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.configurationGroupBox.ResumeLayout(false);
            this.configurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attributesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).EndInit();
            this.typeSelectionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox configurationGroupBox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.GroupBox typeSelectionGroupBox;
        private System.Windows.Forms.Button newTypeButton;
        private System.Windows.Forms.Button chooseTypeButton;
        private System.Windows.Forms.ComboBox typeSelectionComboBox;
        private System.Windows.Forms.Label typeNameLabel;
        private System.Windows.Forms.TextBox typeNameTextBox;
        private System.Windows.Forms.Label parametersLabel;
        private System.Windows.Forms.Button abortChangesButton;
        private System.Windows.Forms.Button removeTypeButton;
        private System.Windows.Forms.DataGridView attributesDataGridView;
        private tech_inspectorDataSet tech_inspectorDataSet;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private tech_inspectorDataSetTableAdapters.typesTableAdapter typesTableAdapter;
        private System.Windows.Forms.BindingSource attributesBindingSource;
        private tech_inspectorDataSetTableAdapters.attributesTableAdapter attributesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn requiredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиТипToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}