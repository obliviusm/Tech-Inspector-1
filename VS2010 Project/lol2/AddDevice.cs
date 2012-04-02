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

        private void AddDevice_Load(object sender, EventArgs e)
        {
            // Fill DB with sample types of equipment
            #region FillDatabaseWithTypesOfEquipment

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
                typeSelectionComboBox.Items.Add((string)item["name"]);
            }
            // Fill DB with sample locations
            #region FillDatabaseWithLocations

            //DatabaseManager.GetDataCollection("locations").RemoveAll();

            //DatabaseManager.GetDataCollection("locations").Insert(new BsonDocument("name", "430"));
            //DatabaseManager.GetDataCollection("locations").Insert(new BsonDocument("name", "433"));
            //DatabaseManager.GetDataCollection("locations").Insert(new BsonDocument("name", "429/1"));
            //DatabaseManager.GetDataCollection("locations").Insert(new BsonDocument("name", "429/2"));
            //DatabaseManager.GetDataCollection("locations").Insert(new BsonDocument("name", "428"));
            //DatabaseManager.GetDataCollection("locations").Insert(new BsonDocument("name", "426"));
            //DatabaseManager.GetDataCollection("locations").Insert(new BsonDocument("name", "416/1"));
            //DatabaseManager.GetDataCollection("locations").Insert(new BsonDocument("name", "416/2"));
            //DatabaseManager.GetDataCollection("locations").Insert(new BsonDocument("name", "417"));
            //DatabaseManager.GetDataCollection("locations").Insert(new BsonDocument("name", "229/1"));
            //DatabaseManager.GetDataCollection("locations").Insert(new BsonDocument("name", "229/2"));
            //DatabaseManager.GetDataCollection("locations").Insert(new BsonDocument("name", "229/3"));
            //DatabaseManager.GetDataCollection("locations").Insert(new BsonDocument("name", "323"));

            #endregion
            // Load locations from DB to ComboBox
            foreach (BsonDocument item in DatabaseManager.GetDataCollection("locations").Find(new QueryDocument()))
            {
                locationComboBox.Items.Add((string)item["name"]);
            }
            configurationGroupBox.Enabled = false;
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
            new DeviceTemplateEditor(typeSelectionComboBox.Text).ShowDialog();
        }

        private string EmptyFields()
        {
            string result = "\n";
            if (deviceNumberTextBox.Text == "") result += "\tІнвентарний номер\n";
            if (locationComboBox.Text == "") result += "\tРозташування\n";
            if (typeSelectionComboBox.Text == "") 
                result += "\tТип обладнання\n";
            else
                for(int i = 0; i < configurationDataGridView.Rows.Count; ++i)
                    if ((string)configurationDataGridView.Rows[i].Cells[1].Value == "")
                        result += "\t" + (string)configurationDataGridView.Rows[i].Cells[0].Value + "\n";
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
                BsonDocument item = new BsonDocument();
                item.Add("inventory_number", deviceNumberTextBox.Text);
                item.Add("type", typeSelectionComboBox.Text);
                item.Add("location", locationComboBox.Text);
                float price;
                if (!String.IsNullOrWhiteSpace(priceTextBox.Text) && float.TryParse("1", out price))
                {
                    item.Add("price", price);
                }
                if (!String.IsNullOrWhiteSpace(purchaseDateTextBox.Text))
                {
                    item.Add("purchase_date", purchaseDateTextBox.Text);
                }
                if (!String.IsNullOrWhiteSpace(placementDateTextBox.Text))
                {
                    item.Add("placement_date", placementDateTextBox.Text);
                }
                if (!String.IsNullOrWhiteSpace(serviceEndTextBox.Text))
                {
                    item.Add("servise_end_date", serviceEndTextBox.Text);
                }
                BsonArray attr = new BsonArray();
                for (int i = 0; i < configurationDataGridView.Rows.Count; ++i)
                {
                    bool compulsory = false;
                    string atr = (string)configurationDataGridView.Rows[i].Cells[0].Value;
                    if (atr.LastIndexOf('*') == (atr.Length - 1))
                    {
                        compulsory = true;
                        atr.Remove(atr.Length - 2);
                    }
                    attr.Add(new BsonDocument{ { "attr_name", atr},{"value", (string)configurationDataGridView.Rows[i].Cells[1].Value}, {"compulsory",compulsory}});
                }
                item.Add("attr", attr);
                DatabaseManager.GetDataCollection("equipments").Insert(item);
                MessageBox.Show("Обладнання успішно додане до бази даних!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Close();
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
    }
}
