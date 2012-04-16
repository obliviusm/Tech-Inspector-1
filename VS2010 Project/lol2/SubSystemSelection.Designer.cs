namespace lol2
{
    partial class SubSystemSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubSystemSelection));
            this.subsystemsGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.diagnosticsButton = new System.Windows.Forms.Button();
            this.reportingButton = new System.Windows.Forms.Button();
            this.planningButton = new System.Windows.Forms.Button();
            this.accountingButton = new System.Windows.Forms.Button();
            this.subsystemsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // subsystemsGroupBox
            // 
            this.subsystemsGroupBox.Controls.Add(this.button1);
            this.subsystemsGroupBox.Controls.Add(this.searchButton);
            this.subsystemsGroupBox.Controls.Add(this.diagnosticsButton);
            this.subsystemsGroupBox.Controls.Add(this.reportingButton);
            this.subsystemsGroupBox.Controls.Add(this.planningButton);
            this.subsystemsGroupBox.Controls.Add(this.accountingButton);
            this.subsystemsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subsystemsGroupBox.Location = new System.Drawing.Point(4, 13);
            this.subsystemsGroupBox.Name = "subsystemsGroupBox";
            this.subsystemsGroupBox.Size = new System.Drawing.Size(534, 364);
            this.subsystemsGroupBox.TabIndex = 0;
            this.subsystemsGroupBox.TabStop = false;
            this.subsystemsGroupBox.Text = "Виберіть підсистему для роботи";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 164);
            this.button1.TabIndex = 5;
            this.button1.Text = "Вихід до меню логіну";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchButton.Enabled = false;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(188, 194);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(155, 164);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Інф. пошук";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // diagnosticsButton
            // 
            this.diagnosticsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("diagnosticsButton.BackgroundImage")));
            this.diagnosticsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.diagnosticsButton.Enabled = false;
            this.diagnosticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosticsButton.Location = new System.Drawing.Point(9, 194);
            this.diagnosticsButton.Name = "diagnosticsButton";
            this.diagnosticsButton.Size = new System.Drawing.Size(155, 164);
            this.diagnosticsButton.TabIndex = 3;
            this.diagnosticsButton.Text = "Діагностика";
            this.diagnosticsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.diagnosticsButton.UseVisualStyleBackColor = true;
            // 
            // reportingButton
            // 
            this.reportingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportingButton.BackgroundImage")));
            this.reportingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reportingButton.Enabled = false;
            this.reportingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportingButton.Location = new System.Drawing.Point(365, 25);
            this.reportingButton.Name = "reportingButton";
            this.reportingButton.Size = new System.Drawing.Size(155, 164);
            this.reportingButton.TabIndex = 2;
            this.reportingButton.Text = "Звітність";
            this.reportingButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportingButton.UseVisualStyleBackColor = true;
            this.reportingButton.Click += new System.EventHandler(this.reportingButton_Click);
            // 
            // planningButton
            // 
            this.planningButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("planningButton.BackgroundImage")));
            this.planningButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.planningButton.Enabled = false;
            this.planningButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planningButton.Location = new System.Drawing.Point(188, 26);
            this.planningButton.Name = "planningButton";
            this.planningButton.Size = new System.Drawing.Size(155, 162);
            this.planningButton.TabIndex = 1;
            this.planningButton.Text = "Планові задачі";
            this.planningButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.planningButton.UseVisualStyleBackColor = true;
            this.planningButton.Click += new System.EventHandler(this.planningButton_Click);
            // 
            // accountingButton
            // 
            this.accountingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accountingButton.BackgroundImage")));
            this.accountingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.accountingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountingButton.Location = new System.Drawing.Point(9, 25);
            this.accountingButton.Name = "accountingButton";
            this.accountingButton.Size = new System.Drawing.Size(155, 163);
            this.accountingButton.TabIndex = 0;
            this.accountingButton.Text = "Облік";
            this.accountingButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accountingButton.UseVisualStyleBackColor = true;
            this.accountingButton.Click += new System.EventHandler(this.accountingButton_Click);
            // 
            // SubSystemSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 389);
            this.Controls.Add(this.subsystemsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SubSystemSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вибір підсистеми";
            this.subsystemsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox subsystemsGroupBox;
        private System.Windows.Forms.Button accountingButton;
        private System.Windows.Forms.Button planningButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button diagnosticsButton;
        private System.Windows.Forms.Button reportingButton;
        private System.Windows.Forms.Button button1;
    }
}