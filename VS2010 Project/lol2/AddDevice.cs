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
            childFormAddingParameterType.Dispose();

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
    }
}
