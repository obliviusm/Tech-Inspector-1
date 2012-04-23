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
        private List<string> runningSubForms = new List<string>();

        public SubSystemSelection()
        {
            InitializeComponent();
            //tabControl1.SelectedTab = tabPage1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void accountingButton_Click(object sender, EventArgs e)
        {
            //Form1 childFormForm1 = new Form1();
            InfoViewer childFormForm1 = new InfoViewer();
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
            subSystemTabs.SelectedTab = scheduledTasksTab;
            //CalendarPlan childFormCalendarPlan = new CalendarPlan();
            //childFormCalendarPlan.FormClosed+=new FormClosedEventHandler(childForm_FormClosed);
            //childFormCalendarPlan.Show();
            //Hide();
        }

        private void reportingButton_Click(object sender, EventArgs e)
        {
            subSystemTabs.SelectedTab = documentsTab;
            //DocumentControl childFormReportingForm = new DocumentControl();
            //childFormReportingForm.FormClosed+=new FormClosedEventHandler(childForm_FormClosed);
            //childFormReportingForm.Show();
            //Hide();
        }

        private void SubSystemSelection_Load(object sender, EventArgs e)
        {
            SetPrivileges();
            //textBox1.Text = Login.getUserId();
            //this.reportViewer1.RefreshReport();
        }

        public void SetPrivileges()
        {
            if (GeneralContentManager.getRoleId() == 1)
            {
                adminButton.Visible = true;
                planningButton.Enabled = true;
            }
            else
            {
                adminButton.Visible = false;
                planningButton.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportingForm childFormReportingForm = new ReportingForm();
            childFormReportingForm.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
            childFormReportingForm.Show();
            Hide();
        }

        private void preventionCalendar_Click(object sender, EventArgs e)
        {
            PreventionCalendar childFormPreventionCalendar = new PreventionCalendar();
            childFormPreventionCalendar.ShowDialog();
        }

        private void startCheckButton_Click(object sender, EventArgs e)
        {
            if (runningSubForms.Contains("CheckReport"))
                return;
            runningSubForms.Add("CheckReport");
            CheckReport childFormCheckReport = new CheckReport();
            childFormCheckReport.FormClosed += new FormClosedEventHandler(childFormCheckReport_FormClosed);
            childFormCheckReport.Show();
        }

        void childFormCheckReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            runningSubForms.Remove("CheckReport");
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminForm childFormAdminForm = new AdminForm();
            childFormAdminForm.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
            childFormAdminForm.Show();
            Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void equipmentByDateButton_Click(object sender, EventArgs e)
        {
            EquipmentByDate childFormAdminForm = new EquipmentByDate();
            childFormAdminForm.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
            childFormAdminForm.Show();
            Hide();
        }
    }
}
