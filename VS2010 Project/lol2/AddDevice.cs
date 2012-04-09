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
            purchaseDateTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            placementDateTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            serviceEndTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void AddDevice_Load(object sender, EventArgs e)
        {
            tech_inspectorDataSet.EnforceConstraints = false;
            this.equipmentsTableAdapter.Fill(this.tech_inspectorDataSet.equipments);
            this.equipments_has_attributesTableAdapter.Fill(this.tech_inspectorDataSet.equipments_has_attributes);
            this.attributesTableAdapter.Fill(this.tech_inspectorDataSet.attributes);
            this.locationsTableAdapter.Fill(this.tech_inspectorDataSet.locations);
            this.typesTableAdapter.Fill(this.tech_inspectorDataSet.types);

            tech_inspectorDataSet.EnforceConstraints = true;

            attrDT = tech_inspectorDataSet.attributes.Copy();

            string attrValueColumnName = tech_inspectorDataSet.equipments_has_attributes.attribute_valueColumn.ColumnName;
            Type attrValueColumnType = tech_inspectorDataSet.equipments_has_attributes.attribute_valueColumn.DataType;
            DataColumn attrValueColumn = new DataColumn(attrValueColumnName, attrValueColumnType);
            attrValueColumn.DefaultValue = String.Empty;
            attrDT.Columns.Add(attrValueColumn);

            string eqIdColumnName = tech_inspectorDataSet.equipments_has_attributes.equipment_idColumn.ColumnName;
            Type eqIdColumnType = tech_inspectorDataSet.equipments_has_attributes.equipment_idColumn.DataType;
            attrDT.Columns.Add(new DataColumn(eqIdColumnName, eqIdColumnType));

            view = attrDT.DefaultView;
            view.RowFilter = "type_id = " + typeSelectionComboBox.SelectedValue.ToString();
            configurationDataGridView.DataSource = view;
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
                    float price;
                    float.TryParse(priceTextBox.Text, out price);
                    tech_inspectorDataSet.equipments.Rows.Add(new object[] { 
                    int.Parse(deviceNumberTextBox.Text),
                    typeSelectionComboBox.SelectedValue,
                    locationComboBox.SelectedValue,
                    1,
                    price//,
                    //DateTime.Today,
                    //DateTime.Today,
                    //DateTime.Today
                });
                    equipmentsTableAdapter.Update(tech_inspectorDataSet.equipments);
                    //Add attribute list to 'equipment_has_attributes'
                    foreach (DataRow r in attrDT.Rows)
                    {
                        r[tech_inspectorDataSet.equipments_has_attributes.equipment_idColumn.ColumnName] = int.Parse(deviceNumberTextBox.Text);
                    }
                    DataTable copyEquipmentHas = tech_inspectorDataSet.equipments_has_attributes.Clone();
                    tech_inspectorDataSet.equipments_has_attributes.Merge(view.ToTable(), true, MissingSchemaAction.Ignore);
                    equipments_has_attributesTableAdapter.Update(tech_inspectorDataSet.equipments_has_attributes);
                    //this.Close();
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
            if (typeSelectionComboBox.Text == "")
                result += "\tТип обладнання\n";
            else
                for (int i = 0; i < configurationDataGridView.Rows.Count; ++i)
                    if (String.IsNullOrWhiteSpace((string)configurationDataGridView.Rows[i].Cells["attribute_value"].Value))
                        result += "\t" + (string)configurationDataGridView.Rows[i].Cells["attribute_name"].Value + "\n";
            return result;
        }

        private void addAttrToGrid(string attrName)
        {
            bool noContains = true;
            foreach (DataGridViewRow row in configurationDataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString() == attrName)
                    noContains = false;
            }
            if (!String.IsNullOrWhiteSpace(attrName) && noContains)
                configurationDataGridView.Rows.Add(attrName, "");
            else if (noContains == false)
            {
                MessageBox.Show("Атрибут " + attrName + " уже присутній", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (attrName != null)
            {
                MessageBox.Show("Оберіть атрибут або додайте новий", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void editTypeButton_Click(object sender, EventArgs e)
        {
            if (typeSelectionComboBox.SelectedIndex != -1)
            {
                DeviceTemplateEditor childFormDeviceTemplateEditor = 
                    new DeviceTemplateEditor(typeSelectionComboBox.Text);
                childFormDeviceTemplateEditor.Show();
            }
        }

        private void addNewTypeButton_Click(object sender, EventArgs e)
        {
            DeviceTemplateEditor childFormDeviceTemplateEditor = new DeviceTemplateEditor();
            childFormDeviceTemplateEditor.Show();
        }

        private void редагуватиТипиОбладнанняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeviceTemplateEditor(typeSelectionComboBox.Text).ShowDialog();
        }

        private string GetSelectedRowNames()
        {
            string result = "\n";
            for (int i = 0; i < configurationDataGridView.SelectedRows.Count; i++)
            {
                for (int j = 0; j < configurationDataGridView.SelectedRows[i].Cells.Count; j++)
                {
                    result += configurationDataGridView.SelectedRows[i].Cells[j].Value.ToString();
                    result += "  ";
                }
                result += "\n";
            }
            return result;
        }

        private void removeSelectedAttrButton_Click(object sender, EventArgs e)
        {
            if (configurationDataGridView.SelectedRows.Count == 0)
                MessageBox.Show("Не вибрано жодного рядку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (configurationDataGridView.SelectedRows.Count > 0)
                    if (MessageBox.Show("Ви дійсно бажаєте видалити наступний набір рядків?" + GetSelectedRowNames(), "Попередження",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        return;
                string removeErrors = "\n";
                for (int i = configurationDataGridView.SelectedRows.Count - 1; i >= 0; i--)
                {
                    string type = (string)configurationDataGridView.SelectedRows[i].Cells[0].Value;
                    if (type[type.Length - 1] != '*') // It's not compulsory?
                        configurationDataGridView.Rows.Remove(configurationDataGridView.SelectedRows[i]);
                    else removeErrors += configurationDataGridView.SelectedRows[i].Cells[0].Value+"\n";
                }
                if (removeErrors.Length > 2)
                    MessageBox.Show("Наступні рядки не були видалені, оскільки вони є обов'язковими :"+
                        removeErrors,"Увага",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void fillByTypesAndSortByIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.typesTableAdapter.FillByTypesAndSortByID(this.tech_inspectorDataSet.types);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
