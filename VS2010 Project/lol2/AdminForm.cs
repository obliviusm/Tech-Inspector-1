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

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUser childFormAddUser = new AddUser();
            childFormAddUser.ShowDialog();
            this.user_listTableAdapter.Fill(this.tech_inspectorDataSet.user_list);
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити виділені профілі з БД ?", "Увага",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                List<int> delrows = new List<int>();
                for (int i = 0; i < userTable.SelectedCells.Count; ++i)
                {
                    int index = userTable.SelectedCells[i].RowIndex;
                    if (!delrows.Contains(index))
                        delrows.Add(index);
                }
                for (int i = 0; i < delrows.Count; ++i)
                {
                    int id = (int)userTable.Rows[delrows[i]].Cells["userid"].Value;
                    tech_inspectorDataSet.user_list.FindByuser_id(id).Delete();
                    int q = this.user_listTableAdapter.Update(this.tech_inspectorDataSet.user_list);
                    MessageBox.Show("Видалено записів: " + q, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tech_inspectorDataSet.equipment_shortinfo.AcceptChanges();
                }
            }
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            List<int> showrows = new List<int>();
            for (int i = 0; i < userTable.SelectedCells.Count; ++i)
            {
                int index = userTable.SelectedCells[i].RowIndex;
                if (!showrows.Contains(index))
                    showrows.Add(index);
            }
            for (int i = 0; i < showrows.Count; ++i)
            {
                int id = (int)userTable.Rows[showrows[i]].Cells["userid"].Value;
                EditUser edit_form = new EditUser(id);
                edit_form.ShowDialog();
            }
            this.user_listTableAdapter.Fill(this.tech_inspectorDataSet.user_list);
        }

    }
}
