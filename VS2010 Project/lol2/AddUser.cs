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
    public partial class AddUser : Form
    {
        public bool pass_excepted = false;
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_inspectorDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.tech_inspectorDataSet.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_inspectorDataSet.roles". При необходимости она может быть перемещена или удалена.
            this.rolesTableAdapter.Fill(this.tech_inspectorDataSet.roles);
            // сортує, обирає "користувач" в rolesComboBox
            rolesBindingSource.Sort = "role_name DESC";
            rolesComboBox.SelectedValue = rolesComboBox.Items.Count;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {     
            string emptyFields = EmptyFields();
            if (emptyFields.Length > 2)
                MessageBox.Show("Наступні обов'язкові поля не були заповнені :" + emptyFields, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (pass_excepted == false)
            {
                MessageBox.Show("Перевірте пароль", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                try
                {
                    //ЗБЕРІГАЄ юзера
                    DataRow userDataRow = tech_inspectorDataSet.users.NewRow();
                    userDataRow[tech_inspectorDataSet.users.user_nameColumn] = userNameTextBox.Text;
                    userDataRow[tech_inspectorDataSet.users.role_idColumn] = rolesComboBox.SelectedIndex + 1;
                    userDataRow[tech_inspectorDataSet.users.passwordColumn] = Login.EncodePass( passwordTextBox.Text );
                    usersBindingSource.EndEdit();
                    tech_inspectorDataSet.users.Rows.Add(userDataRow);
                    int q = usersTableAdapter.Update(tech_inspectorDataSet.users);
                    tech_inspectorDataSet.users.AcceptChanges();
                    if (q > 0)
                        MessageBox.Show("Зміни збережено", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (System.Data.ConstraintException)
                {
                    MessageBox.Show("Профіль з таким логіном вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string EmptyFields()
        {
            string result = "\n";
            if (userNameTextBox.Text == "") result += "\tЛогін\n";
            if (passwordTextBox.Text == "") result += "\tПароль\n";
            if (rolesComboBox.Text == "") result += "\tТПрава\n";
            return result;
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if( passwordTextBox.Text != "" && repeatPasswordTextBox.Text != "")
                VerifyPassword();
        }

        private void repeatPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != "" && repeatPasswordTextBox.Text != "")
                VerifyPassword();
        }
        private void VerifyPassword()
        {
            if (passwordTextBox.Text == repeatPasswordTextBox.Text)
            {
                verifyPasswordLabel.Text = "Паролі співпадають";
                verifyPasswordLabel.ForeColor = System.Drawing.Color.Green;
                pass_excepted = true;
            }
            else
            {
                verifyPasswordLabel.Text = "Паролі не співпадають";
                verifyPasswordLabel.ForeColor = System.Drawing.Color.Red;
                pass_excepted = false;
            }
        }
        
    }
}
