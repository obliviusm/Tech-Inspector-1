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
    public partial class EditEquipment : Form
    {
        private int equipment_id { get; set; }
        public EditEquipment(int id)
        {
            InitializeComponent();
            equipment_id = id;
        }

        private void EditEquipment_Load(object sender, EventArgs e)
        {
            addNewRowToHistory();

            this.action_typesTableAdapter.Fill(this.tech_inspectorDataSet.action_types);
            this.attributes_listTableAdapter.FillByID(this.tech_inspectorDataSet.attributes_list, equipment_id);
            this.locationsTableAdapter.Fill(this.tech_inspectorDataSet.locations);
            this.statesTableAdapter.Fill(this.tech_inspectorDataSet.states);
            this.typesTableAdapter.Fill(this.tech_inspectorDataSet.types);
            this.equipmentsTableAdapter.FillByID(this.tech_inspectorDataSet.equipments, equipment_id);

            typeSelectionComboBox.SelectedValue = tech_inspectorDataSet.equipments[0].type_id;
            stateSelectComboBox.SelectedValue = tech_inspectorDataSet.equipments[0].state_id;
            locationComboBox.SelectedValue = tech_inspectorDataSet.equipments[0].location_id;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                attributeslistBindingSource.EndEdit();
                attributes_listTableAdapter.Update(tech_inspectorDataSet.attributes_list);
                tech_inspectorDataSet.attributes_list.AcceptChanges();
                equipmentsBindingSource.EndEdit();
                equipmentsTableAdapter.Update(tech_inspectorDataSet.equipments);
                tech_inspectorDataSet.equipments.AcceptChanges();
                MessageBox.Show("Зміни успішно внесено!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Обладнання з таким інвентарним номером вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

        }

        private void addLogButton_Click(object sender, EventArgs e)
        {
            historyBindingSource.EndEdit();
            int q = historyTableAdapter.Update(tech_inspectorDataSet.history);
            switch ((int)actionTypeComboBox.SelectedValue)
            {
                case 1: //Передача на ремонт
                    {
                        repairingCheckBox.Checked = true;
                        break; 
                    }
                case 2: //Завершення ремонту
                    {
                        repairingCheckBox.Checked = false;
                        break;
                    }
                case 3: //Вихід з ладу
                    {
                        stateSelectComboBox.SelectedValue = 3;
                        break;
                    }
                case 4: //Часткова несправність
                    {
                        stateSelectComboBox.SelectedValue = 2;
                        break;
                    }
                case 5: //Відновлення роботи
                    {
                        stateSelectComboBox.SelectedValue = 1;
                        break;
                    }
                case 6: //Тимчасове перенесення
                    {
                        movedCheckBox.Checked = true;
                        AddingString childFormAddingParameterType = new AddingString("Введіть тимчасове місце розташування");
                        childFormAddingParameterType.ShowDialog();
                        if (!String.IsNullOrWhiteSpace(childFormAddingParameterType.parameterName))
                        {
                            movedPlaceTextBox.Text = childFormAddingParameterType.parameterName;
                        }
                        break;
                    }
                case 7: //Повернення на постійне місце
                    {
                        movedCheckBox.Checked = false;
                        movedPlaceTextBox.Text = String.Empty;
                        break;
                    }
            }
            equipmentsBindingSource.EndEdit();
            equipmentsTableAdapter.Update(tech_inspectorDataSet.equipments);
            tech_inspectorDataSet.equipments.AcceptChanges();
            addNewRowToHistory();
        }
        private void addNewRowToHistory()
        {
            tech_inspectorDataSet.history.Rows.Clear();
            DataRow row = tech_inspectorDataSet.history.NewRow();
            row.SetField<int>(tech_inspectorDataSet.history.equipment_idColumn, equipment_id);
            row.SetField<int>(tech_inspectorDataSet.history.action_type_idColumn, 1);
            row.SetField<DateTime>(tech_inspectorDataSet.history.dateColumn, DateTime.Now);
            tech_inspectorDataSet.history.Rows.Add(row);
        }

        private void showHistoryButton_Click(object sender, EventArgs e)
        {
            History h = new History(equipment_id);
            h.ShowDialog();
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveChangesButton.PerformClick();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showHistoryButton.PerformClick();
        }
    }
}
