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
    public partial class Form1 : Form
    {
        Dictionary<string,bool> childFormsOpened=new Dictionary<string, bool>(); 

        public Form1()
        {
            InitializeComponent();
            childFormsOpened["RepairmentReport"] = false;
            childFormsOpened["CalendarPlan"] = false;
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!childFormsOpened["RepairmentReport"])
            {
                childFormsOpened["RepairmentReport"] = true;
                RepairmentLog childRepairmentLog = new RepairmentLog();
                childRepairmentLog.Closed += new EventHandler(childRepairmentLog_Closed);
                childRepairmentLog.Show();
            }
        }

        void childRepairmentLog_Closed(object sender, EventArgs e)
        {
            childFormsOpened["RepairmentReport"] = false;
        }

        private void календарнийПланОблікуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!childFormsOpened["CalendarPlan"])
            {
                childFormsOpened["CalendarPlan"] = true;
                CalendarPlan childCalendarPlan=new CalendarPlan();
                childCalendarPlan.Closed += new EventHandler(childCalendarPlan_Closed);
                childCalendarPlan.Show();
            }
        }

        void childCalendarPlan_Closed(object sender, EventArgs e)
        {
            childFormsOpened["CalendarPlan"] = false;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            detailedInfoDataGridView.AutoResizeColumns();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            detailedInfoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            detailedInfoDataGridView.Rows.Add("Процесор","Intel Core i5 2.4 GHZ");
            detailedInfoDataGridView.Rows.Add("Відеокарта", "ATI Radeon HD 5470");
            detailedInfoDataGridView.Rows.Add("HDD", "320 GB");
            detailedInfoDataGridView.Rows.Add("USB", "4x USB 2.0");
            detailedInfoDataGridView.Rows.Add("RAM", "3 GB DDR3");
            detailedInfoDataGridView.Rows.Add("Bluetooth", "Bluetooth 2.1+EDR");
            detailedInfoDataGridView.Rows.Add("Wi-fi", "Acer Nplify 802.11");
            detailedInfoDataGridView.Rows.Add("Привід", "DVD-Super Multi DL drive");
        }

        private void новийФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDevice childFormAddDevice = new AddDevice();
            childFormAddDevice.ShowDialog();
        }

        private void редагуванняШаблонівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceTemplateEditor childFormDeviceTemplateEditor = new DeviceTemplateEditor();
            childFormDeviceTemplateEditor.Show();
        }
    }
}
