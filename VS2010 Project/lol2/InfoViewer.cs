using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace lol2
{
    public partial class InfoViewer : Form
    {
        public InfoViewer()
        {
            InitializeComponent();
            FillDataGrid();
            foreach (BsonDocument item in DatabaseManager.GetDataCollection("equipment_types").Find(new QueryDocument()))
            {
                typeSelectionComboBox.Items.Add((string)item["name"]);
            }
            typeSelectionComboBox.SelectedIndex = typeSelectionComboBox.Items.Add("Всі");
            foreach (BsonDocument item in DatabaseManager.GetDataCollection("locations").Find(new QueryDocument()))
            {
                locationComboBox.Items.Add((string)item["name"]);
            }
            locationComboBox.SelectedIndex = locationComboBox.Items.Add("Всі");
        }

        public void FillDataGrid()
        {
            infosDataGridView.Rows.Clear();
            QueryDocument query = new QueryDocument();
            if (!String.IsNullOrWhiteSpace(deviceNumberTextBox.Text))
            {
                query.Add("inventory_number", deviceNumberTextBox.Text);
            }
            if (!String.IsNullOrWhiteSpace(typeSelectionComboBox.Text) && typeSelectionComboBox.Text != "Всі")
            {
                query.Add("type", typeSelectionComboBox.Text);
            }
            if (!String.IsNullOrWhiteSpace(locationComboBox.Text) && locationComboBox.Text != "Всі")
            {
                query.Add("location", locationComboBox.Text);
            }
            foreach (BsonDocument item in DatabaseManager.GetDataCollection("equipments").Find(query))
            {
                infosDataGridView.Rows.Add((string)item["inventory_number"], (string)item["type"], (string)item["location"]);
            }
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
            if (MessageBox.Show("Ви дійсно бажаєте видалити виділене обладнання з БД ?", "Увага",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                List<int> delrows = new List<int>();
                for (int i = 0; i < infosDataGridView.SelectedCells.Count; ++i)
                {
                    int index = infosDataGridView.SelectedCells[i].RowIndex;
                    if (!delrows.Contains(index))
                        delrows.Add(index);
                }
                for (int i = 0; i < delrows.Count; ++i)
                {
                    DatabaseManager.GetDataCollection("equipments").Remove(new QueryDocument("inventory_number", (string)infosDataGridView.Rows[i].Cells[0].Value));
                }
                FillDataGrid();
            }
        }

        private void addDeviceButton_Click(object sender, EventArgs e)
        {
            AddDevice childFormAddDevice = new AddDevice();
            childFormAddDevice.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillDataGrid();
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

        }

        private void typeSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
