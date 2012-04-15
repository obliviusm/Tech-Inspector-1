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
            attributeslistBindingSource.EndEdit();
            attributes_listTableAdapter.Update(tech_inspectorDataSet.attributes_list);
            tech_inspectorDataSet.attributes_list.AcceptChanges();
            equipmentsBindingSource.EndEdit();
            equipmentsTableAdapter.Update(tech_inspectorDataSet.equipments);
            tech_inspectorDataSet.equipments.AcceptChanges();
            MessageBox.Show("Зміни успішно внесено!", "Повідомлення", MessageBoxButtons.OK,MessageBoxIcon.Information);
            Close();
        }
    }
}
