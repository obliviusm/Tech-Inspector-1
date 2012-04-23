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
    public partial class EditUser : Form
    {
        public int user_id;
        public bool pass_excepted = false;
        public bool old_pass_excepted = false;
        public EditUser(int id)
        {
            InitializeComponent();
            user_id = id;
        }

        private void EditUsercs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_inspectorDataSet1.users". При необходимости она может быть перемещена или удалена.
           // this.usersTableAdapter.Fill(this.tech_inspectorDataSet.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_inspectorDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.tech_inspectorDataSet.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_inspectorDataSet.roles". При необходимости она может быть перемещена или удалена.
            this.rolesTableAdapter.Fill(this.tech_inspectorDataSet.roles);
            //дістаємо обраного юзера
            this.usersTableAdapter.FillBy(this.tech_inspectorDataSet.users, user_id);

            //заповнюємо поля
            //userNameTextBox.Text = tech_inspectorDataSet.users[0].user_name;
            rolesComboBox.SelectedValue = tech_inspectorDataSet.users[0].role_id;
        }
        private string EmptyFields()
        {
            string result = "\n";
            if (userNameTextBox.Text == "") result += "\tЛогін\n";
            return result;
        }
        private void addUserButton_Click(object sender, EventArgs e)
        {
            string emptyFields = EmptyFields();
            if (emptyFields.Length > 2)
                MessageBox.Show("Наступні обов'язкові поля не були заповнені :" + emptyFields, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if ((pass_excepted == false && old_pass_excepted == true) ||
                (pass_excepted == true && old_pass_excepted == false))
            {
                MessageBox.Show("Перевірте пароль", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pass_excepted == true && old_pass_excepted == true)
                    tech_inspectorDataSet.users[0].password =
                        GeneralContentManager.EncodePass(passwordTextBox.Text);
                try
                {
                    usersBindingSource.EndEdit();
                    usersTableAdapter.Update(tech_inspectorDataSet.users);
                    tech_inspectorDataSet.users.AcceptChanges();
                    MessageBox.Show("Зміни успішно внесено!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (System.Data.ConstraintException)
                {
                    MessageBox.Show("Профіль з таким логіном вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void oldPassTextBox_Leave(object sender, EventArgs e)
        {
            if ( oldPassTextBox.Text != "")
                VerifyOldPassword();
        }
        public void VerifyOldPassword()
        {
            if (GeneralContentManager.EncodePass(oldPassTextBox.Text) == tech_inspectorDataSet.users[0].password)
            {
                old_pass_excepted = true;
                verifyOldPassLabel.Text = "Пароль вірний";
                verifyOldPassLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                old_pass_excepted = false;
                verifyOldPassLabel.Text = "Пароль невірний";
                verifyOldPassLabel.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != "" && repeatPasswordTextBox.Text != "")
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
