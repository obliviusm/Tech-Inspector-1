namespace lol2
{
    partial class CalendarPlan
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.addDateButton = new System.Windows.Forms.Button();
            this.dateMaskedBox1 = new System.Windows.Forms.MaskedTextBox();
            this.checkDateMarkGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numberOfDatesTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addNDatesButton = new System.Windows.Forms.Button();
            this.dateMaskedBox2 = new System.Windows.Forms.MaskedTextBox();
            this.reportProplemsButton = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новийФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.експортуватиФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adobePDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.нещодавноВідкритіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файл1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файл2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копіюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вирізатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інструментиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.версіяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розробникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ліцензіяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkDateMarkGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(215, 27);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // addDateButton
            // 
            this.addDateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addDateButton.Location = new System.Drawing.Point(44, 113);
            this.addDateButton.Name = "addDateButton";
            this.addDateButton.Size = new System.Drawing.Size(113, 33);
            this.addDateButton.TabIndex = 3;
            this.addDateButton.Text = "Додати";
            this.addDateButton.UseVisualStyleBackColor = true;
            this.addDateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateMaskedBox1
            // 
            this.dateMaskedBox1.Location = new System.Drawing.Point(50, 59);
            this.dateMaskedBox1.Mask = "00/00/0000 90:00";
            this.dateMaskedBox1.Name = "dateMaskedBox1";
            this.dateMaskedBox1.Size = new System.Drawing.Size(99, 20);
            this.dateMaskedBox1.TabIndex = 2;
            this.dateMaskedBox1.ValidatingType = typeof(System.DateTime);
            this.dateMaskedBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // checkDateMarkGroupBox
            // 
            this.checkDateMarkGroupBox.Controls.Add(this.dateMaskedBox1);
            this.checkDateMarkGroupBox.Controls.Add(this.addDateButton);
            this.checkDateMarkGroupBox.Location = new System.Drawing.Point(12, 27);
            this.checkDateMarkGroupBox.Name = "checkDateMarkGroupBox";
            this.checkDateMarkGroupBox.Size = new System.Drawing.Size(200, 161);
            this.checkDateMarkGroupBox.TabIndex = 5;
            this.checkDateMarkGroupBox.TabStop = false;
            this.checkDateMarkGroupBox.Text = "Додати дату перевірки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numberOfDatesTextBox);
            this.groupBox2.Controls.Add(this.addNDatesButton);
            this.groupBox2.Controls.Add(this.dateMaskedBox2);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 170);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Розставити перевірки кожні N днів від виділеної дати :";
            // 
            // numberOfDatesTextBox
            // 
            this.numberOfDatesTextBox.Location = new System.Drawing.Point(50, 82);
            this.numberOfDatesTextBox.Mask = "00000";
            this.numberOfDatesTextBox.Name = "numberOfDatesTextBox";
            this.numberOfDatesTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfDatesTextBox.TabIndex = 5;
            this.numberOfDatesTextBox.ValidatingType = typeof(int);
            // 
            // addNDatesButton
            // 
            this.addNDatesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addNDatesButton.Location = new System.Drawing.Point(44, 121);
            this.addNDatesButton.Name = "addNDatesButton";
            this.addNDatesButton.Size = new System.Drawing.Size(113, 33);
            this.addNDatesButton.TabIndex = 4;
            this.addNDatesButton.Text = "Додати";
            this.addNDatesButton.UseVisualStyleBackColor = true;
            // 
            // dateMaskedBox2
            // 
            this.dateMaskedBox2.Location = new System.Drawing.Point(50, 47);
            this.dateMaskedBox2.Mask = "00/00/0000 90:00";
            this.dateMaskedBox2.Name = "dateMaskedBox2";
            this.dateMaskedBox2.Size = new System.Drawing.Size(99, 20);
            this.dateMaskedBox2.TabIndex = 4;
            this.dateMaskedBox2.ValidatingType = typeof(System.DateTime);
            // 
            // reportProplemsButton
            // 
            this.reportProplemsButton.Location = new System.Drawing.Point(220, 223);
            this.reportProplemsButton.Name = "reportProplemsButton";
            this.reportProplemsButton.Size = new System.Drawing.Size(214, 39);
            this.reportProplemsButton.TabIndex = 7;
            this.reportProplemsButton.Text = "Звіт про неполадки за виділене число";
            this.reportProplemsButton.UseVisualStyleBackColor = true;
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(220, 277);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(214, 39);
            this.report.TabIndex = 8;
            this.report.Text = "Відмітити планові перевірки що не відбулися";
            this.report.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.інструментиToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новийФайлToolStripMenuItem,
            this.відкритиФайлToolStripMenuItem,
            this.зберегтиФайлToolStripMenuItem,
            this.експортуватиФайлToolStripMenuItem,
            this.toolStripMenuItem2,
            this.нещодавноВідкритіToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // новийФайлToolStripMenuItem
            // 
            this.новийФайлToolStripMenuItem.Name = "новийФайлToolStripMenuItem";
            this.новийФайлToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.новийФайлToolStripMenuItem.Text = "&Додати пристрій до бази";
            // 
            // відкритиФайлToolStripMenuItem
            // 
            this.відкритиФайлToolStripMenuItem.Name = "відкритиФайлToolStripMenuItem";
            this.відкритиФайлToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.відкритиФайлToolStripMenuItem.Text = "&Підключитися до бази";
            // 
            // зберегтиФайлToolStripMenuItem
            // 
            this.зберегтиФайлToolStripMenuItem.Name = "зберегтиФайлToolStripMenuItem";
            this.зберегтиФайлToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.зберегтиФайлToolStripMenuItem.Text = "&Зберегти зміни";
            // 
            // експортуватиФайлToolStripMenuItem
            // 
            this.експортуватиФайлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microsoftWordToolStripMenuItem,
            this.microsoftExcelToolStripMenuItem,
            this.adobePDFToolStripMenuItem});
            this.експортуватиФайлToolStripMenuItem.Name = "експортуватиФайлToolStripMenuItem";
            this.експортуватиФайлToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.експортуватиФайлToolStripMenuItem.Text = "&Експортувати у файл";
            // 
            // microsoftWordToolStripMenuItem
            // 
            this.microsoftWordToolStripMenuItem.Name = "microsoftWordToolStripMenuItem";
            this.microsoftWordToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.microsoftWordToolStripMenuItem.Text = "&Microsoft Word";
            // 
            // microsoftExcelToolStripMenuItem
            // 
            this.microsoftExcelToolStripMenuItem.Name = "microsoftExcelToolStripMenuItem";
            this.microsoftExcelToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.microsoftExcelToolStripMenuItem.Text = "&Microsoft Excel";
            // 
            // adobePDFToolStripMenuItem
            // 
            this.adobePDFToolStripMenuItem.Name = "adobePDFToolStripMenuItem";
            this.adobePDFToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.adobePDFToolStripMenuItem.Text = "&Adobe PDF";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(206, 6);
            // 
            // нещодавноВідкритіToolStripMenuItem
            // 
            this.нещодавноВідкритіToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файл1ToolStripMenuItem,
            this.файл2ToolStripMenuItem});
            this.нещодавноВідкритіToolStripMenuItem.Name = "нещодавноВідкритіToolStripMenuItem";
            this.нещодавноВідкритіToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.нещодавноВідкритіToolStripMenuItem.Text = "&Нещодавно відкриті";
            // 
            // файл1ToolStripMenuItem
            // 
            this.файл1ToolStripMenuItem.Name = "файл1ToolStripMenuItem";
            this.файл1ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.файл1ToolStripMenuItem.Text = "&Пристрій1";
            // 
            // файл2ToolStripMenuItem
            // 
            this.файл2ToolStripMenuItem.Name = "файл2ToolStripMenuItem";
            this.файл2ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.файл2ToolStripMenuItem.Text = "&Пристрій2";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
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
            // інструментиToolStripMenuItem
            // 
            this.інструментиToolStripMenuItem.Name = "інструментиToolStripMenuItem";
            this.інструментиToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.інструментиToolStripMenuItem.Text = "&Інструменти";
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
            // CalendarPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 371);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.report);
            this.Controls.Add(this.reportProplemsButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkDateMarkGroupBox);
            this.Controls.Add(this.monthCalendar);
            this.MaximizeBox = false;
            this.Name = "CalendarPlan";
            this.Text = "Календарне планування";
            this.Load += new System.EventHandler(this.CalendarPlan_Load);
            this.checkDateMarkGroupBox.ResumeLayout(false);
            this.checkDateMarkGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button addDateButton;
        private System.Windows.Forms.MaskedTextBox dateMaskedBox1;
        private System.Windows.Forms.GroupBox checkDateMarkGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox numberOfDatesTextBox;
        private System.Windows.Forms.Button addNDatesButton;
        private System.Windows.Forms.MaskedTextBox dateMaskedBox2;
        private System.Windows.Forms.Button reportProplemsButton;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новийФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem експортуватиФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adobePDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem нещодавноВідкритіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файл1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файл2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копіюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вирізатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інструментиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem версіяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розробникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ліцензіяToolStripMenuItem;
    }
}