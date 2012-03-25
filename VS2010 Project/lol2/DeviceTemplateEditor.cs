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
    public partial class DeviceTemplateEditor : Form
    {
        #region Declarations

        private string initialTemplateName = "";
        private bool TypeEditingActive
        {
            set
            {
                configurationGroupBox.Enabled = value;
                saveChangesButton.Enabled = value;
                abortChangesButton.Enabled = value;
                removeTypeButton.Enabled = value;
            }
        }

        #endregion

        public DeviceTemplateEditor()
        {
            InitializeComponent();
            TypeEditingActive = false;
            chooseTypeButton.Enabled = false;
            configurationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Load types of equipment from DB to ComboBox
            foreach (BsonDocument item in DatabaseManager.GetDataCollection("equipment_types").Find(new QueryDocument()))
            {
                typeSelectionComboBox.Items.Add((string)item["name"]);
            } 
        }

        public DeviceTemplateEditor(string editType)
        {
            InitializeComponent();
            TypeEditingActive = false;
            chooseTypeButton.Enabled = false;
            configurationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Load types of equipment from DB to ComboBox
            foreach (BsonDocument item in DatabaseManager.GetDataCollection("equipment_types").Find(new QueryDocument()))
            {
                typeSelectionComboBox.Items.Add((string)item["name"]);
            }
            if (typeSelectionComboBox.Items.IndexOf(editType) > -1)
            {
                typeSelectionComboBox.SelectedIndex = typeSelectionComboBox.Items.IndexOf(editType);
                TypeEditingActive = true;
                chooseTypeButton.Enabled = true;
                LoadAttrToDataGrid(editType);
                typeNameTextBox.Text = editType;
            }
        }

        private void LoadAttrToDataGrid(string type)
        {
            // Clear available data
            configurationDataGridView.Rows.Clear();
            // Get elements of Array with attributes for current type of equipment
            var attr_arr = DatabaseManager.GetDataCollection("equipment_types").FindOne(new QueryDocument { { "name", type } })["attr"];
            if (attr_arr.IsBsonArray)
            {
                foreach (BsonDocument item in attr_arr.AsBsonArray)
                {
                    if (item["compulsory"].AsBoolean)
                        configurationDataGridView.Rows.Add((string)item["attr_name"], true);
                    else
                    {
                        //if not compulsory
                        configurationDataGridView.Rows.Add((string)item["attr_name"], false);
                    }
                }
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

        private void deleteParameterButton_Click(object sender, EventArgs e)
        {
            if (configurationDataGridView.SelectedRows.Count == 0)
                MessageBox.Show("Не вибрано жодного рядку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (configurationDataGridView.SelectedRows.Count > 0)
                    if (MessageBox.Show("Ви дійсно бажаєте видалити наступний набір рядків?" + GetSelectedRowNames(), "Попередження",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        return;
                for (int i = configurationDataGridView.SelectedRows.Count - 1; i >= 0; i--)
                    configurationDataGridView.Rows.Remove(configurationDataGridView.SelectedRows[i]);
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (typeNameTextBox.Text == "")
                MessageBox.Show("Поле назви типу не заповнене", "Помилка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (configurationDataGridView.Rows.Count < 1)
                MessageBox.Show("Таблиця атрибутів не може бути пустою", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                initialTemplateName = typeNameTextBox.Text;
                BsonDocument type = new BsonDocument("name", typeNameTextBox.Text);
                BsonArray attr = new BsonArray();
                for(int i=0; i< configurationDataGridView.Rows.Count; ++i)
                {
                    attr.Add(new BsonDocument{ {"attr_name", (string)configurationDataGridView.Rows[i].Cells[0].Value},
                        {"compulsory",(bool)configurationDataGridView.Rows[i].Cells[1].Value}});
                }
                type.Add("attr", attr);
                DatabaseManager.GetDataCollection("equipment_types").Update(new QueryDocument(new BsonDocument("name", initialTemplateName)), new UpdateDocument(type));
            }
        }

        private void configurationDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            deleteParameterButton.Enabled = (configurationDataGridView.SelectedRows.Count > 0);
        }

        private void addParameterButton_Click(object sender, EventArgs e)
        {
            AddingString childFormAddingParameterType = new AddingString("Введіть назву нового параметру");
            childFormAddingParameterType.ShowDialog();
            if (childFormAddingParameterType.parameterName != null)
                configurationDataGridView.Rows.Add(childFormAddingParameterType.parameterName, false);
        }

        private void typeSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseTypeButton.Enabled = true;
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void configurationDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((bool)configurationDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) // Чтото я редактировал ячейку таблицы, нажал ентер и у меня тут выскочила ошибка :)
                configurationDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CCCC33");
            else configurationDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }

        private void newTypeButton_Click(object sender, EventArgs e)
        {
            AddingString childFormAddingParameterType = new AddingString("Введіть назву нового типу обладнання");
            childFormAddingParameterType.ShowDialog();
            if (childFormAddingParameterType.parameterName != null)
            {
                initialTemplateName = childFormAddingParameterType.parameterName;
                typeNameTextBox.Text = initialTemplateName;
                TypeEditingActive = true;
                configurationDataGridView.Rows.Clear();
                typeSelectionComboBox.SelectedIndex = typeSelectionComboBox.Items.Add(initialTemplateName);
                DatabaseManager.GetDataCollection("equipment_types").Insert(new BsonDocument { { "name", initialTemplateName }, { "attr", new BsonArray() } });
            }
        }

        private void chooseTypeButton_Click(object sender, EventArgs e)
        {
            if (typeSelectionComboBox.SelectedIndex > -1)
            {
                initialTemplateName = typeSelectionComboBox.Text;
                typeNameTextBox.Text = initialTemplateName;
                TypeEditingActive = true;
                LoadAttrToDataGrid(initialTemplateName);
            }
        }

        private void removeTypeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити вибраний шаблон з бази даних ?", "Попередження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DatabaseManager.GetDataCollection("equipment_types").Remove(new QueryDocument(new BsonDocument("name", initialTemplateName)));
                typeNameTextBox.Text = "";
                configurationDataGridView.Rows.Clear();
                TypeEditingActive = false;
                typeSelectionComboBox.Items.Remove(initialTemplateName);
                typeSelectionComboBox.SelectedIndex = -1;
            }
        }

        private void abortChangesButton_Click(object sender, EventArgs e)
        {
            if (initialTemplateName == "")
                MessageBox.Show("Цей шаблон будувався 'з 0', тому відмінити зміни неможливо", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (MessageBox.Show("Ви дійсно бажаєте відхилити всі зміни застосовані до цього шаблону ?", "Попередження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                typeNameTextBox.Text = initialTemplateName;
                LoadAttrToDataGrid(initialTemplateName);
            }
        }
    }
}
