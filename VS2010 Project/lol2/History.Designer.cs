namespace lol2
{
    partial class History
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
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.tech_inspectorDataSet = new lol2.tech_inspectorDataSet();
            this.historylistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.history_listTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.history_listTableAdapter();
            this.equimpent_idLabel = new System.Windows.Forms.Label();
            this.equimpent_idTextBox = new System.Windows.Forms.TextBox();
            this.actiontypenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noticeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historylistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.AllowUserToAddRows = false;
            this.historyDataGridView.AllowUserToDeleteRows = false;
            this.historyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.historyDataGridView.AutoGenerateColumns = false;
            this.historyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actiontypenameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.noticeDataGridViewTextBoxColumn});
            this.historyDataGridView.DataSource = this.historylistBindingSource;
            this.historyDataGridView.Location = new System.Drawing.Point(13, 52);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.ReadOnly = true;
            this.historyDataGridView.Size = new System.Drawing.Size(621, 488);
            this.historyDataGridView.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(559, 546);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Закрити";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // tech_inspectorDataSet
            // 
            this.tech_inspectorDataSet.DataSetName = "tech_inspectorDataSet";
            this.tech_inspectorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historylistBindingSource
            // 
            this.historylistBindingSource.DataMember = "history_list";
            this.historylistBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // history_listTableAdapter
            // 
            this.history_listTableAdapter.ClearBeforeFill = true;
            // 
            // equimpent_idLabel
            // 
            this.equimpent_idLabel.AutoSize = true;
            this.equimpent_idLabel.Location = new System.Drawing.Point(12, 20);
            this.equimpent_idLabel.Name = "equimpent_idLabel";
            this.equimpent_idLabel.Size = new System.Drawing.Size(107, 13);
            this.equimpent_idLabel.TabIndex = 2;
            this.equimpent_idLabel.Text = "Інвентаринй номер:";
            // 
            // equimpent_idTextBox
            // 
            this.equimpent_idTextBox.Location = new System.Drawing.Point(125, 17);
            this.equimpent_idTextBox.Name = "equimpent_idTextBox";
            this.equimpent_idTextBox.ReadOnly = true;
            this.equimpent_idTextBox.Size = new System.Drawing.Size(114, 20);
            this.equimpent_idTextBox.TabIndex = 3;
            // 
            // actiontypenameDataGridViewTextBoxColumn
            // 
            this.actiontypenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.actiontypenameDataGridViewTextBoxColumn.DataPropertyName = "action_type_name";
            this.actiontypenameDataGridViewTextBoxColumn.FillWeight = 73.85786F;
            this.actiontypenameDataGridViewTextBoxColumn.HeaderText = "Тип дії";
            this.actiontypenameDataGridViewTextBoxColumn.Name = "actiontypenameDataGridViewTextBoxColumn";
            this.actiontypenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.actiontypenameDataGridViewTextBoxColumn.Width = 65;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 152.2843F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 58;
            // 
            // noticeDataGridViewTextBoxColumn
            // 
            this.noticeDataGridViewTextBoxColumn.DataPropertyName = "notice";
            this.noticeDataGridViewTextBoxColumn.FillWeight = 73.85786F;
            this.noticeDataGridViewTextBoxColumn.HeaderText = "Примітка";
            this.noticeDataGridViewTextBoxColumn.Name = "noticeDataGridViewTextBoxColumn";
            this.noticeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 581);
            this.Controls.Add(this.equimpent_idTextBox);
            this.Controls.Add(this.equimpent_idLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.historyDataGridView);
            this.Name = "History";
            this.Text = "Історія обладнання";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historylistBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.BindingSource historylistBindingSource;
        private tech_inspectorDataSet tech_inspectorDataSet;
        private System.Windows.Forms.Button closeButton;
        private tech_inspectorDataSetTableAdapters.history_listTableAdapter history_listTableAdapter;
        private System.Windows.Forms.Label equimpent_idLabel;
        private System.Windows.Forms.TextBox equimpent_idTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn actiontypenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noticeDataGridViewTextBoxColumn;
    }
}