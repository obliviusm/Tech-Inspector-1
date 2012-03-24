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
    public partial class AddDevice : Form
    {
        public AddDevice()
        {
            InitializeComponent();
            purchaseDateTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            placementDateTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            serviceEndTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        /// <summary>
        ///    Fill configurationDataGridView and addParameterComboBox with attributes for current type of equipment
        /// </summary>
        private void fillDataGrid()
        {
            // Clear available data
            configurationDataGridView.Rows.Clear();
            addParameterComboBox.Items.Clear();
            addParameterButton.Enabled = false;
            addParameterComboBox.Enabled = false;
            // Get elements of Array with attributes for current type of equipment
            foreach (BsonDocument item in DatabaseManager.GetDataCollection("equipment_types").FindOne(new QueryDocument { { "name", typeSelectionComboBox.Text } })["attr"].AsBsonArray)
            {
                if (item["compulsory"].AsBoolean)
                    configurationDataGridView.Rows.Add(item["attr_name"]+"*", "");
                else
                {
                    //if not compulsory
                    addParameterComboBox.Items.Add(item["attr_name"]);
                    addParameterButton.Enabled = true;
                    addParameterComboBox.Enabled = true;
                }
            }
            if (addParameterComboBox.Items.Count != 0)
                addParameterComboBox.SelectedIndex = 0;
            configurationGroupBox.Enabled = true;
        }

        private void addAttrToGrid(string attrName)
        {
            bool noContains = true;
            foreach (DataGridViewRow row in configurationDataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString() == attrName)
                    noContains = false;
            }
            if (attrName != null && attrName != "" && noContains)
                configurationDataGridView.Rows.Add(attrName, "");
            else if (noContains == false)
            {
                MessageBox.Show("Атрибут " + attrName + " уже присутній", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (attrName != null)
            {
                MessageBox.Show("Оберіть атрибут або додавйте новий", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddDevice_Load(object sender, EventArgs e)
        {
            // Initialize DB
            DatabaseManager.Initialize("tech_inspector");
            // Fill DB with sample types of equipment
            #region FillDatabase

            //DatabaseManager.GetDataCollection("equipment_types").RemoveAll();

            //DatabaseManager.GetDataCollection("equipment_types").Insert(new BsonDocument { { "name", "Комп'ютер" }, 
            //{ "attr", new BsonArray{
            //new BsonDocument{{"attr_name", "Монітор"}, {"compulsory", true}},
            //new BsonDocument{{"attr_name", "Клавіатура"}, {"compulsory", true}},
            //new BsonDocument{{"attr_name", "Миш"}, {"compulsory", true}},
            //new BsonDocument{{"attr_name", "Процесор"}, {"compulsory", true}},
            //new BsonDocument{{"attr_name", "Відеокарта"}, {"compulsory", true}},
            //new BsonDocument{{"attr_name", "HDD"}, {"compulsory", true}},
            //new BsonDocument{{"attr_name", "RAM"}, {"compulsory", true}},
            //new BsonDocument{{"attr_name", "Привід"}, {"compulsory", true}},
            //new BsonDocument{{"attr_name", "USB"}, {"compulsory", false}},
            //new BsonDocument{{"attr_name", "Bluetooth"}, {"compulsory", false}},
            //new BsonDocument{{"attr_name", "Wi-fi"}, {"compulsory", false}}
            //}}});

            //DatabaseManager.GetDataCollection("equipment_types").Insert(new BsonDocument { { "name", "Проектор" }, 
            //{ "attr", new BsonArray{
            //new BsonDocument{{"attr_name", "Виробник"}, {"compulsory", true}},
            //new BsonDocument{{"attr_name", "Модель"}, {"compulsory", true}},
            //new BsonDocument{{"attr_name", "Срок експлуатації"}, {"compulsory", false}}
            //}}});

            //DatabaseManager.GetDataCollection("equipment_types").Insert(new BsonDocument { { "name", "Принтер" }, 
            //{ "attr", new BsonArray{
            //new BsonDocument{{"attr_name", "Виробник"}, {"compulsory", true}},
            //new BsonDocument{{"attr_name", "Модель"}, {"compulsory", true}},
            //new BsonDocument{{"attr_name", "Тип (1 - струйний, 2 - лазерний)"}, {"compulsory", false}}
            //}}});

            //DatabaseManager.GetDataCollection("equipment_types").Insert(new BsonDocument { { "name", "Інше" }, 
            //{ "attr", new BsonArray{
            //new BsonDocument{{"attr_name", "Тип обладнання"}, {"compulsory", true}}
            //}}});
            #endregion
            // Load types of equipment from DB to ComboBox
            foreach (BsonDocument item in DatabaseManager.GetDataCollection("equipment_types").Find(new QueryDocument()))
            {
                typeSelectionComboBox.Items.Add(item["name"]);
            }
            configurationGroupBox.Enabled = false;
            //if (typeSelectionComboBox.Items.Count != 0)
            //    typeSelectionComboBox.SelectedIndex = 0;
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewParameterButton_Click(object sender, EventArgs e)
        {
            AddingString childFormAddingParameterType = new AddingString("Введіть назву нового параметру");
            childFormAddingParameterType.ShowDialog();
            addAttrToGrid(childFormAddingParameterType.parameterName);
        }

        private void addParameterButton_Click(object sender, EventArgs e)
        {
            addAttrToGrid(addParameterComboBox.Text);
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

        private void typeSelectionComboBox_TextChanged(object sender, EventArgs e)
        {
            fillDataGrid();
        }

        private void редагуватиТипиОбладнанняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeviceTemplateEditor().ShowDialog();
        }

        private string EmptyFields()
        {
            string result = "\n";
            if (deviceNumberTextBox.Text == "") result += "  Інвентарний номер\n";
            if (priceTextBox.Text == "") result += "  Ціна\n";
            if (locationComboBox.Text == "") result += "  Розташування\n";
            if (purchaseDateTextBox.Text == "") result += "  Дата покупки\n";
            if (placementDateTextBox.Text == "") result += "  Дата розміщення\n";
            if (serviceEndTextBox.Text == "") result += "  Кінець гарантії обслуговування\n";
            return result;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            string emptyFields = EmptyFields();
            if (emptyFields.Length>2)
                MessageBox.Show("Наступні обов'язкові поля не були заповнені :"+emptyFields, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else 
            {
                //TODO: Save item to DB
            }
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
                if (configurationDataGridView.SelectedRows.Count > 1)
                    if (MessageBox.Show("Ви дійсно бажаєте видалити наступний набір рядків?" + GetSelectedRowNames(), "Попередження",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        return;
                string removeErrors = "\n";
                for (int i = configurationDataGridView.SelectedRows.Count - 1; i >= 0; i--)
                    //if (//TODO: check if element is required)
                        configurationDataGridView.Rows.Remove(configurationDataGridView.SelectedRows[i]);
                    //else removeErrors += configurationDataGridView.SelectedRows[i].Cells[0].Value+"\n";
                if (removeErrors.Length > 2)
                    MessageBox.Show("Наступні рядки не були видалені, оскільки вони є обов'язковими :"+
                        removeErrors,"Увага",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
