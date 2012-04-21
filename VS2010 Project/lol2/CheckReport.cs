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
    public partial class CheckReport : Form
    {
        public CheckReport()
        {
            InitializeComponent();
        }

        private void CheckReport_Load(object sender, EventArgs e)
        {
            this.locationsTableAdapter.Fill(this.tech_inspectorDataSet.locations);

        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
