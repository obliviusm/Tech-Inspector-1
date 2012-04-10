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
            string connStr = "server=localhost;user=root;database=tech_inspector;port=3306;password=1111;";
            MySqlConnection conn = new MySqlConnection(connStr);
            string sql = "SELECT equipments.equipment_id, types.type_name, locations.location_name, states.state_name, equipments.price, equipments.purchase_date,"
             + " equipments.placement_date, equipments.warranty_end_date"
             + " FROM equipments INNER JOIN"
             + " locations ON equipments.location_id = locations.location_id INNER JOIN"
             + " states ON equipments.state_id = states.state_id INNER JOIN"
             + " types ON equipments.type_id = types.type_id";
            MySqlDataAdapter equipmentListAdapter = new MySqlDataAdapter(sql, conn);
            //DataSet equipmentListDataSet = new DataSet();
            //equipmentListAdapter.Fill(equipmentListDataSet, "EquipmentList");
            DataTable equipmentListDataTable = new DataTable("EquipmentList");
            equipmentListAdapter.Fill(equipmentListDataTable);
            DataView equipmentListViewTable = equipmentListDataTable.DefaultView;
            infosDataGridView.DataSource = equipmentListViewTable;
            //typeSelectionComboBox.SelectedIndex = typeSelectionComboBox.Items.Add("Всі");
            //locationComboBox.SelectedIndex = locationComboBox.Items.Add("Всі");
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
            // TODO: This line of code loads data into the 'tech_inspectorDataSet.locations' table. You can move, or remove it, as needed.
            this.locationsTableAdapter.Fill(this.tech_inspectorDataSet.locations);
            // TODO: This line of code loads data into the 'tech_inspectorDataSet.types' table. You can move, or remove it, as needed.
            this.typesTableAdapter.Fill(this.tech_inspectorDataSet.types);

            //foreach (var tec in collection)
            //{
                
            //}
        }

        private void typeSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
