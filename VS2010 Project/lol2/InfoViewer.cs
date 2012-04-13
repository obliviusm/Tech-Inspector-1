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

namespace lol2
{
    public partial class InfoViewer : Form
    {
        public InfoViewer()
        {
            InitializeComponent();
        }
     
        private void новийФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDevice childFormAddDevice = new AddDevice();
            childFormAddDevice.ShowDialog();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void редагуванняШаблонівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceTemplateEditor childFormDeviceTemplateEditor = new DeviceTemplateEditor();
            childFormDeviceTemplateEditor.Show();
        }

        private void deleteDeviceButton_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Ви дійсно бажаєте видалити виділене обладнання з БД ?", "Увага",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
            //    DialogResult.Yes)
            //{
            //    List<int> delrows = new List<int>();
            //    for (int i = 0; i < infosDataGridView.SelectedCells.Count; ++i)
            //    {
            //        int index = infosDataGridView.SelectedCells[i].RowIndex;
            //        if (!delrows.Contains(index))
            //            delrows.Add(index);
            //    }
            //    for (int i = 0; i < delrows.Count; ++i)
            //    {
            //        DatabaseManager.GetDataCollection("equipments").Remove(new QueryDocument("inventory_number", (string)infosDataGridView.Rows[i].Cells[0].Value));
            //    }
            //    FillDataGrid();
            //}
        }

        private void addDeviceButton_Click(object sender, EventArgs e)
        {
            AddDevice childFormAddDevice = new AddDevice();
            childFormAddDevice.ShowDialog();
        }

        private void editInfoButton_Click(object sender, EventArgs e)
        {

        }

        private void detailedInfoButton_Click(object sender, EventArgs e)
        {
            List<int> showrows = new List<int>();
            for (int i = 0; i < infosDataGridView.SelectedCells.Count; ++i)
            {
                int index = infosDataGridView.SelectedCells[i].RowIndex;
                if (!showrows.Contains(index))
                    showrows.Add(index);
            }
            for (int i = 0; i < showrows.Count; ++i)
            {
                string inventory_number = (string)infosDataGridView.Rows[showrows[i]].Cells[0].Value;
                DetailedInfo det_info = new DetailedInfo(inventory_number);
                det_info.Show();
            }
        }

        private void InfoViewer_Load(object sender, EventArgs e)
        {
            this.statesTableAdapter.Fill(this.tech_inspectorDataSet.states);
            this.locationsTableAdapter.Fill(this.tech_inspectorDataSet.locations);
            this.typesTableAdapter.Fill(this.tech_inspectorDataSet.types);

            tech_inspectorDataSet.EnforceConstraints = false;
            this.equipment_shortinfoTableAdapter.Fill(this.tech_inspectorDataSet.equipment_shortinfo);

            infosDataGridView.Columns[tech_inspectorDataSet.equipment_shortinfo.Columns.IndexOf(tech_inspectorDataSet.equipment_shortinfo.state_idColumn)].Visible = false;
            infosDataGridView.Columns[tech_inspectorDataSet.equipment_shortinfo.Columns.IndexOf(tech_inspectorDataSet.equipment_shortinfo.location_idColumn)].Visible = false;
            infosDataGridView.Columns[tech_inspectorDataSet.equipment_shortinfo.Columns.IndexOf(tech_inspectorDataSet.equipment_shortinfo.type_idColumn)].Visible = false;

            tech_inspectorDataSet.states.Rows.Add(new object[]{0, "Всі"});
            statesBindingSource.Sort = tech_inspectorDataSet.states.state_idColumn.ColumnName;

            tech_inspectorDataSet.locations.Rows.Add(new object[] { 0, "Всі" });
            locationsBindingSource.Sort = tech_inspectorDataSet.locations.location_idColumn.ColumnName;

            tech_inspectorDataSet.types.Rows.Add(new object[] { 0, "Всі" });
            typesBindingSource.Sort = tech_inspectorDataSet.types.type_idColumn.ColumnName;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string filter_str = "";
            if ((int)locationComboBox.SelectedValue != 0)
            {
                filter_str += "location_id = " + locationComboBox.SelectedValue + " AND ";
            }
            if ((int)typeSelectionComboBox.SelectedValue != 0)
            {
                filter_str += "type_id = " + typeSelectionComboBox.SelectedValue + " AND ";
            }
            if ((int)stateComboBox.SelectedValue != 0)
            {
                filter_str += "state_id = " + stateComboBox.SelectedValue + " AND ";
            }
            if (String.IsNullOrWhiteSpace(deviceNumberTextBox.Text))
            {
                filter_str += "true";
            }
            else
            {
                int id;
                if (int.TryParse(deviceNumberTextBox.Text, out id))
                {
                    filter_str += "equipment_id = " + id;
                }
                else
                {
                    MessageBox.Show("Невірний формат інвентарного номеру", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    filter_str += "true";
                }
            }
            equipmentshortinfoBindingSource.Filter = filter_str;
        }
    }
}
