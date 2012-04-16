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
        private bool changes = false;
        private string startingValue;

        private void SaveChanges()
        {
            int q = locationsTableAdapter1.Update(tech_inspectorDataSet.locations);
            tech_inspectorDataSet.locations.AcceptChanges();
            if (q > 0)
                MessageBox.Show("Зміни збережено", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            changes = false;
        }

        public PreventionCalendar()
        {
            InitializeComponent();
            locationsTableAdapter1.Fill(tech_inspectorDataSet.locations);
            planTable.DataSource = tech_inspectorDataSet.locations.DefaultView;
        }

        private void blockInput_CheckedChanged(object sender, EventArgs e)
        {
            planTable.ReadOnly = blockInput.Checked;
            planTable.Columns[0].ReadOnly = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void planTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            startingValue = planTable[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void planTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (startingValue==null || planTable[e.ColumnIndex, e.RowIndex].Value.ToString() != startingValue)
                changes = true;
        }

        private void PreventionCalendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes && MessageBox.Show("Зберегти внесені зміни?", "Незбережені зміни",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                SaveChanges();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (planTable.SelectedCells.Count == 1)
                Clipboard.SetText(planTable.SelectedCells[0].Value.ToString());
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (planTable.SelectedCells.Count == 1)
            {
                Clipboard.SetText(planTable.SelectedCells[0].Value.ToString());
                planTable.SelectedCells[0].Value = "";
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (planTable.SelectedCells.Count == 1 && planTable.SelectedCells[0].ColumnIndex!=0)
                planTable.SelectedCells[0].Value = Clipboard.GetText();
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
