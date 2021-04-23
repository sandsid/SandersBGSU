using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        // This (app) refers to the object that contains the application
        // logic.
        private PhoneApp mApp;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mApp = new PhoneApp();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.  This will generate the Closing event
            // to write out the data.
            this.Close();
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the phone number for the selected name.

            if (lstNames.SelectedIndex > 0)
                this.txtPhone.Text = ((Phone)this.lstNames.SelectedItem).PhoneNumberDisplay;

            if (this.lstNames.Items.Count < 1)
            {
                modifyMenuItem.Enabled = false;
                removeMenuItem.Enabled = false;
                saveAsMenuItem.Enabled = false;
                txtPhone.Text = "";
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // This is called whenever the main form is closed
            // and causes the file to be written.
            if (!Program.mErrorFlag && mApp != null) mApp.WritePhones();
        }

        private void insertMenuItem_Click(object sender, EventArgs e)
        {
            // Try to add a new phone number to the list
            try
            {
                PhoneForm frm = new PhoneForm();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    mApp.NewPhone(frm.mNewPhone);
                    this.lstNames.Items.Add(frm.mNewPhone);
                    this.lstNames.SelectedIndex = 0;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            // Close the form.  This will generate the Closing event
            // to write out the data.
            if (!Program.mErrorFlag && mApp != null) mApp.WritePhones();
            this.Close();
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            mApp.WritePhones();
        }

        private void mergeMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList phones;
            string fileName = "";
            Program.mErrorFlag = false;

            // Set the filter for the open file dialog
            this.dlgOpenFile.Filter = DataAccess.FileFilter;

            // Get the name of the input file
            if (this.dlgOpenFile.ShowDialog() == DialogResult.OK)
                fileName = this.dlgOpenFile.FileName;
            else
            {
                Program.mErrorFlag = true;
                this.Close();
            }
            phones = mApp.ReadPhones(fileName);

            // Add each phone in the array list to the list box
            foreach (Phone p in phones)
                this.lstNames.Items.Add(p);
            if (this.lstNames.Items.Count > 0)
            {
                this.lstNames.SelectedIndex = 0;
                this.txtPhone.Text = ((Phone)this.lstNames.SelectedItem).PhoneNumberDisplay;
            }



            modifyMenuItem.Enabled = true;
            removeMenuItem.Enabled = true;
            saveAsMenuItem.Enabled = true;
        }

        private void removeMenuItem_Click(object sender, EventArgs e)
        {
            int i = this.lstNames.SelectedIndex;
            DialogResult result = MessageBox.Show("Are you sure you want to remove this Phone Number?", 
                            "Confirmation", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.lstNames.Items.RemoveAt(i);
                if (this.lstNames.Items.Count > 0)
                    this.lstNames.SelectedIndex = i;
            }

        }

        private void modifyMenuItem_Click(object sender, EventArgs e)
        {
            //
            //open a new phone, with selected data
            //remove old phone add new to the list and select it
            PhoneForm frm = new PhoneForm((Phone)this.lstNames.SelectedItem);
            int i = this.lstNames.SelectedIndex;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.lstNames.Items.RemoveAt(i);
                mApp.NewPhone(frm.mNewPhone);

                this.lstNames.Items.Insert(i, frm.mNewPhone);
                this.lstNames.SelectedIndex = i;

                //this.lstNames.Items.Add(frm.mNewPhone);
                //this.lstNames.SelectedIndex = this.lstNames.Items.Count-1;
            }

        }
    }
}
