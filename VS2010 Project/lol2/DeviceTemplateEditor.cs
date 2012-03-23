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
        public DeviceTemplateEditor()
        {
            InitializeComponent();
            configurationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            configurationDataGridView.Rows.Add("Процесор", "");
            configurationDataGridView.Rows.Add("Відеокарта", "");
            configurationDataGridView.Rows.Add("HDD", "(\\d){1,4} GB");
            configurationDataGridView.Rows.Add("USB", "");
            configurationDataGridView.Rows.Add("RAM", "");
            configurationDataGridView.Rows.Add("Bluetooth", "");
            configurationDataGridView.Rows.Add("Wi-fi", "");
            configurationDataGridView.Rows.Add("Привід", "");
        }

        public DeviceTemplateEditor(string editType)
        {
            InitializeComponent();
            //TODO: if type exists open it for editing
        }

        private void addParameterButton_Click(object sender, EventArgs e)
        {
            if (addParameterComboBox.Text != "")
                configurationDataGridView.Rows.Add(addParameterComboBox.Text, "");
        }

        private void addNewParameterButton_Click(object sender, EventArgs e)
        {
            AddingString childFormAddingParameterType = new AddingString("Введіть назву нового параметру");
            childFormAddingParameterType.ShowDialog();
            if (childFormAddingParameterType.parameterName != "")
                configurationDataGridView.Rows.Add(childFormAddingParameterType.parameterName, "");
            childFormAddingParameterType.Dispose();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
