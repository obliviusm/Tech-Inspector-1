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
        private int user_id;
        public EditUser(int id)
        {
            InitializeComponent();
            user_id = id;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {

        }
    }
}
