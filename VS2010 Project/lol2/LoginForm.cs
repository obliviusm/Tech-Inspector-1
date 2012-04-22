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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //Login.user_role = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SaveUser()
        {
            usersTableAdapter.FillByLoginAndPass(this.tech_inspectorDataSet.users,
                userNameTextBox.Text, passwordTextBox.Text);
            if (tech_inspectorDataSet.users.Rows.Count > 0)
            {
                Login.set(tech_inspectorDataSet.users[0]);

                MessageBox.Show("Ви ввійшли як: " + Login.getUserName() +
                "\nПрава доступу: " + Login.getRoleName(), "Повідомлення", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                SubSystemSelection childForm = new SubSystemSelection();
                childForm.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
                childForm.Show();
                Hide();
            }
            else
                MessageBox.Show("Невірний логін або пароль", "Помилка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveUser();
        }

        void childForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}
