using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            configurationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //TODO: Load list of templates to typeSelectionComboBox   
        }

        public DeviceTemplateEditor(string editType)
        {
            InitializeComponent();
            //TODO: if type exists open it for editing
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
                if (configurationDataGridView.SelectedRows.Count > 1)
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
                //TODO: Save template data to DB
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
            configurationGroupBox.Enabled = (typeSelectionComboBox.SelectedIndex > -1);
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void configurationDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((bool)configurationDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                configurationDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CCCC33");
            else configurationDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }

        private void newTypeButton_Click(object sender, EventArgs e)
        {
            TypeEditingActive = true;
            configurationDataGridView.Rows.Clear();
        }

        private void chooseTypeButton_Click(object sender, EventArgs e)
        {
            if (typeSelectionComboBox.SelectedIndex > -1)
            {
                initialTemplateName = typeSelectionComboBox.Text;
                typeNameTextBox.Text = initialTemplateName;
                TypeEditingActive = true;
                //TODO: Load template data from DB
                //dataGrid example
                //configurationDataGridView.Rows.Add("Процесор",true);
            }
        }

        private void removeTypeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити вибраний шаблон з бази даних ?", "Попередження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //TODO: Remove template from DB
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
                //TODO : Reload template from database
            }
        }
    }
}
