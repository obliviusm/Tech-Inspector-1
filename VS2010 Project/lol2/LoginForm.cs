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
        private Font normalFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Regular))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Font silverFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SaveUser()
        {
            usersTableAdapter.FillByLoginAndPass(this.tech_inspectorDataSet.users,
                userNameTextBox.Text, GeneralContentManager.EncodePass(passwordTextBox.Text));
            if (tech_inspectorDataSet.users.Rows.Count > 0)
            {
                //зберегти увійшовшого
                GeneralContentManager.set(tech_inspectorDataSet.users[0]);
                
                MessageBox.Show("Ви ввійшли як: " + GeneralContentManager.getUserName() +
                "\nПрава доступу: " + GeneralContentManager.getRoleName(), "Повідомлення", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //перейти в головну форму
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

        private void userNameTextBox_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Tag == "noPas")
            {
                userNameTextBox.Tag = "enteringPas";
                userNameTextBox.Text = "";
                this.userNameTextBox.Font = normalFont;
                this.userNameTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void userNameTextBox_Leave(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                userNameTextBox.Text = "Введіть...";
                userNameTextBox.Tag = "noPas";
                this.userNameTextBox.Font = silverFont;
                this.userNameTextBox.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (userNameTextBox.Tag == "noPas")
            {
                userNameTextBox.Tag = "enteringPas";
                this.userNameTextBox.Font = normalFont;
                this.userNameTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Tag == "noPas")
            {
                passwordTextBox.Tag = "enteringPas";
                this.passwordTextBox.Font = normalFont;
                this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Tag == "noPas")
            {
                passwordTextBox.Tag = "enteringPas";
                passwordTextBox.Text = "";
                this.passwordTextBox.Font = normalFont;
                this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Введіть...";
                passwordTextBox.Tag = "noPas";
                this.passwordTextBox.Font = silverFont;
                this.passwordTextBox.ForeColor = System.Drawing.Color.Silver;
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }
    }
}
