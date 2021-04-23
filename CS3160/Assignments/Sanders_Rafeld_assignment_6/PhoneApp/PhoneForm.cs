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

        public PhoneForm()
        {
            InitializeComponent();
            this.Text = "New Phone";
        }

        public PhoneForm(Phone pn)
        {
            InitializeComponent();
            this.Text = "Edit Phone Information";
            txtName.Text = pn.Name;
            txtPhone.Text = pn.PhoneNumber;
            txtName.SelectAll();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                mNewPhone = new Phone(this.txtName.Text, this.txtPhone.Text);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mNewPhone = null;
            this.Close();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            Phone temp = new Phone();

            TextBox tbName = (TextBox)sender;

            //temp.Name = tbName.Text;

            //if (!temp.ValidName)
            //{
            //    ErrorProvider.SetError(tbName, "Invalid Name");
            //    tbName.SelectAll();
            //}
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            Phone temp = new Phone();

            TextBox tbPhone = (TextBox)sender;

            temp.PhoneNumber = tbPhone.Text;

            if (!temp.ValidPhoneNumber)
            {
                ErrorProvider.SetError(tbPhone, "Invalid Phone Number");
                tbPhone.SelectAll();
            }
        }
    }
    
}
