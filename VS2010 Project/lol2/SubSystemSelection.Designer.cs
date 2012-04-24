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
            this.accountingButton = new System.Windows.Forms.Button();
            this.reportingButton = new System.Windows.Forms.Button();
            this.diagnosticsButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.subsystemsGroupBox = new System.Windows.Forms.GroupBox();
            this.adminButton = new System.Windows.Forms.Button();
            this.startCheckButton = new System.Windows.Forms.Button();
            this.preventionCalendar = new System.Windows.Forms.Button();
            this.subsystemsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountingButton
            // 
            this.accountingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accountingButton.BackgroundImage")));
            this.accountingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.accountingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountingButton.Location = new System.Drawing.Point(9, 26);
            this.accountingButton.Name = "accountingButton";
            this.accountingButton.Size = new System.Drawing.Size(155, 175);
            this.accountingButton.TabIndex = 0;
            this.accountingButton.Text = "Облік";
            this.accountingButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accountingButton.UseVisualStyleBackColor = true;
            this.accountingButton.Click += new System.EventHandler(this.accountingButton_Click);
            // 
            // reportingButton
            // 
            this.reportingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportingButton.BackgroundImage")));
            this.reportingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reportingButton.Enabled = false;
            this.reportingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportingButton.Location = new System.Drawing.Point(492, 27);
            this.reportingButton.Name = "reportingButton";
            this.reportingButton.Size = new System.Drawing.Size(155, 175);
            this.reportingButton.TabIndex = 2;
            this.reportingButton.Text = "Документообіг";
            this.reportingButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportingButton.UseVisualStyleBackColor = true;
            this.reportingButton.Click += new System.EventHandler(this.reportingButton_Click);
            // 
            // diagnosticsButton
            // 
            this.diagnosticsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("diagnosticsButton.BackgroundImage")));
            this.diagnosticsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.diagnosticsButton.Enabled = false;
            this.diagnosticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosticsButton.Location = new System.Drawing.Point(9, 207);
            this.diagnosticsButton.Name = "diagnosticsButton";
            this.diagnosticsButton.Size = new System.Drawing.Size(155, 175);
            this.diagnosticsButton.TabIndex = 3;
            this.diagnosticsButton.Text = "Діагностика";
            this.diagnosticsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.diagnosticsButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchButton.Enabled = false;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(170, 207);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(155, 175);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Інф. пошук";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 175);
            this.button1.TabIndex = 5;
            this.button1.Text = "Вихід до меню логіну";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // subsystemsGroupBox
            // 
            this.subsystemsGroupBox.Controls.Add(this.adminButton);
            this.subsystemsGroupBox.Controls.Add(this.startCheckButton);
            this.subsystemsGroupBox.Controls.Add(this.button1);
            this.subsystemsGroupBox.Controls.Add(this.preventionCalendar);
            this.subsystemsGroupBox.Controls.Add(this.searchButton);
            this.subsystemsGroupBox.Controls.Add(this.diagnosticsButton);
            this.subsystemsGroupBox.Controls.Add(this.reportingButton);
            this.subsystemsGroupBox.Controls.Add(this.accountingButton);
            this.subsystemsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subsystemsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.subsystemsGroupBox.Name = "subsystemsGroupBox";
            this.subsystemsGroupBox.Size = new System.Drawing.Size(656, 392);
            this.subsystemsGroupBox.TabIndex = 0;
            this.subsystemsGroupBox.TabStop = false;
            this.subsystemsGroupBox.Text = "Виберіть підсистему для роботи";
            // 
            // adminButton
            // 
            this.adminButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminButton.BackgroundImage")));
            this.adminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adminButton.Location = new System.Drawing.Point(331, 208);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(155, 175);
            this.adminButton.TabIndex = 6;
            this.adminButton.Text = "Адміністрування";
            this.adminButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // startCheckButton
            // 
            this.startCheckButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startCheckButton.BackgroundImage")));
            this.startCheckButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startCheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCheckButton.Location = new System.Drawing.Point(331, 27);
            this.startCheckButton.Name = "startCheckButton";
            this.startCheckButton.Size = new System.Drawing.Size(155, 175);
            this.startCheckButton.TabIndex = 6;
            this.startCheckButton.Text = "Виконати профілактику";
            this.startCheckButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startCheckButton.UseVisualStyleBackColor = true;
            this.startCheckButton.Click += new System.EventHandler(this.startCheckButton_Click);
            // 
            // preventionCalendar
            // 
            this.preventionCalendar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preventionCalendar.BackgroundImage")));
            this.preventionCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.preventionCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preventionCalendar.Location = new System.Drawing.Point(170, 26);
            this.preventionCalendar.Name = "preventionCalendar";
            this.preventionCalendar.Size = new System.Drawing.Size(155, 175);
            this.preventionCalendar.TabIndex = 6;
            this.preventionCalendar.Text = "Розклад профілактик";
            this.preventionCalendar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.preventionCalendar.UseVisualStyleBackColor = true;
            this.preventionCalendar.Click += new System.EventHandler(this.preventionCalendar_Click);
            // 
            // SubSystemSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 414);
            this.Controls.Add(this.subsystemsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SubSystemSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вибір підсистеми";
            this.Load += new System.EventHandler(this.SubSystemSelection_Load);
            this.subsystemsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button accountingButton;
        private System.Windows.Forms.Button reportingButton;
        private System.Windows.Forms.Button diagnosticsButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox subsystemsGroupBox;
        private System.Windows.Forms.Button preventionCalendar;
        private System.Windows.Forms.Button startCheckButton;
        private System.Windows.Forms.Button adminButton;

    }
}