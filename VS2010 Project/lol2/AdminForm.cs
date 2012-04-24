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

        private void refresh()
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
        private void editUser()
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
        private void addUser()
        {
            AddUser childFormAddUser = new AddUser();
            childFormAddUser.ShowDialog();
            this.user_listTableAdapter.Fill(this.tech_inspectorDataSet.user_list);
        }
        private void deleteUser()
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
                    this.user_listTableAdapter.DeleteByUserId(id);
                    this.user_listTableAdapter.Update(this.tech_inspectorDataSet.user_list);
                }
                this.user_listTableAdapter.Fill(this.tech_inspectorDataSet.user_list);
                MessageBox.Show("Видалено записів: " + delrows.Count, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tech_inspectorDataSet.equipment_shortinfo.AcceptChanges();
            }
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();   
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            addUser();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            editUser();
        }

        private void refreshStripMenuItem_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editUser();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUser();
        }

        private void deleteUserStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveControl != null && ActiveControl.Text != "")
                Clipboard.SetText(ActiveControl.Text);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveControl != null && ActiveControl.Text != "")
            {
                Clipboard.SetText(ActiveControl.Text);
                ActiveControl.Text = "";
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveControl != null && Clipboard.GetText() != null)
                ActiveControl.Text += Clipboard.GetText();
        }

    }
}
