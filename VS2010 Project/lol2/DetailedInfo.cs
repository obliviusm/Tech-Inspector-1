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
    public partial class DetailedInfo : Form
    {
        private int equipment_id { get; set; }
        public DetailedInfo(int id)
        {
            InitializeComponent();
            this.equipment_id = id;
        }

        private void DetailedInfo_Load(object sender, EventArgs e)
        {
            this.attributes_listTableAdapter.FillByID(tech_inspectorDataSet.attributes_list, equipment_id);
            this.statesTableAdapter.Fill(this.tech_inspectorDataSet.states);
            this.locationsTableAdapter.Fill(this.tech_inspectorDataSet.locations);
            this.typesTableAdapter.Fill(this.tech_inspectorDataSet.types);
            this.equipmentsTableAdapter.FillByID(this.tech_inspectorDataSet.equipments, equipment_id);
            DataRow equipment_info = tech_inspectorDataSet.equipments[0];
            type_idTextBox.Text = equipment_info.GetParentRow(tech_inspectorDataSet.equipments.ParentRelations["fk_Equipments_Types"])[tech_inspectorDataSet.types.type_nameColumn].ToString();
            location_idTextBox.Text = equipment_info.GetParentRow(tech_inspectorDataSet.equipments.ParentRelations["fk_Equipments_Locations1"])[tech_inspectorDataSet.locations.location_nameColumn].ToString();
            state_idTextBox.Text = equipment_info.GetParentRow(tech_inspectorDataSet.equipments.ParentRelations["fk_Equipments_States1"])[tech_inspectorDataSet.states.state_nameColumn].ToString();
        }

        private void histotyButton_Click(object sender, EventArgs e)
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
