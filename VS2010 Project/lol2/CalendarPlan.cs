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
    public partial class CalendarPlan : Form
    {
        public CalendarPlan()
        {
            InitializeComponent();
        }

        private void CalendarPlan_Load(object sender, EventArgs e)
        {
            monthCalendar.AddBoldedDate(new DateTime(2012,2,10));
            monthCalendar.AddBoldedDate(new DateTime(2012,2,17));
            monthCalendar.AddBoldedDate(new DateTime(2012, 2, 27));
            monthCalendar.UpdateBoldedDates();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = dateMaskedBox1.Text;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.Text = e.End.Date.ToString() + e.End.Month.ToString() + e.End.Year;
        }
    }
}
