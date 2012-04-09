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
            AddDevice aaaa = new AddDevice() ;
            aaaa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubSystemSelection childForm = new SubSystemSelection();
            childForm.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
            childForm.Show();
            Hide();
        }

        void childForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
