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
    public partial class InfoViewer : Form
    {
        public InfoViewer()
        {
            InitializeComponent();
        }

        private void новийФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDevice childFormAddDevice = new AddDevice();
            childFormAddDevice.ShowDialog();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void редагуванняШаблонівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceTemplateEditor childFormDeviceTemplateEditor = new DeviceTemplateEditor();
            childFormDeviceTemplateEditor.Show();
        }

        private void deleteDeviceButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити виділене обладнання з БД ?", "Увага",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                //TODO: Remove from DB
            }
        }

        private void addDeviceButton_Click(object sender, EventArgs e)
        {
            AddDevice childFormAddDevice = new AddDevice();
            childFormAddDevice.ShowDialog();
        }
    }
}
