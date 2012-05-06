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


namespace lol2
{
    public partial class DeviceTemplateEditor : Form
    {
        private int type_id { get; set; }

        public DeviceTemplateEditor()
        {
            InitializeComponent();
            configurationGroupBox.Enabled = false;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(typeNameTextBox.Text))
                MessageBox.Show("Поле назви типу не заповнене", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (tech_inspectorDataSet.types.FindBytype_id(type_id).type_name != typeNameTextBox.Text || tech_inspectorDataSet.types.FindBytype_id(type_id).RowState == DataRowState.Added)
                {
                    tech_inspectorDataSet.types.FindBytype_id(type_id).type_name = typeNameTextBox.Text;
                    typesTableAdapter.Update(tech_inspectorDataSet.types);
                    tech_inspectorDataSet.types.AcceptChanges();
                }
                int q = attributesTableAdapter.Update(tech_inspectorDataSet.attributes);
                tech_inspectorDataSet.attributes.AcceptChanges();
                if (q > 0)
                {
                    MessageBox.Show("Зміни збережено", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newTypeButton_Click(object sender, EventArgs e)
        {
            AddingString childFormAddingParameterType = new AddingString("Введіть назву нового типу обладнання");
            childFormAddingParameterType.ShowDialog();
            if (!String.IsNullOrWhiteSpace(childFormAddingParameterType.parameterName))
            {
                if (typeSelectionComboBox.Items.Contains(childFormAddingParameterType.parameterName))
                {
                    MessageBox.Show("Тип з таким ім'ям уже існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string new_type_name = childFormAddingParameterType.parameterName;
                    DataRow new_type_row = tech_inspectorDataSet.types.NewRow();
                    new_type_row.SetField<string>(tech_inspectorDataSet.types.type_nameColumn, new_type_name);
                    tech_inspectorDataSet.types.Rows.Add(new_type_row);
                    typeSelectionComboBox.SelectedValue = new_type_row.Field<int>(tech_inspectorDataSet.types.type_idColumn);
                    chooseTypeButton_Click(typeSelectionComboBox, new EventArgs());
                }
            }
        }

        private void chooseTypeButton_Click(object sender, EventArgs e)
        {
            if (typeSelectionComboBox.SelectedIndex > -1)
            {
                type_id = (int)typeSelectionComboBox.SelectedValue;
                configurationGroupBox.Enabled = true;
                attributesTableAdapter.FillByTypeID(tech_inspectorDataSet.attributes, type_id);
                typeNameTextBox.Text = typeSelectionComboBox.Text;
                tech_inspectorDataSet.attributes.type_idColumn.DefaultValue = type_id;
            }
        }

        private void removeTypeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити вибраний тип обладнання з бази даних? (Все обладнання даного типу буде видалено)", "Попередження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataRow row in tech_inspectorDataSet.attributes.Rows)
                {
                    row.Delete();
                }
                attributesTableAdapter.Update(tech_inspectorDataSet.attributes);
                tech_inspectorDataSet.attributes.AcceptChanges();
                tech_inspectorDataSet.types.FindBytype_id(type_id).Delete();
                typesTableAdapter.Update(tech_inspectorDataSet.types);
                tech_inspectorDataSet.types.AcceptChanges();

                typeNameTextBox.Text = String.Empty;
                configurationGroupBox.Enabled = false;
            }
        }

        private void abortChangesButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте відхилити зміни?", "Попередження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tech_inspectorDataSet.attributes.RejectChanges();
                typeNameTextBox.Text = tech_inspectorDataSet.types.FindBytype_id(type_id).type_name;
            }
        }


        private void DeviceTemplateEditor_Load(object sender, EventArgs e)
        {
            this.typesTableAdapter.Fill(this.tech_inspectorDataSet.types);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void instructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this,
                    System.IO.Path.GetFullPath(Properties.Settings.Default.HelpPath));
            }
            catch (Exception err)
            {
                MessageBox.Show("Виникла помилка\n" + err.Message, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^c");
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^x");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^v");
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTypeButton.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveChangesButton.PerformClick();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abortChangesButton.PerformClick();
        }

        private void видалитиТипToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeTypeButton.PerformClick();
        }
    }
}
