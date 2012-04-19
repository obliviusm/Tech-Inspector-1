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
    public partial class History : Form
    {
        private int equipmet_id { get; set; }
        public History(int id)
        {
            InitializeComponent();
            equipmet_id = id;
        }

        private void History_Load(object sender, EventArgs e)
        {
            equimpent_idTextBox.Text = equipmet_id.ToString();
            history_listTableAdapter.FillByID(tech_inspectorDataSet.history_list, equipmet_id);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
