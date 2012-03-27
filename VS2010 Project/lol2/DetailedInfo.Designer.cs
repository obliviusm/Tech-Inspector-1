namespace lol2
{
    partial class DetailedInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.deviceNumberLabel = new System.Windows.Forms.Label();
            this.deviceNumberTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.deviceTypeLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.dateGroupBox = new System.Windows.Forms.GroupBox();
            this.serviceEndTextBox = new System.Windows.Forms.MaskedTextBox();
            this.placementDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.purchaseDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.warrantyEndLabel = new System.Windows.Forms.Label();
            this.placementDateLabel = new System.Windows.Forms.Label();
            this.purchaseDateLabel = new System.Windows.Forms.Label();
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.configurationDataGridView = new System.Windows.Forms.DataGridView();
            this.parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.dateGroupBox.SuspendLayout();
            this.configurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.locationTextBox);
            this.groupBox1.Controls.Add(this.typeTextBox);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.deviceNumberLabel);
            this.groupBox1.Controls.Add(this.deviceNumberTextBox);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.deviceTypeLabel);
            this.groupBox1.Controls.Add(this.locationLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 132);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальна інформація";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(127, 97);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(152, 20);
            this.priceTextBox.TabIndex = 21;
            // 
            // deviceNumberLabel
            // 
            this.deviceNumberLabel.AutoSize = true;
            this.deviceNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceNumberLabel.Location = new System.Drawing.Point(11, 19);
            this.deviceNumberLabel.Name = "deviceNumberLabel";
            this.deviceNumberLabel.Size = new System.Drawing.Size(110, 13);
            this.deviceNumberLabel.TabIndex = 2;
            this.deviceNumberLabel.Text = "Інвентарний номер :";
            // 
            // deviceNumberTextBox
            // 
            this.deviceNumberTextBox.Enabled = false;
            this.deviceNumberTextBox.Location = new System.Drawing.Point(127, 19);
            this.deviceNumberTextBox.Name = "deviceNumberTextBox";
            this.deviceNumberTextBox.Size = new System.Drawing.Size(152, 20);
            this.deviceNumberTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(11, 97);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(35, 13);
            this.priceLabel.TabIndex = 20;
            this.priceLabel.Text = "Ціна :";
            // 
            // deviceTypeLabel
            // 
            this.deviceTypeLabel.AutoSize = true;
            this.deviceTypeLabel.Location = new System.Drawing.Point(11, 44);
            this.deviceTypeLabel.Name = "deviceTypeLabel";
            this.deviceTypeLabel.Size = new System.Drawing.Size(95, 13);
            this.deviceTypeLabel.TabIndex = 4;
            this.deviceTypeLabel.Text = "Тип обладнання :";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(11, 71);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(86, 13);
            this.locationLabel.TabIndex = 18;
            this.locationLabel.Text = "Розташування :";
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
            this.dateGroupBox.Location = new System.Drawing.Point(314, 12);
            this.dateGroupBox.Name = "dateGroupBox";
            this.dateGroupBox.Size = new System.Drawing.Size(302, 101);
            this.dateGroupBox.TabIndex = 25;
            this.dateGroupBox.TabStop = false;
            this.dateGroupBox.Text = "Дата";
            // 
            // serviceEndTextBox
            // 
            this.serviceEndTextBox.Enabled = false;
            this.serviceEndTextBox.Location = new System.Drawing.Point(197, 66);
            this.serviceEndTextBox.Mask = "00/00/0000";
            this.serviceEndTextBox.Name = "serviceEndTextBox";
            this.serviceEndTextBox.Size = new System.Drawing.Size(88, 20);
            this.serviceEndTextBox.TabIndex = 5;
            this.serviceEndTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // placementDateTextBox
            // 
            this.placementDateTextBox.Enabled = false;
            this.placementDateTextBox.Location = new System.Drawing.Point(197, 44);
            this.placementDateTextBox.Mask = "00/00/0000";
            this.placementDateTextBox.Name = "placementDateTextBox";
            this.placementDateTextBox.Size = new System.Drawing.Size(88, 20);
            this.placementDateTextBox.TabIndex = 4;
            this.placementDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // purchaseDateTextBox
            // 
            this.purchaseDateTextBox.Enabled = false;
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
            // configurationGroupBox
            // 
            this.configurationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.configurationGroupBox.Controls.Add(this.configurationDataGridView);
            this.configurationGroupBox.Location = new System.Drawing.Point(12, 150);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(605, 299);
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
            this.configurationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.configurationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.configurationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parameter,
            this.value});
            this.configurationDataGridView.Location = new System.Drawing.Point(7, 19);
            this.configurationDataGridView.Name = "configurationDataGridView";
            this.configurationDataGridView.Size = new System.Drawing.Size(592, 274);
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
            // typeTextBox
            // 
            this.typeTextBox.Enabled = false;
            this.typeTextBox.Location = new System.Drawing.Point(127, 45);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(152, 20);
            this.typeTextBox.TabIndex = 22;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Enabled = false;
            this.locationTextBox.Location = new System.Drawing.Point(127, 71);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(152, 20);
            this.locationTextBox.TabIndex = 23;
            // 
            // DetailedInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateGroupBox);
            this.Controls.Add(this.configurationGroupBox);
            this.Name = "DetailedInfo";
            this.Text = "Детальна інформація";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dateGroupBox.ResumeLayout(false);
            this.dateGroupBox.PerformLayout();
            this.configurationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configurationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label deviceNumberLabel;
        private System.Windows.Forms.TextBox deviceNumberTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label deviceTypeLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.GroupBox dateGroupBox;
        private System.Windows.Forms.MaskedTextBox serviceEndTextBox;
        private System.Windows.Forms.MaskedTextBox placementDateTextBox;
        private System.Windows.Forms.MaskedTextBox purchaseDateTextBox;
        private System.Windows.Forms.Label warrantyEndLabel;
        private System.Windows.Forms.Label placementDateLabel;
        private System.Windows.Forms.Label purchaseDateLabel;
        private System.Windows.Forms.GroupBox configurationGroupBox;
        private System.Windows.Forms.DataGridView configurationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
    }
}