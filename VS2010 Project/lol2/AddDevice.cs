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
    public partial class AddDevice : Form
    {
        private DataTable attrDT { get; set; }
        private DataView view { get; set; }

        public AddDevice()
        {
            InitializeComponent();
        }

        private void AddDevice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tech_inspectorDataSet.states' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.tech_inspectorDataSet.states);
            // Fill all DataSet with data from MySQL tables
            tech_inspectorDataSet.EnforceConstraints = false;

            this.equipmentsTableAdapter.Fill(this.tech_inspectorDataSet.equipments);
            this.equipments_has_attributesTableAdapter.Fill(this.tech_inspectorDataSet.equipments_has_attributes);
            this.attributesTableAdapter.Fill(this.tech_inspectorDataSet.attributes);
            this.locationsTableAdapter.Fill(this.tech_inspectorDataSet.locations);
            this.typesTableAdapter.Fill(this.tech_inspectorDataSet.types);

            tech_inspectorDataSet.EnforceConstraints = true;
            
            // Create copy of attributrs DataTable
            attrDT = tech_inspectorDataSet.attributes.Copy();

            // Add two columns ('attribute_value', 'equipment_id') to fill it in DataGrid and merge with 'equipments_has_attributes'
            string attrValueColumnName = tech_inspectorDataSet.equipments_has_attributes.attribute_valueColumn.ColumnName;
            Type attrValueColumnType = tech_inspectorDataSet.equipments_has_attributes.attribute_valueColumn.DataType;
            DataColumn attrValueColumn = new DataColumn(attrValueColumnName, attrValueColumnType);
            attrValueColumn.DefaultValue = String.Empty;
            attrDT.Columns.Add(attrValueColumn);

            string eqIdColumnName = tech_inspectorDataSet.equipments_has_attributes.equipment_idColumn.ColumnName;
            Type eqIdColumnType = tech_inspectorDataSet.equipments_has_attributes.equipment_idColumn.DataType;
            attrDT.Columns.Add(new DataColumn(eqIdColumnName, eqIdColumnType));

            // Create DataView to filter all attributes by value of 'type_id'
            view = attrDT.DefaultView;
            view.RowFilter = "type_id = " + typeSelectionComboBox.SelectedValue.ToString();
            configurationDataGridView.DataSource = view;

            //Edit DataGrid
            configurationDataGridView.Columns[tech_inspectorDataSet.attributes.attribute_idColumn.ColumnName].Visible = false;
            configurationDataGridView.Columns[tech_inspectorDataSet.attributes.type_idColumn.ColumnName].Visible = false;
            configurationDataGridView.Columns[tech_inspectorDataSet.equipments_has_attributes.equipment_idColumn.ColumnName].Visible = false;
            configurationDataGridView.Columns[tech_inspectorDataSet.attributes.requiredColumn.ColumnName].ReadOnly = true;
            configurationDataGridView.Columns[tech_inspectorDataSet.attributes.attribute_nameColumn.ColumnName].ReadOnly = true;
            configurationDataGridView.Columns[tech_inspectorDataSet.attributes.requiredColumn.ColumnName].Width = 55;            
        }

        private void typeSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeSelectionComboBox.SelectedValue != null)
            {
                view.RowFilter = "type_id = " + typeSelectionComboBox.SelectedValue.ToString();
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            string emptyFields = EmptyFields();
            if (emptyFields.Length > 2)
                MessageBox.Show("Наступні обов'язкові поля не були заповнені :" + emptyFields, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    //Add new equipment to 'equipments'
                    DataRow equipmentDataRow = tech_inspectorDataSet.equipments.NewRow();                    

                    equipmentDataRow[tech_inspectorDataSet.equipments.equipment_idColumn] = int.Parse(deviceNumberTextBox.Text);
                    equipmentDataRow[tech_inspectorDataSet.equipments.type_idColumn] = typeSelectionComboBox.SelectedValue;
                    equipmentDataRow[tech_inspectorDataSet.equipments.location_idColumn] = locationComboBox.SelectedValue;
                    equipmentDataRow[tech_inspectorDataSet.equipments.state_idColumn] = stateSelectComboBox.SelectedValue;
                    float price;
                    float.TryParse(priceTextBox.Text, out price);
                    equipmentDataRow[tech_inspectorDataSet.equipments.priceColumn] = price;
                    if (purchaseDateTimePicker.Checked)
                    {
                        equipmentDataRow[tech_inspectorDataSet.equipments.purchase_dateColumn] = purchaseDateTimePicker.Value;
                    }
                    if (placementDateTimePicker.Checked)
                    {
                        equipmentDataRow[tech_inspectorDataSet.equipments.placement_dateColumn] = placementDateTimePicker.Value;
                    } 
                    if (warrantyEndDateTimePicker.Checked)
                    {
                        equipmentDataRow[tech_inspectorDataSet.equipments.warranty_end_dateColumn] = warrantyEndDateTimePicker.Value;
                    }
                    tech_inspectorDataSet.equipments.Rows.Add(equipmentDataRow);
                    equipmentsTableAdapter.Update(tech_inspectorDataSet.equipments);

                    //Add attribute list to 'equipment_has_attributes'
                    int equip_id;
                    int.TryParse(deviceNumberTextBox.Text, out equip_id); //TODO: Сделать проверку
                    foreach (DataRow r in attrDT.Rows)
                    {
                        r[tech_inspectorDataSet.equipments_has_attributes.equipment_idColumn.ColumnName] = equip_id;
                    }
                    tech_inspectorDataSet.equipments_has_attributes.Merge(view.ToTable(), true, MissingSchemaAction.Ignore);
                    equipments_has_attributesTableAdapter.Update(tech_inspectorDataSet.equipments_has_attributes);
                    MessageBox.Show("Обладнання успішно додано.","Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (System.Data.ConstraintException)
                {
                    MessageBox.Show("Обладнання з таким інвентарним номером вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string EmptyFields()
        {
            string result = "\n";
            if (deviceNumberTextBox.Text == "") result += "\tІнвентарний номер\n";
            if (locationComboBox.Text == "") result += "\tРозташування\n";
            if (stateSelectComboBox.Text == "") result += "\tТехнічний стан\n";
            if (typeSelectionComboBox.Text == "")
                result += "\tТип обладнання\n";
            else
                for (int i = 0; i < configurationDataGridView.Rows.Count; ++i)
                    if ((bool)configurationDataGridView.Rows[i].Cells["required"].Value == true &&
                        String.IsNullOrWhiteSpace((string)configurationDataGridView.Rows[i].Cells["attribute_value"].Value))
                    {
                        result += "\t" + (string)configurationDataGridView.Rows[i].Cells["attribute_name"].Value + "\n";
                    }
            return result;
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void редагуватиТипиОбладнанняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeviceTemplateEditor(typeSelectionComboBox.Text).ShowDialog();
        }

        //private string GetSelectedRowNames()
        //{
        //    string result = "\n";
        //    for (int i = 0; i < configurationDataGridView.SelectedRows.Count; i++)
        //    {
        //        for (int j = 0; j < configurationDataGridView.SelectedRows[i].Cells.Count; j++)
        //        {
        //            result += configurationDataGridView.SelectedRows[i].Cells[j].Value.ToString();
        //            result += "  ";
        //        }
        //        result += "\n";
        //    }
        //    return result;
        //}

        //private void removeSelectedAttrButton_Click(object sender, EventArgs e)
        //{
        //    if (configurationDataGridView.SelectedRows.Count == 0)
        //        MessageBox.Show("Не вибрано жодного рядку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    else
        //    {
        //        if (configurationDataGridView.SelectedRows.Count > 0)
        //            if (MessageBox.Show("Ви дійсно бажаєте видалити наступний набір рядків?" + GetSelectedRowNames(), "Попередження",
        //                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
        //                return;
        //        string removeErrors = "\n";
        //        for (int i = configurationDataGridView.SelectedRows.Count - 1; i >= 0; i--)
        //        {
        //            string type = (string)configurationDataGridView.SelectedRows[i].Cells[0].Value;
        //            if (type[type.Length - 1] != '*') // It's not compulsory?
        //                configurationDataGridView.Rows.Remove(configurationDataGridView.SelectedRows[i]);
        //            else removeErrors += configurationDataGridView.SelectedRows[i].Cells[0].Value+"\n";
        //        }
        //        if (removeErrors.Length > 2)
        //            MessageBox.Show("Наступні рядки не були видалені, оскільки вони є обов'язковими :"+
        //                removeErrors,"Увага",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        //    }
        //}
    }
}
