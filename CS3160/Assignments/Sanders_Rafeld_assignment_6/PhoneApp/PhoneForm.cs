using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneApp
{
    public partial class PhoneForm : Form
    {

        public Phone mNewPhone;
        Phone temp = new Phone();
        public PhoneForm()
        {
            InitializeComponent();
            mNewPhone = new Phone();
            this.Text = "New Phone";
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public PhoneForm(Phone pn)
        {
            InitializeComponent();
            mNewPhone = new Phone();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Edit Phone Information";
            txtName.Text = pn.Name;
            txtPhone.Text = pn.PhoneNumber;
            txtName.SelectAll();
        }

        /// <summary>
        /// Trys to create a new contact untill the validation is satisfied with the 
        /// user input
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            try
            {
                while (mNewPhone.ValidName == false || mNewPhone.ValidPhoneNumber == false)
                {
                    mNewPhone = new Phone(this.txtName.Text, this.txtPhone.Text);
                }
            }
            catch (Exception exc)
            {
                // If there's an error, just return to the form and allow 
                // the user to fix the problem.
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            
            this.Close();
        }

        /// <summary>
        /// Stops the creation of the new contact
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            mNewPhone = null;

            this.Close();
        }

        /// <summary>
        /// Tests the user input untill is satified or canceled
        /// </summary>
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            TextBox tbName = (TextBox)sender;

            temp.Name = tbName.Text;

            if (!temp.ValidName)
            {
                ErrorProvider.SetError(txtName, "Invalid Name");
                txtPhone.Enabled = false;
                txtName.Focus();
                txtName.SelectAll();
                
            }
            
            if (temp.ValidName)
            {
                txtPhone.Enabled = true;
                ErrorProvider.SetError(tbName, "");
            }
            
        }

        /// <summary>
        /// Tests the user input untill is satisfied or canceled
        /// </summary>
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            Phone temp = new Phone();

            TextBox tbPhone = (TextBox)sender;

            temp.PhoneNumber = tbPhone.Text;

            if (!temp.ValidPhoneNumber)
            {
                ErrorProvider.SetError(txtPhone, "Invalid Phone Number");
                txtName.Enabled = false;
                txtPhone.Focus();
                txtPhone.SelectAll();
            }
            
            if (temp.ValidPhoneNumber)
            {
                txtName.Enabled = true;
                ErrorProvider.SetError(tbPhone, "");
            }


        }
    }
    
}
