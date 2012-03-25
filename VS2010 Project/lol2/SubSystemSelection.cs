using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lol2
{
    public partial class SubSystemSelection : Form
    {
        public SubSystemSelection()
        {
            InitializeComponent();
            // Initialize DB
            DatabaseManager.Initialize("tech_inspector");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void accountingButton_Click(object sender, EventArgs e)
        {
            Form1 childFormForm1 = new Form1();
            childFormForm1.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
            childFormForm1.Show();
            Hide();
        }

        void childForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void planningButton_Click(object sender, EventArgs e)
        {
            CalendarPlan childFormCalendarPlan = new CalendarPlan();
            childFormCalendarPlan.FormClosed+=new FormClosedEventHandler(childForm_FormClosed);
            childFormCalendarPlan.Show();
            Hide();
        }

        private void reportingButton_Click(object sender, EventArgs e)
        {
            ReportingForm childFormReportingForm = new ReportingForm();
            childFormReportingForm.FormClosed+=new FormClosedEventHandler(childForm_FormClosed);
            childFormReportingForm.Show();
            Hide();
        }
    }
}
