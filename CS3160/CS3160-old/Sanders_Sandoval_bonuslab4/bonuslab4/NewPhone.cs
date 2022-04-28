using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bonuslab4
{
    public partial class NewPhone : Form
    {
        public Phone newPhone;


        public NewPhone()
        {
            InitializeComponent();
        }

        // This form is also part of the presentation tier. It is
        // displayed to allow the user to enter information for a
        //new phone number. 
        /// 

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            try
            {
                newPhone = new Phone(this.txtName.Text, this.txtPhone.Text);
            }
            catch (Exception exc)
            {
                // If there's an error, just return to the form and allow
                // the user to fix the problem.
                //
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK; this.Close();

        }
    }
}
