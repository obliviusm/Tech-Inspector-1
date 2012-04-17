﻿namespace lol2
{
    partial class PreventionCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreventionCalendar));
            this.planTable = new System.Windows.Forms.DataGridView();
            this.location_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsibleadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prophylaxisdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techinspectorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_inspectorDataSet = new lol2.tech_inspectorDataSet();
            this.blockInput = new System.Windows.Forms.CheckBox();
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
            this.lockPictureBox = new System.Windows.Forms.PictureBox();
            this.saveChanges = new System.Windows.Forms.Button();
            this.locationsTableAdapter1 = new lol2.tech_inspectorDataSetTableAdapters.locationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.planTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techinspectorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // planTable
            // 
            this.planTable.AllowUserToAddRows = false;
            this.planTable.AllowUserToDeleteRows = false;
            this.planTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planTable.AutoGenerateColumns = false;
            this.planTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.planTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.location_name,
            this.responsibleadminDataGridViewTextBoxColumn,
            this.prophylaxisdateDataGridViewTextBoxColumn});
            this.planTable.DataSource = this.locationsBindingSource;
            this.planTable.Location = new System.Drawing.Point(1, 63);
            this.planTable.Name = "planTable";
            this.planTable.ReadOnly = true;
            this.planTable.Size = new System.Drawing.Size(732, 397);
            this.planTable.TabIndex = 0;
            this.planTable.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.planTable_CellBeginEdit);
            this.planTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.planTable_CellEndEdit);
            // 
            // location_name
            // 
            this.location_name.DataPropertyName = "location_name";
            this.location_name.HeaderText = "Аудиторія";
            this.location_name.Name = "location_name";
            this.location_name.ReadOnly = true;
            // 
            // responsibleadminDataGridViewTextBoxColumn
            // 
            this.responsibleadminDataGridViewTextBoxColumn.DataPropertyName = "responsible_admin";
            this.responsibleadminDataGridViewTextBoxColumn.HeaderText = "Відповідальний";
            this.responsibleadminDataGridViewTextBoxColumn.Name = "responsibleadminDataGridViewTextBoxColumn";
            this.responsibleadminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prophylaxisdateDataGridViewTextBoxColumn
            // 
            this.prophylaxisdateDataGridViewTextBoxColumn.DataPropertyName = "prophylaxis_date";
            this.prophylaxisdateDataGridViewTextBoxColumn.HeaderText = "Дата профілактики";
            this.prophylaxisdateDataGridViewTextBoxColumn.Name = "prophylaxisdateDataGridViewTextBoxColumn";
            this.prophylaxisdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "locations";
            this.locationsBindingSource.DataSource = this.techinspectorDataSetBindingSource;
            // 
            // techinspectorDataSetBindingSource
            // 
            this.techinspectorDataSetBindingSource.DataSource = this.tech_inspectorDataSet;
            this.techinspectorDataSetBindingSource.Position = 0;
            // 
            // tech_inspectorDataSet
            // 
            this.tech_inspectorDataSet.DataSetName = "tech_inspectorDataSet";
            this.tech_inspectorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blockInput
            // 
            this.blockInput.AutoSize = true;
            this.blockInput.Checked = true;
            this.blockInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blockInput.Location = new System.Drawing.Point(52, 40);
            this.blockInput.Name = "blockInput";
            this.blockInput.Size = new System.Drawing.Size(114, 17);
            this.blockInput.TabIndex = 1;
            this.blockInput.Text = "Заблокувати ввід";
            this.blockInput.UseVisualStyleBackColor = true;
            this.blockInput.CheckedChanged += new System.EventHandler(this.blockInput_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.saveChangesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.saveChangesToolStripMenuItem.Text = "Зберегти зміни";
            this.saveChangesToolStripMenuItem.Click += new System.EventHandler(this.saveChangesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 6);
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.closeWindowToolStripMenuItem.Text = "Закрити вікно";
            this.closeWindowToolStripMenuItem.Click += new System.EventHandler(this.closeWindowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
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
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cutToolStripMenuItem.Text = "Вирізати";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
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
            // lockPictureBox
            // 
            this.lockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("lockPictureBox.Image")));
            this.lockPictureBox.Location = new System.Drawing.Point(20, 27);
            this.lockPictureBox.Name = "lockPictureBox";
            this.lockPictureBox.Size = new System.Drawing.Size(30, 30);
            this.lockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lockPictureBox.TabIndex = 3;
            this.lockPictureBox.TabStop = false;
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(172, 27);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(120, 30);
            this.saveChanges.TabIndex = 4;
            this.saveChanges.Text = "Зберегти зміни";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // locationsTableAdapter1
            // 
            this.locationsTableAdapter1.ClearBeforeFill = true;
            // 
            // PreventionCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.lockPictureBox);
            this.Controls.Add(this.blockInput);
            this.Controls.Add(this.planTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "PreventionCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Розклад профілактик";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreventionCalendar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.planTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techinspectorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView planTable;
        private System.Windows.Forms.CheckBox blockInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem версіяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розробникиToolStripMenuItem;
        private System.Windows.Forms.PictureBox lockPictureBox;
        private tech_inspectorDataSet tech_inspectorDataSet;
        private System.Windows.Forms.BindingSource techinspectorDataSetBindingSource;
        private tech_inspectorDataSetTableAdapters.locationsTableAdapter locationsTableAdapter1;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsibleadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prophylaxisdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeWindowToolStripMenuItem;
    }
}