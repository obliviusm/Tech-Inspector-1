﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lol2
{
    public partial class EquipmentByDate : Form
    {
        public EquipmentByDate()
        {
            InitializeComponent();
        }
        public void SetPrivileges()
        {
            if (Login.getRoleId() == 1)
            {
                editInfoButton.Enabled = true;
                addDeviceButton.Enabled = true;
                deleteDeviceButton.Enabled = true;
                menuStrip1.Enabled = true;
            }
            else if (Login.getRoleId() == 2)
            {
                editInfoButton.Enabled = true;
                addDeviceButton.Enabled = true;
                deleteDeviceButton.Enabled = true;
                menuStrip1.Enabled = false;
            }
            else
            {
                editInfoButton.Enabled = false;
                addDeviceButton.Enabled = false;
                deleteDeviceButton.Enabled = false;
                menuStrip1.Enabled = false;
            }
        }
        private void EquipmentByDate_Load(object sender, EventArgs e)
        {
            SetPrivileges();
            //this.statesTableAdapter.Fill(this.tech_inspectorDataSet.states);
            //this.locationsTableAdapter.Fill(this.tech_inspectorDataSet.locations);
            this.typesTableAdapter.Fill(this.tech_inspectorDataSet.types);


            tech_inspectorDataSet.EnforceConstraints = false;
            this.equipment_shortinfoTableAdapter.Fill(this.tech_inspectorDataSet.equipment_shortinfo);

            //tech_inspectorDataSet.states.Rows.Add(new object[] { 0, "Всі" });
            //stateComboBox.SelectedValue = 0;
            //tech_inspectorDataSet.locations.Rows.Add(new object[] { 0, "Всі" });
            //locationComboBox.SelectedValue = 0;
            tech_inspectorDataSet.types.Rows.Add(new object[] { 0, "Всі" });
            typeSelectionComboBox.SelectedValue = 0;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string filter_str = "";
            if ((int)typeSelectionComboBox.SelectedValue != 0)
            {
                filter_str += "type_id = " + typeSelectionComboBox.SelectedValue + " AND ";
            }
            if (fromPurchaseDateTimePicker.Checked)
            {
                filter_str += "purchase_date >= '" + fromPurchaseDateTimePicker.Value + "' AND ";
            }
            if (toPurchaseDateTimePicker.Checked)
            {
                filter_str += "purchase_date <= '" + toPurchaseDateTimePicker.Value + "' AND ";
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
                int id = (int)infosDataGridView.Rows[showrows[i]].Cells[0].Value;
                DetailedInfo det_info = new DetailedInfo(id);
                det_info.Show();
            }
        }

        private void editInfoButton_Click(object sender, EventArgs e)
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
                int id = (int)infosDataGridView.Rows[showrows[i]].Cells[0].Value;
                EditEquipment edit_form = new EditEquipment(id);
                edit_form.ShowDialog();
            }
            this.equipment_shortinfoTableAdapter.Fill(this.tech_inspectorDataSet.equipment_shortinfo);
        }

        private void addDeviceButton_Click(object sender, EventArgs e)
        {
            AddDevice childFormAddDevice = new AddDevice();
            childFormAddDevice.ShowDialog();
            this.equipment_shortinfoTableAdapter.Fill(this.tech_inspectorDataSet.equipment_shortinfo);
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
                    int id = (int)infosDataGridView.Rows[delrows[i]].Cells[0].Value;
                    tech_inspectorDataSet.equipment_shortinfo.FindByequipment_id(id).Delete();
                    int q = equipment_shortinfoTableAdapter.Update(tech_inspectorDataSet.equipment_shortinfo);
                    MessageBox.Show("Видалено записів: " + q, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tech_inspectorDataSet.equipment_shortinfo.AcceptChanges();
                }
            }
        }

    }
}