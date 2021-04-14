using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeasurementFormSEED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayCustomerForm();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveCustomerForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            ToolStripButton tb = (ToolStripButton)sender;

            displayCustomerForm();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ToolStripButton tb = (ToolStripButton)sender;
            saveCustomerForm();
        }

        private void displayCustomerForm()
        {
            MeasurementForm cf = new MeasurementForm();
            cf.MdiParent = this;
            cf.Show();
        }

        private void saveCustomerForm()
        {
            MeasurementForm cf = (MeasurementForm)ActiveMdiChild;
            if (cf.checkMeasureUnit())
            {

            }
            else
            {

            }
        }
    }
}
