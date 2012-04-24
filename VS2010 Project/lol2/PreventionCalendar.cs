using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace lol2
{
    public partial class PreventionCalendar : Form
    {
        private void SaveChanges()
        {
            for (int i = 0; i < planTable.RowCount; i++)
            {
                planTable[5, i].Value = (planTable["day_string", i] as DataGridViewComboBoxCell).Items.IndexOf(planTable["day_string", i].Value);
                planTable[6, i].Value = (planTable["lesson_string", i] as DataGridViewComboBoxCell).Items.IndexOf(planTable["lesson_string", i].Value);
            }
            locationsBindingSource.EndEdit();
            int q = locationsTableAdapter.Update(tech_inspectorDataSet.locations);
            tech_inspectorDataSet.locations.AcceptChanges();
            if (q > 0)
                MessageBox.Show("Зміни збережено", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StringColLoader();
        }

        public PreventionCalendar()
        {
            InitializeComponent();
        }

        private void blockInput_CheckedChanged(object sender, EventArgs e)
        {
            planTable.ReadOnly = blockInput.Checked;
            planTable.Columns[1].ReadOnly = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void PreventionCalendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataRow row in tech_inspectorDataSet.locations.Rows)
                if (row.RowState == DataRowState.Modified)
                {
                    if (MessageBox.Show("Зберегти внесені зміни?", "Незбережені зміни",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        SaveChanges();
                    break;
                }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^c");
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^x");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^v");
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            Close();
        }

        private void StringColLoader()
        {
            for (int i = 0; i < planTable.RowCount; i++)
            {
                planTable["day_string", i].Value = (planTable["day_string", i] as DataGridViewComboBoxCell).Items[(int)planTable[5, i].Value];
                planTable["lesson_string", i].Value = (planTable["lesson_string", i] as DataGridViewComboBoxCell).Items[(int)planTable[6, i].Value];
            }
        }

        private void PreventionCalendar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tech_inspectorDataSet.locations' table. You can move, or remove it, as needed.
            this.locationsTableAdapter.Fill(this.tech_inspectorDataSet.locations);
            // TODO: This line of code loads data into the 'tech_inspectorDataSet.days_of_the_week' table. You can move, or remove it, as needed.
            this.locationsTableAdapter.Fill(this.tech_inspectorDataSet.locations);
            StringColLoader();
        }

        private void planTable_Sorted(object sender, EventArgs e)
        {
            StringColLoader();
        }

        private void planTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
                planTable[5, e.RowIndex].Value = (planTable["day_string", e.RowIndex] as DataGridViewComboBoxCell).Items.IndexOf(planTable["day_string", e.RowIndex].Value);
            if (e.ColumnIndex == 4)
                planTable[6, e.RowIndex].Value = (planTable["lesson_string", e.RowIndex] as DataGridViewComboBoxCell).Items.IndexOf(planTable["lesson_string", e.RowIndex].Value);
        }
    }
}
