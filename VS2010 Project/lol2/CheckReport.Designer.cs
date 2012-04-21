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
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.responsibleLabel = new System.Windows.Forms.Label();
            this.responsibleTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.locationsTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.locationsTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.generalInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveChangesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeWindowToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // saveChangesToolStripMenuItem
            // 
            this.saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
            this.saveChangesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveChangesToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.saveChangesToolStripMenuItem.Text = "Зберегти протокол";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 6);
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.closeWindowToolStripMenuItem.Text = "Закрити вікно";
            this.closeWindowToolStripMenuItem.Click += new System.EventHandler(this.closeWindowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
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
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.copyToolStripMenuItem.Text = "Копіювати";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cutToolStripMenuItem.Text = "Вирізати";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.pasteToolStripMenuItem.Text = "Вставити";
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
            // 
            // версіяToolStripMenuItem
            // 
            this.версіяToolStripMenuItem.Name = "версіяToolStripMenuItem";
            this.версіяToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.версіяToolStripMenuItem.Text = "Версія";
            // 
            // розробникиToolStripMenuItem
            // 
            this.розробникиToolStripMenuItem.Name = "розробникиToolStripMenuItem";
            this.розробникиToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.розробникиToolStripMenuItem.Text = "Розробники";
            // 
            // generalInformationGroupBox
            // 
            this.generalInformationGroupBox.Controls.Add(this.startCheckButton);
            this.generalInformationGroupBox.Controls.Add(this.locationComboBox);
            this.generalInformationGroupBox.Controls.Add(this.locationLabel);
            this.generalInformationGroupBox.Controls.Add(this.endTimeDateTimePicker);
            this.generalInformationGroupBox.Controls.Add(this.endTimeLabel);
            this.generalInformationGroupBox.Controls.Add(this.startTimeDateTimePicker);
            this.generalInformationGroupBox.Controls.Add(this.startTimeLabel);
            this.generalInformationGroupBox.Controls.Add(this.responsibleLabel);
            this.generalInformationGroupBox.Controls.Add(this.responsibleTextBox);
            this.generalInformationGroupBox.Location = new System.Drawing.Point(12, 36);
            this.generalInformationGroupBox.Name = "generalInformationGroupBox";
            this.generalInformationGroupBox.Size = new System.Drawing.Size(205, 246);
            this.generalInformationGroupBox.TabIndex = 4;
            this.generalInformationGroupBox.TabStop = false;
            this.generalInformationGroupBox.Text = "Загальна інформація";
            // 
            // startCheckButton
            // 
            this.startCheckButton.Location = new System.Drawing.Point(6, 201);
            this.startCheckButton.Name = "startCheckButton";
            this.startCheckButton.Size = new System.Drawing.Size(189, 30);
            this.startCheckButton.TabIndex = 8;
            this.startCheckButton.Text = "Розпочати ";
            this.startCheckButton.UseVisualStyleBackColor = true;
            // 
            // locationComboBox
            // 
            this.locationComboBox.DataSource = this.locationsBindingSource;
            this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationComboBox.DisplayMember = "location_name";
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(6, 173);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(189, 21);
            this.locationComboBox.TabIndex = 7;
            this.locationComboBox.ValueMember = "location_name";
            this.locationComboBox.SelectedIndexChanged += new System.EventHandler(this.locationComboBox_SelectedIndexChanged);
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
            this.locationLabel.Location = new System.Drawing.Point(10, 157);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(62, 13);
            this.locationLabel.TabIndex = 6;
            this.locationLabel.Text = "Аудиторія :";
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(6, 134);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(189, 20);
            this.endTimeDateTimePicker.TabIndex = 5;
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(10, 118);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(98, 13);
            this.endTimeLabel.TabIndex = 4;
            this.endTimeLabel.Text = "Час завершення :";
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(6, 86);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(189, 20);
            this.startTimeDateTimePicker.TabIndex = 3;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(10, 70);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(75, 13);
            this.startTimeLabel.TabIndex = 2;
            this.startTimeLabel.Text = "Час початку :";
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(223, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 443);
            this.dataGridView1.TabIndex = 5;
            // 
            // locationsTableAdapter
            // 
            this.locationsTableAdapter.ClearBeforeFill = true;
            // 
            // CheckReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.generalInformationGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "CheckReport";
            this.Text = "Протокол по профілактиці";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CheckReport_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.generalInformationGroupBox.ResumeLayout(false);
            this.generalInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Button startCheckButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tech_inspectorDataSet tech_inspectorDataSet;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private tech_inspectorDataSetTableAdapters.locationsTableAdapter locationsTableAdapter;
    }
}