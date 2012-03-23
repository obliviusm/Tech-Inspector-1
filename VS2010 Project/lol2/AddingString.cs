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
    public partial class AddingString : Form
    {
        public string parameterName = null;

        public AddingString(string windowName)
        {
            InitializeComponent();
            Text = windowName;
        }

        private void cancelOperationButton_Click(object sender, EventArgs e)
        {
            parameterName = null;
            Close();
        }

        private void addParameterButton_Click(object sender, EventArgs e)
        {
            parameterName = parameterTextBox.Text;
            Close();
        }
    }
}
