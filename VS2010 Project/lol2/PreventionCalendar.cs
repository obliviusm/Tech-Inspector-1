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
            locationsBindingSource.EndEdit();
            int q = locationsTableAdapter.Update(tech_inspectorDataSet.locations);
            tech_inspectorDataSet.locations.AcceptChanges();
            if (q > 0)
                MessageBox.Show("Зміни збережено", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void PreventionCalendar_Load(object sender, EventArgs e)
        {
            this.locationsTableAdapter.Fill(this.tech_inspectorDataSet.locations);

        }

        private void planTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(planTable[e.ColumnIndex, e.RowIndex].Value.ToString()))
                planTable[e.ColumnIndex, e.RowIndex].Value = null;
        }
    }
}
