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
        public bool pass_excepted = true;
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
            VerifyPassword();

            string emptyFields = EmptyFields();
            if (emptyFields.Length > 2)
                MessageBox.Show("Наступні обов'язкові поля не були заповнені :" + emptyFields, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (pass_excepted == false )
            {
                MessageBox.Show("Паролі не співпадають", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pass_excepted == true && passwordTextBox.Text != "" 
                    && repeatPasswordTextBox.Text != "")
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
    }
}
