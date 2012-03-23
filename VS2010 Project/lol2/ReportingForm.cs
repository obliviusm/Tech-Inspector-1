using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace lol2
{
    public partial class ReportingForm : Form
    {
        private Object oDocument; 

        public ReportingForm()
        {
            InitializeComponent();
            
        }

        private void ReportingForm_Load(object sender, EventArgs e)
        {
            docTypesComboBox.SelectedIndex = 0;
        }

        private void docTypesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Path.GetFullPath("DATA\\samples\\"+docTypesComboBox.Text+".mht"));
        }
    }
}
