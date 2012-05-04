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
            try
            {
                locationsBindingSource.EndEdit();
                int q = locationsTableAdapter.Update(tech_inspectorDataSet.locations);
                tech_inspectorDataSet.locations.AcceptChanges();
                if (q > 0)
                {
                    MessageBox.Show("Зміни збережено", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Виникла помилка\n"+e.Message, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public PreventionCalendar()
        {
            InitializeComponent();
        }

        private void blockInput_CheckedChanged(object sender, EventArgs e)
        {
            planTable.ReadOnly = blockInput.Checked;
            locationidDataGridViewTextBoxColumn.ReadOnly = true;
            lastprophylaxisDataGridViewTextBoxColumn.ReadOnly = true;
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

        private void PreventionCalendar_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable daysDataTable = new DataTable();
                DataColumn day_id = new DataColumn("day_id", typeof(int));
                DataColumn day_name_id = new DataColumn("day_name_id", typeof(String));
                daysDataTable.Columns.Add(day_id);
                daysDataTable.Columns.Add(day_name_id);
                daysDataTable.Rows.Add(new object[] { 0, "Не вибраний" });
                daysDataTable.Rows.Add(new object[] { 1, "Понеділок" });
                daysDataTable.Rows.Add(new object[] { 2, "Вівторок" });
                daysDataTable.Rows.Add(new object[] { 3, "Середа" });
                daysDataTable.Rows.Add(new object[] { 4, "Четвер" });
                daysDataTable.Rows.Add(new object[] { 5, "П'ятниця" });
                daysDataTable.Rows.Add(new object[] { 6, "Субота" });
                daysDataTable.Rows.Add(new object[] { 7, "Неділя" });

                this.day_index_DataGridViewColumn.DataSource = daysDataTable;
                this.day_index_DataGridViewColumn.DisplayMember = "day_name_id";
                this.day_index_DataGridViewColumn.ValueMember = "day_id";

                DataTable lessonsDataTable = new DataTable();
                DataColumn lesson_id = new DataColumn("lesson_id", typeof(int));
                DataColumn lesson_name_id = new DataColumn("lesson_name_id", typeof(String));
                lessonsDataTable.Columns.Add(lesson_id);
                lessonsDataTable.Columns.Add(lesson_name_id);
                lessonsDataTable.Rows.Add(new object[] { 0, "Не вибрано" });
                lessonsDataTable.Rows.Add(new object[] { 1, "1" });
                lessonsDataTable.Rows.Add(new object[] { 2, "2" });
                lessonsDataTable.Rows.Add(new object[] { 3, "3" });
                lessonsDataTable.Rows.Add(new object[] { 4, "4" });
                lessonsDataTable.Rows.Add(new object[] { 5, "5" });
                lessonsDataTable.Rows.Add(new object[] { 6, "6" });
                lessonsDataTable.Rows.Add(new object[] { 7, "7" });

                this.lesson_idDataGridViewColumn.DataSource = lessonsDataTable;
                this.lesson_idDataGridViewColumn.DisplayMember = "lesson_name_id";
                this.lesson_idDataGridViewColumn.ValueMember = "lesson_id";

                // TODO: This line of code loads data into the 'tech_inspectorDataSet.locations' table. You can move, or remove it, as needed.
                this.locationsTableAdapter.Fill(this.tech_inspectorDataSet.locations);
            }
            catch (Exception err)
            {
                MessageBox.Show("Виникла помилка\n" + err.Message, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this,
                    System.IO.Path.GetFullPath(Properties.Settings.Default.HelpPath));
            }
            catch (Exception err)
            {
                MessageBox.Show("Виникла помилка\n" + err.Message, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
