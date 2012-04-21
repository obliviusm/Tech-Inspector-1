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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_inspectorDataSet.roles". При необходимости она может быть перемещена или удалена.
            this.rolesTableAdapter.Fill(this.tech_inspectorDataSet.roles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_inspectorDataSet.user_list". При необходимости она может быть перемещена или удалена.
            this.user_listTableAdapter.Fill(this.tech_inspectorDataSet.user_list);

            // завантажує права в rolesComboBox
            rolesBindingSource.Sort = "role_name ASC";
            tech_inspectorDataSet.roles.Rows.Add(new object[] { 0, "Всі" });
            rolesComboBox.SelectedValue = 0;
            
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string filter_str = "";
            // фільруємо по правах
            if ((int)rolesComboBox.SelectedValue != 0)
                filter_str += "role_id = " + rolesComboBox.SelectedValue + " AND ";
            //фільтруємо по логіну
            if (String.IsNullOrWhiteSpace(userNameTextBox.Text))
                filter_str += "true";
            else
                filter_str += "user_name = \'" + userNameTextBox.Text + "\'";

            userlistBindingSource.Filter = filter_str;
        }

    }
}
