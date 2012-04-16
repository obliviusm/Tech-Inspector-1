namespace lol2
{
    partial class ReportingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.planForBuyingTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deleteButton = new System.Windows.Forms.Button();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.saveDocOutputComboBox = new System.Windows.Forms.ComboBox();
            this.saveDocOutputLabel = new System.Windows.Forms.Label();
            this.openDocOutputComboBox = new System.Windows.Forms.ComboBox();
            this.openDocOutputLabel = new System.Windows.Forms.Label();
            this.openDocOutputButton = new System.Windows.Forms.Button();
            this.restLabel = new System.Windows.Forms.Label();
            this.outputDataGridView = new System.Windows.Forms.DataGridView();
            this.costLabel = new System.Windows.Forms.Label();
            this.planForBuyingLabel = new System.Windows.Forms.Label();
            this.saveDocOutputButton = new System.Windows.Forms.Button();
            this.restLabel2 = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.costLabel2 = new System.Windows.Forms.Label();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfGoodsTextBox = new System.Windows.Forms.TextBox();
            this.numberOfGoodsLabel = new System.Windows.Forms.Label();
            this.openDocInputComboBox = new System.Windows.Forms.ComboBox();
            this.openDocInputLabel = new System.Windows.Forms.Label();
            this.inputDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDocInputButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planForBuyingTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataGridView)).BeginInit();
            this.inputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // planForBuyingTabControl
            // 
            this.planForBuyingTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.planForBuyingTabControl.Controls.Add(this.tabPage1);
            this.planForBuyingTabControl.Controls.Add(this.tabPage2);
            this.planForBuyingTabControl.Location = new System.Drawing.Point(3, 12);
            this.planForBuyingTabControl.Name = "planForBuyingTabControl";
            this.planForBuyingTabControl.SelectedIndex = 0;
            this.planForBuyingTabControl.Size = new System.Drawing.Size(1271, 648);
            this.planForBuyingTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Controls.Add(this.outputGroupBox);
            this.tabPage1.Controls.Add(this.inputGroupBox);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1263, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "План закупівель";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(559, 331);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(48, 51);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "<";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.outputGroupBox.Controls.Add(this.BalanceTextBox);
            this.outputGroupBox.Controls.Add(this.saveDocOutputComboBox);
            this.outputGroupBox.Controls.Add(this.saveDocOutputLabel);
            this.outputGroupBox.Controls.Add(this.openDocOutputComboBox);
            this.outputGroupBox.Controls.Add(this.openDocOutputLabel);
            this.outputGroupBox.Controls.Add(this.openDocOutputButton);
            this.outputGroupBox.Controls.Add(this.restLabel);
            this.outputGroupBox.Controls.Add(this.outputDataGridView);
            this.outputGroupBox.Controls.Add(this.costLabel);
            this.outputGroupBox.Controls.Add(this.planForBuyingLabel);
            this.outputGroupBox.Controls.Add(this.saveDocOutputButton);
            this.outputGroupBox.Controls.Add(this.restLabel2);
            this.outputGroupBox.Controls.Add(this.BalanceLabel);
            this.outputGroupBox.Controls.Add(this.costLabel2);
            this.outputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputGroupBox.Location = new System.Drawing.Point(620, 16);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(631, 600);
            this.outputGroupBox.TabIndex = 15;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Вихідні дані";
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Location = new System.Drawing.Point(564, 43);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.Size = new System.Drawing.Size(58, 20);
            this.BalanceTextBox.TabIndex = 30;
            // 
            // saveDocOutputComboBox
            // 
            this.saveDocOutputComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveDocOutputComboBox.FormattingEnabled = true;
            this.saveDocOutputComboBox.Items.AddRange(new object[] {
            "Прайс-лист",
            "Тендерна пропозиція",
            "Рахунок-фактура",
            "Заявка на оплату",
            "Заявка на довіреність"});
            this.saveDocOutputComboBox.Location = new System.Drawing.Point(112, 94);
            this.saveDocOutputComboBox.Name = "saveDocOutputComboBox";
            this.saveDocOutputComboBox.Size = new System.Drawing.Size(211, 21);
            this.saveDocOutputComboBox.TabIndex = 29;
            // 
            // saveDocOutputLabel
            // 
            this.saveDocOutputLabel.AutoSize = true;
            this.saveDocOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveDocOutputLabel.Location = new System.Drawing.Point(6, 97);
            this.saveDocOutputLabel.Name = "saveDocOutputLabel";
            this.saveDocOutputLabel.Size = new System.Drawing.Size(102, 13);
            this.saveDocOutputLabel.TabIndex = 28;
            this.saveDocOutputLabel.Text = "Вихідний документ";
            // 
            // openDocOutputComboBox
            // 
            this.openDocOutputComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openDocOutputComboBox.FormattingEnabled = true;
            this.openDocOutputComboBox.Items.AddRange(new object[] {
            "Прайс-лист",
            "Тендерна пропозиція",
            "Рахунок-фактура",
            "Заявка на оплату",
            "Заявка на довіреність"});
            this.openDocOutputComboBox.Location = new System.Drawing.Point(112, 40);
            this.openDocOutputComboBox.Name = "openDocOutputComboBox";
            this.openDocOutputComboBox.Size = new System.Drawing.Size(211, 21);
            this.openDocOutputComboBox.TabIndex = 27;
            // 
            // openDocOutputLabel
            // 
            this.openDocOutputLabel.AutoSize = true;
            this.openDocOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openDocOutputLabel.Location = new System.Drawing.Point(6, 43);
            this.openDocOutputLabel.Name = "openDocOutputLabel";
            this.openDocOutputLabel.Size = new System.Drawing.Size(96, 13);
            this.openDocOutputLabel.TabIndex = 25;
            this.openDocOutputLabel.Text = "Вхідний документ";
            // 
            // openDocOutputButton
            // 
            this.openDocOutputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openDocOutputButton.Location = new System.Drawing.Point(340, 34);
            this.openDocOutputButton.Name = "openDocOutputButton";
            this.openDocOutputButton.Size = new System.Drawing.Size(67, 30);
            this.openDocOutputButton.TabIndex = 26;
            this.openDocOutputButton.Text = "Відкрити";
            this.openDocOutputButton.UseVisualStyleBackColor = true;
            // 
            // restLabel
            // 
            this.restLabel.AutoSize = true;
            this.restLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restLabel.Location = new System.Drawing.Point(583, 101);
            this.restLabel.Name = "restLabel";
            this.restLabel.Size = new System.Drawing.Size(39, 13);
            this.restLabel.TabIndex = 24;
            this.restLabel.Text = "50 грн";
            // 
            // outputDataGridView
            // 
            this.outputDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.outputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.Column7});
            this.outputDataGridView.Location = new System.Drawing.Point(9, 136);
            this.outputDataGridView.Name = "outputDataGridView";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.outputDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.outputDataGridView.Size = new System.Drawing.Size(616, 458);
            this.outputDataGridView.TabIndex = 16;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(583, 75);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(39, 13);
            this.costLabel.TabIndex = 23;
            this.costLabel.Text = "50 грн";
            // 
            // planForBuyingLabel
            // 
            this.planForBuyingLabel.AutoSize = true;
            this.planForBuyingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.planForBuyingLabel.Location = new System.Drawing.Point(471, 23);
            this.planForBuyingLabel.Name = "planForBuyingLabel";
            this.planForBuyingLabel.Size = new System.Drawing.Size(106, 13);
            this.planForBuyingLabel.TabIndex = 17;
            this.planForBuyingLabel.Text = "План закупівель";
            // 
            // saveDocOutputButton
            // 
            this.saveDocOutputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveDocOutputButton.Location = new System.Drawing.Point(340, 90);
            this.saveDocOutputButton.Name = "saveDocOutputButton";
            this.saveDocOutputButton.Size = new System.Drawing.Size(67, 27);
            this.saveDocOutputButton.TabIndex = 18;
            this.saveDocOutputButton.Text = "Зберегти";
            this.saveDocOutputButton.UseVisualStyleBackColor = true;
            // 
            // restLabel2
            // 
            this.restLabel2.AutoSize = true;
            this.restLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restLabel2.Location = new System.Drawing.Point(413, 101);
            this.restLabel2.Name = "restLabel2";
            this.restLabel2.Size = new System.Drawing.Size(70, 13);
            this.restLabel2.TabIndex = 21;
            this.restLabel2.Text = "Залишилось";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalanceLabel.Location = new System.Drawing.Point(413, 51);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(112, 13);
            this.BalanceLabel.TabIndex = 19;
            this.BalanceLabel.Text = "Сума для закупівель";
            // 
            // costLabel2
            // 
            this.costLabel2.AutoSize = true;
            this.costLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel2.Location = new System.Drawing.Point(413, 75);
            this.costLabel2.Name = "costLabel2";
            this.costLabel2.Size = new System.Drawing.Size(140, 13);
            this.costLabel2.TabIndex = 20;
            this.costLabel2.Text = "Вартість обраноих товарів";
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.inputGroupBox.Controls.Add(this.numberOfGoodsTextBox);
            this.inputGroupBox.Controls.Add(this.numberOfGoodsLabel);
            this.inputGroupBox.Controls.Add(this.openDocInputComboBox);
            this.inputGroupBox.Controls.Add(this.openDocInputLabel);
            this.inputGroupBox.Controls.Add(this.inputDataGridView);
            this.inputGroupBox.Controls.Add(this.openDocInputButton);
            this.inputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputGroupBox.Location = new System.Drawing.Point(3, 6);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(545, 610);
            this.inputGroupBox.TabIndex = 14;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Вхідні дані";
            // 
            // numberOfGoodsTextBox
            // 
            this.numberOfGoodsTextBox.Location = new System.Drawing.Point(220, 26);
            this.numberOfGoodsTextBox.Name = "numberOfGoodsTextBox";
            this.numberOfGoodsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfGoodsTextBox.TabIndex = 9;
            this.numberOfGoodsTextBox.TextChanged += new System.EventHandler(this.numberOfGoodsTextBox_TextChanged);
            // 
            // numberOfGoodsLabel
            // 
            this.numberOfGoodsLabel.AutoSize = true;
            this.numberOfGoodsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfGoodsLabel.Location = new System.Drawing.Point(45, 33);
            this.numberOfGoodsLabel.Name = "numberOfGoodsLabel";
            this.numberOfGoodsLabel.Size = new System.Drawing.Size(155, 13);
            this.numberOfGoodsLabel.TabIndex = 8;
            this.numberOfGoodsLabel.Text = "Кількість товарів в документі";
            // 
            // openDocInputComboBox
            // 
            this.openDocInputComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openDocInputComboBox.FormattingEnabled = true;
            this.openDocInputComboBox.Items.AddRange(new object[] {
            "Прайс-лист",
            "Тендерна пропозиція",
            "Рахунок-фактура",
            "Заявка на оплату",
            "Заявка на довіреність"});
            this.openDocInputComboBox.Location = new System.Drawing.Point(220, 67);
            this.openDocInputComboBox.Name = "openDocInputComboBox";
            this.openDocInputComboBox.Size = new System.Drawing.Size(211, 21);
            this.openDocInputComboBox.TabIndex = 7;
            this.openDocInputComboBox.SelectedIndexChanged += new System.EventHandler(this.openDocInputComboBox_SelectedIndexChanged);
            // 
            // openDocInputLabel
            // 
            this.openDocInputLabel.AutoSize = true;
            this.openDocInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openDocInputLabel.Location = new System.Drawing.Point(45, 70);
            this.openDocInputLabel.Name = "openDocInputLabel";
            this.openDocInputLabel.Size = new System.Drawing.Size(96, 13);
            this.openDocInputLabel.TabIndex = 4;
            this.openDocInputLabel.Text = "Вхідний документ";
            // 
            // inputDataGridView
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inputDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.inputDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.inputDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.inputDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inputDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.inputDataGridView.Location = new System.Drawing.Point(6, 139);
            this.inputDataGridView.Name = "inputDataGridView";
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inputDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.inputDataGridView.Size = new System.Drawing.Size(527, 465);
            this.inputDataGridView.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Назва товару";
            this.Column2.Name = "Column2";
            this.Column2.Width = 320;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Гарантія";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ціна";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // openDocInputButton
            // 
            this.openDocInputButton.Enabled = false;
            this.openDocInputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openDocInputButton.Location = new System.Drawing.Point(220, 100);
            this.openDocInputButton.Name = "openDocInputButton";
            this.openDocInputButton.Size = new System.Drawing.Size(67, 30);
            this.openDocInputButton.TabIndex = 6;
            this.openDocInputButton.Text = "Відкрити";
            this.openDocInputButton.UseVisualStyleBackColor = true;
            this.openDocInputButton.Click += new System.EventHandler(this.openDocInputButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(559, 274);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(48, 51);
            this.addButton.TabIndex = 0;
            this.addButton.Text = ">";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1263, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Назва товару";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 320;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Гарантія";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ціна";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Кількість";
            this.Column7.Name = "Column7";
            // 
            // ReportingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 662);
            this.Controls.Add(this.planForBuyingTabControl);
            this.Name = "ReportingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формування звітності";
            this.Load += new System.EventHandler(this.ReportingForm_Load);
            this.planForBuyingTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataGridView)).EndInit();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl planForBuyingTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView inputDataGridView;
        private System.Windows.Forms.Label openDocInputLabel;
        private System.Windows.Forms.Button openDocInputButton;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Label restLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label planForBuyingLabel;
        private System.Windows.Forms.Button saveDocOutputButton;
        private System.Windows.Forms.Label restLabel2;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label costLabel2;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.DataGridView outputDataGridView;
        private System.Windows.Forms.ComboBox openDocInputComboBox;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.ComboBox saveDocOutputComboBox;
        private System.Windows.Forms.Label saveDocOutputLabel;
        private System.Windows.Forms.ComboBox openDocOutputComboBox;
        private System.Windows.Forms.Label openDocOutputLabel;
        private System.Windows.Forms.Button openDocOutputButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox numberOfGoodsTextBox;
        private System.Windows.Forms.Label numberOfGoodsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;

    }
}